using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_WLAN
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_WLAN")]
    public class SmsGSystemDeviceWlan
    {
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public uint Enabled { get; set; }
        /// <summary>
        /// WMI Property EthernetMAC
        /// </summary>
        public string EthernetMac { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property WiFiMAC
        /// </summary>
        public string WiFiMac { get; set; }
    }
}
