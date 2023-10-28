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
import {VerifyTransactionCriteria} from './VerifyTransactionCriteria';

/**
 * The VerifyAccountRequest model module.
 * @module model/VerifyAccountRequest
 * @version 1.1.0
 */
export class VerifyAccountRequest {
  /**
   * Constructs a new <code>VerifyAccountRequest</code>.
   * @alias module:model/VerifyAccountRequest
   * @class
   * @param transactionCriteria {Array.<module:model/VerifyTransactionCriteria>} 
   */
  constructor(transactionCriteria) {
    this.transactionCriteria = transactionCriteria;
  }

  /**
   * Constructs a <code>VerifyAccountRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VerifyAccountRequest} obj Optional instance to populate.
   * @return {module:model/VerifyAccountRequest} The populated <code>VerifyAccountRequest</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new VerifyAccountRequest();
      if (data.hasOwnProperty('container'))
        obj.container = ApiClient.convertToType(data['container'], 'String');
      if (data.hasOwnProperty('accountId'))
        obj.accountId = ApiClient.convertToType(data['accountId'], 'Number');
      if (data.hasOwnProperty('transactionCriteria'))
        obj.transactionCriteria = ApiClient.convertToType(data['transactionCriteria'], [VerifyTransactionCriteria]);
    }
    return obj;
  }
}

/**
 * Allowed values for the <code>container</code> property.
 * @enum {String}
 * @readonly
 */
VerifyAccountRequest.ContainerEnum = {
  /**
   * value: "bank"
   * @const
   */
  bank: "bank",

  /**
   * value: "creditCard"
   * @const
   */
  creditCard: "creditCard",

  /**
   * value: "investment"
   * @const
   */
  investment: "investment",

  /**
   * value: "insurance"
   * @const
   */
  insurance: "insurance",

  /**
   * value: "loan"
   * @const
   */
  loan: "loan",

  /**
   * value: "reward"
   * @const
   */
  reward: "reward",

  /**
   * value: "bill"
   * @const
   */
  bill: "bill",

  /**
   * value: "realEstate"
   * @const
   */
  realEstate: "realEstate",

  /**
   * value: "otherAssets"
   * @const
   */
  otherAssets: "otherAssets",

  /**
   * value: "otherLiabilities"
   * @const
   */
  otherLiabilities: "otherLiabilities"
};
/**
 * @member {module:model/VerifyAccountRequest.ContainerEnum} container
 */
VerifyAccountRequest.prototype.container = undefined;

/**
 * @member {Number} accountId
 */
VerifyAccountRequest.prototype.accountId = undefined;

/**
 * @member {Array.<module:model/VerifyTransactionCriteria>} transactionCriteria
 */
VerifyAccountRequest.prototype.transactionCriteria = undefined;
