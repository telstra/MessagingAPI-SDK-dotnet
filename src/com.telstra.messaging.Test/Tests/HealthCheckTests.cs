using com.telstra.messaging.Models.Common;

namespace com.telstra.messaging.test
{
    public class HealthCheckTest
    {
        private Credentials credentials;

        public HealthCheckTest()
        {
            // Initialize credentials with desired values
            credentials = new Credentials();
            credentials.ClientId = "YOUR CLIENT ID";
            credentials.ClientSecret = "YOUR CLIENT SECRET";
        }


        [Fact]
        public async Task HealthCheck()
        {

            try
            {
                var healthCheck = new HealthCheck(credentials);
                var response = await healthCheck.GetStatus();
                Assert.Equal("up", response.Status);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }

        }
    }
}

