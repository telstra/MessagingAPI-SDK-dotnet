# com.telstra.messaging - the C# library for the Telstra Messaging API

 The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 


- API version: 2.2.4
- SDK version: 1.0.1

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;
```
<a name="packaging"></a>
## Packaging


This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out com.telstra.messaging.csproj
```


<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string |  (default to client_credentials)

            try
            {
                // Generate authentication token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthToken: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://tapi.telstra.com/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthToken**](docs/AuthenticationApi.md#authtoken) | **POST** /oauth/token | Generate authentication token
*MessagingApi* | [**GetMMSStatus**](docs/MessagingApi.md#getmmsstatus) | **GET** /messages/mms/{messageid}/status | Get MMS Status
*MessagingApi* | [**GetSMSStatus**](docs/MessagingApi.md#getsmsstatus) | **GET** /messages/sms/{messageId}/status | Get SMS Status
*MessagingApi* | [**RetrieveSMSResponses**](docs/MessagingApi.md#retrievesmsresponses) | **GET** /messages/sms | Retrieve SMS Responses
*MessagingApi* | [**SendMMS**](docs/MessagingApi.md#sendmms) | **POST** /messages/mms | Send MMS
*MessagingApi* | [**SendSMS**](docs/MessagingApi.md#sendsms) | **POST** /messages/sms | Send SMS
*ProvisioningApi* | [**CreateSubscription**](docs/ProvisioningApi.md#createsubscription) | **POST** /messages/provisioning/subscriptions | Create Subscription
*ProvisioningApi* | [**DeleteSubscription**](docs/ProvisioningApi.md#deletesubscription) | **DELETE** /messages/provisioning/subscriptions | Delete Subscription
*ProvisioningApi* | [**GetSubscription**](docs/ProvisioningApi.md#getsubscription) | **GET** /messages/provisioning/subscriptions | Get Subscription


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.ErrorErrorError](docs/ErrorErrorError.md)
 - [Model.InboundPollResponse](docs/InboundPollResponse.md)
 - [Model.MMSContent](docs/MMSContent.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageSentResponse](docs/MessageSentResponse.md)
 - [Model.MessageType](docs/MessageType.md)
 - [Model.OAuthRequest](docs/OAuthRequest.md)
 - [Model.OAuthResponse](docs/OAuthResponse.md)
 - [Model.OutboundPollResponse](docs/OutboundPollResponse.md)
 - [Model.ProvisionNumberRequest](docs/ProvisionNumberRequest.md)
 - [Model.ProvisionNumberResponse](docs/ProvisionNumberResponse.md)
 - [Model.SendMmsRequest](docs/SendMmsRequest.md)
 - [Model.SendSMSRequest](docs/SendSMSRequest.md)
 - [Model.Status](docs/Status.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="auth"></a>
### auth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - NSMS: NSMS

