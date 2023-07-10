using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebServiceResource
    {
        public TWebServiceResource()
        {
            TWebServiceRoleResources = new HashSet<TWebServiceRoleResource>();
        }

        public Guid Oid { get; set; }
        public string WebServiceResourceId { get; set; } = null!;
        public string WebServiceResourceName { get; set; } = null!;
        public string? MachineId { get; set; }
        public Guid Fproduct { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TProduct FproductNavigation { get; set; } = null!;
        public virtual ICollection<TWebServiceRoleResource> TWebServiceRoleResources { get; set; }
    }
}
