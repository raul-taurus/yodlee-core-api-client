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
    public interface IDerivedApi
    {
        /// <summary>
        /// Get Holding Summary The get holding summary service is used to get the summary of asset classifications for the user.&lt;br&gt;By default, accounts with status as ACTIVE and TO BE CLOSED will be considered.&lt;br&gt;If the include parameter value is passed as details then a summary with holdings and account information is returned.&lt;br&gt;
        /// </summary>
        /// <param name="accountIds">Comma separated accountIds</param>
        /// <param name="classificationType">e.g. Country, Sector, etc.</param>
        /// <param name="include">details</param>
        /// <returns>DerivedHoldingSummaryResponse</returns>
        DerivedHoldingSummaryResponse GetHoldingSummary (string accountIds, string classificationType, string include);
        /// <summary>
        /// Get Networth Summary The get networth service is used to get the networth for the user.&lt;br&gt;If the include parameter value is passed as details then networth with historical balances is returned. &lt;br&gt;
        /// </summary>
        /// <param name="accountIds">comma separated accountIds</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities</param>
        /// <param name="fromDate">from date for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="include">details</param>
        /// <param name="interval">D-daily, W-weekly or M-monthly</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">toDate for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <returns>DerivedNetworthResponse</returns>
        DerivedNetworthResponse GetNetworth (string accountIds, string container, string fromDate, string include, string interval, int? skip, string toDate, int? top);
        /// <summary>
        /// Get Transaction Summary The transaction summary service provides the summary values of transactions for the given date range by category type, high-level categories, or system-defined categories.&lt;br&gt;&lt;br&gt;Yodlee has the transaction data stored for a day, month, year and week per category as per the availability of user&#x27;s data. If the include parameter value is passed as details, then summary details will be returned depending on the interval passed-monthly is the default.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ol&gt; &lt;li&gt; Details can be requested for only one system-defined category&lt;li&gt;Passing categoryType is mandatory except when the groupBy value is CATEGORY_TYPE&lt;li&gt;Dates will not be respected for monthly, yearly, and weekly details&lt;li&gt;When monthly details are requested, only the fromDate and toDate month will be respected&lt;li&gt;When yearly details are requested, only the fromDate and toDate year will be respected&lt;li&gt;For weekly data points, details will be provided for every Sunday date available within the fromDate and toDate&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter&lt;/li&gt;&lt;/ol&gt;
        /// </summary>
        /// <param name="groupBy">CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY</param>
        /// <param name="accountId">comma separated account Ids</param>
        /// <param name="categoryId">comma separated categoryIds</param>
        /// <param name="categoryType">INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION</param>
        /// <param name="fromDate">YYYY-MM-DD format</param>
        /// <param name="include">details</param>
        /// <param name="includeUserCategory">TRUE/FALSE</param>
        /// <param name="interval">D-daily, W-weekly, M-mothly or Y-yearly</param>
        /// <param name="toDate">YYYY-MM-DD format</param>
        /// <returns>DerivedTransactionSummaryResponse</returns>
        DerivedTransactionSummaryResponse GetTransactionSummary (string groupBy, string accountId, string categoryId, string categoryType, string fromDate, string include, bool? includeUserCategory, string interval, string toDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DerivedApi : IDerivedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DerivedApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DerivedApi(String basePath)
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
        /// Get Holding Summary The get holding summary service is used to get the summary of asset classifications for the user.&lt;br&gt;By default, accounts with status as ACTIVE and TO BE CLOSED will be considered.&lt;br&gt;If the include parameter value is passed as details then a summary with holdings and account information is returned.&lt;br&gt;
        /// </summary>
        /// <param name="accountIds">Comma separated accountIds</param>
        /// <param name="classificationType">e.g. Country, Sector, etc.</param>
        /// <param name="include">details</param>
        /// <returns>DerivedHoldingSummaryResponse</returns>
        public DerivedHoldingSummaryResponse GetHoldingSummary (string accountIds, string classificationType, string include)
        {
    
            var path = "/derived/holdingSummary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (classificationType != null) queryParams.Add("classificationType", ApiClient.ParameterToString(classificationType)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldingSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldingSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DerivedHoldingSummaryResponse) ApiClient.Deserialize(response.Content, typeof(DerivedHoldingSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Networth Summary The get networth service is used to get the networth for the user.&lt;br&gt;If the include parameter value is passed as details then networth with historical balances is returned. &lt;br&gt;
        /// </summary>
        /// <param name="accountIds">comma separated accountIds</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities</param>
        /// <param name="fromDate">from date for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="include">details</param>
        /// <param name="interval">D-daily, W-weekly or M-monthly</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">toDate for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <returns>DerivedNetworthResponse</returns>
        public DerivedNetworthResponse GetNetworth (string accountIds, string container, string fromDate, string include, string interval, int? skip, string toDate, int? top)
        {
    
            var path = "/derived/networth";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (container != null) queryParams.Add("container", ApiClient.ParameterToString(container)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (interval != null) queryParams.Add("interval", ApiClient.ParameterToString(interval)); // query parameter
 if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
 if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNetworth: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNetworth: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DerivedNetworthResponse) ApiClient.Deserialize(response.Content, typeof(DerivedNetworthResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Transaction Summary The transaction summary service provides the summary values of transactions for the given date range by category type, high-level categories, or system-defined categories.&lt;br&gt;&lt;br&gt;Yodlee has the transaction data stored for a day, month, year and week per category as per the availability of user&#x27;s data. If the include parameter value is passed as details, then summary details will be returned depending on the interval passed-monthly is the default.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ol&gt; &lt;li&gt; Details can be requested for only one system-defined category&lt;li&gt;Passing categoryType is mandatory except when the groupBy value is CATEGORY_TYPE&lt;li&gt;Dates will not be respected for monthly, yearly, and weekly details&lt;li&gt;When monthly details are requested, only the fromDate and toDate month will be respected&lt;li&gt;When yearly details are requested, only the fromDate and toDate year will be respected&lt;li&gt;For weekly data points, details will be provided for every Sunday date available within the fromDate and toDate&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter&lt;/li&gt;&lt;/ol&gt;
        /// </summary>
        /// <param name="groupBy">CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY</param>
        /// <param name="accountId">comma separated account Ids</param>
        /// <param name="categoryId">comma separated categoryIds</param>
        /// <param name="categoryType">INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION</param>
        /// <param name="fromDate">YYYY-MM-DD format</param>
        /// <param name="include">details</param>
        /// <param name="includeUserCategory">TRUE/FALSE</param>
        /// <param name="interval">D-daily, W-weekly, M-mothly or Y-yearly</param>
        /// <param name="toDate">YYYY-MM-DD format</param>
        /// <returns>DerivedTransactionSummaryResponse</returns>
        public DerivedTransactionSummaryResponse GetTransactionSummary (string groupBy, string accountId, string categoryId, string categoryType, string fromDate, string include, bool? includeUserCategory, string interval, string toDate)
        {
            // verify the required parameter 'groupBy' is set
            if (groupBy == null) throw new ApiException(400, "Missing required parameter 'groupBy' when calling GetTransactionSummary");
    
            var path = "/derived/transactionSummary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (categoryId != null) queryParams.Add("categoryId", ApiClient.ParameterToString(categoryId)); // query parameter
 if (categoryType != null) queryParams.Add("categoryType", ApiClient.ParameterToString(categoryType)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (includeUserCategory != null) queryParams.Add("includeUserCategory", ApiClient.ParameterToString(includeUserCategory)); // query parameter
 if (interval != null) queryParams.Add("interval", ApiClient.ParameterToString(interval)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DerivedTransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(DerivedTransactionSummaryResponse), response.Headers);
        }
    
    }
}
