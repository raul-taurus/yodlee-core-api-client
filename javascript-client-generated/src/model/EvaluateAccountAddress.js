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

/**
 * The EvaluateAccountAddress model module.
 * @module model/EvaluateAccountAddress
 * @version 1.1.0
 */
export class EvaluateAccountAddress {
  /**
   * Constructs a new <code>EvaluateAccountAddress</code>.
   * @alias module:model/EvaluateAccountAddress
   * @class
   * @param street {String} 
   */
  constructor(street) {
    this.street = street;
  }

  /**
   * Constructs a <code>EvaluateAccountAddress</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/EvaluateAccountAddress} obj Optional instance to populate.
   * @return {module:model/EvaluateAccountAddress} The populated <code>EvaluateAccountAddress</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new EvaluateAccountAddress();
      if (data.hasOwnProperty('zip'))
        obj.zip = ApiClient.convertToType(data['zip'], 'String');
      if (data.hasOwnProperty('country'))
        obj.country = ApiClient.convertToType(data['country'], 'String');
      if (data.hasOwnProperty('address3'))
        obj.address3 = ApiClient.convertToType(data['address3'], 'String');
      if (data.hasOwnProperty('address2'))
        obj.address2 = ApiClient.convertToType(data['address2'], 'String');
      if (data.hasOwnProperty('city'))
        obj.city = ApiClient.convertToType(data['city'], 'String');
      if (data.hasOwnProperty('sourceType'))
        obj.sourceType = ApiClient.convertToType(data['sourceType'], 'String');
      if (data.hasOwnProperty('address1'))
        obj.address1 = ApiClient.convertToType(data['address1'], 'String');
      if (data.hasOwnProperty('street'))
        obj.street = ApiClient.convertToType(data['street'], 'String');
      if (data.hasOwnProperty('state'))
        obj.state = ApiClient.convertToType(data['state'], 'String');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
    }
    return obj;
  }
}

/**
 * Zip.
 * @member {String} zip
 */
EvaluateAccountAddress.prototype.zip = undefined;

/**
 * Country.
 * @member {String} country
 */
EvaluateAccountAddress.prototype.country = undefined;

/**
 * Address Line 3.
 * @member {String} address3
 */
EvaluateAccountAddress.prototype.address3 = undefined;

/**
 * Address Line 2.
 * @member {String} address2
 */
EvaluateAccountAddress.prototype.address2 = undefined;

/**
 * City.
 * @member {String} city
 */
EvaluateAccountAddress.prototype.city = undefined;

/**
 * @member {String} sourceType
 */
EvaluateAccountAddress.prototype.sourceType = undefined;

/**
 * Address Line 1.
 * @member {String} address1
 */
EvaluateAccountAddress.prototype.address1 = undefined;

/**
 * @member {String} street
 */
EvaluateAccountAddress.prototype.street = undefined;

/**
 * State.
 * @member {String} state
 */
EvaluateAccountAddress.prototype.state = undefined;

/**
 * Allowed values for the <code>type</code> property.
 * @enum {String}
 * @readonly
 */
EvaluateAccountAddress.TypeEnum = {
  /**
   * value: "HOME"
   * @const
   */
  HOME: "HOME",

  /**
   * value: "BUSINESS"
   * @const
   */
  BUSINESS: "BUSINESS",

  /**
   * value: "POBOX"
   * @const
   */
  POBOX: "POBOX",

  /**
   * value: "RETAIL"
   * @const
   */
  RETAIL: "RETAIL",

  /**
   * value: "OFFICE"
   * @const
   */
  OFFICE: "OFFICE",

  /**
   * value: "SMALL_BUSINESS"
   * @const
   */
  SMALL_BUSINESS: "SMALL_BUSINESS",

  /**
   * value: "COMMUNICATION"
   * @const
   */
  COMMUNICATION: "COMMUNICATION",

  /**
   * value: "PERMANENT"
   * @const
   */
  PERMANENT: "PERMANENT",

  /**
   * value: "STATEMENT_ADDRESS"
   * @const
   */
  STATEMENT_ADDRESS: "STATEMENT_ADDRESS",

  /**
   * value: "PAYMENT"
   * @const
   */
  PAYMENT: "PAYMENT",

  /**
   * value: "PAYOFF"
   * @const
   */
  PAYOFF: "PAYOFF",

  /**
   * value: "UNKNOWN"
   * @const
   */
  UNKNOWN: "UNKNOWN"
};
/**
 * @member {module:model/EvaluateAccountAddress.TypeEnum} type
 */
EvaluateAccountAddress.prototype.type = undefined;

