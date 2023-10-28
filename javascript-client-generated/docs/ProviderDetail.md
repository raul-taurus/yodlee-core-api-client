# YodleeCoreApis.ProviderDetail

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**languageISOCode** | **String** | The language in which the provider details are provided. For example, a site supports two languages English and French. English being the primary language, the provider response will be provided in French depending on the user&#x27;s locale. The language follows the two letter ISO code.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**favicon** | **String** | Favicon link of the provider.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**accountType** | **[String]** | AccountType supported by the provider, eg: Brokerage Cash, Current&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**countryISOCode** | **String** | Country to which the provider belongs.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isAddedByUser** | **String** | Indicates that the site has been added by the user at least once.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**PRIORITY** | **String** | Indicates the priority for which the service is invoked.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**associatedProviderIds** | **[Number]** | The screen-scraping providers that are associated to the Open Banking provider ID.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**primaryLanguageISOCode** | **String** | The primary language of the site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**help** | **String** | Text to guide user through linking an account that belongs to the site&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**baseUrl** | **String** | The base URL of the provider&#x27;s site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**capability** | [**[Capability]**](Capability.md) | Capability of the site&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;b&gt;Note : &lt;/b&gt; capability has been deprecated | [optional] 
**loginForm** | [**[LoginForm]**](LoginForm.md) | This entity represents the structure of the login or MFA form that is displayed to the user at the provider site. For performance reasons, this field is returned only when a single provider is requested in the request.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isConsentRequired** | **Boolean** | Indicates if a provider site requires consent.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**loginUrl** | **String** | The login URL of the provider&#x27;s site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isAutoRefreshEnabled** | **Boolean** | Indicates if a provider site is auto-refreshed.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**name** | **String** | The name of a provider site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**logo** | **String** | The logo link of the provider institution. The link will return the logo in the PNG format.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**id** | **Number** | Unique identifier for the provider site(e.g., financial institution sites, biller sites, lender sites, etc.).&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**lastModified** | **String** | Determines when the provider information was updated by Yodlee. If the customer caches the data, the cache is recommended to be refreshed based on this field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**authParameter** | **[String]** | AuthParameter appears in the response only in case of token-based aggregation sites.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**authType** | **String** | The authentication type enabled at the provider site. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**dataset** | [**[ProvidersDataset]**](ProvidersDataset.md) | Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 
**status** | **String** | Determines if the provider is supported for the cobrand (customer), is in the beta stage, etc. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;li&gt;GET providers&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="[AccountTypeEnum]"></a>
## Enum: [AccountTypeEnum]

* `CURRENT` (value: `"CURRENT"`)
* `BROKERAGE_CASH` (value: `"BROKERAGE_CASH"`)


<a name="PRIORITYEnum"></a>
## Enum: PRIORITYEnum

* `POPULAR` (value: `"POPULAR"`)
* `SUGGESTED` (value: `"SUGGESTED"`)
* `COBRAND` (value: `"COBRAND"`)
* `SEARCH` (value: `"SEARCH"`)
* `ALL` (value: `"ALL"`)


<a name="[AuthParameterEnum]"></a>
## Enum: [AuthParameterEnum]

* `authorizationCode` (value: `"authorizationCode"`)
* `idToken` (value: `"idToken"`)
* `authResponse` (value: `"authResponse"`)
* `state` (value: `"state"`)


<a name="AuthTypeEnum"></a>
## Enum: AuthTypeEnum

* `OAUTH` (value: `"OAUTH"`)
* `CREDENTIALS` (value: `"CREDENTIALS"`)
* `MFA_CREDENTIALS` (value: `"MFA_CREDENTIALS"`)


<a name="StatusEnum"></a>
## Enum: StatusEnum

* `supported` (value: `"Supported"`)
* `beta` (value: `"Beta"`)
* `unsupported` (value: `"Unsupported"`)

