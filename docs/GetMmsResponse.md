# Telstra.Messaging.Model.GetMmsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The final state of the message.  | 
**DestinationAddress** | **string** | The number the message was sent to.  | 
**SenderAddress** | **string** | The number the message was sent from.  | 
**Subject** | **string** | The subject assigned to the message.  | [optional] 
**MessageId** | **string** | Message Id assigned by the MMSC.  | [optional] 
**ApiMsgId** | **string** | Message Id assigned by the API.  | [optional] 
**SentTimestamp** | **string** | Time handling of the message ended.  | 
**MMSContent** | [**List&lt;MMSContent&gt;**](MMSContent.md) | An array of content that was received in an MMS message.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

