using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CertificateInfo
    /// </summary>
    [WmiClass(Name = "SMS_CertificateInfo")]
    public class SmsCertificateInfo
    {
        /// <summary>
        /// WMI static method <c>BlockCertificate</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="blocked">WMI Property <c>Blocked</c> of type <c>bool</c>.</param>
        /// <param name="smsid">WMI Property <c>SMSID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate int BlockCertificateDelegate(WmiContext wmiContext, bool blocked = default, string smsid = default);
        /// <summary>
        /// WMI static method <c>BlockCertificate</c>.
        /// </summary>
        public static BlockCertificateDelegate BlockCertificate;
        
        /// <summary>
        /// WMI static method <c>RenewCertificate</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="smsid">WMI Property <c>SMSID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate int RenewCertificateDelegate(WmiContext wmiContext, string smsid = default);
        /// <summary>
        /// WMI static method <c>RenewCertificate</c>.
        /// </summary>
        public static RenewCertificateDelegate RenewCertificate;
        /// <summary>
        /// WMI Property Certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// WMI Property IsApproved
        /// </summary>
        public bool IsApproved { get; set; }
        /// <summary>
        /// WMI Property IsBlocked
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// WMI Property IssuedTo
        /// </summary>
        public string IssuedTo { get; set; }
        /// <summary>
        /// WMI Property KeyType
        /// </summary>
        public int KeyType { get; set; }
        /// <summary>
        /// WMI Property PublicKey
        /// </summary>
        public string PublicKey { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property ValidFrom
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// WMI Property ValidUntil
        /// </summary>
        public DateTime ValidUntil { get; set; }
    }
}
