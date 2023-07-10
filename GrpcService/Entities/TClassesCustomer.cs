using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TClassesCustomer
    {
        public Guid? Classes { get; set; }
        public Guid? Customers { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TClass? ClassesNavigation { get; set; }
        public virtual TCustomer? CustomersNavigation { get; set; }
    }
}
