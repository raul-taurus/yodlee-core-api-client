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
    describe('Attribute', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.Attribute();
      });

      it('should create an instance of Attribute', function() {
        // TODO: update the code to test Attribute
        expect(instance).to.be.a(YodleeCoreApis.Attribute);
      });

      it('should have the property container (base name: "container")', function() {
        // TODO: update the code to test the property container
        expect(instance).to.have.property('container');
        // expect(instance.container).to.be(expectedValueLiteral);
      });

      it('should have the property fromDate (base name: "fromDate")', function() {
        // TODO: update the code to test the property fromDate
        expect(instance).to.have.property('fromDate');
        // expect(instance.fromDate).to.be(expectedValueLiteral);
      });

      it('should have the property toFinYear (base name: "toFinYear")', function() {
        // TODO: update the code to test the property toFinYear
        expect(instance).to.have.property('toFinYear');
        // expect(instance.toFinYear).to.be(expectedValueLiteral);
      });

      it('should have the property fromFinYear (base name: "fromFinYear")', function() {
        // TODO: update the code to test the property fromFinYear
        expect(instance).to.have.property('fromFinYear');
        // expect(instance.fromFinYear).to.be(expectedValueLiteral);
      });

      it('should have the property containerAttributes (base name: "containerAttributes")', function() {
        // TODO: update the code to test the property containerAttributes
        expect(instance).to.have.property('containerAttributes');
        // expect(instance.containerAttributes).to.be(expectedValueLiteral);
      });

      it('should have the property toDate (base name: "toDate")', function() {
        // TODO: update the code to test the property toDate
        expect(instance).to.have.property('toDate');
        // expect(instance.toDate).to.be(expectedValueLiteral);
      });

      it('should have the property name (base name: "name")', function() {
        // TODO: update the code to test the property name
        expect(instance).to.have.property('name');
        // expect(instance.name).to.be(expectedValueLiteral);
      });

    });
  });

}));
