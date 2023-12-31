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
    describe('RewardBalance', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.RewardBalance();
      });

      it('should create an instance of RewardBalance', function() {
        // TODO: update the code to test RewardBalance
        expect(instance).to.be.a(YodleeCoreApis.RewardBalance);
      });

      it('should have the property expiryDate (base name: "expiryDate")', function() {
        // TODO: update the code to test the property expiryDate
        expect(instance).to.have.property('expiryDate');
        // expect(instance.expiryDate).to.be(expectedValueLiteral);
      });

      it('should have the property balanceToReward (base name: "balanceToReward")', function() {
        // TODO: update the code to test the property balanceToReward
        expect(instance).to.have.property('balanceToReward');
        // expect(instance.balanceToReward).to.be(expectedValueLiteral);
      });

      it('should have the property balanceType (base name: "balanceType")', function() {
        // TODO: update the code to test the property balanceType
        expect(instance).to.have.property('balanceType');
        // expect(instance.balanceType).to.be(expectedValueLiteral);
      });

      it('should have the property balance (base name: "balance")', function() {
        // TODO: update the code to test the property balance
        expect(instance).to.have.property('balance');
        // expect(instance.balance).to.be(expectedValueLiteral);
      });

      it('should have the property description (base name: "description")', function() {
        // TODO: update the code to test the property description
        expect(instance).to.have.property('description');
        // expect(instance.description).to.be(expectedValueLiteral);
      });

      it('should have the property balanceToLevel (base name: "balanceToLevel")', function() {
        // TODO: update the code to test the property balanceToLevel
        expect(instance).to.have.property('balanceToLevel');
        // expect(instance.balanceToLevel).to.be(expectedValueLiteral);
      });

      it('should have the property units (base name: "units")', function() {
        // TODO: update the code to test the property units
        expect(instance).to.have.property('units');
        // expect(instance.units).to.be(expectedValueLiteral);
      });

    });
  });

}));
