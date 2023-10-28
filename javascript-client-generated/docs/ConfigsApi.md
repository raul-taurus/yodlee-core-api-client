# YodleeCoreApis.ConfigsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createSubscriptionNotificationEvent**](ConfigsApi.md#createSubscriptionNotificationEvent) | **POST** /configs/notifications/events/{eventName} | Subscribe For Notification Event
[**deleteSubscribedNotificationEvent**](ConfigsApi.md#deleteSubscribedNotificationEvent) | **DELETE** /configs/notifications/events/{eventName} | Delete Notification Subscription
[**getSubscribedNotificationEvents**](ConfigsApi.md#getSubscribedNotificationEvents) | **GET** /configs/notifications/events | Get Subscribed Notification Events
[**updateSubscribedNotificationEvent**](ConfigsApi.md#updateSubscribedNotificationEvent) | **PUT** /configs/notifications/events/{eventName} | Update Notification Subscription

<a name="createSubscriptionNotificationEvent"></a>
# **createSubscriptionNotificationEvent**
> createSubscriptionNotificationEvent(body, eventName)

Subscribe For Notification Event

The subscribe events service is used to subscribe to an event for receiving notifications.&lt;br&gt;The callback URL, where the notification will be posted should be provided to this service.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;Customers can subscribe to REFRESH,DATA_UPDATES,AUTO_REFRESH_UPDATES and LATEST_BALANCE_UPDATES event.&lt;br&gt;&lt;br&gt;&lt;b&gt;Notes:&lt;/b&gt;&lt;li&gt;This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.&lt;li&gt;The content type has to be passed as application/json for the body parameter.&lt;/li&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ConfigsApi();
let body = new YodleeCoreApis.CreateConfigsNotificationEventRequest(); // CreateConfigsNotificationEventRequest | eventRequest
let eventName = "eventName_example"; // String | eventName

apiInstance.createSubscriptionNotificationEvent(body, eventName, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateConfigsNotificationEventRequest**](CreateConfigsNotificationEventRequest.md)| eventRequest | 
 **eventName** | **String**| eventName | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="deleteSubscribedNotificationEvent"></a>
# **deleteSubscribedNotificationEvent**
> deleteSubscribedNotificationEvent(eventName)

Delete Notification Subscription

The delete events service is used to unsubscribe from an events service.&lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ConfigsApi();
let eventName = "eventName_example"; // String | eventName

apiInstance.deleteSubscribedNotificationEvent(eventName, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **String**| eventName | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getSubscribedNotificationEvents"></a>
# **getSubscribedNotificationEvents**
> ConfigsNotificationResponse getSubscribedNotificationEvents(opts)

Get Subscribed Notification Events

The get events service provides the list of events for which consumers subscribed to receive notifications. &lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ConfigsApi();
let opts = { 
  'eventName': "eventName_example" // String | eventName
};
apiInstance.getSubscribedNotificationEvents(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **String**| eventName | [optional] 

### Return type

[**ConfigsNotificationResponse**](ConfigsNotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="updateSubscribedNotificationEvent"></a>
# **updateSubscribedNotificationEvent**
> updateSubscribedNotificationEvent(body, eventName)

Update Notification Subscription

The update events service is used to update the callback URL.&lt;br&gt;If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.&lt;br&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; &lt;li&gt;The content type has to be passed as application/json for the body parameter. &lt;br&gt;

### Example
```javascript
import {YodleeCoreApis} from 'yodlee_core_apis';

let apiInstance = new YodleeCoreApis.ConfigsApi();
let body = new YodleeCoreApis.UpdateConfigsNotificationEventRequest(); // UpdateConfigsNotificationEventRequest | eventRequest
let eventName = "eventName_example"; // String | eventName

apiInstance.updateSubscribedNotificationEvent(body, eventName, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateConfigsNotificationEventRequest**](UpdateConfigsNotificationEventRequest.md)| eventRequest | 
 **eventName** | **String**| eventName | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

