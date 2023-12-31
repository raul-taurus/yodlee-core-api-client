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
import {Name} from './Name';
import {UserAddress} from './UserAddress';
import {UserResponsePreferences} from './UserResponsePreferences';

/**
 * The UserDetail model module.
 * @module model/UserDetail
 * @version 1.1.0
 */
export class UserDetail {
  /**
   * Constructs a new <code>UserDetail</code>.
   * @alias module:model/UserDetail
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>UserDetail</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UserDetail} obj Optional instance to populate.
   * @return {module:model/UserDetail} The populated <code>UserDetail</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new UserDetail();
      if (data.hasOwnProperty('preferences'))
        obj.preferences = UserResponsePreferences.constructFromObject(data['preferences']);
      if (data.hasOwnProperty('address'))
        obj.address = UserAddress.constructFromObject(data['address']);
      if (data.hasOwnProperty('phoneNumber'))
        obj.phoneNumber = ApiClient.convertToType(data['phoneNumber'], 'String');
      if (data.hasOwnProperty('loginName'))
        obj.loginName = ApiClient.convertToType(data['loginName'], 'String');
      if (data.hasOwnProperty('name'))
        obj.name = Name.constructFromObject(data['name']);
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'Number');
      if (data.hasOwnProperty('roleType'))
        obj.roleType = ApiClient.convertToType(data['roleType'], 'String');
      if (data.hasOwnProperty('email'))
        obj.email = ApiClient.convertToType(data['email'], 'String');
      if (data.hasOwnProperty('segmentName'))
        obj.segmentName = ApiClient.convertToType(data['segmentName'], 'String');
    }
    return obj;
  }
}

/**
 * @member {module:model/UserResponsePreferences} preferences
 */
UserDetail.prototype.preferences = undefined;

/**
 * @member {module:model/UserAddress} address
 */
UserDetail.prototype.address = undefined;

/**
 * @member {String} phoneNumber
 */
UserDetail.prototype.phoneNumber = undefined;

/**
 * The login name of the user used for authentication.<br><br><b>Endpoints</b>:<ul><li>POST user/register</li><li>GET user</li></ul>
 * @member {String} loginName
 */
UserDetail.prototype.loginName = undefined;

/**
 * @member {module:model/Name} name
 */
UserDetail.prototype.name = undefined;

/**
 * The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.<br><br><b>Endpoints</b>:<ul><li>POST user/samlLogin</li><li>POST user/register</li><li>GET user</li></ul>
 * @member {Number} id
 */
UserDetail.prototype.id = undefined;

/**
 * Allowed values for the <code>roleType</code> property.
 * @enum {String}
 * @readonly
 */
UserDetail.RoleTypeEnum = {
  /**
   * value: "INDIVIDUAL"
   * @const
   */
  INDIVIDUAL: "INDIVIDUAL"
};
/**
 * @member {module:model/UserDetail.RoleTypeEnum} roleType
 */
UserDetail.prototype.roleType = undefined;

/**
 * The email address of the user.<br><br><b>Endpoints</b>:<ul><li>GET user</li></ul>
 * @member {String} email
 */
UserDetail.prototype.email = undefined;

/**
 * @member {String} segmentName
 */
UserDetail.prototype.segmentName = undefined;

