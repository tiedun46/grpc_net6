using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebCredentialsAuthorization
    {
        public Guid Oid { get; set; }
        public Guid? WebCredentials { get; set; }
        public Guid? WebDeployments { get; set; }
        public int? OptimisticLockField { get; set; }
        public string? Roles { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }

        public virtual TWebCredential? WebCredentialsNavigation { get; set; }
        public virtual TLicense? WebDeploymentsNavigation { get; set; }
    }
}
