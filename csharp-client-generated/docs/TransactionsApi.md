# IO.Swagger.Api.TransactionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrRunTransactionCategorizationRules**](TransactionsApi.md#createorruntransactioncategorizationrules) | **POST** /transactions/categories/rules | Create or Run Transaction Categorization Rule
[**CreateTransactionCategory**](TransactionsApi.md#createtransactioncategory) | **POST** /transactions/categories | Create Category
[**DeleteTransactionCategorizationRule**](TransactionsApi.md#deletetransactioncategorizationrule) | **DELETE** /transactions/categories/rules/{ruleId} | Delete Transaction Categorization Rule
[**DeleteTransactionCategory**](TransactionsApi.md#deletetransactioncategory) | **DELETE** /transactions/categories/{categoryId} | Delete Category
[**GetTransactionCategories**](TransactionsApi.md#gettransactioncategories) | **GET** /transactions/categories | Get Transaction Category List
[**GetTransactionCategorizationRules**](TransactionsApi.md#gettransactioncategorizationrules) | **GET** /transactions/categories/txnRules | Get Transaction Categorization Rules
[**GetTransactionCategorizationRulesDeprecated**](TransactionsApi.md#gettransactioncategorizationrulesdeprecated) | **GET** /transactions/categories/rules | Get Transaction Categorization Rules
[**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /transactions | Get Transactions
[**GetTransactionsCount**](TransactionsApi.md#gettransactionscount) | **GET** /transactions/count | Get Transactions Count
[**RunTransactionCategorizationRule**](TransactionsApi.md#runtransactioncategorizationrule) | **POST** /transactions/categories/rules/{ruleId} | Run Transaction Categorization Rule
[**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /transactions/{transactionId} | Update Transaction
[**UpdateTransactionCategorizationRule**](TransactionsApi.md#updatetransactioncategorizationrule) | **PUT** /transactions/categories/rules/{ruleId} | Update Transaction Categorization Rule
[**UpdateTransactionCategory**](TransactionsApi.md#updatetransactioncategory) | **PUT** /transactions/categories | Update Category

<a name="createorruntransactioncategorizationrules"></a>
# **CreateOrRunTransactionCategorizationRules**
> void CreateOrRunTransactionCategorizationRules (string action = null, string ruleParam = null)

Create or Run Transaction Categorization Rule

The Create or Run Transaction Categorization Rule endpoint is used to: <br>Create transaction categorization rules for both system and user-defined categories.<br>Run all the transaction categorization rules to categorize transactions by calling the endpoint with action=run as the query parameter. <br><br>The input body parameters to create transaction categorization rules follow:<br>     categoryId - This field is mandatory and numeric<br>     priority - This field is optional and numeric. Priority decides the order in which the rule gets applied on transactions.<br>     ruleClause - This field is mandatory and should contain at least one rule<br>     field - The value can be description or amount<br><br>       If the field value is description then,<br>         1. operation - value can be stringEquals or stringContains<br>         2. value - value should be min of 3 and max of 50 characters<br><br>       If the field value is amount then, <br>         1. operation - value can be numberEquals, numberLessThan, numberLessThanEquals, numberGreaterThan or numberGreaterThanEquals<br>         2. value - min value 0 and a max value of 99999999999.99 is allowed<br>The HTTP response code is 201 (Created Successfully).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrRunTransactionCategorizationRulesExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var action = action_example;  // string | To run rules, pass action=run. Only value run is supported (optional) 
            var ruleParam = ruleParam_example;  // string | rules(JSON format) to categorize the transactions (optional) 

            try
            {
                // Create or Run Transaction Categorization Rule
                apiInstance.CreateOrRunTransactionCategorizationRules(action, ruleParam);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateOrRunTransactionCategorizationRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| To run rules, pass action&#x3D;run. Only value run is supported | [optional] 
 **ruleParam** | **string**| rules(JSON format) to categorize the transactions | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtransactioncategory"></a>
# **CreateTransactionCategory**
> void CreateTransactionCategory (TransactionCategoryRequest body)

Create Category

The create transaction categories service is used to create user-defined categories for a system-defined category.<br>The parentCategoryId is the system-defined category id.This can be retrieved using get transaction categories service.<br>The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.<br>The HTTP response code is 201 (Created successfully).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTransactionCategoryExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new TransactionCategoryRequest(); // TransactionCategoryRequest | User Transaction Category in JSON format

            try
            {
                // Create Category
                apiInstance.CreateTransactionCategory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateTransactionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionCategoryRequest**](TransactionCategoryRequest.md)| User Transaction Category in JSON format | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetransactioncategorizationrule"></a>
# **DeleteTransactionCategorizationRule**
> void DeleteTransactionCategorizationRule (long? ruleId)

Delete Transaction Categorization Rule

The delete transaction categorization rule service is used to delete the given user-defined transaction categorization rule for both system-defined category as well as user-defined category.<br>This will delete all the corresponding rule clauses associated with the rule.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTransactionCategorizationRuleExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var ruleId = 789;  // long? | ruleId

            try
            {
                // Delete Transaction Categorization Rule
                apiInstance.DeleteTransactionCategorizationRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategorizationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **long?**| ruleId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetransactioncategory"></a>
# **DeleteTransactionCategory**
> void DeleteTransactionCategory (long? categoryId)

Delete Category

The delete transaction categories service is used to delete the given user-defined category.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTransactionCategoryExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var categoryId = 789;  // long? | categoryId

            try
            {
                // Delete Category
                apiInstance.DeleteTransactionCategory(categoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **long?**| categoryId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettransactioncategories"></a>
# **GetTransactionCategories**
> TransactionCategoryResponse GetTransactionCategories ()

Get Transaction Category List

The categories service returns the list of available transaction categories.<br>High level category is returned in the response only if it is opted by the customer.<br>When invoked by passing the cobrand session or admin access token, this service returns the supported transaction categories at the cobrand level. <br>When invoked by passing the cobrand session and the user session or user access token, this service returns the transaction categories <br>along with user-defined categories.<br>Double quotes in the user-defined category name will be prefixed by backslashes (&#92;) in the response, <br>e.g. Toys \"R\" Us.<br/>Source and id are the primary attributes of the category entity.<br><br><b>Note:</b><li>This service supports the localization feature and accepts locale as a header parameter.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionCategoriesExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();

            try
            {
                // Get Transaction Category List
                TransactionCategoryResponse result = apiInstance.GetTransactionCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TransactionCategoryResponse**](TransactionCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettransactioncategorizationrules"></a>
# **GetTransactionCategorizationRules**
> TransactionCategorizationRuleResponse GetTransactionCategorizationRules ()

Get Transaction Categorization Rules

The get transaction categorization rule service is used to get all the categorization rules.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionCategorizationRulesExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();

            try
            {
                // Get Transaction Categorization Rules
                TransactionCategorizationRuleResponse result = apiInstance.GetTransactionCategorizationRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TransactionCategorizationRuleResponse**](TransactionCategorizationRuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettransactioncategorizationrulesdeprecated"></a>
# **GetTransactionCategorizationRulesDeprecated**
> List<TransactionCategorizationRule> GetTransactionCategorizationRulesDeprecated ()

Get Transaction Categorization Rules

The get transaction categorization rule service is used to get all the categorization rules.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionCategorizationRulesDeprecatedExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();

            try
            {
                // Get Transaction Categorization Rules
                List&lt;TransactionCategorizationRule&gt; result = apiInstance.GetTransactionCategorizationRulesDeprecated();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRulesDeprecated: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TransactionCategorizationRule>**](TransactionCategorizationRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettransactions"></a>
# **GetTransactions**
> TransactionResponse GetTransactions (string accountId = null, string baseType = null, string categoryId = null, string categoryType = null, string container = null, string detailCategoryId = null, string fromDate = null, string highLevelCategoryId = null, string keyword = null, int? skip = null, string toDate = null, int? top = null, string type = null)

Get Transactions

The Transaction service is used to get a list of transactions for a user.<br>By default, this service returns the last 30 days of transactions from today's date.<br>The keyword parameter performs a contains search on the original, consumer, and simple description attributes, replace the special characters #, &, and + with percent-encoding values %23, %26, and %2B respectively. Eg: for -Debit# , pass the input as -Debit%23.<br>Values for categoryId parameter can be fetched from get transaction category list service.<br> The categoryId is used to filter transactions based on system-defined category as well as user-defined category.<br>User-defined categoryIds should be provided in the filter with the prefix ''U''. E.g. U10002<br>The skip and top parameters are used for pagination. In the skip and top parameters pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of transactions.<br>Double quotes in the merchant name will be prefixed by backslashes (&#92;) in the response, e.g. Toys \"R\" Us. <br>sourceId is a unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts. Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.<br><br><b>Note</b><ul><li><a href=\"https://developer.envestnet.com/resources/yodlee/transaction-data-enrichment/docs\">Transaction Data Enrichment (TDE)</a> is made available for bank and card accounts. The address field in the response is available only when the TDE key is turned on.</li><li>The pagination feature is available by default. If no values are passed in the skip and top parameters, the API will only return the first 500 transactions.</li><li>This service supports the localization feature and accepts locale as a header parameter.</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var accountId = accountId_example;  // string | Comma separated accountIds (optional) 
            var baseType = baseType_example;  // string | DEBIT/CREDIT (optional) 
            var categoryId = categoryId_example;  // string | Comma separated categoryIds (optional) 
            var categoryType = categoryType_example;  // string | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) (optional) 
            var container = container_example;  // string | bank/creditCard/investment/insurance/loan (optional) 
            var detailCategoryId = detailCategoryId_example;  // string | Comma separated detailCategoryIds (optional) 
            var fromDate = fromDate_example;  // string | Transaction from date(YYYY-MM-DD) (optional) 
            var highLevelCategoryId = highLevelCategoryId_example;  // string | Comma separated highLevelCategoryIds (optional) 
            var keyword = keyword_example;  // string | Transaction search text (optional) 
            var skip = 56;  // int? | skip (Min 0) (optional) 
            var toDate = toDate_example;  // string | Transaction end date (YYYY-MM-DD) (optional) 
            var top = 56;  // int? | top (Max 500) (optional) 
            var type = type_example;  // string | Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment (optional) 

            try
            {
                // Get Transactions
                TransactionResponse result = apiInstance.GetTransactions(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, skip, toDate, top, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountIds | [optional] 
 **baseType** | **string**| DEBIT/CREDIT | [optional] 
 **categoryId** | **string**| Comma separated categoryIds | [optional] 
 **categoryType** | **string**| Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) | [optional] 
 **container** | **string**| bank/creditCard/investment/insurance/loan | [optional] 
 **detailCategoryId** | **string**| Comma separated detailCategoryIds | [optional] 
 **fromDate** | **string**| Transaction from date(YYYY-MM-DD) | [optional] 
 **highLevelCategoryId** | **string**| Comma separated highLevelCategoryIds | [optional] 
 **keyword** | **string**| Transaction search text | [optional] 
 **skip** | **int?**| skip (Min 0) | [optional] 
 **toDate** | **string**| Transaction end date (YYYY-MM-DD) | [optional] 
 **top** | **int?**| top (Max 500) | [optional] 
 **type** | **string**| Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettransactionscount"></a>
# **GetTransactionsCount**
> TransactionCountResponse GetTransactionsCount (string accountId = null, string baseType = null, string categoryId = null, string categoryType = null, string container = null, string detailCategoryId = null, string fromDate = null, string highLevelCategoryId = null, string keyword = null, string toDate = null, string type = null)

Get Transactions Count

The count service provides the total number of transactions for a specific user depending on the input parameters passed.<br>If you are implementing pagination for transactions, call this endpoint before calling GET /transactions to know the number of transactions that are returned for the input parameters passed.<br>The functionality of the input parameters remains the same as that of the GET /transactions endpoint.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionsCountExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var accountId = accountId_example;  // string | Comma separated accountIds  (optional) 
            var baseType = baseType_example;  // string | DEBIT/CREDIT (optional) 
            var categoryId = categoryId_example;  // string | Comma separated categoryIds (optional) 
            var categoryType = categoryType_example;  // string | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) (optional) 
            var container = container_example;  // string | bank/creditCard/investment/insurance/loan (optional) 
            var detailCategoryId = detailCategoryId_example;  // string | Comma separated detailCategoryIds (optional) 
            var fromDate = fromDate_example;  // string | Transaction from date(YYYY-MM-DD) (optional) 
            var highLevelCategoryId = highLevelCategoryId_example;  // string | Comma separated highLevelCategoryIds (optional) 
            var keyword = keyword_example;  // string | Transaction search text  (optional) 
            var toDate = toDate_example;  // string | Transaction end date (YYYY-MM-DD) (optional) 
            var type = type_example;  // string | Transaction Type(SELL,SWEEP, etc.) (optional) 

            try
            {
                // Get Transactions Count
                TransactionCountResponse result = apiInstance.GetTransactionsCount(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, toDate, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionsCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Comma separated accountIds  | [optional] 
 **baseType** | **string**| DEBIT/CREDIT | [optional] 
 **categoryId** | **string**| Comma separated categoryIds | [optional] 
 **categoryType** | **string**| Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) | [optional] 
 **container** | **string**| bank/creditCard/investment/insurance/loan | [optional] 
 **detailCategoryId** | **string**| Comma separated detailCategoryIds | [optional] 
 **fromDate** | **string**| Transaction from date(YYYY-MM-DD) | [optional] 
 **highLevelCategoryId** | **string**| Comma separated highLevelCategoryIds | [optional] 
 **keyword** | **string**| Transaction search text  | [optional] 
 **toDate** | **string**| Transaction end date (YYYY-MM-DD) | [optional] 
 **type** | **string**| Transaction Type(SELL,SWEEP, etc.) | [optional] 

### Return type

[**TransactionCountResponse**](TransactionCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="runtransactioncategorizationrule"></a>
# **RunTransactionCategorizationRule**
> void RunTransactionCategorizationRule (string action, long? ruleId)

Run Transaction Categorization Rule

The run transaction categorization rule service is used to run a rule on transactions, to categorize the transactions.<br>The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunTransactionCategorizationRuleExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var action = action_example;  // string |  (default to run)
            var ruleId = 789;  // long? | Unique id of the categorization rule

            try
            {
                // Run Transaction Categorization Rule
                apiInstance.RunTransactionCategorizationRule(action, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.RunTransactionCategorizationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**|  | [default to run]
 **ruleId** | **long?**| Unique id of the categorization rule | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetransaction"></a>
# **UpdateTransaction**
> void UpdateTransaction (TransactionRequest body, long? transactionId)

Update Transaction

The update transaction service is used to update the category,consumer description, memo, isPhysical, merchantType, detailCategory for a transaction.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new TransactionRequest(); // TransactionRequest | transactionRequest
            var transactionId = 789;  // long? | transactionId

            try
            {
                // Update Transaction
                apiInstance.UpdateTransaction(body, transactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionRequest**](TransactionRequest.md)| transactionRequest | 
 **transactionId** | **long?**| transactionId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetransactioncategorizationrule"></a>
# **UpdateTransactionCategorizationRule**
> void UpdateTransactionCategorizationRule (TransactionCategorizationRuleRequest body, long? ruleId)

Update Transaction Categorization Rule

The update transaction categorization rule service is used to update a categorization rule for both system-defined category as well as user-defined category.<br>ruleParam JSON input should be as explained in the create transaction categorization rule service.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTransactionCategorizationRuleExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new TransactionCategorizationRuleRequest(); // TransactionCategorizationRuleRequest | transactionCategoriesRuleRequest
            var ruleId = 789;  // long? | ruleId

            try
            {
                // Update Transaction Categorization Rule
                apiInstance.UpdateTransactionCategorizationRule(body, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategorizationRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionCategorizationRuleRequest**](TransactionCategorizationRuleRequest.md)| transactionCategoriesRuleRequest | 
 **ruleId** | **long?**| ruleId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetransactioncategory"></a>
# **UpdateTransactionCategory**
> void UpdateTransactionCategory (UpdateCategoryRequest body)

Update Category

The update transaction categories service is used to update the transaction category name<br>for a high level category, a system-defined category and a user-defined category.<br>The renamed category can be set back to the original name by passing an empty string for categoryName.<br>The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTransactionCategoryExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new UpdateCategoryRequest(); // UpdateCategoryRequest | updateCategoryRequest

            try
            {
                // Update Category
                apiInstance.UpdateTransactionCategory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCategoryRequest**](UpdateCategoryRequest.md)| updateCategoryRequest | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
