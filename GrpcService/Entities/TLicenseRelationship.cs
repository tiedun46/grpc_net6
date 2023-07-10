using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TLicenseRelationship
    {
        public Guid Oid { get; set; }
        public Guid ParentLicenseId { get; set; }
        public Guid ChildLicenseId { get; set; }
        public int IPermission { get; set; }
        public DateTime DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual TLicense ChildLicense { get; set; } = null!;
        public virtual TLicense ParentLicense { get; set; } = null!;
    }
}
