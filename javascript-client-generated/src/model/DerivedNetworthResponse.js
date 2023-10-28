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
import {DerivedNetworth} from './DerivedNetworth';

/**
 * The DerivedNetworthResponse model module.
 * @module model/DerivedNetworthResponse
 * @version 1.1.0
 */
export class DerivedNetworthResponse {
  /**
   * Constructs a new <code>DerivedNetworthResponse</code>.
   * @alias module:model/DerivedNetworthResponse
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>DerivedNetworthResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DerivedNetworthResponse} obj Optional instance to populate.
   * @return {module:model/DerivedNetworthResponse} The populated <code>DerivedNetworthResponse</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new DerivedNetworthResponse();
      if (data.hasOwnProperty('networth'))
        obj.networth = ApiClient.convertToType(data['networth'], [DerivedNetworth]);
    }
    return obj;
  }
}

/**
 * @member {Array.<module:model/DerivedNetworth>} networth
 */
DerivedNetworthResponse.prototype.networth = undefined;

