using System.Collections.Generic;
using System.Text;
using TelstraMessagingAPI.Standard.Utilities;
using TelstraMessagingAPI.Standard.Models;
namespace TelstraMessagingAPI.Standard
{
    public partial class Configuration
    {
        public delegate void OAuthTokenUpdateDelegate(OAuthToken token);

        public static OAuthToken OAuthToken;

        public static OAuthTokenUpdateDelegate OAuthTokenUpdateCallback;

        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            DEFAULT,
            ACCESS_TOKEN_SERVER,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "TODO: Replace";

        //OAuth 2 Client Secret
        //TODO: Replace the OAuthClientSecret with an appropriate value
        public static string OAuthClientSecret = "TODO: Replace";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"https://tapi.telstra.com/v2" },
                        { Servers.ACCESS_TOKEN_SERVER,"https://tapi.telstra.com/v1/oauth" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}