using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Common
{
    public class Paging
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; } = string.Empty;

        [JsonProperty("previousPage")]
        public string PreviousPage { get; set; } = string.Empty;

        [JsonProperty("lastPage")]
        public string LastPage { get; set; } = string.Empty;

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; } = 0;
    }
}