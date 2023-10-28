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
    public interface ICobrandApi
    {
        /// <summary>
        /// Cobrand Login The cobrand login service authenticates a cobrand.&lt;br&gt;Cobrand session in the response includes the cobrand session token (cobSession) &lt;br&gt;which is used in subsequent API calls like registering or signing in the user. &lt;br&gt;The idle timeout for a cobrand session is 2 hours and the absolute timeout is 24 hours. This service can be &lt;br&gt;invoked to create a new cobrand session token. &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">cobrandLoginRequest</param>
        /// <returns>CobrandLoginResponse</returns>
        CobrandLoginResponse CobrandLogin (CobrandLoginRequest body);
        /// <summary>
        /// Cobrand Logout The cobrand logout service is used to log out the cobrand.&lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        void CobrandLogout ();
        /// <summary>
        /// Subscribe Event &lt;b&gt;Refer POST /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The subscribe events service is used to subscribe to an event for receiving notifications.&lt;br&gt;The callback URL, where the notification will be posted should be provided to this service.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;Customers can subscribe to REFRESH,DATA_UPDATES and AUTO_REFRESH_UPDATES event.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes&lt;/b&gt;:&lt;br&gt;This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.&lt;br&gt;The content type has to be passed as application/json for the body parameter.&lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void CreateSubscriptionEvent (CreateCobrandNotificationEventRequest body, string eventName);
        /// <summary>
        /// Delete Subscription &lt;b&gt;Refer DELETE /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The delete events service is used to unsubscribe from an events service.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void DeleteSubscribedEvent (string eventName);
        /// <summary>
        /// Get Public Key &lt;b&gt;Refer GET /configs/publicKey.&lt;/b&gt;&lt;br&gt;The get public key service provides the customer the public key that should be used to encrypt the user credentials before sending it to Yodlee.&lt;br&gt;This endpoint is useful only for PKI enabled.&lt;br&gt;
        /// </summary>
        /// <returns>CobrandPublicKeyResponse</returns>
        CobrandPublicKeyResponse GetPublicKey ();
        /// <summary>
        /// Get Subscribed Events &lt;b&gt;Refer GET /configs/notifications/events.&lt;/b&gt;&lt;br&gt;The get events service provides the list of events for which consumers subscribed &lt;br&gt;to receive notifications. &lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns>CobrandNotificationResponse</returns>
        CobrandNotificationResponse GetSubscribedEvents (string eventName);
        /// <summary>
        /// Update Subscription &lt;b&gt;Refer PUT /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The update events service is used to update the callback URL.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void UpdateSubscribedEvent (UpdateCobrandNotificationEventRequest body, string eventName);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CobrandApi : ICobrandApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CobrandApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CobrandApi(String basePath)
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
        /// Cobrand Login The cobrand login service authenticates a cobrand.&lt;br&gt;Cobrand session in the response includes the cobrand session token (cobSession) &lt;br&gt;which is used in subsequent API calls like registering or signing in the user. &lt;br&gt;The idle timeout for a cobrand session is 2 hours and the absolute timeout is 24 hours. This service can be &lt;br&gt;invoked to create a new cobrand session token. &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">cobrandLoginRequest</param>
        /// <returns>CobrandLoginResponse</returns>
        public CobrandLoginResponse CobrandLogin (CobrandLoginRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CobrandLogin");
    
            var path = "/cobrand/login";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CobrandLogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CobrandLogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CobrandLoginResponse) ApiClient.Deserialize(response.Content, typeof(CobrandLoginResponse), response.Headers);
        }
    
        /// <summary>
        /// Cobrand Logout The cobrand logout service is used to log out the cobrand.&lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.&lt;br&gt;
        /// </summary>
        /// <returns></returns>
        public void CobrandLogout ()
        {
    
            var path = "/cobrand/logout";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CobrandLogout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CobrandLogout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Subscribe Event &lt;b&gt;Refer POST /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The subscribe events service is used to subscribe to an event for receiving notifications.&lt;br&gt;The callback URL, where the notification will be posted should be provided to this service.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;Customers can subscribe to REFRESH,DATA_UPDATES and AUTO_REFRESH_UPDATES event.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes&lt;/b&gt;:&lt;br&gt;This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.&lt;br&gt;The content type has to be passed as application/json for the body parameter.&lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void CreateSubscriptionEvent (CreateCobrandNotificationEventRequest body, string eventName)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateSubscriptionEvent");
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling CreateSubscriptionEvent");
    
            var path = "/cobrand/config/notifications/events/{eventName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventName" + "}", ApiClient.ParameterToString(eventName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete Subscription &lt;b&gt;Refer DELETE /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The delete events service is used to unsubscribe from an events service.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void DeleteSubscribedEvent (string eventName)
        {
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling DeleteSubscribedEvent");
    
            var path = "/cobrand/config/notifications/events/{eventName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventName" + "}", ApiClient.ParameterToString(eventName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscribedEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscribedEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get Public Key &lt;b&gt;Refer GET /configs/publicKey.&lt;/b&gt;&lt;br&gt;The get public key service provides the customer the public key that should be used to encrypt the user credentials before sending it to Yodlee.&lt;br&gt;This endpoint is useful only for PKI enabled.&lt;br&gt;
        /// </summary>
        /// <returns>CobrandPublicKeyResponse</returns>
        public CobrandPublicKeyResponse GetPublicKey ()
        {
    
            var path = "/cobrand/publicKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CobrandPublicKeyResponse) ApiClient.Deserialize(response.Content, typeof(CobrandPublicKeyResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Subscribed Events &lt;b&gt;Refer GET /configs/notifications/events.&lt;/b&gt;&lt;br&gt;The get events service provides the list of events for which consumers subscribed &lt;br&gt;to receive notifications. &lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns>CobrandNotificationResponse</returns>
        public CobrandNotificationResponse GetSubscribedEvents (string eventName)
        {
    
            var path = "/cobrand/config/notifications/events";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventName != null) queryParams.Add("eventName", ApiClient.ParameterToString(eventName)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscribedEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscribedEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CobrandNotificationResponse) ApiClient.Deserialize(response.Content, typeof(CobrandNotificationResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Subscription &lt;b&gt;Refer PUT /configs/notifications/events/{eventName}.&lt;/b&gt;&lt;br&gt;The update events service is used to update the callback URL.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void UpdateSubscribedEvent (UpdateCobrandNotificationEventRequest body, string eventName)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateSubscribedEvent");
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling UpdateSubscribedEvent");
    
            var path = "/cobrand/config/notifications/events/{eventName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eventName" + "}", ApiClient.ParameterToString(eventName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscribedEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscribedEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
