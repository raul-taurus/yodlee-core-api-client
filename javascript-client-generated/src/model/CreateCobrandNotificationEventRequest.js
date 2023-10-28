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
import {CreateCobrandNotificationEvent} from './CreateCobrandNotificationEvent';

/**
 * The CreateCobrandNotificationEventRequest model module.
 * @module model/CreateCobrandNotificationEventRequest
 * @version 1.1.0
 */
export class CreateCobrandNotificationEventRequest {
  /**
   * Constructs a new <code>CreateCobrandNotificationEventRequest</code>.
   * @alias module:model/CreateCobrandNotificationEventRequest
   * @class
   * @param event {module:model/CreateCobrandNotificationEvent} 
   */
  constructor(event) {
    this.event = event;
  }

  /**
   * Constructs a <code>CreateCobrandNotificationEventRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CreateCobrandNotificationEventRequest} obj Optional instance to populate.
   * @return {module:model/CreateCobrandNotificationEventRequest} The populated <code>CreateCobrandNotificationEventRequest</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new CreateCobrandNotificationEventRequest();
      if (data.hasOwnProperty('event'))
        obj.event = CreateCobrandNotificationEvent.constructFromObject(data['event']);
    }
    return obj;
  }
}

/**
 * @member {module:model/CreateCobrandNotificationEvent} event
 */
CreateCobrandNotificationEventRequest.prototype.event = undefined;

