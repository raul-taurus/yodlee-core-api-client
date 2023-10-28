/* 
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DataExtractsTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DataExtractsTransactionTests
    {
        // TODO uncomment below to declare an instance variable for DataExtractsTransaction
        //private DataExtractsTransaction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DataExtractsTransaction
            //instance = new DataExtractsTransaction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataExtractsTransaction
        /// </summary>
        [Test]
        public void DataExtractsTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DataExtractsTransaction
            //Assert.IsInstanceOfType<DataExtractsTransaction> (instance, "variable 'instance' is a DataExtractsTransaction");
        }


        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'SourceId'
        /// </summary>
        [Test]
        public void SourceIdTest()
        {
            // TODO unit test for the property 'SourceId'
        }
        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'CusipNumber'
        /// </summary>
        [Test]
        public void CusipNumberTest()
        {
            // TODO unit test for the property 'CusipNumber'
        }
        /// <summary>
        /// Test the property 'HighLevelCategoryId'
        /// </summary>
        [Test]
        public void HighLevelCategoryIdTest()
        {
            // TODO unit test for the property 'HighLevelCategoryId'
        }
        /// <summary>
        /// Test the property 'DetailCategoryId'
        /// </summary>
        [Test]
        public void DetailCategoryIdTest()
        {
            // TODO unit test for the property 'DetailCategoryId'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Memo'
        /// </summary>
        [Test]
        public void MemoTest()
        {
            // TODO unit test for the property 'Memo'
        }
        /// <summary>
        /// Test the property 'SettleDate'
        /// </summary>
        [Test]
        public void SettleDateTest()
        {
            // TODO unit test for the property 'SettleDate'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Intermediary'
        /// </summary>
        [Test]
        public void IntermediaryTest()
        {
            // TODO unit test for the property 'Intermediary'
        }
        /// <summary>
        /// Test the property 'BaseType'
        /// </summary>
        [Test]
        public void BaseTypeTest()
        {
            // TODO unit test for the property 'BaseType'
        }
        /// <summary>
        /// Test the property 'CategorySource'
        /// </summary>
        [Test]
        public void CategorySourceTest()
        {
            // TODO unit test for the property 'CategorySource'
        }
        /// <summary>
        /// Test the property 'Principal'
        /// </summary>
        [Test]
        public void PrincipalTest()
        {
            // TODO unit test for the property 'Principal'
        }
        /// <summary>
        /// Test the property 'LastUpdated'
        /// </summary>
        [Test]
        public void LastUpdatedTest()
        {
            // TODO unit test for the property 'LastUpdated'
        }
        /// <summary>
        /// Test the property 'IsDeleted'
        /// </summary>
        [Test]
        public void IsDeletedTest()
        {
            // TODO unit test for the property 'IsDeleted'
        }
        /// <summary>
        /// Test the property 'Interest'
        /// </summary>
        [Test]
        public void InterestTest()
        {
            // TODO unit test for the property 'Interest'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Commission'
        /// </summary>
        [Test]
        public void CommissionTest()
        {
            // TODO unit test for the property 'Commission'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'MerchantType'
        /// </summary>
        [Test]
        public void MerchantTypeTest()
        {
            // TODO unit test for the property 'MerchantType'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'CheckNumber'
        /// </summary>
        [Test]
        public void CheckNumberTest()
        {
            // TODO unit test for the property 'CheckNumber'
        }
        /// <summary>
        /// Test the property 'IsPhysical'
        /// </summary>
        [Test]
        public void IsPhysicalTest()
        {
            // TODO unit test for the property 'IsPhysical'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'Valoren'
        /// </summary>
        [Test]
        public void ValorenTest()
        {
            // TODO unit test for the property 'Valoren'
        }
        /// <summary>
        /// Test the property 'IsManual'
        /// </summary>
        [Test]
        public void IsManualTest()
        {
            // TODO unit test for the property 'IsManual'
        }
        /// <summary>
        /// Test the property 'Merchant'
        /// </summary>
        [Test]
        public void MerchantTest()
        {
            // TODO unit test for the property 'Merchant'
        }
        /// <summary>
        /// Test the property 'Sedol'
        /// </summary>
        [Test]
        public void SedolTest()
        {
            // TODO unit test for the property 'Sedol'
        }
        /// <summary>
        /// Test the property 'TransactionDate'
        /// </summary>
        [Test]
        public void TransactionDateTest()
        {
            // TODO unit test for the property 'TransactionDate'
        }
        /// <summary>
        /// Test the property 'CategoryType'
        /// </summary>
        [Test]
        public void CategoryTypeTest()
        {
            // TODO unit test for the property 'CategoryType'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Test]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
        }
        /// <summary>
        /// Test the property 'SourceType'
        /// </summary>
        [Test]
        public void SourceTypeTest()
        {
            // TODO unit test for the property 'SourceType'
        }
        /// <summary>
        /// Test the property 'CONTAINER'
        /// </summary>
        [Test]
        public void CONTAINERTest()
        {
            // TODO unit test for the property 'CONTAINER'
        }
        /// <summary>
        /// Test the property 'PostDate'
        /// </summary>
        [Test]
        public void PostDateTest()
        {
            // TODO unit test for the property 'PostDate'
        }
        /// <summary>
        /// Test the property 'ParentCategoryId'
        /// </summary>
        [Test]
        public void ParentCategoryIdTest()
        {
            // TODO unit test for the property 'ParentCategoryId'
        }
        /// <summary>
        /// Test the property 'SubType'
        /// </summary>
        [Test]
        public void SubTypeTest()
        {
            // TODO unit test for the property 'SubType'
        }
        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
        }
        /// <summary>
        /// Test the property 'RunningBalance'
        /// </summary>
        [Test]
        public void RunningBalanceTest()
        {
            // TODO unit test for the property 'RunningBalance'
        }
        /// <summary>
        /// Test the property 'CategoryId'
        /// </summary>
        [Test]
        public void CategoryIdTest()
        {
            // TODO unit test for the property 'CategoryId'
        }
        /// <summary>
        /// Test the property 'HoldingDescription'
        /// </summary>
        [Test]
        public void HoldingDescriptionTest()
        {
            // TODO unit test for the property 'HoldingDescription'
        }
        /// <summary>
        /// Test the property 'Isin'
        /// </summary>
        [Test]
        public void IsinTest()
        {
            // TODO unit test for the property 'Isin'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

    }

}
