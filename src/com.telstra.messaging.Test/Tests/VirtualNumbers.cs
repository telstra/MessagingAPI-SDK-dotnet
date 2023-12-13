using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

namespace com.telstra.messaging.test
{
    public class VirtualNumbersTest
    {
        private Credentials credentials;

        public VirtualNumbersTest()
        {
            // Initialize credentials with desired values
            credentials = new Credentials();
            credentials.ClientId = "YOUR CLIENT ID";
            credentials.ClientSecret = "YOUR CLIENT SECRET";
        }

        [Fact]
        public async Task GetAllVirtualNumbers()
        {
            try
            {
				var vn = new VirtualNumbers(credentials);
				var response = await vn.GetAll();
				Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task AssignVirtualNumber()
        {
            try
            {
				var vn = new VirtualNumbers(credentials);
                List<string> tags = new() { "reprehenderit", "Excepteur non labore" };
                var assignVirtualNumberParams = new AssignVirtualNumberParams("http://www.example.com", tags);
                var response = await vn.Assign(assignVirtualNumberParams);
				Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task UpdateVirtualNumber()
        {
            try
            {
                var vn = new VirtualNumbers(credentials);               
                List<string> tags = new() { "reprehenderit", "Excepteur non labore", "qui voluptate" };
                var assignVirtualNumberParams = new AssignVirtualNumberParams("http://www.example.com", tags);
                var updateVirtualNumberParams = new UpdateVirtualNumberParams("0428180739", assignVirtualNumberParams);
                var response = await vn.Update(updateVirtualNumberParams);
                Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task DeleteVirtualNumber()
        {
            try
            {
                var vn = new VirtualNumbers(credentials);
                await vn.Delete("0428180739");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task GetVirtualNumber()
        {
            try
            {
                var vn = new VirtualNumbers(credentials);               
                var response = await vn.Get("0428180739");
                Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }

        [Fact]
        public async Task GetOptOuts()
        {
            try
            {
                var vn = new VirtualNumbers(credentials);
                var response = await vn.GetOptouts("0428180739");
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

