using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_PNP_DEVICE_DRIVER
    /// </summary>
    [WmiClass(Name = "SMS_G_System_PNP_DEVICE_DRIVER")]
    public class SmsGSystemPnpDeviceDriver
    {
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ClassGuid
        /// </summary>
        public string ClassGuid { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Service
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
