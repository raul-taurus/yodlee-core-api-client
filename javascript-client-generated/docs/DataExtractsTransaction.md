# YodleeCoreApis.DataExtractsTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_date** | **String** | The value provided will be either postDate or transactionDate. postDate takes higher priority than transactionDate, except for the investment container as only transactionDate is available. The availability of postDate or transactionDate depends on the provider site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**sourceId** | **String** | A unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts.&lt;br&gt;Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts. | [optional] 
**symbol** | **String** | The symbol of the security being traded.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: The settle date field applies only to trade-related transactions. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**cusipNumber** | **String** | The CUSIP (Committee on Uniform Securities Identification Procedures) identifies the financial instruments in the United States and Canada.&lt;br&gt;&lt;b&gt;&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;&lt;/b&gt;: The CUSIP number field applies only to trade related transactions.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**highLevelCategoryId** | **Number** | The high level category assigned to the transaction. The supported values are provided by the GET transactions/categories. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**detailCategoryId** | **Number** | The id of the detail category that is assigned to the transaction. The supported values are provided by GET transactions/categories.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard&lt;br&gt; | [optional] 
**description** | [**Description**](Description.md) |  | [optional] 
**memo** | **String** | Additional notes provided by the user for a particular  transaction through application or API services. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**settleDate** | **String** | It is the date on which the transaction is finalized, that is, the date the ownership of the security is transferred to the buyer. The settlement date is usually few days after the transaction date.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**type** | **String** | The nature of the transaction, i.e., deposit, refund, payment, etc.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: The transaction type field is available only for the United States, Canada, United Kingdom, and India based provider sites. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment&lt;br&gt; | [optional] 
**intermediary** | **[String]** | The intermediary of the transaction.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;:  bank,creditCard,investment,loan&lt;br&gt; | [optional] 
**baseType** | **String** | Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**categorySource** | **String** | Indicates the source of the category, i.e., categories derived by the system or assigned/provided by the consumer. This is the source field of the transaction category resource. The supported values are provided by the GET transactions/categories.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**principal** | [**Money**](Money.md) |  | [optional] 
**lastUpdated** | **String** |  | [optional] 
**isDeleted** | **Boolean** | Indicates if the transaction is marked as deleted.&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**interest** | [**Money**](Money.md) |  | [optional] 
**price** | [**Money**](Money.md) |  | [optional] 
**commission** | [**Money**](Money.md) |  | [optional] 
**id** | **Number** | An unique identifier for the transaction. The combination of the id and account container are unique in the system. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**merchantType** | **String** | Indicates the merchantType of the transaction.e.g:-BILLERS,SUBSCRIPTION,OTHERS &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt; | [optional] 
**amount** | [**Money**](Money.md) |  | [optional] 
**checkNumber** | **String** | The checkNumber of the transaction.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank&lt;br&gt; | [optional] 
**isPhysical** | **Boolean** | Indicates if the transaction is happened online or in-store. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt; | [optional] 
**quantity** | **Number** | The quantity associated with the transaction.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: The quantity field applies only to trade-related transactions.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**valoren** | **String** | It is an identification number that is assigned to financial instruments such as stocks and bonds trading in Switzerland.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**isManual** | **Boolean** | Indicates if the transaction is aggregated from the FI site or the consumer has manually created the transaction using the application or an API. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**merchant** | [**Merchant**](Merchant.md) |  | [optional] 
**sedol** | **String** | SEDOL stands for Stock Exchange Daily Official List, a list of security identifiers used in the United Kingdom and Ireland for clearing purposes.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**transactionDate** | **String** | The date the transaction happens in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**categoryType** | **String** | The categoryType of the category assigned to the transaction. This is the type field of the transaction category resource. The supported values are provided by the GET transactions/categories.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**accountId** | **Number** | The account from which the transaction was made. This is basically the primary key of the account resource. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**createdDate** | **String** |  | [optional] 
**sourceType** | **String** | The source through which the transaction is added to the Yodlee system.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loann&lt;br&gt;&lt;b&gt;Applicable Values:&lt;/b&gt;&lt;br&gt; | [optional] 
**CONTAINER** | **String** | The account&#x27;s container.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**postDate** | **String** | The date on which the transaction is posted to the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,insurance,loan&lt;br&gt; | [optional] 
**parentCategoryId** | **Number** | The parentCategoryId of the category assigned to the transaction.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: This field will be provided in the response if the transaction is assigned to a user-created category. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**subType** | **String** | The transaction subtype field provides a detailed transaction type. For example, purchase is a transaction type and the transaction subtype field indicates if the purchase was made using a debit or credit card.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: The transaction subtype field is available only in the United States, Canada, United Kingdom, and India.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**category** | **String** | The name of the category assigned to the transaction. This is the category field of the transaction category resource. The supported values are provided by the GET transactions/categories.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**runningBalance** | [**Money**](Money.md) |  | [optional] 
**categoryId** | **Number** | The id of the category assigned to the transaction. This is the id field of the transaction category resource. The supported values are provided by the GET transactions/categories.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt; | [optional] 
**holdingDescription** | **String** | For transactions involving securities, this captures the securities description.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**isin** | **String** | International Securities Identification Number (ISIN) standard is used worldwide to identify specific securities.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] 
**status** | **String** | The status of the transaction: pending or posted.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: Most FI sites only display posted transactions. If the FI site displays transaction status, same will be aggregated.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 

<a name="BaseTypeEnum"></a>
## Enum: BaseTypeEnum

* `CREDIT` (value: `"CREDIT"`)
* `DEBIT` (value: `"DEBIT"`)


<a name="CategorySourceEnum"></a>
## Enum: CategorySourceEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `USER` (value: `"USER"`)


<a name="CategoryTypeEnum"></a>
## Enum: CategoryTypeEnum

* `TRANSFER` (value: `"TRANSFER"`)
* `DEFERRED_COMPENSATION` (value: `"DEFERRED_COMPENSATION"`)
* `UNCATEGORIZE` (value: `"UNCATEGORIZE"`)
* `INCOME` (value: `"INCOME"`)
* `EXPENSE` (value: `"EXPENSE"`)


<a name="SourceTypeEnum"></a>
## Enum: SourceTypeEnum

* `AGGREGATED` (value: `"AGGREGATED"`)
* `MANUAL` (value: `"MANUAL"`)


<a name="CONTAINEREnum"></a>
## Enum: CONTAINEREnum

* `bank` (value: `"bank"`)
* `creditCard` (value: `"creditCard"`)
* `investment` (value: `"investment"`)
* `insurance` (value: `"insurance"`)
* `loan` (value: `"loan"`)
* `reward` (value: `"reward"`)
* `bill` (value: `"bill"`)
* `realEstate` (value: `"realEstate"`)
* `otherAssets` (value: `"otherAssets"`)
* `otherLiabilities` (value: `"otherLiabilities"`)


<a name="SubTypeEnum"></a>
## Enum: SubTypeEnum

* `OVERDRAFT_CHARGE` (value: `"OVERDRAFT_CHARGE"`)
* `ONLINE_PURCHASE` (value: `"ONLINE_PURCHASE"`)
* `TAX_PAYMENT` (value: `"TAX_PAYMENT"`)
* `PAYMENT_BY_CHECK` (value: `"PAYMENT_BY_CHECK"`)
* `ATM_CASH_WITHDRAWAL` (value: `"ATM_CASH_WITHDRAWAL"`)
* `SERVICE_CHARGE` (value: `"SERVICE_CHARGE"`)
* `RETURNED_CHECK_CHARGE` (value: `"RETURNED_CHECK_CHARGE"`)
* `STOP_PAYMENT_CHARGE` (value: `"STOP_PAYMENT_CHARGE"`)
* `CONVENIENCE_FEE` (value: `"CONVENIENCE_FEE"`)
* `AUTO_LOAN` (value: `"AUTO_LOAN"`)
* `HOME_LOAN_MORTGAGE` (value: `"HOME_LOAN_MORTGAGE"`)
* `RECURRING_SUBSCRIPTION_PAYMENT` (value: `"RECURRING_SUBSCRIPTION_PAYMENT"`)
* `INTEREST` (value: `"INTEREST"`)
* `PAYMENT` (value: `"PAYMENT"`)
* `PURCHASE` (value: `"PURCHASE"`)
* `REFUND` (value: `"REFUND"`)
* `TRANSFER` (value: `"TRANSFER"`)
* `FINANCE_CHARGE` (value: `"FINANCE_CHARGE"`)
* `OTHER_CHARGES_FEES` (value: `"OTHER_CHARGES_FEES"`)
* `ANNUAL_FEE` (value: `"ANNUAL_FEE"`)
* `DEPOSIT` (value: `"DEPOSIT"`)
* `DIRECT_DEPOSIT_SALARY` (value: `"DIRECT_DEPOSIT_SALARY"`)
* `INVESTMENT_INCOME_CASH` (value: `"INVESTMENT_INCOME_CASH"`)
* `SSA` (value: `"SSA"`)
* `REWARDS` (value: `"REWARDS"`)
* `TAX_REFUND` (value: `"TAX_REFUND"`)
* `CREDIT_CARD_PAYMENT` (value: `"CREDIT_CARD_PAYMENT"`)
* `INSURANCE_PAYMENT` (value: `"INSURANCE_PAYMENT"`)
* `UTILITIES_PAYMENT` (value: `"UTILITIES_PAYMENT"`)
* `CHILD_SUPPORT` (value: `"CHILD_SUPPORT"`)
* `LOAN` (value: `"LOAN"`)
* `PERSONAL_LOAN` (value: `"PERSONAL_LOAN"`)
* `STUDENT_LOAN` (value: `"STUDENT_LOAN"`)
* `REIMBURSEMENT` (value: `"REIMBURSEMENT"`)
* `BALANCE_TRANSFER` (value: `"BALANCE_TRANSFER"`)
* `OVERDRAFT_PROTECTION` (value: `"OVERDRAFT_PROTECTION"`)
* `CREDIT` (value: `"CREDIT"`)
* `NSF_FEES` (value: `"NSF_FEES"`)


<a name="StatusEnum"></a>
## Enum: StatusEnum

* `POSTED` (value: `"POSTED"`)
* `PENDING` (value: `"PENDING"`)
* `SCHEDULED` (value: `"SCHEDULED"`)
* `FAILED` (value: `"FAILED"`)
* `CLEARED` (value: `"CLEARED"`)

