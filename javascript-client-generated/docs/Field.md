# YodleeCoreApis.Field

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**image** | **String** | Image displayed at the endsite.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**prefix** | **String** | The prefix string that has to be displayed before the field value.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**minLength** | **Number** | The minimum length of the login form field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**valueEditable** | **String** | Indicates whether the field is editable or not.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isOptional** | **Boolean** | Indicates if a field is an optional field or a mandatory field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**suffix** | **String** | The suffix string that has to be displayed next to the field value.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**type** | **String** | This indicates the display type of the field. For example, text box, image, etc. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**isValueProvided** | **Boolean** | Indicates that the answer to the security question already exists in the Yodlee system.Persuading the user to provide the answer to the security question again during the edit-credential flow can be avoided.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;questions&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}? include&#x3D;questions&lt;/li&gt;&lt;/ul&gt; | [optional] 
**name** | **String** | Name of the field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**id** | **String** | Identifier for the field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**value** | **String** | Value expected from the user for the field. This will be blank and is expected to be filled and sent back when submitting the login or MFA information.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**maxLength** | **Number** | The maximum length of the login form field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**option** | [**[Option]**](Option.md) | Provides the different values that are available for the user to choose. This field is applicable for drop-down or radio field types.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="TypeEnum"></a>
## Enum: TypeEnum

* `text` (value: `"text"`)
* `password` (value: `"password"`)
* `options` (value: `"options"`)
* `checkbox` (value: `"checkbox"`)
* `radio` (value: `"radio"`)
* `image` (value: `"image"`)
* `option` (value: `"option"`)

