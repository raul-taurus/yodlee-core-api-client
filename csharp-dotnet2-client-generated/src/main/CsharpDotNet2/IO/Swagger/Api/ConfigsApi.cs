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
    public interface IConfigsApi
    {
        /// <summary>
        /// Subscribe For Notification Event The subscribe events service is used to subscribe to an event for receiving notifications.&lt;br&gt;The callback URL, where the notification will be posted should be provided to this service.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;Customers can subscribe to REFRESH,DATA_UPDATES,AUTO_REFRESH_UPDATES and LATEST_BALANCE_UPDATES event.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;li&gt;This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.&lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void CreateSubscriptionNotificationEvent (CreateConfigsNotificationEventRequest body, string eventName);
        /// <summary>
        /// Delete Notification Subscription The delete events service is used to unsubscribe from an events service.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void DeleteSubscribedNotificationEvent (string eventName);
        /// <summary>
        /// Get Subscribed Notification Events The get events service provides the list of events for which consumers subscribed to receive notifications. &lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns>ConfigsNotificationResponse</returns>
        ConfigsNotificationResponse GetSubscribedNotificationEvents (string eventName);
        /// <summary>
        /// Update Notification Subscription The update events service is used to update the callback URL.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        void UpdateSubscribedNotificationEvent (UpdateConfigsNotificationEventRequest body, string eventName);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigsApi : IConfigsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConfigsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigsApi(String basePath)
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
        /// Subscribe For Notification Event The subscribe events service is used to subscribe to an event for receiving notifications.&lt;br&gt;The callback URL, where the notification will be posted should be provided to this service.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;Customers can subscribe to REFRESH,DATA_UPDATES,AUTO_REFRESH_UPDATES and LATEST_BALANCE_UPDATES event.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;li&gt;This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.&lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void CreateSubscriptionNotificationEvent (CreateConfigsNotificationEventRequest body, string eventName)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateSubscriptionNotificationEvent");
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling CreateSubscriptionNotificationEvent");
    
            var path = "/configs/notifications/events/{eventName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionNotificationEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionNotificationEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete Notification Subscription The delete events service is used to unsubscribe from an events service.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void DeleteSubscribedNotificationEvent (string eventName)
        {
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling DeleteSubscribedNotificationEvent");
    
            var path = "/configs/notifications/events/{eventName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscribedNotificationEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscribedNotificationEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get Subscribed Notification Events The get events service provides the list of events for which consumers subscribed to receive notifications. &lt;br&gt;
        /// </summary>
        /// <param name="eventName">eventName</param>
        /// <returns>ConfigsNotificationResponse</returns>
        public ConfigsNotificationResponse GetSubscribedNotificationEvents (string eventName)
        {
    
            var path = "/configs/notifications/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscribedNotificationEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscribedNotificationEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ConfigsNotificationResponse) ApiClient.Deserialize(response.Content, typeof(ConfigsNotificationResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Notification Subscription The update events service is used to update the callback URL.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter. &lt;br&gt;
        /// </summary>
        /// <param name="body">eventRequest</param>
        /// <param name="eventName">eventName</param>
        /// <returns></returns>
        public void UpdateSubscribedNotificationEvent (UpdateConfigsNotificationEventRequest body, string eventName)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateSubscribedNotificationEvent");
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling UpdateSubscribedNotificationEvent");
    
            var path = "/configs/notifications/events/{eventName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscribedNotificationEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscribedNotificationEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
