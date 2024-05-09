using System.ComponentModel.DataAnnotations;
using System.Text;

namespace com.telstra.messaging.Models.Common
{
    public class QueryParams
    {
        private int _limit = 10;
        private int _offset = 0;


        public int Limit
        {
            get { return _limit; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ValidationException("Limit value out of range. Accepts value between 1 and 50.");
                }

                _limit = value;
            }
        }
        public int Offset
        {
            get { return _offset; }
            set
            {
                if (value < 0 || value > 999999)
                {
                    throw new ValidationException("Offset value out of range. Accepts value between 0 and 999999.");
                }

                _offset = value;
            }
        }
        public string Filter { get; set; }

        public QueryParams(int limit, int offset, string? filter = null)
        {
            Limit = limit;
            Offset = offset;
            Filter = filter ?? string.Empty;
        }

        public string BuildQueryString()
        {
            var qs = new StringBuilder();

            if (Limit == 10 && Offset == 0 && String.IsNullOrEmpty(Filter))
                return string.Empty;

            var limit = (Limit != 10) ? $"limit={Uri.EscapeDataString(Limit.ToString())}" : string.Empty;
            var offset = (Offset != 0) ? $"offset={Uri.EscapeDataString(Offset.ToString())}" : string.Empty;
            var filter = !String.IsNullOrEmpty(Filter) ? $"filter={Uri.EscapeDataString(Filter)}" : string.Empty;

            qs.Append("?");
            qs.Append(String.IsNullOrEmpty(limit) ? string.Empty : $"{limit}&");
            qs.Append(String.IsNullOrEmpty(offset) ? string.Empty : $"{offset}&");
            qs.Append(String.IsNullOrEmpty(filter) ? string.Empty : $"{filter}&");

            return qs.ToString().TrimEnd('&');
        }
    }
}
