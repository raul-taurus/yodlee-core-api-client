# YodleeCoreApis.CobrandNotificationEvent

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **String** | Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET cobrand/config/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**callbackUrl** | **String** | URL to which the notification should be posted.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET cobrand/config/notifications/events&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="NameEnum"></a>
## Enum: NameEnum

* `REFRESH` (value: `"REFRESH"`)
* `DATA_UPDATES` (value: `"DATA_UPDATES"`)
* `AUTO_REFRESH_UPDATES` (value: `"AUTO_REFRESH_UPDATES"`)

