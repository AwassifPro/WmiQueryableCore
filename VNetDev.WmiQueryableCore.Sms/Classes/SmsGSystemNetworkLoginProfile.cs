using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_NETWORK_LOGIN_PROFILE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_NETWORK_LOGIN_PROFILE")]
    public class SmsGSystemNetworkLoginProfile
    {
        /// <summary>
        /// WMI Property AccountExpires
        /// </summary>
        public DateTime AccountExpires { get; set; }
        /// <summary>
        /// WMI Property AuthorizationFlags
        /// </summary>
        public uint AuthorizationFlags { get; set; }
        /// <summary>
        /// WMI Property BadPasswordCount
        /// </summary>
        public uint BadPasswordCount { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property CodePage
        /// </summary>
        public uint CodePage { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property CountryCode
        /// </summary>
        public uint CountryCode { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property FullName
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HomeDirectory
        /// </summary>
        public string HomeDirectory { get; set; }
        /// <summary>
        /// WMI Property HomeDirectoryDrive
        /// </summary>
        public string HomeDirectoryDrive { get; set; }
        /// <summary>
        /// WMI Property LastLogoff
        /// </summary>
        public DateTime LastLogoff { get; set; }
        /// <summary>
        /// WMI Property LastLogon
        /// </summary>
        public DateTime LastLogon { get; set; }
        /// <summary>
        /// WMI Property LogonHours
        /// </summary>
        public string LogonHours { get; set; }
        /// <summary>
        /// WMI Property LogonServer
        /// </summary>
        public string LogonServer { get; set; }
        /// <summary>
        /// WMI Property MaximumStorage
        /// </summary>
        public ulong MaximumStorage { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfLogons
        /// </summary>
        public uint NumberOfLogons { get; set; }
        /// <summary>
        /// WMI Property Parameters
        /// </summary>
        public string Parameters { get; set; }
        /// <summary>
        /// WMI Property PasswordAge
        /// </summary>
        public string PasswordAge { get; set; }
        /// <summary>
        /// WMI Property PasswordExpires
        /// </summary>
        public DateTime PasswordExpires { get; set; }
        /// <summary>
        /// WMI Property PrimaryGroupId
        /// </summary>
        public uint PrimaryGroupId { get; set; }
        /// <summary>
        /// WMI Property Privileges
        /// </summary>
        public uint Privileges { get; set; }
        /// <summary>
        /// WMI Property Profile
        /// </summary>
        public string Profile { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property ScriptPath
        /// </summary>
        public string ScriptPath { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UnitsPerWeek
        /// </summary>
        public uint UnitsPerWeek { get; set; }
        /// <summary>
        /// WMI Property UserComment
        /// </summary>
        public string UserComment { get; set; }
        /// <summary>
        /// WMI Property UserId
        /// </summary>
        public uint UserId { get; set; }
        /// <summary>
        /// WMI Property UserType
        /// </summary>
        public string UserType { get; set; }
        /// <summary>
        /// WMI Property Workstations
        /// </summary>
        public string Workstations { get; set; }
    }
}
