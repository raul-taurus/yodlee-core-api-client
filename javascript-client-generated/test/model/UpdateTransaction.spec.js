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
    describe('UpdateTransaction', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.UpdateTransaction();
      });

      it('should create an instance of UpdateTransaction', function() {
        // TODO: update the code to test UpdateTransaction
        expect(instance).to.be.a(YodleeCoreApis.UpdateTransaction);
      });

      it('should have the property categorySource (base name: "categorySource")', function() {
        // TODO: update the code to test the property categorySource
        expect(instance).to.have.property('categorySource');
        // expect(instance.categorySource).to.be(expectedValueLiteral);
      });

      it('should have the property container (base name: "container")', function() {
        // TODO: update the code to test the property container
        expect(instance).to.have.property('container');
        // expect(instance.container).to.be(expectedValueLiteral);
      });

      it('should have the property isPhysical (base name: "isPhysical")', function() {
        // TODO: update the code to test the property isPhysical
        expect(instance).to.have.property('isPhysical');
        // expect(instance.isPhysical).to.be(expectedValueLiteral);
      });

      it('should have the property detailCategoryId (base name: "detailCategoryId")', function() {
        // TODO: update the code to test the property detailCategoryId
        expect(instance).to.have.property('detailCategoryId');
        // expect(instance.detailCategoryId).to.be(expectedValueLiteral);
      });

      it('should have the property description (base name: "description")', function() {
        // TODO: update the code to test the property description
        expect(instance).to.have.property('description');
        // expect(instance.description).to.be(expectedValueLiteral);
      });

      it('should have the property memo (base name: "memo")', function() {
        // TODO: update the code to test the property memo
        expect(instance).to.have.property('memo');
        // expect(instance.memo).to.be(expectedValueLiteral);
      });

      it('should have the property merchantType (base name: "merchantType")', function() {
        // TODO: update the code to test the property merchantType
        expect(instance).to.have.property('merchantType');
        // expect(instance.merchantType).to.be(expectedValueLiteral);
      });

      it('should have the property categoryId (base name: "categoryId")', function() {
        // TODO: update the code to test the property categoryId
        expect(instance).to.have.property('categoryId');
        // expect(instance.categoryId).to.be(expectedValueLiteral);
      });

    });
  });

}));
