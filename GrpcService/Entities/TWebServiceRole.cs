using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebServiceRole
    {
        public TWebServiceRole()
        {
            TWebServiceRoleResources = new HashSet<TWebServiceRoleResource>();
        }

        public Guid Oid { get; set; }
        public string WebServiceRoleId { get; set; } = null!;
        public string WebServiceRoleName { get; set; } = null!;
        public string? MachineId { get; set; }
        public Guid Fproduct { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TProduct FproductNavigation { get; set; } = null!;
        public virtual ICollection<TWebServiceRoleResource> TWebServiceRoleResources { get; set; }
    }
}
