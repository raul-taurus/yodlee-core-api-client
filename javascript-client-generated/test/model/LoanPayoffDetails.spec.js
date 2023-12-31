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
    describe('LoanPayoffDetails', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.LoanPayoffDetails();
      });

      it('should create an instance of LoanPayoffDetails', function() {
        // TODO: update the code to test LoanPayoffDetails
        expect(instance).to.be.a(YodleeCoreApis.LoanPayoffDetails);
      });

      it('should have the property payByDate (base name: "payByDate")', function() {
        // TODO: update the code to test the property payByDate
        expect(instance).to.have.property('payByDate');
        // expect(instance.payByDate).to.be(expectedValueLiteral);
      });

      it('should have the property payoffAmount (base name: "payoffAmount")', function() {
        // TODO: update the code to test the property payoffAmount
        expect(instance).to.have.property('payoffAmount');
        // expect(instance.payoffAmount).to.be(expectedValueLiteral);
      });

      it('should have the property outstandingBalance (base name: "outstandingBalance")', function() {
        // TODO: update the code to test the property outstandingBalance
        expect(instance).to.have.property('outstandingBalance');
        // expect(instance.outstandingBalance).to.be(expectedValueLiteral);
      });

    });
  });

}));
