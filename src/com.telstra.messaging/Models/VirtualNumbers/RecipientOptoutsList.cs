using com.telstra.messaging.Models.Common;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class RecipientOptoutsList
    {
        [JsonProperty("recipientOptouts")]
        public List<RecipientOptout> recipientOptouts { get; set; } = new List<RecipientOptout>();

        [JsonProperty("paging")]
        public Paging Paging { get; set; } = new Paging();
    }
}