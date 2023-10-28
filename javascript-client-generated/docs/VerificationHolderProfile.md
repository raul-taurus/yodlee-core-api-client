# YodleeCoreApis.VerificationHolderProfile

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **Number** | The primary key of the account resource and the unique identifier for the account | [optional] 
**address** | [**[AbstractAddress]**](AbstractAddress.md) | The account holder&#x27;s address available at the profile and account levels | [optional] 
**phoneNumber** | [**[PhoneNumber]**](PhoneNumber.md) | The account holder&#x27;s phone number available at the profile and account levels | [optional] 
**providerAccountId** | **Number** | The primary key of the provider account resource | [optional] 
**holder** | [**[VerificationHolder]**](VerificationHolder.md) | The holder entity is account-specific and captures the ownership status and the name details of the user | [optional] 
**email** | [**[Email]**](Email.md) | The account holder&#x27;s email ID available at the profile and account levels | [optional] 
