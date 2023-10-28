# YodleeCoreApis.UpdateAccountInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**container** | **String** |  | [optional] 
**includeInNetWorth** | **String** |  | [optional] 
**address** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**accountName** | **String** |  | [optional] 
**dueDate** | **String** |  | [optional] 
**memo** | **String** |  | [optional] 
**homeValue** | [**Money**](Money.md) |  | [optional] 
**accountNumber** | **String** |  | [optional] 
**frequency** | **String** |  | [optional] 
**accountStatus** | **String** |  | [optional] 
**amountDue** | [**Money**](Money.md) |  | [optional] 
**linkedAccountIds** | **[Number]** | List of loan accounts to which a real-estate account is linked. | [optional] 
**balance** | [**Money**](Money.md) |  | [optional] 
**isEbillEnrolled** | **String** |  | [optional] 
**nickname** | **String** |  | [optional] 

<a name="ContainerEnum"></a>
## Enum: ContainerEnum

* `bank` (value: `"bank"`)
* `creditCard` (value: `"creditCard"`)
* `investment` (value: `"investment"`)
* `insurance` (value: `"insurance"`)
* `loan` (value: `"loan"`)
* `reward` (value: `"reward"`)
* `bill` (value: `"bill"`)
* `realEstate` (value: `"realEstate"`)
* `otherAssets` (value: `"otherAssets"`)
* `otherLiabilities` (value: `"otherLiabilities"`)


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


<a name="AccountStatusEnum"></a>
## Enum: AccountStatusEnum

* `ACTIVE` (value: `"ACTIVE"`)
* `INACTIVE` (value: `"INACTIVE"`)
* `TO_BE_CLOSED` (value: `"TO_BE_CLOSED"`)
* `CLOSED` (value: `"CLOSED"`)
* `DELETED` (value: `"DELETED"`)

