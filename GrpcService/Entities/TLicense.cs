using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TLicense
    {
        public TLicense()
        {
            TLicenseRelationshipChildLicenses = new HashSet<TLicenseRelationship>();
            TLicenseRelationshipParentLicenses = new HashSet<TLicenseRelationship>();
            TWebCredentialsAuthorizations = new HashSet<TWebCredentialsAuthorization>();
            TWebDeploymentUrls = new HashSet<TWebDeploymentUrl>();
        }

        public Guid Oid { get; set; }
        public string? LicenseId { get; set; }
        public string? LicenseCode { get; set; }
        public string? LicenseName { get; set; }
        public DateTime? GiveDate { get; set; }
        public Guid Fcustomer { get; set; }
        public Guid Fproduct { get; set; }
        public string? KeyDescription { get; set; }
        public int? LicenseType { get; set; }
        public string? Orgname { get; set; }
        public string? Orgname2 { get; set; }
        public bool? IsActivated { get; set; }
        public bool IsDemo { get; set; }
        public bool IsNsmoduleGranted { get; set; }
        public bool IsDtmoduleGranted { get; set; }
        public bool IsWebModuleGranted { get; set; }
        public string? MachineId { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public int? OptimisticLockField { get; set; }
        public Guid MaskedOid { get; set; }
        public DateTime? DLastActivityDate { get; set; }
        public string? SLastSeenDbversion { get; set; }
        public string? SLastSeenFileVersion { get; set; }
        public string? SLastSeenIpaddress { get; set; }
        public string? SLastSeenOsversion { get; set; }
        public string? SLastSeenCpuname { get; set; }
        public string? SLastSeenSystemType { get; set; }
        public string? SLastSeenRamSize { get; set; }
        public string? SLastSeenNetVersion { get; set; }

        public virtual TCustomer FcustomerNavigation { get; set; } = null!;
        public virtual TProduct FproductNavigation { get; set; } = null!;
        public virtual ICollection<TLicenseRelationship> TLicenseRelationshipChildLicenses { get; set; }
        public virtual ICollection<TLicenseRelationship> TLicenseRelationshipParentLicenses { get; set; }
        public virtual ICollection<TWebCredentialsAuthorization> TWebCredentialsAuthorizations { get; set; }
        public virtual ICollection<TWebDeploymentUrl> TWebDeploymentUrls { get; set; }
    }
}
