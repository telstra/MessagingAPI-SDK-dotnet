using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
    public class GetMessageResponse
    {
        [JsonProperty("messageId")]
        public string? MessageId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("createTimestamp")]
        public DateTime CreateTimeStamp { get; set; }

        [JsonProperty("sentTimestamp")]
        public DateTime SentTimestamp { get; set; }

        [JsonProperty("receivedTimestamp")]
        public DateTime ReceivedTimestamp { get; set; }

        [JsonProperty("to")]
        public string? To { get; set; }

        [JsonProperty("from")]
        public string? From { get; set; }

        [JsonProperty("messageContent")]
        public string? MessageContent { get; set; }

        [JsonProperty("multimedia")]
        public List<MultimediaResponse>? Multimedia { get; set; }

        [JsonProperty("direction")]
        public string? Direction { get; set; }

        [JsonProperty("retryTimeout")]
        public int RetryTimeout { get; set; }

        [JsonProperty("scheduleSend")]
        public DateTime ScheduleSend { get; set; }

        [JsonProperty("deliveryNotification")]
        public bool DeliveryNotification { get; set; }

        [JsonProperty("statusCallbackUrl")]
        public string? StatusCallbackUrl { get; set; }

        [JsonProperty("queuePriority")]
        public int QueuePriority { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }
    }
}