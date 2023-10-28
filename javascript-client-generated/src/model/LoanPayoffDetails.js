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
 * The LoanPayoffDetails model module.
 * @module model/LoanPayoffDetails
 * @version 1.1.0
 */
export class LoanPayoffDetails {
  /**
   * Constructs a new <code>LoanPayoffDetails</code>.
   * @alias module:model/LoanPayoffDetails
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>LoanPayoffDetails</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LoanPayoffDetails} obj Optional instance to populate.
   * @return {module:model/LoanPayoffDetails} The populated <code>LoanPayoffDetails</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new LoanPayoffDetails();
      if (data.hasOwnProperty('payByDate'))
        obj.payByDate = ApiClient.convertToType(data['payByDate'], 'String');
      if (data.hasOwnProperty('payoffAmount'))
        obj.payoffAmount = Money.constructFromObject(data['payoffAmount']);
      if (data.hasOwnProperty('outstandingBalance'))
        obj.outstandingBalance = Money.constructFromObject(data['outstandingBalance']);
    }
    return obj;
  }
}

/**
 * The date by which the payoff amount should be paid.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
 * @member {String} payByDate
 */
LoanPayoffDetails.prototype.payByDate = undefined;

/**
 * @member {module:model/Money} payoffAmount
 */
LoanPayoffDetails.prototype.payoffAmount = undefined;

/**
 * @member {module:model/Money} outstandingBalance
 */
LoanPayoffDetails.prototype.outstandingBalance = undefined;
