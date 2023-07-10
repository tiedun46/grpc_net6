using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TProductUpdateTProduct
    {
        public Guid? TProducts { get; set; }
        public Guid? TProductUpdates { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TProductUpdate? TProductUpdatesNavigation { get; set; }
        public virtual TProduct? TProductsNavigation { get; set; }
    }
}
