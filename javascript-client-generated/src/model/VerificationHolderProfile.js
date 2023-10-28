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
import {AbstractAddress} from './AbstractAddress';
import {Email} from './Email';
import {PhoneNumber} from './PhoneNumber';
import {VerificationHolder} from './VerificationHolder';

/**
 * The VerificationHolderProfile model module.
 * @module model/VerificationHolderProfile
 * @version 1.1.0
 */
export class VerificationHolderProfile {
  /**
   * Constructs a new <code>VerificationHolderProfile</code>.
   * @alias module:model/VerificationHolderProfile
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>VerificationHolderProfile</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VerificationHolderProfile} obj Optional instance to populate.
   * @return {module:model/VerificationHolderProfile} The populated <code>VerificationHolderProfile</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new VerificationHolderProfile();
      if (data.hasOwnProperty('accountId'))
        obj.accountId = ApiClient.convertToType(data['accountId'], 'Number');
      if (data.hasOwnProperty('address'))
        obj.address = ApiClient.convertToType(data['address'], [AbstractAddress]);
      if (data.hasOwnProperty('phoneNumber'))
        obj.phoneNumber = ApiClient.convertToType(data['phoneNumber'], [PhoneNumber]);
      if (data.hasOwnProperty('providerAccountId'))
        obj.providerAccountId = ApiClient.convertToType(data['providerAccountId'], 'Number');
      if (data.hasOwnProperty('holder'))
        obj.holder = ApiClient.convertToType(data['holder'], [VerificationHolder]);
      if (data.hasOwnProperty('email'))
        obj.email = ApiClient.convertToType(data['email'], [Email]);
    }
    return obj;
  }
}

/**
 * The primary key of the account resource and the unique identifier for the account
 * @member {Number} accountId
 */
VerificationHolderProfile.prototype.accountId = undefined;

/**
 * The account holder's address available at the profile and account levels
 * @member {Array.<module:model/AbstractAddress>} address
 */
VerificationHolderProfile.prototype.address = undefined;

/**
 * The account holder's phone number available at the profile and account levels
 * @member {Array.<module:model/PhoneNumber>} phoneNumber
 */
VerificationHolderProfile.prototype.phoneNumber = undefined;

/**
 * The primary key of the provider account resource
 * @member {Number} providerAccountId
 */
VerificationHolderProfile.prototype.providerAccountId = undefined;

/**
 * The holder entity is account-specific and captures the ownership status and the name details of the user
 * @member {Array.<module:model/VerificationHolder>} holder
 */
VerificationHolderProfile.prototype.holder = undefined;

/**
 * The account holder's email ID available at the profile and account levels
 * @member {Array.<module:model/Email>} email
 */
VerificationHolderProfile.prototype.email = undefined;

