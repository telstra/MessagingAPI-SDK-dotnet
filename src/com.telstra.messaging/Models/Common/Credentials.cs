namespace com.telstra.messaging.Models.Common
{
    public class Credentials
    {
        private string _clientId = string.Empty;
        private string _clientSecret = string.Empty;

        public string ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }

        public string ClientSecret
        {
            get { return _clientSecret; }
            set { _clientSecret = value; }
        }

        public bool HasValues
        {
            get
            {
                return (_clientId != string.Empty && _clientSecret != string.Empty);
            }
        }
    }
}
