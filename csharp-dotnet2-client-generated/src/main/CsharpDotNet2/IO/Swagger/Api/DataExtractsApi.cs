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
    public interface IDataExtractsApi
    {
        /// <summary>
        /// Get Events The get extracts events service is used to learn about occurrences of data extract related events. This service currently supports only the DATA_UPDATES event.&lt;br&gt;Passing the event name as DATA_UPDATES provides information about users for whom data has been modified in the system for the specified time range. For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;You can retrieve data in increments of no more than 60 minutes over the period of the last 7 days from today&#x27;s date.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">Event Name</param>
        /// <param name="fromDate">From DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <param name="toDate">To DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <returns>DataExtractsEventResponse</returns>
        DataExtractsEventResponse GetDataExtractsEvents (string eventName, string fromDate, string toDate);
        /// <summary>
        /// Get userData The get user data service is used to get a user&#x27;s modified data for a particular period of time for accounts, transactions, holdings, and provider account information.&lt;br&gt;The time difference between fromDate and toDate fields cannot be more than 60 minutes.&lt;br&gt;By default, pagination is available for the transaction entity in this API. In the first response, the API will retrieve 500 transactions along with other data. The response header will provide a link to retrieve the next set of transactions.&lt;br&gt;In the response body of the first API response, totalTransactionsCount indicates the total number of transactions the API will retrieve for the user.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br/&gt;For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="fromDate">From DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <param name="loginName">Login Name</param>
        /// <param name="toDate">To DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <returns>DataExtractsUserDataResponse</returns>
        DataExtractsUserDataResponse GetDataExtractsUserData (string fromDate, string loginName, string toDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataExtractsApi : IDataExtractsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtractsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DataExtractsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtractsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataExtractsApi(String basePath)
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
        /// Get Events The get extracts events service is used to learn about occurrences of data extract related events. This service currently supports only the DATA_UPDATES event.&lt;br&gt;Passing the event name as DATA_UPDATES provides information about users for whom data has been modified in the system for the specified time range. For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;You can retrieve data in increments of no more than 60 minutes over the period of the last 7 days from today&#x27;s date.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br&gt;
        /// </summary>
        /// <param name="eventName">Event Name</param>
        /// <param name="fromDate">From DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <param name="toDate">To DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <returns>DataExtractsEventResponse</returns>
        public DataExtractsEventResponse GetDataExtractsEvents (string eventName, string fromDate, string toDate)
        {
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling GetDataExtractsEvents");
            // verify the required parameter 'fromDate' is set
            if (fromDate == null) throw new ApiException(400, "Missing required parameter 'fromDate' when calling GetDataExtractsEvents");
            // verify the required parameter 'toDate' is set
            if (toDate == null) throw new ApiException(400, "Missing required parameter 'toDate' when calling GetDataExtractsEvents");
    
            var path = "/dataExtracts/events";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventName != null) queryParams.Add("eventName", ApiClient.ParameterToString(eventName)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataExtractsEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataExtractsEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataExtractsEventResponse) ApiClient.Deserialize(response.Content, typeof(DataExtractsEventResponse), response.Headers);
        }
    
        /// <summary>
        /// Get userData The get user data service is used to get a user&#x27;s modified data for a particular period of time for accounts, transactions, holdings, and provider account information.&lt;br&gt;The time difference between fromDate and toDate fields cannot be more than 60 minutes.&lt;br&gt;By default, pagination is available for the transaction entity in this API. In the first response, the API will retrieve 500 transactions along with other data. The response header will provide a link to retrieve the next set of transactions.&lt;br&gt;In the response body of the first API response, totalTransactionsCount indicates the total number of transactions the API will retrieve for the user.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br/&gt;For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
        /// </summary>
        /// <param name="fromDate">From DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <param name="loginName">Login Name</param>
        /// <param name="toDate">To DateTime (YYYY-MM-DDThh:mm:ssZ)</param>
        /// <returns>DataExtractsUserDataResponse</returns>
        public DataExtractsUserDataResponse GetDataExtractsUserData (string fromDate, string loginName, string toDate)
        {
            // verify the required parameter 'fromDate' is set
            if (fromDate == null) throw new ApiException(400, "Missing required parameter 'fromDate' when calling GetDataExtractsUserData");
            // verify the required parameter 'loginName' is set
            if (loginName == null) throw new ApiException(400, "Missing required parameter 'loginName' when calling GetDataExtractsUserData");
            // verify the required parameter 'toDate' is set
            if (toDate == null) throw new ApiException(400, "Missing required parameter 'toDate' when calling GetDataExtractsUserData");
    
            var path = "/dataExtracts/userData";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (loginName != null) queryParams.Add("loginName", ApiClient.ParameterToString(loginName)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataExtractsUserData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataExtractsUserData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataExtractsUserDataResponse) ApiClient.Deserialize(response.Content, typeof(DataExtractsUserDataResponse), response.Headers);
        }
    
    }
}
