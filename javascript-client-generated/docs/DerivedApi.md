# YodleeCoreApis.DerivedApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getHoldingSummary**](DerivedApi.md#getHoldingSummary) | **GET** /derived/holdingSummary | Get Holding Summary
[**getNetworth**](DerivedApi.md#getNetworth) | **GET** /derived/networth | Get Networth Summary
[**getTransactionSummary**](DerivedApi.md#getTransactionSummary) | **GET** /derived/transactionSummary | Get Transaction Summary

<a name="getHoldingSummary"></a>
# **getHoldingSummary**
> DerivedHoldingSummaryResponse getHoldingSummary(opts)

Get Holding Summary

The get holding summary service is used to get the summary of asset classifications for the user.&lt;br&gt;By default, accounts with status as ACTIVE and TO BE CLOSED will be considered.&lt;br&gt;If the include parameter value is passed as details then a summary with holdings and account information is returned.&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.DerivedApi();
let opts = { 
  'accountIds': "accountIds_example", // String | Comma separated accountIds
  'classificationType': "classificationType_example", // String | e.g. Country, Sector, etc.
  'include': "include_example" // String | details
};
apiInstance.getHoldingSummary(opts, (error, data, response) => {
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
 **accountIds** | **String**| Comma separated accountIds | [optional] 
 **classificationType** | **String**| e.g. Country, Sector, etc. | [optional] 
 **include** | **String**| details | [optional] 

### Return type

[**DerivedHoldingSummaryResponse**](DerivedHoldingSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getNetworth"></a>
# **getNetworth**
> DerivedNetworthResponse getNetworth(opts)

Get Networth Summary

The get networth service is used to get the networth for the user.&lt;br&gt;If the include parameter value is passed as details then networth with historical balances is returned. &lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.DerivedApi();
let opts = { 
  'accountIds': "accountIds_example", // String | comma separated accountIds
  'container': "container_example", // String | bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities
  'fromDate': "fromDate_example", // String | from date for balance retrieval (YYYY-MM-DD)
  'include': "include_example", // String | details
  'interval': "interval_example", // String | D-daily, W-weekly or M-monthly
  'skip': 56, // Number | skip (Min 0)
  'toDate': "toDate_example", // String | toDate for balance retrieval (YYYY-MM-DD)
  'top': 56 // Number | top (Max 500)
};
apiInstance.getNetworth(opts, (error, data, response) => {
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
 **accountIds** | **String**| comma separated accountIds | [optional] 
 **container** | **String**| bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities | [optional] 
 **fromDate** | **String**| from date for balance retrieval (YYYY-MM-DD) | [optional] 
 **include** | **String**| details | [optional] 
 **interval** | **String**| D-daily, W-weekly or M-monthly | [optional] 
 **skip** | **Number**| skip (Min 0) | [optional] 
 **toDate** | **String**| toDate for balance retrieval (YYYY-MM-DD) | [optional] 
 **top** | **Number**| top (Max 500) | [optional] 

### Return type

[**DerivedNetworthResponse**](DerivedNetworthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getTransactionSummary"></a>
# **getTransactionSummary**
> DerivedTransactionSummaryResponse getTransactionSummary(groupBy, opts)

Get Transaction Summary

The transaction summary service provides the summary values of transactions for the given date range by category type, high-level categories, or system-defined categories.&lt;br&gt;&lt;br&gt;Yodlee has the transaction data stored for a day, month, year and week per category as per the availability of user&#x27;s data. If the include parameter value is passed as details, then summary details will be returned depending on the interval passed-monthly is the default.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ol&gt; &lt;li&gt; Details can be requested for only one system-defined category&lt;li&gt;Passing categoryType is mandatory except when the groupBy value is CATEGORY_TYPE&lt;li&gt;Dates will not be respected for monthly, yearly, and weekly details&lt;li&gt;When monthly details are requested, only the fromDate and toDate month will be respected&lt;li&gt;When yearly details are requested, only the fromDate and toDate year will be respected&lt;li&gt;For weekly data points, details will be provided for every Sunday date available within the fromDate and toDate&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter&lt;/li&gt;&lt;/ol&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.DerivedApi();
let groupBy = "groupBy_example"; // String | CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY
let opts = { 
  'accountId': "accountId_example", // String | comma separated account Ids
  'categoryId': "categoryId_example", // String | comma separated categoryIds
  'categoryType': "categoryType_example", // String | INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION
  'fromDate': "fromDate_example", // String | YYYY-MM-DD format
  'include': "include_example", // String | details
  'includeUserCategory': true, // Boolean | TRUE/FALSE
  'interval': "interval_example", // String | D-daily, W-weekly, M-mothly or Y-yearly
  'toDate': "toDate_example" // String | YYYY-MM-DD format
};
apiInstance.getTransactionSummary(groupBy, opts, (error, data, response) => {
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
 **groupBy** | **String**| CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY | 
 **accountId** | **String**| comma separated account Ids | [optional] 
 **categoryId** | **String**| comma separated categoryIds | [optional] 
 **categoryType** | **String**| INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION | [optional] 
 **fromDate** | **String**| YYYY-MM-DD format | [optional] 
 **include** | **String**| details | [optional] 
 **includeUserCategory** | **Boolean**| TRUE/FALSE | [optional] 
 **interval** | **String**| D-daily, W-weekly, M-mothly or Y-yearly | [optional] 
 **toDate** | **String**| YYYY-MM-DD format | [optional] 

### Return type

[**DerivedTransactionSummaryResponse**](DerivedTransactionSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

