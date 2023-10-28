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
(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.YodleeCoreApis);
  }
}(this, function(expect, YodleeCoreApis) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('EvaluateAccountAddress', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.EvaluateAccountAddress();
      });

      it('should create an instance of EvaluateAccountAddress', function() {
        // TODO: update the code to test EvaluateAccountAddress
        expect(instance).to.be.a(YodleeCoreApis.EvaluateAccountAddress);
      });

      it('should have the property zip (base name: "zip")', function() {
        // TODO: update the code to test the property zip
        expect(instance).to.have.property('zip');
        // expect(instance.zip).to.be(expectedValueLiteral);
      });

      it('should have the property country (base name: "country")', function() {
        // TODO: update the code to test the property country
        expect(instance).to.have.property('country');
        // expect(instance.country).to.be(expectedValueLiteral);
      });

      it('should have the property address3 (base name: "address3")', function() {
        // TODO: update the code to test the property address3
        expect(instance).to.have.property('address3');
        // expect(instance.address3).to.be(expectedValueLiteral);
      });

      it('should have the property address2 (base name: "address2")', function() {
        // TODO: update the code to test the property address2
        expect(instance).to.have.property('address2');
        // expect(instance.address2).to.be(expectedValueLiteral);
      });

      it('should have the property city (base name: "city")', function() {
        // TODO: update the code to test the property city
        expect(instance).to.have.property('city');
        // expect(instance.city).to.be(expectedValueLiteral);
      });

      it('should have the property sourceType (base name: "sourceType")', function() {
        // TODO: update the code to test the property sourceType
        expect(instance).to.have.property('sourceType');
        // expect(instance.sourceType).to.be(expectedValueLiteral);
      });

      it('should have the property address1 (base name: "address1")', function() {
        // TODO: update the code to test the property address1
        expect(instance).to.have.property('address1');
        // expect(instance.address1).to.be(expectedValueLiteral);
      });

      it('should have the property street (base name: "street")', function() {
        // TODO: update the code to test the property street
        expect(instance).to.have.property('street');
        // expect(instance.street).to.be(expectedValueLiteral);
      });

      it('should have the property state (base name: "state")', function() {
        // TODO: update the code to test the property state
        expect(instance).to.have.property('state');
        // expect(instance.state).to.be(expectedValueLiteral);
      });

      it('should have the property type (base name: "type")', function() {
        // TODO: update the code to test the property type
        expect(instance).to.have.property('type');
        // expect(instance.type).to.be(expectedValueLiteral);
      });

    });
  });

}));
