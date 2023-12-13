using System.ComponentModel.DataAnnotations;
using com.telstra.messaging.Utils;
using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
    public class SendMessageParams
    {
        private List<string>? _to;
        [JsonProperty("to")]
        public List<string> To
        {
            get { return _to ?? new List<string>(); }

            set
            {
                if (value.Count < 1 || value.Count > 500)
                {
                    throw new ValidationException("Out of range. To accepts minimum of 1 number and maximum of 500 numbers.");
                }

                if (value.Any(N => N.Length < 5 || N.Length > 16))
                {
                    throw new ValidationException("One or more numbers in the list are not valid. Destination number accepts a valid mobile number.");
                }

                _to = value;
            }
        }

        private string? _from;
        [JsonProperty("from")]
        public string From
        {
            get { return _from ?? string.Empty; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 13)
                {
                    throw new ValidationException("Invalid value. From accepts '04xxxxxxxx' or unique alphanumeric string of up to 11 characters");
                }

                _from = value;
            }
        }

        private string? _messageContent;
        [JsonProperty("messageContent")]
        public string? MessageContent
        {
            get { return _messageContent; }
            set
            {
                if (!string.IsNullOrEmpty(value) && (value.Length < 1 || value.Length > 1600))
                {
                    throw new ValidationException("Invalid value. MessageContent accepts a string with max of 1600 characters");
                }

                _messageContent = value;
            }
        }

        [JsonProperty("multimedia")]
        public List<Multimedia>? Multimedia { get; set; }

        [JsonProperty("retryTimeout")]
        public int RetryTimeout { get; set; }

        private DateTime? _scheduleSend;
        [JsonProperty("scheduleSend")]
        public DateTime? ScheduleSend
        {
            get { return _scheduleSend; }
            set
            {
                Console.WriteLine(value);
                Console.WriteLine(DateTime.UtcNow);
                if (value != null && (value < DateTime.UtcNow || value > DateTime.UtcNow.AddDays(10)))
                {
                    throw new ValidationException("Invalid value. ScheduleSend accepts future UTC time not greater than 10 days.");
                }

                _scheduleSend = value;
            }
        }

        [JsonProperty("deliveryNotification")]
        public bool DeliveryNotification { get; set; } = false;

        [JsonProperty("statusCallbackUrl")]
        public string? StatusCallbackUrl { get; set; }

        [JsonProperty("queuePriority")]
        public int QueuePriority { get; set; } = 2;

        private List<string>? _tags;
        [JsonProperty("tags")]
        public List<string>? Tags
        {
            get { return _tags; }

            set
            {
                if (value != null && value.Count > 10)
                {
                    throw new ValidationException("Tags out of range. Accepts maximum od 10 strings.");
                }

                if (value != null && value.Any(N => N.Length < 1 || N.Length > 64))
                {
                    throw new ValidationException("One or more tags in the list are not valid. Tag accepts a string with maximum 64 characters.");
                }

                _tags = value;
            }
        }

        public SendMessageParams(List<string> to,
            string from,
            string? messageContent = null,
            List<Multimedia>? multimedia = null,
            int retryTimeout = 10,
            DateTime? scheduleSend = null,
            bool deliveryNotification = false,
            string? statusCallbackUrl = null,
            int queuePriority = 2,
            List<string>? tags = null)
        {
            To = to;
            From = from;
            MessageContent = messageContent;
            Multimedia = multimedia;
            RetryTimeout = retryTimeout;
            ScheduleSend = scheduleSend;
            DeliveryNotification = deliveryNotification;
            StatusCallbackUrl = statusCallbackUrl;
            QueuePriority = queuePriority;
            Tags = tags;

            if (string.IsNullOrEmpty(MessageContent) && (Multimedia == null || Multimedia.Count < 1))
            {
                throw new ValidationException("Field Missing. Either MessageContent or Multimedia are required.");
            }
        }
    }
}