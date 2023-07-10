using Grpc.Core;
using GrpcService.Entities;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using System;

namespace GrpcService.Services
{
    public class AdministrativeUnitService: AdministrativeUnit.AdministrativeUnitBase
    {
        public override Task<AdministrativeUnitList> GetList(Empty request, ServerCallContext context)
        {
            var _context = new IASMGRContext();
            var item1 = new AdministrativeUnitsModel {
            Oid = Guid.NewGuid().ToString(),
            MaTinh = "2",
            MaHuyen = "3",
            MaXa = "4",
            MaThon = "5",
            Ten = "Ten",
            Cap = 7,
            MaVung = "8",
            SoLuong = 9,
            MaDonVi = "10",
            MaDonViCha = "11",
            IDDonViCha = "12",
            DInputDate = "04/06/2001",
            DValidUntilDate = "14",
            HuyenDao = 15,
            HuyenNgheo = 16,
            MachineID = "17",
            MaVungKinhTeTrongDiem = "18",
            OptimisticLockField = 19,
            PhanLoaiHuyen = 20,
            PhanLoaiXa = 21,
            Thieu = true,
            ThonDacBietKhoKhan = 23,
            XaBaiNgang = 24,
            XaBienGioi = 25,
            XaDao = 26,
            XaMienNuiKV1 = 27,
            XaMienNuiKV2 = 28,
            XaMienNuiKV3 = 29
        };
            var result = new AdministrativeUnitList();
            result.Administrativeunits.Add(item1);
            return Task.FromResult(result);
        }
    }
}
