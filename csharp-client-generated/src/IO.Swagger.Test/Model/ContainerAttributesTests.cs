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
    ///  Class for testing ContainerAttributes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContainerAttributesTests
    {
        // TODO uncomment below to declare an instance variable for ContainerAttributes
        //private ContainerAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ContainerAttributes
            //instance = new ContainerAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContainerAttributes
        /// </summary>
        [Test]
        public void ContainerAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ContainerAttributes
            //Assert.IsInstanceOfType<ContainerAttributes> (instance, "variable 'instance' is a ContainerAttributes");
        }


        /// <summary>
        /// Test the property 'BANK'
        /// </summary>
        [Test]
        public void BANKTest()
        {
            // TODO unit test for the property 'BANK'
        }
        /// <summary>
        /// Test the property 'LOAN'
        /// </summary>
        [Test]
        public void LOANTest()
        {
            // TODO unit test for the property 'LOAN'
        }
        /// <summary>
        /// Test the property 'CREDITCARD'
        /// </summary>
        [Test]
        public void CREDITCARDTest()
        {
            // TODO unit test for the property 'CREDITCARD'
        }
        /// <summary>
        /// Test the property 'INVESTMENT'
        /// </summary>
        [Test]
        public void INVESTMENTTest()
        {
            // TODO unit test for the property 'INVESTMENT'
        }
        /// <summary>
        /// Test the property 'INSURANCE'
        /// </summary>
        [Test]
        public void INSURANCETest()
        {
            // TODO unit test for the property 'INSURANCE'
        }

    }

}