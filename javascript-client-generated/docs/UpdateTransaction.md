# YodleeCoreApis.UpdateTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**categorySource** | **String** |  | 
**container** | **String** |  | 
**isPhysical** | **Boolean** |  | [optional] 
**detailCategoryId** | **Number** |  | [optional] 
**description** | [**Description**](Description.md) |  | [optional] 
**memo** | **String** |  | [optional] 
**merchantType** | **String** |  | [optional] 
**categoryId** | **Number** |  | 

<a name="CategorySourceEnum"></a>
## Enum: CategorySourceEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `USER` (value: `"USER"`)


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


<a name="MerchantTypeEnum"></a>
## Enum: MerchantTypeEnum

* `BILLERS` (value: `"BILLERS"`)
* `SUBSCRIPTION` (value: `"SUBSCRIPTION"`)
* `OTHERS` (value: `"OTHERS"`)

