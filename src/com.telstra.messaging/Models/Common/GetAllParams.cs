using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Common
{
    public class GetAllParams
    {
        private int _limit;
        private int _offset;

        [JsonProperty("limit")]
        public int Limit
        {
            get { return _limit; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ValidationException("Limit value out of range. Expected a value between 1 to 50.");
                }

                _limit = value;
            }
        }

        [JsonProperty("offset")]
        public int Offset
        {
            get { return _offset; }
            set
            {
                if (value < 0 || value > 999999)
                {
                    throw new ValidationException("Offset value out of range. Expected a value between 0 to 999999.");
                }

                _offset = value;
            }
        }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        public GetAllParams()
        {
            _limit = 10;
            _offset = 0;
            Filter = string.Empty;
        }

        public GetAllParams(int limit, int offset, string filter)
        {
            Limit = limit;
            Offset = offset;
            Filter = filter;
        }

    }
}