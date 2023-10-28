# YodleeCoreApis.UserDetail

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**preferences** | [**UserResponsePreferences**](UserResponsePreferences.md) |  | [optional] 
**address** | [**UserAddress**](UserAddress.md) |  | [optional] 
**phoneNumber** | **String** |  | [optional] 
**loginName** | **String** | The login name of the user used for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt; | [optional] 
**name** | [**Name**](Name.md) |  | [optional] 
**id** | **Number** | The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/samlLogin&lt;/li&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt; | [optional] 
**roleType** | **String** |  | [optional] 
**email** | **String** | The email address of the user.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt; | [optional] 
**segmentName** | **String** |  | [optional] 

<a name="RoleTypeEnum"></a>
## Enum: RoleTypeEnum

* `INDIVIDUAL` (value: `"INDIVIDUAL"`)

