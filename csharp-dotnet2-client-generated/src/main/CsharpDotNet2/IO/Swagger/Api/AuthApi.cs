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
    public interface IAuthApi
    {
        /// <summary>
        /// Delete API Key This endpoint allows an existing API key to be deleted.&lt;br&gt;You can use one of the following authorization methods to access this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt; &lt;b&gt;Notes:&lt;/b&gt; &lt;li&gt;This service is not available in developer sandbox environment and will be made availablefor testing in your dedicated environment. 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        void DeleteApiKey (string key);
        /// <summary>
        /// Delete Token This endpoint revokes the token passed in the Authorization header. This service is applicable for JWT-based (and all API key-based) authentication and also client credential (clientId and secret) based authentication. This service does not return a response body. The HTTP response code is 204 (success with no content). &lt;br&gt;Tokens generally have limited lifetime of up to 30 minutes. You will call this service when you finish working with one user, and you want to delete the valid token rather than simply letting it expire.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;Revoking an access token (either type, admin or a user token) can take up to 2 minutes, as the tokens are stored on a distributed system.&lt;br/&gt;
        /// </summary>
        /// <returns></returns>
        void DeleteToken ();
        /// <summary>
        /// Generate Access Token &lt;b&gt;Generate Access Token using client credential authentication.&lt;/b&gt;&lt;br&gt;This service returns access tokens required to access Yodlee 1.1 APIs. These tokens are the simplest and easiest of several alternatives for authenticating with Yodlee servers.&lt;br&gt;The most commonly used services obtain data specific to an end user (your customer). For these services, you need a &lt;b&gt;user access token&lt;/b&gt;. These are simply tokens created with the user name parameter (&lt;b&gt;loginName&lt;/b&gt;) set to the id of your end user.  &lt;i&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; You determine this id and you must ensure it&#x27;s unique among all your customers.&lt;/i&gt; &lt;br&gt;&lt;br&gt;Each token issued has an associated user. The token passed in the http headers explicitly names the user referenced in that API call.&lt;br&gt;&lt;br&gt;Some of the APIs do administrative work, and don&#x27;t reference an end user. &lt;br/&gt;One example of administrative work is key management. Another example is registering a new user explicitly, with &lt;b&gt;POST /user/register&lt;/b&gt; call or subscribe to webhook, with &lt;b&gt;POST /config/notifications/events/{eventName}&lt;/b&gt;. &lt;br/&gt;To invoke these, you need an &lt;b&gt;admin access token&lt;/b&gt;. Create this by passing in your admin user login name in place of a regular user name.&lt;br&gt;&lt;br&gt;This service also allows for simplified registration of new users. Any time you pass in a user name not already in use, the system will automatically implicitly create a new user for you. &lt;br&gt;This user will naturally have very few associated details. You can later provide additional user information by calling the &lt;b&gt;PUT user/register service&lt;/b&gt;.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ul&gt;&lt;li&gt;The header &lt;code&gt;Authorization&lt;/code&gt; does not apply to this service.&lt;/li&gt;&lt;li&gt;The content type has to be passed as application/x-www-form-urlencoded.&lt;li&gt;Upgrading to client credential authentication requires infrastructure reconfiguration. &lt;li&gt;Customers wishing to switch from another authentication scheme to client credential authentication, please contact Yodlee Client Services.&lt;/li&gt;&lt;li&gt;Default expiry time of user access token and admin access token is 30 minutes.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="secret"></param>
        /// <returns>ClientCredentialTokenResponse</returns>
        ClientCredentialTokenResponse GenerateAccessToken (string clientId, string secret);
        /// <summary>
        /// Generate API Key This endpoint is used to generate an API key. The RSA public key you provide should be in 2048 bit PKCS#8 encoded format. &lt;br&gt;A public key is a mandatory input for generating the API key.&lt;br/&gt;The public key should be a unique key. The apiKeyId you get in the response is what you should use to generate the JWT token.&lt;br&gt; You can use one of the following authorization methods to access&lt;br/&gt;this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt; Alternatively, you can use base 64 encoded cobrandLogin and cobrandPassword in the Authorization header (Format: Authorization: Basic &lt;encoded value of cobrandLogin: cobrandPassword&gt;)&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. The content type has to be passed as application/json for the body parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="body">apiKeyRequest</param>
        /// <returns>ApiKeyResponse</returns>
        ApiKeyResponse GenerateApiKey (ApiKeyRequest body);
        /// <summary>
        /// Get API Keys This endpoint provides the list of API keys that exist for a customer.&lt;br&gt;You can use one of the following authorization methods to access this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;li&gt;This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. 
        /// </summary>
        /// <returns>ApiKeyResponse</returns>
        ApiKeyResponse GetApiKeys ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthApi : IAuthApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
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
        /// Delete API Key This endpoint allows an existing API key to be deleted.&lt;br&gt;You can use one of the following authorization methods to access this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt; &lt;b&gt;Notes:&lt;/b&gt; &lt;li&gt;This service is not available in developer sandbox environment and will be made availablefor testing in your dedicated environment. 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        public void DeleteApiKey (string key)
        {
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteApiKey");
    
            var path = "/auth/apiKey/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete Token This endpoint revokes the token passed in the Authorization header. This service is applicable for JWT-based (and all API key-based) authentication and also client credential (clientId and secret) based authentication. This service does not return a response body. The HTTP response code is 204 (success with no content). &lt;br&gt;Tokens generally have limited lifetime of up to 30 minutes. You will call this service when you finish working with one user, and you want to delete the valid token rather than simply letting it expire.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;Revoking an access token (either type, admin or a user token) can take up to 2 minutes, as the tokens are stored on a distributed system.&lt;br/&gt;
        /// </summary>
        /// <returns></returns>
        public void DeleteToken ()
        {
    
            var path = "/auth/token";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generate Access Token &lt;b&gt;Generate Access Token using client credential authentication.&lt;/b&gt;&lt;br&gt;This service returns access tokens required to access Yodlee 1.1 APIs. These tokens are the simplest and easiest of several alternatives for authenticating with Yodlee servers.&lt;br&gt;The most commonly used services obtain data specific to an end user (your customer). For these services, you need a &lt;b&gt;user access token&lt;/b&gt;. These are simply tokens created with the user name parameter (&lt;b&gt;loginName&lt;/b&gt;) set to the id of your end user.  &lt;i&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; You determine this id and you must ensure it&#x27;s unique among all your customers.&lt;/i&gt; &lt;br&gt;&lt;br&gt;Each token issued has an associated user. The token passed in the http headers explicitly names the user referenced in that API call.&lt;br&gt;&lt;br&gt;Some of the APIs do administrative work, and don&#x27;t reference an end user. &lt;br/&gt;One example of administrative work is key management. Another example is registering a new user explicitly, with &lt;b&gt;POST /user/register&lt;/b&gt; call or subscribe to webhook, with &lt;b&gt;POST /config/notifications/events/{eventName}&lt;/b&gt;. &lt;br/&gt;To invoke these, you need an &lt;b&gt;admin access token&lt;/b&gt;. Create this by passing in your admin user login name in place of a regular user name.&lt;br&gt;&lt;br&gt;This service also allows for simplified registration of new users. Any time you pass in a user name not already in use, the system will automatically implicitly create a new user for you. &lt;br&gt;This user will naturally have very few associated details. You can later provide additional user information by calling the &lt;b&gt;PUT user/register service&lt;/b&gt;.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ul&gt;&lt;li&gt;The header &lt;code&gt;Authorization&lt;/code&gt; does not apply to this service.&lt;/li&gt;&lt;li&gt;The content type has to be passed as application/x-www-form-urlencoded.&lt;li&gt;Upgrading to client credential authentication requires infrastructure reconfiguration. &lt;li&gt;Customers wishing to switch from another authentication scheme to client credential authentication, please contact Yodlee Client Services.&lt;/li&gt;&lt;li&gt;Default expiry time of user access token and admin access token is 30 minutes.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="secret"></param>
        /// <returns>ClientCredentialTokenResponse</returns>
        public ClientCredentialTokenResponse GenerateAccessToken (string clientId, string secret)
        {
    
            var path = "/auth/token";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (clientId != null) formParams.Add("clientId", ApiClient.ParameterToString(clientId)); // form parameter
if (secret != null) formParams.Add("secret", ApiClient.ParameterToString(secret)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GenerateAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GenerateAccessToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientCredentialTokenResponse) ApiClient.Deserialize(response.Content, typeof(ClientCredentialTokenResponse), response.Headers);
        }
    
        /// <summary>
        /// Generate API Key This endpoint is used to generate an API key. The RSA public key you provide should be in 2048 bit PKCS#8 encoded format. &lt;br&gt;A public key is a mandatory input for generating the API key.&lt;br/&gt;The public key should be a unique key. The apiKeyId you get in the response is what you should use to generate the JWT token.&lt;br&gt; You can use one of the following authorization methods to access&lt;br/&gt;this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt; Alternatively, you can use base 64 encoded cobrandLogin and cobrandPassword in the Authorization header (Format: Authorization: Basic &lt;encoded value of cobrandLogin: cobrandPassword&gt;)&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. The content type has to be passed as application/json for the body parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="body">apiKeyRequest</param>
        /// <returns>ApiKeyResponse</returns>
        public ApiKeyResponse GenerateApiKey (ApiKeyRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GenerateApiKey");
    
            var path = "/auth/apiKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GenerateApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GenerateApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyResponse) ApiClient.Deserialize(response.Content, typeof(ApiKeyResponse), response.Headers);
        }
    
        /// <summary>
        /// Get API Keys This endpoint provides the list of API keys that exist for a customer.&lt;br&gt;You can use one of the following authorization methods to access this API:&lt;br&gt;&lt;ol&gt;&lt;li&gt;cobsession&lt;/li&gt;&lt;li&gt;JWT token&lt;/li&gt;&lt;/ol&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;li&gt;This service is not available in developer sandbox environment and will be made available for testing in your dedicated environment. 
        /// </summary>
        /// <returns>ApiKeyResponse</returns>
        public ApiKeyResponse GetApiKeys ()
        {
    
            var path = "/auth/apiKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetApiKeys: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApiKeys: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyResponse) ApiClient.Deserialize(response.Content, typeof(ApiKeyResponse), response.Headers);
        }
    
    }
}
