using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class AssignVirtualNumberParams
    {
        private List<string>? _tags;

        [JsonProperty("replyCallbackUrl")]
        public string ReplyCallbackUrl { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags
        {
            get
            {
                return _tags ?? new List<string>();
            }

            set
            {
                if (value.Count > 10)
                {
                    throw new ValidationException("VirtualNumber Tags value out of range. Accepts maximum od 10 strings.");
                }

                if (value.Any(N => N.Length < 1 || N.Length > 64))
                {
                    throw new ValidationException("One or more strings in the list are not valid tags. Accepts strings with maximum 64 characters.");
                }

                _tags = value;
            }
        }

        public AssignVirtualNumberParams(string replyCallbackUrl, List<string>? tags = null)
        {
            ReplyCallbackUrl = replyCallbackUrl ?? string.Empty;
            Tags = tags ?? new List<string>();
        }
    }
}