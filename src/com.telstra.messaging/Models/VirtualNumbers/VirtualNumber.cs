using Newtonsoft.Json;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class VirtualNumber
    {
        [JsonProperty("virtualNumber")]
        public string Number { get; set; } = string.Empty;

        [JsonProperty("replyCallbackUrl")]
        public string ReplyCallbackUrl { get; set; } = string.Empty;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string>();

        [JsonProperty("lastUse")]
        public DateTime LastUse { get; set; }
    }
}