# YodleeCoreApis.CreateAccountInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**includeInNetWorth** | **String** |  | [optional] 
**address** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**accountName** | **String** |  | 
**accountType** | **String** |  | 
**dueDate** | **String** |  | [optional] 
**memo** | **String** |  | [optional] 
**homeValue** | [**Money**](Money.md) |  | [optional] 
**accountNumber** | **String** |  | [optional] 
**frequency** | **String** |  | [optional] 
**amountDue** | [**Money**](Money.md) |  | [optional] 
**balance** | [**Money**](Money.md) |  | [optional] 
**nickname** | **String** |  | [optional] 
**valuationType** | **String** |  | [optional] 

<a name="FrequencyEnum"></a>
## Enum: FrequencyEnum

* `DAILY` (value: `"DAILY"`)
* `ONE_TIME` (value: `"ONE_TIME"`)
* `WEEKLY` (value: `"WEEKLY"`)
* `eVERY2WEEKS` (value: `"EVERY_2_WEEKS"`)
* `SEMI_MONTHLY` (value: `"SEMI_MONTHLY"`)
* `MONTHLY` (value: `"MONTHLY"`)
* `QUARTERLY` (value: `"QUARTERLY"`)
* `SEMI_ANNUALLY` (value: `"SEMI_ANNUALLY"`)
* `ANNUALLY` (value: `"ANNUALLY"`)
* `eVERY2MONTHS` (value: `"EVERY_2_MONTHS"`)
* `EBILL` (value: `"EBILL"`)
* `FIRST_DAY_MONTHLY` (value: `"FIRST_DAY_MONTHLY"`)
* `LAST_DAY_MONTHLY` (value: `"LAST_DAY_MONTHLY"`)
* `eVERY4WEEKS` (value: `"EVERY_4_WEEKS"`)
* `UNKNOWN` (value: `"UNKNOWN"`)
* `OTHER` (value: `"OTHER"`)


<a name="ValuationTypeEnum"></a>
## Enum: ValuationTypeEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `MANUAL` (value: `"MANUAL"`)

