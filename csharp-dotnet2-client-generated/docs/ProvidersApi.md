# IO.Swagger.Api.ProvidersApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllProviders**](ProvidersApi.md#getallproviders) | **GET** /providers | Get Providers
[**GetProvider**](ProvidersApi.md#getprovider) | **GET** /providers/{providerId} | Get Provider Details
[**GetProvidersCount**](ProvidersApi.md#getproviderscount) | **GET** /providers/count | Get Providers Count

<a name="getallproviders"></a>
# **GetAllProviders**
> ProviderResponse GetAllProviders (string capability, long? institutionId, string name, string priority, string providerId, int? skip, int? top)

Get Providers

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br>The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region.<br><br>Searching for a provider using a routing number is applicable only to the USA and Canada regions.<br> The valid values for priority are: <br><ol><li> cobrand: Returns providers enabled for the cobrand (Default priority)</li><li>popular: Returns providers popular among users of the customer.</li></ol><br>The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.The response header provides the links to retrieve the next and previous set of transactions.<br><br> Providers accept the configName as the input to the API and return the providers list based on the configurations of each configName.  For verification, the providers will accept the configName with which has the verification product and the attributes that are chosen in the configName which returns the list of providers that match the criteria.  ***For an example,  /ysl/providers?configName=aggregationAndVerification*** <br><br>Note:</b> <ol><li>In a product flow involving user interaction, Yodlee recommends invoking this service with filters.<li>Without filters, the service may perform slowly as it takes a few minutes to return data in the response.<li>The AuthParameter appears in the response only in case of token-based aggregation sites.<li>The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.<li>This service supports the localization feature and accepts locale as a header parameter.<li>The capability has been deprecated in query parameter and response. </li></ol>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllProvidersExample
    {
        public void main()
        {

            var apiInstance = new ProvidersApi();
            var capability = capability_example;  // string | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated (optional) 
            var institutionId = 789;  // long? | Institution Id for Single site selection (optional) 
            var name = name_example;  // string | Name in minimum 1 character or routing number. (optional) 
            var priority = priority_example;  // string | Search priority (optional) 
            var providerId = providerId_example;  // string | Max 5 Comma seperated Provider Ids (optional) 
            var skip = 56;  // int? | skip (Min 0) - This is not applicable along with 'name' parameter. (optional) 
            var top = 56;  // int? | top (Max 500) - This is not applicable along with 'name' parameter. (optional) 

            try
            {
                // Get Providers
                ProviderResponse result = apiInstance.GetAllProviders(capability, institutionId, name, priority, providerId, skip, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetAllProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **capability** | **string**| CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional] 
 **institutionId** | **long?**| Institution Id for Single site selection | [optional] 
 **name** | **string**| Name in minimum 1 character or routing number. | [optional] 
 **priority** | **string**| Search priority | [optional] 
 **providerId** | **string**| Max 5 Comma seperated Provider Ids | [optional] 
 **skip** | **int?**| skip (Min 0) - This is not applicable along with &#x27;name&#x27; parameter. | [optional] 
 **top** | **int?**| top (Max 500) - This is not applicable along with &#x27;name&#x27; parameter. | [optional] 

### Return type

[**ProviderResponse**](ProviderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovider"></a>
# **GetProvider**
> ProviderDetailResponse GetProvider (long? providerId)

Get Provider Details

The get provider detail service is used to get detailed information including the login form for a provider.<br>The response is a provider object that includes information such as name of the provider, <br>provider's base URL, a list of containers supported by the provider, the login form details of the provider, etc.<br>Only enabled datasets, attributes and containers gets returned in the response.<br><br><b>Note:</b><li>This service supports the localization feature and accepts locale as a header parameter.<li>The capability has been deprecated in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProviderExample
    {
        public void main()
        {

            var apiInstance = new ProvidersApi();
            var providerId = 789;  // long? | providerId

            try
            {
                // Get Provider Details
                ProviderDetailResponse result = apiInstance.GetProvider(providerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerId** | **long?**| providerId | 

### Return type

[**ProviderDetailResponse**](ProviderDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproviderscount"></a>
# **GetProvidersCount**
> ProvidersCountResponse GetProvidersCount (string capability, string name, string priority)

Get Providers Count

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br>The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.<br>If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.<br>The functionality of the input parameters remains the same as that of the GET /providers endpoint<br><br><b>Note:</b> <li>The capability has been deprecated in the query parameter.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvidersCountExample
    {
        public void main()
        {

            var apiInstance = new ProvidersApi();
            var capability = capability_example;  // string | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated (optional) 
            var name = name_example;  // string | Name in minimum 1 character or routing number. (optional) 
            var priority = priority_example;  // string | Search priority (optional) 

            try
            {
                // Get Providers Count
                ProvidersCountResponse result = apiInstance.GetProvidersCount(capability, name, priority);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvidersCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **capability** | **string**| CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional] 
 **name** | **string**| Name in minimum 1 character or routing number. | [optional] 
 **priority** | **string**| Search priority | [optional] 

### Return type

[**ProvidersCountResponse**](ProvidersCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

