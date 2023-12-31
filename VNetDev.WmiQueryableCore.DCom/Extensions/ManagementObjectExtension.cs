﻿using System;
using System.Linq;
using System.Management;
using System.Reflection;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.DCom.Extensions
{
    internal static class ManagementObjectExtension
    {
        internal static void AssignObjectValues(this ManagementObject managementObject, object objectInstance)
        {
            var currentObjectType = objectInstance.GetType();
            foreach (var property in currentObjectType.GetProperties())
            {
                if (currentObjectType.GetProperty(property.Name)?
                        .GetCustomAttribute<WmiIgnorePropertyAttribute>(false) != null)
                {
                    continue;
                }

                var objectPropertyAttribute = currentObjectType
                    .GetProperty(property.Name)?
                    .GetCustomAttribute<WmiPropertyAttribute>(false);

                var propertyName = objectPropertyAttribute?.Name ?? property.Name;
                property.SetValue(
                    objectInstance,
                    managementObject.GetWmiValue(property.PropertyType, propertyName));
            }
        }

        internal static T GetWmiValue<T>(this ManagementBaseObject wmiObject, string key) =>
            (T)GetWmiValue(wmiObject, typeof(T), key);

        internal static object GetWmiValue(this ManagementBaseObject wmiObject, Type type, string key) =>
            ManagementObjectTypeConverter.FromWmiType(type, wmiObject[key]);

        internal static void SetWmiValue(this ManagementObject wmiObject, string key, Type valueType, object value)
        {
            if (!valueType.IsValueType && valueType != typeof(string))
            {
                return;
            }

            wmiObject[key] = ManagementObjectTypeConverter.ToWmiType(value);
        }

        internal static string[] GetWmiObjectPropertyNames(this ManagementObject managementObject)
        {
            var result = Enumerable.Empty<string>();
            foreach (var objectProperty in managementObject.Properties)
            {
                result = result.Append(objectProperty.Name.ToLower());
            }

            return result.ToArray();
        }

        internal static void SetWmiValues(this ManagementBaseObject wmiObject, ObjectTracker objectTracker, object objectInstance)
        {
            if (!(wmiObject is ManagementObject managementObject))
            {
                return;
            }

            var currentObjectType = objectInstance.GetType();
            var availablePropertyNames = managementObject.GetWmiObjectPropertyNames();
            foreach (var property in currentObjectType.GetProperties())
            {
                if (!objectTracker.CheckPropertyChanged(objectInstance, property.Name))
                {
                    continue;
                }

                if (currentObjectType.GetProperty(property.Name)?
                        .GetCustomAttribute<WmiIgnorePropertyAttribute>(false) != null)
                {
                    continue;
                }

                var objectPropertyAttribute = currentObjectType
                    .GetProperty(property.Name)?
                    .GetCustomAttribute<WmiPropertyAttribute>(false);

                var propertyName = objectPropertyAttribute?.Name ?? property.Name;
                if (!availablePropertyNames.Contains(propertyName.ToLower()))
                {
                    continue;
                }

                try
                {
                    managementObject
                        .SetWmiValue(
                            propertyName,
                            property.PropertyType,
                            property.GetValue(objectInstance));
                }
                catch
                {
                    // ignored
                }
            }

            managementObject.Put();
            managementObject.Get();
            managementObject.AssignObjectValues(objectInstance);
            objectTracker.ResetTrackedObject(objectInstance);
        }
    }
}