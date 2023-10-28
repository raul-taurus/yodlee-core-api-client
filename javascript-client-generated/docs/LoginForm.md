# YodleeCoreApis.LoginForm

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**mfaInfoTitle** | **String** | The title for the MFA information demanded from the user.This is the title displayed in the provider site.This field is applicable for MFA form types only. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**help** | **String** | The help that can be displayed to the customer in the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**forgetPasswordURL** | **String** | The forget password URL of the provider site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**formType** | **String** | The type of the forms for which the user information is required.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**mfaInfoText** | **String** | The text displayed in the provider site while requesting the user&#x27;s MFA information. This field is applicable for MFA form types only. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**loginHelp** | **String** | The help that can be displayed to the customer in the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**mfaTimeout** | **Number** | The amount of time before which the user is expected to provide MFA information. This field is applicable for MFA form types only. This would be an useful information that could be displayed to the users. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**id** | **Number** | The identifier of the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**row** | [**[Row]**](Row.md) | This indicates one row in the form. The row will have one label. But it may have single or multiple fields.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="FormTypeEnum"></a>
## Enum: FormTypeEnum

* `login` (value: `"login"`)
* `questionAndAnswer` (value: `"questionAndAnswer"`)
* `token` (value: `"token"`)
* `image` (value: `"image"`)

