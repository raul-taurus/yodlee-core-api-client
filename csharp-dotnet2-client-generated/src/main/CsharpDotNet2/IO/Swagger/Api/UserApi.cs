using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        /// <summary>
        /// Get Access Tokens The Get Access Tokens service is used to retrieve the access tokens for the application id(s) provided.&lt;br&gt;URL in the response can be used to launch the application for which token is requested.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;
        /// </summary>
        /// <param name="appIds">appIds</param>
        /// <returns>UserAccessTokensResponse</returns>
        UserAccessTokensResponse GetAccessTokens (string appIds);
        /// <summary>
        /// Get User Details The get user details service is used to get the user profile information and the application preferences set at the time of user registration.&lt;br&gt;
        /// </summary>
        /// <returns>UserDetailResponse</returns>
        UserDetailResponse GetUser ();
        /// <summary>
        /// Register User The register user service is used to register a user in Yodlee.&lt;br&gt;The loginName cannot include spaces and must be between 3 and 150 characters.&lt;br&gt;locale passed must be one of the supported locales for the customer. &lt;br&gt;Currency provided in the input will be respected in the derived services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;userParam is accepted as a body parameter. &lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt; &lt;br&gt; Note: We recommend you to not use special characters in loginName other than \&quot;@\&quot;, \&quot;#\&quot;, \&quot;_\&quot; &amp; \&quot;-\&quot;.
        /// </summary>
        /// <param name="body">userRequest</param>
        /// <returns>UserResponse</returns>
        UserResponse RegisterUser (UserRequest body);
        /// <summary>
        /// Saml Login The SAML login service is used to authenticate system users with a SAML response.&lt;br&gt;A new user will be created with the input provided if that user isn&#x27;t already in the system.&lt;br&gt;For existing users, the system will make updates based on changes or new information.&lt;br&gt;When authentication is successful, a user session token is returned.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/x-www-form-urlencoded. &lt;li&gt;issuer, source and samlResponse should be passed as body parameters.&lt;/li&gt;
        /// </summary>
        /// <param name="issuer">issuer</param>
        /// <param name="samlResponse">samlResponse</param>
        /// <param name="source">source</param>
        /// <returns>UserResponse</returns>
        UserResponse SamlLogin (string issuer, string samlResponse, string source);
        /// <summary>
        /// Delete User The delete user service is used to delete or unregister a user from Yodlee. &lt;br&gt;Once deleted, the information related to the users cannot be retrieved. &lt;br&gt;The HTTP response code is 204 (Success without content)&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        void Unregister ();
        /// <summary>
        /// Update User Details The update user details service is used to update user details like name, address, currency preference, etc.&lt;br&gt;Currency provided in the input will be respected in the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/products/yodlee/core-apis/docs/api-reference#yodlee-coreapis-derivednetworth-get\&quot;&gt;Derived&lt;/a&gt; services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;The HTTP response code is 204 (Success without content). &lt;br&gt;
        /// </summary>
        /// <param name="body">userRequest</param>
        /// <returns></returns>
        void UpdateUser (UpdateUserRequest body);
        /// <summary>
        /// User Logout &lt;b&gt;Deprecated&lt;/b&gt;: This endpoint is deprecated for API Key-based authentication. The user logout service allows the user to log out of the application.&lt;br&gt;The service does not return a response body. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        void UserLogout ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get Access Tokens The Get Access Tokens service is used to retrieve the access tokens for the application id(s) provided.&lt;br&gt;URL in the response can be used to launch the application for which token is requested.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;
        /// </summary>
        /// <param name="appIds">appIds</param>
        /// <returns>UserAccessTokensResponse</returns>
        public UserAccessTokensResponse GetAccessTokens (string appIds)
        {
            // verify the required parameter 'appIds' is set
            if (appIds == null) throw new ApiException(400, "Missing required parameter 'appIds' when calling GetAccessTokens");
    
            var path = "/user/accessTokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (appIds != null) queryParams.Add("appIds", ApiClient.ParameterToString(appIds)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccessTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccessTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAccessTokensResponse) ApiClient.Deserialize(response.Content, typeof(UserAccessTokensResponse), response.Headers);
        }
    
        /// <summary>
        /// Get User Details The get user details service is used to get the user profile information and the application preferences set at the time of user registration.&lt;br&gt;
        /// </summary>
        /// <returns>UserDetailResponse</returns>
        public UserDetailResponse GetUser ()
        {
    
            var path = "/user";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserDetailResponse) ApiClient.Deserialize(response.Content, typeof(UserDetailResponse), response.Headers);
        }
    
        /// <summary>
        /// Register User The register user service is used to register a user in Yodlee.&lt;br&gt;The loginName cannot include spaces and must be between 3 and 150 characters.&lt;br&gt;locale passed must be one of the supported locales for the customer. &lt;br&gt;Currency provided in the input will be respected in the derived services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;userParam is accepted as a body parameter. &lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt; &lt;br&gt; Note: We recommend you to not use special characters in loginName other than \&quot;@\&quot;, \&quot;#\&quot;, \&quot;_\&quot; &amp; \&quot;-\&quot;.
        /// </summary>
        /// <param name="body">userRequest</param>
        /// <returns>UserResponse</returns>
        public UserResponse RegisterUser (UserRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegisterUser");
    
            var path = "/user/register";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponse) ApiClient.Deserialize(response.Content, typeof(UserResponse), response.Headers);
        }
    
        /// <summary>
        /// Saml Login The SAML login service is used to authenticate system users with a SAML response.&lt;br&gt;A new user will be created with the input provided if that user isn&#x27;t already in the system.&lt;br&gt;For existing users, the system will make updates based on changes or new information.&lt;br&gt;When authentication is successful, a user session token is returned.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/x-www-form-urlencoded. &lt;li&gt;issuer, source and samlResponse should be passed as body parameters.&lt;/li&gt;
        /// </summary>
        /// <param name="issuer">issuer</param>
        /// <param name="samlResponse">samlResponse</param>
        /// <param name="source">source</param>
        /// <returns>UserResponse</returns>
        public UserResponse SamlLogin (string issuer, string samlResponse, string source)
        {
            // verify the required parameter 'issuer' is set
            if (issuer == null) throw new ApiException(400, "Missing required parameter 'issuer' when calling SamlLogin");
            // verify the required parameter 'samlResponse' is set
            if (samlResponse == null) throw new ApiException(400, "Missing required parameter 'samlResponse' when calling SamlLogin");
    
            var path = "/user/samlLogin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (issuer != null) queryParams.Add("issuer", ApiClient.ParameterToString(issuer)); // query parameter
 if (samlResponse != null) queryParams.Add("samlResponse", ApiClient.ParameterToString(samlResponse)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SamlLogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SamlLogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponse) ApiClient.Deserialize(response.Content, typeof(UserResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete User The delete user service is used to delete or unregister a user from Yodlee. &lt;br&gt;Once deleted, the information related to the users cannot be retrieved. &lt;br&gt;The HTTP response code is 204 (Success without content)&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        public void Unregister ()
        {
    
            var path = "/user/unregister";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Unregister: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Unregister: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update User Details The update user details service is used to update user details like name, address, currency preference, etc.&lt;br&gt;Currency provided in the input will be respected in the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/products/yodlee/core-apis/docs/api-reference#yodlee-coreapis-derivednetworth-get\&quot;&gt;Derived&lt;/a&gt; services and the amount fields in the response will be provided in the preferred currency.&lt;br&gt;The HTTP response code is 204 (Success without content). &lt;br&gt;
        /// </summary>
        /// <param name="body">userRequest</param>
        /// <returns></returns>
        public void UpdateUser (UpdateUserRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUser");
    
            var path = "/user";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// User Logout &lt;b&gt;Deprecated&lt;/b&gt;: This endpoint is deprecated for API Key-based authentication. The user logout service allows the user to log out of the application.&lt;br&gt;The service does not return a response body. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        public void UserLogout ()
        {
    
            var path = "/user/logout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserLogout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserLogout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
