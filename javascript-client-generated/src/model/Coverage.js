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
import {CoverageAmount} from './CoverageAmount';

/**
 * The Coverage model module.
 * @module model/Coverage
 * @version 1.1.0
 */
export class Coverage {
  /**
   * Constructs a new <code>Coverage</code>.
   * @alias module:model/Coverage
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>Coverage</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Coverage} obj Optional instance to populate.
   * @return {module:model/Coverage} The populated <code>Coverage</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Coverage();
      if (data.hasOwnProperty('amount'))
        obj.amount = ApiClient.convertToType(data['amount'], [CoverageAmount]);
      if (data.hasOwnProperty('planType'))
        obj.planType = ApiClient.convertToType(data['planType'], 'String');
      if (data.hasOwnProperty('endDate'))
        obj.endDate = ApiClient.convertToType(data['endDate'], 'String');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
      if (data.hasOwnProperty('startDate'))
        obj.startDate = ApiClient.convertToType(data['startDate'], 'String');
    }
    return obj;
  }
}

/**
 * The coverage amount-related details.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
 * @member {Array.<module:model/CoverageAmount>} amount
 */
Coverage.prototype.amount = undefined;

/**
 * Allowed values for the <code>planType</code> property.
 * @enum {String}
 * @readonly
 */
Coverage.PlanTypeEnum = {
  /**
   * value: "PPO"
   * @const
   */
  PPO: "PPO",

  /**
   * value: "HMO"
   * @const
   */
  HMO: "HMO",

  /**
   * value: "UNKNOWN"
   * @const
   */
  UNKNOWN: "UNKNOWN"
};
/**
 * The plan type for an insurance provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
 * @member {module:model/Coverage.PlanTypeEnum} planType
 */
Coverage.prototype.planType = undefined;

/**
 * The date on which the coverage for the account ends or expires.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
 * @member {String} endDate
 */
Coverage.prototype.endDate = undefined;

/**
 * Allowed values for the <code>type</code> property.
 * @enum {String}
 * @readonly
 */
Coverage.TypeEnum = {
  /**
   * value: "VISION"
   * @const
   */
  VISION: "VISION",

  /**
   * value: "DENTAL"
   * @const
   */
  DENTAL: "DENTAL",

  /**
   * value: "MEDICAL"
   * @const
   */
  MEDICAL: "MEDICAL",

  /**
   * value: "HEALTH"
   * @const
   */
  HEALTH: "HEALTH",

  /**
   * value: "DEATH_COVER"
   * @const
   */
  DEATH_COVER: "DEATH_COVER",

  /**
   * value: "TOTAL_PERMANENT_DISABILITY"
   * @const
   */
  TOTAL_PERMANENT_DISABILITY: "TOTAL_PERMANENT_DISABILITY",

  /**
   * value: "ACCIDENTAL_DEATH_COVER"
   * @const
   */
  ACCIDENTAL_DEATH_COVER: "ACCIDENTAL_DEATH_COVER",

  /**
   * value: "INCOME_PROTECTION"
   * @const
   */
  INCOME_PROTECTION: "INCOME_PROTECTION",

  /**
   * value: "DEATH_TOTAL_PERMANENT_DISABILITY"
   * @const
   */
  DEATH_TOTAL_PERMANENT_DISABILITY: "DEATH_TOTAL_PERMANENT_DISABILITY",

  /**
   * value: "OTHER"
   * @const
   */
  OTHER: "OTHER"
};
/**
 * The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
 * @member {module:model/Coverage.TypeEnum} type
 */
Coverage.prototype.type = undefined;

/**
 * The date on which the coverage for the account starts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
 * @member {String} startDate
 */
Coverage.prototype.startDate = undefined;

