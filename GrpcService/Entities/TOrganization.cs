using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TOrganization
    {
        public TOrganization()
        {
            TClasses = new HashSet<TClass>();
            TContacts = new HashSet<TContact>();
            TCustomers = new HashSet<TCustomer>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumber2 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? MachineId { get; set; }
        public Guid? FparentOrganization { get; set; }
        public Guid? FadministrativeUnit { get; set; }

        public virtual TAdministrativeUnit? FadministrativeUnitNavigation { get; set; }
        public virtual TParentOrganization? FparentOrganizationNavigation { get; set; }
        public virtual ICollection<TClass> TClasses { get; set; }
        public virtual ICollection<TContact> TContacts { get; set; }
        public virtual ICollection<TCustomer> TCustomers { get; set; }
    }
}
