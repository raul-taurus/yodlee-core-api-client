# YodleeCoreApis.ProvidersApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getAllProviders**](ProvidersApi.md#getAllProviders) | **GET** /providers | Get Providers
[**getProvider**](ProvidersApi.md#getProvider) | **GET** /providers/{providerId} | Get Provider Details
[**getProvidersCount**](ProvidersApi.md#getProvidersCount) | **GET** /providers/count | Get Providers Count

<a name="getAllProviders"></a>
# **getAllProviders**
> ProviderResponse getAllProviders(opts)

Get Providers

&lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region.&lt;br&gt;&lt;br&gt;Searching for a provider using a routing number is applicable only to the USA and Canada regions.&lt;br&gt; The valid values for priority are: &lt;br&gt;&lt;ol&gt;&lt;li&gt; cobrand: Returns providers enabled for the cobrand (Default priority)&lt;/li&gt;&lt;li&gt;popular: Returns providers popular among users of the customer.&lt;/li&gt;&lt;/ol&gt;&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;&lt;br&gt; Providers accept the configName as the input to the API and return the providers list based on the configurations of each configName.  For verification, the providers will accept the configName with which has the verification product and the attributes that are chosen in the configName which returns the list of providers that match the criteria.  ***For an example,  /ysl/providers?configName&#x3D;aggregationAndVerification*** &lt;br&gt;&lt;br&gt;Note:&lt;/b&gt; &lt;ol&gt;&lt;li&gt;In a product flow involving user interaction, Yodlee recommends invoking this service with filters.&lt;li&gt;Without filters, the service may perform slowly as it takes a few minutes to return data in the response.&lt;li&gt;The AuthParameter appears in the response only in case of token-based aggregation sites.&lt;li&gt;The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in query parameter and response. &lt;/li&gt;&lt;/ol&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ProvidersApi();
let opts = { 
  'capability': "capability_example", // String | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated
  'institutionId': 789, // Number | Institution Id for Single site selection
  'name': "name_example", // String | Name in minimum 1 character or routing number.
  'priority': "priority_example", // String | Search priority
  'providerId': "providerId_example", // String | Max 5 Comma seperated Provider Ids
  'skip': 56, // Number | skip (Min 0) - This is not applicable along with 'name' parameter.
  'top': 56 // Number | top (Max 500) - This is not applicable along with 'name' parameter.
};
apiInstance.getAllProviders(opts, (error, data, response) => {
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
 **capability** | **String**| CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional] 
 **institutionId** | **Number**| Institution Id for Single site selection | [optional] 
 **name** | **String**| Name in minimum 1 character or routing number. | [optional] 
 **priority** | **String**| Search priority | [optional] 
 **providerId** | **String**| Max 5 Comma seperated Provider Ids | [optional] 
 **skip** | **Number**| skip (Min 0) - This is not applicable along with &#x27;name&#x27; parameter. | [optional] 
 **top** | **Number**| top (Max 500) - This is not applicable along with &#x27;name&#x27; parameter. | [optional] 

### Return type

[**ProviderResponse**](ProviderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getProvider"></a>
# **getProvider**
> ProviderDetailResponse getProvider(providerId)

Get Provider Details

The get provider detail service is used to get detailed information including the login form for a provider.&lt;br&gt;The response is a provider object that includes information such as name of the provider, &lt;br&gt;provider&#x27;s base URL, a list of containers supported by the provider, the login form details of the provider, etc.&lt;br&gt;Only enabled datasets, attributes and containers gets returned in the response.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in the response.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ProvidersApi();
let providerId = 789; // Number | providerId

apiInstance.getProvider(providerId, (error, data, response) => {
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
 **providerId** | **Number**| providerId | 

### Return type

[**ProviderDetailResponse**](ProviderDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getProvidersCount"></a>
# **getProvidersCount**
> ProvidersCountResponse getProvidersCount(opts)

Get Providers Count

&lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /providers endpoint&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The capability has been deprecated in the query parameter.&lt;/li&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ProvidersApi();
let opts = { 
  'capability': "capability_example", // String | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated
  'name': "name_example", // String | Name in minimum 1 character or routing number.
  'priority': "priority_example" // String | Search priority
};
apiInstance.getProvidersCount(opts, (error, data, response) => {
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
 **capability** | **String**| CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional] 
 **name** | **String**| Name in minimum 1 character or routing number. | [optional] 
 **priority** | **String**| Search priority | [optional] 

### Return type

[**ProvidersCountResponse**](ProvidersCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

