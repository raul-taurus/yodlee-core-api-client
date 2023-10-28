# YodleeCoreApis.Document

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountID** | **Number** | The unique identifier for the account. The account ID to which the document is linked.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**lastUpdated** | **String** | Indicates the date and time the document was last updated.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**formType** | **String** | Indicates the type of the tax form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**docType** | **String** | Indicates the type of the document.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**name** | **String** | Indicates the name of the document.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**id** | **String** | The document&#x27;s primary key and unique identifier.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**source** | **String** | Indicates the source of the document download.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 
**status** | **String** | Indicates the status of the document download.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, creditCard, loan, insurance&lt;br&gt; | [optional] 

<a name="DocTypeEnum"></a>
## Enum: DocTypeEnum

* `STMT` (value: `"STMT"`)
* `TAX` (value: `"TAX"`)
* `EBILL` (value: `"EBILL"`)

