using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ApplyDriverPackageAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ApplyDriverPackageAction")]
    public class SmsTaskSequenceApplyDriverPackageAction
    {
        /// <summary>
        /// WMI Property BootCriticalContentUniqueID
        /// </summary>
        public string BootCriticalContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property BootCriticalDriverID
        /// </summary>
        public string BootCriticalDriverId { get; set; }
        /// <summary>
        /// WMI Property BootCriticalHardwareComponent
        /// </summary>
        public string BootCriticalHardwareComponent { get; set; }
        /// <summary>
        /// WMI Property BootCriticalID
        /// </summary>
        public string BootCriticalId { get; set; }
        /// <summary>
        /// WMI Property BootCriticalINFFile
        /// </summary>
        public string BootCriticalInfFile { get; set; }
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DriverPackageID
        /// </summary>
        public string DriverPackageId { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Recurse
        /// </summary>
        public bool Recurse { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property UnsignedDriver
        /// </summary>
        public bool UnsignedDriver { get; set; }
    }
}
