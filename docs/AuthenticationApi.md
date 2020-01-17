# Telstra.Messaging.Api.AuthenticationApi

All URIs are relative to *https://tapi.telstra.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthToken**](AuthenticationApi.md#authtoken) | **POST** /oauth/token | Generate OAuth2 token


<a name="authtoken"></a>
# **AuthToken**
> OAuthResponse AuthToken (string clientId, string clientSecret, string grantType, string scope = null)

Generate OAuth2 token

To generate an OAuth2 Authentication token, pass through your `Client key` and `Client secret` that you received when you registered for the **API Free Trial** Product.  The grant_type should be left as `client_credentials` and the scope as `NSMS`.  The token will expire in one hour. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class AuthTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new AuthenticationApi(Configuration.Default);
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string |  (default to "client_credentials")
            var scope = scope_example;  // string | NSMS (optional) 

            try
            {
                // Generate OAuth2 token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **clientSecret** | **string**|  | 
 **grantType** | **string**|  | [default to &quot;client_credentials&quot;]
 **scope** | **string**| NSMS | [optional] 

### Return type

[**OAuthResponse**](OAuthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | unsupported_grant_type |  -  |
| **401** | invalid_client |  -  |
| **404** | The requested URI does not exist |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

