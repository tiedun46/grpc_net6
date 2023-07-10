using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TBranch
    {
        public TBranch()
        {
            TProducts = new HashSet<TProduct>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchDescription { get; set; }
        public string? BranchFullName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? MachineId { get; set; }

        public virtual ICollection<TProduct> TProducts { get; set; }
    }
}
