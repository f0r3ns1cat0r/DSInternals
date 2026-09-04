---
external help file: DSInternals.PowerShell.dll-Help.xml
Module Name: DSInternals
online version: https://github.com/MichaelGrafnetter/DSInternals/blob/master/Documentation/PowerShell/Get-ADReplTrust.md
schema: 2.0.0
---

# Get-ADReplTrust

## SYNOPSIS
Reads a specific trust object from a domain controller through the MS-DRSR protocol.

## SYNTAX

```
Get-ADReplTrust -Name <String> -Server <String> [-Credential <PSCredential>] [<CommonParameters>]
```

## DESCRIPTION

Replicates a single trusted object from an Active Directory domain controller through the MS-DRSR protocol.
Use this cmdlet to fetch trust metadata and trust authentication secrets for a specific trust relationship.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-ADReplTrust -Server 'lon-dc1.contoso.com' -Name 'adatum.com'
```

Replicates the trust object named `adatum.com` from the current domain partition of the specified domain controller.

## PARAMETERS

### -Credential
Specifies a user account that has permission to perform this action. The default is the current user.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name of the trust object to retrieve.

```yaml
Type: String
Parameter Sets: (All)
Aliases: TrustPartner, TrustName

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Server
Specifies the target computer for the operation. Enter a fully qualified domain name (FQDN), a NetBIOS name, or an IP address. When the remote computer is in a different domain than the local computer, the fully qualified domain name is required.

```yaml
Type: String
Parameter Sets: (All)
Aliases: Host, DomainController, DC

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### DSInternals.Common.Kerberos.TrustedDomain

## NOTES

## RELATED LINKS

[Get-ADDBTrust](Get-ADDBTrust.md)
