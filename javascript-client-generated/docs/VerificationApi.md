# YodleeCoreApis.VerificationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getHolderProfile**](VerificationApi.md#getHolderProfile) | **GET** /verification/holderProfile | Get Holder Profile
[**getVerificationStatus**](VerificationApi.md#getVerificationStatus) | **GET** /verification | Get Verification Status
[**getVerifiedAccounts**](VerificationApi.md#getVerifiedAccounts) | **GET** /verification/verifiedAccounts | Get Verified Accounts
[**initiateMatchingOrChallengeDepositeVerification**](VerificationApi.md#initiateMatchingOrChallengeDepositeVerification) | **POST** /verification | Initiaite Challenge Deposit
[**verifyChallengeDeposit**](VerificationApi.md#verifyChallengeDeposit) | **PUT** /verification | Verify Challenge Deposit

<a name="getHolderProfile"></a>
# **getHolderProfile**
> HolderProfileResponse getHolderProfile(providerAccountId, opts)

Get Holder Profile

The Holder Profile API service allows retrieving the user&#x27;s profile details (i.e., PII data such as name, email, phone number, and address) that are available at the provider account and each account level. The API accepts the providerAccountId and retrieves the profile information available under it and all the details available under each of the associated accounts.  &lt;br&gt;&lt;br&gt;This service can only be invoked by Yodlee API v1.1, FastLink 3, and FastLink 4 customers. &lt;br&gt;&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerificationApi();
let providerAccountId = "providerAccountId_example"; // String | providerAccountId.
let opts = { 
  'accountId': "accountId_example" // String | accountId
};
apiInstance.getHolderProfile(providerAccountId, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **String**| providerAccountId. | 
 **accountId** | **String**| accountId | [optional] 

### Return type

[**HolderProfileResponse**](HolderProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getVerificationStatus"></a>
# **getVerificationStatus**
> VerificationStatusResponse getVerificationStatus(opts)

Get Verification Status

&lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The get verification status service is used to retrieve the verification status of all accounts for which the CDV process has been initiated.For the CDV process, the account details object returns the user provided account information.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerificationApi();
let opts = { 
  'accountId': "accountId_example", // String | Comma separated accountId
  'providerAccountId': "providerAccountId_example", // String | Comma separated providerAccountId
  'verificationType': "verificationType_example" // String | verificationType
};
apiInstance.getVerificationStatus(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **String**| Comma separated accountId | [optional] 
 **providerAccountId** | **String**| Comma separated providerAccountId | [optional] 
 **verificationType** | **String**| verificationType | [optional] 

### Return type

[**VerificationStatusResponse**](VerificationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getVerifiedAccounts"></a>
# **getVerifiedAccounts**
> VerifiedAccountResponse getVerifiedAccounts(providerAccountId, opts)

Get Verified Accounts

The Verified Accounts API v1.1 provides information about the bank and investment accounts that the user  has selected for verification, during the Account Verification flow on FastLink 4. By default, the API only returns information of the accounts that were selected and have been successfully verified. &lt;br&gt;&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerificationApi();
let providerAccountId = "providerAccountId_example"; // String | providerAccountId.
let opts = { 
  'accountId': "accountId_example", // String | Comma separated accountIds.
  'isSelected': "isSelected_example", // String | Comma separated isSelected. Allowed values are true, false <br><b>Note:</b> If no value is passed, the implicit default value is true.
  'verificationStatus': "verificationStatus_example" // String | Comma separated verificationStatus. Allowed values are SUCCESS, FAILED <br><b>Note:</b> If no value is passed, the implicit default value is SUCCESS.
};
apiInstance.getVerifiedAccounts(providerAccountId, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **String**| providerAccountId. | 
 **accountId** | **String**| Comma separated accountIds. | [optional] 
 **isSelected** | **String**| Comma separated isSelected. Allowed values are true, false &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is true. | [optional] 
 **verificationStatus** | **String**| Comma separated verificationStatus. Allowed values are SUCCESS, FAILED &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is SUCCESS. | [optional] 

### Return type

[**VerifiedAccountResponse**](VerifiedAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="initiateMatchingOrChallengeDepositeVerification"></a>
# **initiateMatchingOrChallengeDepositeVerification**
> VerificationResponse initiateMatchingOrChallengeDepositeVerification(body)

Initiaite Challenge Deposit

&lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The post verification service is used to initiate the challenge deposit account verification (CDV) process to verify account ownership.The CDV process can verify ownership of only bank accounts (i.e., checking and savings).Once the CDV process is initiated, Yodlee will post the micro-transaction (i.e., credit and debit) in the user&#x27;s account. The CDV process takes 2 to 3 days to complete as it requires the user to provide the microtransaction details.&lt;br&gt;&lt;br&gt;The CDV process is currently supported only in the United States.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerificationApi();
let body = new YodleeCoreApis.VerificationRequest(); // VerificationRequest | verification information

apiInstance.initiateMatchingOrChallengeDepositeVerification(body, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VerificationRequest**](VerificationRequest.md)| verification information | 

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="verifyChallengeDeposit"></a>
# **verifyChallengeDeposit**
> VerificationResponse verifyChallengeDeposit(body)

Verify Challenge Deposit

The put verification service is used to complete the challenge deposit verification (CDV) process.&lt;br&gt;This service is used only by the customer of CDV flow.&lt;br&gt;In the CDV process, the user-provided microtransaction details (i.e., credit and debit) is matched against the microtransactions posted by Yodlee. For a successful verification of the account&#x27;s ownership both the microtransaction details should match.&lt;br&gt;The CDV process is currently supported only in the United States.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ul&gt;&lt;li&gt;This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team&#x27;s assistance to set up a dedicated environment.&lt;/li&gt;&lt;/ul&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerificationApi();
let body = new YodleeCoreApis.UpdateVerificationRequest(); // UpdateVerificationRequest | verification information

apiInstance.verifyChallengeDeposit(body, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateVerificationRequest**](UpdateVerificationRequest.md)| verification information | 

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

