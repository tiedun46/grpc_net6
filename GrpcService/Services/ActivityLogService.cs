using Grpc.Core;
using GrpcService.Entities;
using Google.Protobuf.WellKnownTypes;

namespace GrpcService.Services
{
    public class ActivityLogService : ActivityLog.ActivityLogBase
    {

        public override async Task<ActivityLogResponse> Insert(ActivityLogModel request, ServerCallContext context)
        {
            var _context = new IASMGRContext();
            var tActivityLog = new TActivityLog();
            tActivityLog.Oid = Guid.NewGuid();
            tActivityLog.MetaLicenseId = tActivityLog.Oid;
            tActivityLog.DInputDate = DateTime.Now;
            tActivityLog.LogType = request.LogType;
            tActivityLog.LogAction = request.LogAction;
            tActivityLog.LogValue = request.LogValue;
            tActivityLog.LogDescription = request.LogDescription;
            tActivityLog.MetaIpaddress = request.MetaIPAddress;
            await _context.TActivityLogs.AddAsync(tActivityLog);
            await _context.SaveChangesAsync();

            var result = new ActivityLogResponse { StatusCode = 1, IsSuccess = true, Message = "Is Success" };
            Console.WriteLine($"{request.LogAction} | {request.LogType} | {request.LogValue} | {request.MetaIPAddress} | {request.LogDescription}");    
            return result;
        }
    }
}
