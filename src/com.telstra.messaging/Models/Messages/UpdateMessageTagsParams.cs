using System.ComponentModel.DataAnnotations;
using com.telstra.messaging.Utils;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
    public class UpdateMessageTagsParams
    {
        private List<string>? _tags;
        [JsonProperty("tags")]
        public List<string>? Tags
        {
            get { return _tags; }

            set
            {
                if (value == null || value.Count > 10)
                {
                    throw new ValidationException("Tags out of range. Accepts maximum od 10 strings.");
                }

                if (value.Any(N => N.Length < 1 || N.Length > 64))
                {
                    throw new ValidationException("One or more tags in the list are not valid. Tag accepts a string with maximum 64 characters.");
                }

                _tags = value;
            }
        }

       
        public UpdateMessageTagsParams(List<string>? tags = null)
        {
            Tags = tags ?? new List<string>();
        }

    }
}