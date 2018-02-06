# com.telstra.messaging.Api.MessagingApi

All URIs are relative to *https://tapi.telstra.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMMSStatus**](MessagingApi.md#getmmsstatus) | **GET** /messages/mms/{messageid}/status | Get MMS Status
[**GetSMSStatus**](MessagingApi.md#getsmsstatus) | **GET** /messages/sms/{messageId}/status | Get SMS Status
[**RetrieveSMSResponses**](MessagingApi.md#retrievesmsresponses) | **GET** /messages/sms | Retrieve SMS Responses
[**SendMMS**](MessagingApi.md#sendmms) | **POST** /messages/mms | Send MMS
[**SendSMS**](MessagingApi.md#sendsms) | **POST** /messages/sms | Send SMS


<a name="getmmsstatus"></a>
# **GetMMSStatus**
> OutboundPollResponse GetMMSStatus (string messageid)

Get MMS Status

Get MMS Status

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class GetMMSStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageid = messageid_example;  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/mms

            try
            {
                // Get MMS Status
                OutboundPollResponse result = apiInstance.GetMMSStatus(messageid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMMSStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageid** | **string**| Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/mms | 

### Return type

[**OutboundPollResponse**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsstatus"></a>
# **GetSMSStatus**
> OutboundPollResponse GetSMSStatus (string messageId)

Get SMS Status

Get Message Status

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class GetSMSStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageId = messageId_example;  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/sms

            try
            {
                // Get SMS Status
                OutboundPollResponse result = apiInstance.GetSMSStatus(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetSMSStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/sms | 

### Return type

[**OutboundPollResponse**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievesmsresponses"></a>
# **RetrieveSMSResponses**
> List<InboundPollResponse> RetrieveSMSResponses ()

Retrieve SMS Responses

Retrieve Messages

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class RetrieveSMSResponsesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();

            try
            {
                // Retrieve SMS Responses
                List&lt;InboundPollResponse&gt; result = apiInstance.RetrieveSMSResponses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.RetrieveSMSResponses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InboundPollResponse>**](InboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmms"></a>
# **SendMMS**
> Object SendMMS (SendMmsRequest body)

Send MMS

Send MMS

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class SendMMSExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var body = new SendMmsRequest(); // SendMmsRequest | A JSON or XML payload containing the recipient's phone number and MMS message.The recipient number should be in the format '04xxxxxxxx' where x is a digit

            try
            {
                // Send MMS
                Object result = apiInstance.SendMMS(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendMMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendMmsRequest**](SendMmsRequest.md)| A JSON or XML payload containing the recipient&#39;s phone number and MMS message.The recipient number should be in the format &#39;04xxxxxxxx&#39; where x is a digit | 

### Return type

**Object**

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsms"></a>
# **SendSMS**
> MessageSentResponse SendSMS (SendSMSRequest payload)

Send SMS

Send Message

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class SendSMSExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var payload = new SendSMSRequest(); // SendSMSRequest | A JSON or XML payload containing the recipient's phone number and text message. The recipient number should be in the format '04xxxxxxxx' where x is a digit

            try
            {
                // Send SMS
                MessageSentResponse result = apiInstance.SendSMS(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**SendSMSRequest**](SendSMSRequest.md)| A JSON or XML payload containing the recipient&#39;s phone number and text message. The recipient number should be in the format &#39;04xxxxxxxx&#39; where x is a digit | 

### Return type

[**MessageSentResponse**](MessageSentResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

