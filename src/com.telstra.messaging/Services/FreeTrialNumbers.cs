using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.FreeTrialNumbers;
using Newtonsoft.Json;

namespace com.telstra.messaging
{
    public class FreeTrialNumbers : Client
    {
        public FreeTrialNumbers(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<FreeTrialNumbersList> Create(FreeTrialNumbersList freeTrialNumbers)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/free-trial-numbers", freeTrialNumbers);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<FreeTrialNumbersList>(responseContent);
                    return responseObject ?? new FreeTrialNumbersList(new List<string>());
                }
                else
                {
                    throw new Exception($"Failed to create FreeTrialNumbers. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create FreeTrialNumbers. {ex.Message}");
            }
        }

        public async Task<FreeTrialNumbersList> GetAll()
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/free-trial-numbers");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<FreeTrialNumbersList>(responseContent);
                    return responseObject ?? new FreeTrialNumbersList(new List<string>());
                }
                else
                {
                    throw new Exception($"Failed to get FreeTrialNumbers. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get FreeTrialNumbers. {ex.Message}");
            }
        }
    }
}
