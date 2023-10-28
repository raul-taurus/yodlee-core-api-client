# IO.Swagger.Api.ProviderAccountsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteProviderAccount**](ProviderAccountsApi.md#deleteprovideraccount) | **DELETE** /providerAccounts/{providerAccountId} | Delete Provider Account
[**EditCredentialsOrRefreshProviderAccount**](ProviderAccountsApi.md#editcredentialsorrefreshprovideraccount) | **PUT** /providerAccounts | Update Account
[**GetAllProviderAccounts**](ProviderAccountsApi.md#getallprovideraccounts) | **GET** /providerAccounts | Get Provider Accounts
[**GetProviderAccount**](ProviderAccountsApi.md#getprovideraccount) | **GET** /providerAccounts/{providerAccountId} | Get Provider Account Details
[**GetProviderAccountProfiles**](ProviderAccountsApi.md#getprovideraccountprofiles) | **GET** /providerAccounts/profile | Get User Profile Details
[**RefreshProviderAccount**](ProviderAccountsApi.md#refreshprovideraccount) | **PUT** /providerAccounts/refresh | Refresh Provider Account
[**UpdatePreferences**](ProviderAccountsApi.md#updatepreferences) | **PUT** /providerAccounts/{providerAccountId}/preferences | Update Preferences

<a name="deleteprovideraccount"></a>
# **DeleteProviderAccount**
> void DeleteProviderAccount (long? providerAccountId)

Delete Provider Account

The delete provider account service is used to delete a provider account from the Yodlee system. This service also deletes the accounts that are created in the Yodlee system for that provider account. <br>This service does not return a response. The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProviderAccountExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var providerAccountId = 789;  // long? | providerAccountId

            try
            {
                // Delete Provider Account
                apiInstance.DeleteProviderAccount(providerAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.DeleteProviderAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **long?**| providerAccountId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editcredentialsorrefreshprovideraccount"></a>
# **EditCredentialsOrRefreshProviderAccount**
> UpdatedProviderAccountResponse EditCredentialsOrRefreshProviderAccount (string providerAccountIds, ProviderAccountRequest body = null)

Update Account

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br>The update account API is used to:<br> <ul><li>Retrieve the latest information of all the eligible accounts that belong to the user.<li>Check the status of the providerAccount before invoking this API. Do not call this API to trigger any action on a providerAccount when an action is already in progress for the providerAccount.<li>If the customer has subscribed to the REFRESH event notification and invoked this API, relevant notifications will be sent to the customer.<li>Check all the dataset additional statuses returned in the response because the provider account status is drawn from the dataset additional statuses.<li>Updating preferences using this API will trigger refreshes.<li> The content type has to be passed as application/json for the body parameter.</ul><br>- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --<br><br><b>Update All Eligible Accounts - Notes:</b><br><ul><li>This API will trigger a refresh for all the eligible provider accounts(both OB and credential-based accounts).<li>This API will not refresh closed, inactive, or UAR accounts, or accounts with refreshes in-progress or recently refreshed non-OB accounts.<li>No parameters should be passed to this API to trigger this action.<li>Do not call this API often. Our recommendation is to call this only at the time the user logs in to your app because it can hamper other API calls performance.<li>The response only contains information for accounts that were refreshed. If no accounts are eligible for refresh, no response is returned.</ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditCredentialsOrRefreshProviderAccountExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var providerAccountIds = providerAccountIds_example;  // string | comma separated providerAccountIds
            var body = new ProviderAccountRequest(); // ProviderAccountRequest | loginForm or field entity (optional) 

            try
            {
                // Update Account
                UpdatedProviderAccountResponse result = apiInstance.EditCredentialsOrRefreshProviderAccount(providerAccountIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.EditCredentialsOrRefreshProviderAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountIds** | **string**| comma separated providerAccountIds | 
 **body** | [**ProviderAccountRequest**](ProviderAccountRequest.md)| loginForm or field entity | [optional] 

### Return type

[**UpdatedProviderAccountResponse**](UpdatedProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallprovideraccounts"></a>
# **GetAllProviderAccounts**
> ProviderAccountResponse GetAllProviderAccounts (string include = null, string providerIds = null)

Get Provider Accounts

The get provider accounts service is used to return all the provider accounts added by the user. <br>This includes the failed and successfully added provider accounts.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllProviderAccountsExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var include = include_example;  // string | include (optional) 
            var providerIds = providerIds_example;  // string | Comma separated providerIds. (optional) 

            try
            {
                // Get Provider Accounts
                ProviderAccountResponse result = apiInstance.GetAllProviderAccounts(include, providerIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetAllProviderAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**| include | [optional] 
 **providerIds** | **string**| Comma separated providerIds. | [optional] 

### Return type

[**ProviderAccountResponse**](ProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprovideraccount"></a>
# **GetProviderAccount**
> ProviderAccountDetailResponse GetProviderAccount (long? providerAccountId, string include = null, string requestId = null)

Get Provider Account Details

The get provider account details service is used to learn the status of adding accounts and updating accounts.<br>This service has to be called continuously to know the progress level of the triggered process. This service also provides the MFA information requested by the provider site.<br>When <i>include = credentials</i>, questions is passed as input, the service returns the credentials (non-password values) and questions stored in the Yodlee system for that provider account. <br><br><b>Note:</b> <li>The password and answer fields are not returned in the response.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProviderAccountExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var providerAccountId = 789;  // long? | providerAccountId
            var include = include_example;  // string | include credentials,questions (optional) 
            var requestId = requestId_example;  // string | The unique identifier for the request that returns contextual data (optional) 

            try
            {
                // Get Provider Account Details
                ProviderAccountDetailResponse result = apiInstance.GetProviderAccount(providerAccountId, include, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **long?**| providerAccountId | 
 **include** | **string**| include credentials,questions | [optional] 
 **requestId** | **string**| The unique identifier for the request that returns contextual data | [optional] 

### Return type

[**ProviderAccountDetailResponse**](ProviderAccountDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprovideraccountprofiles"></a>
# **GetProviderAccountProfiles**
> ProviderAccountUserProfileResponse GetProviderAccountProfiles (string providerAccountId = null)

Get User Profile Details

<b>Refer GET /verification/holderProfile</b><br>The get provider accounts profile service is used to return the user profile details that are associated to the provider account. <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProviderAccountProfilesExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var providerAccountId = providerAccountId_example;  // string | Comma separated providerAccountIds. (optional) 

            try
            {
                // Get User Profile Details
                ProviderAccountUserProfileResponse result = apiInstance.GetProviderAccountProfiles(providerAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccountProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **string**| Comma separated providerAccountIds. | [optional] 

### Return type

[**ProviderAccountUserProfileResponse**](ProviderAccountUserProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="refreshprovideraccount"></a>
# **RefreshProviderAccount**
> RefreshProviderAccountResponse RefreshProviderAccount (ProviderAccountRefreshRequest body)

Refresh Provider Account

This api service will allow you to refresh the Non-MFA provider accounts against a configName, i.e refresh will respect the configurations of the configName while refreshing the account.<br>Note: this service will only work with FastLink 4 users.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefreshProviderAccountExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var body = new ProviderAccountRefreshRequest(); // ProviderAccountRefreshRequest | refreshRequest

            try
            {
                // Refresh Provider Account
                RefreshProviderAccountResponse result = apiInstance.RefreshProviderAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.RefreshProviderAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProviderAccountRefreshRequest**](ProviderAccountRefreshRequest.md)| refreshRequest | 

### Return type

[**RefreshProviderAccountResponse**](RefreshProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepreferences"></a>
# **UpdatePreferences**
> void UpdatePreferences (ProviderAccountPreferencesRequest body, long? providerAccountId)

Update Preferences

This endpoint is used to update preferences like data extracts and auto refreshes without triggering refresh for the providerAccount.<br>Setting isDataExtractsEnabled to false will not trigger data extracts notification and dataExtracts/events will not reflect any data change that is happening for the providerAccount.<br>Modified data will not be provided in the dataExtracts/userData endpoint.<br>Setting isAutoRefreshEnabled to false will not trigger auto refreshes for the provider account.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePreferencesExample
    {
        public void main()
        {
            var apiInstance = new ProviderAccountsApi();
            var body = new ProviderAccountPreferencesRequest(); // ProviderAccountPreferencesRequest | preferences
            var providerAccountId = 789;  // long? | providerAccountId

            try
            {
                // Update Preferences
                apiInstance.UpdatePreferences(body, providerAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.UpdatePreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProviderAccountPreferencesRequest**](ProviderAccountPreferencesRequest.md)| preferences | 
 **providerAccountId** | **long?**| providerAccountId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
