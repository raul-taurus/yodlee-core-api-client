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
import {VerifyAccountRequest} from '../model/VerifyAccountRequest';
import {VerifyAccountResponse} from '../model/VerifyAccountResponse';
import {YodleeError} from '../model/YodleeError';

/**
* VerifyAccount service.
* @module api/VerifyAccountApi
* @version 1.1.0
*/
export class VerifyAccountApi {

    /**
    * Constructs a new VerifyAccountApi. 
    * @alias module:api/VerifyAccountApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instanc
    e} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }

    /**
     * Callback function to receive the result of the initiateAccountVerification operation.
     * @callback moduleapi/VerifyAccountApi~initiateAccountVerificationCallback
     * @param {String} error Error message, if any.
     * @param {module:model/VerifyAccountResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Verify Accounts Using Transactions
     * The verify account service is used to verify the account&#x27;s ownership by  matching the transaction details with the accounts aggregated for the user.&lt;br&gt;&lt;ul&gt;&lt;li&gt;If a match is identified, the service returns details of all the accounts along with the matched transaction&#x27;s details.&lt;li&gt;If no transaction match is found, an empty response will be returned.&lt;li&gt;A maximum of 5 transactionCriteria can be passed in a request.&lt;li&gt;The baseType, date, and amount parameters should mandatorily be passed.&lt;li&gt;The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.&lt;li&gt;Pass the container or accountId parameters for better performance.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;/li&gt;&lt;/ul&gt;
     * @param {module:model/VerifyAccountRequest} body verificationParam
     * @param {String} providerAccountId providerAccountId
     * @param {module:api/VerifyAccountApi~initiateAccountVerificationCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    initiateAccountVerification(body, providerAccountId, callback) {
      
      let postBody = body;
      // verify the required parameter 'body' is set
      if (body === undefined || body === null) {
        throw new Error("Missing the required parameter 'body' when calling initiateAccountVerification");
      }
      // verify the required parameter 'providerAccountId' is set
      if (providerAccountId === undefined || providerAccountId === null) {
        throw new Error("Missing the required parameter 'providerAccountId' when calling initiateAccountVerification");
      }

      let pathParams = {
        'providerAccountId': providerAccountId
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
      let returnType = VerifyAccountResponse;

      return this.apiClient.callApi(
        '/verifyAccount/{providerAccountId}', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

}