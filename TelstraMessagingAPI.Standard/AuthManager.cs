
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TelstraMessagingAPI.Standard.Controllers;
using TelstraMessagingAPI.Standard.Exceptions;
using TelstraMessagingAPI.Standard.Models;

namespace TelstraMessagingAPI.Standard.Utilities
{
    public class AuthManager
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AuthManager instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AuthManager Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AuthManager();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        public OAuthToken Authorize(List<OAuthScopeEnum> scopes = null, Dictionary<string, object> additionalParameters = null)
        {
            string authorizationHeader = BuildBasicAuthheader(Configuration.OAuthClientId,
                Configuration.OAuthClientSecret);
            OAuthToken token = OAuthAuthorizationController.Instance.CreateRequestToken(authorizationHeader, (scopes != null) ? String.Join(" ", scopes.Select(OAuthScopeEnumHelper.ToValue).ToArray()) : null, additionalParameters);
            UpdateAccessToken(token);
            return token;
        }


        public string BuildBasicAuthheader(string username, string password)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(username + ':' + password);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }


        public void UpdateAccessToken(OAuthToken token)
        {
            if (token.ExpiresIn != null && token.ExpiresIn!=0)
                token.Expiry = token.ExpiresIn.Value + (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

            Configuration.OAuthToken = token;
            if(Configuration.OAuthTokenUpdateCallback!=null)
                Configuration.OAuthTokenUpdateCallback.Invoke(token);
        }

        public void CheckAuthorization()
        {
            if (Configuration.OAuthToken == null)
                Authorize();
        } 
    }
}