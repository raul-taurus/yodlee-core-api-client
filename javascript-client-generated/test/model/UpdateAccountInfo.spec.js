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
    describe('UpdateAccountInfo', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.UpdateAccountInfo();
      });

      it('should create an instance of UpdateAccountInfo', function() {
        // TODO: update the code to test UpdateAccountInfo
        expect(instance).to.be.a(YodleeCoreApis.UpdateAccountInfo);
      });

      it('should have the property container (base name: "container")', function() {
        // TODO: update the code to test the property container
        expect(instance).to.have.property('container');
        // expect(instance.container).to.be(expectedValueLiteral);
      });

      it('should have the property includeInNetWorth (base name: "includeInNetWorth")', function() {
        // TODO: update the code to test the property includeInNetWorth
        expect(instance).to.have.property('includeInNetWorth');
        // expect(instance.includeInNetWorth).to.be(expectedValueLiteral);
      });

      it('should have the property address (base name: "address")', function() {
        // TODO: update the code to test the property address
        expect(instance).to.have.property('address');
        // expect(instance.address).to.be(expectedValueLiteral);
      });

      it('should have the property accountName (base name: "accountName")', function() {
        // TODO: update the code to test the property accountName
        expect(instance).to.have.property('accountName');
        // expect(instance.accountName).to.be(expectedValueLiteral);
      });

      it('should have the property dueDate (base name: "dueDate")', function() {
        // TODO: update the code to test the property dueDate
        expect(instance).to.have.property('dueDate');
        // expect(instance.dueDate).to.be(expectedValueLiteral);
      });

      it('should have the property memo (base name: "memo")', function() {
        // TODO: update the code to test the property memo
        expect(instance).to.have.property('memo');
        // expect(instance.memo).to.be(expectedValueLiteral);
      });

      it('should have the property homeValue (base name: "homeValue")', function() {
        // TODO: update the code to test the property homeValue
        expect(instance).to.have.property('homeValue');
        // expect(instance.homeValue).to.be(expectedValueLiteral);
      });

      it('should have the property accountNumber (base name: "accountNumber")', function() {
        // TODO: update the code to test the property accountNumber
        expect(instance).to.have.property('accountNumber');
        // expect(instance.accountNumber).to.be(expectedValueLiteral);
      });

      it('should have the property frequency (base name: "frequency")', function() {
        // TODO: update the code to test the property frequency
        expect(instance).to.have.property('frequency');
        // expect(instance.frequency).to.be(expectedValueLiteral);
      });

      it('should have the property accountStatus (base name: "accountStatus")', function() {
        // TODO: update the code to test the property accountStatus
        expect(instance).to.have.property('accountStatus');
        // expect(instance.accountStatus).to.be(expectedValueLiteral);
      });

      it('should have the property amountDue (base name: "amountDue")', function() {
        // TODO: update the code to test the property amountDue
        expect(instance).to.have.property('amountDue');
        // expect(instance.amountDue).to.be(expectedValueLiteral);
      });

      it('should have the property linkedAccountIds (base name: "linkedAccountIds")', function() {
        // TODO: update the code to test the property linkedAccountIds
        expect(instance).to.have.property('linkedAccountIds');
        // expect(instance.linkedAccountIds).to.be(expectedValueLiteral);
      });

      it('should have the property balance (base name: "balance")', function() {
        // TODO: update the code to test the property balance
        expect(instance).to.have.property('balance');
        // expect(instance.balance).to.be(expectedValueLiteral);
      });

      it('should have the property isEbillEnrolled (base name: "isEbillEnrolled")', function() {
        // TODO: update the code to test the property isEbillEnrolled
        expect(instance).to.have.property('isEbillEnrolled');
        // expect(instance.isEbillEnrolled).to.be(expectedValueLiteral);
      });

      it('should have the property nickname (base name: "nickname")', function() {
        // TODO: update the code to test the property nickname
        expect(instance).to.have.property('nickname');
        // expect(instance.nickname).to.be(expectedValueLiteral);
      });

    });
  });

}));