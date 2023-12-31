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
import {Field} from './Field';
import {ProviderAccountPreferences} from './ProviderAccountPreferences';

/**
 * The ProviderAccountRequest model module.
 * @module model/ProviderAccountRequest
 * @version 1.1.0
 */
export class ProviderAccountRequest {
  /**
   * Constructs a new <code>ProviderAccountRequest</code>.
   * @alias module:model/ProviderAccountRequest
   * @class
   * @param field {Array.<module:model/Field>} 
   */
  constructor(field) {
    this.field = field;
  }

  /**
   * Constructs a <code>ProviderAccountRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ProviderAccountRequest} obj Optional instance to populate.
   * @return {module:model/ProviderAccountRequest} The populated <code>ProviderAccountRequest</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ProviderAccountRequest();
      if (data.hasOwnProperty('consentId'))
        obj.consentId = ApiClient.convertToType(data['consentId'], 'Number');
      if (data.hasOwnProperty('preferences'))
        obj.preferences = ProviderAccountPreferences.constructFromObject(data['preferences']);
      if (data.hasOwnProperty('aggregationSource'))
        obj.aggregationSource = ApiClient.convertToType(data['aggregationSource'], 'String');
      if (data.hasOwnProperty('field'))
        obj.field = ApiClient.convertToType(data['field'], [Field]);
    }
    return obj;
  }
}

/**
 * Consent Id generated for the request through POST Consent.<br><br><b>Endpoints</b>:<ul><li>POST Provider Account</li><li>PUT Provider Account</li></ul>
 * @member {Number} consentId
 */
ProviderAccountRequest.prototype.consentId = undefined;

/**
 * @member {module:model/ProviderAccountPreferences} preferences
 */
ProviderAccountRequest.prototype.preferences = undefined;

/**
 * Allowed values for the <code>aggregationSource</code> property.
 * @enum {String}
 * @readonly
 */
ProviderAccountRequest.AggregationSourceEnum = {
  /**
   * value: "SYSTEM"
   * @const
   */
  SYSTEM: "SYSTEM",

  /**
   * value: "USER"
   * @const
   */
  USER: "USER"
};
/**
 * @member {module:model/ProviderAccountRequest.AggregationSourceEnum} aggregationSource
 */
ProviderAccountRequest.prototype.aggregationSource = undefined;

/**
 * @member {Array.<module:model/Field>} field
 */
ProviderAccountRequest.prototype.field = undefined;

