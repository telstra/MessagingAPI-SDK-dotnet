# com.telstra.messaging.Api.AuthApi

All URIs are relative to *https://tapi.telstra.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthTokenPost**](AuthApi.md#oauthtokenpost) | **POST** /oauth/token | AuthGeneratetokenPost


<a name="oauthtokenpost"></a>
# **OauthTokenPost**
> AuthgeneratetokenpostResponse OauthTokenPost (string oAuthClientId, string oAuthClientSecret)

AuthGeneratetokenPost

generate auth token

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class OauthTokenPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var oAuthClientId = oAuthClientId_example;  // string | 
            var oAuthClientSecret = oAuthClientSecret_example;  // string | 

            try
            {
                // AuthGeneratetokenPost
                AuthgeneratetokenpostResponse result = apiInstance.OauthTokenPost(oAuthClientId, oAuthClientSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.OauthTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oAuthClientId** | **string**|  | 
 **oAuthClientSecret** | **string**|  | 

### Return type

[**AuthgeneratetokenpostResponse**](AuthgeneratetokenpostResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

