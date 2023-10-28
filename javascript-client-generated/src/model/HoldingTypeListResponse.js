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
 * The HoldingTypeListResponse model module.
 * @module model/HoldingTypeListResponse
 * @version 1.1.0
 */
export class HoldingTypeListResponse {
  /**
   * Constructs a new <code>HoldingTypeListResponse</code>.
   * @alias module:model/HoldingTypeListResponse
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>HoldingTypeListResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/HoldingTypeListResponse} obj Optional instance to populate.
   * @return {module:model/HoldingTypeListResponse} The populated <code>HoldingTypeListResponse</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new HoldingTypeListResponse();
      if (data.hasOwnProperty('holdingType'))
        obj.holdingType = ApiClient.convertToType(data['holdingType'], ['String']);
    }
    return obj;
  }
}

/**
 * Allowed values for the <code>holdingType</code> property.
 * @enum {String}
 * @readonly
 */
HoldingTypeListResponse.HoldingTypeEnum = {
  /**
   * value: "stock"
   * @const
   */
  stock: "stock",

  /**
   * value: "mutualFund"
   * @const
   */
  mutualFund: "mutualFund",

  /**
   * value: "bond"
   * @const
   */
  bond: "bond",

  /**
   * value: "CD"
   * @const
   */
  CD: "CD",

  /**
   * value: "option"
   * @const
   */
  option: "option",

  /**
   * value: "moneyMarketFund"
   * @const
   */
  moneyMarketFund: "moneyMarketFund",

  /**
   * value: "other"
   * @const
   */
  other: "other",

  /**
   * value: "remic"
   * @const
   */
  remic: "remic",

  /**
   * value: "future"
   * @const
   */
  future: "future",

  /**
   * value: "commodity"
   * @const
   */
  commodity: "commodity",

  /**
   * value: "currency"
   * @const
   */
  currency: "currency",

  /**
   * value: "unitInvestmentTrust"
   * @const
   */
  unitInvestmentTrust: "unitInvestmentTrust",

  /**
   * value: "employeeStockOption"
   * @const
   */
  employeeStockOption: "employeeStockOption",

  /**
   * value: "insuranceAnnuity"
   * @const
   */
  insuranceAnnuity: "insuranceAnnuity",

  /**
   * value: "unknown"
   * @const
   */
  unknown: "unknown",

  /**
   * value: "preferredStock"
   * @const
   */
  preferredStock: "preferredStock",

  /**
   * value: "ETF"
   * @const
   */
  ETF: "ETF",

  /**
   * value: "warrants"
   * @const
   */
  warrants: "warrants",

  /**
   * value: "digitalAsset"
   * @const
   */
  digitalAsset: "digitalAsset"
};
/**
 * @member {Array.<module:model/HoldingTypeListResponse.HoldingTypeEnum>} holdingType
 */
HoldingTypeListResponse.prototype.holdingType = undefined;

