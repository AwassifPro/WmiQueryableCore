using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_Variable
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_Variable")]
    public class SmsTaskSequenceVariable
    {
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
