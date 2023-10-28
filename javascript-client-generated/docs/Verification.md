# YodleeCoreApis.Verification

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **Number** | Unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**reason** | **String** | The reason the account verification failed.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**verificationStatus** | **String** | The status of the account verification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt; | [optional] 
**providerAccountId** | **Number** | Unique identifier for the provider account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**verificationType** | **String** | The account verification type.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt; | [optional] 
**account** | [**VerificationAccount**](VerificationAccount.md) |  | [optional] 
**verificationDate** | **String** | The date of the account verification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**verificationId** | **Number** | Unique identifier for the verification request.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="ReasonEnum"></a>
## Enum: ReasonEnum

* `DATA_NOT_AVAILABLE` (value: `"DATA_NOT_AVAILABLE"`)
* `ACCOUNT_HOLDER_MISMATCH` (value: `"ACCOUNT_HOLDER_MISMATCH"`)
* `FULL_ACCOUNT_NUMBER_AND_BANK_TRANSFER_CODE_NOT_AVAILABLE` (value: `"FULL_ACCOUNT_NUMBER_AND_BANK_TRANSFER_CODE_NOT_AVAILABLE"`)
* `FULL_ACCOUNT_NUMBER_NOT_AVAILABLE` (value: `"FULL_ACCOUNT_NUMBER_NOT_AVAILABLE"`)
* `BANK_TRANSFER_CODE_NOT_AVAILABLE` (value: `"BANK_TRANSFER_CODE_NOT_AVAILABLE"`)
* `EXPIRED` (value: `"EXPIRED"`)
* `DATA_MISMATCH` (value: `"DATA_MISMATCH"`)
* `INSTRUCTION_GENERATION_ERROR` (value: `"INSTRUCTION_GENERATION_ERROR"`)


<a name="VerificationStatusEnum"></a>
## Enum: VerificationStatusEnum

* `INITIATED` (value: `"INITIATED"`)
* `DEPOSITED` (value: `"DEPOSITED"`)
* `SUCCESS` (value: `"SUCCESS"`)
* `FAILED` (value: `"FAILED"`)


<a name="VerificationTypeEnum"></a>
## Enum: VerificationTypeEnum

* `MATCHING` (value: `"MATCHING"`)
* `CHALLENGE_DEPOSIT` (value: `"CHALLENGE_DEPOSIT"`)

