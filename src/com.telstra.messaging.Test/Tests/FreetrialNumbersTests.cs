using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.FreeTrialNumbers;

namespace com.telstra.messaging.test
{
    public class FreetrialNumbersTests
    {
        private Credentials credentials;

        public FreetrialNumbersTests()
        {
            // Initialize credentials with desired values
            credentials = new Credentials();
            credentials.ClientId = "YOUR CLIENT ID";
            credentials.ClientSecret = "YOUR CLIENT SECRET";
        }



        [Fact]
        public async Task CreateFreetrialNumbers()
        {
            try
            {
                var ft = new FreeTrialNumbers(credentials);
                var ftList = new FreeTrialNumbersList(new List<string>() { "0434000001", "0434000002" });
                var response = await ft.Create(ftList);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }


        [Fact]
        public async Task GetFreeTrialNumbers()
        {
            try
            {
                var ft = new FreeTrialNumbers(credentials);
                var response = await ft.GetAll();

                ((List<string>)response.FreeTrialNumbers).ForEach(F => Console.WriteLine(F));
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }
        }




    }
}

