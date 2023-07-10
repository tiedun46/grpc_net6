using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TCustomerAttr
    {
        public Guid Oid { get; set; }
        public Guid Fcustomer { get; set; }
        public string AttrCode { get; set; } = null!;
        public string AttrValue { get; set; } = null!;
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual TCustomer FcustomerNavigation { get; set; } = null!;
    }
}
