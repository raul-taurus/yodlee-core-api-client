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
    ///  Class for testing HoldingAssetClassificationListResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HoldingAssetClassificationListResponseTests
    {
        // TODO uncomment below to declare an instance variable for HoldingAssetClassificationListResponse
        //private HoldingAssetClassificationListResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HoldingAssetClassificationListResponse
            //instance = new HoldingAssetClassificationListResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HoldingAssetClassificationListResponse
        /// </summary>
        [Test]
        public void HoldingAssetClassificationListResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HoldingAssetClassificationListResponse
            //Assert.IsInstanceOfType<HoldingAssetClassificationListResponse> (instance, "variable 'instance' is a HoldingAssetClassificationListResponse");
        }


        /// <summary>
        /// Test the property 'AssetClassificationList'
        /// </summary>
        [Test]
        public void AssetClassificationListTest()
        {
            // TODO unit test for the property 'AssetClassificationList'
        }

    }

}