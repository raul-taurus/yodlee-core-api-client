# YodleeCoreApis.ProviderAccountRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**consentId** | **Number** | Consent Id generated for the request through POST Consent.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;/ul&gt; | [optional] 
**preferences** | [**ProviderAccountPreferences**](ProviderAccountPreferences.md) |  | [optional] 
**aggregationSource** | **String** |  | [optional] 
**field** | [**[Field]**](Field.md) |  | 

<a name="AggregationSourceEnum"></a>
## Enum: AggregationSourceEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `USER` (value: `"USER"`)

