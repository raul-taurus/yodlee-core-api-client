# YodleeCoreApis.VerifyAccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**initiateAccountVerification**](VerifyAccountApi.md#initiateAccountVerification) | **POST** /verifyAccount/{providerAccountId} | Verify Accounts Using Transactions

<a name="initiateAccountVerification"></a>
# **initiateAccountVerification**
> VerifyAccountResponse initiateAccountVerification(body, providerAccountId)

Verify Accounts Using Transactions

The verify account service is used to verify the account&#x27;s ownership by  matching the transaction details with the accounts aggregated for the user.&lt;br&gt;&lt;ul&gt;&lt;li&gt;If a match is identified, the service returns details of all the accounts along with the matched transaction&#x27;s details.&lt;li&gt;If no transaction match is found, an empty response will be returned.&lt;li&gt;A maximum of 5 transactionCriteria can be passed in a request.&lt;li&gt;The baseType, date, and amount parameters should mandatorily be passed.&lt;li&gt;The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.&lt;li&gt;Pass the container or accountId parameters for better performance.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.VerifyAccountApi();
let body = new YodleeCoreApis.VerifyAccountRequest(); // VerifyAccountRequest | verificationParam
let providerAccountId = "providerAccountId_example"; // String | providerAccountId

apiInstance.initiateAccountVerification(body, providerAccountId, (error, data, response) => {
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
 **body** | [**VerifyAccountRequest**](VerifyAccountRequest.md)| verificationParam | 
 **providerAccountId** | **String**| providerAccountId | 

### Return type

[**VerifyAccountResponse**](VerifyAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

