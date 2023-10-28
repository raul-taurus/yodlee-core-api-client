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
import {VerificationAccount} from './VerificationAccount';

/**
 * The VerificationStatus model module.
 * @module model/VerificationStatus
 * @version 1.1.0
 */
export class VerificationStatus {
  /**
   * Constructs a new <code>VerificationStatus</code>.
   * @alias module:model/VerificationStatus
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>VerificationStatus</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VerificationStatus} obj Optional instance to populate.
   * @return {module:model/VerificationStatus} The populated <code>VerificationStatus</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new VerificationStatus();
      if (data.hasOwnProperty('accountId'))
        obj.accountId = ApiClient.convertToType(data['accountId'], 'Number');
      if (data.hasOwnProperty('reason'))
        obj.reason = ApiClient.convertToType(data['reason'], 'String');
      if (data.hasOwnProperty('verificationStatus'))
        obj.verificationStatus = ApiClient.convertToType(data['verificationStatus'], 'String');
      if (data.hasOwnProperty('providerAccountId'))
        obj.providerAccountId = ApiClient.convertToType(data['providerAccountId'], 'Number');
      if (data.hasOwnProperty('verificationType'))
        obj.verificationType = ApiClient.convertToType(data['verificationType'], 'String');
      if (data.hasOwnProperty('account'))
        obj.account = VerificationAccount.constructFromObject(data['account']);
      if (data.hasOwnProperty('remainingAttempts'))
        obj.remainingAttempts = ApiClient.convertToType(data['remainingAttempts'], 'Number');
      if (data.hasOwnProperty('verificationDate'))
        obj.verificationDate = ApiClient.convertToType(data['verificationDate'], 'String');
      if (data.hasOwnProperty('verificationId'))
        obj.verificationId = ApiClient.convertToType(data['verificationId'], 'Number');
    }
    return obj;
  }
}

/**
 * Unique identifier for the account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
 * @member {Number} accountId
 */
VerificationStatus.prototype.accountId = undefined;

/**
 * Allowed values for the <code>reason</code> property.
 * @enum {String}
 * @readonly
 */
VerificationStatus.ReasonEnum = {
  /**
   * value: "DATA_NOT_AVAILABLE"
   * @const
   */
  DATA_NOT_AVAILABLE: "DATA_NOT_AVAILABLE",

  /**
   * value: "ACCOUNT_HOLDER_MISMATCH"
   * @const
   */
  ACCOUNT_HOLDER_MISMATCH: "ACCOUNT_HOLDER_MISMATCH",

  /**
   * value: "FULL_ACCOUNT_NUMBER_AND_BANK_TRANSFER_CODE_NOT_AVAILABLE"
   * @const
   */
  FULL_ACCOUNT_NUMBER_AND_BANK_TRANSFER_CODE_NOT_AVAILABLE: "FULL_ACCOUNT_NUMBER_AND_BANK_TRANSFER_CODE_NOT_AVAILABLE",

  /**
   * value: "FULL_ACCOUNT_NUMBER_NOT_AVAILABLE"
   * @const
   */
  FULL_ACCOUNT_NUMBER_NOT_AVAILABLE: "FULL_ACCOUNT_NUMBER_NOT_AVAILABLE",

  /**
   * value: "BANK_TRANSFER_CODE_NOT_AVAILABLE"
   * @const
   */
  BANK_TRANSFER_CODE_NOT_AVAILABLE: "BANK_TRANSFER_CODE_NOT_AVAILABLE",

  /**
   * value: "EXPIRED"
   * @const
   */
  EXPIRED: "EXPIRED",

  /**
   * value: "DATA_MISMATCH"
   * @const
   */
  DATA_MISMATCH: "DATA_MISMATCH",

  /**
   * value: "INSTRUCTION_GENERATION_ERROR"
   * @const
   */
  INSTRUCTION_GENERATION_ERROR: "INSTRUCTION_GENERATION_ERROR"
};
/**
 * The reason the account verification failed.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
 * @member {module:model/VerificationStatus.ReasonEnum} reason
 */
VerificationStatus.prototype.reason = undefined;

/**
 * Allowed values for the <code>verificationStatus</code> property.
 * @enum {String}
 * @readonly
 */
VerificationStatus.VerificationStatusEnum = {
  /**
   * value: "INITIATED"
   * @const
   */
  INITIATED: "INITIATED",

  /**
   * value: "DEPOSITED"
   * @const
   */
  DEPOSITED: "DEPOSITED",

  /**
   * value: "SUCCESS"
   * @const
   */
  SUCCESS: "SUCCESS",

  /**
   * value: "FAILED"
   * @const
   */
  FAILED: "FAILED"
};
/**
 * The status of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b>
 * @member {module:model/VerificationStatus.VerificationStatusEnum} verificationStatus
 */
VerificationStatus.prototype.verificationStatus = undefined;

/**
 * Unique identifier for the provider account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
 * @member {Number} providerAccountId
 */
VerificationStatus.prototype.providerAccountId = undefined;

/**
 * Allowed values for the <code>verificationType</code> property.
 * @enum {String}
 * @readonly
 */
VerificationStatus.VerificationTypeEnum = {
  /**
   * value: "MATCHING"
   * @const
   */
  MATCHING: "MATCHING",

  /**
   * value: "CHALLENGE_DEPOSIT"
   * @const
   */
  CHALLENGE_DEPOSIT: "CHALLENGE_DEPOSIT"
};
/**
 * The account verification type.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b>
 * @member {module:model/VerificationStatus.VerificationTypeEnum} verificationType
 */
VerificationStatus.prototype.verificationType = undefined;

/**
 * @member {module:model/VerificationAccount} account
 */
VerificationStatus.prototype.account = undefined;

/**
 * @member {Number} remainingAttempts
 */
VerificationStatus.prototype.remainingAttempts = undefined;

/**
 * The date of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
 * @member {String} verificationDate
 */
VerificationStatus.prototype.verificationDate = undefined;

/**
 * Unique identifier for the verification request.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
 * @member {Number} verificationId
 */
VerificationStatus.prototype.verificationId = undefined;

