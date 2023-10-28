# IO.Swagger.Api.HoldingsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAssetClassificationList**](HoldingsApi.md#getassetclassificationlist) | **GET** /holdings/assetClassificationList | Get Asset Classification List
[**GetHoldingTypeList**](HoldingsApi.md#getholdingtypelist) | **GET** /holdings/holdingTypeList | Get Holding Type List
[**GetHoldings**](HoldingsApi.md#getholdings) | **GET** /holdings | Get Holdings
[**GetSecurities**](HoldingsApi.md#getsecurities) | **GET** /holdings/securities | Get Security Details

<a name="getassetclassificationlist"></a>
# **GetAssetClassificationList**
> HoldingAssetClassificationListResponse GetAssetClassificationList ()

Get Asset Classification List

The get asset classifications list service is used to get the supported asset classifications. <br>The response includes different classification types like assetClass, country, sector, style, etc. and the values corresponding to each type.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetClassificationListExample
    {
        public void main()
        {
            var apiInstance = new HoldingsApi();

            try
            {
                // Get Asset Classification List
                HoldingAssetClassificationListResponse result = apiInstance.GetAssetClassificationList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetAssetClassificationList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HoldingAssetClassificationListResponse**](HoldingAssetClassificationListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getholdingtypelist"></a>
# **GetHoldingTypeList**
> HoldingTypeListResponse GetHoldingTypeList ()

Get Holding Type List

The get holding types list service is used to get the supported holding types.<br>The response includes different holding types such as future, moneyMarketFund, stock, etc. and it returns the supported holding types <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHoldingTypeListExample
    {
        public void main()
        {
            var apiInstance = new HoldingsApi();

            try
            {
                // Get Holding Type List
                HoldingTypeListResponse result = apiInstance.GetHoldingTypeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetHoldingTypeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HoldingTypeListResponse**](HoldingTypeListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getholdings"></a>
# **GetHoldings**
> HoldingResponse GetHoldings (string accountId = null, string assetClassificationClassificationType = null, string classificationValue = null, string include = null, string providerAccountId = null)

Get Holdings

The get holdings service is used to get the list of holdings of a user.<br>Supported holding types can be employeeStockOption, moneyMarketFund, bond, etc. and is obtained using get holding type list service. <br>Asset classifications for the holdings need to be requested through the \"include\" parameter.<br>Asset classification information for holdings are not available by default, as it is a premium feature.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHoldingsExample
    {
        public void main()
        {
            var apiInstance = new HoldingsApi();
            var accountId = accountId_example;  // string | Comma separated accountId (optional) 
            var assetClassificationClassificationType = assetClassificationClassificationType_example;  // string | e.g. Country, Sector, etc. (optional) 
            var classificationValue = classificationValue_example;  // string | e.g. US (optional) 
            var include = include_example;  // string | assetClassification (optional) 
            var providerAccountId = providerAccountId_example;  // string | providerAccountId (optional) 

            try
            {
                // Get Holdings
                HoldingResponse result = apiInstance.GetHoldings(accountId, assetClassificationClassificationType, classificationValue, include, providerAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetHoldings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountId | [optional] 
 **assetClassificationClassificationType** | **string**| e.g. Country, Sector, etc. | [optional] 
 **classificationValue** | **string**| e.g. US | [optional] 
 **include** | **string**| assetClassification | [optional] 
 **providerAccountId** | **string**| providerAccountId | [optional] 

### Return type

[**HoldingResponse**](HoldingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsecurities"></a>
# **GetSecurities**
> HoldingSecuritiesResponse GetSecurities (string holdingId = null)

Get Security Details

The get security details service is used to get all the security information for the holdings<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSecuritiesExample
    {
        public void main()
        {
            var apiInstance = new HoldingsApi();
            var holdingId = holdingId_example;  // string | Comma separated holdingId (optional) 

            try
            {
                // Get Security Details
                HoldingSecuritiesResponse result = apiInstance.GetSecurities(holdingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **holdingId** | **string**| Comma separated holdingId | [optional] 

### Return type

[**HoldingSecuritiesResponse**](HoldingSecuritiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
