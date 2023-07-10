using System;
using System.Collections.Generic;

namespace GrpcService.Entities
{
    public partial class TWebCredential
    {
        public TWebCredential()
        {
            TWebCredentialsAuthorizations = new HashSet<TWebCredentialsAuthorization>();
        }

        public Guid Oid { get; set; }
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; }
        public int Type { get; set; }
        public Guid Fcustomer { get; set; }
        public string Fullname { get; set; } = null!;
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public string? MachineId { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string? ActivationCode { get; set; }
        public DateTime? DLastActivityDate { get; set; }
        public DateTime? DLastPasswordChangedDate { get; set; }

        public virtual TCustomer FcustomerNavigation { get; set; } = null!;
        public virtual ICollection<TWebCredentialsAuthorization> TWebCredentialsAuthorizations { get; set; }
    }
}
