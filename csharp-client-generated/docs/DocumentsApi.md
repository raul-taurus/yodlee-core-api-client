# IO.Swagger.Api.DocumentsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDocument**](DocumentsApi.md#deletedocument) | **DELETE** /documents/{documentId} | Delete Document
[**DownloadDocument**](DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId} | Download a Document
[**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /documents | Get Documents

<a name="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (string documentId)

Delete Document

The delete document service allows the consumer to delete a document. The deleted document will not be returned in the get documents API. The HTTP response code is 204 (success without content).<br>Documents can be deleted only if the document related dataset attributes are subscribed.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | documentId

            try
            {
                // Delete Document
                apiInstance.DeleteDocument(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DeleteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| documentId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloaddocument"></a>
# **DownloadDocument**
> DocumentDownloadResponse DownloadDocument (string documentId)

Download a Document

The get document details service allows consumers to download a document. The document is provided in base64.<br>This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadDocumentExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | documentId

            try
            {
                // Download a Document
                DocumentDownloadResponse result = apiInstance.DownloadDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| documentId | 

### Return type

[**DocumentDownloadResponse**](DocumentDownloadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocuments"></a>
# **GetDocuments**
> DocumentResponse GetDocuments (string keyword = null, string accountId = null, string docType = null, string fromDate = null, string toDate = null)

Get Documents

The get documents service allows customers to search or retrieve metadata related to documents. <br>The API returns the document as per the input parameters passed. If no date range is provided then all downloaded documents will be retrieved. Details of deleted documents or documents associated to closed providerAccount will not be returned. <br>This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var keyword = keyword_example;  // string | The string used to search a document by its name. (optional) 
            var accountId = accountId_example;  // string | The unique identifier of an account. Retrieve documents for a given accountId. (optional) 
            var docType = docType_example;  // string | Accepts only one of the following valid document types: STMT, TAX, and EBILL. (optional) 
            var fromDate = fromDate_example;  // string | The date from which documents have to be retrieved. (optional) 
            var toDate = toDate_example;  // string | The date to which documents have to be retrieved. (optional) 

            try
            {
                // Get Documents
                DocumentResponse result = apiInstance.GetDocuments(keyword, accountId, docType, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **string**| The string used to search a document by its name. | [optional] 
 **accountId** | **string**| The unique identifier of an account. Retrieve documents for a given accountId. | [optional] 
 **docType** | **string**| Accepts only one of the following valid document types: STMT, TAX, and EBILL. | [optional] 
 **fromDate** | **string**| The date from which documents have to be retrieved. | [optional] 
 **toDate** | **string**| The date to which documents have to be retrieved. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
