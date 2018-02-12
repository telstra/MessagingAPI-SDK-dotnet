# com.telstra.messaging.Api.ProvisioningApi

All URIs are relative to *https://tapi.telstra.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](ProvisioningApi.md#createsubscription) | **POST** /messages/provisioning/subscriptions | Create Subscription
[**DeleteSubscription**](ProvisioningApi.md#deletesubscription) | **DELETE** /messages/provisioning/subscriptions | Delete Subscription
[**GetSubscription**](ProvisioningApi.md#getsubscription) | **GET** /messages/provisioning/subscriptions | Get Subscription


<a name="createsubscription"></a>
# **CreateSubscription**
> ProvisionNumberResponse CreateSubscription (ProvisionNumberRequest body)

Create Subscription

Provision a mobile number

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi();
            var body = new ProvisionNumberRequest(); // ProvisionNumberRequest | A JSON payload containing the required attributes

            try
            {
                // Create Subscription
                ProvisionNumberResponse result = apiInstance.CreateSubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvisioningApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProvisionNumberRequest**](ProvisionNumberRequest.md)| A JSON payload containing the required attributes | 

### Return type

[**ProvisionNumberResponse**](ProvisionNumberResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (DeleteNumberRequest body)

Delete Subscription

Delete a mobile number subscription from an account

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi();
            var body = new DeleteNumberRequest(); // DeleteNumberRequest | EmptyArr

            try
            {
                // Delete Subscription
                apiInstance.DeleteSubscription(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvisioningApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteNumberRequest**](DeleteNumberRequest.md)| EmptyArr | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription ()

Get Subscription

Get mobile number subscription for an account

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi();

            try
            {
                // Get Subscription
                GetSubscriptionResponse result = apiInstance.GetSubscription();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvisioningApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

