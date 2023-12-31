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
import {DataExtractsEventResponse} from '../model/DataExtractsEventResponse';
import {DataExtractsUserDataResponse} from '../model/DataExtractsUserDataResponse';
import {YodleeError} from '../model/YodleeError';

/**
* DataExtracts service.
* @module api/DataExtractsApi
* @version 1.1.0
*/
export class DataExtractsApi {

    /**
    * Constructs a new DataExtractsApi. 
    * @alias module:api/DataExtractsApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instanc
    e} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }

    /**
     * Callback function to receive the result of the getDataExtractsEvents operation.
     * @callback moduleapi/DataExtractsApi~getDataExtractsEventsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/DataExtractsEventResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Events
     * The get extracts events service is used to learn about occurrences of data extract related events. This service currently supports only the DATA_UPDATES event.&lt;br&gt;Passing the event name as DATA_UPDATES provides information about users for whom data has been modified in the system for the specified time range. For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;You can retrieve data in increments of no more than 60 minutes over the period of the last 7 days from today&#x27;s date.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br&gt;
     * @param {String} eventName Event Name
     * @param {String} fromDate From DateTime (YYYY-MM-DDThh:mm:ssZ)
     * @param {String} toDate To DateTime (YYYY-MM-DDThh:mm:ssZ)
     * @param {module:api/DataExtractsApi~getDataExtractsEventsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getDataExtractsEvents(eventName, fromDate, toDate, callback) {
      
      let postBody = null;
      // verify the required parameter 'eventName' is set
      if (eventName === undefined || eventName === null) {
        throw new Error("Missing the required parameter 'eventName' when calling getDataExtractsEvents");
      }
      // verify the required parameter 'fromDate' is set
      if (fromDate === undefined || fromDate === null) {
        throw new Error("Missing the required parameter 'fromDate' when calling getDataExtractsEvents");
      }
      // verify the required parameter 'toDate' is set
      if (toDate === undefined || toDate === null) {
        throw new Error("Missing the required parameter 'toDate' when calling getDataExtractsEvents");
      }

      let pathParams = {
        
      };
      let queryParams = {
        'eventName': eventName,'fromDate': fromDate,'toDate': toDate
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = DataExtractsEventResponse;

      return this.apiClient.callApi(
        '/dataExtracts/events', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getDataExtractsUserData operation.
     * @callback moduleapi/DataExtractsApi~getDataExtractsUserDataCallback
     * @param {String} error Error message, if any.
     * @param {module:model/DataExtractsUserDataResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get userData
     * The get user data service is used to get a user&#x27;s modified data for a particular period of time for accounts, transactions, holdings, and provider account information.&lt;br&gt;The time difference between fromDate and toDate fields cannot be more than 60 minutes.&lt;br&gt;By default, pagination is available for the transaction entity in this API. In the first response, the API will retrieve 500 transactions along with other data. The response header will provide a link to retrieve the next set of transactions.&lt;br&gt;In the response body of the first API response, totalTransactionsCount indicates the total number of transactions the API will retrieve for the user.&lt;br&gt;This service is only invoked with either admin access token or a cobrand session.&lt;br/&gt;For more information, refer to the &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/data-extracts/docs/overview\&quot;&gt;Data Extracts&lt;/a&gt; page.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;
     * @param {String} fromDate From DateTime (YYYY-MM-DDThh:mm:ssZ)
     * @param {String} loginName Login Name
     * @param {String} toDate To DateTime (YYYY-MM-DDThh:mm:ssZ)
     * @param {module:api/DataExtractsApi~getDataExtractsUserDataCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getDataExtractsUserData(fromDate, loginName, toDate, callback) {
      
      let postBody = null;
      // verify the required parameter 'fromDate' is set
      if (fromDate === undefined || fromDate === null) {
        throw new Error("Missing the required parameter 'fromDate' when calling getDataExtractsUserData");
      }
      // verify the required parameter 'loginName' is set
      if (loginName === undefined || loginName === null) {
        throw new Error("Missing the required parameter 'loginName' when calling getDataExtractsUserData");
      }
      // verify the required parameter 'toDate' is set
      if (toDate === undefined || toDate === null) {
        throw new Error("Missing the required parameter 'toDate' when calling getDataExtractsUserData");
      }

      let pathParams = {
        
      };
      let queryParams = {
        'fromDate': fromDate,'loginName': loginName,'toDate': toDate
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = DataExtractsUserDataResponse;

      return this.apiClient.callApi(
        '/dataExtracts/userData', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

}