using Grpc.Net.Client;
using GrpcService;

namespace ConsoleAppClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new ActivityLog.ActivityLogClient(channel);
            var response = await client.InsertAsync(new ActivityLogModel
            {
                LogType = "add7",
                LogAction = "add7",
                LogValue = 7,
                LogDescription = "LogDescription7",
                MetaIPAddress = "127.0.0.7",
            });
            Console.WriteLine($"Message: {response.Message} | StatusCode: {response.StatusCode} | IsSuccess: {response.IsSuccess}");

            var client2 = new AdministrativeUnit.AdministrativeUnitClient(channel);
            var reponse_admunit = client2.GetList(new Google.Protobuf.WellKnownTypes.Empty());
            foreach(var item in reponse_admunit.Administrativeunits)
            {
                Console.WriteLine($"Ma tinh: {item.MaTinh} | Ma don vi: {item.MaDonVi}");
            }
            await channel.ShutdownAsync();
            Console.ReadKey();
        }
    }
}