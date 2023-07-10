using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TProductUpdate
    {
        public TProductUpdate()
        {
            TProductUpdateTProducts = new HashSet<TProductUpdateTProduct>();
        }

        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public string? UpdateName { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateType { get; set; }
        public string? Version { get; set; }
        public string? DownloadUrl { get; set; }
        public bool? Downloadable { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? Enabled { get; set; }
        public bool? IsTesting { get; set; }
        public string? TechnicalDescription { get; set; }
        public string? VoidReason { get; set; }

        public virtual ICollection<TProductUpdateTProduct> TProductUpdateTProducts { get; set; }
    }
}
