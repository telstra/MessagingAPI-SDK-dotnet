using com.telstra.messaging.Utils;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
    public class SendMessageResponse
    {
        [JsonProperty("messageId")]
        public List<string>? MessageId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("to")]
        public List<string>? To { get; set; }

        [JsonProperty("from")]
        public string? From { get; set; }

        [JsonProperty("messageContent")]
        public string? MessageContent { get; set; }

        [JsonProperty("multimedia")]
        public List<MultimediaResponse>? Multimedia { get; set; }

        [JsonProperty("retryTimeout")]
        public int RetryTimeout { get; set; }

        [JsonProperty("scheduleSend")]
        public DateTime ScheduleSend { get; set; }

        [JsonProperty("deliveryNotification")]
        public bool DeliveryNotification { get; set; }

        [JsonProperty("statusCallbackUrl")]
        public string? StatusCallbackUrl { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }
    }
}