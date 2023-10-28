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
    public interface IAccountsApi
    {
        /// <summary>
        /// Add Manual Account The add account service is used to add manual accounts.&lt;br&gt;The response of add account service includes the account name , account number and Yodlee generated account id.&lt;br&gt;All manual accounts added will be included as part of networth calculation by default.&lt;br&gt;Add manual account support is available for bank, card, investment, insurance and loan container only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;ul&gt; &lt;li&gt;A real estate account addition is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">accountParam</param>
        /// <returns>CreatedAccountResponse</returns>
        CreatedAccountResponse CreateManualAccount (CreateAccountRequest body);
        /// <summary>
        /// Delete Account The delete account service allows an account to be deleted.&lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <returns></returns>
        void DeleteAccount (long? accountId);
        /// <summary>
        /// Evaluate Address Use this service to validate the address before adding the real estate account.&lt;br&gt;If the address is valid, the service will return the complete address information.&lt;br&gt;The response will contain multiple addresses if the user-provided input matches with multiple entries in the vendor database.&lt;br&gt;In the case of multiple matches, the user can select the appropriate address from the list and then invoke the add account service with the complete address.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;ul&gt;&lt;li&gt;Yodlee recommends to use this service before adding the real estate account to avoid failures.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">addressParam</param>
        /// <returns>EvaluateAddressResponse</returns>
        EvaluateAddressResponse EvaluateAddress (EvaluateAddressRequest body);
        /// <summary>
        /// Get Account Details The get account details service provides detailed information of an account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="include">profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</param>
        /// <returns>AccountResponse</returns>
        AccountResponse GetAccount (long? accountId, string include);
        /// <summary>
        /// Get Accounts &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get accounts service provides information about accounts added by the user.&lt;br&gt;By default, this service returns information for active and to be closed accounts.&lt;br&gt;If requestId is provided, the accounts that are updated in the context of the requestId will be provided in the response.&lt;br&gt;&lt;br&gt; This API returns all the accounts that were chosen by the user in both the verification selection screen and the aggregation selection screen. In FastLink 4, we have separate APIs to provide the data for verification product-related data (/verification/verifiedAccounts) and the GET accounts should be utilized with an additional query param (isSelectedForAggregation&#x3D;true) to retrieve only the aggregation accounts.
        /// </summary>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities</param>
        /// <param name="include">profile, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;&lt;br&gt;&lt;li&gt;profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.&lt;/li&gt;</param>
        /// <param name="providerAccountId">Comma separated providerAccountIds.</param>
        /// <param name="requestId">The unique identifier that returns contextual data</param>
        /// <param name="status">ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED</param>
        /// <returns>AccountResponse</returns>
        AccountResponse GetAllAccounts (string accountId, string container, string include, string providerAccountId, string requestId, string status);
        /// <summary>
        /// Get Historical Balances The historical balances service is used to retrieve the historical balances for an account or a user.&lt;br&gt;Historical balances are daily (D), weekly (W), and monthly (M). &lt;br&gt;The interval input should be passed as D, W, and M to retrieve the desired historical balances. The default interval is daily (D). &lt;br&gt;When no account id is provided, historical balances of the accounts that are active, to be closed, and closed are provided in the response. &lt;br&gt;If the fromDate and toDate are not passed, the last 90 days of data will be provided. &lt;br&gt;The fromDate and toDate should be passed in the YYYY-MM-DD format. &lt;br&gt;The date field in the response denotes the date for which the balance is requested.&lt;br&gt;includeCF needs to be sent as true if the customer wants to return carried forward balances for a date when the data is not available. &lt;br&gt;asofDate field in the response denotes the date as of which the balance was updated for that account.&lt;br&gt;When there is no balance available for a requested date and if includeCF is sent as true, the previous date for which the balance is available is provided in the response. &lt;br&gt;When there is no previous balance available, no data will be sent. &lt;br&gt;By default, pagination is available for the historicalBalances entity in this API. The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of historical balances.&lt;br&gt; The API will only retrieve a maximum 500 records by default when values for skip and top parameters are not provided.
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="fromDate">from date for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="includeCF">Consider carry forward logic for missing balances</param>
        /// <param name="interval">D-daily, W-weekly or M-monthly</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">toDate for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <returns>AccountHistoricalBalancesResponse</returns>
        AccountHistoricalBalancesResponse GetHistoricalBalances (string accountId, string fromDate, bool? includeCF, string interval, int? skip, string toDate, int? top);
        /// <summary>
        /// Get Latest Balances The latest balances service provides the latest account balance by initiating a new balance refresh request
        /// </summary>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <returns>AccountBalanceResponse</returns>
        AccountBalanceResponse GetLatestBalances (string accountId, string providerAccountId);
        /// <summary>
        /// Update Account The update account service is used to update manual and aggregated accounts.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;Update manual account support is available for bank, card, investment, insurance, loan, otherAssets, otherLiabilities and realEstate containers only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; A real estate account update is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt; &lt;li&gt; A real estate account can be linked to a loan account by passing accountId of a loan account in linkedAccountIds .&lt;/li&gt; &lt;li&gt; Attribute &lt;b&gt;isEbillEnrolled&lt;/b&gt; is deprecated as it is applicable for bill accounts only.&lt;/li&gt;
        /// </summary>
        /// <param name="body">accountRequest</param>
        /// <param name="accountId">accountId</param>
        /// <returns></returns>
        void UpdateAccount (UpdateAccountRequest body, long? accountId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
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
        /// Add Manual Account The add account service is used to add manual accounts.&lt;br&gt;The response of add account service includes the account name , account number and Yodlee generated account id.&lt;br&gt;All manual accounts added will be included as part of networth calculation by default.&lt;br&gt;Add manual account support is available for bank, card, investment, insurance and loan container only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;ul&gt; &lt;li&gt;A real estate account addition is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">accountParam</param>
        /// <returns>CreatedAccountResponse</returns>
        public CreatedAccountResponse CreateManualAccount (CreateAccountRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateManualAccount");
    
            var path = "/accounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateManualAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateManualAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CreatedAccountResponse) ApiClient.Deserialize(response.Content, typeof(CreatedAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete Account The delete account service allows an account to be deleted.&lt;br&gt;This service does not return a response. The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <returns></returns>
        public void DeleteAccount (long? accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteAccount");
    
            var path = "/accounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Evaluate Address Use this service to validate the address before adding the real estate account.&lt;br&gt;If the address is valid, the service will return the complete address information.&lt;br&gt;The response will contain multiple addresses if the user-provided input matches with multiple entries in the vendor database.&lt;br&gt;In the case of multiple matches, the user can select the appropriate address from the list and then invoke the add account service with the complete address.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;ul&gt;&lt;li&gt;Yodlee recommends to use this service before adding the real estate account to avoid failures.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">addressParam</param>
        /// <returns>EvaluateAddressResponse</returns>
        public EvaluateAddressResponse EvaluateAddress (EvaluateAddressRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EvaluateAddress");
    
            var path = "/accounts/evaluateAddress";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EvaluateAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EvaluateAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EvaluateAddressResponse) ApiClient.Deserialize(response.Content, typeof(EvaluateAddressResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Account Details The get account details service provides detailed information of an account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="include">profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</param>
        /// <returns>AccountResponse</returns>
        public AccountResponse GetAccount (long? accountId, string include)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccount");
    
            var path = "/accounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountResponse) ApiClient.Deserialize(response.Content, typeof(AccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Accounts &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get accounts service provides information about accounts added by the user.&lt;br&gt;By default, this service returns information for active and to be closed accounts.&lt;br&gt;If requestId is provided, the accounts that are updated in the context of the requestId will be provided in the response.&lt;br&gt;&lt;br&gt; This API returns all the accounts that were chosen by the user in both the verification selection screen and the aggregation selection screen. In FastLink 4, we have separate APIs to provide the data for verification product-related data (/verification/verifiedAccounts) and the GET accounts should be utilized with an additional query param (isSelectedForAggregation&#x3D;true) to retrieve only the aggregation accounts.
        /// </summary>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities</param>
        /// <param name="include">profile, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;&lt;br&gt;&lt;li&gt;profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.&lt;/li&gt;</param>
        /// <param name="providerAccountId">Comma separated providerAccountIds.</param>
        /// <param name="requestId">The unique identifier that returns contextual data</param>
        /// <param name="status">ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED</param>
        /// <returns>AccountResponse</returns>
        public AccountResponse GetAllAccounts (string accountId, string container, string include, string providerAccountId, string requestId, string status)
        {
    
            var path = "/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (container != null) queryParams.Add("container", ApiClient.ParameterToString(container)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
 if (requestId != null) queryParams.Add("requestId", ApiClient.ParameterToString(requestId)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountResponse) ApiClient.Deserialize(response.Content, typeof(AccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Historical Balances The historical balances service is used to retrieve the historical balances for an account or a user.&lt;br&gt;Historical balances are daily (D), weekly (W), and monthly (M). &lt;br&gt;The interval input should be passed as D, W, and M to retrieve the desired historical balances. The default interval is daily (D). &lt;br&gt;When no account id is provided, historical balances of the accounts that are active, to be closed, and closed are provided in the response. &lt;br&gt;If the fromDate and toDate are not passed, the last 90 days of data will be provided. &lt;br&gt;The fromDate and toDate should be passed in the YYYY-MM-DD format. &lt;br&gt;The date field in the response denotes the date for which the balance is requested.&lt;br&gt;includeCF needs to be sent as true if the customer wants to return carried forward balances for a date when the data is not available. &lt;br&gt;asofDate field in the response denotes the date as of which the balance was updated for that account.&lt;br&gt;When there is no balance available for a requested date and if includeCF is sent as true, the previous date for which the balance is available is provided in the response. &lt;br&gt;When there is no previous balance available, no data will be sent. &lt;br&gt;By default, pagination is available for the historicalBalances entity in this API. The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of historical balances.&lt;br&gt; The API will only retrieve a maximum 500 records by default when values for skip and top parameters are not provided.
        /// </summary>
        /// <param name="accountId">accountId</param>
        /// <param name="fromDate">from date for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="includeCF">Consider carry forward logic for missing balances</param>
        /// <param name="interval">D-daily, W-weekly or M-monthly</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">toDate for balance retrieval (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <returns>AccountHistoricalBalancesResponse</returns>
        public AccountHistoricalBalancesResponse GetHistoricalBalances (string accountId, string fromDate, bool? includeCF, string interval, int? skip, string toDate, int? top)
        {
    
            var path = "/accounts/historicalBalances";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (includeCF != null) queryParams.Add("includeCF", ApiClient.ParameterToString(includeCF)); // query parameter
 if (interval != null) queryParams.Add("interval", ApiClient.ParameterToString(interval)); // query parameter
 if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
 if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHistoricalBalances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHistoricalBalances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountHistoricalBalancesResponse) ApiClient.Deserialize(response.Content, typeof(AccountHistoricalBalancesResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Latest Balances The latest balances service provides the latest account balance by initiating a new balance refresh request
        /// </summary>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <returns>AccountBalanceResponse</returns>
        public AccountBalanceResponse GetLatestBalances (string accountId, string providerAccountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetLatestBalances");
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling GetLatestBalances");
    
            var path = "/accounts/latestBalances";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLatestBalances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLatestBalances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountBalanceResponse) ApiClient.Deserialize(response.Content, typeof(AccountBalanceResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Account The update account service is used to update manual and aggregated accounts.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;Update manual account support is available for bank, card, investment, insurance, loan, otherAssets, otherLiabilities and realEstate containers only.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt; A real estate account update is only supported for SYSTEM and MANUAL valuation type.&lt;/li&gt; &lt;li&gt; A real estate account can be linked to a loan account by passing accountId of a loan account in linkedAccountIds .&lt;/li&gt; &lt;li&gt; Attribute &lt;b&gt;isEbillEnrolled&lt;/b&gt; is deprecated as it is applicable for bill accounts only.&lt;/li&gt;
        /// </summary>
        /// <param name="body">accountRequest</param>
        /// <param name="accountId">accountId</param>
        /// <returns></returns>
        public void UpdateAccount (UpdateAccountRequest body, long? accountId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAccount");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateAccount");
    
            var path = "/accounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
