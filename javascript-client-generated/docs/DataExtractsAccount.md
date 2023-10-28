# YodleeCoreApis.DataExtractsAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**availableCash** | [**Money**](Money.md) |  | [optional] 
**includeInNetWorth** | **Boolean** | Used to determine  whether an account to be considered in the networth calculation.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,loan,investment,insurance,realEstate,otherAssets,otherLiabilities&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**moneyMarketBalance** | [**Money**](Money.md) |  | [optional] 
**enrollmentDate** | **String** | Date on which the user is enrolled on the rewards program.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**estimatedDate** | **String** | The date on which the home value was estimated.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: realEstate&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**memo** | **String** | The additional description or notes given by the user.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**guarantor** | **String** | A nonprofit or state organization that works with lender, servicer, school, and the Department of Education to help successfully repay Federal Family Education Loan Program (FFELP) loans. If FFELP student loans default, the guarantor takes ownership of them.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**interestPaidLastYear** | [**Money**](Money.md) |  | [optional] 
**lastUpdated** | **String** | The date time the account information was last retrieved from the provider site and updated in the Yodlee system.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**balance** | [**Money**](Money.md) |  | [optional] 
**homeInsuranceType** | **String** | Type of home insurance, like -&lt;ul&gt;&lt;li&gt;HOME_OWNER&lt;/li&gt;&lt;li&gt;RENTAL&lt;/li&gt;&lt;li&gt;RENTER&lt;/li&gt;&lt;li&gt;etc..&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**id** | **Number** | The primary key of the account resource and the unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts &lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET investmentOptions&lt;/li&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;li&gt;POST accounts&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**cash** | [**Money**](Money.md) |  | [optional] 
**totalCreditLine** | [**Money**](Money.md) |  | [optional] 
**providerName** | **String** | Service provider or institution name where the account originates. This belongs to the provider resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**valuationType** | **String** | The valuation type indicates whether the home value is calculated either manually or by Yodlee Partners.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: realEstate&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**marginBalance** | [**Money**](Money.md) |  | [optional] 
**apr** | **Number** | The annual percentage rate (APR) is the yearly rate of interest on the credit card account.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt; The yearly percentage rate charged when a balance is held on a credit card. This rate of interest is applied every month on the outstanding credit card balance.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**availableCredit** | [**Money**](Money.md) |  | [optional] 
**currentBalance** | [**Money**](Money.md) |  | [optional] 
**isManual** | **Boolean** | Indicates if an account is aggregated from a site or it is a manual account i.e. account information manually provided by the user.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**escrowBalance** | [**Money**](Money.md) |  | [optional] 
**nextLevel** | **String** | The eligible next level of the rewards program.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**classification** | **String** | The classification of the account such as personal, corporate, etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, reward, loan, insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**loanPayoffAmount** | [**Money**](Money.md) |  | [optional] 
**interestRateType** | **String** | The type of the interest rate, for example, fixed or variable.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**loanPayByDate** | **String** | The date by which the payoff amount should be paid.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**faceAmount** | [**Money**](Money.md) |  | [optional] 
**policyFromDate** | **String** | The date the insurance policy began.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**premiumPaymentTerm** | **String** | The number of years for which premium payments have to be made in a policy.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**policyTerm** | **String** | The duration for which the policy is valid or in effect. For example, one year, five years, etc.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**repaymentPlanType** | **String** | The type of repayment plan that the borrower prefers to repay the loan. &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values:&lt;/b&gt;&lt;br&gt; | [optional] 
**aggregatedAccountType** | **String** | The type of account that is aggregated. | [optional] 
**availableBalance** | [**Money**](Money.md) |  | [optional] 
**accountStatus** | **String** | The status of the account that is updated by the consumer through an application or an API. Valid Values: AccountStatus&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;&lt;br&gt;&lt;b&gt;ACTIVE:&lt;/b&gt; All the added manual and aggregated accounts status will be made \&quot;ACTIVE\&quot; by default. &lt;br&gt;&lt;b&gt;TO_BE_CLOSED:&lt;/b&gt; If the aggregated accounts are not found or closed in the data provider site, Yodlee system marks the status as TO_BE_CLOSED&lt;br&gt;&lt;b&gt;INACTIVE:&lt;/b&gt; Users can update the status as INACTIVE to stop updating and to stop considering the account in other services&lt;br&gt;&lt;b&gt;CLOSED:&lt;/b&gt; Users can update the status as CLOSED, if the account is closed with the provider. &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**lifeInsuranceType** | **String** | Type of life insurance.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**premium** | [**Money**](Money.md) |  | [optional] 
**aggregationSource** | **String** | The source through which the account(s) are added in the system.&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;: SYSTEM, USER&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**isDeleted** | **Boolean** | Indicates if the account is marked as deleted.&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**overDraftLimit** | [**Money**](Money.md) |  | [optional] 
**nickname** | **String** | The nickname of the account as provided by the consumer to identify an account. The account nickname can be used instead of the account name.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**term** | **String** | The tenure for which the CD account is valid  or in case of loan, the number of years/months over which the loan amount  has to be repaid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;&lt;br&gt;  Bank: The Term field is only applicable for the account type CD.Loan: The period for which the loan agreement is in force. The period, before or at the end of which, the loan should either be repaid or renegotiated for another term.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**interestRate** | **Number** | &lt;br&gt;&lt;b&gt;Bank:&lt;/b&gt; The interest rate offered by a FI to its depositors on a bank account.&lt;br&gt;&lt;b&gt;Loan:&lt;/b&gt; Interest rate applied on the loan.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The Interest Rate field is only applicable for the following account types: savings, checking, money market, and certificate of deposit.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**deathBenefit** | [**Money**](Money.md) |  | [optional] 
**address** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**cashValue** | [**Money**](Money.md) |  | [optional] 
**_401kLoan** | [**Money**](Money.md) |  | [optional] 
**homeValue** | [**Money**](Money.md) |  | [optional] 
**accountNumber** | **String** | The account number as it appears on the site. (The POST accounts service response return this field as number)&lt;br&gt;&lt;b&gt;Additional Details&lt;/b&gt;:&lt;b&gt; Bank/ Loan/ Insurance/ Investment&lt;/b&gt;:&lt;br&gt; The account number for the bank account as it appears at the site.&lt;br&gt;&lt;b&gt;Credit Card&lt;/b&gt;: The account number of the card account as it appears at the site,&lt;br&gt;i.e., the card number.The account number can be full or partial based on how it is displayed in the account summary page of the site.In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST accounts&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**createdDate** | **String** | The date on which the account is created in the Yodlee system.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt; It is the date when the user links or aggregates the account(s) that are held with the provider to the Yodlee system.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**interestPaidYTD** | [**Money**](Money.md) |  | [optional] 
**providerAccountId** | **Number** | The primary key of the provider account resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isSelectedForAggregation** | **Boolean** | Indicates if the account is selected by user for aggregation.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**collateral** | **String** | Property or possession offered to support a loan that can be seized on a default.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**dataset** | [**[AccountDataset]**](AccountDataset.md) | Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**runningBalance** | [**Money**](Money.md) |  | [optional] 
**sourceId** | **String** | A unique ID that the provider site has assigned to the account. The source ID is only available for the HELD accounts.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, loan, reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**dueDate** | **String** | The date on which the due amount has to be paid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;&lt;br&gt;&lt;b&gt;Credit Card:&lt;/b&gt; The monthly date by when the minimum payment is due to be paid on the credit card account. &lt;br&gt;&lt;b&gt;Loan:&lt;/b&gt; The date on or before which the due amount should be paid.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**frequency** | **String** | The frequency of the billing cycle of the account in case of card. The frequency in which premiums are paid in an insurance policy such as monthly, quarterly, and annually. The frequency in which due amounts are paid in a loan  account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, insurance, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**maturityAmount** | [**Money**](Money.md) |  | [optional] 
**associatedProviderAccountId** | **[Number]** | The providerAccountIds that share the account with the primary providerAccountId that was created when the user had added the account for the first time.&lt;br&gt;&lt;b&gt;Additional Details&lt;/b&gt;: This attribute is returned in the response only if the account deduplication feature is enabled and the same account is mapped to more than one provider account IDs indicating the account is owned by more than one user, for example, joint accounts.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**isAsset** | **Boolean** | The account to be considered as an asset or liability.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**principalBalance** | [**Money**](Money.md) |  | [optional] 
**totalCashLimit** | [**Money**](Money.md) |  | [optional] 
**maturityDate** | **String** | The date when a certificate of deposit (CD/FD) matures or the final payment date of a loan at which point the principal amount (including pending interest) is due to be paid.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt; The date when a certificate of deposit (CD) matures, i.e., the money in the CD can be withdrawn without paying an early withdrawal penalty.The final payment date of a loan, i.e., the principal amount (including pending interest) is due to be paid.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**minimumAmountDue** | [**Money**](Money.md) |  | [optional] 
**annualPercentageYield** | **Number** | Annual percentage yield (APY) is a normalized representation of an interest rate, based on a compounding period of one year. APY generally refers to the rate paid to a depositor by a financial institution on an account.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**accountType** | **String** | The type of account that is aggregated, i.e., savings, checking, credit card, charge, HELOC, etc. The account type is derived based on the attributes of the account. &lt;br&gt;&lt;b&gt;Valid Values:&lt;/b&gt;&lt;br&gt;&lt;b&gt;Aggregated Account Type&lt;/b&gt;&lt;br&gt;&lt;b&gt;bank&lt;/b&gt;&lt;ul&gt;&lt;li&gt;CHECKING&lt;/li&gt;&lt;li&gt;SAVINGS&lt;/li&gt;&lt;li&gt;CD&lt;/li&gt;&lt;li&gt;PPF&lt;/li&gt;&lt;li&gt;RECURRING_DEPOSIT&lt;/li&gt;&lt;li&gt;FSA&lt;/li&gt;&lt;li&gt;MONEY_MARKET&lt;/li&gt;&lt;li&gt;IRA&lt;/li&gt;&lt;li&gt;PREPAID&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;creditCard&lt;/b&gt;&lt;ul&gt;&lt;li&gt;OTHER&lt;/li&gt;&lt;li&gt;CREDIT&lt;/li&gt;&lt;li&gt;STORE&lt;/li&gt;&lt;li&gt;CHARGE&lt;/li&gt;&lt;li&gt;OTHER&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;investment (SN 1.0)&lt;/b&gt;&lt;ul&gt;&lt;li&gt;BROKERAGE_MARGIN&lt;/li&gt;&lt;li&gt;HSA&lt;/li&gt;&lt;li&gt;IRA&lt;/li&gt;&lt;li&gt;BROKERAGE_CASH&lt;/li&gt;&lt;li&gt;401K&lt;/li&gt;&lt;li&gt;403B&lt;/li&gt;&lt;li&gt;TRUST&lt;/li&gt;&lt;li&gt;ANNUITY&lt;/li&gt;&lt;li&gt;SIMPLE&lt;/li&gt;&lt;li&gt;CUSTODIAL&lt;/li&gt;&lt;li&gt;BROKERAGE_CASH_OPTION&lt;/li&gt;&lt;li&gt;BROKERAGE_MARGIN_OPTION&lt;/li&gt;&lt;li&gt;INDIVIDUAL&lt;/li&gt;&lt;li&gt;CORPORATE&lt;/li&gt;&lt;li&gt;JTTIC&lt;/li&gt;&lt;li&gt;JTWROS&lt;/li&gt;&lt;li&gt;COMMUNITY_PROPERTY&lt;/li&gt;&lt;li&gt;JOINT_BY_ENTIRETY&lt;/li&gt;&lt;li&gt;CONSERVATORSHIP&lt;/li&gt;&lt;li&gt;ROTH&lt;/li&gt;&lt;li&gt;ROTH_CONVERSION&lt;/li&gt;&lt;li&gt;ROLLOVER&lt;/li&gt;&lt;li&gt;EDUCATIONAL&lt;/li&gt;&lt;li&gt;529_PLAN&lt;/li&gt;&lt;li&gt;457_DEFERRED_COMPENSATION&lt;/li&gt;&lt;li&gt;401A&lt;/li&gt;&lt;li&gt;PSP&lt;/li&gt;&lt;li&gt;MPP&lt;/li&gt;&lt;li&gt;STOCK_BASKET&lt;/li&gt;&lt;li&gt;LIVING_TRUST&lt;/li&gt;&lt;li&gt;REVOCABLE_TRUST&lt;/li&gt;&lt;li&gt;IRREVOCABLE_TRUST&lt;/li&gt;&lt;li&gt;CHARITABLE_REMAINDER&lt;/li&gt;&lt;li&gt;CHARITABLE_LEAD&lt;/li&gt;&lt;li&gt;CHARITABLE_GIFT_ACCOUNT&lt;/li&gt;&lt;li&gt;SEP&lt;/li&gt;&lt;li&gt;UTMA&lt;/li&gt;&lt;li&gt;UGMA&lt;/li&gt;&lt;li&gt;ESOPP&lt;/li&gt;&lt;li&gt;ADMINISTRATOR&lt;/li&gt;&lt;li&gt;EXECUTOR&lt;/li&gt;&lt;li&gt;PARTNERSHIP&lt;/li&gt;&lt;li&gt;SOLE_PROPRIETORSHIP&lt;/li&gt;&lt;li&gt;CHURCH&lt;/li&gt;&lt;li&gt;INVESTMENT_CLUB&lt;/li&gt;&lt;li&gt;RESTRICTED_STOCK_AWARD&lt;/li&gt;&lt;li&gt;CMA&lt;/li&gt;&lt;li&gt;EMPLOYEE_STOCK_PURCHASE_PLAN&lt;/li&gt;&lt;li&gt;PERFORMANCE_PLAN&lt;/li&gt;&lt;li&gt;BROKERAGE_LINK_ACCOUNT&lt;/li&gt;&lt;li&gt;MONEY_MARKET&lt;/li&gt;&lt;li&gt;SUPER_ANNUATION&lt;/li&gt;&lt;li&gt;REGISTERED_RETIREMENT_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;SPOUSAL_RETIREMENT_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;DEFERRED_PROFIT_SHARING_PLAN&lt;/li&gt;&lt;li&gt;NON_REGISTERED_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;REGISTERED_EDUCATION_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;GROUP_RETIREMENT_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;LOCKED_IN_RETIREMENT_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;RESTRICTED_LOCKED_IN_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;LOCKED_IN_RETIREMENT_ACCOUNT&lt;/li&gt;&lt;li&gt;REGISTERED_PENSION_PLAN&lt;/li&gt;&lt;li&gt;TAX_FREE_SAVINGS_ACCOUNT&lt;/li&gt;&lt;li&gt;LIFE_INCOME_FUND&lt;/li&gt;&lt;li&gt;REGISTERED_RETIREMENT_INCOME_FUND&lt;/li&gt;&lt;li&gt;SPOUSAL_RETIREMENT_INCOME_FUND&lt;/li&gt;&lt;li&gt;LOCKED_IN_REGISTERED_INVESTMENT_FUND&lt;/li&gt;&lt;li&gt;PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND&lt;/li&gt;&lt;li&gt;GUARANTEED_INVESTMENT_CERTIFICATES&lt;/li&gt;&lt;li&gt;REGISTERED_DISABILITY_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;DIGITAL_WALLET&lt;/li&gt;&lt;li&gt;OTHER&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;investment (SN 2.0)&lt;/b&gt;&lt;ul&gt;&lt;li&gt;BROKERAGE_CASH&lt;/li&gt;&lt;li&gt;BROKERAGE_MARGIN&lt;/li&gt;&lt;li&gt;INDIVIDUAL_RETIREMENT_ACCOUNT_IRA&lt;/li&gt;&lt;li&gt;EMPLOYEE_RETIREMENT_ACCOUNT_401K&lt;/li&gt;&lt;li&gt;EMPLOYEE_RETIREMENT_SAVINGS_PLAN_403B&lt;/li&gt;&lt;li&gt;TRUST&lt;/li&gt;&lt;li&gt;ANNUITY&lt;/li&gt;&lt;li&gt;SIMPLE_IRA&lt;/li&gt;&lt;li&gt;CUSTODIAL_ACCOUNT&lt;/li&gt;&lt;li&gt;BROKERAGE_CASH_OPTION&lt;/li&gt;&lt;li&gt;BROKERAGE_MARGIN_OPTION&lt;/li&gt;&lt;li&gt;INDIVIDUAL&lt;/li&gt;&lt;li&gt;CORPORATE_INVESTMENT_ACCOUNT&lt;/li&gt;&lt;li&gt;JOINT_TENANTS_TENANCY_IN_COMMON_JTIC&lt;/li&gt;&lt;li&gt;JOINT_TENANTS_WITH_RIGHTS_OF_SURVIVORSHIP_JTWROS&lt;/li&gt;&lt;li&gt;JOINT_TENANTS_COMMUNITY_PROPERTY&lt;/li&gt;&lt;li&gt;JOINT_TENANTS_TENANTS_BY_ENTIRETY&lt;/li&gt;&lt;li&gt;CONSERVATOR&lt;/li&gt;&lt;li&gt;ROTH_IRA&lt;/li&gt;&lt;li&gt;ROTH_CONVERSION&lt;/li&gt;&lt;li&gt;ROLLOVER_IRA&lt;/li&gt;&lt;li&gt;EDUCATIONAL&lt;/li&gt;&lt;li&gt;EDUCATIONAL_SAVINGS_PLAN_529&lt;/li&gt;&lt;li&gt;DEFERRED_COMPENSATION_PLAN_457&lt;/li&gt;&lt;li&gt;MONEY_PURCHASE_RETIREMENT_PLAN_401A&lt;/li&gt;&lt;li&gt;PROFIT_SHARING_PLAN&lt;/li&gt;&lt;li&gt;MONEY_PURCHASE_PLAN&lt;/li&gt;&lt;li&gt;STOCK_BASKET_ACCOUNT&lt;/li&gt;&lt;li&gt;LIVING_TRUST&lt;/li&gt;&lt;li&gt;REVOCABLE_TRUST&lt;/li&gt;&lt;li&gt;IRREVOCABLE_TRUST&lt;/li&gt;&lt;li&gt;CHARITABLE_REMAINDER_TRUST&lt;/li&gt;&lt;li&gt;CHARITABLE_LEAD_TRUST&lt;/li&gt;&lt;li&gt;CHARITABLE_GIFT_ACCOUNT&lt;/li&gt;&lt;li&gt;SEP_IRA&lt;/li&gt;&lt;li&gt;UNIFORM_TRANSFER_TO_MINORS_ACT_UTMA&lt;/li&gt;&lt;li&gt;UNIFORM_GIFT_TO_MINORS_ACT_UGMA&lt;/li&gt;&lt;li&gt;EMPLOYEE_STOCK_OWNERSHIP_PLAN_ESOP&lt;/li&gt;&lt;li&gt;ADMINISTRATOR&lt;/li&gt;&lt;li&gt;EXECUTOR&lt;/li&gt;&lt;li&gt;PARTNERSHIP&lt;/li&gt;&lt;li&gt;PROPRIETORSHIP&lt;/li&gt;&lt;li&gt;CHURCH_ACCOUNT&lt;/li&gt;&lt;li&gt;INVESTMENT_CLUB&lt;/li&gt;&lt;li&gt;RESTRICTED_STOCK_AWARD&lt;/li&gt;&lt;li&gt;CASH_MANAGEMENT_ACCOUNT&lt;/li&gt;&lt;li&gt;EMPLOYEE_STOCK_PURCHASE_PLAN_ESPP&lt;/li&gt;&lt;li&gt;PERFORMANCE_PLAN&lt;/li&gt;&lt;li&gt;BROKERAGE_LINK_ACCOUNT&lt;/li&gt;&lt;li&gt;MONEY_MARKET_ACCOUNT&lt;/li&gt;&lt;li&gt;SUPERANNUATION&lt;/li&gt;&lt;li&gt;REGISTERED_RETIREMENT_SAVINGS_PLAN_RRSP&lt;/li&gt;&lt;li&gt;SPOUSAL_RETIREMENT_SAVINGS_PLAN_SRSP&lt;/li&gt;&lt;li&gt;DEFERRED_PROFIT_SHARING_PLAN_DPSP&lt;/li&gt;&lt;li&gt;NON_REGISTERED_SAVINGS_PLAN_NRSP&lt;/li&gt;&lt;li&gt;REGISTERED_EDUCATION_SAVINGS_PLAN_RESP&lt;/li&gt;&lt;li&gt;GROUP_RETIREMENT_SAVINGS_PLAN_GRSP&lt;/li&gt;&lt;li&gt;LOCKED_IN_RETIREMENT_SAVINGS_PLAN_LRSP&lt;/li&gt;&lt;li&gt;RESTRICTED_LOCKED_IN_SAVINGS_PLAN_RLSP&lt;/li&gt;&lt;li&gt;LOCKED_IN_RETIREMENT_ACCOUNT_LIRA&lt;/li&gt;&lt;li&gt;REGISTERED_PENSION_PLAN_RPP&lt;/li&gt;&lt;li&gt;TAX_FREE_SAVINGS_ACCOUNT_TFSA&lt;/li&gt;&lt;li&gt;LIFE_INCOME_FUND_LIF&lt;/li&gt;&lt;li&gt;REGISTERED_RETIREMENT_INCOME_FUND_RIF&lt;/li&gt;&lt;li&gt;SPOUSAL_RETIREMENT_INCOME_FUND_SRIF&lt;/li&gt;&lt;li&gt;LOCKED_IN_REGISTERED_INVESTMENT_FUND_LRIF&lt;/li&gt;&lt;li&gt;PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND_PRIF&lt;/li&gt;&lt;li&gt;GUARANTEED_INVESTMENT_CERTIFICATES_GIC&lt;/li&gt;&lt;li&gt;REGISTERED_DISABILITY_SAVINGS_PLAN_RDSP&lt;/li&gt;&lt;li&gt;DEFINED_CONTRIBUTION_PLAN&lt;/li&gt;&lt;li&gt;DEFINED_BENEFIT_PLAN&lt;/li&gt;&lt;li&gt;EMPLOYEE_STOCK_OPTION_PLAN&lt;/li&gt;&lt;li&gt;NONQUALIFIED_DEFERRED_COMPENSATION_PLAN_409A&lt;/li&gt;&lt;li&gt;KEOGH_PLAN&lt;/li&gt;&lt;li&gt;EMPLOYEE_RETIREMENT_ACCOUNT_ROTH_401K&lt;/li&gt;&lt;li&gt;DEFERRED_CONTINGENT_CAPITAL_PLAN_DCCP&lt;/li&gt;&lt;li&gt;EMPLOYEE_BENEFIT_PLAN&lt;/li&gt;&lt;li&gt;EMPLOYEE_SAVINGS_PLAN&lt;/li&gt;&lt;li&gt;HEALTH_SAVINGS_ACCOUNT_HSA&lt;/li&gt;&lt;li&gt;COVERDELL_EDUCATION_SAVINGS_ACCOUNT_ESA&lt;/li&gt;&lt;li&gt;TESTAMENTARY_TRUST&lt;/li&gt;&lt;li&gt;ESTATE&lt;/li&gt;&lt;li&gt;GRANTOR_RETAINED_ANNUITY_TRUST_GRAT&lt;/li&gt;&lt;li&gt;ADVISORY_ACCOUNT&lt;/li&gt;&lt;li&gt;NON_PROFIT_ORGANIZATION_501C&lt;/li&gt;&lt;li&gt;HEALTH_REIMBURSEMENT_ARRANGEMENT_HRA&lt;/li&gt;&lt;li&gt;INDIVIDUAL_SAVINGS_ACCOUNT_ISA&lt;/li&gt;&lt;li&gt;CASH_ISA&lt;/li&gt;&lt;li&gt;STOCKS_AND_SHARES_ISA&lt;/li&gt;&lt;li&gt;INNOVATIVE_FINANCE_ISA&lt;/li&gt;&lt;li&gt;JUNIOR_ISA&lt;/li&gt;&lt;li&gt;EMPLOYEES_PROVIDENT_FUND_ORGANIZATION_EPFO&lt;/li&gt;&lt;li&gt;PUBLIC_PROVIDENT_FUND_PPF&lt;/li&gt;&lt;li&gt;EMPLOYEES_PENSION_SCHEME_EPS&lt;/li&gt;&lt;li&gt;NATIONAL_PENSION_SYSTEM_NPS&lt;/li&gt;&lt;li&gt;INDEXED_ANNUITY&lt;/li&gt;&lt;li&gt;ANNUITIZED_ANNUITY&lt;/li&gt;&lt;li&gt;VARIABLE_ANNUITY&lt;/li&gt;&lt;li&gt;ROTH_403B&lt;/li&gt;&lt;li&gt;SPOUSAL_IRA&lt;/li&gt;&lt;li&gt;SPOUSAL_ROTH_IRA&lt;/li&gt;&lt;li&gt;SARSEP_IRA&lt;/li&gt;&lt;li&gt;SUBSTANTIALLY_EQUAL_PERIODIC_PAYMENTS_SEPP&lt;/li&gt;&lt;li&gt;OFFSHORE_TRUST&lt;/li&gt;&lt;li&gt;IRREVOCABLE_LIFE_INSURANCE_TRUST&lt;/li&gt;&lt;li&gt;INTERNATIONAL_TRUST&lt;/li&gt;&lt;li&gt;LIFE_INTEREST_TRUST&lt;/li&gt;&lt;li&gt;EMPLOYEE_BENEFIT_TRUST&lt;/li&gt;&lt;li&gt;PRECIOUS_METAL_ACCOUNT&lt;/li&gt;&lt;li&gt;INVESTMENT_LOAN_ACCOUNT&lt;/li&gt;&lt;li&gt;GRANTOR_RETAINED_INCOME_TRUST&lt;/li&gt;&lt;li&gt;PENSION_PLAN&lt;/li&gt;&lt;li&gt;DIGITAL_WALLET&lt;/li&gt;&lt;li&gt;OTHER&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;loan&lt;/b&gt;&lt;ul&gt;&lt;li&gt;MORTGAGE&lt;/li&gt;&lt;li&gt;INSTALLMENT_LOAN&lt;/li&gt;&lt;li&gt;PERSONAL_LOAN&lt;/li&gt;&lt;li&gt;HOME_EQUITY_LINE_OF_CREDIT&lt;/li&gt;&lt;li&gt;LINE_OF_CREDIT&lt;/li&gt;&lt;li&gt;AUTO_LOAN&lt;/li&gt;&lt;li&gt;STUDENT_LOAN&lt;/li&gt;&lt;li&gt;HOME_LOAN&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;insurance&lt;/b&gt;&lt;ul&gt;&lt;li&gt;AUTO_INSURANCE&lt;/li&gt;&lt;li&gt;HEALTH_INSURANCE&lt;/li&gt;&lt;li&gt;HOME_INSURANCE&lt;/li&gt;&lt;li&gt;LIFE_INSURANCE&lt;/li&gt;&lt;li&gt;ANNUITY&lt;/li&gt;&lt;li&gt;TRAVEL_INSURANCE&lt;/li&gt;&lt;li&gt;INSURANCE&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;realEstate&lt;/b&gt;&lt;ul&gt; &lt;li&gt;REAL_ESTATE&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;reward&lt;/b&gt;&lt;ul&gt;&lt;li&gt;REWARD_POINTS&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Manual Account Type&lt;/b&gt;&lt;br&gt;&lt;b&gt;bank&lt;/b&gt;&lt;ul&gt;&lt;li&gt;CHECKING&lt;/li&gt;&lt;li&gt;SAVINGS&lt;/li&gt;&lt;li&gt;CD&lt;/li&gt;&lt;li&gt;PREPAID&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;credit&lt;/b&gt;&lt;ul&gt;  &lt;li&gt;CREDIT&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;loan&lt;/b&gt;&lt;ul&gt;  &lt;li&gt;PERSONAL_LOAN&lt;/li&gt;&lt;li&gt;HOME_LOAN&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;insurance&lt;/b&gt;&lt;ul&gt;&lt;li&gt;INSURANCE&lt;/li&gt;&lt;li&gt;ANNUITY&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;investment&lt;/b&gt;&lt;ul&gt;&lt;li&gt;BROKERAGE_CASH&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**originationDate** | **String** | The date on which the loan is disbursed.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**totalVestedBalance** | [**Money**](Money.md) |  | [optional] 
**rewardBalance** | [**[RewardBalance]**](RewardBalance.md) | Information of different reward balances associated with the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**sourceAccountStatus** | **String** | Indicates the status of the loan account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values:&lt;/b&gt;&lt;br&gt; | [optional] 
**linkedAccountIds** | **[Number]** | List of Loan accountId(s) to which the real-estate account is linked&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: realEstate&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**derivedApr** | **Number** | Derived APR will be an estimated purchase APR based on consumers credit card transactions and credit card purchase.&lt;br&gt;&lt;b&gt;Aggregated / Manual / Derived&lt;/b&gt;: Derived&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**policyEffectiveDate** | **String** | The date on which the insurance policy coverage commences.&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**totalUnvestedBalance** | [**Money**](Money.md) |  | [optional] 
**annuityBalance** | [**Money**](Money.md) |  | [optional] 
**accountName** | **String** | The account name as it appears at the site.&lt;br&gt;(The POST accounts service response return this field as name)&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All Containers&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**totalCreditLimit** | [**Money**](Money.md) |  | [optional] 
**policyStatus** | **String** | The status of the policy.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**shortBalance** | [**Money**](Money.md) |  | [optional] 
**lender** | **String** | The financial institution that provides the loan.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**lastEmployeeContributionAmount** | [**Money**](Money.md) |  | [optional] 
**providerId** | **String** | Identifier of the provider site. The primary key of provider resource. &lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Both &lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**lastPaymentDate** | **String** | The date on which the payment for the previous or current billing cycle is done.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt; If the payment is already done for the current billing cycle, then the field indicates the payment date of the current billing cycle. If payment is yet to be done for the current billing cycle, then the field indicates the date on which the payment was made for any of the previous billing cycles. The last payment date at the account-level can differ from the last payment date at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, loan, insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**primaryRewardUnit** | **String** | Primary reward unit for this reward program. E.g. miles, points, etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**lastPaymentAmount** | [**Money**](Money.md) |  | [optional] 
**remainingBalance** | [**Money**](Money.md) |  | [optional] 
**userClassification** | **String** | &lt;b&gt;Applicable containers&lt;/b&gt;: reward, bank, creditCard, investment, loan, insurance, realEstate, otherLiabilities&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts &lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST accounts&lt;/ul&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**bankTransferCode** | [**[BankTransferCode]**](BankTransferCode.md) | Bank and branch identification information.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**expirationDate** | **String** | The date on which the insurance policy expires or matures.&lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt; The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**coverage** | [**[Coverage]**](Coverage.md) | The coverage-related details of the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance,investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**cashApr** | **Number** | Annual percentage rate applied to cash withdrawals on the card.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**oauthMigrationStatus** | **String** | Indicates the migration status of the account from screen-scraping provider to the Open Banking provider. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**displayedName** | **String** | The name or identification of the account owner, as it appears at the FI site. &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, loan, reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**sourceProviderAccountId** | **Number** | The providerAccountId that is deleted and merged into the destinationProviderAccountId as part of the many-to-one OAuth migration process.&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**amountDue** | [**Money**](Money.md) |  | [optional] 
**currentLevel** | **String** | Current level of the reward program the user is associated with. E.g. Silver, Jade etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**originalLoanAmount** | [**Money**](Money.md) |  | [optional] 
**policyToDate** | **String** | The date to which the policy exists.&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: insurance&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**loanPayoffDetails** | [**LoanPayoffDetails**](LoanPayoffDetails.md) |  | [optional] 
**CONTAINER** | **String** | The type of service. E.g., Bank, Credit Card, Investment, Insurance, etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: All containers&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**lastEmployeeContributionDate** | **String** | The date on which the last employee contribution was made to the 401k account.&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; The last employee contribution date field is derived from the transaction data and not aggregated from the FI site. The field is only applicable to the 401k account type.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**lastPayment** | [**Money**](Money.md) |  | [optional] 
**recurringPayment** | [**Money**](Money.md) |  | [optional] 

<a name="HomeInsuranceTypeEnum"></a>
## Enum: HomeInsuranceTypeEnum

* `HOME_OWNER` (value: `"HOME_OWNER"`)
* `RENTAL` (value: `"RENTAL"`)
* `RENTER` (value: `"RENTER"`)
* `UNKNOWN` (value: `"UNKNOWN"`)
* `OTHER` (value: `"OTHER"`)


<a name="ValuationTypeEnum"></a>
## Enum: ValuationTypeEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `MANUAL` (value: `"MANUAL"`)


<a name="ClassificationEnum"></a>
## Enum: ClassificationEnum

* `OTHER` (value: `"OTHER"`)
* `PERSONAL` (value: `"PERSONAL"`)
* `CORPORATE` (value: `"CORPORATE"`)
* `SMALL_BUSINESS` (value: `"SMALL_BUSINESS"`)
* `TRUST` (value: `"TRUST"`)
* `ADD_ON_CARD` (value: `"ADD_ON_CARD"`)
* `VIRTUAL_CARD` (value: `"VIRTUAL_CARD"`)


<a name="InterestRateTypeEnum"></a>
## Enum: InterestRateTypeEnum

* `FIXED` (value: `"FIXED"`)
* `VARIABLE` (value: `"VARIABLE"`)
* `UNKNOWN` (value: `"UNKNOWN"`)
* `OTHER` (value: `"OTHER"`)


<a name="RepaymentPlanTypeEnum"></a>
## Enum: RepaymentPlanTypeEnum

* `STANDARD` (value: `"STANDARD"`)
* `GRADUATED` (value: `"GRADUATED"`)
* `EXTENDED` (value: `"EXTENDED"`)
* `INCOME_BASED` (value: `"INCOME_BASED"`)
* `INCOME_CONTINGENT` (value: `"INCOME_CONTINGENT"`)
* `INCOME_SENSITIVE` (value: `"INCOME_SENSITIVE"`)
* `PAY_AS_YOU_EARN` (value: `"PAY_AS_YOU_EARN"`)
* `REVISED_PAY_AS_YOU_EARN` (value: `"REVISED_PAY_AS_YOU_EARN"`)


<a name="AccountStatusEnum"></a>
## Enum: AccountStatusEnum

* `ACTIVE` (value: `"ACTIVE"`)
* `INACTIVE` (value: `"INACTIVE"`)
* `TO_BE_CLOSED` (value: `"TO_BE_CLOSED"`)
* `CLOSED` (value: `"CLOSED"`)
* `DELETED` (value: `"DELETED"`)


<a name="LifeInsuranceTypeEnum"></a>
## Enum: LifeInsuranceTypeEnum

* `OTHER` (value: `"OTHER"`)
* `TERM_LIFE_INSURANCE` (value: `"TERM_LIFE_INSURANCE"`)
* `UNIVERSAL_LIFE_INSURANCE` (value: `"UNIVERSAL_LIFE_INSURANCE"`)
* `WHOLE_LIFE_INSURANCE` (value: `"WHOLE_LIFE_INSURANCE"`)
* `VARIABLE_LIFE_INSURANCE` (value: `"VARIABLE_LIFE_INSURANCE"`)
* `ULIP` (value: `"ULIP"`)
* `ENDOWMENT` (value: `"ENDOWMENT"`)


<a name="AggregationSourceEnum"></a>
## Enum: AggregationSourceEnum

* `SYSTEM` (value: `"SYSTEM"`)
* `USER` (value: `"USER"`)


<a name="FrequencyEnum"></a>
## Enum: FrequencyEnum

* `DAILY` (value: `"DAILY"`)
* `ONE_TIME` (value: `"ONE_TIME"`)
* `WEEKLY` (value: `"WEEKLY"`)
* `eVERY2WEEKS` (value: `"EVERY_2_WEEKS"`)
* `SEMI_MONTHLY` (value: `"SEMI_MONTHLY"`)
* `MONTHLY` (value: `"MONTHLY"`)
* `QUARTERLY` (value: `"QUARTERLY"`)
* `SEMI_ANNUALLY` (value: `"SEMI_ANNUALLY"`)
* `ANNUALLY` (value: `"ANNUALLY"`)
* `eVERY2MONTHS` (value: `"EVERY_2_MONTHS"`)
* `EBILL` (value: `"EBILL"`)
* `FIRST_DAY_MONTHLY` (value: `"FIRST_DAY_MONTHLY"`)
* `LAST_DAY_MONTHLY` (value: `"LAST_DAY_MONTHLY"`)
* `eVERY4WEEKS` (value: `"EVERY_4_WEEKS"`)
* `UNKNOWN` (value: `"UNKNOWN"`)
* `OTHER` (value: `"OTHER"`)


<a name="SourceAccountStatusEnum"></a>
## Enum: SourceAccountStatusEnum

* `IN_REPAYMENT` (value: `"IN_REPAYMENT"`)
* `DEFAULTED` (value: `"DEFAULTED"`)
* `IN_SCHOOL` (value: `"IN_SCHOOL"`)
* `IN_GRACE_PERIOD` (value: `"IN_GRACE_PERIOD"`)
* `DELINQUENCY` (value: `"DELINQUENCY"`)
* `DEFERMENT` (value: `"DEFERMENT"`)
* `FORBEARANCE` (value: `"FORBEARANCE"`)


<a name="PolicyStatusEnum"></a>
## Enum: PolicyStatusEnum

* `ACTIVE` (value: `"ACTIVE"`)
* `IN_ACTIVE` (value: `"IN_ACTIVE"`)
* `OTHER` (value: `"OTHER"`)


<a name="UserClassificationEnum"></a>
## Enum: UserClassificationEnum

* `BUSINESS` (value: `"BUSINESS"`)
* `PERSONAL` (value: `"PERSONAL"`)


<a name="OauthMigrationStatusEnum"></a>
## Enum: OauthMigrationStatusEnum

* `IN_PROGRESS` (value: `"IN_PROGRESS"`)
* `TO_BE_MIGRATED` (value: `"TO_BE_MIGRATED"`)
* `COMPLETED` (value: `"COMPLETED"`)
* `MIGRATED` (value: `"MIGRATED"`)


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

