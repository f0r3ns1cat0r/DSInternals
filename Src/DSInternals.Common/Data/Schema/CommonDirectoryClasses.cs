﻿namespace DSInternals.Common.Data
{
    public static class CommonDirectoryClasses
    {
        public const string Secret = "secret";
        public const string User = "user";
        public const string ClassSchema = "classSchema";
        public const int ClassSchemaId = 196621;
        public const string AttributeSchema = "attributeSchema";
        public const int AttributeSchemaId = 196622;
        public const string Schema = "dMD";
        public const string KdsRootKey = "msKds-ProvRootKey";
        public const string GroupManagedServiceAccount = "msDS-GroupManagedServiceAccount";
        public const string DelegatedManagedServiceAccount = "msDS-DelegatedManagedServiceAccount";
        public const string FVERecoveryInformation = "msFVE-RecoveryInformation";
        public const string DnsZone = "dnsZone";
        public const string DnsNode = "dnsNode";

        /// <summary>
        /// NTDS Settings of a writable DC.
        /// </summary>
        public const string NtdsSettings = "nTDSDSA";

        /// <summary>
        /// NTDS Settings of a RODC.
        /// </summary>
        public const string NtdsSettingsRO = "nTDSDSARO";
    }
}
