# YodleeCoreApis.RuleClause

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**field** | **String** | Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**userDefinedRuleId** | **Number** | Unique identifier generated for every rule the user creates.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**fieldValue** | **String** | The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**operation** | **String** | Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 
**ruleClauseId** | **Number** | Unique identifier generated for the rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] 

<a name="FieldEnum"></a>
## Enum: FieldEnum

* `amount` (value: `"amount"`)
* `description` (value: `"description"`)


<a name="OperationEnum"></a>
## Enum: OperationEnum

* `numberEquals` (value: `"numberEquals"`)
* `numberLessThan` (value: `"numberLessThan"`)
* `numberLessThanEquals` (value: `"numberLessThanEquals"`)
* `numberGreaterThan` (value: `"numberGreaterThan"`)
* `numberGreaterThanEquals` (value: `"numberGreaterThanEquals"`)
* `stringEquals` (value: `"stringEquals"`)
* `stringContains` (value: `"stringContains"`)

