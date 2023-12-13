using Newtonsoft.Json;
using com.telstra.messaging.Models.Common;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class VirtualNumbersList
    {
        [JsonProperty("virtualNumbers")]
        public List<VirtualNumber> Numbers { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        public VirtualNumbersList()
        {
            Numbers = new List<VirtualNumber>();
            Paging = new Paging();
        }
    }
}