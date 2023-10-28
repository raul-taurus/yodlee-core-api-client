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
    describe('DataExtractsHolding', function() {
      beforeEach(function() {
        instance = new YodleeCoreApis.DataExtractsHolding();
      });

      it('should create an instance of DataExtractsHolding', function() {
        // TODO: update the code to test DataExtractsHolding
        expect(instance).to.be.a(YodleeCoreApis.DataExtractsHolding);
      });

      it('should have the property symbol (base name: "symbol")', function() {
        // TODO: update the code to test the property symbol
        expect(instance).to.have.property('symbol');
        // expect(instance.symbol).to.be(expectedValueLiteral);
      });

      it('should have the property exercisedQuantity (base name: "exercisedQuantity")', function() {
        // TODO: update the code to test the property exercisedQuantity
        expect(instance).to.have.property('exercisedQuantity');
        // expect(instance.exercisedQuantity).to.be(expectedValueLiteral);
      });

      it('should have the property cusipNumber (base name: "cusipNumber")', function() {
        // TODO: update the code to test the property cusipNumber
        expect(instance).to.have.property('cusipNumber');
        // expect(instance.cusipNumber).to.be(expectedValueLiteral);
      });

      it('should have the property vestedQuantity (base name: "vestedQuantity")', function() {
        // TODO: update the code to test the property vestedQuantity
        expect(instance).to.have.property('vestedQuantity');
        // expect(instance.vestedQuantity).to.be(expectedValueLiteral);
      });

      it('should have the property description (base name: "description")', function() {
        // TODO: update the code to test the property description
        expect(instance).to.have.property('description');
        // expect(instance.description).to.be(expectedValueLiteral);
      });

      it('should have the property unvestedValue (base name: "unvestedValue")', function() {
        // TODO: update the code to test the property unvestedValue
        expect(instance).to.have.property('unvestedValue');
        // expect(instance.unvestedValue).to.be(expectedValueLiteral);
      });

      it('should have the property securityStyle (base name: "securityStyle")', function() {
        // TODO: update the code to test the property securityStyle
        expect(instance).to.have.property('securityStyle');
        // expect(instance.securityStyle).to.be(expectedValueLiteral);
      });

      it('should have the property vestedValue (base name: "vestedValue")', function() {
        // TODO: update the code to test the property vestedValue
        expect(instance).to.have.property('vestedValue');
        // expect(instance.vestedValue).to.be(expectedValueLiteral);
      });

      it('should have the property optionType (base name: "optionType")', function() {
        // TODO: update the code to test the property optionType
        expect(instance).to.have.property('optionType');
        // expect(instance.optionType).to.be(expectedValueLiteral);
      });

      it('should have the property lastUpdated (base name: "lastUpdated")', function() {
        // TODO: update the code to test the property lastUpdated
        expect(instance).to.have.property('lastUpdated');
        // expect(instance.lastUpdated).to.be(expectedValueLiteral);
      });

      it('should have the property associatedProviderAccountId (base name: "associatedProviderAccountId")', function() {
        // TODO: update the code to test the property associatedProviderAccountId
        expect(instance).to.have.property('associatedProviderAccountId');
        // expect(instance.associatedProviderAccountId).to.be(expectedValueLiteral);
      });

      it('should have the property matchStatus (base name: "matchStatus")', function() {
        // TODO: update the code to test the property matchStatus
        expect(instance).to.have.property('matchStatus');
        // expect(instance.matchStatus).to.be(expectedValueLiteral);
      });

      it('should have the property holdingType (base name: "holdingType")', function() {
        // TODO: update the code to test the property holdingType
        expect(instance).to.have.property('holdingType');
        // expect(instance.holdingType).to.be(expectedValueLiteral);
      });

      it('should have the property maturityDate (base name: "maturityDate")', function() {
        // TODO: update the code to test the property maturityDate
        expect(instance).to.have.property('maturityDate');
        // expect(instance.maturityDate).to.be(expectedValueLiteral);
      });

      it('should have the property price (base name: "price")', function() {
        // TODO: update the code to test the property price
        expect(instance).to.have.property('price');
        // expect(instance.price).to.be(expectedValueLiteral);
      });

      it('should have the property term (base name: "term")', function() {
        // TODO: update the code to test the property term
        expect(instance).to.have.property('term');
        // expect(instance.term).to.be(expectedValueLiteral);
      });

      it('should have the property contractQuantity (base name: "contractQuantity")', function() {
        // TODO: update the code to test the property contractQuantity
        expect(instance).to.have.property('contractQuantity');
        // expect(instance.contractQuantity).to.be(expectedValueLiteral);
      });

      it('should have the property id (base name: "id")', function() {
        // TODO: update the code to test the property id
        expect(instance).to.have.property('id');
        // expect(instance.id).to.be(expectedValueLiteral);
      });

      it('should have the property isShort (base name: "isShort")', function() {
        // TODO: update the code to test the property isShort
        expect(instance).to.have.property('isShort');
        // expect(instance.isShort).to.be(expectedValueLiteral);
      });

      it('should have the property value (base name: "value")', function() {
        // TODO: update the code to test the property value
        expect(instance).to.have.property('value');
        // expect(instance.value).to.be(expectedValueLiteral);
      });

      it('should have the property expirationDate (base name: "expirationDate")', function() {
        // TODO: update the code to test the property expirationDate
        expect(instance).to.have.property('expirationDate');
        // expect(instance.expirationDate).to.be(expectedValueLiteral);
      });

      it('should have the property interestRate (base name: "interestRate")', function() {
        // TODO: update the code to test the property interestRate
        expect(instance).to.have.property('interestRate');
        // expect(instance.interestRate).to.be(expectedValueLiteral);
      });

      it('should have the property quantity (base name: "quantity")', function() {
        // TODO: update the code to test the property quantity
        expect(instance).to.have.property('quantity');
        // expect(instance.quantity).to.be(expectedValueLiteral);
      });

      it('should have the property accruedInterest (base name: "accruedInterest")', function() {
        // TODO: update the code to test the property accruedInterest
        expect(instance).to.have.property('accruedInterest');
        // expect(instance.accruedInterest).to.be(expectedValueLiteral);
      });

      it('should have the property grantDate (base name: "grantDate")', function() {
        // TODO: update the code to test the property grantDate
        expect(instance).to.have.property('grantDate');
        // expect(instance.grantDate).to.be(expectedValueLiteral);
      });

      it('should have the property sedol (base name: "sedol")', function() {
        // TODO: update the code to test the property sedol
        expect(instance).to.have.property('sedol');
        // expect(instance.sedol).to.be(expectedValueLiteral);
      });

      it('should have the property vestedSharesExercisable (base name: "vestedSharesExercisable")', function() {
        // TODO: update the code to test the property vestedSharesExercisable
        expect(instance).to.have.property('vestedSharesExercisable');
        // expect(instance.vestedSharesExercisable).to.be(expectedValueLiteral);
      });

      it('should have the property spread (base name: "spread")', function() {
        // TODO: update the code to test the property spread
        expect(instance).to.have.property('spread');
        // expect(instance.spread).to.be(expectedValueLiteral);
      });

      it('should have the property accountId (base name: "accountId")', function() {
        // TODO: update the code to test the property accountId
        expect(instance).to.have.property('accountId');
        // expect(instance.accountId).to.be(expectedValueLiteral);
      });

      it('should have the property enrichedDescription (base name: "enrichedDescription")', function() {
        // TODO: update the code to test the property enrichedDescription
        expect(instance).to.have.property('enrichedDescription');
        // expect(instance.enrichedDescription).to.be(expectedValueLiteral);
      });

      it('should have the property couponRate (base name: "couponRate")', function() {
        // TODO: update the code to test the property couponRate
        expect(instance).to.have.property('couponRate');
        // expect(instance.couponRate).to.be(expectedValueLiteral);
      });

      it('should have the property createdDate (base name: "createdDate")', function() {
        // TODO: update the code to test the property createdDate
        expect(instance).to.have.property('createdDate');
        // expect(instance.createdDate).to.be(expectedValueLiteral);
      });

      it('should have the property accruedIncome (base name: "accruedIncome")', function() {
        // TODO: update the code to test the property accruedIncome
        expect(instance).to.have.property('accruedIncome');
        // expect(instance.accruedIncome).to.be(expectedValueLiteral);
      });

      it('should have the property securityType (base name: "securityType")', function() {
        // TODO: update the code to test the property securityType
        expect(instance).to.have.property('securityType');
        // expect(instance.securityType).to.be(expectedValueLiteral);
      });

      it('should have the property providerAccountId (base name: "providerAccountId")', function() {
        // TODO: update the code to test the property providerAccountId
        expect(instance).to.have.property('providerAccountId');
        // expect(instance.providerAccountId).to.be(expectedValueLiteral);
      });

      it('should have the property unvestedQuantity (base name: "unvestedQuantity")', function() {
        // TODO: update the code to test the property unvestedQuantity
        expect(instance).to.have.property('unvestedQuantity');
        // expect(instance.unvestedQuantity).to.be(expectedValueLiteral);
      });

      it('should have the property costBasis (base name: "costBasis")', function() {
        // TODO: update the code to test the property costBasis
        expect(instance).to.have.property('costBasis');
        // expect(instance.costBasis).to.be(expectedValueLiteral);
      });

      it('should have the property vestingDate (base name: "vestingDate")', function() {
        // TODO: update the code to test the property vestingDate
        expect(instance).to.have.property('vestingDate');
        // expect(instance.vestingDate).to.be(expectedValueLiteral);
      });

      it('should have the property isin (base name: "isin")', function() {
        // TODO: update the code to test the property isin
        expect(instance).to.have.property('isin');
        // expect(instance.isin).to.be(expectedValueLiteral);
      });

      it('should have the property strikePrice (base name: "strikePrice")', function() {
        // TODO: update the code to test the property strikePrice
        expect(instance).to.have.property('strikePrice');
        // expect(instance.strikePrice).to.be(expectedValueLiteral);
      });

    });
  });

}));
