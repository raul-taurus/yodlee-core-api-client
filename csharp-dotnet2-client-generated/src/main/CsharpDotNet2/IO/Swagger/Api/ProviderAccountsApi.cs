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
    public interface IProviderAccountsApi
    {
        /// <summary>
        /// Delete Provider Account The delete provider account service is used to delete a provider account from the Yodlee system. This service also deletes the accounts that are created in the Yodlee system for that provider account. &lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns></returns>
        void DeleteProviderAccount (long? providerAccountId);
        /// <summary>
        /// Update Account &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The update account API is used to:&lt;br&gt; &lt;ul&gt;&lt;li&gt;Retrieve the latest information of all the eligible accounts that belong to the user.&lt;li&gt;Check the status of the providerAccount before invoking this API. Do not call this API to trigger any action on a providerAccount when an action is already in progress for the providerAccount.&lt;li&gt;If the customer has subscribed to the REFRESH event notification and invoked this API, relevant notifications will be sent to the customer.&lt;li&gt;Check all the dataset additional statuses returned in the response because the provider account status is drawn from the dataset additional statuses.&lt;li&gt;Updating preferences using this API will trigger refreshes.&lt;li&gt; The content type has to be passed as application/json for the body parameter.&lt;/ul&gt;&lt;br&gt;- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --&lt;br&gt;&lt;br&gt;&lt;b&gt;Update All Eligible Accounts - Notes:&lt;/b&gt;&lt;br&gt;&lt;ul&gt;&lt;li&gt;This API will trigger a refresh for all the eligible provider accounts(both OB and credential-based accounts).&lt;li&gt;This API will not refresh closed, inactive, or UAR accounts, or accounts with refreshes in-progress or recently refreshed non-OB accounts.&lt;li&gt;No parameters should be passed to this API to trigger this action.&lt;li&gt;Do not call this API often. Our recommendation is to call this only at the time the user logs in to your app because it can hamper other API calls performance.&lt;li&gt;The response only contains information for accounts that were refreshed. If no accounts are eligible for refresh, no response is returned.&lt;/ul&gt;
        /// </summary>
        /// <param name="providerAccountIds">comma separated providerAccountIds</param>
        /// <param name="body">loginForm or field entity</param>
        /// <returns>UpdatedProviderAccountResponse</returns>
        UpdatedProviderAccountResponse EditCredentialsOrRefreshProviderAccount (string providerAccountIds, ProviderAccountRequest body);
        /// <summary>
        /// Get Provider Accounts The get provider accounts service is used to return all the provider accounts added by the user. &lt;br&gt;This includes the failed and successfully added provider accounts.&lt;br&gt;
        /// </summary>
        /// <param name="include">include</param>
        /// <param name="providerIds">Comma separated providerIds.</param>
        /// <returns>ProviderAccountResponse</returns>
        ProviderAccountResponse GetAllProviderAccounts (string include, string providerIds);
        /// <summary>
        /// Get Provider Account Details The get provider account details service is used to learn the status of adding accounts and updating accounts.&lt;br&gt;This service has to be called continuously to know the progress level of the triggered process. This service also provides the MFA information requested by the provider site.&lt;br&gt;When &lt;i&gt;include &#x3D; credentials&lt;/i&gt;, questions is passed as input, the service returns the credentials (non-password values) and questions stored in the Yodlee system for that provider account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The password and answer fields are not returned in the response.&lt;/li&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <param name="include">include credentials,questions</param>
        /// <param name="requestId">The unique identifier for the request that returns contextual data</param>
        /// <returns>ProviderAccountDetailResponse</returns>
        ProviderAccountDetailResponse GetProviderAccount (long? providerAccountId, string include, string requestId);
        /// <summary>
        /// Get User Profile Details &lt;b&gt;Refer GET /verification/holderProfile&lt;/b&gt;&lt;br&gt;The get provider accounts profile service is used to return the user profile details that are associated to the provider account. &lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">Comma separated providerAccountIds.</param>
        /// <returns>ProviderAccountUserProfileResponse</returns>
        ProviderAccountUserProfileResponse GetProviderAccountProfiles (string providerAccountId);
        /// <summary>
        /// Refresh Provider Account This api service will allow you to refresh the Non-MFA provider accounts against a configName, i.e refresh will respect the configurations of the configName while refreshing the account.&lt;br&gt;Note: this service will only work with FastLink 4 users.&lt;br&gt;
        /// </summary>
        /// <param name="body">refreshRequest</param>
        /// <returns>RefreshProviderAccountResponse</returns>
        RefreshProviderAccountResponse RefreshProviderAccount (ProviderAccountRefreshRequest body);
        /// <summary>
        /// Update Preferences This endpoint is used to update preferences like data extracts and auto refreshes without triggering refresh for the providerAccount.&lt;br&gt;Setting isDataExtractsEnabled to false will not trigger data extracts notification and dataExtracts/events will not reflect any data change that is happening for the providerAccount.&lt;br&gt;Modified data will not be provided in the dataExtracts/userData endpoint.&lt;br&gt;Setting isAutoRefreshEnabled to false will not trigger auto refreshes for the provider account.&lt;br&gt;
        /// </summary>
        /// <param name="body">preferences</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns></returns>
        void UpdatePreferences (ProviderAccountPreferencesRequest body, long? providerAccountId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProviderAccountsApi : IProviderAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProviderAccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProviderAccountsApi(String basePath)
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
        /// Delete Provider Account The delete provider account service is used to delete a provider account from the Yodlee system. This service also deletes the accounts that are created in the Yodlee system for that provider account. &lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns></returns>
        public void DeleteProviderAccount (long? providerAccountId)
        {
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling DeleteProviderAccount");
    
            var path = "/providerAccounts/{providerAccountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "providerAccountId" + "}", ApiClient.ParameterToString(providerAccountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProviderAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProviderAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update Account &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The update account API is used to:&lt;br&gt; &lt;ul&gt;&lt;li&gt;Retrieve the latest information of all the eligible accounts that belong to the user.&lt;li&gt;Check the status of the providerAccount before invoking this API. Do not call this API to trigger any action on a providerAccount when an action is already in progress for the providerAccount.&lt;li&gt;If the customer has subscribed to the REFRESH event notification and invoked this API, relevant notifications will be sent to the customer.&lt;li&gt;Check all the dataset additional statuses returned in the response because the provider account status is drawn from the dataset additional statuses.&lt;li&gt;Updating preferences using this API will trigger refreshes.&lt;li&gt; The content type has to be passed as application/json for the body parameter.&lt;/ul&gt;&lt;br&gt;- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --&lt;br&gt;&lt;br&gt;&lt;b&gt;Update All Eligible Accounts - Notes:&lt;/b&gt;&lt;br&gt;&lt;ul&gt;&lt;li&gt;This API will trigger a refresh for all the eligible provider accounts(both OB and credential-based accounts).&lt;li&gt;This API will not refresh closed, inactive, or UAR accounts, or accounts with refreshes in-progress or recently refreshed non-OB accounts.&lt;li&gt;No parameters should be passed to this API to trigger this action.&lt;li&gt;Do not call this API often. Our recommendation is to call this only at the time the user logs in to your app because it can hamper other API calls performance.&lt;li&gt;The response only contains information for accounts that were refreshed. If no accounts are eligible for refresh, no response is returned.&lt;/ul&gt;
        /// </summary>
        /// <param name="providerAccountIds">comma separated providerAccountIds</param>
        /// <param name="body">loginForm or field entity</param>
        /// <returns>UpdatedProviderAccountResponse</returns>
        public UpdatedProviderAccountResponse EditCredentialsOrRefreshProviderAccount (string providerAccountIds, ProviderAccountRequest body)
        {
            // verify the required parameter 'providerAccountIds' is set
            if (providerAccountIds == null) throw new ApiException(400, "Missing required parameter 'providerAccountIds' when calling EditCredentialsOrRefreshProviderAccount");
    
            var path = "/providerAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (providerAccountIds != null) queryParams.Add("providerAccountIds", ApiClient.ParameterToString(providerAccountIds)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditCredentialsOrRefreshProviderAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditCredentialsOrRefreshProviderAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UpdatedProviderAccountResponse) ApiClient.Deserialize(response.Content, typeof(UpdatedProviderAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Provider Accounts The get provider accounts service is used to return all the provider accounts added by the user. &lt;br&gt;This includes the failed and successfully added provider accounts.&lt;br&gt;
        /// </summary>
        /// <param name="include">include</param>
        /// <param name="providerIds">Comma separated providerIds.</param>
        /// <returns>ProviderAccountResponse</returns>
        public ProviderAccountResponse GetAllProviderAccounts (string include, string providerIds)
        {
    
            var path = "/providerAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (providerIds != null) queryParams.Add("providerIds", ApiClient.ParameterToString(providerIds)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllProviderAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllProviderAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProviderAccountResponse) ApiClient.Deserialize(response.Content, typeof(ProviderAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Provider Account Details The get provider account details service is used to learn the status of adding accounts and updating accounts.&lt;br&gt;This service has to be called continuously to know the progress level of the triggered process. This service also provides the MFA information requested by the provider site.&lt;br&gt;When &lt;i&gt;include &#x3D; credentials&lt;/i&gt;, questions is passed as input, the service returns the credentials (non-password values) and questions stored in the Yodlee system for that provider account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The password and answer fields are not returned in the response.&lt;/li&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <param name="include">include credentials,questions</param>
        /// <param name="requestId">The unique identifier for the request that returns contextual data</param>
        /// <returns>ProviderAccountDetailResponse</returns>
        public ProviderAccountDetailResponse GetProviderAccount (long? providerAccountId, string include, string requestId)
        {
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling GetProviderAccount");
    
            var path = "/providerAccounts/{providerAccountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "providerAccountId" + "}", ApiClient.ParameterToString(providerAccountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (requestId != null) queryParams.Add("requestId", ApiClient.ParameterToString(requestId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviderAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviderAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProviderAccountDetailResponse) ApiClient.Deserialize(response.Content, typeof(ProviderAccountDetailResponse), response.Headers);
        }
    
        /// <summary>
        /// Get User Profile Details &lt;b&gt;Refer GET /verification/holderProfile&lt;/b&gt;&lt;br&gt;The get provider accounts profile service is used to return the user profile details that are associated to the provider account. &lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">Comma separated providerAccountIds.</param>
        /// <returns>ProviderAccountUserProfileResponse</returns>
        public ProviderAccountUserProfileResponse GetProviderAccountProfiles (string providerAccountId)
        {
    
            var path = "/providerAccounts/profile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviderAccountProfiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviderAccountProfiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProviderAccountUserProfileResponse) ApiClient.Deserialize(response.Content, typeof(ProviderAccountUserProfileResponse), response.Headers);
        }
    
        /// <summary>
        /// Refresh Provider Account This api service will allow you to refresh the Non-MFA provider accounts against a configName, i.e refresh will respect the configurations of the configName while refreshing the account.&lt;br&gt;Note: this service will only work with FastLink 4 users.&lt;br&gt;
        /// </summary>
        /// <param name="body">refreshRequest</param>
        /// <returns>RefreshProviderAccountResponse</returns>
        public RefreshProviderAccountResponse RefreshProviderAccount (ProviderAccountRefreshRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RefreshProviderAccount");
    
            var path = "/providerAccounts/refresh";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshProviderAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshProviderAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RefreshProviderAccountResponse) ApiClient.Deserialize(response.Content, typeof(RefreshProviderAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Preferences This endpoint is used to update preferences like data extracts and auto refreshes without triggering refresh for the providerAccount.&lt;br&gt;Setting isDataExtractsEnabled to false will not trigger data extracts notification and dataExtracts/events will not reflect any data change that is happening for the providerAccount.&lt;br&gt;Modified data will not be provided in the dataExtracts/userData endpoint.&lt;br&gt;Setting isAutoRefreshEnabled to false will not trigger auto refreshes for the provider account.&lt;br&gt;
        /// </summary>
        /// <param name="body">preferences</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns></returns>
        public void UpdatePreferences (ProviderAccountPreferencesRequest body, long? providerAccountId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePreferences");
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling UpdatePreferences");
    
            var path = "/providerAccounts/{providerAccountId}/preferences";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "providerAccountId" + "}", ApiClient.ParameterToString(providerAccountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePreferences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePreferences: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
