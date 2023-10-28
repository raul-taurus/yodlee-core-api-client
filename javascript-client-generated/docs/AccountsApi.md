# YodleeCoreApis.AccountsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createManualAccount**](AccountsApi.md#createManualAccount) | **POST** /accounts | Add Manual Account
[**deleteAccount**](AccountsApi.md#deleteAccount) | **DELETE** /accounts/{accountId} | Delete Account
[**evaluateAddress**](AccountsApi.md#evaluateAddress) | **POST** /accounts/evaluateAddress | Evaluate Address
[**getAccount**](AccountsApi.md#getAccount) | **GET** /accounts/{accountId} | Get Account Details
[**getAllAccounts**](AccountsApi.md#getAllAccounts) | **GET** /accounts | Get Accounts
[**getHistoricalBalances**](AccountsApi.md#getHistoricalBalances) | **GET** /accounts/historicalBalances | Get Historical Balances
[**getLatestBalances**](AccountsApi.md#getLatestBalances) | **GET** /accounts/latestBalances | Get Latest Balances
[**updateAccount**](AccountsApi.md#updateAccount) | **PUT** /accounts/{accountId} | Update Account

<a name="createManualAccount"></a>
# **createManualAccount**
> CreatedAccountResponse createManualAccount(body)

Add Manual Account

The add account service is used to add manual accounts.&lt;br&gt;The response of add account service includes the account name , account number and Yodlee generated account id.&lt;br&gt;All manual accounts added will be included as part of networth calculation by default.&lt;br&gt;Add manual account support is available for bank, card, investment, insurance and loan container only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;ul&gt; &lt;li&gt;A real estate account addition is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt;&lt;/ul&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let body = new YodleeCoreApis.CreateAccountRequest(); // CreateAccountRequest | accountParam

apiInstance.createManualAccount(body, (error, data, response) => {
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
 **body** | [**CreateAccountRequest**](CreateAccountRequest.md)| accountParam | 

### Return type

[**CreatedAccountResponse**](CreatedAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="deleteAccount"></a>
# **deleteAccount**
> deleteAccount(accountId)

Delete Account

The delete account service allows an account to be deleted.&lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let accountId = 789; // Number | accountId

apiInstance.deleteAccount(accountId, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **Number**| accountId | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="evaluateAddress"></a>
# **evaluateAddress**
> EvaluateAddressResponse evaluateAddress(body)

Evaluate Address

Use this service to validate the address before adding the real estate account.&lt;br&gt;If the address is valid, the service will return the complete address information.&lt;br&gt;The response will contain multiple addresses if the user-provided input matches with multiple entries in the vendor database.&lt;br&gt;In the case of multiple matches, the user can select the appropriate address from the list and then invoke the add account service with the complete address.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;ul&gt;&lt;li&gt;Yodlee recommends to use this service before adding the real estate account to avoid failures.&lt;/li&gt;&lt;/ul&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let body = new YodleeCoreApis.EvaluateAddressRequest(); // EvaluateAddressRequest | addressParam

apiInstance.evaluateAddress(body, (error, data, response) => {
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
 **body** | [**EvaluateAddressRequest**](EvaluateAddressRequest.md)| addressParam | 

### Return type

[**EvaluateAddressResponse**](EvaluateAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="getAccount"></a>
# **getAccount**
> AccountResponse getAccount(accountId, opts)

Get Account Details

The get account details service provides detailed information of an account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let accountId = 789; // Number | accountId
let opts = { 
  'include': "include_example" // String | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh<br><b>Note:</b>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.
};
apiInstance.getAccount(accountId, opts, (error, data, response) => {
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
 **accountId** | **Number**| accountId | 
 **include** | **String**| profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response. | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getAllAccounts"></a>
# **getAllAccounts**
> AccountResponse getAllAccounts(opts)

Get Accounts

&lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get accounts service provides information about accounts added by the user.&lt;br&gt;By default, this service returns information for active and to be closed accounts.&lt;br&gt;If requestId is provided, the accounts that are updated in the context of the requestId will be provided in the response.&lt;br&gt;&lt;br&gt; This API returns all the accounts that were chosen by the user in both the verification selection screen and the aggregation selection screen. In FastLink 4, we have separate APIs to provide the data for verification product-related data (/verification/verifiedAccounts) and the GET accounts should be utilized with an additional query param (isSelectedForAggregation&#x3D;true) to retrieve only the aggregation accounts.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let opts = { 
  'accountId': "accountId_example", // String | Comma separated accountIds.
  'container': "container_example", // String | bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities
  'include': "include_example", // String | profile, paymentProfile, autoRefresh<br><b>Note:</b><br><li>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li><br><li>profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.</li>
  'providerAccountId': "providerAccountId_example", // String | Comma separated providerAccountIds.
  'requestId': "requestId_example", // String | The unique identifier that returns contextual data
  'status': "status_example" // String | ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED
};
apiInstance.getAllAccounts(opts, (error, data, response) => {
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
 **accountId** | **String**| Comma separated accountIds. | [optional] 
 **container** | **String**| bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities | [optional] 
 **include** | **String**| profile, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;&lt;br&gt;&lt;li&gt;profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.&lt;/li&gt; | [optional] 
 **providerAccountId** | **String**| Comma separated providerAccountIds. | [optional] 
 **requestId** | **String**| The unique identifier that returns contextual data | [optional] 
 **status** | **String**| ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getHistoricalBalances"></a>
# **getHistoricalBalances**
> AccountHistoricalBalancesResponse getHistoricalBalances(opts)

Get Historical Balances

The historical balances service is used to retrieve the historical balances for an account or a user.&lt;br&gt;Historical balances are daily (D), weekly (W), and monthly (M). &lt;br&gt;The interval input should be passed as D, W, and M to retrieve the desired historical balances. The default interval is daily (D). &lt;br&gt;When no account id is provided, historical balances of the accounts that are active, to be closed, and closed are provided in the response. &lt;br&gt;If the fromDate and toDate are not passed, the last 90 days of data will be provided. &lt;br&gt;The fromDate and toDate should be passed in the YYYY-MM-DD format. &lt;br&gt;The date field in the response denotes the date for which the balance is requested.&lt;br&gt;includeCF needs to be sent as true if the customer wants to return carried forward balances for a date when the data is not available. &lt;br&gt;asofDate field in the response denotes the date as of which the balance was updated for that account.&lt;br&gt;When there is no balance available for a requested date and if includeCF is sent as true, the previous date for which the balance is available is provided in the response. &lt;br&gt;When there is no previous balance available, no data will be sent. &lt;br&gt;By default, pagination is available for the historicalBalances entity in this API. The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of historical balances.&lt;br&gt; The API will only retrieve a maximum 500 records by default when values for skip and top parameters are not provided.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let opts = { 
  'accountId': "accountId_example", // String | accountId
  'fromDate': "fromDate_example", // String | from date for balance retrieval (YYYY-MM-DD)
  'includeCF': true, // Boolean | Consider carry forward logic for missing balances
  'interval': "interval_example", // String | D-daily, W-weekly or M-monthly
  'skip': 56, // Number | skip (Min 0)
  'toDate': "toDate_example", // String | toDate for balance retrieval (YYYY-MM-DD)
  'top': 56 // Number | top (Max 500)
};
apiInstance.getHistoricalBalances(opts, (error, data, response) => {
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
 **accountId** | **String**| accountId | [optional] 
 **fromDate** | **String**| from date for balance retrieval (YYYY-MM-DD) | [optional] 
 **includeCF** | **Boolean**| Consider carry forward logic for missing balances | [optional] 
 **interval** | **String**| D-daily, W-weekly or M-monthly | [optional] 
 **skip** | **Number**| skip (Min 0) | [optional] 
 **toDate** | **String**| toDate for balance retrieval (YYYY-MM-DD) | [optional] 
 **top** | **Number**| top (Max 500) | [optional] 

### Return type

[**AccountHistoricalBalancesResponse**](AccountHistoricalBalancesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getLatestBalances"></a>
# **getLatestBalances**
> AccountBalanceResponse getLatestBalances(accountId, providerAccountId)

Get Latest Balances

The latest balances service provides the latest account balance by initiating a new balance refresh request

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let accountId = "accountId_example"; // String | Comma separated accountIds.
let providerAccountId = "providerAccountId_example"; // String | providerAccountId.

apiInstance.getLatestBalances(accountId, providerAccountId, (error, data, response) => {
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
 **accountId** | **String**| Comma separated accountIds. | 
 **providerAccountId** | **String**| providerAccountId. | 

### Return type

[**AccountBalanceResponse**](AccountBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="updateAccount"></a>
# **updateAccount**
> updateAccount(body, accountId)

Update Account

The update account service is used to update manual and aggregated accounts.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;Update manual account support is available for bank, card, investment, insurance, loan, otherAssets, otherLiabilities and realEstate containers only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; A real estate account update is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt; &lt;li&gt; A real estate account can be linked to a loan account by passing accountId of a loan account in linkedAccountIds .&lt;/li&gt; &lt;li&gt; Attribute &lt;b&gt;isEbillEnrolled&lt;/b&gt; is deprecated as it is applicable for bill accounts only.&lt;/li&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.AccountsApi();
let body = new YodleeCoreApis.UpdateAccountRequest(); // UpdateAccountRequest | accountRequest
let accountId = 789; // Number | accountId

apiInstance.updateAccount(body, accountId, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateAccountRequest**](UpdateAccountRequest.md)| accountRequest | 
 **accountId** | **Number**| accountId | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

