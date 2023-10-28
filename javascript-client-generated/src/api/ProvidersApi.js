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
import {ProviderDetailResponse} from '../model/ProviderDetailResponse';
import {ProviderResponse} from '../model/ProviderResponse';
import {ProvidersCountResponse} from '../model/ProvidersCountResponse';
import {YodleeError} from '../model/YodleeError';

/**
* Providers service.
* @module api/ProvidersApi
* @version 1.1.0
*/
export class ProvidersApi {

    /**
    * Constructs a new ProvidersApi. 
    * @alias module:api/ProvidersApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instanc
    e} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }

    /**
     * Callback function to receive the result of the getAllProviders operation.
     * @callback moduleapi/ProvidersApi~getAllProvidersCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ProviderResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Providers
     * &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region.&lt;br&gt;&lt;br&gt;Searching for a provider using a routing number is applicable only to the USA and Canada regions.&lt;br&gt; The valid values for priority are: &lt;br&gt;&lt;ol&gt;&lt;li&gt; cobrand: Returns providers enabled for the cobrand (Default priority)&lt;/li&gt;&lt;li&gt;popular: Returns providers popular among users of the customer.&lt;/li&gt;&lt;/ol&gt;&lt;br&gt;The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.The response header provides the links to retrieve the next and previous set of transactions.&lt;br&gt;&lt;br&gt; Providers accept the configName as the input to the API and return the providers list based on the configurations of each configName.  For verification, the providers will accept the configName with which has the verification product and the attributes that are chosen in the configName which returns the list of providers that match the criteria.  ***For an example,  /ysl/providers?configName&#x3D;aggregationAndVerification*** &lt;br&gt;&lt;br&gt;Note:&lt;/b&gt; &lt;ol&gt;&lt;li&gt;In a product flow involving user interaction, Yodlee recommends invoking this service with filters.&lt;li&gt;Without filters, the service may perform slowly as it takes a few minutes to return data in the response.&lt;li&gt;The AuthParameter appears in the response only in case of token-based aggregation sites.&lt;li&gt;The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in query parameter and response. &lt;/li&gt;&lt;/ol&gt;
     * @param {Object} opts Optional parameters
     * @param {String} opts.capability CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated
     * @param {Number} opts.institutionId Institution Id for Single site selection
     * @param {String} opts.name Name in minimum 1 character or routing number.
     * @param {String} opts.priority Search priority
     * @param {String} opts.providerId Max 5 Comma seperated Provider Ids
     * @param {Number} opts.skip skip (Min 0) - This is not applicable along with &#x27;name&#x27; parameter.
     * @param {Number} opts.top top (Max 500) - This is not applicable along with &#x27;name&#x27; parameter.
     * @param {module:api/ProvidersApi~getAllProvidersCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getAllProviders(opts, callback) {
      opts = opts || {};
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        'capability': opts['capability'],'institutionId': opts['institutionId'],'name': opts['name'],'priority': opts['priority'],'providerId': opts['providerId'],'skip': opts['skip'],'top': opts['top']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = ProviderResponse;

      return this.apiClient.callApi(
        '/providers', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getProvider operation.
     * @callback moduleapi/ProvidersApi~getProviderCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ProviderDetailResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Provider Details
     * The get provider detail service is used to get detailed information including the login form for a provider.&lt;br&gt;The response is a provider object that includes information such as name of the provider, &lt;br&gt;provider&#x27;s base URL, a list of containers supported by the provider, the login form details of the provider, etc.&lt;br&gt;Only enabled datasets, attributes and containers gets returned in the response.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;li&gt;This service supports the localization feature and accepts locale as a header parameter.&lt;li&gt;The capability has been deprecated in the response.
     * @param {Number} providerId providerId
     * @param {module:api/ProvidersApi~getProviderCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getProvider(providerId, callback) {
      
      let postBody = null;
      // verify the required parameter 'providerId' is set
      if (providerId === undefined || providerId === null) {
        throw new Error("Missing the required parameter 'providerId' when calling getProvider");
      }

      let pathParams = {
        'providerId': providerId
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
      let returnType = ProviderDetailResponse;

      return this.apiClient.callApi(
        '/providers/{providerId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the getProvidersCount operation.
     * @callback moduleapi/ProvidersApi~getProvidersCountCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ProvidersCountResponse{ data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Providers Count
     * &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt;The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.&lt;br&gt;If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.&lt;br&gt;The functionality of the input parameters remains the same as that of the GET /providers endpoint&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The capability has been deprecated in the query parameter.&lt;/li&gt;
     * @param {Object} opts Optional parameters
     * @param {String} opts.capability CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated
     * @param {String} opts.name Name in minimum 1 character or routing number.
     * @param {String} opts.priority Search priority
     * @param {module:api/ProvidersApi~getProvidersCountCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link <&vendorExtensions.x-jsdoc-type>}
     */
    getProvidersCount(opts, callback) {
      opts = opts || {};
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        'capability': opts['capability'],'name': opts['name'],'priority': opts['priority']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = ['application/json;charset=UTF-8'];
      let returnType = ProvidersCountResponse;

      return this.apiClient.callApi(
        '/providers/count', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

}