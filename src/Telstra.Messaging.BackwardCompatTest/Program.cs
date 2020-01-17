using System;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Telstra.Messaging.BackwardCompatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new AuthenticationApi(config);
            var clientId = Environment.GetEnvironmentVariable("CLIENT_ID");  // string | 
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET");  // string | 
            var grantType = "client_credentials";  // string |  (default to "client_credentials")
            var scope = "NSMS";  // string | NSMS (optional) 

            try
            {
                // Generate OAuth2 token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType, scope);
                Console.WriteLine("Token acquired!");
                config.AccessToken = result.AccessToken;

                var provisioningInstance = new ProvisioningApi(config);
                var body = new ProvisionNumberRequest(30);
                ProvisionNumberResponse provisioningResult = provisioningInstance.CreateSubscription(body);
                Console.WriteLine("Number provisioned!");

                var smsApiInstance = new MessagingApi(config);
                var payload = new SendSMSRequest(
                    Environment.GetEnvironmentVariable("PHONE_NO"),
                    "Test C# SDK",
                    Environment.GetEnvironmentVariable("FROM_ALIAS"));

                MessageSentResponseSms smsResult = smsApiInstance.SendSMS(payload);
                Console.WriteLine("Message sent");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuthenticationApi.AuthToken: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
