# IO.Swagger.Api.VerificationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHolderProfile**](VerificationApi.md#getholderprofile) | **GET** /verification/holderProfile | Get Holder Profile
[**GetVerificationStatus**](VerificationApi.md#getverificationstatus) | **GET** /verification | Get Verification Status
[**GetVerifiedAccounts**](VerificationApi.md#getverifiedaccounts) | **GET** /verification/verifiedAccounts | Get Verified Accounts
[**InitiateMatchingOrChallengeDepositeVerification**](VerificationApi.md#initiatematchingorchallengedepositeverification) | **POST** /verification | Initiaite Challenge Deposit
[**VerifyChallengeDeposit**](VerificationApi.md#verifychallengedeposit) | **PUT** /verification | Verify Challenge Deposit

<a name="getholderprofile"></a>
# **GetHolderProfile**
> HolderProfileResponse GetHolderProfile (string providerAccountId, string accountId)

Get Holder Profile

The Holder Profile API service allows retrieving the user's profile details (i.e., PII data such as name, email, phone number, and address) that are available at the provider account and each account level. The API accepts the providerAccountId and retrieves the profile information available under it and all the details available under each of the associated accounts.  <br><br>This service can only be invoked by Yodlee API v1.1, FastLink 3, and FastLink 4 customers. <br><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHolderProfileExample
    {
        public void main()
        {

            var apiInstance = new VerificationApi();
            var providerAccountId = providerAccountId_example;  // string | providerAccountId.
            var accountId = accountId_example;  // string | accountId (optional) 

            try
            {
                // Get Holder Profile
                HolderProfileResponse result = apiInstance.GetHolderProfile(providerAccountId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetHolderProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **string**| providerAccountId. | 
 **accountId** | **string**| accountId | [optional] 

### Return type

[**HolderProfileResponse**](HolderProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> VerificationStatusResponse GetVerificationStatus (string accountId, string providerAccountId, string verificationType)

Get Verification Status

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br> The get verification status service is used to retrieve the verification status of all accounts for which the CDV process has been initiated.For the CDV process, the account details object returns the user provided account information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVerificationStatusExample
    {
        public void main()
        {

            var apiInstance = new VerificationApi();
            var accountId = accountId_example;  // string | Comma separated accountId (optional) 
            var providerAccountId = providerAccountId_example;  // string | Comma separated providerAccountId (optional) 
            var verificationType = verificationType_example;  // string | verificationType (optional) 

            try
            {
                // Get Verification Status
                VerificationStatusResponse result = apiInstance.GetVerificationStatus(accountId, providerAccountId, verificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetVerificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountId | [optional] 
 **providerAccountId** | **string**| Comma separated providerAccountId | [optional] 
 **verificationType** | **string**| verificationType | [optional] 

### Return type

[**VerificationStatusResponse**](VerificationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifiedaccounts"></a>
# **GetVerifiedAccounts**
> VerifiedAccountResponse GetVerifiedAccounts (string providerAccountId, string accountId, string isSelected, string verificationStatus)

Get Verified Accounts

The Verified Accounts API v1.1 provides information about the bank and investment accounts that the user  has selected for verification, during the Account Verification flow on FastLink 4. By default, the API only returns information of the accounts that were selected and have been successfully verified. <br><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVerifiedAccountsExample
    {
        public void main()
        {

            var apiInstance = new VerificationApi();
            var providerAccountId = providerAccountId_example;  // string | providerAccountId.
            var accountId = accountId_example;  // string | Comma separated accountIds. (optional) 
            var isSelected = isSelected_example;  // string | Comma separated isSelected. Allowed values are true, false <br><b>Note:</b> If no value is passed, the implicit default value is true. (optional) 
            var verificationStatus = verificationStatus_example;  // string | Comma separated verificationStatus. Allowed values are SUCCESS, FAILED <br><b>Note:</b> If no value is passed, the implicit default value is SUCCESS. (optional) 

            try
            {
                // Get Verified Accounts
                VerifiedAccountResponse result = apiInstance.GetVerifiedAccounts(providerAccountId, accountId, isSelected, verificationStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetVerifiedAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerAccountId** | **string**| providerAccountId. | 
 **accountId** | **string**| Comma separated accountIds. | [optional] 
 **isSelected** | **string**| Comma separated isSelected. Allowed values are true, false &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is true. | [optional] 
 **verificationStatus** | **string**| Comma separated verificationStatus. Allowed values are SUCCESS, FAILED &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is SUCCESS. | [optional] 

### Return type

[**VerifiedAccountResponse**](VerifiedAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatematchingorchallengedepositeverification"></a>
# **InitiateMatchingOrChallengeDepositeVerification**
> VerificationResponse InitiateMatchingOrChallengeDepositeVerification (VerificationRequest body)

Initiaite Challenge Deposit

<i>This API implementation notes is intended for FastLink 4 users. For FastLink 3 users, additional integration notes related to this endpoint is available <a href=\"https://developer.envestnet.com/resources/yodlee/fastlink-3/docs/api-integrations\">here</a>.</i><br><br> The post verification service is used to initiate the challenge deposit account verification (CDV) process to verify account ownership.The CDV process can verify ownership of only bank accounts (i.e., checking and savings).Once the CDV process is initiated, Yodlee will post the micro-transaction (i.e., credit and debit) in the user's account. The CDV process takes 2 to 3 days to complete as it requires the user to provide the microtransaction details.<br><br>The CDV process is currently supported only in the United States.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateMatchingOrChallengeDepositeVerificationExample
    {
        public void main()
        {

            var apiInstance = new VerificationApi();
            var body = new VerificationRequest(); // VerificationRequest | verification information

            try
            {
                // Initiaite Challenge Deposit
                VerificationResponse result = apiInstance.InitiateMatchingOrChallengeDepositeVerification(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.InitiateMatchingOrChallengeDepositeVerification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VerificationRequest**](VerificationRequest.md)| verification information | 

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifychallengedeposit"></a>
# **VerifyChallengeDeposit**
> VerificationResponse VerifyChallengeDeposit (UpdateVerificationRequest body)

Verify Challenge Deposit

The put verification service is used to complete the challenge deposit verification (CDV) process.<br>This service is used only by the customer of CDV flow.<br>In the CDV process, the user-provided microtransaction details (i.e., credit and debit) is matched against the microtransactions posted by Yodlee. For a successful verification of the account's ownership both the microtransaction details should match.<br>The CDV process is currently supported only in the United States.<br><br><b>Notes:</b><ul><li>This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team's assistance to set up a dedicated environment.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyChallengeDepositExample
    {
        public void main()
        {

            var apiInstance = new VerificationApi();
            var body = new UpdateVerificationRequest(); // UpdateVerificationRequest | verification information

            try
            {
                // Verify Challenge Deposit
                VerificationResponse result = apiInstance.VerifyChallengeDeposit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyChallengeDeposit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateVerificationRequest**](UpdateVerificationRequest.md)| verification information | 

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

