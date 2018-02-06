# com.telstra.messaging.Model.SendSMSRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | Phone number (in E.164 format) to send the SMS to. This number can be in international format if preceeded by a ‘+’, or in national format. | 
**Body** | **string** | The text body of the message. Messages longer than 160 characters will be counted as multiple messages. | 
**From** | **string** | Phone number (in E.164 format) the SMS was sent from. If not present, the serverice will use the mobile number associated with the application, or it be an Alphanumeric address of up to 11 characters. | [optional] 
**Validity** | **int?** | How long the platform should attempt to deliver the message for. This period is specified in minutes from the message | [optional] 
**ScheduledDelivery** | **int?** | How long the platform should wait before attempting to send the message - specified in minutes. | [optional] 
**NotifyURL** | **string** | Contains a URL that will be called once your message has been processed. The status may be delivered, expired, deleted, etc. | [optional] 
**ReplyRequest** | **bool?** | If set to true, the reply message functionality will be implemented and the to address will be ignored if present. If false or not present, then normal message handling is implemented. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

