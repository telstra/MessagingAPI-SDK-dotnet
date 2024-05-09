using com.telstra.messaging;
using com.telstra.messaging.Models.FreeTrialNumbers;
using com.telstra.messaging.Models.Messages;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

namespace com.telstra.messaging.examples
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome! from .NET SDK");
        }

        private static async Task DoHealthCheck()
        {
            var hc = new HealthCheck();
            var response = await hc.GetStatus();

            Console.WriteLine($"HealtCheck Status:{response.Status}");
        }

        private static async Task GetFreeTrialNumbers()
        {
            var ft = new FreeTrialNumbers();
            var response = await ft.GetAll();

            ((List<string>)response.FreeTrialNumbers).ForEach(F => Console.WriteLine(F));
        }

        private static async Task AddFreeTrialNumber()
        {
            var ft = new FreeTrialNumbers();
            var numbersList = new FreeTrialNumbersList(new List<string>() { "0434651022" });
            var response = await ft.Create(numbersList);

            ((List<string>)response.FreeTrialNumbers).ForEach(F => Console.WriteLine(F));
        }

        private static async Task SendSMSMessage()
        {
            var sm = new Messages();
            var sendMessageParams = new SendMessageParams(new List<string>() { "0434651022" }, "0434651022", "Hello from .NET SDK");
            var response = await sm.Send(sendMessageParams);
        }

        private static async Task SendScheduledMessage()
        {
            var sm = new Messages();
            var sendMessageParams = new SendMessageParams(new List<string>() { "0434651022" }, "0434651022", "Hello from .NET SDK", null, 10, DateTime.UtcNow.AddSeconds(25));
            var response = await sm.Send(sendMessageParams);
        }

        /** Expected to Fail **/
        private static async Task SendInvalidScheduleDateMessage()
        {
            try
            {
                var sm = new Messages();
                var sendMessageParams = new SendMessageParams(new List<string>() { "0434651022" }, "0434651022", "Hello from .NET SDK", null, 10, DateTime.UtcNow.AddSeconds(-25));
                var response = await sm.Send(sendMessageParams);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task SendMMSMessage()
        {
            var sm = new Messages();
            var multimediaAttachment = new Multimedia(MultiMediaContentType.IMAGE_GIF, "bus.gif", "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");
            var sendMessageParams = new SendMessageParams(new List<string>() { "0434651022" }, "0434651022", "Hello from .NET SDK", new List<Multimedia>() { multimediaAttachment });
            var response = await sm.Send(sendMessageParams);
        }

        private static async Task GetVirtualNumbers()
        {
            var vn = new VirtualNumbers();
            var response = await vn.GetAll();
            Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
        }

        private static async Task GetReports()
        {
            var reports = new Reports();
            var response = await reports.GetAll();
            Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
        }

        private static async Task GetReport()
        {
            var reports = new Reports();
            var response = await reports.Get("18a4e170-4679-11ee-b0f7-d3e728240d0f");
            Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
        }

        private static async Task CreateReport()
        {
            var reports = new Reports();
            var myParams = new CreateReportsParams(DateTime.Now.AddDays(-30), DateTime.Now);
            var response = await reports.Create(myParams);
            Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
        }
    }
}
