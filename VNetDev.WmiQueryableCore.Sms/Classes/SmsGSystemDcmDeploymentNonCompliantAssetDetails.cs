using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_SYSTEM_DCMDeploymentNonCompliantAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_G_SYSTEM_DCMDeploymentNonCompliantAssetDetails")]
    public class SmsGSystemDcmDeploymentNonCompliantAssetDetails
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property BL_ID
        /// </summary>
        [WmiProperty(Name = "BL_ID")]
        public uint BlId { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Rule_ID
        /// </summary>
        [WmiProperty(Name = "Rule_ID")]
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property RuleSubState
        /// </summary>
        public uint RuleSubState { get; set; }
    }
}
