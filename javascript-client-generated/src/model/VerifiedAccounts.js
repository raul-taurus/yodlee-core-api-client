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
import {AccountHolder} from './AccountHolder';
import {BankTransferCode} from './BankTransferCode';
import {FullAccountNumberList} from './FullAccountNumberList';
import {Money} from './Money';

/**
 * The VerifiedAccounts model module.
 * @module model/VerifiedAccounts
 * @version 1.1.0
 */
export class VerifiedAccounts {
  /**
   * Constructs a new <code>VerifiedAccounts</code>.
   * @alias module:model/VerifiedAccounts
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>VerifiedAccounts</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VerifiedAccounts} obj Optional instance to populate.
   * @return {module:model/VerifiedAccounts} The populated <code>VerifiedAccounts</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new VerifiedAccounts();
      if (data.hasOwnProperty('accountName'))
        obj.accountName = ApiClient.convertToType(data['accountName'], 'String');
      if (data.hasOwnProperty('verificationStatus'))
        obj.verificationStatus = ApiClient.convertToType(data['verificationStatus'], 'String');
      if (data.hasOwnProperty('accountType'))
        obj.accountType = ApiClient.convertToType(data['accountType'], 'String');
      if (data.hasOwnProperty('currentBalance'))
        obj.currentBalance = Money.constructFromObject(data['currentBalance']);
      if (data.hasOwnProperty('displayedName'))
        obj.displayedName = ApiClient.convertToType(data['displayedName'], 'String');
      if (data.hasOwnProperty('holder'))
        obj.holder = ApiClient.convertToType(data['holder'], [AccountHolder]);
      if (data.hasOwnProperty('accountNumber'))
        obj.accountNumber = ApiClient.convertToType(data['accountNumber'], 'String');
      if (data.hasOwnProperty('classification'))
        obj.classification = ApiClient.convertToType(data['classification'], 'String');
      if (data.hasOwnProperty('availableBalance'))
        obj.availableBalance = Money.constructFromObject(data['availableBalance']);
      if (data.hasOwnProperty('fullAccountNumberList'))
        obj.fullAccountNumberList = FullAccountNumberList.constructFromObject(data['fullAccountNumberList']);
      if (data.hasOwnProperty('accountId'))
        obj.accountId = ApiClient.convertToType(data['accountId'], 'Number');
      if (data.hasOwnProperty('accountAgeClassification'))
        obj.accountAgeClassification = ApiClient.convertToType(data['accountAgeClassification'], 'String');
      if (data.hasOwnProperty('balance'))
        obj.balance = Money.constructFromObject(data['balance']);
      if (data.hasOwnProperty('providerId'))
        obj.providerId = ApiClient.convertToType(data['providerId'], 'String');
      if (data.hasOwnProperty('providerAccountId'))
        obj.providerAccountId = ApiClient.convertToType(data['providerAccountId'], 'Number');
      if (data.hasOwnProperty('CONTAINER'))
        obj.CONTAINER = ApiClient.convertToType(data['CONTAINER'], 'String');
      if (data.hasOwnProperty('isSelected'))
        obj.isSelected = ApiClient.convertToType(data['isSelected'], 'Boolean');
      if (data.hasOwnProperty('cash'))
        obj.cash = Money.constructFromObject(data['cash']);
      if (data.hasOwnProperty('bankTransferCode'))
        obj.bankTransferCode = ApiClient.convertToType(data['bankTransferCode'], [BankTransferCode]);
      if (data.hasOwnProperty('providerName'))
        obj.providerName = ApiClient.convertToType(data['providerName'], 'String');
      if (data.hasOwnProperty('failedReason'))
        obj.failedReason = ApiClient.convertToType(data['failedReason'], 'String');
    }
    return obj;
  }
}

/**
 * The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} accountName
 */
VerifiedAccounts.prototype.accountName = undefined;

/**
 * Allowed values for the <code>verificationStatus</code> property.
 * @enum {String}
 * @readonly
 */
VerifiedAccounts.VerificationStatusEnum = {
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
 * The status of the account verification.
 * @member {module:model/VerifiedAccounts.VerificationStatusEnum} verificationStatus
 */
VerifiedAccounts.prototype.verificationStatus = undefined;

/**
 * The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>MONEY_MARKET</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} accountType
 */
VerifiedAccounts.prototype.accountType = undefined;

/**
 * @member {module:model/Money} currentBalance
 */
VerifiedAccounts.prototype.currentBalance = undefined;

/**
 * The name or identification of the account owner, as it appears at the FI site. <br><b>Note:</b> The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} displayedName
 */
VerifiedAccounts.prototype.displayedName = undefined;

/**
 * Holder details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {Array.<module:model/AccountHolder>} holder
 */
VerifiedAccounts.prototype.holder = undefined;

/**
 * The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank / Investment</b>:<br> The account number for the bank account as it appears at the site.<br>In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} accountNumber
 */
VerifiedAccounts.prototype.accountNumber = undefined;

/**
 * Allowed values for the <code>classification</code> property.
 * @enum {String}
 * @readonly
 */
VerifiedAccounts.ClassificationEnum = {
  /**
   * value: "OTHER"
   * @const
   */
  OTHER: "OTHER",

  /**
   * value: "PERSONAL"
   * @const
   */
  PERSONAL: "PERSONAL",

  /**
   * value: "CORPORATE"
   * @const
   */
  CORPORATE: "CORPORATE",

  /**
   * value: "SMALL_BUSINESS"
   * @const
   */
  SMALL_BUSINESS: "SMALL_BUSINESS",

  /**
   * value: "TRUST"
   * @const
   */
  TRUST: "TRUST",

  /**
   * value: "ADD_ON_CARD"
   * @const
   */
  ADD_ON_CARD: "ADD_ON_CARD",

  /**
   * value: "VIRTUAL_CARD"
   * @const
   */
  VIRTUAL_CARD: "VIRTUAL_CARD"
};
/**
 * The classification of the account such as personal, corporate, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<li>GET /verification/verifiedAccounts</li></ul><b>Applicable Values</b><br>
 * @member {module:model/VerifiedAccounts.ClassificationEnum} classification
 */
VerifiedAccounts.prototype.classification = undefined;

/**
 * @member {module:model/Money} availableBalance
 */
VerifiedAccounts.prototype.availableBalance = undefined;

/**
 * @member {module:model/FullAccountNumberList} fullAccountNumberList
 */
VerifiedAccounts.prototype.fullAccountNumberList = undefined;

/**
 * The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {Number} accountId
 */
VerifiedAccounts.prototype.accountId = undefined;

/**
 * Allowed values for the <code>accountAgeClassification</code> property.
 * @enum {String}
 * @readonly
 */
VerifiedAccounts.AccountAgeClassificationEnum = {
  /**
   * value: "UNCLASSIFIED"
   * @const
   */
  UNCLASSIFIED: "UNCLASSIFIED",

  /**
   * value: "OLD"
   * @const
   */
  OLD: "OLD",

  /**
   * value: "NEW"
   * @const
   */
  NEW: "NEW",

  /**
   * value: "RECENT"
   * @const
   */
  RECENT: "RECENT"
};
/**
 * Attribute to return the classification of the account age by specifying whether the account is old/new/recent as relevant for a verification use case. If it could not be classified into any one of these values, the attribute would return the value as 'unclassified'
 * @member {module:model/VerifiedAccounts.AccountAgeClassificationEnum} accountAgeClassification
 */
VerifiedAccounts.prototype.accountAgeClassification = undefined;

/**
 * @member {module:model/Money} balance
 */
VerifiedAccounts.prototype.balance = undefined;

/**
 * Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} providerId
 */
VerifiedAccounts.prototype.providerId = undefined;

/**
 * The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {Number} providerAccountId
 */
VerifiedAccounts.prototype.providerAccountId = undefined;

/**
 * Allowed values for the <code>CONTAINER</code> property.
 * @enum {String}
 * @readonly
 */
VerifiedAccounts.CONTAINEREnum = {
  /**
   * value: "bank"
   * @const
   */
  bank: "bank",

  /**
   * value: "investment"
   * @const
   */
  investment: "investment"
};
/**
 * The type of service. E.g., Bank, Investment <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</ul><b>Applicable Values</b><br>
 * @member {module:model/VerifiedAccounts.CONTAINEREnum} CONTAINER
 */
VerifiedAccounts.prototype.CONTAINER = undefined;

/**
 * Indicates if an account is selected by the user in the FastLink 4 application
 * @member {Boolean} isSelected
 */
VerifiedAccounts.prototype.isSelected = undefined;

/**
 * @member {module:model/Money} cash
 */
VerifiedAccounts.prototype.cash = undefined;

/**
 * Bank and branch identification information.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {Array.<module:model/BankTransferCode>} bankTransferCode
 */
VerifiedAccounts.prototype.bankTransferCode = undefined;

/**
 * Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
 * @member {String} providerName
 */
VerifiedAccounts.prototype.providerName = undefined;

/**
 * Allowed values for the <code>failedReason</code> property.
 * @enum {String}
 * @readonly
 */
VerifiedAccounts.FailedReasonEnum = {
  /**
   * value: "REQUIRED_DATA_NOT_AVAILABLE"
   * @const
   */
  REQUIRED_DATA_NOT_AVAILABLE: "REQUIRED_DATA_NOT_AVAILABLE",

  /**
   * value: "MATCHING_FAILED"
   * @const
   */
  MATCHING_FAILED: "MATCHING_FAILED"
};
/**
 * The reason for the verification failure of the account.
 * @member {module:model/VerifiedAccounts.FailedReasonEnum} failedReason
 */
VerifiedAccounts.prototype.failedReason = undefined;
