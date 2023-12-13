using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.HealthCheck;
using Newtonsoft.Json.Linq;

namespace com.telstra.messaging
{
    public class HealthCheck : Client
    {
        public HealthCheck(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<ApiStatus> GetStatus()
        {
            try
            {
                var response = await this.SendAsync(HttpMethod.Get, "/messaging/v3/health-check");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JObject.Parse(responseContent);
                    return new ApiStatus(responseObject["status"]?.ToString());
                }
                else
                {
                    throw new Exception($"Failed to get ApiStatus. {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get ApiStatus. {ex.Message}");
            }
        }
    }
}
