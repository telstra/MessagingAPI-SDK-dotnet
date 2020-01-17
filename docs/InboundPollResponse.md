# Telstra.Messaging.Model.InboundPollResponse
Poll for incoming messages returning the latest. Only works if no callback url was specified when provisioning a number. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | message status | [optional] 
**DestinationAddress** | **string** | The phone number (recipient) that the message was sent to (in E.164 format).  | [optional] 
**SenderAddress** | **string** | The phone number (sender) that the message was sent from (in E.164 format).  | [optional] 
**Message** | **string** | Text of the message that was sent | [optional] 
**MessageId** | **string** | Message Id | [optional] 
**SentTimestamp** | **string** | The date and time when the message was sent by recipient. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

