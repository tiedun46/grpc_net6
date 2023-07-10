using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TClass
    {
        public TClass()
        {
            TClassesCustomers = new HashSet<TClassesCustomer>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? ClassId { get; set; }
        public string? ClassName { get; set; }
        public Guid? Fproduct { get; set; }
        public Guid? Forganization { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ClassDescription { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ClassType { get; set; }
        public string? MachineId { get; set; }

        public virtual TOrganization? ForganizationNavigation { get; set; }
        public virtual TProduct? FproductNavigation { get; set; }
        public virtual ICollection<TClassesCustomer> TClassesCustomers { get; set; }
    }
}
