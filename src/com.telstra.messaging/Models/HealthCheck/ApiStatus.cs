using Newtonsoft.Json;

namespace com.telstra.messaging.Models.HealthCheck
{
    public class ApiStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; } = "down";

        public ApiStatus(string? status)
        {
            Status = status ?? "down";
        }
    }
}