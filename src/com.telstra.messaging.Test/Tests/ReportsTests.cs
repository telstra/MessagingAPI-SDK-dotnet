using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

namespace com.telstra.messaging.test
{
    public class ReportsTest
    {
        private Credentials credentials;

        public ReportsTest()
        {
            // Initialize credentials with desired values
            credentials = new Credentials();
            credentials.ClientId = "YOUR CLIENT ID";
            credentials.ClientSecret = "YOUR CLIENT SECRET";
        }

        [Fact]
        public async Task GetReports()
        {
            try
            {
				var reports = new Reports(credentials);
				var response = await reports.GetAll();
				Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task GetReport()
        {
            try
            {
				var reports = new Reports(credentials);
				var response = await reports.Get("0eaf6960-580d-11ee-986c-e35ce4792749");
				Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task CreateReport()
        {
            try
            {
				var reports = new Reports(credentials);
				var myParams = new CreateReportsParams(DateTime.Now.AddDays(-30), DateTime.Now);
				var response = await reports.Create(myParams);
				Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }
    }
}

