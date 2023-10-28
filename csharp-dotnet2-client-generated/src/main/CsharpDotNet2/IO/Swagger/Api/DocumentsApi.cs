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
    public interface IDocumentsApi
    {
        /// <summary>
        /// Delete Document The delete document service allows the consumer to delete a document. The deleted document will not be returned in the get documents API. The HTTP response code is 204 (success without content).&lt;br&gt;Documents can be deleted only if the document related dataset attributes are subscribed.&lt;br&gt;
        /// </summary>
        /// <param name="documentId">documentId</param>
        /// <returns></returns>
        void DeleteDocument (string documentId);
        /// <summary>
        /// Download a Document The get document details service allows consumers to download a document. The document is provided in base64.&lt;br&gt;This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. &lt;br&gt;
        /// </summary>
        /// <param name="documentId">documentId</param>
        /// <returns>DocumentDownloadResponse</returns>
        DocumentDownloadResponse DownloadDocument (string documentId);
        /// <summary>
        /// Get Documents The get documents service allows customers to search or retrieve metadata related to documents. &lt;br&gt;The API returns the document as per the input parameters passed. If no date range is provided then all downloaded documents will be retrieved. Details of deleted documents or documents associated to closed providerAccount will not be returned. &lt;br&gt;This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. &lt;br&gt;
        /// </summary>
        /// <param name="keyword">The string used to search a document by its name.</param>
        /// <param name="accountId">The unique identifier of an account. Retrieve documents for a given accountId.</param>
        /// <param name="docType">Accepts only one of the following valid document types: STMT, TAX, and EBILL.</param>
        /// <param name="fromDate">The date from which documents have to be retrieved.</param>
        /// <param name="toDate">The date to which documents have to be retrieved.</param>
        /// <returns>DocumentResponse</returns>
        DocumentResponse GetDocuments (string keyword, string accountId, string docType, string fromDate, string toDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentsApi : IDocumentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DocumentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentsApi(String basePath)
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
        /// Delete Document The delete document service allows the consumer to delete a document. The deleted document will not be returned in the get documents API. The HTTP response code is 204 (success without content).&lt;br&gt;Documents can be deleted only if the document related dataset attributes are subscribed.&lt;br&gt;
        /// </summary>
        /// <param name="documentId">documentId</param>
        /// <returns></returns>
        public void DeleteDocument (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocument");
    
            var path = "/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Download a Document The get document details service allows consumers to download a document. The document is provided in base64.&lt;br&gt;This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. &lt;br&gt;
        /// </summary>
        /// <param name="documentId">documentId</param>
        /// <returns>DocumentDownloadResponse</returns>
        public DocumentDownloadResponse DownloadDocument (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DownloadDocument");
    
            var path = "/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DocumentDownloadResponse) ApiClient.Deserialize(response.Content, typeof(DocumentDownloadResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Documents The get documents service allows customers to search or retrieve metadata related to documents. &lt;br&gt;The API returns the document as per the input parameters passed. If no date range is provided then all downloaded documents will be retrieved. Details of deleted documents or documents associated to closed providerAccount will not be returned. &lt;br&gt;This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. &lt;br&gt;
        /// </summary>
        /// <param name="keyword">The string used to search a document by its name.</param>
        /// <param name="accountId">The unique identifier of an account. Retrieve documents for a given accountId.</param>
        /// <param name="docType">Accepts only one of the following valid document types: STMT, TAX, and EBILL.</param>
        /// <param name="fromDate">The date from which documents have to be retrieved.</param>
        /// <param name="toDate">The date to which documents have to be retrieved.</param>
        /// <returns>DocumentResponse</returns>
        public DocumentResponse GetDocuments (string keyword, string accountId, string docType, string fromDate, string toDate)
        {
    
            var path = "/documents";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyword != null) queryParams.Add("Keyword", ApiClient.ParameterToString(keyword)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
 if (docType != null) queryParams.Add("docType", ApiClient.ParameterToString(docType)); // query parameter
 if (fromDate != null) queryParams.Add("fromDate", ApiClient.ParameterToString(fromDate)); // query parameter
 if (toDate != null) queryParams.Add("toDate", ApiClient.ParameterToString(toDate)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DocumentResponse) ApiClient.Deserialize(response.Content, typeof(DocumentResponse), response.Headers);
        }
    
    }
}
