# IO.Swagger.Api.UserApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccessTokens**](UserApi.md#getaccesstokens) | **GET** /user/accessTokens | Get Access Tokens
[**GetUser**](UserApi.md#getuser) | **GET** /user | Get User Details
[**RegisterUser**](UserApi.md#registeruser) | **POST** /user/register | Register User
[**SamlLogin**](UserApi.md#samllogin) | **POST** /user/samlLogin | Saml Login
[**Unregister**](UserApi.md#unregister) | **DELETE** /user/unregister | Delete User
[**UpdateUser**](UserApi.md#updateuser) | **PUT** /user | Update User Details
[**UserLogout**](UserApi.md#userlogout) | **POST** /user/logout | User Logout

<a name="getaccesstokens"></a>
# **GetAccessTokens**
> UserAccessTokensResponse GetAccessTokens (string appIds)

Get Access Tokens

The Get Access Tokens service is used to retrieve the access tokens for the application id(s) provided.<br>URL in the response can be used to launch the application for which token is requested.<br><br><b>Note:</b> <li>This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccessTokensExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var appIds = appIds_example;  // string | appIds

            try
            {
                // Get Access Tokens
                UserAccessTokensResponse result = apiInstance.GetAccessTokens(appIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetAccessTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appIds** | **string**| appIds | 

### Return type

[**UserAccessTokensResponse**](UserAccessTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuser"></a>
# **GetUser**
> UserDetailResponse GetUser ()

Get User Details

The get user details service is used to get the user profile information and the application preferences set at the time of user registration.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                // Get User Details
                UserDetailResponse result = apiInstance.GetUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserDetailResponse**](UserDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeruser"></a>
# **RegisterUser**
> UserResponse RegisterUser (UserRequest body)

Register User

The register user service is used to register a user in Yodlee.<br>The loginName cannot include spaces and must be between 3 and 150 characters.<br>locale passed must be one of the supported locales for the customer. <br>Currency provided in the input will be respected in the derived services and the amount fields in the response will be provided in the preferred currency.<br>userParam is accepted as a body parameter. <br><br><b>Note:</b> <li>The content type has to be passed as application/json for the body parameter.</li> <br> Note: We recommend you to not use special characters in loginName other than \"@\", \"#\", \"_\" & \"-\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new UserRequest(); // UserRequest | userRequest

            try
            {
                // Register User
                UserResponse result = apiInstance.RegisterUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RegisterUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRequest**](UserRequest.md)| userRequest | 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="samllogin"></a>
# **SamlLogin**
> UserResponse SamlLogin (string issuer, string samlResponse, string source = null)

Saml Login

The SAML login service is used to authenticate system users with a SAML response.<br>A new user will be created with the input provided if that user isn't already in the system.<br>For existing users, the system will make updates based on changes or new information.<br>When authentication is successful, a user session token is returned.<br><br><b>Note:</b> <li>The content type has to be passed as application/x-www-form-urlencoded. <li>issuer, source and samlResponse should be passed as body parameters.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SamlLoginExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var issuer = issuer_example;  // string | issuer
            var samlResponse = samlResponse_example;  // string | samlResponse
            var source = source_example;  // string | source (optional) 

            try
            {
                // Saml Login
                UserResponse result = apiInstance.SamlLogin(issuer, samlResponse, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SamlLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issuer** | **string**| issuer | 
 **samlResponse** | **string**| samlResponse | 
 **source** | **string**| source | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unregister"></a>
# **Unregister**
> void Unregister ()

Delete User

The delete user service is used to delete or unregister a user from Yodlee. <br>Once deleted, the information related to the users cannot be retrieved. <br>The HTTP response code is 204 (Success without content)<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnregisterExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                // Delete User
                apiInstance.Unregister();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.Unregister: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (UpdateUserRequest body)

Update User Details

The update user details service is used to update user details like name, address, currency preference, etc.<br>Currency provided in the input will be respected in the <a href=\"https://developer.envestnet.com/products/yodlee/core-apis/docs/api-reference#yodlee-coreapis-derivednetworth-get\">Derived</a> services and the amount fields in the response will be provided in the preferred currency.<br>The HTTP response code is 204 (Success without content). <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new UpdateUserRequest(); // UpdateUserRequest | userRequest

            try
            {
                // Update User Details
                apiInstance.UpdateUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateUserRequest**](UpdateUserRequest.md)| userRequest | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userlogout"></a>
# **UserLogout**
> void UserLogout ()

User Logout

<b>Deprecated</b>: This endpoint is deprecated for API Key-based authentication. The user logout service allows the user to log out of the application.<br>The service does not return a response body. The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserLogoutExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                // User Logout
                apiInstance.UserLogout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserLogout: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
