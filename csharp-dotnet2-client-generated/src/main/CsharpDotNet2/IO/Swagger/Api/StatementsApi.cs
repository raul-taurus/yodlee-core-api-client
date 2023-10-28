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
    public interface IStatementsApi
    {
        /// <summary>
        /// Get Statements The statements service is used to get the list of statement related information. &lt;br&gt;By default, all the latest statements of active and to be closed accounts are retrieved for the user. &lt;br&gt;Certain sites do not have both a statement date and a due date. When a fromDate is passed as an input, all the statements that have the due date on or after the passed date are retrieved. &lt;br&gt;For sites that do not have the due date, statements that have the statement date on or after the passed date are retrieved. &lt;br&gt;The default value of \&quot;isLatest\&quot; is true. To retrieve historical statements isLatest needs to be set to false.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="container">creditCard/loan/insurance</param>
        /// <param name="fromDate">from date for statement retrieval (YYYY-MM-DD)</param>
        /// <param name="isLatest">isLatest (true/false)</param>
        /// <param name="status">ACTIVE,TO_BE_CLOSED,CLOSED</param>
        /// <returns>StatementResponse</returns>
        StatementResponse GetStatements (string accountId, string container, string fromDate, string isLatest, string status);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatementsApi : IStatementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StatementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatementsApi(String basePath)
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
        /// Get Statements The statements service is used to get the list of statement related information. &lt;br&gt;By default, all the latest statements of active and to be closed accounts are retrieved for the user. &lt;br&gt;Certain sites do not have both a statement date and a due date. When a fromDate is passed as an input, all the statements that have the due date on or after the passed date are retrieved. &lt;br&gt;For sites that do not have the due date, statements that have the statement date on or after the passed date are retrieved. &lt;br&gt;The default value of \&quot;isLatest\&quot; is true. To retrieve historical statements isLatest needs to be set to false.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="container">creditCard/loan/insurance</param>
        /// <param name="fromDate">from date for statement retrieval (YYYY-MM-DD)</param>
        /// <param name="isLatest">isLatest (true/false)</param>
        /// <param name="status">ACTIVE,TO_BE_CLOSED,CLOSED</param>
        /// <returns>StatementResponse</returns>
        public StatementResponse GetStatements (string accountId, string container, string fromDate, string isLatest, string status)
        {
    
            var path = "/statements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (container != null) queryParams.Add("container", ApiClient.ParameterToString(container)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (isLatest != null) queryParams.Add("isLatest", ApiClient.ParameterToString(isLatest)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StatementResponse) ApiClient.Deserialize(response.Content, typeof(StatementResponse), response.Headers);
        }
    
    }
}
