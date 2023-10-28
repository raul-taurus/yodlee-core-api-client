# IO.Swagger.Api.AuthApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteApiKey**](AuthApi.md#deleteapikey) | **DELETE** /auth/apiKey/{key} | Delete API Key
[**DeleteToken**](AuthApi.md#deletetoken) | **DELETE** /auth/token | Delete Token
[**GenerateAccessToken**](AuthApi.md#generateaccesstoken) | **POST** /auth/token | Generate Access Token
[**GenerateApiKey**](AuthApi.md#generateapikey) | **POST** /auth/apiKey | Generate API Key
[**GetApiKeys**](AuthApi.md#getapikeys) | **GET** /auth/apiKey | Get API Keys

<a name="deleteapikey"></a>
# **DeleteApiKey**
> void DeleteApiKey (string key)

Delete API Key

This endpoint allows an existing API key to be deleted.<br>You can use one of the following authorization methods to access this API:<br><ol><li>cobsession</li><li>JWT token</li></ol> <b>Notes:</b> <li>This service is not available in developer sandbox environment and will be made availablefor testing in your dedicated environment. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteApiKeyExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var key = key_example;  // string | key

            try
            {
                // Delete API Key
                apiInstance.DeleteApiKey(key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetoken"></a>
# **DeleteToken**
> void DeleteToken ()

Delete Token

This endpoint revokes the token passed in the Authorization header. This service is applicable for JWT-based (and all API key-based) authentication and also client credential (clientId and secret) based authentication. This service does not return a response body. The HTTP response code is 204 (success with no content). <br>Tokens generally have limited lifetime of up to 30 minutes. You will call this service when you finish working with one user, and you want to delete the valid token rather than simply letting it expire.<br><br><b>Note:</b> <li>Revoking an access token (either type, admin or a user token) can take up to 2 minutes, as the tokens are stored on a distributed system.<br/>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();

            try
            {
                // Delete Token
                apiInstance.DeleteToken();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generateaccesstoken"></a>
# **GenerateAccessToken**
> ClientCredentialTokenResponse GenerateAccessToken (string clientId = null, string secret = null)

Generate Access Token

<b>Generate Access Token using client credential authentication.</b><br>This service returns access tokens required to access Yodlee 1.1 APIs. These tokens are the simplest and easiest of several alternatives for authenticating with Yodlee servers.<br>The most commonly used services obtain data specific to an end user (your customer). For these services, you need a <b>user access token</b>. These are simply tokens created with the user name parameter (<b>loginName</b>) set to the id of your end user.  <i><br><br><b>Note:</b> You determine this id and you must ensure it's unique among all your customers.</i> <br><br>Each token issued has an associated user. The token passed in the http headers explicitly names the user referenced in that API call.<br><br>Some of the APIs do administrative work, and don't reference an end user. <br/>One example of administrative work is key management. Another example is registering a new user explicitly, with <b>POST /user/register</b> call or subscribe to webhook, with <b>POST /config/notifications/events/{eventName}</b>. <br/>To invoke these, you need an <b>admin access token</b>. Create this by passing in your admin user login name in place of a regular user name.<br><br>This service also allows for simplified registration of new users. Any time you pass in a user name not already in use, the system will automatically implicitly create a new user for you. <br>This user will naturally have very few associated details. You can later provide additional user information by calling the <b>PUT user/register service</b>.<br><br><b>Notes:</b><ul><li>The header <code>Authorization</code> does not apply to this service.</li><li>The content type has to be passed as application/x-www-form-urlencoded.<li>Upgrading to client credential authentication requires infrastructure reconfiguration. <li>Customers wishing to switch from another authentication scheme to client credential authentication, please contact Yodlee Client Services.</li><li>Default expiry time of user access token and admin access token is 30 minutes.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateAccessTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var clientId = clientId_example;  // string |  (optional) 
            var secret = secret_example;  // string |  (optional) 

            try
            {
                // Generate Access Token
                ClientCredentialTokenResponse result = apiInstance.GenerateAccessToken(clientId, secret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.GenerateAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | [optional] 
 **secret** | **string**|  | [optional] 

### Return type

[**ClientCredentialTokenResponse**](ClientCredentialTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generateapikey"></a>
# **GenerateApiKey**
> ApiKeyResponse GenerateApiKey (ApiKeyRequest body)

Generate API Key

This endpoint is used to generate an API key. The RSA public key you provide should be in 2048 bit PKCS#8 encoded format. <br>A public key is a mandatory input for generating the API key.<br/>The public key should be a unique key. The apiKeyId you get in the response is what you should use to generate the JWT token.<br> You can use one of the following authorization methods to access<br/>this API:<br><ol><li>cobsession</li><li>JWT token</li></ol> Alternatively, you can use base 64 encoded cobrandLogin and cobrandPassword in the Authorization header (Format: Authorization: Basic <encoded value of cobrandLogin: cobrandPassword>)<br><br><b>Note:</b><br><li>This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. The content type has to be passed as application/json for the body parameter.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateApiKeyExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var body = new ApiKeyRequest(); // ApiKeyRequest | apiKeyRequest

            try
            {
                // Generate API Key
                ApiKeyResponse result = apiInstance.GenerateApiKey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.GenerateApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiKeyRequest**](ApiKeyRequest.md)| apiKeyRequest | 

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapikeys"></a>
# **GetApiKeys**
> ApiKeyResponse GetApiKeys ()

Get API Keys

This endpoint provides the list of API keys that exist for a customer.<br>You can use one of the following authorization methods to access this API:<br><ol><li>cobsession</li><li>JWT token</li></ol><b>Notes:</b><li>This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetApiKeysExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();

            try
            {
                // Get API Keys
                ApiKeyResponse result = apiInstance.GetApiKeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.GetApiKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
