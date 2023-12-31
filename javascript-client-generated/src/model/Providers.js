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
import {Capability} from './Capability';
import {ProvidersDataset} from './ProvidersDataset';

/**
 * The Providers model module.
 * @module model/Providers
 * @version 1.1.0
 */
export class Providers {
  /**
   * Constructs a new <code>Providers</code>.
   * @alias module:model/Providers
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>Providers</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Providers} obj Optional instance to populate.
   * @return {module:model/Providers} The populated <code>Providers</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Providers();
      if (data.hasOwnProperty('languageISOCode'))
        obj.languageISOCode = ApiClient.convertToType(data['languageISOCode'], 'String');
      if (data.hasOwnProperty('forgetPasswordUrl'))
        obj.forgetPasswordUrl = ApiClient.convertToType(data['forgetPasswordUrl'], 'String');
      if (data.hasOwnProperty('favicon'))
        obj.favicon = ApiClient.convertToType(data['favicon'], 'String');
      if (data.hasOwnProperty('accountType'))
        obj.accountType = ApiClient.convertToType(data['accountType'], ['String']);
      if (data.hasOwnProperty('countryISOCode'))
        obj.countryISOCode = ApiClient.convertToType(data['countryISOCode'], 'String');
      if (data.hasOwnProperty('isAddedByUser'))
        obj.isAddedByUser = ApiClient.convertToType(data['isAddedByUser'], 'String');
      if (data.hasOwnProperty('PRIORITY'))
        obj.PRIORITY = ApiClient.convertToType(data['PRIORITY'], 'String');
      if (data.hasOwnProperty('associatedProviderIds'))
        obj.associatedProviderIds = ApiClient.convertToType(data['associatedProviderIds'], ['Number']);
      if (data.hasOwnProperty('loginHelp'))
        obj.loginHelp = ApiClient.convertToType(data['loginHelp'], 'String');
      if (data.hasOwnProperty('primaryLanguageISOCode'))
        obj.primaryLanguageISOCode = ApiClient.convertToType(data['primaryLanguageISOCode'], 'String');
      if (data.hasOwnProperty('help'))
        obj.help = ApiClient.convertToType(data['help'], 'String');
      if (data.hasOwnProperty('baseUrl'))
        obj.baseUrl = ApiClient.convertToType(data['baseUrl'], 'String');
      if (data.hasOwnProperty('capability'))
        obj.capability = ApiClient.convertToType(data['capability'], [Capability]);
      if (data.hasOwnProperty('isConsentRequired'))
        obj.isConsentRequired = ApiClient.convertToType(data['isConsentRequired'], 'Boolean');
      if (data.hasOwnProperty('loginUrl'))
        obj.loginUrl = ApiClient.convertToType(data['loginUrl'], 'String');
      if (data.hasOwnProperty('isAutoRefreshEnabled'))
        obj.isAutoRefreshEnabled = ApiClient.convertToType(data['isAutoRefreshEnabled'], 'Boolean');
      if (data.hasOwnProperty('name'))
        obj.name = ApiClient.convertToType(data['name'], 'String');
      if (data.hasOwnProperty('logo'))
        obj.logo = ApiClient.convertToType(data['logo'], 'String');
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'Number');
      if (data.hasOwnProperty('lastModified'))
        obj.lastModified = ApiClient.convertToType(data['lastModified'], 'String');
      if (data.hasOwnProperty('authParameter'))
        obj.authParameter = ApiClient.convertToType(data['authParameter'], ['String']);
      if (data.hasOwnProperty('authType'))
        obj.authType = ApiClient.convertToType(data['authType'], 'String');
      if (data.hasOwnProperty('dataset'))
        obj.dataset = ApiClient.convertToType(data['dataset'], [ProvidersDataset]);
      if (data.hasOwnProperty('status'))
        obj.status = ApiClient.convertToType(data['status'], 'String');
    }
    return obj;
  }
}

/**
 * The language in which the provider details are provided. For example, a site supports two languages English and French. English being the primary language, the provider response will be provided in French depending on the user's locale. The language follows the two letter ISO code.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} languageISOCode
 */
Providers.prototype.languageISOCode = undefined;

/**
 * The forget password URL of the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul>
 * @member {String} forgetPasswordUrl
 */
Providers.prototype.forgetPasswordUrl = undefined;

/**
 * Favicon link of the provider.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} favicon
 */
Providers.prototype.favicon = undefined;

/**
 * Allowed values for the <code>accountType</code> property.
 * @enum {String}
 * @readonly
 */
Providers.AccountTypeEnum = {
  /**
   * value: "CURRENT"
   * @const
   */
  CURRENT: "CURRENT",

  /**
   * value: "BROKERAGE_CASH"
   * @const
   */
  BROKERAGE_CASH: "BROKERAGE_CASH"
};
/**
 * AccountType supported by the provider, eg: Brokerage Cash, Current<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Array.<module:model/Providers.AccountTypeEnum>} accountType
 */
Providers.prototype.accountType = undefined;

/**
 * Country to which the provider belongs.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} countryISOCode
 */
Providers.prototype.countryISOCode = undefined;

/**
 * Indicates that the site has been added by the user at least once.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} isAddedByUser
 */
Providers.prototype.isAddedByUser = undefined;

/**
 * Allowed values for the <code>PRIORITY</code> property.
 * @enum {String}
 * @readonly
 */
Providers.PRIORITYEnum = {
  /**
   * value: "POPULAR"
   * @const
   */
  POPULAR: "POPULAR",

  /**
   * value: "SUGGESTED"
   * @const
   */
  SUGGESTED: "SUGGESTED",

  /**
   * value: "COBRAND"
   * @const
   */
  COBRAND: "COBRAND",

  /**
   * value: "SEARCH"
   * @const
   */
  SEARCH: "SEARCH",

  /**
   * value: "ALL"
   * @const
   */
  ALL: "ALL"
};
/**
 * Indicates the priority for which the service is invoked.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
 * @member {module:model/Providers.PRIORITYEnum} PRIORITY
 */
Providers.prototype.PRIORITY = undefined;

/**
 * The screen-scraping providers that are associated to the Open Banking provider ID.<br><br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul>
 * @member {Array.<Number>} associatedProviderIds
 */
Providers.prototype.associatedProviderIds = undefined;

/**
 * Help text to guide the user to choose the correct provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul>
 * @member {String} loginHelp
 */
Providers.prototype.loginHelp = undefined;

/**
 * The primary language of the site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} primaryLanguageISOCode
 */
Providers.prototype.primaryLanguageISOCode = undefined;

/**
 * Text to guide user through linking an account that belongs to the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} help
 */
Providers.prototype.help = undefined;

/**
 * The base URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} baseUrl
 */
Providers.prototype.baseUrl = undefined;

/**
 * Capability of the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><br><b>Note : </b> capability has been deprecated
 * @member {Array.<module:model/Capability>} capability
 */
Providers.prototype.capability = undefined;

/**
 * Indicates if a provider site requires consent.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Boolean} isConsentRequired
 */
Providers.prototype.isConsentRequired = undefined;

/**
 * The login URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} loginUrl
 */
Providers.prototype.loginUrl = undefined;

/**
 * Indicates if a provider site is auto-refreshed.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Boolean} isAutoRefreshEnabled
 */
Providers.prototype.isAutoRefreshEnabled = undefined;

/**
 * The name of a provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} name
 */
Providers.prototype.name = undefined;

/**
 * The logo link of the provider institution. The link will return the logo in the PNG format.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} logo
 */
Providers.prototype.logo = undefined;

/**
 * Unique identifier for the provider site(e.g., financial institution sites, biller sites, lender sites, etc.).<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Number} id
 */
Providers.prototype.id = undefined;

/**
 * Determines when the provider information was updated by Yodlee. If the customer caches the data, the cache is recommended to be refreshed based on this field.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {String} lastModified
 */
Providers.prototype.lastModified = undefined;

/**
 * Allowed values for the <code>authParameter</code> property.
 * @enum {String}
 * @readonly
 */
Providers.AuthParameterEnum = {
  /**
   * value: "authorizationCode"
   * @const
   */
  authorizationCode: "authorizationCode",

  /**
   * value: "idToken"
   * @const
   */
  idToken: "idToken",

  /**
   * value: "authResponse"
   * @const
   */
  authResponse: "authResponse",

  /**
   * value: "state"
   * @const
   */
  state: "state"
};
/**
 * AuthParameter appears in the response only in case of token-based aggregation sites.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Array.<module:model/Providers.AuthParameterEnum>} authParameter
 */
Providers.prototype.authParameter = undefined;

/**
 * Allowed values for the <code>authType</code> property.
 * @enum {String}
 * @readonly
 */
Providers.AuthTypeEnum = {
  /**
   * value: "OAUTH"
   * @const
   */
  OAUTH: "OAUTH",

  /**
   * value: "CREDENTIALS"
   * @const
   */
  CREDENTIALS: "CREDENTIALS",

  /**
   * value: "MFA_CREDENTIALS"
   * @const
   */
  MFA_CREDENTIALS: "MFA_CREDENTIALS"
};
/**
 * The authentication type enabled at the provider site. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
 * @member {module:model/Providers.AuthTypeEnum} authType
 */
Providers.prototype.authType = undefined;

/**
 * Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {Array.<module:model/ProvidersDataset>} dataset
 */
Providers.prototype.dataset = undefined;

/**
 * Allowed values for the <code>status</code> property.
 * @enum {String}
 * @readonly
 */
Providers.StatusEnum = {
  /**
   * value: "Supported"
   * @const
   */
  supported: "Supported",

  /**
   * value: "Beta"
   * @const
   */
  beta: "Beta",

  /**
   * value: "Unsupported"
   * @const
   */
  unsupported: "Unsupported"
};
/**
 * Determines if the provider is supported for the cobrand (customer), is in the beta stage, etc. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
 * @member {module:model/Providers.StatusEnum} status
 */
Providers.prototype.status = undefined;

