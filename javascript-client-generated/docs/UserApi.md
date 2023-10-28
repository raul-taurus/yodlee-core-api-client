# YodleeCoreApis.UserApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getAccessTokens**](UserApi.md#getAccessTokens) | **GET** /user/accessTokens | Get Access Tokens
[**getUser**](UserApi.md#getUser) | **GET** /user | Get User Details
[**registerUser**](UserApi.md#registerUser) | **POST** /user/register | Register User
[**samlLogin**](UserApi.md#samlLogin) | **POST** /user/samlLogin | Saml Login
[**unregister**](UserApi.md#unregister) | **DELETE** /user/unregister | Delete User
[**updateUser**](UserApi.md#updateUser) | **PUT** /user | Update User Details
[**userLogout**](UserApi.md#userLogout) | **POST** /user/logout | User Logout

<a name="getAccessTokens"></a>
# **getAccessTokens**
> UserAccessTokensResponse getAccessTokens(appIds)

Get Access Tokens

The Get Access Tokens service is used to retrieve the access tokens for the application id(s) provided.&lt;br&gt;URL in the response can be used to launch the application for which token is requested.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
let appIds = "appIds_example"; // String | appIds

apiInstance.getAccessTokens(appIds, (error, data, response) => {
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
 **appIds** | **String**| appIds | 

### Return type

[**UserAccessTokensResponse**](UserAccessTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getUser"></a>
# **getUser**
> UserDetailResponse getUser()

Get User Details

The get user details service is used to get the user profile information and the application preferences set at the time of user registration.&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
apiInstance.getUser((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
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

<a name="registerUser"></a>
# **registerUser**
> UserResponse registerUser(body)

Register User

The register user service is used to register a user in Yodlee.&lt;br&gt;The loginName cannot include spaces and must be between 3 and 150 characters.&lt;br&gt;locale passed must be one of the supported locales for the customer. &lt;br&gt;Currency provided in the input will be respected in the derived services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;userParam is accepted as a body parameter. &lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt; &lt;br&gt; Note: We recommend you to not use special characters in loginName other than \&quot;@\&quot;, \&quot;#\&quot;, \&quot;_\&quot; &amp; \&quot;-\&quot;.

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
let body = new YodleeCoreApis.UserRequest(); // UserRequest | userRequest

apiInstance.registerUser(body, (error, data, response) => {
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
 **body** | [**UserRequest**](UserRequest.md)| userRequest | 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="samlLogin"></a>
# **samlLogin**
> UserResponse samlLogin(issuer, samlResponse, opts)

Saml Login

The SAML login service is used to authenticate system users with a SAML response.&lt;br&gt;A new user will be created with the input provided if that user isn&#x27;t already in the system.&lt;br&gt;For existing users, the system will make updates based on changes or new information.&lt;br&gt;When authentication is successful, a user session token is returned.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/x-www-form-urlencoded. &lt;li&gt;issuer, source and samlResponse should be passed as body parameters.&lt;/li&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
let issuer = "issuer_example"; // String | issuer
let samlResponse = "samlResponse_example"; // String | samlResponse
let opts = { 
  'source': "source_example" // String | source
};
apiInstance.samlLogin(issuer, samlResponse, opts, (error, data, response) => {
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
 **issuer** | **String**| issuer | 
 **samlResponse** | **String**| samlResponse | 
 **source** | **String**| source | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="unregister"></a>
# **unregister**
> unregister()

Delete User

The delete user service is used to delete or unregister a user from Yodlee. &lt;br&gt;Once deleted, the information related to the users cannot be retrieved. &lt;br&gt;The HTTP response code is 204 (Success without content)&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
apiInstance.unregister((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateUser"></a>
# **updateUser**
> updateUser(body)

Update User Details

The update user details service is used to update user details like name, address, currency preference, etc.&lt;br&gt;Currency provided in the input will be respected in the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/products/yodlee/core-apis/docs/api-reference#yodlee-coreapis-derivednetworth-get\&quot;&gt;Derived&lt;/a&gt; services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;The HTTP response code is 204 (Success without content). &lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
let body = new YodleeCoreApis.UpdateUserRequest(); // UpdateUserRequest | userRequest

apiInstance.updateUser(body, (error, data, response) => {
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
 **body** | [**UpdateUserRequest**](UpdateUserRequest.md)| userRequest | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userLogout"></a>
# **userLogout**
> userLogout()

User Logout

&lt;b&gt;Deprecated&lt;/b&gt;: This endpoint is deprecated for API Key-based authentication. The user logout service allows the user to log out of the application.&lt;br&gt;The service does not return a response body. The HTTP response code is 204 (Success with no content).&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.UserApi();
apiInstance.userLogout((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

