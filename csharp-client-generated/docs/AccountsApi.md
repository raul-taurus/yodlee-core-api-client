# IO.Swagger.Api.AccountsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateManualAccount**](AccountsApi.md#createmanualaccount) | **POST** /accounts | Add Manual Account
[**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /accounts/{accountId} | Delete Account
[**EvaluateAddress**](AccountsApi.md#evaluateaddress) | **POST** /accounts/evaluateAddress | Evaluate Address
[**GetAccount**](AccountsApi.md#getaccount) | **GET** /accounts/{accountId} | Get Account Details
[**GetAllAccounts**](AccountsApi.md#getallaccounts) | **GET** /accounts | Get Accounts
[**GetHistoricalBalances**](AccountsApi.md#gethistoricalbalances) | **GET** /accounts/historicalBalances | Get Historical Balances
[**GetLatestBalances**](AccountsApi.md#getlatestbalances) | **GET** /accounts/latestBalances | Get Latest Balances
[**UpdateAccount**](AccountsApi.md#updateaccount) | **PUT** /accounts/{accountId} | Update Account

<a name="createmanualaccount"></a>
# **CreateManualAccount**
> CreatedAccountResponse CreateManualAccount (CreateAccountRequest body)

Add Manual Account

The add account service is used to add manual accounts.<br>The response of add account service includes the account name , account number and Yodlee generated account id.<br>All manual accounts added will be included as part of networth calculation by default.<br>Add manual account support is available for bank, card, investment, insurance and loan container only.<br><br><b>Note:</b><ul> <li>A real estate account addition is only supported for SYSTEM and MANUAL valuation type.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateManualAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new CreateAccountRequest(); // CreateAccountRequest | accountParam

            try
            {
                // Add Manual Account
                CreatedAccountResponse result = apiInstance.CreateManualAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateManualAccount: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteaccount"></a>
# **DeleteAccount**
> void DeleteAccount (long? accountId)

Delete Account

The delete account service allows an account to be deleted.<br>This service does not return a response. The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = 789;  // long? | accountId

            try
            {
                // Delete Account
                apiInstance.DeleteAccount(accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **long?**| accountId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="evaluateaddress"></a>
# **EvaluateAddress**
> EvaluateAddressResponse EvaluateAddress (EvaluateAddressRequest body)

Evaluate Address

Use this service to validate the address before adding the real estate account.<br>If the address is valid, the service will return the complete address information.<br>The response will contain multiple addresses if the user-provided input matches with multiple entries in the vendor database.<br>In the case of multiple matches, the user can select the appropriate address from the list and then invoke the add account service with the complete address.<br><br><b>Note:</b> <ul><li>Yodlee recommends to use this service before adding the real estate account to avoid failures.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EvaluateAddressExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new EvaluateAddressRequest(); // EvaluateAddressRequest | addressParam

            try
            {
                // Evaluate Address
                EvaluateAddressResponse result = apiInstance.EvaluateAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.EvaluateAddress: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaccount"></a>
# **GetAccount**
> AccountResponse GetAccount (long? accountId, string include = null)

Get Account Details

The get account details service provides detailed information of an account.<br><br><b>Note:</b><li> fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = 789;  // long? | accountId
            var include = include_example;  // string | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh<br><b>Note:</b>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response. (optional) 

            try
            {
                // Get Account Details
                AccountResponse result = apiInstance.GetAccount(accountId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **long?**| accountId | 
 **include** | **string**| profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response. | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallaccounts"></a>
# **GetAllAccounts**
> AccountResponse GetAllAccounts (string accountId = null, string container = null, string include = null, string providerAccountId = null, string requestId = null, string status = null)

Get Accounts

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br>The get accounts service provides information about accounts added by the user.<br>By default, this service returns information for active and to be closed accounts.<br>If requestId is provided, the accounts that are updated in the context of the requestId will be provided in the response.<br><br> This API returns all the accounts that were chosen by the user in both the verification selection screen and the aggregation selection screen. In FastLink 4, we have separate APIs to provide the data for verification product-related data (/verification/verifiedAccounts) and the GET accounts should be utilized with an additional query param (isSelectedForAggregation=true) to retrieve only the aggregation accounts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAccountsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | Comma separated accountIds. (optional) 
            var container = container_example;  // string | bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities (optional) 
            var include = include_example;  // string | profile, paymentProfile, autoRefresh<br><b>Note:</b><br><li>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li><br><li>profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.</li> (optional) 
            var providerAccountId = providerAccountId_example;  // string | Comma separated providerAccountIds. (optional) 
            var requestId = requestId_example;  // string | The unique identifier that returns contextual data (optional) 
            var status = status_example;  // string | ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED (optional) 

            try
            {
                // Get Accounts
                AccountResponse result = apiInstance.GetAllAccounts(accountId, container, include, providerAccountId, requestId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAllAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountIds. | [optional] 
 **container** | **string**| bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities | [optional] 
 **include** | **string**| profile, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;&lt;br&gt;&lt;li&gt;profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.&lt;/li&gt; | [optional] 
 **providerAccountId** | **string**| Comma separated providerAccountIds. | [optional] 
 **requestId** | **string**| The unique identifier that returns contextual data | [optional] 
 **status** | **string**| ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethistoricalbalances"></a>
# **GetHistoricalBalances**
> AccountHistoricalBalancesResponse GetHistoricalBalances (string accountId = null, string fromDate = null, bool? includeCF = null, string interval = null, int? skip = null, string toDate = null, int? top = null)

Get Historical Balances

The historical balances service is used to retrieve the historical balances for an account or a user.<br>Historical balances are daily (D), weekly (W), and monthly (M). <br>The interval input should be passed as D, W, and M to retrieve the desired historical balances. The default interval is daily (D). <br>When no account id is provided, historical balances of the accounts that are active, to be closed, and closed are provided in the response. <br>If the fromDate and toDate are not passed, the last 90 days of data will be provided. <br>The fromDate and toDate should be passed in the YYYY-MM-DD format. <br>The date field in the response denotes the date for which the balance is requested.<br>includeCF needs to be sent as true if the customer wants to return carried forward balances for a date when the data is not available. <br>asofDate field in the response denotes the date as of which the balance was updated for that account.<br>When there is no balance available for a requested date and if includeCF is sent as true, the previous date for which the balance is available is provided in the response. <br>When there is no previous balance available, no data will be sent. <br>By default, pagination is available for the historicalBalances entity in this API. The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of historical balances.<br> The API will only retrieve a maximum 500 records by default when values for skip and top parameters are not provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricalBalancesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | accountId (optional) 
            var fromDate = fromDate_example;  // string | from date for balance retrieval (YYYY-MM-DD) (optional) 
            var includeCF = true;  // bool? | Consider carry forward logic for missing balances (optional) 
            var interval = interval_example;  // string | D-daily, W-weekly or M-monthly (optional) 
            var skip = 56;  // int? | skip (Min 0) (optional) 
            var toDate = toDate_example;  // string | toDate for balance retrieval (YYYY-MM-DD) (optional) 
            var top = 56;  // int? | top (Max 500) (optional) 

            try
            {
                // Get Historical Balances
                AccountHistoricalBalancesResponse result = apiInstance.GetHistoricalBalances(accountId, fromDate, includeCF, interval, skip, toDate, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetHistoricalBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| accountId | [optional] 
 **fromDate** | **string**| from date for balance retrieval (YYYY-MM-DD) | [optional] 
 **includeCF** | **bool?**| Consider carry forward logic for missing balances | [optional] 
 **interval** | **string**| D-daily, W-weekly or M-monthly | [optional] 
 **skip** | **int?**| skip (Min 0) | [optional] 
 **toDate** | **string**| toDate for balance retrieval (YYYY-MM-DD) | [optional] 
 **top** | **int?**| top (Max 500) | [optional] 

### Return type

[**AccountHistoricalBalancesResponse**](AccountHistoricalBalancesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlatestbalances"></a>
# **GetLatestBalances**
> AccountBalanceResponse GetLatestBalances (string accountId, string providerAccountId)

Get Latest Balances

The latest balances service provides the latest account balance by initiating a new balance refresh request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLatestBalancesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | Comma separated accountIds.
            var providerAccountId = providerAccountId_example;  // string | providerAccountId.

            try
            {
                // Get Latest Balances
                AccountBalanceResponse result = apiInstance.GetLatestBalances(accountId, providerAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetLatestBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountIds. | 
 **providerAccountId** | **string**| providerAccountId. | 

### Return type

[**AccountBalanceResponse**](AccountBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaccount"></a>
# **UpdateAccount**
> void UpdateAccount (UpdateAccountRequest body, long? accountId)

Update Account

The update account service is used to update manual and aggregated accounts.<br>The HTTP response code is 204 (Success without content).<br>Update manual account support is available for bank, card, investment, insurance, loan, otherAssets, otherLiabilities and realEstate containers only.<br><br><b>Note:</b><li> A real estate account update is only supported for SYSTEM and MANUAL valuation type.</li> <li> A real estate account can be linked to a loan account by passing accountId of a loan account in linkedAccountIds .</li> <li> Attribute <b>isEbillEnrolled</b> is deprecated as it is applicable for bill accounts only.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new UpdateAccountRequest(); // UpdateAccountRequest | accountRequest
            var accountId = 789;  // long? | accountId

            try
            {
                // Update Account
                apiInstance.UpdateAccount(body, accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateAccountRequest**](UpdateAccountRequest.md)| accountRequest | 
 **accountId** | **long?**| accountId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
