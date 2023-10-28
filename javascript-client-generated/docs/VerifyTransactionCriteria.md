# YodleeCoreApis.VerifyTransactionCriteria

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_date** | **String** |  | 
**amount** | **Number** |  | 
**verifiedTransaction** | [**[Transaction]**](Transaction.md) |  | [optional] 
**matched** | **String** | Indicates if the criteria is matched or not. &lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**keyword** | **String** |  | [optional] 
**dateVariance** | **String** |  | [optional] 
**baseType** | **String** | Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 

<a name="MatchedEnum"></a>
## Enum: MatchedEnum

* `COMPLETE` (value: `"COMPLETE"`)
* `NONE` (value: `"NONE"`)


<a name="BaseTypeEnum"></a>
## Enum: BaseTypeEnum

* `CREDIT` (value: `"CREDIT"`)
* `DEBIT` (value: `"DEBIT"`)

