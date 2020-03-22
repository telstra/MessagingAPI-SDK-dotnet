# Telstra.Messaging.Model.MessageSentResponseMms
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;Message&gt;**](Message.md) | An array of messages. | 
**MmsMediaKB** | **int** | Indicates the message size in kB of the MMS sent.  | [optional] 
**Country** | **List&lt;Object&gt;** | An array of the countries to which the destination MSISDNs belong. | [optional] 
**MessageType** | **string** | This returns whether the message sent was a SMS or MMS. | 
**NumberSegments** | **int** | MMS with numberSegments below 600 are classed as Small whereas those that are bigger than 600 are classed as Large. They will be charged accordingly.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

