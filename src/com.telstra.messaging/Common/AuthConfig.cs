using com.telstra.messaging.Models.Common;

namespace com.telstra.messaging.Common
{
    public class AuthConfig
    {
        private Credentials _authCredentials = new Credentials();
        public Credentials AuthCredentials { get { return _authCredentials; } }

        public AuthConfig()
        {

        }

        public AuthConfig(Credentials credentials)
        {
            // Credentials passed through code
            if (credentials.HasValues)
            {
                _authCredentials = credentials;
            }
            else
            {
                throw new Exception("Missing Credentials");
            }
        }

   
    }
}
