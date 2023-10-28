using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVerificationApi
    {
        /// <summary>
        /// Get Holder Profile The Holder Profile API service allows retrieving the user&#x27;s profile details (i.e., PII data such as name, email, phone number, and address) that are available at the provider account and each account level. The API accepts the providerAccountId and retrieves the profile information available under it and all the details available under each of the associated accounts.  &lt;br&gt;&lt;br&gt;This service can only be invoked by Yodlee API v1.1, FastLink 3, and FastLink 4 customers. &lt;br&gt;&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <param name="accountId">accountId</param>
        /// <returns>HolderProfileResponse</returns>
        HolderProfileResponse GetHolderProfile (string providerAccountId, string accountId);
        /// <summary>
        /// Get Verification Status &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The get verification status service is used to retrieve the verification status of all accounts for which the CDV process has been initiated.For the CDV process, the account details object returns the user provided account information.
        /// </summary>
        /// <param name="accountId">Comma separated accountId</param>
        /// <param name="providerAccountId">Comma separated providerAccountId</param>
        /// <param name="verificationType">verificationType</param>
        /// <returns>VerificationStatusResponse</returns>
        VerificationStatusResponse GetVerificationStatus (string accountId, string providerAccountId, string verificationType);
        /// <summary>
        /// Get Verified Accounts The Verified Accounts API v1.1 provides information about the bank and investment accounts that the user  has selected for verification, during the Account Verification flow on FastLink 4. By default, the API only returns information of the accounts that were selected and have been successfully verified. &lt;br&gt;&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="isSelected">Comma separated isSelected. Allowed values are true, false &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is true.</param>
        /// <param name="verificationStatus">Comma separated verificationStatus. Allowed values are SUCCESS, FAILED &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is SUCCESS.</param>
        /// <returns>VerifiedAccountResponse</returns>
        VerifiedAccountResponse GetVerifiedAccounts (string providerAccountId, string accountId, string isSelected, string verificationStatus);
        /// <summary>
        /// Initiaite Challenge Deposit &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The post verification service is used to initiate the challenge deposit account verification (CDV) process to verify account ownership.The CDV process can verify ownership of only bank accounts (i.e., checking and savings).Once the CDV process is initiated, Yodlee will post the micro-transaction (i.e., credit and debit) in the user&#x27;s account. The CDV process takes 2 to 3 days to complete as it requires the user to provide the microtransaction details.&lt;br&gt;&lt;br&gt;The CDV process is currently supported only in the United States.
        /// </summary>
        /// <param name="body">verification information</param>
        /// <returns>VerificationResponse</returns>
        VerificationResponse InitiateMatchingOrChallengeDepositeVerification (VerificationRequest body);
        /// <summary>
        /// Verify Challenge Deposit The put verification service is used to complete the challenge deposit verification (CDV) process.&lt;br&gt;This service is used only by the customer of CDV flow.&lt;br&gt;In the CDV process, the user-provided microtransaction details (i.e., credit and debit) is matched against the microtransactions posted by Yodlee. For a successful verification of the account&#x27;s ownership both the microtransaction details should match.&lt;br&gt;The CDV process is currently supported only in the United States.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ul&gt;&lt;li&gt;This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team&#x27;s assistance to set up a dedicated environment.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">verification information</param>
        /// <returns>VerificationResponse</returns>
        VerificationResponse VerifyChallengeDeposit (UpdateVerificationRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VerificationApi : IVerificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VerificationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VerificationApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get Holder Profile The Holder Profile API service allows retrieving the user&#x27;s profile details (i.e., PII data such as name, email, phone number, and address) that are available at the provider account and each account level. The API accepts the providerAccountId and retrieves the profile information available under it and all the details available under each of the associated accounts.  &lt;br&gt;&lt;br&gt;This service can only be invoked by Yodlee API v1.1, FastLink 3, and FastLink 4 customers. &lt;br&gt;&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <param name="accountId">accountId</param>
        /// <returns>HolderProfileResponse</returns>
        public HolderProfileResponse GetHolderProfile (string providerAccountId, string accountId)
        {
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling GetHolderProfile");
    
            var path = "/verification/holderProfile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHolderProfile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHolderProfile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HolderProfileResponse) ApiClient.Deserialize(response.Content, typeof(HolderProfileResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Verification Status &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The get verification status service is used to retrieve the verification status of all accounts for which the CDV process has been initiated.For the CDV process, the account details object returns the user provided account information.
        /// </summary>
        /// <param name="accountId">Comma separated accountId</param>
        /// <param name="providerAccountId">Comma separated providerAccountId</param>
        /// <param name="verificationType">verificationType</param>
        /// <returns>VerificationStatusResponse</returns>
        public VerificationStatusResponse GetVerificationStatus (string accountId, string providerAccountId, string verificationType)
        {
    
            var path = "/verification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
 if (verificationType != null) queryParams.Add("verificationType", ApiClient.ParameterToString(verificationType)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerificationStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerificationStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerificationStatusResponse) ApiClient.Deserialize(response.Content, typeof(VerificationStatusResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Verified Accounts The Verified Accounts API v1.1 provides information about the bank and investment accounts that the user  has selected for verification, during the Account Verification flow on FastLink 4. By default, the API only returns information of the accounts that were selected and have been successfully verified. &lt;br&gt;&lt;br&gt;
        /// </summary>
        /// <param name="providerAccountId">providerAccountId.</param>
        /// <param name="accountId">Comma separated accountIds.</param>
        /// <param name="isSelected">Comma separated isSelected. Allowed values are true, false &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is true.</param>
        /// <param name="verificationStatus">Comma separated verificationStatus. Allowed values are SUCCESS, FAILED &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is SUCCESS.</param>
        /// <returns>VerifiedAccountResponse</returns>
        public VerifiedAccountResponse GetVerifiedAccounts (string providerAccountId, string accountId, string isSelected, string verificationStatus)
        {
            // verify the required parameter 'providerAccountId' is set
            if (providerAccountId == null) throw new ApiException(400, "Missing required parameter 'providerAccountId' when calling GetVerifiedAccounts");
    
            var path = "/verification/verifiedAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (isSelected != null) queryParams.Add("isSelected", ApiClient.ParameterToString(isSelected)); // query parameter
 if (providerAccountId != null) queryParams.Add("providerAccountId", ApiClient.ParameterToString(providerAccountId)); // query parameter
 if (verificationStatus != null) queryParams.Add("verificationStatus", ApiClient.ParameterToString(verificationStatus)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerifiedAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVerifiedAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerifiedAccountResponse) ApiClient.Deserialize(response.Content, typeof(VerifiedAccountResponse), response.Headers);
        }
    
        /// <summary>
        /// Initiaite Challenge Deposit &lt;i&gt;This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available &lt;a href&#x3D;\&quot;https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\&quot;&gt;here&lt;/a&gt;.&lt;/i&gt;&lt;br&gt;&lt;br&gt; The post verification service is used to initiate the challenge deposit account verification (CDV) process to verify account ownership.The CDV process can verify ownership of only bank accounts (i.e., checking and savings).Once the CDV process is initiated, Yodlee will post the micro-transaction (i.e., credit and debit) in the user&#x27;s account. The CDV process takes 2 to 3 days to complete as it requires the user to provide the microtransaction details.&lt;br&gt;&lt;br&gt;The CDV process is currently supported only in the United States.
        /// </summary>
        /// <param name="body">verification information</param>
        /// <returns>VerificationResponse</returns>
        public VerificationResponse InitiateMatchingOrChallengeDepositeVerification (VerificationRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InitiateMatchingOrChallengeDepositeVerification");
    
            var path = "/verification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateMatchingOrChallengeDepositeVerification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateMatchingOrChallengeDepositeVerification: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerificationResponse) ApiClient.Deserialize(response.Content, typeof(VerificationResponse), response.Headers);
        }
    
        /// <summary>
        /// Verify Challenge Deposit The put verification service is used to complete the challenge deposit verification (CDV) process.&lt;br&gt;This service is used only by the customer of CDV flow.&lt;br&gt;In the CDV process, the user-provided microtransaction details (i.e., credit and debit) is matched against the microtransactions posted by Yodlee. For a successful verification of the account&#x27;s ownership both the microtransaction details should match.&lt;br&gt;The CDV process is currently supported only in the United States.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;ul&gt;&lt;li&gt;This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team&#x27;s assistance to set up a dedicated environment.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <param name="body">verification information</param>
        /// <returns>VerificationResponse</returns>
        public VerificationResponse VerifyChallengeDeposit (UpdateVerificationRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling VerifyChallengeDeposit");
    
            var path = "/verification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyChallengeDeposit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyChallengeDeposit: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VerificationResponse) ApiClient.Deserialize(response.Content, typeof(VerificationResponse), response.Headers);
        }
    
    }
}
