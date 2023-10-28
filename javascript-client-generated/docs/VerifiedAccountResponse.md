# YodleeCoreApis.VerifiedAccountResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **String** | The unique identifier for the verification request that returns contextual data | [optional] 
**requestDate** | **String** | The date of the verification request | [optional] 
**state** | **String** | The overall status of the verification request | [optional] 
**verifiedAccount** | [**[VerifiedAccounts]**](VerifiedAccounts.md) |  | [optional] 
**failedReason** | **String** | The reason for the failure of the verification request | [optional] 

<a name="StateEnum"></a>
## Enum: StateEnum

* `COMPLETED` (value: `"COMPLETED"`)
* `FAILED` (value: `"FAILED"`)


<a name="FailedReasonEnum"></a>
## Enum: FailedReasonEnum

* `ACCOUNT_LOCKED` (value: `"ACCOUNT_LOCKED"`)
* `ADDL_AUTHENTICATION_REQUIRED` (value: `"ADDL_AUTHENTICATION_REQUIRED"`)
* `CREDENTIALS_UPDATE_NEEDED` (value: `"CREDENTIALS_UPDATE_NEEDED"`)
* `INCORRECT_CREDENTIALS` (value: `"INCORRECT_CREDENTIALS"`)
* `INVALID_ADDL_INFO_PROVIDED` (value: `"INVALID_ADDL_INFO_PROVIDED"`)
* `REQUEST_TIME_OUT` (value: `"REQUEST_TIME_OUT"`)
* `SITE_BLOCKING_ERROR` (value: `"SITE_BLOCKING_ERROR"`)
* `UNEXPECTED_SITE_ERROR` (value: `"UNEXPECTED_SITE_ERROR"`)
* `SITE_NOT_SUPPORTED` (value: `"SITE_NOT_SUPPORTED"`)
* `SITE_UNAVAILABLE` (value: `"SITE_UNAVAILABLE"`)
* `TECH_ERROR` (value: `"TECH_ERROR"`)
* `USER_ACTION_NEEDED_AT_SITE` (value: `"USER_ACTION_NEEDED_AT_SITE"`)
* `SITE_SESSION_INVALIDATED` (value: `"SITE_SESSION_INVALIDATED"`)
* `NEW_AUTHENTICATION_REQUIRED` (value: `"NEW_AUTHENTICATION_REQUIRED"`)
* `CONSENT_REQUIRED` (value: `"CONSENT_REQUIRED"`)
* `CONSENT_EXPIRED` (value: `"CONSENT_EXPIRED"`)
* `CONSENT_REVOKED` (value: `"CONSENT_REVOKED"`)
* `INCORRECT_OAUTH_TOKEN` (value: `"INCORRECT_OAUTH_TOKEN"`)
* `REQUIRED_DATA_NOT_AVAILABLE` (value: `"REQUIRED_DATA_NOT_AVAILABLE"`)
* `MATCHING_FAILED` (value: `"MATCHING_FAILED"`)
* `NO_ELIGIBLE_ACCOUNTS` (value: `"NO_ELIGIBLE_ACCOUNTS"`)
* `USER_INPUT_REQUIRED` (value: `"USER_INPUT_REQUIRED"`)

