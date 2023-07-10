using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TCustomer
    {
        public TCustomer()
        {
            InverseFsuperiorNavigation = new HashSet<TCustomer>();
            TClassesCustomers = new HashSet<TClassesCustomer>();
            TContacts = new HashSet<TContact>();
            TCustomerAttrs = new HashSet<TCustomerAttr>();
            TLicenses = new HashSet<TLicense>();
            TWebCredentials = new HashSet<TWebCredential>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public Guid? Forganization { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? MachineId { get; set; }
        public string? CredentialFormat { get; set; }
        public Guid? Fsuperior { get; set; }
        public Guid MaskedOid { get; set; }
        public Guid? FadministrativeUnit { get; set; }
        public string? CpublicPrivate { get; set; }
        public string? CmanagementLevel { get; set; }
        public string? CorganizationLevel { get; set; }
        public string? CmanagementRole { get; set; }

        public virtual TAdministrativeUnit? FadministrativeUnitNavigation { get; set; }
        public virtual TOrganization? ForganizationNavigation { get; set; }
        public virtual TCustomer? FsuperiorNavigation { get; set; }
        public virtual ICollection<TCustomer> InverseFsuperiorNavigation { get; set; }
        public virtual ICollection<TClassesCustomer> TClassesCustomers { get; set; }
        public virtual ICollection<TContact> TContacts { get; set; }
        public virtual ICollection<TCustomerAttr> TCustomerAttrs { get; set; }
        public virtual ICollection<TLicense> TLicenses { get; set; }
        public virtual ICollection<TWebCredential> TWebCredentials { get; set; }
    }
}
