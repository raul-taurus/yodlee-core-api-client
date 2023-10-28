# YodleeCoreApis.TransactionCategory

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**highLevelCategoryName** | **String** | The name of the high level category. A group of similar transaction categories are clubbed together to form a high-level category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**defaultHighLevelCategoryName** | **String** | A attribute which will always hold the first value(initial name) of Yodlee defined highLevelCategoryName attribute.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**highLevelCategoryId** | **Number** | The unique identifier of the high level category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**detailCategory** | [**[DetailCategory]**](DetailCategory.md) | Entity that provides detail category attributes&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**id** | **Number** | Unique identifier of the category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**source** | **String** | Source used to identify whether the transaction category is user defined category or system created category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**category** | **String** | The name of the category.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: Transaction categorization is one of the core features offered by Yodlee and the categories are assigned to the transactions by the system. Transactions can be clubbed together by the category that is assigned to them.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**classification** | **String** | Category Classification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**type** | **String** | Transaction categories and high-level categories are further mapped to five transaction category types. Customers, based on their needs can either use the transaction categories, the high-level categories, or the transaction category types. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**defaultCategoryName** | **String** | A attribute which will always hold the first value(initial name) of Yodlee defined category attribute.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 

<a name="SourceEnum"></a>
## Enum: SourceEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `USER` (value: `"USER"`)


<a name="ClassificationEnum"></a>
## Enum: ClassificationEnum

* `PERSONAL` (value: `"PERSONAL"`)
* `BUSINESS` (value: `"BUSINESS"`)


<a name="TypeEnum"></a>
## Enum: TypeEnum

* `TRANSFER` (value: `"TRANSFER"`)
* `DEFERRED_COMPENSATION` (value: `"DEFERRED_COMPENSATION"`)
* `UNCATEGORIZE` (value: `"UNCATEGORIZE"`)
* `INCOME` (value: `"INCOME"`)
* `EXPENSE` (value: `"EXPENSE"`)

