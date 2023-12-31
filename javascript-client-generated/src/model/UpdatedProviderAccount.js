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
import {AccountDataset} from './AccountDataset';
import {LoginForm} from './LoginForm';

/**
 * The UpdatedProviderAccount model module.
 * @module model/UpdatedProviderAccount
 * @version 1.1.0
 */
export class UpdatedProviderAccount {
  /**
   * Constructs a new <code>UpdatedProviderAccount</code>.
   * @alias module:model/UpdatedProviderAccount
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>UpdatedProviderAccount</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UpdatedProviderAccount} obj Optional instance to populate.
   * @return {module:model/UpdatedProviderAccount} The populated <code>UpdatedProviderAccount</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new UpdatedProviderAccount();
      if (data.hasOwnProperty('lastUpdated'))
        obj.lastUpdated = ApiClient.convertToType(data['lastUpdated'], 'String');
      if (data.hasOwnProperty('loginForm'))
        obj.loginForm = ApiClient.convertToType(data['loginForm'], [LoginForm]);
      if (data.hasOwnProperty('createdDate'))
        obj.createdDate = ApiClient.convertToType(data['createdDate'], 'String');
      if (data.hasOwnProperty('aggregationSource'))
        obj.aggregationSource = ApiClient.convertToType(data['aggregationSource'], 'String');
      if (data.hasOwnProperty('oauthMigrationStatus'))
        obj.oauthMigrationStatus = ApiClient.convertToType(data['oauthMigrationStatus'], 'String');
      if (data.hasOwnProperty('providerId'))
        obj.providerId = ApiClient.convertToType(data['providerId'], 'Number');
      if (data.hasOwnProperty('requestId'))
        obj.requestId = ApiClient.convertToType(data['requestId'], 'String');
      if (data.hasOwnProperty('isManual'))
        obj.isManual = ApiClient.convertToType(data['isManual'], 'Boolean');
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'Number');
      if (data.hasOwnProperty('dataset'))
        obj.dataset = ApiClient.convertToType(data['dataset'], [AccountDataset]);
      if (data.hasOwnProperty('status'))
        obj.status = ApiClient.convertToType(data['status'], 'String');
    }
    return obj;
  }
}

/**
 * Indicate when the providerAccount is last updated successfully.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul>
 * @member {String} lastUpdated
 */
UpdatedProviderAccount.prototype.lastUpdated = undefined;

/**
 * This entity gets returned in the response for only MFA based provider accounts during the add/update account polling process. This indicates that the MFA information is expected from the user to complete the process. This represents the structure of MFA form that is displayed to the user in the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
 * @member {Array.<module:model/LoginForm>} loginForm
 */
UpdatedProviderAccount.prototype.loginForm = undefined;

/**
 * The date on when the provider account is created in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {String} createdDate
 */
UpdatedProviderAccount.prototype.createdDate = undefined;

/**
 * Allowed values for the <code>aggregationSource</code> property.
 * @enum {String}
 * @readonly
 */
UpdatedProviderAccount.AggregationSourceEnum = {
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
 * The source through which the providerAccount is added in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
 * @member {module:model/UpdatedProviderAccount.AggregationSourceEnum} aggregationSource
 */
UpdatedProviderAccount.prototype.aggregationSource = undefined;

/**
 * Allowed values for the <code>oauthMigrationStatus</code> property.
 * @enum {String}
 * @readonly
 */
UpdatedProviderAccount.OauthMigrationStatusEnum = {
  /**
   * value: "IN_PROGRESS"
   * @const
   */
  IN_PROGRESS: "IN_PROGRESS",

  /**
   * value: "TO_BE_MIGRATED"
   * @const
   */
  TO_BE_MIGRATED: "TO_BE_MIGRATED",

  /**
   * value: "COMPLETED"
   * @const
   */
  COMPLETED: "COMPLETED",

  /**
   * value: "MIGRATED"
   * @const
   */
  MIGRATED: "MIGRATED"
};
/**
 * Indicates the migration status of the provider account from screen-scraping provider to the Open Banking provider. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>GET providerAccounts/{providerAccountId}</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {module:model/UpdatedProviderAccount.OauthMigrationStatusEnum} oauthMigrationStatus
 */
UpdatedProviderAccount.prototype.oauthMigrationStatus = undefined;

/**
 * Unique identifier for the provider resource. This denotes the provider for which the provider account id is generated by the user.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {Number} providerId
 */
UpdatedProviderAccount.prototype.providerId = undefined;

/**
 * Unique id generated to indicate the request.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
 * @member {String} requestId
 */
UpdatedProviderAccount.prototype.requestId = undefined;

/**
 * Indicates whether account is a manual or aggregated provider account.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {Boolean} isManual
 */
UpdatedProviderAccount.prototype.isManual = undefined;

/**
 * Unique identifier for the provider account resource. This is created during account addition.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {Number} id
 */
UpdatedProviderAccount.prototype.id = undefined;

/**
 * Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
 * @member {Array.<module:model/AccountDataset>} dataset
 */
UpdatedProviderAccount.prototype.dataset = undefined;

/**
 * Allowed values for the <code>status</code> property.
 * @enum {String}
 * @readonly
 */
UpdatedProviderAccount.StatusEnum = {
  /**
   * value: "LOGIN_IN_PROGRESS"
   * @const
   */
  LOGIN_IN_PROGRESS: "LOGIN_IN_PROGRESS",

  /**
   * value: "USER_INPUT_REQUIRED"
   * @const
   */
  USER_INPUT_REQUIRED: "USER_INPUT_REQUIRED",

  /**
   * value: "IN_PROGRESS"
   * @const
   */
  IN_PROGRESS: "IN_PROGRESS",

  /**
   * value: "PARTIAL_SUCCESS"
   * @const
   */
  PARTIAL_SUCCESS: "PARTIAL_SUCCESS",

  /**
   * value: "SUCCESS"
   * @const
   */
  SUCCESS: "SUCCESS",

  /**
   * value: "FAILED"
   * @const
   */
  FAILED: "FAILED",

  /**
   * value: "MIGRATION_IN_PROGRESS"
   * @const
   */
  MIGRATION_IN_PROGRESS: "MIGRATION_IN_PROGRESS"
};
/**
 * The status of last update attempted for the account. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
 * @member {module:model/UpdatedProviderAccount.StatusEnum} status
 */
UpdatedProviderAccount.prototype.status = undefined;

