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
    public interface IVerifyAccountApi
    {
        /// <summary>
        /// Verify Accounts Using Transactions The verify account service is used to verify the account&#x27;s ownership by  matching the transaction details with the accounts aggregated for the user.&lt;br&gt;&lt;ul&gt;&lt;li&gt;If a match is identified, the service returns details of all the accounts along with the matched transaction&#x27;s details.&lt;li&gt;If no transaction match is found, an empty response will be returned.&lt;li&gt;A maximum of 5 transactionCriteria can be passed in a request.&lt;li&gt;The baseType, date, and amount parameters should mandatorily be passed.&lt;li&gt;The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.&lt;li&gt;Pass the container or accountId parameters for better performance.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">verificationParam</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns>VerifyAccountResponse</returns>
        VerifyAccountResponse InitiateAccountVerification (VerifyAccountRequest body, string providerAccountId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VerifyAccountApi : IVerifyAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAccountApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VerifyAccountApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VerifyAccountApi(String basePath)
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
        /// Verify Accounts Using Transactions The verify account service is used to verify the account&#x27;s ownership by  matching the transaction details with the accounts aggregated for the user.&lt;br&gt;&lt;ul&gt;&lt;li&gt;If a match is identified, the service returns details of all the accounts along with the matched transaction&#x27;s details.&lt;li&gt;If no transaction match is found, an empty response will be returned.&lt;li&gt;A maximum of 5 transactionCriteria can be passed in a request.&lt;li&gt;The baseType, date, and amount parameters should mandatorily be passed.&lt;li&gt;The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.&lt;li&gt;Pass the container or accountId parameters for better performance.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">verificationParam</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns>VerifyAccountResponse</returns>
        public VerifyAccountResponse InitiateAccountVerification (VerifyAccountRequest body, string providerAccountId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InitiateAccountVerification");
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling InitiateAccountVerification");
    
            var path = "/verifyAccount/{providerAccountId}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateAccountVerification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateAccountVerification: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerifyAccountResponse) ApiClient.Deserialize(response.Content, typeof(VerifyAccountResponse), response.Headers);
        }
    
    }
}
