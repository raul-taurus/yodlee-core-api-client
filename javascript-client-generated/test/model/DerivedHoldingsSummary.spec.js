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
    describe('DerivedHoldingsSummary', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.DerivedHoldingsSummary();
      });

      it('should create an instance of DerivedHoldingsSummary', function() {
        // TODO: update the code to test DerivedHoldingsSummary
        expect(instance).to.be.a(YodleeCoreApis.DerivedHoldingsSummary);
      });

      it('should have the property holding (base name: "holding")', function() {
        // TODO: update the code to test the property holding
        expect(instance).to.have.property('holding');
        // expect(instance.holding).to.be(expectedValueLiteral);
      });

      it('should have the property classificationType (base name: "classificationType")', function() {
        // TODO: update the code to test the property classificationType
        expect(instance).to.have.property('classificationType');
        // expect(instance.classificationType).to.be(expectedValueLiteral);
      });

      it('should have the property classificationValue (base name: "classificationValue")', function() {
        // TODO: update the code to test the property classificationValue
        expect(instance).to.have.property('classificationValue');
        // expect(instance.classificationValue).to.be(expectedValueLiteral);
      });

      it('should have the property value (base name: "value")', function() {
        // TODO: update the code to test the property value
        expect(instance).to.have.property('value');
        // expect(instance.value).to.be(expectedValueLiteral);
      });

      it('should have the property account (base name: "account")', function() {
        // TODO: update the code to test the property account
        expect(instance).to.have.property('account');
        // expect(instance.account).to.be(expectedValueLiteral);
      });

    });
  });

}));
