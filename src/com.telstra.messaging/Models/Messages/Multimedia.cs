using Newtonsoft.Json;

namespace com.telstra.messaging.Models.Messages
{
    public class Multimedia
    {
        private string? _type;
        [JsonProperty("type")]
        public string? Type
        {
            get { return _type; }
            set
            {
                if (MultiMediaContentType.ContentTypes.Any(a => a.Equals(value)))
                {
                    _type = value;
                }
                else
                {
                    throw new Exception("Invalid value. Please use 'MultiMediaContentType'.");
                }
            }
        }

        private string? _fileName;
        [JsonProperty("fileName")]
        public string FileName
        {
            get { return _fileName ?? string.Empty; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 100)
                {
                    throw new Exception("Invalid value. FileName accepts a string with max 100 charcters.");
                }

                _fileName = value;
            }
        }

        private string? _payload;
        [JsonProperty("payload")]
        public string Payload
        {
            get { return _payload ?? string.Empty; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 999999)
                {
                    throw new Exception("Invalid value. Payload accepts a base64 encoded content string.");
                }

                _payload = value;
            }
        }

        public Multimedia(string? type, string fileName, string payload)
        {
            Type = type;
            FileName = fileName;
            Payload = payload;
        }
    }

    public class MultimediaResponse
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("fileName")]
        public string? FileName { get; set; }
    }
}