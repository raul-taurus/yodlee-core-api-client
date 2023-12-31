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
import {Option} from './Option';

/**
 * The Field model module.
 * @module model/Field
 * @version 1.1.0
 */
export class Field {
  /**
   * Constructs a new <code>Field</code>.
   * @alias module:model/Field
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>Field</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Field} obj Optional instance to populate.
   * @return {module:model/Field} The populated <code>Field</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Field();
      if (data.hasOwnProperty('image'))
        obj.image = ApiClient.convertToType(data['image'], 'String');
      if (data.hasOwnProperty('prefix'))
        obj.prefix = ApiClient.convertToType(data['prefix'], 'String');
      if (data.hasOwnProperty('minLength'))
        obj.minLength = ApiClient.convertToType(data['minLength'], 'Number');
      if (data.hasOwnProperty('valueEditable'))
        obj.valueEditable = ApiClient.convertToType(data['valueEditable'], 'String');
      if (data.hasOwnProperty('isOptional'))
        obj.isOptional = ApiClient.convertToType(data['isOptional'], 'Boolean');
      if (data.hasOwnProperty('suffix'))
        obj.suffix = ApiClient.convertToType(data['suffix'], 'String');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
      if (data.hasOwnProperty('isValueProvided'))
        obj.isValueProvided = ApiClient.convertToType(data['isValueProvided'], 'Boolean');
      if (data.hasOwnProperty('name'))
        obj.name = ApiClient.convertToType(data['name'], 'String');
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'String');
      if (data.hasOwnProperty('value'))
        obj.value = ApiClient.convertToType(data['value'], 'String');
      if (data.hasOwnProperty('maxLength'))
        obj.maxLength = ApiClient.convertToType(data['maxLength'], 'Number');
      if (data.hasOwnProperty('option'))
        obj.option = ApiClient.convertToType(data['option'], [Option]);
    }
    return obj;
  }
}

/**
 * Image displayed at the endsite.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul>
 * @member {String} image
 */
Field.prototype.image = undefined;

/**
 * The prefix string that has to be displayed before the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} prefix
 */
Field.prototype.prefix = undefined;

/**
 * The minimum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {Number} minLength
 */
Field.prototype.minLength = undefined;

/**
 * Indicates whether the field is editable or not.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} valueEditable
 */
Field.prototype.valueEditable = undefined;

/**
 * Indicates if a field is an optional field or a mandatory field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {Boolean} isOptional
 */
Field.prototype.isOptional = undefined;

/**
 * The suffix string that has to be displayed next to the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} suffix
 */
Field.prototype.suffix = undefined;

/**
 * Allowed values for the <code>type</code> property.
 * @enum {String}
 * @readonly
 */
Field.TypeEnum = {
  /**
   * value: "text"
   * @const
   */
  text: "text",

  /**
   * value: "password"
   * @const
   */
  password: "password",

  /**
   * value: "options"
   * @const
   */
  options: "options",

  /**
   * value: "checkbox"
   * @const
   */
  checkbox: "checkbox",

  /**
   * value: "radio"
   * @const
   */
  radio: "radio",

  /**
   * value: "image"
   * @const
   */
  image: "image",

  /**
   * value: "option"
   * @const
   */
  option: "option"
};
/**
 * This indicates the display type of the field. For example, text box, image, etc. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul><b>Applicable Values</b><br>
 * @member {module:model/Field.TypeEnum} type
 */
Field.prototype.type = undefined;

/**
 * Indicates that the answer to the security question already exists in the Yodlee system.Persuading the user to provide the answer to the security question again during the edit-credential flow can be avoided.<br><br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=questions</li><li>GET providerAccounts/{providerAccountId}? include=questions</li></ul>
 * @member {Boolean} isValueProvided
 */
Field.prototype.isValueProvided = undefined;

/**
 * Name of the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} name
 */
Field.prototype.name = undefined;

/**
 * Identifier for the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} id
 */
Field.prototype.id = undefined;

/**
 * Value expected from the user for the field. This will be blank and is expected to be filled and sent back when submitting the login or MFA information.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {String} value
 */
Field.prototype.value = undefined;

/**
 * The maximum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {Number} maxLength
 */
Field.prototype.maxLength = undefined;

/**
 * Provides the different values that are available for the user to choose. This field is applicable for drop-down or radio field types.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
 * @member {Array.<module:model/Option>} option
 */
Field.prototype.option = undefined;

