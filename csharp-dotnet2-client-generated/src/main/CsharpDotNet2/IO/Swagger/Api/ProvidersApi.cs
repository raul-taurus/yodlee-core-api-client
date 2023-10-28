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
    public interface IProvidersApi
    {
        /// <summary>
        /// Get Providers &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region.&lt;br&gt;&lt;br&gt;Searching for a provider using a routing number is applicable only to the USA and Canada regions.&lt;br&gt; The valid values for priority are: &lt;br&gt;&lt;ol&gt;&lt;li&gt; cobrand: Returns providers enabled for the cobrand (Default priority)&lt;/li&gt;&lt;li&gt;popular: Returns providers popular among users of the customer.&lt;/li&gt;&lt;/ol&gt;&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;&lt;br&gt; Providers accept the configName as the input to the API and return the providers list based on the configurations of each configName.  For verification, the providers will accept the configName with which has the verification product and the attributes that are chosen in the configName which returns the list of providers that match the criteria.  ***For an example,  /ysl/providers?configName&#x3D;aggregationAndVerification*** &lt;br&gt;&lt;br&gt;Note:&lt;/b&gt; &lt;ol&gt;&lt;li&gt;In a product flow involving user interaction, Yodlee recommends invoking this service with filters.&lt;li&gt;Without filters, the service may perform slowly as it takes a few minutes to return data in the response.&lt;li&gt;The AuthParameter appears in the response only in case of token-based aggregation sites.&lt;li&gt;The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in query parameter and response. &lt;/li&gt;&lt;/ol&gt;
        /// </summary>
        /// <param name="capability">CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated</param>
        /// <param name="institutionId">Institution Id for Single site selection</param>
        /// <param name="name">Name in minimum 1 character or routing number.</param>
        /// <param name="priority">Search priority</param>
        /// <param name="providerId">Max 5 Comma seperated Provider Ids</param>
        /// <param name="skip">skip (Min 0) - This is not applicable along with &#x27;name&#x27; parameter.</param>
        /// <param name="top">top (Max 500) - This is not applicable along with &#x27;name&#x27; parameter.</param>
        /// <returns>ProviderResponse</returns>
        ProviderResponse GetAllProviders (string capability, long? institutionId, string name, string priority, string providerId, int? skip, int? top);
        /// <summary>
        /// Get Provider Details The get provider detail service is used to get detailed information including the login form for a provider.&lt;br&gt;The response is a provider object that includes information such as name of the provider, &lt;br&gt;provider&#x27;s base URL, a list of containers supported by the provider, the login form details of the provider, etc.&lt;br&gt;Only enabled datasets, attributes and containers gets returned in the response.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in the response.
        /// </summary>
        /// <param name="providerId">providerId</param>
        /// <returns>ProviderDetailResponse</returns>
        ProviderDetailResponse GetProvider (long? providerId);
        /// <summary>
        /// Get Providers Count &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /providers endpoint&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The capability has been deprecated in the query parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="capability">CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated</param>
        /// <param name="name">Name in minimum 1 character or routing number.</param>
        /// <param name="priority">Search priority</param>
        /// <returns>ProvidersCountResponse</returns>
        ProvidersCountResponse GetProvidersCount (string capability, string name, string priority);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProvidersApi : IProvidersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProvidersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProvidersApi(String basePath)
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
        /// Get Providers &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region.&lt;br&gt;&lt;br&gt;Searching for a provider using a routing number is applicable only to the USA and Canada regions.&lt;br&gt; The valid values for priority are: &lt;br&gt;&lt;ol&gt;&lt;li&gt; cobrand: Returns providers enabled for the cobrand (Default priority)&lt;/li&gt;&lt;li&gt;popular: Returns providers popular among users of the customer.&lt;/li&gt;&lt;/ol&gt;&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;&lt;br&gt; Providers accept the configName as the input to the API and return the providers list based on the configurations of each configName.  For verification, the providers will accept the configName with which has the verification product and the attributes that are chosen in the configName which returns the list of providers that match the criteria.  ***For an example,  /ysl/providers?configName&#x3D;aggregationAndVerification*** &lt;br&gt;&lt;br&gt;Note:&lt;/b&gt; &lt;ol&gt;&lt;li&gt;In a product flow involving user interaction, Yodlee recommends invoking this service with filters.&lt;li&gt;Without filters, the service may perform slowly as it takes a few minutes to return data in the response.&lt;li&gt;The AuthParameter appears in the response only in case of token-based aggregation sites.&lt;li&gt;The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in query parameter and response. &lt;/li&gt;&lt;/ol&gt;
        /// </summary>
        /// <param name="capability">CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated</param>
        /// <param name="institutionId">Institution Id for Single site selection</param>
        /// <param name="name">Name in minimum 1 character or routing number.</param>
        /// <param name="priority">Search priority</param>
        /// <param name="providerId">Max 5 Comma seperated Provider Ids</param>
        /// <param name="skip">skip (Min 0) - This is not applicable along with &#x27;name&#x27; parameter.</param>
        /// <param name="top">top (Max 500) - This is not applicable along with &#x27;name&#x27; parameter.</param>
        /// <returns>ProviderResponse</returns>
        public ProviderResponse GetAllProviders (string capability, long? institutionId, string name, string priority, string providerId, int? skip, int? top)
        {
    
            var path = "/providers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (capability != null) queryParams.Add("capability", ApiClient.ParameterToString(capability)); // query parameter
 if (institutionId != null) queryParams.Add("institutionId", ApiClient.ParameterToString(institutionId)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (priority != null) queryParams.Add("priority", ApiClient.ParameterToString(priority)); // query parameter
 if (providerId != null) queryParams.Add("providerId", ApiClient.ParameterToString(providerId)); // query parameter
 if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
 if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProviderResponse) ApiClient.Deserialize(response.Content, typeof(ProviderResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Provider Details The get provider detail service is used to get detailed information including the login form for a provider.&lt;br&gt;The response is a provider object that includes information such as name of the provider, &lt;br&gt;provider&#x27;s base URL, a list of containers supported by the provider, the login form details of the provider, etc.&lt;br&gt;Only enabled datasets, attributes and containers gets returned in the response.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in the response.
        /// </summary>
        /// <param name="providerId">providerId</param>
        /// <returns>ProviderDetailResponse</returns>
        public ProviderDetailResponse GetProvider (long? providerId)
        {
            // verify the required parameter 'providerId' is set
            if (providerId == null) throw new ApiException(400, "Missing required parameter 'providerId' when calling GetProvider");
    
            var path = "/providers/{providerId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "providerId" + "}", ApiClient.ParameterToString(providerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetProvider: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProvider: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProviderDetailResponse) ApiClient.Deserialize(response.Content, typeof(ProviderDetailResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Providers Count &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /providers endpoint&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The capability has been deprecated in the query parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="capability">CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated</param>
        /// <param name="name">Name in minimum 1 character or routing number.</param>
        /// <param name="priority">Search priority</param>
        /// <returns>ProvidersCountResponse</returns>
        public ProvidersCountResponse GetProvidersCount (string capability, string name, string priority)
        {
    
            var path = "/providers/count";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (capability != null) queryParams.Add("capability", ApiClient.ParameterToString(capability)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (priority != null) queryParams.Add("priority", ApiClient.ParameterToString(priority)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProvidersCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProvidersCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProvidersCountResponse) ApiClient.Deserialize(response.Content, typeof(ProvidersCountResponse), response.Headers);
        }
    
    }
}
