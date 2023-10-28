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
    public interface ITransactionsApi
    {
        /// <summary>
        /// Create or Run Transaction Categorization Rule The Create or Run Transaction Categorization Rule endpoint is used to: &lt;br&gt;Create transaction categorization rules for both system and user-defined categories.&lt;br&gt;Run all the transaction categorization rules to categorize transactions by calling the endpoint with action&#x3D;run as the query parameter. &lt;br&gt;&lt;br&gt;The input body parameters to create transaction categorization rules follow:&lt;br&gt;     categoryId - This field is mandatory and numeric&lt;br&gt;     priority - This field is optional and numeric. Priority decides the order in which the rule gets applied on transactions.&lt;br&gt;     ruleClause - This field is mandatory and should contain at least one rule&lt;br&gt;     field - The value can be description or amount&lt;br&gt;&lt;br&gt;       If the field value is description then,&lt;br&gt;         1. operation - value can be stringEquals or stringContains&lt;br&gt;         2. value - value should be min of 3 and max of 50 characters&lt;br&gt;&lt;br&gt;       If the field value is amount then, &lt;br&gt;         1. operation - value can be numberEquals, numberLessThan, numberLessThanEquals, numberGreaterThan or numberGreaterThanEquals&lt;br&gt;         2. value - min value 0 and a max value of 99999999999.99 is allowed&lt;br&gt;The HTTP response code is 201 (Created Successfully).
        /// </summary>
        /// <param name="action">To run rules, pass action&#x3D;run. Only value run is supported</param>
        /// <param name="ruleParam">rules(JSON format) to categorize the transactions</param>
        /// <returns></returns>
        void CreateOrRunTransactionCategorizationRules (string action, string ruleParam);
        /// <summary>
        /// Create Category The create transaction categories service is used to create user-defined categories for a system-defined category.&lt;br&gt;The parentCategoryId is the system-defined category id.This can be retrieved using get transaction categories service.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 201 (Created successfully).&lt;br&gt;
        /// </summary>
        /// <param name="body">User Transaction Category in JSON format</param>
        /// <returns></returns>
        void CreateTransactionCategory (TransactionCategoryRequest body);
        /// <summary>
        /// Delete Transaction Categorization Rule The delete transaction categorization rule service is used to delete the given user-defined transaction categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;This will delete all the corresponding rule clauses associated with the rule.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="ruleId">ruleId</param>
        /// <returns></returns>
        void DeleteTransactionCategorizationRule (long? ruleId);
        /// <summary>
        /// Delete Category The delete transaction categories service is used to delete the given user-defined category.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="categoryId">categoryId</param>
        /// <returns></returns>
        void DeleteTransactionCategory (long? categoryId);
        /// <summary>
        /// Get Transaction Category List The categories service returns the list of available transaction categories.&lt;br&gt;High level category is returned in the response only if it is opted by the customer.&lt;br&gt;When invoked by passing the cobrand session or admin access token, this service returns the supported transaction categories at the cobrand level. &lt;br&gt;When invoked by passing the cobrand session and the user session or user access token, this service returns the transaction categories &lt;br&gt;along with user-defined categories.&lt;br&gt;Double quotes in the user-defined category name will be prefixed by backslashes (&amp;#92;) in the response, &lt;br&gt;e.g. Toys \&quot;R\&quot; Us.&lt;br/&gt;Source and id are the primary attributes of the category entity.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
        /// </summary>
        /// <returns>TransactionCategoryResponse</returns>
        TransactionCategoryResponse GetTransactionCategories ();
        /// <summary>
        /// Get Transaction Categorization Rules The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
        /// </summary>
        /// <returns>TransactionCategorizationRuleResponse</returns>
        TransactionCategorizationRuleResponse GetTransactionCategorizationRules ();
        /// <summary>
        /// Get Transaction Categorization Rules The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
        /// </summary>
        /// <returns>List&lt;TransactionCategorizationRule&gt;</returns>
        List<TransactionCategorizationRule> GetTransactionCategorizationRulesDeprecated ();
        /// <summary>
        /// Get Transactions The Transaction service is used to get a list of transactions for a user.&lt;br&gt;By default, this service returns the last 30 days of transactions from today&#x27;s date.&lt;br&gt;The keyword parameter performs a contains search on the original, consumer, and simple description attributes, replace the special characters #, &amp;, and + with percent-encoding values %23, %26, and %2B respectively. Eg: for -Debit# , pass the input as -Debit%23.&lt;br&gt;Values for categoryId parameter can be fetched from get transaction category list service.&lt;br&gt; The categoryId is used to filter transactions based on system-defined category as well as user-defined category.&lt;br&gt;User-defined categoryIds should be provided in the filter with the prefix &#x27;&#x27;U&#x27;&#x27;. E.g. U10002&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;Double quotes in the merchant name will be prefixed by backslashes (&amp;#92;) in the response, e.g. Toys \&quot;R\&quot; Us. &lt;br&gt;sourceId is a unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts. Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;&lt;ul&gt;&lt;li&gt;&lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/transaction-data-enrichment/docs\&quot;&gt;Transaction Data Enrichment (TDE)&lt;/a&gt; is made available for bank and card accounts. The address field in the response is available only when the TDE key is turned on.&lt;/li&gt;&lt;li&gt;The pagination feature is available by default. If no values are passed in the skip and top parameters, the API will only return the first 500 transactions.&lt;/li&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountIds</param>
        /// <param name="baseType">DEBIT/CREDIT</param>
        /// <param name="categoryId">Comma separated categoryIds</param>
        /// <param name="categoryType">Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan</param>
        /// <param name="detailCategoryId">Comma separated detailCategoryIds</param>
        /// <param name="fromDate">Transaction from date(YYYY-MM-DD)</param>
        /// <param name="highLevelCategoryId">Comma separated highLevelCategoryIds</param>
        /// <param name="keyword">Transaction search text</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">Transaction end date (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <param name="type">Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment</param>
        /// <returns>TransactionResponse</returns>
        TransactionResponse GetTransactions (string accountId, string baseType, string categoryId, string categoryType, string container, string detailCategoryId, string fromDate, string highLevelCategoryId, string keyword, int? skip, string toDate, int? top, string type);
        /// <summary>
        /// Get Transactions Count The count service provides the total number of transactions for a specific user depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for transactions, call this endpoint before calling GET /transactions to know the number of transactions that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /transactions endpoint.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountIds </param>
        /// <param name="baseType">DEBIT/CREDIT</param>
        /// <param name="categoryId">Comma separated categoryIds</param>
        /// <param name="categoryType">Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan</param>
        /// <param name="detailCategoryId">Comma separated detailCategoryIds</param>
        /// <param name="fromDate">Transaction from date(YYYY-MM-DD)</param>
        /// <param name="highLevelCategoryId">Comma separated highLevelCategoryIds</param>
        /// <param name="keyword">Transaction search text </param>
        /// <param name="toDate">Transaction end date (YYYY-MM-DD)</param>
        /// <param name="type">Transaction Type(SELL,SWEEP, etc.)</param>
        /// <returns>TransactionCountResponse</returns>
        TransactionCountResponse GetTransactionsCount (string accountId, string baseType, string categoryId, string categoryType, string container, string detailCategoryId, string fromDate, string highLevelCategoryId, string keyword, string toDate, string type);
        /// <summary>
        /// Run Transaction Categorization Rule The run transaction categorization rule service is used to run a rule on transactions, to categorize the transactions.&lt;br&gt;The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ruleId">Unique id of the categorization rule</param>
        /// <returns></returns>
        void RunTransactionCategorizationRule (string action, long? ruleId);
        /// <summary>
        /// Update Transaction The update transaction service is used to update the category,consumer description, memo, isPhysical, merchantType, detailCategory for a transaction.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">transactionRequest</param>
        /// <param name="transactionId">transactionId</param>
        /// <returns></returns>
        void UpdateTransaction (TransactionRequest body, long? transactionId);
        /// <summary>
        /// Update Transaction Categorization Rule The update transaction categorization rule service is used to update a categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;ruleParam JSON input should be as explained in the create transaction categorization rule service.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">transactionCategoriesRuleRequest</param>
        /// <param name="ruleId">ruleId</param>
        /// <returns></returns>
        void UpdateTransactionCategorizationRule (TransactionCategorizationRuleRequest body, long? ruleId);
        /// <summary>
        /// Update Category The update transaction categories service is used to update the transaction category name&lt;br&gt;for a high level category, a system-defined category and a user-defined category.&lt;br&gt;The renamed category can be set back to the original name by passing an empty string for categoryName.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">updateCategoryRequest</param>
        /// <returns></returns>
        void UpdateTransactionCategory (UpdateCategoryRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
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
        /// Create or Run Transaction Categorization Rule The Create or Run Transaction Categorization Rule endpoint is used to: &lt;br&gt;Create transaction categorization rules for both system and user-defined categories.&lt;br&gt;Run all the transaction categorization rules to categorize transactions by calling the endpoint with action&#x3D;run as the query parameter. &lt;br&gt;&lt;br&gt;The input body parameters to create transaction categorization rules follow:&lt;br&gt;     categoryId - This field is mandatory and numeric&lt;br&gt;     priority - This field is optional and numeric. Priority decides the order in which the rule gets applied on transactions.&lt;br&gt;     ruleClause - This field is mandatory and should contain at least one rule&lt;br&gt;     field - The value can be description or amount&lt;br&gt;&lt;br&gt;       If the field value is description then,&lt;br&gt;         1. operation - value can be stringEquals or stringContains&lt;br&gt;         2. value - value should be min of 3 and max of 50 characters&lt;br&gt;&lt;br&gt;       If the field value is amount then, &lt;br&gt;         1. operation - value can be numberEquals, numberLessThan, numberLessThanEquals, numberGreaterThan or numberGreaterThanEquals&lt;br&gt;         2. value - min value 0 and a max value of 99999999999.99 is allowed&lt;br&gt;The HTTP response code is 201 (Created Successfully).
        /// </summary>
        /// <param name="action">To run rules, pass action&#x3D;run. Only value run is supported</param>
        /// <param name="ruleParam">rules(JSON format) to categorize the transactions</param>
        /// <returns></returns>
        public void CreateOrRunTransactionCategorizationRules (string action, string ruleParam)
        {
    
            var path = "/transactions/categories/rules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (action != null) queryParams.Add("action", ApiClient.ParameterToString(action)); // query parameter
 if (ruleParam != null) queryParams.Add("ruleParam", ApiClient.ParameterToString(ruleParam)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrRunTransactionCategorizationRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrRunTransactionCategorizationRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create Category The create transaction categories service is used to create user-defined categories for a system-defined category.&lt;br&gt;The parentCategoryId is the system-defined category id.This can be retrieved using get transaction categories service.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 201 (Created successfully).&lt;br&gt;
        /// </summary>
        /// <param name="body">User Transaction Category in JSON format</param>
        /// <returns></returns>
        public void CreateTransactionCategory (TransactionCategoryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTransactionCategory");
    
            var path = "/transactions/categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransactionCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransactionCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete Transaction Categorization Rule The delete transaction categorization rule service is used to delete the given user-defined transaction categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;This will delete all the corresponding rule clauses associated with the rule.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="ruleId">ruleId</param>
        /// <returns></returns>
        public void DeleteTransactionCategorizationRule (long? ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling DeleteTransactionCategorizationRule");
    
            var path = "/transactions/categories/rules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransactionCategorizationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransactionCategorizationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete Category The delete transaction categories service is used to delete the given user-defined category.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="categoryId">categoryId</param>
        /// <returns></returns>
        public void DeleteTransactionCategory (long? categoryId)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling DeleteTransactionCategory");
    
            var path = "/transactions/categories/{categoryId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "categoryId" + "}", ApiClient.ParameterToString(categoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransactionCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTransactionCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get Transaction Category List The categories service returns the list of available transaction categories.&lt;br&gt;High level category is returned in the response only if it is opted by the customer.&lt;br&gt;When invoked by passing the cobrand session or admin access token, this service returns the supported transaction categories at the cobrand level. &lt;br&gt;When invoked by passing the cobrand session and the user session or user access token, this service returns the transaction categories &lt;br&gt;along with user-defined categories.&lt;br&gt;Double quotes in the user-defined category name will be prefixed by backslashes (&amp;#92;) in the response, &lt;br&gt;e.g. Toys \&quot;R\&quot; Us.&lt;br/&gt;Source and id are the primary attributes of the category entity.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
        /// </summary>
        /// <returns>TransactionCategoryResponse</returns>
        public TransactionCategoryResponse GetTransactionCategories ()
        {
    
            var path = "/transactions/categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionCategoryResponse) ApiClient.Deserialize(response.Content, typeof(TransactionCategoryResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Transaction Categorization Rules The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
        /// </summary>
        /// <returns>TransactionCategorizationRuleResponse</returns>
        public TransactionCategorizationRuleResponse GetTransactionCategorizationRules ()
        {
    
            var path = "/transactions/categories/txnRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategorizationRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategorizationRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionCategorizationRuleResponse) ApiClient.Deserialize(response.Content, typeof(TransactionCategorizationRuleResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Transaction Categorization Rules The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
        /// </summary>
        /// <returns>List&lt;TransactionCategorizationRule&gt;</returns>
        public List<TransactionCategorizationRule> GetTransactionCategorizationRulesDeprecated ()
        {
    
            var path = "/transactions/categories/rules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategorizationRulesDeprecated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionCategorizationRulesDeprecated: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TransactionCategorizationRule>) ApiClient.Deserialize(response.Content, typeof(List<TransactionCategorizationRule>), response.Headers);
        }
    
        /// <summary>
        /// Get Transactions The Transaction service is used to get a list of transactions for a user.&lt;br&gt;By default, this service returns the last 30 days of transactions from today&#x27;s date.&lt;br&gt;The keyword parameter performs a contains search on the original, consumer, and simple description attributes, replace the special characters #, &amp;, and + with percent-encoding values %23, %26, and %2B respectively. Eg: for -Debit# , pass the input as -Debit%23.&lt;br&gt;Values for categoryId parameter can be fetched from get transaction category list service.&lt;br&gt; The categoryId is used to filter transactions based on system-defined category as well as user-defined category.&lt;br&gt;User-defined categoryIds should be provided in the filter with the prefix &#x27;&#x27;U&#x27;&#x27;. E.g. U10002&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;Double quotes in the merchant name will be prefixed by backslashes (&amp;#92;) in the response, e.g. Toys \&quot;R\&quot; Us. &lt;br&gt;sourceId is a unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts. Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;&lt;ul&gt;&lt;li&gt;&lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/transaction-data-enrichment/docs\&quot;&gt;Transaction Data Enrichment (TDE)&lt;/a&gt; is made available for bank and card accounts. The address field in the response is available only when the TDE key is turned on.&lt;/li&gt;&lt;li&gt;The pagination feature is available by default. If no values are passed in the skip and top parameters, the API will only return the first 500 transactions.&lt;/li&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountIds</param>
        /// <param name="baseType">DEBIT/CREDIT</param>
        /// <param name="categoryId">Comma separated categoryIds</param>
        /// <param name="categoryType">Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan</param>
        /// <param name="detailCategoryId">Comma separated detailCategoryIds</param>
        /// <param name="fromDate">Transaction from date(YYYY-MM-DD)</param>
        /// <param name="highLevelCategoryId">Comma separated highLevelCategoryIds</param>
        /// <param name="keyword">Transaction search text</param>
        /// <param name="skip">skip (Min 0)</param>
        /// <param name="toDate">Transaction end date (YYYY-MM-DD)</param>
        /// <param name="top">top (Max 500)</param>
        /// <param name="type">Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment</param>
        /// <returns>TransactionResponse</returns>
        public TransactionResponse GetTransactions (string accountId, string baseType, string categoryId, string categoryType, string container, string detailCategoryId, string fromDate, string highLevelCategoryId, string keyword, int? skip, string toDate, int? top, string type)
        {
    
            var path = "/transactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (baseType != null) queryParams.Add("baseType", ApiClient.ParameterToString(baseType)); // query parameter
 if (categoryId != null) queryParams.Add("categoryId", ApiClient.ParameterToString(categoryId)); // query parameter
 if (categoryType != null) queryParams.Add("categoryType", ApiClient.ParameterToString(categoryType)); // query parameter
 if (container != null) queryParams.Add("container", ApiClient.ParameterToString(container)); // query parameter
 if (detailCategoryId != null) queryParams.Add("detailCategoryId", ApiClient.ParameterToString(detailCategoryId)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (highLevelCategoryId != null) queryParams.Add("highLevelCategoryId", ApiClient.ParameterToString(highLevelCategoryId)); // query parameter
 if (keyword != null) queryParams.Add("keyword", ApiClient.ParameterToString(keyword)); // query parameter
 if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
 if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionResponse) ApiClient.Deserialize(response.Content, typeof(TransactionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Transactions Count The count service provides the total number of transactions for a specific user depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for transactions, call this endpoint before calling GET /transactions to know the number of transactions that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /transactions endpoint.&lt;br&gt;
        /// </summary>
        /// <param name="accountId">Comma separated accountIds </param>
        /// <param name="baseType">DEBIT/CREDIT</param>
        /// <param name="categoryId">Comma separated categoryIds</param>
        /// <param name="categoryType">Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)</param>
        /// <param name="container">bank/creditCard/investment/insurance/loan</param>
        /// <param name="detailCategoryId">Comma separated detailCategoryIds</param>
        /// <param name="fromDate">Transaction from date(YYYY-MM-DD)</param>
        /// <param name="highLevelCategoryId">Comma separated highLevelCategoryIds</param>
        /// <param name="keyword">Transaction search text </param>
        /// <param name="toDate">Transaction end date (YYYY-MM-DD)</param>
        /// <param name="type">Transaction Type(SELL,SWEEP, etc.)</param>
        /// <returns>TransactionCountResponse</returns>
        public TransactionCountResponse GetTransactionsCount (string accountId, string baseType, string categoryId, string categoryType, string container, string detailCategoryId, string fromDate, string highLevelCategoryId, string keyword, string toDate, string type)
        {
    
            var path = "/transactions/count";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (baseType != null) queryParams.Add("baseType", ApiClient.ParameterToString(baseType)); // query parameter
 if (categoryId != null) queryParams.Add("categoryId", ApiClient.ParameterToString(categoryId)); // query parameter
 if (categoryType != null) queryParams.Add("categoryType", ApiClient.ParameterToString(categoryType)); // query parameter
 if (container != null) queryParams.Add("container", ApiClient.ParameterToString(container)); // query parameter
 if (detailCategoryId != null) queryParams.Add("detailCategoryId", ApiClient.ParameterToString(detailCategoryId)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (highLevelCategoryId != null) queryParams.Add("highLevelCategoryId", ApiClient.ParameterToString(highLevelCategoryId)); // query parameter
 if (keyword != null) queryParams.Add("keyword", ApiClient.ParameterToString(keyword)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionCountResponse) ApiClient.Deserialize(response.Content, typeof(TransactionCountResponse), response.Headers);
        }
    
        /// <summary>
        /// Run Transaction Categorization Rule The run transaction categorization rule service is used to run a rule on transactions, to categorize the transactions.&lt;br&gt;The HTTP response code is 204 (Success with no content).&lt;br&gt;
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ruleId">Unique id of the categorization rule</param>
        /// <returns></returns>
        public void RunTransactionCategorizationRule (string action, long? ruleId)
        {
            // verify the required parameter 'action' is set
            if (action == null) throw new ApiException(400, "Missing required parameter 'action' when calling RunTransactionCategorizationRule");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling RunTransactionCategorizationRule");
    
            var path = "/transactions/categories/rules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (action != null) queryParams.Add("action", ApiClient.ParameterToString(action)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RunTransactionCategorizationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RunTransactionCategorizationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update Transaction The update transaction service is used to update the category,consumer description, memo, isPhysical, merchantType, detailCategory for a transaction.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">transactionRequest</param>
        /// <param name="transactionId">transactionId</param>
        /// <returns></returns>
        public void UpdateTransaction (TransactionRequest body, long? transactionId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling UpdateTransaction");
    
            var path = "/transactions/{transactionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "transactionId" + "}", ApiClient.ParameterToString(transactionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update Transaction Categorization Rule The update transaction categorization rule service is used to update a categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;ruleParam JSON input should be as explained in the create transaction categorization rule service.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">transactionCategoriesRuleRequest</param>
        /// <param name="ruleId">ruleId</param>
        /// <returns></returns>
        public void UpdateTransactionCategorizationRule (TransactionCategorizationRuleRequest body, long? ruleId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateTransactionCategorizationRule");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling UpdateTransactionCategorizationRule");
    
            var path = "/transactions/categories/rules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransactionCategorizationRule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransactionCategorizationRule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update Category The update transaction categories service is used to update the transaction category name&lt;br&gt;for a high level category, a system-defined category and a user-defined category.&lt;br&gt;The renamed category can be set back to the original name by passing an empty string for categoryName.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
        /// </summary>
        /// <param name="body">updateCategoryRequest</param>
        /// <returns></returns>
        public void UpdateTransactionCategory (UpdateCategoryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateTransactionCategory");
    
            var path = "/transactions/categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransactionCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransactionCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
