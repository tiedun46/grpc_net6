using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebServiceRoleResource
    {
        public Guid Oid { get; set; }
        public Guid FwebServiceRole { get; set; }
        public Guid FwebServiceResource { get; set; }
        public int IPermission { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TWebServiceResource FwebServiceResourceNavigation { get; set; } = null!;
        public virtual TWebServiceRole FwebServiceRoleNavigation { get; set; } = null!;
    }
}
