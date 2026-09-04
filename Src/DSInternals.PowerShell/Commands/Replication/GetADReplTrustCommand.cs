using System.Management.Automation;
using DSInternals.Common.Kerberos;

namespace DSInternals.PowerShell.Commands;

[Cmdlet(VerbsCommon.Get, "ADReplTrust")]
[OutputType(typeof(TrustedDomain))]
public class GetADReplTrustCommand : ADReplCommandBase
{
    [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    [Alias("TrustPartner", "TrustName")]
    public string Name
    {
        get;
        set;
    }

    protected override void ProcessRecord()
    {
        base.ProcessRecord();

        try
        {
            TrustedDomain trust = this.ReplicationClient.GetTrustedDomain(this.Name);
            this.WriteObject(trust);
        }
        catch (Exception ex)
        {
            // TODO: Produce exception-specific errors
            var error = new ErrorRecord(ex, "Replication_TrustNotFound", ErrorCategory.ObjectNotFound, this.Name);
            this.WriteError(error);
        }
    }
}
