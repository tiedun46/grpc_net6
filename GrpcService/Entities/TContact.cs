using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TContact
    {
        public Guid Oid { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? ContactId { get; set; }
        public string? ContactName { get; set; }
        public Guid? Fcustomer { get; set; }
        public Guid? Forganization { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? ContactDescription { get; set; }
        public int? ContactType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? PhoneNumber1 { get; set; }
        public string? Address1 { get; set; }
        public string? MachineId { get; set; }

        public virtual TCustomer? FcustomerNavigation { get; set; }
        public virtual TOrganization? ForganizationNavigation { get; set; }
    }
}
