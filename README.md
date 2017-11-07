# Getting started


The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.

It also allows your application to track the delivery status of both sent and received SMS messages.


## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (TelstraMessagingAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

## Initialization

### Example
```csharp
using TelstraMessagingAPI.Standard;
using TelstraMessagingAPI.Standard.Models;
using TelstraMessagingAPI.Standard.Exceptions;
using System.Collections.Generic;

namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
           string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
           string oAuthClientSecret = "oAuthClientSecret"; // OAuth 2 Client Secret
           
            TelstraMessagingAPIClient client = new TelstraMessagingAPIClient(oAuthClientId, oAuthClientSecret);

            object storedToken = client.Auth.Authorize(new List<OAuthScopeEnum>(){OAuthScopeEnum.NSMS});
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [ProvisioningController](#provisioning_controller)
* [MessagingController](#messaging_controller)

## <a name="provisioning_controller"></a>![Class: ](https://apidocs.io/img/class.png "TelstraMessagingAPI.Standard.Controllers.ProvisioningController") ProvisioningController

### Get singleton instance

The singleton instance of the ``` ProvisioningController ``` class can be accessed from the API Client.

```csharp
ProvisioningController provisioning = client.Provisioning;
```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

### <a name="delete_subscription"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.ProvisioningController.DeleteSubscription") DeleteSubscription

> Delete Subscription


```csharp
Task DeleteSubscription()
```

#### Example Usage

```csharp

await provisioning.DeleteSubscription();

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does not have permission |
| 404 | The requested URI does not exist |
| 0 | An internal error occurred when processing the request |


### <a name="create_subscription"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.ProvisioningController.CreateSubscription") CreateSubscription

> Create Subscription


```csharp
Task<Models.ProvisionNumberResponse> CreateSubscription(Models.ProvisionNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | A JSON payload containing the required attributes |


#### Example Usage

```csharp
var body = new Models.ProvisionNumberRequest();

Models.ProvisionNumberResponse result = await provisioning.CreateSubscription(body);

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does not have permission |
| 404 | The requested URI does not exist |
| 0 | An internal error occurred when processing the request |


### <a name="get_subscription"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.ProvisioningController.GetSubscription") GetSubscription

> Get Subscription


```csharp
Task<Models.ProvisionNumberResponse> GetSubscription()
```

#### Example Usage

```csharp

Models.ProvisionNumberResponse result = await provisioning.GetSubscription();

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does not have permission |
| 404 | The requested URI does not exist |
| 0 | An internal error occurred when processing the request |


[Back to List of Controllers](#list_of_controllers)

## <a name="messaging_controller"></a>![Class: ](https://apidocs.io/img/class.png "TelstraMessagingAPI.Standard.Controllers.MessagingController") MessagingController

### Get singleton instance

The singleton instance of the ``` MessagingController ``` class can be accessed from the API Client.

```csharp
MessagingController messaging = client.Messaging;
```

### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.MessagingController.CreateSendSMS") CreateSendSMS

> Send SMS

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payload |  ``` Required ```  | A JSON or XML payload containing the recipient's phone number and text message.

The recipient number should be in the format '04xxxxxxxx' where x is a digit |


#### Example Usage

```csharp
var payload = new Models.SendSMSRequest();

Models.MessageSentResponse result = await messaging.CreateSendSMS(payload);

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does<br>not have permission |
| 404 | The requested URI does not exist |
| 405 | The requested resource does not support the supplied verb |
| 415 | API does not support the requested content type |
| 422 | The request is formed correctly, but due to some condition<br>the request cannot be processed e.g. email is required and it is not provided<br>in the request |
| 501 | The HTTP method being used has not yet been implemented for<br>the requested resource |
| 503 | The service requested is currently unavailable |
| 0 | An internal error occurred when processing the request |


### <a name="get_sms_status"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.MessagingController.GetSMSStatus") GetSMSStatus

> Get SMS Status

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageId |  ``` Required ```  | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/sms |


#### Example Usage

```csharp
string messageId = "messageId";

List<Models.OutboundPollResponse> result = await messaging.GetSMSStatus(messageId);

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does<br>not have permission |
| 404 | The requested URI does not exist |
| 405 | The requested resource does not support the supplied verb |
| 415 | API does not support the requested content type |
| 422 | The request is formed correctly, but due to some condition<br>the request cannot be processed e.g. email is required and it is not provided<br>in the request |
| 501 | The HTTP method being used has not yet been implemented for<br>the requested resource |
| 503 | The service requested is currently unavailable |
| 0 | An internal error occurred when processing the request |


### <a name="create_send_mms"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.MessagingController.CreateSendMMS") CreateSendMMS

> Send MMS

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | A JSON or XML payload containing the recipient's phone number
and MMS message.The recipient number should be in the format '04xxxxxxxx'
where x is a digit |


#### Example Usage

```csharp
var body = new Models.SendMMSRequest();

dynamic result = await messaging.CreateSendMMS(body);

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does<br>not have permission |
| 404 | The requested URI does not exist |
| 405 | The requested resource does not support the supplied verb |
| 415 | API does not support the requested content type |
| 422 | The request is formed correctly, but due to some condition<br>the request cannot be processed e.g. email is required and it is not provided<br>in the request |
| 501 | The HTTP method being used has not yet been implemented for<br>the requested resource |
| 503 | The service requested is currently unavailable |
| 0 | An internal error occurred when processing the request |


### <a name="get_mms_status"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.MessagingController.GetMMSStatus") GetMMSStatus

> Get MMS Status

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageid |  ``` Required ```  | Unique identifier of a message - it is the value returned from
a previous POST call to https://api.telstra.com/v2/messages/mms |


#### Example Usage

```csharp
string messageid = "messageid";

List<Models.OutboundPollResponse> result = await messaging.GetMMSStatus(messageid);

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does<br>not have permission |
| 404 | The requested URI does not exist |
| 405 | The requested resource does not support the supplied verb |
| 415 | API does not support the requested content type |
| 422 | The request is formed correctly, but due to some condition<br>the request cannot be processed e.g. email is required and it is not provided<br>in the request |
| 501 | The HTTP method being used has not yet been implemented for<br>the requested resource |
| 503 | The service requested is currently unavailable |
| 0 | An internal error occurred when processing the request |


### <a name="retrieve_sms_responses"></a>![Method: ](https://apidocs.io/img/method.png "TelstraMessagingAPI.Standard.Controllers.MessagingController.RetrieveSMSResponses") RetrieveSMSResponses

> Retrieve SMS Responses

#### Example Usage

```csharp

Models.InboundPollResponse result = await messaging.RetrieveSMSResponses();

```

See the documentation at [Dev.Telstra.com](https://dev.telstra.com/content/messaging-api) for more information

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid or missing request parameters |
| 401 | Invalid or no credentials passed in the request |
| 403 | Authorization credentials passed and accepted but account does<br>not have permission |
| 404 | The requested URI does not exist |
| 405 | The requested resource does not support the supplied verb |
| 415 | API does not support the requested content type |
| 422 | The request is formed correctly, but due to some condition<br>the request cannot be processed e.g. email is required and it is not provided<br>in the request |
| 501 | The HTTP method being used has not yet been implemented for<br>the requested resource |
| 503 | The service requested is currently unavailable |
| 0 | An internal error occurred when processing the request |


[Back to List of Controllers](#list_of_controllers)



