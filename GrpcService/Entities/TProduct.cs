using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TProduct
    {
        public TProduct()
        {
            TClasses = new HashSet<TClass>();
            TLicenses = new HashSet<TLicense>();
            TProductUpdateTProducts = new HashSet<TProductUpdateTProduct>();
            TWebServiceResources = new HashSet<TWebServiceResource>();
            TWebServiceRoles = new HashSet<TWebServiceRole>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductFullName { get; set; }
        public string? ProductDescription { get; set; }
        public Guid? Fbranch { get; set; }
        public string? ProductVersion { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? ProductCode { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? MachineId { get; set; }
        public bool? StatisticsEnabled { get; set; }

        public virtual TBranch? FbranchNavigation { get; set; }
        public virtual ICollection<TClass> TClasses { get; set; }
        public virtual ICollection<TLicense> TLicenses { get; set; }
        public virtual ICollection<TProductUpdateTProduct> TProductUpdateTProducts { get; set; }
        public virtual ICollection<TWebServiceResource> TWebServiceResources { get; set; }
        public virtual ICollection<TWebServiceRole> TWebServiceRoles { get; set; }
    }
}
