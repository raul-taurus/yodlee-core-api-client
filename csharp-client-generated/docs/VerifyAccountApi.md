# IO.Swagger.Api.VerifyAccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InitiateAccountVerification**](VerifyAccountApi.md#initiateaccountverification) | **POST** /verifyAccount/{providerAccountId} | Verify Accounts Using Transactions

<a name="initiateaccountverification"></a>
# **InitiateAccountVerification**
> VerifyAccountResponse InitiateAccountVerification (VerifyAccountRequest body, string providerAccountId)

Verify Accounts Using Transactions

The verify account service is used to verify the account's ownership by  matching the transaction details with the accounts aggregated for the user.<br><ul><li>If a match is identified, the service returns details of all the accounts along with the matched transaction's details.<li>If no transaction match is found, an empty response will be returned.<li>A maximum of 5 transactionCriteria can be passed in a request.<li>The baseType, date, and amount parameters should mandatorily be passed.<li>The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.<li>Pass the container or accountId parameters for better performance.<li>This service supports the localization feature and accepts locale as a header parameter.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateAccountVerificationExample
    {
        public void main()
        {
            var apiInstance = new VerifyAccountApi();
            var body = new VerifyAccountRequest(); // VerifyAccountRequest | verificationParam
            var providerAccountId = providerAccountId_example;  // string | providerAccountId

            try
            {
                // Verify Accounts Using Transactions
                VerifyAccountResponse result = apiInstance.InitiateAccountVerification(body, providerAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyAccountApi.InitiateAccountVerification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VerifyAccountRequest**](VerifyAccountRequest.md)| verificationParam | 
 **providerAccountId** | **string**| providerAccountId | 

### Return type

[**VerifyAccountResponse**](VerifyAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
