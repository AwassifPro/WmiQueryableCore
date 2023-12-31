﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Management.Infrastructure;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.Cim.Extensions;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.Cim
{
    internal class ObjectReader<T> : IEnumerable<T>
    {
        private Enumerator _enumerator;

        public ObjectReader(IEnumerable<CimInstance> collection, CimConnection connection, IWqlQuery queryObject,
            Type outType = null)
        {
            _enumerator = new Enumerator(collection, connection, queryObject, outType);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var e = _enumerator;
            if (e == null)
            {
                throw new InvalidOperationException("Cannot enumerate more than once");
            }

            _enumerator = null;
            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator : IEnumerator<T>
        {
            private readonly IEnumerator<CimInstance> _collection;
            private readonly CimConnection _connection;
            private readonly IWqlQuery _queryObject;
            private readonly Type _outType;

            private readonly ConstantExpression _connectionExpression;

            public T Current { get; private set; }

            internal Enumerator(IEnumerable<CimInstance> collection, CimConnection connection, IWqlQuery queryObject,
                Type outType)
            {
                if (queryObject == null && outType == null)
                {
                    throw new ArgumentException(
                        $"Both {nameof(queryObject)} and {nameof(outType)} cannot be null at the same time.");
                }

                _connection = connection;
                _collection = collection.GetEnumerator();
                _queryObject = queryObject;
                _connectionExpression = Expression.Constant(connection);
                _outType = outType;
            }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (!_collection.MoveNext())
                {
                    return false;
                }

                var currentObject = Activator.CreateInstance(_outType ?? _queryObject.WqlQueryResultType);

                _connection.RegisterInstance(currentObject, _collection.Current);

                var currentObjectType = currentObject.GetType();
                _collection.Current.AssignObjectValues(currentObject);

                var members = currentObjectType
                    .GetFields(BindingFlags.Instance | BindingFlags.Public)
                    .Where(f => f.FieldType.IsSubclassOf(typeof(Delegate)))
                    .ToArray();

                var invokeCimMethodInfo = _connection
                    .GetType()
                    .GetMethod(
                        nameof(CimConnection.InvokeCimMethod),
                        BindingFlags.Instance | BindingFlags.NonPublic);

                if (invokeCimMethodInfo == null)
                {
                    throw new InvalidOperationException(_connection.GetType().Name +
                                                        " does not support cim method invoke operation.");
                }

                var classInstanceExpression = Expression.Constant(currentObject);
                var parametersDictionaryType = typeof(Dictionary<string, object>);
                var addToDictionaryMethod = parametersDictionaryType.GetMethod(nameof(Dictionary<string, object>.Add));
                if (addToDictionaryMethod == null)
                {
                    throw new InvalidOperationException(parametersDictionaryType.Name + " does not support list init!");
                }

                foreach (var member in members)
                {
                    var invokeMethod = member.FieldType.GetMethod("Invoke");

                    if (invokeMethod == null)
                    {
                        continue;
                    }

                    var wmiMethodName = member.GetCustomAttributes<WmiMethodAttribute>().Select(a => a.Name)
                                            .FirstOrDefault(a => !string.IsNullOrWhiteSpace(a)) ??
                                        member.Name;

                    var invokeMethodParameters = invokeMethod.GetParameters();

                    var newDictionaryExpression = Expression.New(parametersDictionaryType);
                    var lambdaParameters = new ParameterExpression[invokeMethodParameters.Length];
                    var listInitParameters = new ElementInit[invokeMethodParameters.Length];

                    for (var i = 0; i < invokeMethodParameters.Length; i++)
                    {
                        var parameter = invokeMethodParameters[i];
                        lambdaParameters[i] = Expression.Parameter(parameter.ParameterType, parameter.Name);

                        listInitParameters[i] = Expression.ElementInit(addToDictionaryMethod,
                            Expression.Constant(parameter.Name),
                            Expression.Convert(lambdaParameters[i], typeof(object)));
                    }

                    var invokeCimMethodCallExpression = Expression.Call(
                        _connectionExpression,
                        invokeCimMethodInfo.MakeGenericMethod(invokeMethod.ReturnType),
                        classInstanceExpression,
                        Expression.Constant(wmiMethodName),
                        Expression.ListInit(newDictionaryExpression, listInitParameters));

                    var lambdaExpression = Expression.Lambda(member.FieldType, invokeCimMethodCallExpression,
                        lambdaParameters);

                    member.SetValue(currentObject, lambdaExpression.Compile());
                }

                Current = (T) (_queryObject == null ? currentObject : _queryObject.ProceedDelegates(currentObject));

                _connection.ObjectTracker.TrackObject(Current);

                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException("Reset is not supported!");
            }

            public void Dispose()
            {
                _collection.Dispose();
            }
        }
    }
}