# YodleeCoreApis.Merchant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**website** | **String** | The website of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt; | [optional] 
**address** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**contact** | [**Contact**](Contact.md) |  | [optional] 
**categoryLabel** | **[String]** | The business categories of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**coordinates** | [**Coordinates**](Coordinates.md) |  | [optional] 
**name** | **String** | The name of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**id** | **String** | Identifier of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**source** | **String** | The source through which merchant information is retrieved.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**logoURL** | **String** | The logoURL of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt; | [optional] 

<a name="SourceEnum"></a>
## Enum: SourceEnum

* `YODLEE` (value: `"YODLEE"`)
* `FACTUAL` (value: `"FACTUAL"`)

