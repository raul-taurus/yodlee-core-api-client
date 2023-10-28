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
import {ApiClient} from '../ApiClient';
import {Providers} from './Providers';

/**
 * The ProviderResponse model module.
 * @module model/ProviderResponse
 * @version 1.1.0
 */
export class ProviderResponse {
  /**
   * Constructs a new <code>ProviderResponse</code>.
   * @alias module:model/ProviderResponse
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>ProviderResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ProviderResponse} obj Optional instance to populate.
   * @return {module:model/ProviderResponse} The populated <code>ProviderResponse</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ProviderResponse();
      if (data.hasOwnProperty('provider'))
        obj.provider = ApiClient.convertToType(data['provider'], [Providers]);
    }
    return obj;
  }
}

/**
 * @member {Array.<module:model/Providers>} provider
 */
ProviderResponse.prototype.provider = undefined;

