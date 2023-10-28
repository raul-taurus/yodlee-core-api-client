# IO.Swagger.Model.VerificationHolderProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long?** | The primary key of the account resource and the unique identifier for the account | [optional] 
**Address** | [**List&lt;AbstractAddress&gt;**](AbstractAddress.md) | The account holder&#x27;s address available at the profile and account levels | [optional] 
**PhoneNumber** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) | The account holder&#x27;s phone number available at the profile and account levels | [optional] 
**ProviderAccountId** | **long?** | The primary key of the provider account resource | [optional] 
**Holder** | [**List&lt;VerificationHolder&gt;**](VerificationHolder.md) | The holder entity is account-specific and captures the ownership status and the name details of the user | [optional] 
**Email** | [**List&lt;Email&gt;**](Email.md) | The account holder&#x27;s email ID available at the profile and account levels | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

