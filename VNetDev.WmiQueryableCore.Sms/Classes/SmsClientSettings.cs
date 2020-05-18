using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientSettings
    /// </summary>
    [WmiClass(Name = "SMS_ClientSettings")]
    public class SmsClientSettings
    {
        /// <summary>
        /// WMI static method <c>CheckPortalUrl</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="portalUrl">WMI Property <c>PortalUrl</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate int CheckPortalUrlDelegate(WmiContext wmiContext, string portalUrl = default);
        /// <summary>
        /// WMI static method <c>CheckPortalUrl</c>.
        /// </summary>
        public static CheckPortalUrlDelegate CheckPortalUrl;
        /// <summary>
        /// WMI Property AgentConfigurations
        /// </summary>
        public ICollection<object> AgentConfigurations { get; set; }
        /// <summary>
        /// WMI Property AssignmentCount
        /// </summary>
        public uint AssignmentCount { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateModified
        /// </summary>
        public DateTime DateModified { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public uint FeatureType { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property SecuredScopeNames
        /// </summary>
        public ICollection<string> SecuredScopeNames { get; set; }
        /// <summary>
        /// WMI Property SettingsID
        /// </summary>
        public uint SettingsId { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
