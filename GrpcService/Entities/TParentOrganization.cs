using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TParentOrganization
    {
        public TParentOrganization()
        {
            TOrganizations = new HashSet<TOrganization>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public string? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? FadministrativeUnit { get; set; }

        public virtual TAdministrativeUnit? FadministrativeUnitNavigation { get; set; }
        public virtual ICollection<TOrganization> TOrganizations { get; set; }
    }
}
