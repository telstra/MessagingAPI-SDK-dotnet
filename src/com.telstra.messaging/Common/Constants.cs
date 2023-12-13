namespace com.telstra.messaging.Common
{
    public class Constants
    {
        public static readonly string BASE_PATH = "https://products.api.telstra.com";
        public static readonly string SHARED_FILE_NAME = "credentials.txt";
        public static readonly string CLIENT_ID_KEY = "TELSTRA_CLIENT_ID";
        public static readonly string CLIENT_SECRET_KEY = "TELSTRA_CLIENT_SECRET";
        public static readonly string CLIENT_AUTH_SCOPE = "free-trial-numbers:read free-trial-numbers:write virtual-numbers:read virtual-numbers:write messages:read messaging:write reports:read reports:write";
    }
}