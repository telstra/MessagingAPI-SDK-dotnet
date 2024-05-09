using Newtonsoft.Json;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class RecipientOptout
    {
        [JsonProperty("messageId")]
        public string? MessageId { get; set; }

        [JsonProperty("virtualNumber")]
        public string? VirtualNumber { get; set; }

        [JsonProperty("optoutNumber")]
        public string? OptoutNumber { get; set; }

        [JsonProperty("createTimeStamp")]
        public DateTime CreateTimeStamp { get; set; }
    }
}