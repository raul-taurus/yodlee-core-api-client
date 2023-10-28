# YodleeCoreApis.DerivedTransactionsSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**categoryType** | **String** | Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**categorySummary** | [**[DerivedCategorySummary]**](DerivedCategorySummary.md) | Summary of transaction amouts at category level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt; | [optional] 
**creditTotal** | [**Money**](Money.md) |  | [optional] 
**links** | [**DerivedTransactionsLinks**](DerivedTransactionsLinks.md) |  | [optional] 
**debitTotal** | [**Money**](Money.md) |  | [optional] 

<a name="CategoryTypeEnum"></a>
## Enum: CategoryTypeEnum

* `TRANSFER` (value: `"TRANSFER"`)
* `DEFERRED_COMPENSATION` (value: `"DEFERRED_COMPENSATION"`)
* `UNCATEGORIZE` (value: `"UNCATEGORIZE"`)
* `INCOME` (value: `"INCOME"`)
* `EXPENSE` (value: `"EXPENSE"`)

