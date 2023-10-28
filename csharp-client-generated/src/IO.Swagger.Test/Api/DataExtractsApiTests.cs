/* 
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DataExtractsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataExtractsApiTests
    {
        private DataExtractsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataExtractsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataExtractsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataExtractsApi
            //Assert.IsInstanceOfType(typeof(DataExtractsApi), instance, "instance is a DataExtractsApi");
        }

        /// <summary>
        /// Test GetDataExtractsEvents
        /// </summary>
        [Test]
        public void GetDataExtractsEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string fromDate = null;
            //string toDate = null;
            //var response = instance.GetDataExtractsEvents(eventName, fromDate, toDate);
            //Assert.IsInstanceOf<DataExtractsEventResponse> (response, "response is DataExtractsEventResponse");
        }
        /// <summary>
        /// Test GetDataExtractsUserData
        /// </summary>
        [Test]
        public void GetDataExtractsUserDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fromDate = null;
            //string loginName = null;
            //string toDate = null;
            //var response = instance.GetDataExtractsUserData(fromDate, loginName, toDate);
            //Assert.IsInstanceOf<DataExtractsUserDataResponse> (response, "response is DataExtractsUserDataResponse");
        }
    }

}
