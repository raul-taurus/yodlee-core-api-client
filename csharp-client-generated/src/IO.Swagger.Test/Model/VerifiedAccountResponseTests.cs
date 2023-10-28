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
    ///  Class for testing VerifiedAccountResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class VerifiedAccountResponseTests
    {
        // TODO uncomment below to declare an instance variable for VerifiedAccountResponse
        //private VerifiedAccountResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of VerifiedAccountResponse
            //instance = new VerifiedAccountResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VerifiedAccountResponse
        /// </summary>
        [Test]
        public void VerifiedAccountResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" VerifiedAccountResponse
            //Assert.IsInstanceOfType<VerifiedAccountResponse> (instance, "variable 'instance' is a VerifiedAccountResponse");
        }


        /// <summary>
        /// Test the property 'RequestId'
        /// </summary>
        [Test]
        public void RequestIdTest()
        {
            // TODO unit test for the property 'RequestId'
        }
        /// <summary>
        /// Test the property 'RequestDate'
        /// </summary>
        [Test]
        public void RequestDateTest()
        {
            // TODO unit test for the property 'RequestDate'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'VerifiedAccount'
        /// </summary>
        [Test]
        public void VerifiedAccountTest()
        {
            // TODO unit test for the property 'VerifiedAccount'
        }
        /// <summary>
        /// Test the property 'FailedReason'
        /// </summary>
        [Test]
        public void FailedReasonTest()
        {
            // TODO unit test for the property 'FailedReason'
        }

    }

}
