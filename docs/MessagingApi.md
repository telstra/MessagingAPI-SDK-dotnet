# Telstra.Messaging.Api.MessagingApi

All URIs are relative to *https://tapi.telstra.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMMSStatus**](MessagingApi.md#getmmsstatus) | **GET** /messages/mms/{messageid}/status | Get MMS Status
[**GetSMSStatus**](MessagingApi.md#getsmsstatus) | **GET** /messages/sms/{messageId}/status | Get SMS Status
[**MMSHealthCheck**](MessagingApi.md#mmshealthcheck) | **GET** /messages/mms/heathcheck | MMS Health Check
[**RetrieveMMSReplies**](MessagingApi.md#retrievemmsreplies) | **GET** /messages/mms | Retrieve MMS Replies
[**RetrieveSMSReplies**](MessagingApi.md#retrievesmsreplies) | **GET** /messages/sms | Retrieve SMS Replies
[**SMSHealthCheck**](MessagingApi.md#smshealthcheck) | **GET** /messages/sms/heathcheck | SMS Health Check
[**SMSMulti**](MessagingApi.md#smsmulti) | **POST** /messages/sms/multi | Send Multiple SMS
[**SendMMS**](MessagingApi.md#sendmms) | **POST** /messages/mms | Send MMS
[**SendSMS**](MessagingApi.md#sendsms) | **POST** /messages/sms | Send SMS


<a name="getmmsstatus"></a>
# **GetMMSStatus**
> List&lt;OutboundPollResponse&gt; GetMMSStatus (string messageid)

Get MMS Status

Get MMS Status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class GetMMSStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);
            var messageid = messageid_example;  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://tapi.telstra.com/v2/messages/mms 

            try
            {
                // Get MMS Status
                List<OutboundPollResponse> result = apiInstance.GetMMSStatus(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMMSStatus: " + e.Message );
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
 **messageid** | **string**| Unique identifier of a message - it is the value returned from a previous POST call to https://tapi.telstra.com/v2/messages/mms  | 

### Return type

[**List&lt;OutboundPollResponse&gt;**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Invalid or missing request parameters  NOT-PROVISIONED  Request flagged as containing suspicious content |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist OLD-NONEXISTANT-MESSAGE-ID RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsstatus"></a>
# **GetSMSStatus**
> List&lt;OutboundPollResponse&gt; GetSMSStatus (string messageId)

Get SMS Status

If no notification URL has been specified, it is possible to poll for the message status.  Note that the `MessageId` that appears in the URL must be URL encoded. Just copying the `MessageId` as it was supplied when submitting the message may not work.  # SMS Status with Notification URL  When a message has reached its final state, the API will send a POST to the URL that has been previously specified.  <pre><code class=\"language-sh\">{     \"to\": \"+61418123456\",     \"sentTimestamp\": \"2017-03-17T10:05:22+10:00\",     \"receivedTimestamp\": \"2017-03-17T10:05:23+10:00\",     \"messageId\": \"1234567890ABCDEFGHIJKLNOPQRSTUVW\",     \"deliveryStatus\": \"DELIVRD\"   } </code></pre>  The fields are:  | Field | Description | | - -- | - --| | `to` |  The number the message was sent to. | | `receivedTimestamp` | Time the message was sent to the API. | | `sentTimestamp` | Time handling of the message ended. | | `deliveryStatus` | The final state of the message. | | `messageId` | The same reference that was returned when the original message was sent.| | `receivedTimestamp` | Time the message was sent to the API.|  Upon receiving this call it is expected that your servers will give a 204 (No Content) response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class GetSMSStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);
            var messageId = messageId_example;  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://tapi.telstra.com/v2/messages/sms. 

            try
            {
                // Get SMS Status
                List<OutboundPollResponse> result = apiInstance.GetSMSStatus(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.GetSMSStatus: " + e.Message );
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
 **messageId** | **string**| Unique identifier of a message - it is the value returned from a previous POST call to https://tapi.telstra.com/v2/messages/sms.  | 

### Return type

[**List&lt;OutboundPollResponse&gt;**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters  NOT-PROVISIONED  Request flagged as containing suspicious content |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission  SpikeArrest-The API call rate limit has been exceeded |  -  |
| **404** | The requested URI does not exist  OLD-NONEXISTANT-MESSAGE-ID  RESOURCE-NOT-FOUND |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmshealthcheck"></a>
# **MMSHealthCheck**
> HealthCheckResponse MMSHealthCheck ()

MMS Health Check

Determine whether the MMS service is up or down. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class MMSHealthCheckExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new MessagingApi(Configuration.Default);

            try
            {
                // MMS Health Check
                HealthCheckResponse result = apiInstance.MMSHealthCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.MMSHealthCheck: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievemmsreplies"></a>
# **RetrieveMMSReplies**
> GetMmsResponse RetrieveMMSReplies ()

Retrieve MMS Replies

Messages are retrieved one at a time, starting with the earliest reply.  If the subscription has a `notifyURL`, reply messages will be logged there instead, i.e. `GET` and reply `notifyURL` are exclusive.  # MMS Reply with Notification URL  When a reply is received, the API will send a POST to the subscription URL that has been previously specified.  <pre><code class=\"language-sh\">{   \"to\": \"+61418123456\",   \"from\": \"+61421987654\",   \"sentTimestamp\": \"2018-03-23T12:15:45+10:00\",   \"messageId\": \"XFRO1ApiA0000000111\",   \"subject\": \"Foo\",   \"envelope\": \"string\",   \"MMSContent\":     [       {         \"type\": \"text/plain\",         \"filename\": \"text_1.txt\",         \"payload\": \"string\"       },       {         \"type\": \"image/jpeg\",         \"filename\": \"sample.jpeg\",         \"payload\": \"string\"       }     ] }</code></pre>  The fields are:  | Field | Description | | - -- | - -- | | `to` |The number the message was sent to. | | `from` | The number the message was sent from. | | `sentTimestamp` | Time handling of the message ended. | | `messageId` | Message Id assigned by the MMSC | | `subject` | The subject assigned to the message. | | `envelope` | Information about about terminal type and originating operator. | | `MMSContent` | An array of the actual content of the reply message. | | `type` | The content type of the message. | | `filename` | The filename for the message content. | | `payload` | The content of the message. | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class RetrieveMMSRepliesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);

            try
            {
                // Retrieve MMS Replies
                GetMmsResponse result = apiInstance.RetrieveMMSReplies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.RetrieveMMSReplies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetMmsResponse**](GetMmsResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievesmsreplies"></a>
# **RetrieveSMSReplies**
> InboundPollResponse RetrieveSMSReplies ()

Retrieve SMS Replies

Messages are retrieved one at a time, starting with the earliest reply.  The API supports the encoding of emojis in the reply message. The emojis will be in their UTF-8 format.  If the subscription has a `notifyURL`, reply messages will be logged there instead.  # SMS Reply with Notification URL  When a reply is received, the API will send a POST to the subscription URL that has been previously specified.  <pre><code class=\"language-sh\">{   \"to\":\"+61472880123\",   \"from\":\"+61412345678\",   \"body\":\"Foo4\",   \"sentTimestamp\":\"2018-04-20T14:24:35\",   \"messageId\":\"DMASApiA0000000146\" }</code></pre>  The fields are:  | Field | Description | | - -- |- -- | | `to` | The number the message was sent to. | | `from` | The number the message was sent from. | | `body` | The content of the SMS response. | | `sentTimestamp` | Time handling of the message ended. | | `messageId` | The ID assigned to the message. | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class RetrieveSMSRepliesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);

            try
            {
                // Retrieve SMS Replies
                InboundPollResponse result = apiInstance.RetrieveSMSReplies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.RetrieveSMSReplies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InboundPollResponse**](InboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smshealthcheck"></a>
# **SMSHealthCheck**
> HealthCheckResponse SMSHealthCheck ()

SMS Health Check

Determine whether the SMS service is up or down. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SMSHealthCheckExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new MessagingApi(Configuration.Default);

            try
            {
                // SMS Health Check
                HealthCheckResponse result = apiInstance.SMSHealthCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SMSHealthCheck: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsmulti"></a>
# **SMSMulti**
> MessageSentResponseSms SMSMulti (SendSmsMultiRequest payload)

Send Multiple SMS

Send multiple SMS in one API call. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SMSMultiExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new MessagingApi(Configuration.Default);
            var payload = new SendSmsMultiRequest(); // SendSmsMultiRequest | A JSON payload containing the recipient's phone number and text message. This number can be in international format if preceeded by a '+' or in national format ('04xxxxxxxx') where x is a digit. 

            try
            {
                // Send Multiple SMS
                MessageSentResponseSms result = apiInstance.SMSMulti(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SMSMulti: " + e.Message );
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
 **payload** | [**SendSmsMultiRequest**](SendSmsMultiRequest.md)| A JSON payload containing the recipient&#39;s phone number and text message. This number can be in international format if preceeded by a &#39;+&#39; or in national format (&#39;04xxxxxxxx&#39;) where x is a digit.  | 

### Return type

[**MessageSentResponseSms**](MessageSentResponseSms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters * DR-NOTIFY-URL-MISSING : when receiptOff is missing or receiptOff&#x3D;false but notifyURL is missing  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmms"></a>
# **SendMMS**
> MessageSentResponseMms SendMMS (SendMmsRequest body)

Send MMS

Send MMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SendMMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);
            var body = new SendMmsRequest(); // SendMmsRequest | A JSON or XML payload containing the recipient's phone number and MMS message. The recipient number should be in the format '04xxxxxxxx' where x is a digit. 

            try
            {
                // Send MMS
                MessageSentResponseMms result = apiInstance.SendMMS(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SendMMS: " + e.Message );
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
 **body** | [**SendMmsRequest**](SendMmsRequest.md)| A JSON or XML payload containing the recipient&#39;s phone number and MMS message. The recipient number should be in the format &#39;04xxxxxxxx&#39; where x is a digit.  | 

### Return type

[**MessageSentResponseMms**](MessageSentResponseMms.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Invalid or missing request parameters MMS-TYPE-MISSING MMS-PAYLOAD-MISSING MMS-FILENAME-MISSING DELIVERY-IMPOSSIBLE TO-MSISDN-NOT-VALID SENDER-MISSING DELIVERY-IMPOSSIBLE SUBJECT-TOO-LONG FROM-MSISDN-TOO-LONG TO-MSISDN-TOO-LONG NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsms"></a>
# **SendSMS**
> MessageSentResponseSms SendSMS (SendSMSRequest payload)

Send SMS

Send an SMS Message to a single or multiple mobile number/s. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SendSMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(Configuration.Default);
            var payload = new SendSMSRequest(); // SendSMSRequest | A JSON or XML payload containing the recipient's phone number and text message. This number can be in international format if preceeded by a '+' or in national format ('04xxxxxxxx') where x is a digit. 

            try
            {
                // Send SMS
                MessageSentResponseSms result = apiInstance.SendSMS(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SendSMS: " + e.Message );
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
 **payload** | [**SendSMSRequest**](SendSMSRequest.md)| A JSON or XML payload containing the recipient&#39;s phone number and text message. This number can be in international format if preceeded by a &#39;+&#39; or in national format (&#39;04xxxxxxxx&#39;) where x is a digit.  | 

### Return type

[**MessageSentResponseSms**](MessageSentResponseSms.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Invalid or missing request parameters * TO-MSISDN-NOT-VALID * SENDER-MISSING * DELIVERY-IMPOSSIBLE * FROM-MSISDN-TOO-LONG * BODY-TOO-LONG * BODY-MISSING * TO-MSISDN-TOO-LONG * TECH-ERR * BODY-NOT-VALID * NOT-PROVISIONED * Request flagged as containing suspicious content. * Invalid &#39;from&#39; address specified.  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission.  SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint :  An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

