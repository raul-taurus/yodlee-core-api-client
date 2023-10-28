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
import {Money} from './Money';

/**
 * The CoverageAmount model module.
 * @module model/CoverageAmount
 * @version 1.1.0
 */
export class CoverageAmount {
  /**
   * Constructs a new <code>CoverageAmount</code>.
   * @alias module:model/CoverageAmount
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>CoverageAmount</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CoverageAmount} obj Optional instance to populate.
   * @return {module:model/CoverageAmount} The populated <code>CoverageAmount</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new CoverageAmount();
      if (data.hasOwnProperty('cover'))
        obj.cover = Money.constructFromObject(data['cover']);
      if (data.hasOwnProperty('unitType'))
        obj.unitType = ApiClient.convertToType(data['unitType'], 'String');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
      if (data.hasOwnProperty('limitType'))
        obj.limitType = ApiClient.convertToType(data['limitType'], 'String');
      if (data.hasOwnProperty('met'))
        obj.met = Money.constructFromObject(data['met']);
    }
    return obj;
  }
}

/**
 * @member {module:model/Money} cover
 */
CoverageAmount.prototype.cover = undefined;

/**
 * Allowed values for the <code>unitType</code> property.
 * @enum {String}
 * @readonly
 */
CoverageAmount.UnitTypeEnum = {
  /**
   * value: "PER_FAMILY"
   * @const
   */
  FAMILY: "PER_FAMILY",

  /**
   * value: "PER_MEMBER"
   * @const
   */
  MEMBER: "PER_MEMBER"
};
/**
 * The type of coverage unit indicates if the coverage is for an individual or a family.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
 * @member {module:model/CoverageAmount.UnitTypeEnum} unitType
 */
CoverageAmount.prototype.unitType = undefined;

/**
 * Allowed values for the <code>type</code> property.
 * @enum {String}
 * @readonly
 */
CoverageAmount.TypeEnum = {
  /**
   * value: "DEDUCTIBLE"
   * @const
   */
  DEDUCTIBLE: "DEDUCTIBLE",

  /**
   * value: "OUT_OF_POCKET"
   * @const
   */
  OUT_OF_POCKET: "OUT_OF_POCKET",

  /**
   * value: "ANNUAL_BENEFIT"
   * @const
   */
  ANNUAL_BENEFIT: "ANNUAL_BENEFIT",

  /**
   * value: "MAX_BENEFIT"
   * @const
   */
  MAX_BENEFIT: "MAX_BENEFIT",

  /**
   * value: "COVERAGE_AMOUNT"
   * @const
   */
  COVERAGE_AMOUNT: "COVERAGE_AMOUNT",

  /**
   * value: "MONTHLY_BENEFIT"
   * @const
   */
  MONTHLY_BENEFIT: "MONTHLY_BENEFIT",

  /**
   * value: "OTHER"
   * @const
   */
  OTHER: "OTHER"
};
/**
 * The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
 * @member {module:model/CoverageAmount.TypeEnum} type
 */
CoverageAmount.prototype.type = undefined;

/**
 * Allowed values for the <code>limitType</code> property.
 * @enum {String}
 * @readonly
 */
CoverageAmount.LimitTypeEnum = {
  /**
   * value: "IN_NETWORK"
   * @const
   */
  IN_NETWORK: "IN_NETWORK",

  /**
   * value: "OUT_NETWORK"
   * @const
   */
  OUT_NETWORK: "OUT_NETWORK"
};
/**
 * The type of coverage limit indicates if the coverage is in-network or out-of-network.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
 * @member {module:model/CoverageAmount.LimitTypeEnum} limitType
 */
CoverageAmount.prototype.limitType = undefined;

/**
 * @member {module:model/Money} met
 */
CoverageAmount.prototype.met = undefined;

