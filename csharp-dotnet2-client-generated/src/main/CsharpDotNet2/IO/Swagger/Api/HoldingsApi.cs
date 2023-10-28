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
    public interface IHoldingsApi
    {
        /// <summary>
        /// Get Asset Classification List The get asset classifications list service is used to get the supported asset classifications. &lt;br&gt;The response includes different classification types like assetClass, country, sector, style, etc. and the values corresponding to each type.&lt;br&gt;
        /// </summary>
        /// <returns>HoldingAssetClassificationListResponse</returns>
        HoldingAssetClassificationListResponse GetAssetClassificationList ();
        /// <summary>
        /// Get Holding Type List The get holding types list service is used to get the supported holding types.&lt;br&gt;The response includes different holding types such as future, moneyMarketFund, stock, etc. and it returns the supported holding types &lt;br&gt;
        /// </summary>
        /// <returns>HoldingTypeListResponse</returns>
        HoldingTypeListResponse GetHoldingTypeList ();
        /// <summary>
        /// Get Holdings The get holdings service is used to get the list of holdings of a user.&lt;br&gt;Supported holding types can be employeeStockOption, moneyMarketFund, bond, etc. and is obtained using get holding type list service. &lt;br&gt;Asset classifications for the holdings need to be requested through the \&quot;include\&quot; parameter.&lt;br&gt;Asset classification information for holdings are not available by default, as it is a premium feature.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountId</param>
        /// <param name="assetClassificationClassificationType">e.g. Country, Sector, etc.</param>
        /// <param name="classificationValue">e.g. US</param>
        /// <param name="include">assetClassification</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns>HoldingResponse</returns>
        HoldingResponse GetHoldings (string accountId, string assetClassificationClassificationType, string classificationValue, string include, string providerAccountId);
        /// <summary>
        /// Get Security Details The get security details service is used to get all the security information for the holdings&lt;br&gt;
        /// </summary>
        /// <param name="holdingId">Comma separated holdingId</param>
        /// <returns>HoldingSecuritiesResponse</returns>
        HoldingSecuritiesResponse GetSecurities (string holdingId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HoldingsApi : IHoldingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HoldingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HoldingsApi(String basePath)
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
        /// Get Asset Classification List The get asset classifications list service is used to get the supported asset classifications. &lt;br&gt;The response includes different classification types like assetClass, country, sector, style, etc. and the values corresponding to each type.&lt;br&gt;
        /// </summary>
        /// <returns>HoldingAssetClassificationListResponse</returns>
        public HoldingAssetClassificationListResponse GetAssetClassificationList ()
        {
    
            var path = "/holdings/assetClassificationList";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssetClassificationList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssetClassificationList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HoldingAssetClassificationListResponse) ApiClient.Deserialize(response.Content, typeof(HoldingAssetClassificationListResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Holding Type List The get holding types list service is used to get the supported holding types.&lt;br&gt;The response includes different holding types such as future, moneyMarketFund, stock, etc. and it returns the supported holding types &lt;br&gt;
        /// </summary>
        /// <returns>HoldingTypeListResponse</returns>
        public HoldingTypeListResponse GetHoldingTypeList ()
        {
    
            var path = "/holdings/holdingTypeList";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldingTypeList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldingTypeList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HoldingTypeListResponse) ApiClient.Deserialize(response.Content, typeof(HoldingTypeListResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Holdings The get holdings service is used to get the list of holdings of a user.&lt;br&gt;Supported holding types can be employeeStockOption, moneyMarketFund, bond, etc. and is obtained using get holding type list service. &lt;br&gt;Asset classifications for the holdings need to be requested through the \&quot;include\&quot; parameter.&lt;br&gt;Asset classification information for holdings are not available by default, as it is a premium feature.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountId</param>
        /// <param name="assetClassificationClassificationType">e.g. Country, Sector, etc.</param>
        /// <param name="classificationValue">e.g. US</param>
        /// <param name="include">assetClassification</param>
        /// <param name="providerAccountId">providerAccountId</param>
        /// <returns>HoldingResponse</returns>
        public HoldingResponse GetHoldings (string accountId, string assetClassificationClassificationType, string classificationValue, string include, string providerAccountId)
        {
    
            var path = "/holdings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (assetClassificationClassificationType != null) queryParams.Add("assetClassification.classificationType", ApiClient.ParameterToString(assetClassificationClassificationType)); // query parameter
 if (classificationValue != null) queryParams.Add("classificationValue", ApiClient.ParameterToString(classificationValue)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHoldings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HoldingResponse) ApiClient.Deserialize(response.Content, typeof(HoldingResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Security Details The get security details service is used to get all the security information for the holdings&lt;br&gt;
        /// </summary>
        /// <param name="holdingId">Comma separated holdingId</param>
        /// <returns>HoldingSecuritiesResponse</returns>
        public HoldingSecuritiesResponse GetSecurities (string holdingId)
        {
    
            var path = "/holdings/securities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (holdingId != null) queryParams.Add("holdingId", ApiClient.ParameterToString(holdingId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HoldingSecuritiesResponse) ApiClient.Deserialize(response.Content, typeof(HoldingSecuritiesResponse), response.Headers);
        }
    
    }
}
