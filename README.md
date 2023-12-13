# com.telstra.messaging - the C# library for the Messaging API v3.1.0

Send and receive SMS & MMS programmatically, leveraging Australia's leading mobile network.
With Telstra's Messaging API, we take out the complexity to allow seamless messaging integration into your app, with just a few lines of code.
Our REST API is enterprise grade, allowing you to communicate with engaging SMS & MMS messaging in your web and mobile apps in near real-time on a global scale.

- API version: 3.0.0
- SDK version: 3.0.0

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.telstra.messaging.Api;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out com.telstra.messaging.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

The nuget package for Messaging V3 is published in https://www.nuget.org/packages/TelstraMessaging/, please install nuget package TelstraMessaging v3.0.0 for developing.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using com.telstra.messaging;
using Newtonsoft.Json;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            // Initialize credentials with desired values
            Credentials credentials = new Credentials();
            credentials.ClientId = "YOUR CLIENT ID";
            credentials.ClientSecret = "YOUR CLIENT SECRET";

            try
            {
                var vn = new VirtualNumbers(credentials);
                var response = await vn.GetAll();
                Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception occurred. Response is not as expected.");
                Console.WriteLine("Exception occurred: " + ex.Message);

            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://products.api.telstra.com/messaging/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthToken**](docs/AuthenticationApi.md#authtoken) | **POST** /oauth/token | Generate an access token
*FreeTrialNumbersApi* | [**CreateTrialNumbers**](docs/FreeTrialNumbersApi.md#createtrialnumbers) | **POST** /free-trial-numbers | create free trial number list
*FreeTrialNumbersApi* | [**GetTrialNumbers**](docs/FreeTrialNumbersApi.md#gettrialnumbers) | **GET** /free-trial-numbers | get all free trial numbers
*HealthCheckApi* | [**HealthCheck**](docs/HealthCheckApi.md#healthcheck) | **GET** /health-check | health check
*MessagesApi* | [**DeleteMessageById**](docs/MessagesApi.md#deletemessagebyid) | **DELETE** /messages/{messageId} | delete a message
*MessagesApi* | [**GetMessageById**](docs/MessagesApi.md#getmessagebyid) | **GET** /messages/{messageId} | fetch a specific message
*MessagesApi* | [**GetMessages**](docs/MessagesApi.md#getmessages) | **GET** /messages | fetch all sent/received messages
*MessagesApi* | [**SendMessages**](docs/MessagesApi.md#sendmessages) | **POST** /messages | send messages
*MessagesApi* | [**UpdateMessageById**](docs/MessagesApi.md#updatemessagebyid) | **PUT** /messages/{messageId} | update a message
*MessagesApi* | [**UpdateMessageTags**](docs/MessagesApi.md#updatemessagetags) | **PATCH** /messages/{messageId} | update message tags
*ReportsApi* | [**GetReport**](docs/ReportsApi.md#getreport) | **GET** /reports/{reportId} | fetch a specific report
*ReportsApi* | [**GetReports**](docs/ReportsApi.md#getreports) | **GET** /reports | fetch all reports
*ReportsApi* | [**MessagesReport**](docs/ReportsApi.md#messagesreport) | **POST** /reports/messages | submit a request for a messages report
*VirtualNumbersApi* | [**AssignNumber**](docs/VirtualNumbersApi.md#assignnumber) | **POST** /virtual-numbers | assign a virtual number
*VirtualNumbersApi* | [**DeleteNumber**](docs/VirtualNumbersApi.md#deletenumber) | **DELETE** /virtual-numbers/{virtual-number} | delete a virtual number
*VirtualNumbersApi* | [**GetNumbers**](docs/VirtualNumbersApi.md#getnumbers) | **GET** /virtual-numbers | fetch all virtual numbers
*VirtualNumbersApi* | [**GetRecipientOptouts**](docs/VirtualNumbersApi.md#getrecipientoptouts) | **GET** /virtual-numbers/{virtual-number}/optouts | Get recipient optouts list
*VirtualNumbersApi* | [**GetVirtualNumber**](docs/VirtualNumbersApi.md#getvirtualnumber) | **GET** /virtual-numbers/{virtual-number} | fetch a virtual number
*VirtualNumbersApi* | [**UpdateNumber**](docs/VirtualNumbersApi.md#updatenumber) | **PUT** /virtual-numbers/{virtual-number} | update a virtual number


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="bearer_auth"></a>
### bearer_auth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - free-trial-numbers:read: read information for free trial numbers
  - free-trial-numbers:write: write information for free trial numbers
  - messages:read: read information for messages
  - messages:write: write information for messages
  - reports:read: read information for reports
  - reports:write: write information for reports
  - virtual-numbers:read: read information for virtual-numbers
  - virtual-numbers:write: write information for virtual numbers

## Getting Started

You can find the `Client key` and `Client secret` here: <https://dev.telstra.com/user/me/apps>.

Before `sending` and `receiving` messages you will need to get your dedicated `Australian number`, see `Subscription` section below.

For `free trial` accounts, you will need to setup a list of `registered destinations` first, see `Free Trial` section below.


This should be done before any interactions requiring authentication, such as
sending a SMS.

## Free Trial

Telstra offers a free trial for the messaging API to help you evaluate whether
it meets your needs. There are some restrictions that apply compared to the
full API, including a maximum number of messages that can be sent and requiring the
registration of a limited number of destinations before a message can be sent to that
destination. For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#FreeTrial>.

### Registering Free Trial Numbers

> :information_source: **Only required for the free trial accounts**

Register destinations for the free trial. For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#RegisteraFreeTrialNumber>.

The function `freeTrialNumbers.create` can be used to register destinations.

It takes an object with following properties as argument:

-   `freeTrialNumbers`: A list of destinations, expected to be phone numbers of the form `04XXXXXXXX`.

It returns the list of phone numbers that have been registered.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.FreeTrialNumbers;


try
{
	var ft = new FreeTrialNumbers(credentials);
	var ftList = new FreeTrialNumbersList(new List<string>() { "0434000001", "0434000002" });
	var response = await ft.Create(ftList);
}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);
}
```

### Fetch all Free Trial Numbers

> :information_source: **Only required for the free trial**

Fetch the Free Trial Number(s) currently assigned to your account. For more information,
please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#FetchyourFreeTrialNumbers>.

The function `freeTrialNumbers.getAll` can be used to retrieve registered destinations.

It takes no arguments.

It returns the list of phone numbers that have been registered.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.FreeTrialNumbers;


try
{
   var ft = new FreeTrialNumbers(credentials);
   var response = await ft.GetAll();

   ((List<string>)response.FreeTrialNumbers).ForEach(F => Console.WriteLine(F));
}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
}
```

## Virtual Number

Gives you a dedicated mobile number tied to an application which
enables you to receive replies from your customers. For more information,
please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#VirtualNumbers>.

### Assign Virtual Number

When a recipient receives your message, you can choose whether they'll see a privateNumber,
Virtual Number or senderName (paid plans only) in the from field.
If you want to use a Virtual Number, use this function to assign one.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#AssignaVirtualNumber>.

The function `virtualNumbers.assign` can be used to create a subscription.

It takes a object with following properties as argument:

-   `replyCallbackUrl` (optional): The URL that replies to the Virtual Number will be posted to.
-   `tags` (optional): Create your own tags and use them to fetch, sort and report on your Virtual Numbers through our other endpoints.
    You can assign up to 10 tags per number.

It returns an object with the following properties:

-   `virtualNumber`: The Virtual Number assigned to your account.
-   `lastUse`: The last time the Virtual Number was used to send a message.
-   `replyCallbackUrl`: The URL that replies to the Virtual Number will be posted to.
-   `tags`: Any customisable tags assigned to the Virtual Number.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
    var vn = new VirtualNumbers(credentials);
    List<string> tags = new() { "reprehenderit", "Excepteur non labore" };
    var assignVirtualNumberParams = new AssignVirtualNumberParams("http://www.example.com", tags);
    var response = await vn.Assign(assignVirtualNumberParams);
    Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);

}

```

### Fetch a Virtual Number

Fetch the tags, replyCallbackUrl and lastUse date for a Virtual Number.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#FetchaVirtualNumber>.

The function `virtualNumbers.get` can be used to get the details of a Virtual Number.

It takes the following arguments:

-   `virtualNumber`: The Virtual Number assigned to your account.

It returns an object with the following properties:

-   `virtualNumber`: The Virtual Number assigned to your account.
-   `lastUse`: The last time the Virtual Number was used to send a message.
-   `replyCallbackUrl`: The URL that replies to the Virtual Number will be posted to.
-   `tags`: Any customisable tags assigned to the Virtual Number.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
	var vn = new VirtualNumbers(credentials);               
	var response = await vn.Get("0428180739");
	Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);

}

```

### Fetch all Virtual Numbers

Fetch all Virtual Numbers currently assigned to your account.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#FetchallVirtualNumbers>.

The function `virtualNumbers.getAll` can be used to get the all virtual numbers associated to your account.

It takes an object with following prperties as argument:

-   `limit` (optional): Tell us how many results you want us to return, up to a maximum of 50.
-   `offset` (optional): Use the offset to navigate between the response results. An offset of 0 will display the first page of results, and so on.
-   `filter` (optional): Filter your Virtual Numbers by tag or by number.

It returns an object with the following properties:

-   `virtualNumbers`: A list of Virtual Numbers assigned to your account.
-   `paging`: Paging information.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
	var vn = new VirtualNumbers(credentials);
	var response = await vn.GetAll();
	Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);

}
```

### Update a Virtual Number

Update a virtual number attributes. For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#UpdateaVirtualNumber>.

The function `virtualNumbers.update` can be used to update a virtual number.

It takes an object with following properties as argument:

-   `virtualNumber`: The Virtual Number assigned to your account.
-   `updateData` (optional):
    -   `reply_callback_url` (optional): The URL that replies to the Virtual Number will be posted to.
    -   `tags` (optional): Create your own tags and use them to fetch, sort and report on your Virtual Numbers through our other endpoints.
        You can assign up to 10 tags per number.

It returns an object with the following properties:

-   `virtualNumber`: The Virtual Number assigned to your account.
-   `lastUse`: The last time the Virtual Number was used to send a message.
-   `replyCallbackUrl`: The URL that replies to the Virtual Number will be posted to.
-   `tags`: Any customisable tags assigned to the Virtual Number.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
	var vn = new VirtualNumbers(credentials);               
	List<string> tags = new() { "reprehenderit", "Excepteur non labore", "qui voluptate" };
	var assignVirtualNumberParams = new AssignVirtualNumberParams("http://www.example.com", tags);
	var updateVirtualNumberParams = new UpdateVirtualNumberParams("0428180739", assignVirtualNumberParams);
	var response = await vn.Update(updateVirtualNumberParams);
	Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);

}
```

### Delete Virtual Number

Delete the a virtual number. For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#DeleteaVirtualNumber>.

The function `virtualNumbers.get` can be used to unassign a Virtual Number.

It takes the following arguments:

-   `virtualNumber`: The Virtual Number assigned to your account.

It returns nothing.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
	var vn = new VirtualNumbers(credentials);
	await vn.Delete("0428180739");
}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);

}
```


### Fetch all Recipient Optouts list

Fetch any mobile number(s) that have opted out of receiving messages
from a Virtual Number assigned to your account.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Fetchallrecipientoptoutslist>.

The function `telstra.messaging.virtual_number.get_optouts` can be used to
get the list of mobile numbers that have opted out of receiving messages
from a virtual number associated to your account.
It takes the following arguments:

- `virtual_number`: The Virtual Number assigned to your account.
- `limit`: Tell us how many results you want us to return, up to a maximum of 50.
- `offset`: Use the offset to navigate between the response results.
  An offset of 0 will display the first page of results, and so on.

Raises `telstra.messaging.exceptions.VirtualNumbersError` if anything goes wrong.

It returns an object with the following
properties:

- `recipient_optouts`: A list of recipient optouts.
- `paging`: Paging information.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using Newtonsoft.Json;

try
{
    var vn = new VirtualNumbers(credentials);
    var response = await vn.GetOptouts("0428180739");
    Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);

}
```


## Message

Send and receive messages. For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Messages>.

### Send Message

Send a message to a mobile number, or to multiple mobile numbers.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#SendanSMSorMMS>.

The function `messages.send` can be used to send a message.

It takes an object with following properties as argument:

-   `to`: The destination address, expected to be a phone number of the form `+614XXXXXXXX` or `04XXXXXXXX`.
-   `from`: This will be either "privateNumber", one of your Virtual Numbers or your senderName.
-   `messageContent` (Either one of messageContent or multimedia is required): The content of the message.
-   `multimedia` (Either one of messageContent or multimedia is required): MMS multimedia content.
-   `retryTimeout` (optional): How many minutes you asked the server to keep trying to send the message.
-   `scheduleSend` (optional): The time (in Central Standard Time) the message is scheduled to send.
-   `deliveryNotification` (optional): If set to true, you will receive a notification to the statusCallbackUrl when your
    SMS or MMS is delivered (paid feature).
-   `statusCallbackUrl` (optional): The URL the API will call when the status of the message changes.
-   `tags` (optional): Any customisable tags assigned to the message.

The type `TMultimedia`can be used to build an mms payload. It has following properties:

-   `type`: The content type of the attachment, for example <TMultimediaContentType.IMAGE_GIF>.
-   `fileName` (optional): Optional field, for example `image.png`.
-   `payload`: The payload of an mms encoded as base64.

It returns an object with the following properties:

-   `messageId`: Use this UUID with our other endpoints to fetch, update or delete the message.
-   `status`: The status will be either queued, sent, delivered or expired.
-   `to`: The recipient's mobile number(s).
-   `from`: This will be either "privateNumber", one of your Virtual Numbers or your senderName.
-   `messageContent`: The content of the message.
-   `multimedia`: The multimedia content of the message (MMS only).
-   `retryTimeout`: How many minutes you asked the server to keep trying to send the message.
-   `scheduleSend`: The time (in Central Standard Time) a message is scheduled to send.
-   `deliveryNotification`: If set to true, you will receive a notification to the
    statusCallbackUrl when your SMS or MMS is delivered (paid feature).
-   `statusCallbackUrl`: The URL the API will call when the status of the message changes.
-   `tags`: Any customisable tags assigned to the message.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    var multimediaAttachment = new Multimedia(MultiMediaContentType.IMAGE_GIF, "bus.gif", "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");
    var sendMessageParams = new SendMessageParams(new List<string>() { "0434651022" }, "privateNumber", "Hello from .NET SDK", new List<Multimedia>() { multimediaAttachment });
    var response = await sm.Send(sendMessageParams);

}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);

}
```

### Get a Message

Use the messageId to fetch a message that's been sent from/to
your account within the last 30 days.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Fetchamessage>.

The function `messages.get` can be used to retrieve the a message.

It takes the following arguments:

-   `messageId`: Unique identifier for the message.

It returns an object with the following properties:

-   `messageId`: Use this UUID with our other endpoints to fetch, update or delete the message.
-   `status`: The status will be either queued, sent, delivered or expired.
-   `createTimestamp`: The time you submitted the message to the queue for sending.
-   `sentTimestamp`: The time the message was sent from the server.
-   `receivedTimestamp`: The time the message was received by the recipient's device.
-   `to`: The recipient's mobile number(s).
-   `from`: This will be either "privateNumber", one of your Virtual Numbers or your senderName.
-   `messageContent`: The content of the message.
-   `multimedia`: The multimedia content of the message (MMS only).
-   `direction`: Direction of the message (outgoing or incoming).
-   `retryTimeout`: How many minutes you asked the server to keep trying to send the message.
-   `scheduleSend`: The time (in Central Standard Time) the message is scheduled to send.
-   `deliveryNotification`: If set to true, you will receive a notification to the statusCallbackUrl when your SMS or MMS
    is delivered (paid feature).
-   `statusCallbackUrl`: The URL the API will call when the status of the message changes.
-   `queuePriority`: The priority assigned to the message.
-   `tags`: Any customisable tags assigned to the message.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    var response = await sm.Get("3247a620-4c38-11ee-a651-ad71114ff6eb");
    Console.WriteLine("response: " + response);
}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);

}	
```

### Get all Messages

Fetch messages that have been sent from/to your account in the last 30 days.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Fetchallsent/receivedmessages>.

The function `messages.getAll` can be used to fetch all messages.

It takes an object with following properties as argument:

-   `limit` (optional): Tell us how many results you want us to return, up to a maximum of 50.
-   `offset` (optional): Use the offset to navigate between the response results. An offset of 0 will display the first page of results, and so on.
-   `filter` (optional): Filter your Virtual Numbers by tag or by number.

It returns an object with the following properties:

-   `messages`: List of all messages.
-   `paging`: Paging information.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    var response = await sm.GetAll();
    Console.WriteLine("response: " + response);
}
catch (Exception ex)
{
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);

}	
```

### Update a Message

Update a message that's scheduled for sending, you can change any of
the below parameters, as long as the message hasn't been sent yet.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Updateamessage>.

The function `messages.send` can be used to send a message.

It takes an object with following properties as argument:

-   `messageId`: Use this UUID with our other endpoints to fetch, update or delete the message.
-   `to`: The destination address, expected to be a phone number of the form `+614XXXXXXXX` or `04XXXXXXXX`.
-   `from`: This will be either "privateNumber", one of your Virtual Numbers or your senderName.
-   `messageContent` (Either one of messageContent or multimedia is required): The content of the message.
-   `multimedia` (Either one of messageContent or multimedia is required): MMS multimedia content.
-   `retryTimeout` (optional): How many minutes you asked the server to keep trying to send the message.
-   `scheduleSend` (optional): The time (in Central Standard Time) the message is scheduled to send.
-   `deliveryNotification` (optional): If set to true, you will receive a notification to the statusCallbackUrl when your
    SMS or MMS is delivered (paid feature).
-   `statusCallbackUrl` (optional): The URL the API will call when the status of the message changes.
-   `tags` (optional): Any customisable tags assigned to the message.

The type `TMultimedia`can be used to build an mms payload. It has following properties:

-   `type`: The content type of the attachment, for example <TMultimediaContentType.IMAGE_GIF>.
-   `fileName` (optional): Optional field, for example `image.png`.
-   `payload`: The payload of an mms encoded as base64.

The dataclass `telstra.messaging.message.Multimedia` can be used to build
a mms payload. It takes the following arguments:

-   `type`: The content type of the attachment, for example `image/png`.
-   `filename` (optional): Optional field, for example `image.png`.
-   `payload`: The payload of an mms encoded as base64.

It returns an object with the following properties:

-   `messageId`: Use this UUID with our other endpoints to fetch, update or delete the message.
-   `status`: The status will be either queued, sent, delivered or expired.
-   `to`: The recipient's mobile number(s).
-   `from`: This will be either "privateNumber", one of your Virtual Numbers or your senderName.
-   `messageContent`: The content of the message.
-   `multimedia`: The multimedia content of the message (MMS only).
-   `retryTimeout`: How many minutes you asked the server to keep trying to send the message.
-   `scheduleSend`: The time (in Central Standard Time) a message is scheduled to send.
-   `deliveryNotification`: If set to true, you will receive a notification to the
    statusCallbackUrl when your SMS or MMS is delivered (paid feature).
-   `statusCallbackUrl`: The URL the API will call when the status of the message changes.
-   `tags`: Any customisable tags assigned to the message.

For example:

```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    string messageId = "9773af40-58da-11ee-ab5d-b5c3bb7fbef4";
    string to = "0434651022";
    string from = "privateNumber";
    string messageContent = "Hello from .NET SDK";
    var multimediaAttachment = new Multimedia(MultiMediaContentType.IMAGE_GIF, "bus.gif", "R0lGODlhPQBEAPeoAJosM//AwO/AwHVYZ/z595kzAP/s7P+goOXMv8+fhw/v739/f+8PD98fH/8mJl+fn/9ZWb8/PzWlwv///6wWGbImAPgTEMImIN9gUFCEm/gDALULDN8PAD6atYdCTX9gUNKlj8wZAKUsAOzZz+UMAOsJAP/Z2ccMDA8PD/95eX5NWvsJCOVNQPtfX/8zM8+QePLl38MGBr8JCP+zs9myn/8GBqwpAP/GxgwJCPny78lzYLgjAJ8vAP9fX/+MjMUcAN8zM/9wcM8ZGcATEL+QePdZWf/29uc/P9cmJu9MTDImIN+/r7+/vz8/P8VNQGNugV8AAF9fX8swMNgTAFlDOICAgPNSUnNWSMQ5MBAQEJE3QPIGAM9AQMqGcG9vb6MhJsEdGM8vLx8fH98AANIWAMuQeL8fABkTEPPQ0OM5OSYdGFl5jo+Pj/+pqcsTE78wMFNGQLYmID4dGPvd3UBAQJmTkP+8vH9QUK+vr8ZWSHpzcJMmILdwcLOGcHRQUHxwcK9PT9DQ0O/v70w5MLypoG8wKOuwsP/g4P/Q0IcwKEswKMl8aJ9fX2xjdOtGRs/Pz+Dg4GImIP8gIH0sKEAwKKmTiKZ8aB/f39Wsl+LFt8dgUE9PT5x5aHBwcP+AgP+WltdgYMyZfyywz78AAAAAAAD///8AAP9mZv///wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH5BAEAAKgALAAAAAA9AEQAAAj/AFEJHEiwoMGDCBMqXMiwocAbBww4nEhxoYkUpzJGrMixogkfGUNqlNixJEIDB0SqHGmyJSojM1bKZOmyop0gM3Oe2liTISKMOoPy7GnwY9CjIYcSRYm0aVKSLmE6nfq05QycVLPuhDrxBlCtYJUqNAq2bNWEBj6ZXRuyxZyDRtqwnXvkhACDV+euTeJm1Ki7A73qNWtFiF+/gA95Gly2CJLDhwEHMOUAAuOpLYDEgBxZ4GRTlC1fDnpkM+fOqD6DDj1aZpITp0dtGCDhr+fVuCu3zlg49ijaokTZTo27uG7Gjn2P+hI8+PDPERoUB318bWbfAJ5sUNFcuGRTYUqV/3ogfXp1rWlMc6awJjiAAd2fm4ogXjz56aypOoIde4OE5u/F9x199dlXnnGiHZWEYbGpsAEA3QXYnHwEFliKAgswgJ8LPeiUXGwedCAKABACCN+EA1pYIIYaFlcDhytd51sGAJbo3onOpajiihlO92KHGaUXGwWjUBChjSPiWJuOO/LYIm4v1tXfE6J4gCSJEZ7YgRYUNrkji9P55sF/ogxw5ZkSqIDaZBV6aSGYq/lGZplndkckZ98xoICbTcIJGQAZcNmdmUc210hs35nCyJ58fgmIKX5RQGOZowxaZwYA+JaoKQwswGijBV4C6SiTUmpphMspJx9unX4KaimjDv9aaXOEBteBqmuuxgEHoLX6Kqx+yXqqBANsgCtit4FWQAEkrNbpq7HSOmtwag5w57GrmlJBASEU18ADjUYb3ADTinIttsgSB1oJFfA63bduimuqKB1keqwUhoCSK374wbujvOSu4QG6UvxBRydcpKsav++Ca6G8A6Pr1x2kVMyHwsVxUALDq/krnrhPSOzXG1lUTIoffqGR7Goi2MAxbv6O2kEG56I7CSlRsEFKFVyovDJoIRTg7sugNRDGqCJzJgcKE0ywc0ELm6KBCCJo8DIPFeCWNGcyqNFE06ToAfV0HBRgxsvLThHn1oddQMrXj5DyAQgjEHSAJMWZwS3HPxT/QMbabI/iBCliMLEJKX2EEkomBAUCxRi42VDADxyTYDVogV+wSChqmKxEKCDAYFDFj4OmwbY7bDGdBhtrnTQYOigeChUmc1K3QTnAUfEgGFgAWt88hKA6aCRIXhxnQ1yg3BCayK44EWdkUQcBByEQChFXfCB776aQsG0BIlQgQgE8qO26X1h8cEUep8ngRBnOy74E9QgRgEAC8SvOfQkh7FDBDmS43PmGoIiKUUEGkMEC/PJHgxw0xH74yx/3XnaYRJgMB8obxQW6kL9QYEJ0FIFgByfIL7/IQAlvQwEpnAC7DtLNJCKUoO/w45c44GwCXiAFB/OXAATQryUxdN4LfFiwgjCNYg+kYMIEFkCKDs6PKAIJouyGWMS1FSKJOMRB/BoIxYJIUXFUxNwoIkEKPAgCBZSQHQ1A2EWDfDEUVLyADj5AChSIQW6gu10bE/JG2VnCZGfo4R4d0sdQoBAHhPjhIB94v/wRoRKQWGRHgrhGSQJxCS+0pCZbEhAAOw==");
    DateTime scheduleSend = DateTime.UtcNow.AddHours(20);
    List<string> tags = new() { "reprehenderit", "Excepteur non labore", "qui voluptate" };            
    var updateMessageParams = new UpdateMessageParams(to, from, messageContent, new List<Multimedia>() { multimediaAttachment }, 10, scheduleSend, false, "http://www.example.com", 2, tags);
    var response = await sm.Update(messageId, updateMessageParams);
    Console.WriteLine("response: " + response);
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}	
	
```
   
### Update Message Tags
   
Update message tags, you can update them even after your message has been delivered.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Updatemessagetags>.
   
The function `messages.updateTags` can be used to update message tags.
   
It takes the following arguments:
   
-   `messageId`: Unique identifier for the message.
-   `tags` (optional): Any customisable tags assigned to the message.
   
It returns nothing.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    string messageId = "9773af40-58da-11ee-ab5d-b5c3bb7fbef4";
    List<string> tags = new List<string> { "marketing", "SMS" };
    UpdateMessageTagsParams updateMessageTagsParams = new UpdateMessageTagsParams(tags);
    await sm.UpdateTags(messageId, updateMessageTagsParams);
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}
   
```
   
### Delete a Message
   
Delete a scheduled message, but hasn't yet sent.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Deleteamessage>.
   
The function `messages.delete` can be used to delete a message.
   
It takes the following arguments:
   
-   `messageId`: Unique identifier for the message.
   
It returns nothing.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;

try
{
    var sm = new Messages(credentials);
    await sm.Delete("cd8cbda0-4c33-11ee-966e-7bcedb926a5d");
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}
```
   
## Reports
   
Create and fetch reports. For more information, please see here:
<https://dev.telstra.com/content/messaging-api-v3#tag/reports>.
   
### Request a Messages Report
   
Request a CSV report of messages (both incoming and outgoing)
that have been sent to/from your account within the last three months.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Submitarequestforamessagesreport>.
   
The function `reports.create` can be used to create a report.
   
It takes the following arguments:
   
-   `startDate`: Set the time period you want to generate a report for by typing the start date (inclusive) here.
    Note that we only retain data for three months, so please ensure your startDate is not more than three months old.
    Use ISO format(yyyy-mm-dd), e.g. "2019-08-24".
-   `endDate`: Type the end date (inclusive) of your reporting period here.
    Your endDate must be a date in the past, and less than three months from your startDate.
    Use ISO format(yyyy-mm-dd), e.g. "2019-08-24".
-   `reportCallbackUrl` (optional): The callbackUrl where notification is sent when report is ready for download.
-   `filter` (optional): Filter report messages by:
    tag - use one of the tags assigned to your message(s)
    number - either the Virtual Number used to send the message,
    or the Recipient Number the message was sent to.
   
It returns an object with the following properties:
   
-   `reportId`: Use this UUID with our other endpoints to fetch the report.
-   `reportCallbackUrl`: If you provided a reportCallbackUrl in your request, it will be returned here.
-   `reportStatus`: The status of the report. It will be either:
    -   queued – the report is in the queue for generation.
    -   completed – the report is ready for download.
    -   failed – the report failed to generate, please try again.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

try
{
    var reports = new Reports(credentials);
    var response = await reports.GetAll();
    Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}
```
   
   
   
### Fetch a specific report
   
Use the report_id to fetch a download link for a report generated.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#FetchaReport>.
   
The function `reports.get` can be used to retrieve
the a report download link. It takes the following arguments:
   
-   `reportId`: Unique identifier for the report.
   
It returns an object with the following properties:
   
-   `reportId`: Use this UUID with our other endpoints to fetch the report.
-   `reportStatus`: The status of the report.
-   `reportUrl`: Download link to download the CSV file.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

try
{
    var reports = new Reports(credentials);
    var response = await reports.Get("0eaf6960-580d-11ee-986c-e35ce4792749");
    Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}	
```
   
### Fetch all reports
   
Fetch details of all reports recently generated for your account.
Use it to check the status of a report, plus fetch the report ID,
status, report type and expiry date.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#Fetchallreports>.
   
The function `reports.getAll` can be used to fetch all reports.
   
It doesn't take any arguments.
   
It returns a list of objects with the following properties:
   
-   `reportId`: Use this UUID with our other endpoints to fetch the report.
-   `reportStatus`: The status of the report.
-   `reportType`: The type of report generated.
-   `reportExpiry`: The expiry date of your report. After this date, you will be unable to download your report.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;

try
{
    var reports = new Reports(credentials);
    var response = await reports.GetAll();
    Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");
}  
catch (Exception ex)
{  
    Assert.Fail("Exception occurred. Response is not as expected.");
    Console.WriteLine("Exception occurred: " + ex.Message);
   
}	
```
   
## Health Check
   
### Get operational status of the messaging service
   
Check the operational status of the messaging service.
For more information, please see here:
<https://dev.telstra.com/docs/messaging-api/apiReference/apiReferenceOverviewEndpoints?version=3.x#HealthCheck>.
   
The function `healthCheck.get` can be used to get the status.
   
It takes no arguments.
   
It returns an object with following properties:
   
-   `status`: Denotes the status of the services Up/Down.
   
For example:
   
```csharp
using com.telstra.messaging.Models.Common;

try
{
	var healthCheck = new HealthCheck(credentials);
	var response = await healthCheck.GetStatus();
	Assert.Equal("up", response.Status);

}
catch (Exception ex)
{
	Assert.Fail("Exception occurred. Response is not as expected.");
	Console.WriteLine("Exception occurred: " + ex.Message);

}
```
   
   
   
