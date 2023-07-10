using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TActivityLog
    {
        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public string? LogType { get; set; }
        public string? LogAction { get; set; }
        public int? LogValue { get; set; }
        public string? LogDescription { get; set; }
        public string? MetaSessionId { get; set; }
        public string? MetaUsername { get; set; }
        public string? MetaDbversion { get; set; }
        public string? MetaFileVersion { get; set; }
        public string? MetaIpaddress { get; set; }
        public string? MetaOsversion { get; set; }
        public string? MetaCpuname { get; set; }
        public string? MetaSystemType { get; set; }
        public string? MetaRamSize { get; set; }
        public string? MetaNetVersion { get; set; }
        public Guid? MetaLicenseId { get; set; }
    }
}
