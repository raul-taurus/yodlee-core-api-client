# IO.Swagger.Api.ConfigsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscriptionNotificationEvent**](ConfigsApi.md#createsubscriptionnotificationevent) | **POST** /configs/notifications/events/{eventName} | Subscribe For Notification Event
[**DeleteSubscribedNotificationEvent**](ConfigsApi.md#deletesubscribednotificationevent) | **DELETE** /configs/notifications/events/{eventName} | Delete Notification Subscription
[**GetSubscribedNotificationEvents**](ConfigsApi.md#getsubscribednotificationevents) | **GET** /configs/notifications/events | Get Subscribed Notification Events
[**UpdateSubscribedNotificationEvent**](ConfigsApi.md#updatesubscribednotificationevent) | **PUT** /configs/notifications/events/{eventName} | Update Notification Subscription

<a name="createsubscriptionnotificationevent"></a>
# **CreateSubscriptionNotificationEvent**
> void CreateSubscriptionNotificationEvent (CreateConfigsNotificationEventRequest body, string eventName)

Subscribe For Notification Event

The subscribe events service is used to subscribe to an event for receiving notifications.<br>The callback URL, where the notification will be posted should be provided to this service.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br>Customers can subscribe to REFRESH,DATA_UPDATES,AUTO_REFRESH_UPDATES and LATEST_BALANCE_UPDATES event.<br><br><b>Notes:</b><li>This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.<li>The content type has to be passed as application/json for the body parameter.</li>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionNotificationEventExample
    {
        public void main()
        {
            var apiInstance = new ConfigsApi();
            var body = new CreateConfigsNotificationEventRequest(); // CreateConfigsNotificationEventRequest | eventRequest
            var eventName = eventName_example;  // string | eventName

            try
            {
                // Subscribe For Notification Event
                apiInstance.CreateSubscriptionNotificationEvent(body, eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.CreateSubscriptionNotificationEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateConfigsNotificationEventRequest**](CreateConfigsNotificationEventRequest.md)| eventRequest | 
 **eventName** | **string**| eventName | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscribednotificationevent"></a>
# **DeleteSubscribedNotificationEvent**
> void DeleteSubscribedNotificationEvent (string eventName)

Delete Notification Subscription

The delete events service is used to unsubscribe from an events service.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubscribedNotificationEventExample
    {
        public void main()
        {
            var apiInstance = new ConfigsApi();
            var eventName = eventName_example;  // string | eventName

            try
            {
                // Delete Notification Subscription
                apiInstance.DeleteSubscribedNotificationEvent(eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.DeleteSubscribedNotificationEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| eventName | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscribednotificationevents"></a>
# **GetSubscribedNotificationEvents**
> ConfigsNotificationResponse GetSubscribedNotificationEvents (string eventName = null)

Get Subscribed Notification Events

The get events service provides the list of events for which consumers subscribed to receive notifications. <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscribedNotificationEventsExample
    {
        public void main()
        {
            var apiInstance = new ConfigsApi();
            var eventName = eventName_example;  // string | eventName (optional) 

            try
            {
                // Get Subscribed Notification Events
                ConfigsNotificationResponse result = apiInstance.GetSubscribedNotificationEvents(eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.GetSubscribedNotificationEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| eventName | [optional] 

### Return type

[**ConfigsNotificationResponse**](ConfigsNotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesubscribednotificationevent"></a>
# **UpdateSubscribedNotificationEvent**
> void UpdateSubscribedNotificationEvent (UpdateConfigsNotificationEventRequest body, string eventName)

Update Notification Subscription

The update events service is used to update the callback URL.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br><br><b>Note:</b> <li>The content type has to be passed as application/json for the body parameter. <br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubscribedNotificationEventExample
    {
        public void main()
        {
            var apiInstance = new ConfigsApi();
            var body = new UpdateConfigsNotificationEventRequest(); // UpdateConfigsNotificationEventRequest | eventRequest
            var eventName = eventName_example;  // string | eventName

            try
            {
                // Update Notification Subscription
                apiInstance.UpdateSubscribedNotificationEvent(body, eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigsApi.UpdateSubscribedNotificationEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateConfigsNotificationEventRequest**](UpdateConfigsNotificationEventRequest.md)| eventRequest | 
 **eventName** | **string**| eventName | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
