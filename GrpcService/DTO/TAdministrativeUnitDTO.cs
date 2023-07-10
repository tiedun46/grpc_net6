using GrpcService.Entities;
using System;
using System.Collections.Generic;

namespace GrpcService.DTO
{
    public partial class TAdministrativeUnitDTO
    {
        public TAdministrativeUnitDTO()
        {
            InverseIddonViChaNavigation = new HashSet<TAdministrativeUnit>();
            TCustomers = new HashSet<TCustomer>();
            TOrganizations = new HashSet<TOrganization>();
            TParentOrganizations = new HashSet<TParentOrganization>();
        }

        public Guid Oid { get; set; }
        public string? MaTinh { get; set; }
        public string? MaHuyen { get; set; }
        public string? MaXa { get; set; }
        public string? MaThon { get; set; }
        public string? Ten { get; set; }
        public int? Cap { get; set; }
        public string? MaVung { get; set; }
        public int? SoLuong { get; set; }
        public string? MaDonVi { get; set; }
        public string? MaDonViCha { get; set; }
        public Guid? IddonViCha { get; set; }
        public DateTime? DInputDate { get; set; }
        public DateTime? DValidUntilDate { get; set; }
        public int? HuyenDao { get; set; }
        public int? HuyenNgheo { get; set; }
        public string? MachineId { get; set; }
        public string? MaVungKinhTeTrongDiem { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? PhanLoaiHuyen { get; set; }
        public int? PhanLoaiXa { get; set; }
        public bool? Thieu { get; set; }
        public int? ThonDacBietKhoKhan { get; set; }
        public int? XaBaiNgang { get; set; }
        public int? XaBienGioi { get; set; }
        public int? XaDao { get; set; }
        public int? XaMienNuiKv1 { get; set; }
        public int? XaMienNuiKv2 { get; set; }
        public int? XaMienNuiKv3 { get; set; }

        public virtual TAdministrativeUnit? IddonViChaNavigation { get; set; }
        public virtual ICollection<TAdministrativeUnit> InverseIddonViChaNavigation { get; set; }
        public virtual ICollection<TCustomer> TCustomers { get; set; }
        public virtual ICollection<TOrganization> TOrganizations { get; set; }
        public virtual ICollection<TParentOrganization> TParentOrganizations { get; set; }
    }
}
