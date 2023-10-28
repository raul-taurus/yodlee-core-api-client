# YodleeCoreApis.VerifiedAccounts

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountName** | **String** | The account name as it appears at the site.&lt;br&gt;(The POST accounts service response return this field as name)&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**verificationStatus** | **String** | The status of the account verification. | [optional] 
**accountType** | **String** | The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. &lt;br&gt;&lt;b&gt;Valid Values:&lt;/b&gt;&lt;br&gt;&lt;b&gt;Aggregated Account Type&lt;/b&gt;&lt;br&gt;&lt;b&gt;bank&lt;/b&gt;&lt;ul&gt;&lt;li&gt;CHECKING&lt;/li&gt;&lt;li&gt;SAVINGS&lt;/li&gt;&lt;li&gt;MONEY_MARKET&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;investment (SN 1.0)&lt;/b&gt;&lt;ul&gt;&lt;li&gt;BROKERAGE_MARGIN&lt;/li&gt;&lt;li&gt;BROKERAGE_CASH&lt;/li&gt;&lt;li&gt;BROKERAGE_LINK_ACCOUNT&lt;/li&gt;&lt;li&gt;INDIVIDUAL&lt;/li&gt;&lt;li&gt;CMA&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;investment (SN 2.0)&lt;/b&gt;&lt;ul&gt;&lt;li&gt;BROKERAGE_MARGIN&lt;/li&gt;&lt;li&gt;BROKERAGE_CASH&lt;/li&gt;&lt;li&gt;BROKERAGE_LINK_ACCOUNT&lt;/li&gt;&lt;li&gt;INDIVIDUAL&lt;/li&gt;&lt;li&gt;CMA&lt;/li&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**currentBalance** | [**Money**](Money.md) |  | [optional] 
**displayedName** | **String** | The name or identification of the account owner, as it appears at the FI site. &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**holder** | [**[AccountHolder]**](AccountHolder.md) | Holder details of the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**accountNumber** | **String** | The account number as it appears on the site. (The POST accounts service response return this field as number)&lt;br&gt;&lt;b&gt;Additional Details&lt;/b&gt;:&lt;b&gt; Bank / Investment&lt;/b&gt;:&lt;br&gt; The account number for the bank account as it appears at the site.&lt;br&gt;In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**classification** | **String** | The classification of the account such as personal, corporate, etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**availableBalance** | [**Money**](Money.md) |  | [optional] 
**fullAccountNumberList** | [**FullAccountNumberList**](FullAccountNumberList.md) |  | [optional] 
**accountId** | **Number** | The primary key of the provider account resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**accountAgeClassification** | **String** | Attribute to return the classification of the account age by specifying whether the account is old/new/recent as relevant for a verification use case. If it could not be classified into any one of these values, the attribute would return the value as &#x27;unclassified&#x27; | [optional] 
**balance** | [**Money**](Money.md) |  | [optional] 
**providerId** | **String** | Identifier of the provider site. The primary key of provider resource. &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**providerAccountId** | **Number** | The primary key of the provider account resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**CONTAINER** | **String** | The type of service. E.g., Bank, Investment &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**isSelected** | **Boolean** | Indicates if an account is selected by the user in the FastLink 4 application | [optional] 
**cash** | [**Money**](Money.md) |  | [optional] 
**bankTransferCode** | [**[BankTransferCode]**](BankTransferCode.md) | Bank and branch identification information.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**providerName** | **String** | Service provider or institution name where the account originates. This belongs to the provider resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /verification/verifiedAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] 
**failedReason** | **String** | The reason for the verification failure of the account. | [optional] 

<a name="VerificationStatusEnum"></a>
## Enum: VerificationStatusEnum

* `SUCCESS` (value: `"SUCCESS"`)
* `FAILED` (value: `"FAILED"`)


<a name="ClassificationEnum"></a>
## Enum: ClassificationEnum

* `OTHER` (value: `"OTHER"`)
* `PERSONAL` (value: `"PERSONAL"`)
* `CORPORATE` (value: `"CORPORATE"`)
* `SMALL_BUSINESS` (value: `"SMALL_BUSINESS"`)
* `TRUST` (value: `"TRUST"`)
* `ADD_ON_CARD` (value: `"ADD_ON_CARD"`)
* `VIRTUAL_CARD` (value: `"VIRTUAL_CARD"`)


<a name="AccountAgeClassificationEnum"></a>
## Enum: AccountAgeClassificationEnum

* `UNCLASSIFIED` (value: `"UNCLASSIFIED"`)
* `OLD` (value: `"OLD"`)
* `NEW` (value: `"NEW"`)
* `RECENT` (value: `"RECENT"`)


<a name="CONTAINEREnum"></a>
## Enum: CONTAINEREnum

* `bank` (value: `"bank"`)
* `investment` (value: `"investment"`)


<a name="FailedReasonEnum"></a>
## Enum: FailedReasonEnum

* `REQUIRED_DATA_NOT_AVAILABLE` (value: `"REQUIRED_DATA_NOT_AVAILABLE"`)
* `MATCHING_FAILED` (value: `"MATCHING_FAILED"`)

