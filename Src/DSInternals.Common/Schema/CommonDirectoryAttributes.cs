﻿using System;

namespace DSInternals.Common.Schema
{
    public static class CommonDirectoryAttributes
    {
        public const string AdminCount = "adminCount";
        public const string AttributeId = "attributeID";
        public const string AttributeOmSyntax = "oMSyntax";
        public const string AttributeSyntax = "attributeSyntax";
        public const string CommonName = "cn";
        public const string CurrentValue = "currentValue";
        public const string Description = "description";
        public const string DisplayName = "displayName";
        public const string DistinguishedName = "distinguishedName";
        public const string DnsHostName = "dNSHostName";
        public const string DnsRoot = "dnsRoot";
        public const string FunctionalLevel = "msDS-Behavior-Version";
        public const string NamingContextName = "nCName";
        public const string DomainComponent = "dc";
        public const string DomainNamingContexts = "msDS-HasDomainNCs";
        public const string GivenName = "givenName";
        public const string GovernsId = "governsID";
        public const string InstanceType = "instanceType";
        public const string InternalId = "msDS-IntId";
        public const string InvocationId = "invocationId";
        public const string IsDefunct = "isDefunct";
        public const string IsDeleted = "isDeleted";
        public const string IsInGlobalCatalog = "isMemberOfPartialAttributeSet";
        public const string IsSingleValued = "isSingleValued";
        public const string KdsCreationTime = "msKds-CreateTime";
        public const string KdsDomainController = "msKds-DomainID";
        public const string KdsKdfAlgorithmId = "msKds-KDFAlgorithmID";
        public const string KdsKdfParameters = "msKds-KDFParam";
        public const string KdsSecretAgreementPrivateKeyLength = "msKds-PrivateKeyLength";
        public const string KdsSecretAgreementPublicKeyLength = "msKds-PublicKeyLength";
        public const string KdsRootKeyData = "msKds-RootKeyData";
        public const string KdsSecretAgreementAlgorithmId = "msKds-SecretAgreementAlgorithmID";
        public const string KdsSecretAgreementParameters = "msKds-SecretAgreementParam";
        public const string KdsEffectiveTime = "msKds-UseStartTime";
        public const string KdsVersion = "msKds-Version";
        public const string KeyCredentialLink = "msDS-KeyCredentialLink";
        public const string LastLogon = "lastLogon";
        public const string LastLogonTimestamp = "lastLogonTimestamp";
        public const string LdapDisplayName = "lDAPDisplayName";
        public const string LinkId = "linkID";
        public const string LMHash = "dBCSPwd";
        public const string LMHashHistory = "lmPwdHistory";
        public const string LockoutTime = "lockoutTime";
        public const string ManagedPasswordId = "msDS-ManagedPasswordId";
        public const string ManagedPasswordPreviousId = "msDS-ManagedPasswordPreviousId";
        public const string ManagedPasswordInterval = "msDS-ManagedPasswordInterval";
        public const string MasterNamingContexts = "msDS-hasMasterNCs";
        public const string Member = "member";
        public const string NetBIOSName = "nETBIOSName";
        public const string NTHash = "unicodePwd";
        public const string NTHashHistory = "ntPwdHistory";
        public const string ObjectCategory = "objectCategory";
        public const string ObjectClass = "objectClass";
        public const string ObjectGuid = "objectGUID";
        public const string ObjectSid = "objectSid";
        public const string OperatingSystemName = "operatingSystem";
        public const string Options = "options";
        public const string OrganizationalUnitName = "ou";
        public const string PasswordLastSet = "pwdLastSet";
        public const string PEKList = "pekList";
        public const string PEKChangeInterval = "pekKeyChangeInterval";
        public const string PKIRoamingTimeStamp = "msPKIRoamingTimeStamp";
        public const string PKIDPAPIMasterKeys = "msPKIDPAPIMasterKeys";
        public const string PKIAccountCredentials = "msPKIAccountCredentials";
        public const string PrefixMap = "prefixMap";
        public const string PrimaryGroupId = "primaryGroupID";
        public const string ReplicationPropertyMetaData = "replPropertyMetaData";
        public const string RangeLower = "rangeLower";
        public const string RangeUpper = "rangeUpper";
        public const string RDN = "name";
        public const string SamAccountName = "sAMAccountName";
        public const string SamAccountType = "sAMAccountType";
        public const string SchemaLocation = "dMDLocation";
        public const string SearchFlags = "searchFlags";
        public const string SecurityDescriptor = "nTSecurityDescriptor";
        public const string SecurityIdentifier = "securityIdentifier";
        public const string ServerReference = "serverReference";
        public const string SchemaIdGuid = "schemaIDGUID";
        public const string ServicePrincipalName = "servicePrincipalName";
        public const string SidHistory = "sIDHistory";
        public const string SupplementalCredentials = "supplementalCredentials";
        public const string SupportedEncryptionTypes = "msDS-SupportedEncryptionTypes";
        public const string Surname = "sn";
        public const string SystemFlags = "systemFlags";
        public const string SystemOnly = "systemOnly";
        public const string UnixUserPassword = "unixUserPassword";
        public const string UserAccountControl = "userAccountControl";
        public const string UserPrincipalName = "userPrincipalName";
        public const string USNCreated = "uSNCreated";
        public const string USNChanged = "uSNChanged";
        public const string WhenCreated = "whenCreated";
        public const string WhenChanged = "whenChanged";
        public const string Initials = "initials";
        public const string EmployeeId = "employeeID";
        public const string EmployeeNumber = "employeeNumber";
        public const string Office = "physicalDeliveryOfficeName";
        public const string TelephoneNumber = "telephoneNumber";
        public const string EmailAddress = "mail";
        public const string HomePhone = "homePhone";
        public const string PagerNumber = "pager";
        public const string Mobile = "mobile";
        public const string IpPhone = "ipPhone";
        public const string WebPage = "wWWHomePage";
        public const string JobTitle = "title";
        public const string Department = "department";
        public const string Company = "company";
        public const string Manager = "manager";
        public const string HomeDirectory = "homeDirectory";
        public const string HomeDrive = "homeDrive";
        public const string UnixHomeDirectory = "unixHomeDirectory";
        public const string ProfilePath = "profilePath";
        public const string ScriptPath = "scriptPath";
        public const string State = "st";
        public const string Street = "streetAddress";
        public const string PostOfficeBox = "postOfficeBox";
        public const string City = "l";
        public const string Country = "c";
        public const string Comment = "info";
        public const string PostalCode = "postalCode";
        public const string ManagedBy = "managedBy";
        public const string Location = "location";
        public const string OperatingSystemVersion = "operatingSystemVersion";
        public const string OperatingSystemHotfix = "operatingSystemHotfix";
        public const string OperatingSystemServicePack = "operatingSystemServicePack";
        public const string TPMOwnerInformation = "msTPM-OwnerInformation";
        public const string TPMInformationForComputer = "msTPM-TpmInformationForComputer";
        public const string TrustAttributes = "trustAttributes";
        public const string TrustAuthIncoming = "trustAuthIncoming";
        public const string TrustAuthOutgoing = "trustAuthOutgoing";
        public const string TrustDirection = "trustDirection";
        public const string TrustPartner = "trustPartner";
        public const string TrustPartnerFlatName = "flatName";
        public const string TrustPosixOffset = "trustPosixOffset";
        public const string TrustType = "trustType";
        public const string FVEKeyPackage = "msFVE-KeyPackage";
        public const string FVEVolumeGuid = "msFVE-VolumeGuid";
        public const string FVERecoveryGuid = "msFVE-RecoveryGuid";
        public const string FVERecoveryPassword = "msFVE-RecoveryPassword";
        public const string LAPSPassword = "ms-Mcs-AdmPwd";
        public const string LAPSPasswordOid = "1.2.840.113556.1.8000.2554.50051.45980.28112.18903.35903.6685103.1224907.2.1";
        public const string LAPSPasswordExpirationTime = "ms-Mcs-AdmPwdExpirationTime";
        public const string LAPSPasswordExpirationTimeOid = "1.2.840.113556.1.8000.2554.50051.45980.28112.18903.35903.6685103.1224907.2.2";
        public const string WindowsLapsPasswordExpirationTime = "msLAPS-PasswordExpirationTime";
        public const string WindowsLapsPasswordExpirationTimeOid = "1.2.840.113556.1.6.44.1.1";
        public const string WindowsLapsPassword = "msLAPS-Password";
        public const string WindowsLapsPasswordOid = "1.2.840.113556.1.6.44.1.2";
        public const string WindowsLapsEncryptedPassword = "msLAPS-EncryptedPassword";
        public const string WindowsLapsEncryptedPasswordOid = "1.2.840.113556.1.6.44.1.3";
        public const string WindowsLapsEncryptedPasswordHistory = "msLAPS-EncryptedPasswordHistory";
        public const string WindowsLapsEncryptedPasswordHistoryOid = "1.2.840.113556.1.6.44.1.4";
        public const string WindowsLapsEncryptedDsrmPassword = "msLAPS-EncryptedDSRMPassword";
        public const string WindowsLapsEncryptedDsrmPasswordOid = "1.2.840.113556.1.6.44.1.5";
        public const string WindowsLapsEncryptedDsrmPasswordHistory = "msLAPS-EncryptedDSRMPasswordHistory";
        public const string WindowsLapsEncryptedDsrmPasswordHistoryOid = "1.2.840.113556.1.6.44.1.6";
        public const string WindowsLapsCurrentPasswordVersion = "msLAPS-CurrentPasswordVersion";
        public const string WindowsLapsCurrentPasswordVersionOid = "1.2.840.113556.1.6.44.1.7";
        public const string DnsRecord = "dnsRecord";
        public const string DnsTombstoned = "dNSTombstoned";

        public static AttributeType? Translate(string ldapDisplayName)
        {
            if (ldapDisplayName == null) throw new ArgumentNullException(nameof(ldapDisplayName));

            return ldapDisplayName switch
            {
                AdminCount => AttributeType.AdminCount,
                AttributeId => AttributeType.AttributeId,
                AttributeOmSyntax => AttributeType.OMSyntax,
                AttributeSyntax => AttributeType.AttributeSyntax,
                CommonName => AttributeType.CommonName,
                CurrentValue => AttributeType.CurrentValue,
                Description => AttributeType.Description,
                DisplayName => AttributeType.DisplayName,
                DistinguishedName => AttributeType.DistinguishedName,
                DnsHostName => AttributeType.DnsHostName,
                DnsRoot => AttributeType.DnsRoot,
                FunctionalLevel => AttributeType.FunctionalLevel,
                NamingContextName => AttributeType.NamingContextName,
                DomainComponent => AttributeType.DomainComponent,
                DomainNamingContexts => AttributeType.DomainNamingContexts,
                GivenName => AttributeType.GivenName,
                GovernsId => AttributeType.GovernsId,
                InstanceType => AttributeType.InstanceType,
                InternalId => AttributeType.InternalId,
                InvocationId => AttributeType.InvocationId,
                IsDefunct => AttributeType.IsDefunct,
                IsDeleted => AttributeType.IsDeleted,
                IsInGlobalCatalog => AttributeType.IsInGlobalCatalog,
                IsSingleValued => AttributeType.IsSingleValued,
                KdsCreationTime => AttributeType.KdsCreationTime,
                KdsDomainController => AttributeType.KdsDomainController,
                KdsKdfAlgorithmId => AttributeType.KdsKdfAlgorithmId,
                KdsKdfParameters => AttributeType.KdsKdfParameters,
                KdsSecretAgreementPrivateKeyLength => AttributeType.KdsSecretAgreementPrivateKeyLength,
                KdsSecretAgreementPublicKeyLength => AttributeType.KdsSecretAgreementPublicKeyLength,
                KdsRootKeyData => AttributeType.KdsRootKeyData,
                KdsSecretAgreementAlgorithmId => AttributeType.KdsSecretAgreementAlgorithmId,
                KdsSecretAgreementParameters => AttributeType.KdsSecretAgreementParameters,
                KdsEffectiveTime => AttributeType.KdsEffectiveTime,
                KdsVersion => AttributeType.KdsVersion,
                KeyCredentialLink => AttributeType.KeyCredentialLink,
                LastLogon => AttributeType.LastLogon,
                LastLogonTimestamp => AttributeType.LastLogonTimestamp,
                LdapDisplayName => AttributeType.LdapDisplayName,
                LinkId => AttributeType.LinkId,
                LMHash => AttributeType.LMHash,
                LMHashHistory => AttributeType.LMHashHistory,
                LockoutTime => AttributeType.LockoutTime,
                ManagedPasswordId => AttributeType.ManagedPasswordId,
                ManagedPasswordPreviousId => AttributeType.ManagedPasswordPreviousId,
                ManagedPasswordInterval => AttributeType.ManagedPasswordInterval,
                MasterNamingContexts => AttributeType.MasterNamingContexts,
                Member => AttributeType.Member,
                RDN => AttributeType.RDN,
                NetBIOSName => AttributeType.NetBIOSName,
                NTHash => AttributeType.NTHash,
                NTHashHistory => AttributeType.NTHashHistory,
                ObjectCategory => AttributeType.ObjectCategory,
                ObjectClass => AttributeType.ObjectClass,
                ObjectGuid => AttributeType.ObjectGuid,
                ObjectSid => AttributeType.ObjectSid,
                OperatingSystemName => AttributeType.OperatingSystemName,
                Options => AttributeType.Options,
                OrganizationalUnitName => AttributeType.OrganizationalUnitName,
                PasswordLastSet => AttributeType.PasswordLastSet,
                PEKList => AttributeType.PEKList,
                PEKChangeInterval => AttributeType.PEKChangeInterval,
                PKIRoamingTimeStamp => AttributeType.PKIRoamingTimeStamp,
                PKIDPAPIMasterKeys => AttributeType.PKIDPAPIMasterKeys,
                PKIAccountCredentials => AttributeType.PKIAccountCredentials,
                PrefixMap => AttributeType.PrefixMap,
                PrimaryGroupId => AttributeType.PrimaryGroupId,
                RangeLower => AttributeType.RangeLower,
                RangeUpper => AttributeType.RangeUpper,
                ReplicationPropertyMetaData => AttributeType.ReplicationPropertyMetaData,
                SamAccountName => AttributeType.SamAccountName,
                SamAccountType => AttributeType.SamAccountType,
                SchemaLocation => AttributeType.SchemaLocation,
                SearchFlags => AttributeType.SearchFlags,
                SecurityDescriptor => AttributeType.SecurityDescriptor,
                ServerReference => AttributeType.ServerReference,
                SchemaIdGuid => AttributeType.SchemaIdGuid,
                ServicePrincipalName => AttributeType.ServicePrincipalName,
                SidHistory => AttributeType.SidHistory,
                SupplementalCredentials => AttributeType.SupplementalCredentials,
                SupportedEncryptionTypes => AttributeType.SupportedEncryptionTypes,
                Surname => AttributeType.Surname,
                SystemFlags => AttributeType.SystemFlags,
                SystemOnly => AttributeType.SystemOnly,
                UnixUserPassword => AttributeType.UnixUserPassword,
                UserAccountControl => AttributeType.UserAccountControl,
                UserPrincipalName => AttributeType.UserPrincipalName,
                USNCreated => AttributeType.USNCreated,
                USNChanged => AttributeType.USNChanged,
                WhenCreated => AttributeType.WhenCreated,
                WhenChanged => AttributeType.WhenChanged,
                Initials => AttributeType.Initials,
                EmployeeId => AttributeType.EmployeeId,
                EmployeeNumber => AttributeType.EmployeeNumber,
                Office => AttributeType.Office,
                TelephoneNumber => AttributeType.TelephoneNumber,
                EmailAddress => AttributeType.EmailAddresses,
                HomePhone => AttributeType.PhoneHomePrimary,
                PagerNumber => AttributeType.PhonePagerPrimary,
                Mobile => AttributeType.PhoneMobilePrimary,
                IpPhone => AttributeType.PhoneIpPrimary,
                WebPage => AttributeType.WebPage,
                JobTitle => AttributeType.JobTitle,
                Department => AttributeType.Department,
                Company => AttributeType.Company,
                Manager => AttributeType.Manager,
                HomeDirectory => AttributeType.HomeDirectory,
                HomeDrive => AttributeType.HomeDrive,
                UnixHomeDirectory => AttributeType.UnixHomeDirectory,
                ProfilePath => AttributeType.ProfilePath,
                ScriptPath => AttributeType.ScriptPath,
                State => AttributeType.State,
                Street => AttributeType.Street,
                PostOfficeBox => AttributeType.PostOfficeBox,
                City => AttributeType.City,
                Country => AttributeType.Country,
                Comment => AttributeType.Comment,
                PostalCode => AttributeType.PostalCode,
                ManagedBy => AttributeType.ManagedBy,
                Location => AttributeType.Location,
                OperatingSystemVersion => AttributeType.OperatingSystemVersion,
                OperatingSystemHotfix => AttributeType.OperatingSystemHotfix,
                OperatingSystemServicePack => AttributeType.OperatingSystemServicePack,
                TPMOwnerInformation => AttributeType.TPMOwnerInformation,
                TPMInformationForComputer => AttributeType.TPMInformationForComputer,
                FVEKeyPackage => AttributeType.FVEKeyPackage,
                FVEVolumeGuid => AttributeType.FVEVolumeGuid,
                FVERecoveryGuid => AttributeType.FVERecoveryGuid,
                FVERecoveryPassword => AttributeType.FVERecoveryPassword,
                DnsRecord => AttributeType.DnsRecord,
                DnsTombstoned => AttributeType.DnsTombstoned,
                _ => null
            };
        }
    }
}
