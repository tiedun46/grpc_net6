using System;
using System.Collections.Generic;

namespace GrpcService.DTO
{
    public partial class TActivityLogDTO
    {
        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public string? LogType { get; set; }
        public string? LogAction { get; set; }
        public int? LogValue { get; set; }
        public string? LogDescription { get; set; }
        public string? MetaIpaddress { get; set; }
        public Guid? MetaLicenseId { get; set; }
    }
}
