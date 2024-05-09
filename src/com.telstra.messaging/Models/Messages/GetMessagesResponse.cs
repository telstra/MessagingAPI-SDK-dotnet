using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
	public class Paging
    {
        [JsonProperty("nextPage")]
        public string? NextPage { get; set; }

        [JsonProperty("previousPage")]
        public string? PreviousPage { get; set; }

        [JsonProperty("lastPage")]
        public string? LastPage { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }
	
    public class GetMessagesResponse
    {
        [JsonProperty("messages")]
        public List<GetMessageResponse>? Messages { get; set; }

        [JsonProperty("paging")]
        public Paging? Paging { get; set; }
    }
}