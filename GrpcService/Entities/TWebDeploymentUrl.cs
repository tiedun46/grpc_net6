using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebDeploymentUrl
    {
        public Guid Oid { get; set; }
        public string UrlAddress { get; set; } = null!;
        public Guid Flicense { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public int? OptimisticLockField { get; set; }
        public string? ServiceUrlAddress { get; set; }

        public virtual TLicense FlicenseNavigation { get; set; } = null!;
    }
}
