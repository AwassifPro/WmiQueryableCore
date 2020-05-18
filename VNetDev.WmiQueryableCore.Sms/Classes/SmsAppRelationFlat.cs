using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppRelation_Flat
    /// </summary>
    [WmiClass(Name = "SMS_AppRelation_Flat")]
    public class SmsAppRelationFlat
    {
        /// <summary>
        /// WMI Property FromApplicationCIID
        /// </summary>
        public uint FromApplicationCiid { get; set; }
        /// <summary>
        /// WMI Property FromDeploymentTypeCIID
        /// </summary>
        public uint FromDeploymentTypeCiid { get; set; }
        /// <summary>
        /// WMI Property Level
        /// </summary>
        public uint Level { get; set; }
        /// <summary>
        /// WMI Property RelationType
        /// </summary>
        public uint RelationType { get; set; }
        /// <summary>
        /// WMI Property ToApplicationCIID
        /// </summary>
        public uint ToApplicationCiid { get; set; }
        /// <summary>
        /// WMI Property ToDeploymentTypeCIID
        /// </summary>
        public uint ToDeploymentTypeCiid { get; set; }
    }
}
