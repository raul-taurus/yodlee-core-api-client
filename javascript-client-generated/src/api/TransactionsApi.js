/*
 * Yodlee Core APIs
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: developer@yodlee.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 3.0.50
 *
 * Do not edit the class manually.
 *
 */
import {ApiClient} from "../ApiClient";
import {TransactionCategorizationRule} from '../model/TransactionCategorizationRule';
import {TransactionCategorizationRuleRequest} from '../model/TransactionCategorizationRuleRequest';
import {TransactionCategorizationRuleResponse} from '../model/TransactionCategorizationRuleResponse';
import {TransactionCategoryRequest} from '../model/TransactionCategoryRequest';
import {TransactionCategoryResponse} from '../model/TransactionCategoryResponse';
import {TransactionCountResponse} from '../model/TransactionCountResponse';
import {TransactionRequest} from '../model/TransactionRequest';
import {TransactionResponse} from '../model/TransactionResponse';
import {UpdateCategoryRequest} from '../model/UpdateCategoryRequest';
import {YodleeError} from '../model/YodleeError';

/**
* Transactions service.
* @module api/TransactionsApi
* @version 1.1.0
*/
export class TransactionsApi {

    /**
    * Constructs a new TransactionsApi. 
    * @alias module:api/TransactionsApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instanc
    e} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }

    /**
     * Callback function to receive the result of the createOrRunTransactionCategorizationRules operation.
     * @callback moduleapi/TransactionsApi~createOrRunTransactionCategorizationRulesCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create or Run Transaction Categorization Rule
     * The Create or Run Transaction Categorization Rule endpoint is used to: &lt;br&gt;Create transaction categorization rules for both system and user-defined categories.&lt;br&gt;Run all the transaction categorization rules to categorize transactions by calling the endpoint with action&#x3D;run as the query parameter. &lt;br&gt;&lt;br&gt;The input body parameters to create transaction categorization rules follow:&lt;br&gt;     categoryId - This field is mandatory and numeric&lt;br&gt;     priority - This field is optional and numeric. Priority decides the order in which the rule gets applied on transactions.&lt;br&gt;     ruleClause - This field is mandatory and should contain at least one rule&lt;br&gt;     field - The value can be description or amount&lt;br&gt;&lt;br&gt;       If the field value is description then,&lt;br&gt;         1. operation - value can be stringEquals or stringContains&lt;br&gt;         2. value - value should be min of 3 and max of 50 characters&lt;br&gt;&lt;br&gt;       If the field value is amount then, &lt;br&gt;         1. operation - value can be numberEquals, numberLessThan, numberLessThanEquals, numberGreaterThan or numberGreaterThanEquals&lt;br&gt;         2. value - min value 0 and a max value of 99999999999.99 is allowed&lt;br&gt;The HTTP response code is 201 (Created Successfully).
     * @param {Object} opts Optional parameters
     * @param {String} opts.action To run rules, pass action&#x3D;run. Only value run is supported
     * @param {String} opts.ruleParam rules(JSON format) to categorize the transactions
     * @param {module:api/TransactionsApi~createOrRunTransactionCategorizationRulesCallback} callback The callback function, accepting three arguments: error, data, response
     */
    createOrRunTransactionCategorizationRules(opts, callback) {
      opts = opts || {};
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        'action': opts['action'],'ruleParam': opts['ruleParam']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories/rules', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the createTransactionCategory operation.
     * @callback moduleapi/TransactionsApi~createTransactionCategoryCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create Category
     * The create transaction categories service is used to create user-defined categories for a system-defined category.&lt;br&gt;The parentCategoryId is the system-defined category id.This can be retrieved using get transaction categories service.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 201 (Created successfully).&lt;br&gt;
     * @param {module:model/TransactionCategoryRequest} body User Transaction Category in JSON format
     * @param {module:api/TransactionsApi~createTransactionCategoryCallback} callback The callback function, accepting three arguments: error, data, response
     */
    createTransactionCategory(body, callback) {
      
      let postBody = body;
      // verify the required parameter 'body' is set
      if (body === undefined || body === null) {
        throw new Error("Missing the required parameter 'body' when calling createTransactionCategory");
      }

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = ['application/json'];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the deleteTransactionCategorizationRule operation.
     * @callback moduleapi/TransactionsApi~deleteTransactionCategorizationRuleCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete Transaction Categorization Rule
     * The delete transaction categorization rule service is used to delete the given user-defined transaction categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;This will delete all the corresponding rule clauses associated with the rule.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
     * @param {Number} ruleId ruleId
     * @param {module:api/TransactionsApi~deleteTransactionCategorizationRuleCallback} callback The callback function, accepting three arguments: error, data, response
     */
    deleteTransactionCategorizationRule(ruleId, callback) {
      
      let postBody = null;
      // verify the required parameter 'ruleId' is set
      if (ruleId === undefined || ruleId === null) {
        throw new Error("Missing the required parameter 'ruleId' when calling deleteTransactionCategorizationRule");
      }

      let pathParams = {
        'ruleId': ruleId
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories/rules/{ruleId}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the deleteTransactionCategory operation.
     * @callback moduleapi/TransactionsApi~deleteTransactionCategoryCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete Category
     * The delete transaction categories service is used to delete the given user-defined category.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
     * @param {Number} categoryId categoryId
     * @param {module:api/TransactionsApi~deleteTransactionCategoryCallback} callback The callback function, accepting three arguments: error, data, response
     */
    deleteTransactionCategory(categoryId, callback) {
      
      let postBody = null;
      // verify the required parameter 'categoryId' is set
      if (categoryId === undefined || categoryId === null) {
        throw new Error("Missing the required parameter 'categoryId' when calling deleteTransactionCategory");
      }

      let pathParams = {
        'categoryId': categoryId
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories/{categoryId}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getTransactionCategories operation.
     * @callback moduleapi/TransactionsApi~getTransactionCategoriesCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TransactionCategoryResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Transaction Category List
     * The categories service returns the list of available transaction categories.&lt;br&gt;High level category is returned in the response only if it is opted by the customer.&lt;br&gt;When invoked by passing the cobrand session or admin access token, this service returns the supported transaction categories at the cobrand level. &lt;br&gt;When invoked by passing the cobrand session and the user session or user access token, this service returns the transaction categories &lt;br&gt;along with user-defined categories.&lt;br&gt;Double quotes in the user-defined category name will be prefixed by backslashes (&amp;#92;) in the response, &lt;br&gt;e.g. Toys \&quot;R\&quot; Us.&lt;br/&gt;Source and id are the primary attributes of the category entity.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
     * @param {module:api/TransactionsApi~getTransactionCategoriesCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getTransactionCategories(callback) {
      
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = TransactionCategoryResponse;

      return this.apiClient.callApi(
        '/transactions/categories', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getTransactionCategorizationRules operation.
     * @callback moduleapi/TransactionsApi~getTransactionCategorizationRulesCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TransactionCategorizationRuleResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Transaction Categorization Rules
     * The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
     * @param {module:api/TransactionsApi~getTransactionCategorizationRulesCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getTransactionCategorizationRules(callback) {
      
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = TransactionCategorizationRuleResponse;

      return this.apiClient.callApi(
        '/transactions/categories/txnRules', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getTransactionCategorizationRulesDeprecated operation.
     * @callback moduleapi/TransactionsApi~getTransactionCategorizationRulesDeprecatedCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/TransactionCategorizationRule>{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Transaction Categorization Rules
     * The get transaction categorization rule service is used to get all the categorization rules.&lt;br&gt;
     * @param {module:api/TransactionsApi~getTransactionCategorizationRulesDeprecatedCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getTransactionCategorizationRulesDeprecated(callback) {
      
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = [TransactionCategorizationRule];

      return this.apiClient.callApi(
        '/transactions/categories/rules', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getTransactions operation.
     * @callback moduleapi/TransactionsApi~getTransactionsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TransactionResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Transactions
     * The Transaction service is used to get a list of transactions for a user.&lt;br&gt;By default, this service returns the last 30 days of transactions from today&#x27;s date.&lt;br&gt;The keyword parameter performs a contains search on the original, consumer, and simple description attributes, replace the special characters #, &amp;, and + with percent-encoding values %23, %26, and %2B respectively. Eg: for -Debit# , pass the input as -Debit%23.&lt;br&gt;Values for categoryId parameter can be fetched from get transaction category list service.&lt;br&gt; The categoryId is used to filter transactions based on system-defined category as well as user-defined category.&lt;br&gt;User-defined categoryIds should be provided in the filter with the prefix &#x27;&#x27;U&#x27;&#x27;. E.g. U10002&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;Double quotes in the merchant name will be prefixed by backslashes (&amp;#92;) in the response, e.g. Toys \&quot;R\&quot; Us. &lt;br&gt;sourceId is a unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts. Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;&lt;ul&gt;&lt;li&gt;&lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/transaction-data-enrichment/docs\&quot;&gt;Transaction Data Enrichment (TDE)&lt;/a&gt; is made available for bank and card accounts. The address field in the response is available only when the TDE key is turned on.&lt;/li&gt;&lt;li&gt;The pagination feature is available by default. If no values are passed in the skip and top parameters, the API will only return the first 500 transactions.&lt;/li&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
     * @param {Object} opts Optional parameters
     * @param {String} opts.accountId Comma separated accountIds
     * @param {String} opts.baseType DEBIT/CREDIT
     * @param {String} opts.categoryId Comma separated categoryIds
     * @param {String} opts.categoryType Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)
     * @param {String} opts.container bank/creditCard/investment/insurance/loan
     * @param {String} opts.detailCategoryId Comma separated detailCategoryIds
     * @param {String} opts.fromDate Transaction from date(YYYY-MM-DD)
     * @param {String} opts.highLevelCategoryId Comma separated highLevelCategoryIds
     * @param {String} opts.keyword Transaction search text
     * @param {Number} opts.skip skip (Min 0)
     * @param {String} opts.toDate Transaction end date (YYYY-MM-DD)
     * @param {Number} opts.top top (Max 500)
     * @param {String} opts.type Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment
     * @param {module:api/TransactionsApi~getTransactionsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getTransactions(opts, callback) {
      opts = opts || {};
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        'accountId': opts['accountId'],'baseType': opts['baseType'],'categoryId': opts['categoryId'],'categoryType': opts['categoryType'],'container': opts['container'],'detailCategoryId': opts['detailCategoryId'],'fromDate': opts['fromDate'],'highLevelCategoryId': opts['highLevelCategoryId'],'keyword': opts['keyword'],'skip': opts['skip'],'toDate': opts['toDate'],'top': opts['top'],'type': opts['type']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = TransactionResponse;

      return this.apiClient.callApi(
        '/transactions', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getTransactionsCount operation.
     * @callback moduleapi/TransactionsApi~getTransactionsCountCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TransactionCountResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Transactions Count
     * The count service provides the total number of transactions for a specific user depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for transactions, call this endpoint before calling GET /transactions to know the number of transactions that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /transactions endpoint.&lt;br&gt;
     * @param {Object} opts Optional parameters
     * @param {String} opts.accountId Comma separated accountIds 
     * @param {String} opts.baseType DEBIT/CREDIT
     * @param {String} opts.categoryId Comma separated categoryIds
     * @param {String} opts.categoryType Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION)
     * @param {String} opts.container bank/creditCard/investment/insurance/loan
     * @param {String} opts.detailCategoryId Comma separated detailCategoryIds
     * @param {String} opts.fromDate Transaction from date(YYYY-MM-DD)
     * @param {String} opts.highLevelCategoryId Comma separated highLevelCategoryIds
     * @param {String} opts.keyword Transaction search text 
     * @param {String} opts.toDate Transaction end date (YYYY-MM-DD)
     * @param {String} opts.type Transaction Type(SELL,SWEEP, etc.)
     * @param {module:api/TransactionsApi~getTransactionsCountCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getTransactionsCount(opts, callback) {
      opts = opts || {};
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        'accountId': opts['accountId'],'baseType': opts['baseType'],'categoryId': opts['categoryId'],'categoryType': opts['categoryType'],'container': opts['container'],'detailCategoryId': opts['detailCategoryId'],'fromDate': opts['fromDate'],'highLevelCategoryId': opts['highLevelCategoryId'],'keyword': opts['keyword'],'toDate': opts['toDate'],'type': opts['type']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = TransactionCountResponse;

      return this.apiClient.callApi(
        '/transactions/count', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the runTransactionCategorizationRule operation.
     * @callback moduleapi/TransactionsApi~runTransactionCategorizationRuleCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Run Transaction Categorization Rule
     * The run transaction categorization rule service is used to run a rule on transactions, to categorize the transactions.&lt;br&gt;The HTTP response code is 204 (Success with no content).&lt;br&gt;
     * @param {module:model/String} action 
     * @param {Number} ruleId Unique id of the categorization rule
     * @param {module:api/TransactionsApi~runTransactionCategorizationRuleCallback} callback The callback function, accepting three arguments: error, data, response
     */
    runTransactionCategorizationRule(action, ruleId, callback) {
      
      let postBody = null;
      // verify the required parameter 'action' is set
      if (action === undefined || action === null) {
        throw new Error("Missing the required parameter 'action' when calling runTransactionCategorizationRule");
      }
      // verify the required parameter 'ruleId' is set
      if (ruleId === undefined || ruleId === null) {
        throw new Error("Missing the required parameter 'ruleId' when calling runTransactionCategorizationRule");
      }

      let pathParams = {
        'ruleId': ruleId
      };
      let queryParams = {
        'action': action
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories/rules/{ruleId}', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the updateTransaction operation.
     * @callback moduleapi/TransactionsApi~updateTransactionCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Transaction
     * The update transaction service is used to update the category,consumer description, memo, isPhysical, merchantType, detailCategory for a transaction.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
     * @param {module:model/TransactionRequest} body transactionRequest
     * @param {Number} transactionId transactionId
     * @param {module:api/TransactionsApi~updateTransactionCallback} callback The callback function, accepting three arguments: error, data, response
     */
    updateTransaction(body, transactionId, callback) {
      
      let postBody = body;
      // verify the required parameter 'body' is set
      if (body === undefined || body === null) {
        throw new Error("Missing the required parameter 'body' when calling updateTransaction");
      }
      // verify the required parameter 'transactionId' is set
      if (transactionId === undefined || transactionId === null) {
        throw new Error("Missing the required parameter 'transactionId' when calling updateTransaction");
      }

      let pathParams = {
        'transactionId': transactionId
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = ['application/json'];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/{transactionId}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the updateTransactionCategorizationRule operation.
     * @callback moduleapi/TransactionsApi~updateTransactionCategorizationRuleCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Transaction Categorization Rule
     * The update transaction categorization rule service is used to update a categorization rule for both system-defined category as well as user-defined category.&lt;br&gt;ruleParam JSON input should be as explained in the create transaction categorization rule service.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
     * @param {module:model/TransactionCategorizationRuleRequest} body transactionCategoriesRuleRequest
     * @param {Number} ruleId ruleId
     * @param {module:api/TransactionsApi~updateTransactionCategorizationRuleCallback} callback The callback function, accepting three arguments: error, data, response
     */
    updateTransactionCategorizationRule(body, ruleId, callback) {
      
      let postBody = body;
      // verify the required parameter 'body' is set
      if (body === undefined || body === null) {
        throw new Error("Missing the required parameter 'body' when calling updateTransactionCategorizationRule");
      }
      // verify the required parameter 'ruleId' is set
      if (ruleId === undefined || ruleId === null) {
        throw new Error("Missing the required parameter 'ruleId' when calling updateTransactionCategorizationRule");
      }

      let pathParams = {
        'ruleId': ruleId
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = ['application/json'];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories/rules/{ruleId}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the updateTransactionCategory operation.
     * @callback moduleapi/TransactionsApi~updateTransactionCategoryCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Category
     * The update transaction categories service is used to update the transaction category name&lt;br&gt;for a high level category, a system-defined category and a user-defined category.&lt;br&gt;The renamed category can be set back to the original name by passing an empty string for categoryName.&lt;br&gt;The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.&lt;br&gt;The HTTP response code is 204 (Success without content).&lt;br&gt;
     * @param {module:model/UpdateCategoryRequest} body updateCategoryRequest
     * @param {module:api/TransactionsApi~updateTransactionCategoryCallback} callback The callback function, accepting three arguments: error, data, response
     */
    updateTransactionCategory(body, callback) {
      
      let postBody = body;
      // verify the required parameter 'body' is set
      if (body === undefined || body === null) {
        throw new Error("Missing the required parameter 'body' when calling updateTransactionCategory");
      }

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = ['application/json'];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = null;

      return this.apiClient.callApi(
        '/transactions/categories', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

}