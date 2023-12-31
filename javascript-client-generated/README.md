# yodlee_core_apis

YodleeCoreApis - JavaScript client for yodlee_core_apis
This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
This SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.1.0
- Package version: 1.1.0
- Build package: io.swagger.codegen.v3.generators.javascript.JavaScriptClientCodegen

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

To publish the library as a [npm](https://www.npmjs.com/),
please follow the procedure in ["Publishing npm packages"](https://docs.npmjs.com/getting-started/publishing-npm-packages).

Then install it via:

```shell
npm install yodlee_core_apis --save
```

#### git
#
If the library is hosted at a git repository, e.g.
https://github.com/GIT_USER_ID/GIT_REPO_ID
then install it via:

```shell
    npm install GIT_USER_ID/GIT_REPO_ID --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following
the above steps with Node.js and installing browserify with `npm install -g browserify`,
perform the following (assuming *main.js* is your entry file):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

### Webpack Configuration

Using Webpack you may encounter the following error: "Module not found: Error:
Cannot resolve module", most certainly you should disable AMD loader. Add/merge
the following section to your webpack config:

```javascript
module: {
  rules: [
    {
      parser: {
        amd: false
      }
    }
  ]
}
```

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var YodleeCoreApis = require('yodlee_core_apis');

var api = new YodleeCoreApis.AccountsApi()
var body = new YodleeCoreApis.CreateAccountRequest(); // {CreateAccountRequest} accountParam

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.createManualAccount(body, callback);
```

## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*YodleeCoreApis.AccountsApi* | [**createManualAccount**](docs/AccountsApi.md#createManualAccount) | **POST** /accounts | Add Manual Account
*YodleeCoreApis.AccountsApi* | [**deleteAccount**](docs/AccountsApi.md#deleteAccount) | **DELETE** /accounts/{accountId} | Delete Account
*YodleeCoreApis.AccountsApi* | [**evaluateAddress**](docs/AccountsApi.md#evaluateAddress) | **POST** /accounts/evaluateAddress | Evaluate Address
*YodleeCoreApis.AccountsApi* | [**getAccount**](docs/AccountsApi.md#getAccount) | **GET** /accounts/{accountId} | Get Account Details
*YodleeCoreApis.AccountsApi* | [**getAllAccounts**](docs/AccountsApi.md#getAllAccounts) | **GET** /accounts | Get Accounts
*YodleeCoreApis.AccountsApi* | [**getHistoricalBalances**](docs/AccountsApi.md#getHistoricalBalances) | **GET** /accounts/historicalBalances | Get Historical Balances
*YodleeCoreApis.AccountsApi* | [**getLatestBalances**](docs/AccountsApi.md#getLatestBalances) | **GET** /accounts/latestBalances | Get Latest Balances
*YodleeCoreApis.AccountsApi* | [**updateAccount**](docs/AccountsApi.md#updateAccount) | **PUT** /accounts/{accountId} | Update Account
*YodleeCoreApis.AuthApi* | [**deleteApiKey**](docs/AuthApi.md#deleteApiKey) | **DELETE** /auth/apiKey/{key} | Delete API Key
*YodleeCoreApis.AuthApi* | [**deleteToken**](docs/AuthApi.md#deleteToken) | **DELETE** /auth/token | Delete Token
*YodleeCoreApis.AuthApi* | [**generateAccessToken**](docs/AuthApi.md#generateAccessToken) | **POST** /auth/token | Generate Access Token
*YodleeCoreApis.AuthApi* | [**generateApiKey**](docs/AuthApi.md#generateApiKey) | **POST** /auth/apiKey | Generate API Key
*YodleeCoreApis.AuthApi* | [**getApiKeys**](docs/AuthApi.md#getApiKeys) | **GET** /auth/apiKey | Get API Keys
*YodleeCoreApis.CobrandApi* | [**cobrandLogin**](docs/CobrandApi.md#cobrandLogin) | **POST** /cobrand/login | Cobrand Login
*YodleeCoreApis.CobrandApi* | [**cobrandLogout**](docs/CobrandApi.md#cobrandLogout) | **POST** /cobrand/logout | Cobrand Logout
*YodleeCoreApis.CobrandApi* | [**createSubscriptionEvent**](docs/CobrandApi.md#createSubscriptionEvent) | **POST** /cobrand/config/notifications/events/{eventName} | Subscribe Event
*YodleeCoreApis.CobrandApi* | [**deleteSubscribedEvent**](docs/CobrandApi.md#deleteSubscribedEvent) | **DELETE** /cobrand/config/notifications/events/{eventName} | Delete Subscription
*YodleeCoreApis.CobrandApi* | [**getPublicKey**](docs/CobrandApi.md#getPublicKey) | **GET** /cobrand/publicKey | Get Public Key
*YodleeCoreApis.CobrandApi* | [**getSubscribedEvents**](docs/CobrandApi.md#getSubscribedEvents) | **GET** /cobrand/config/notifications/events | Get Subscribed Events
*YodleeCoreApis.CobrandApi* | [**updateSubscribedEvent**](docs/CobrandApi.md#updateSubscribedEvent) | **PUT** /cobrand/config/notifications/events/{eventName} | Update Subscription
*YodleeCoreApis.ConfigsApi* | [**createSubscriptionNotificationEvent**](docs/ConfigsApi.md#createSubscriptionNotificationEvent) | **POST** /configs/notifications/events/{eventName} | Subscribe For Notification Event
*YodleeCoreApis.ConfigsApi* | [**deleteSubscribedNotificationEvent**](docs/ConfigsApi.md#deleteSubscribedNotificationEvent) | **DELETE** /configs/notifications/events/{eventName} | Delete Notification Subscription
*YodleeCoreApis.ConfigsApi* | [**getSubscribedNotificationEvents**](docs/ConfigsApi.md#getSubscribedNotificationEvents) | **GET** /configs/notifications/events | Get Subscribed Notification Events
*YodleeCoreApis.ConfigsApi* | [**updateSubscribedNotificationEvent**](docs/ConfigsApi.md#updateSubscribedNotificationEvent) | **PUT** /configs/notifications/events/{eventName} | Update Notification Subscription
*YodleeCoreApis.DataExtractsApi* | [**getDataExtractsEvents**](docs/DataExtractsApi.md#getDataExtractsEvents) | **GET** /dataExtracts/events | Get Events
*YodleeCoreApis.DataExtractsApi* | [**getDataExtractsUserData**](docs/DataExtractsApi.md#getDataExtractsUserData) | **GET** /dataExtracts/userData | Get userData
*YodleeCoreApis.DerivedApi* | [**getHoldingSummary**](docs/DerivedApi.md#getHoldingSummary) | **GET** /derived/holdingSummary | Get Holding Summary
*YodleeCoreApis.DerivedApi* | [**getNetworth**](docs/DerivedApi.md#getNetworth) | **GET** /derived/networth | Get Networth Summary
*YodleeCoreApis.DerivedApi* | [**getTransactionSummary**](docs/DerivedApi.md#getTransactionSummary) | **GET** /derived/transactionSummary | Get Transaction Summary
*YodleeCoreApis.DocumentsApi* | [**deleteDocument**](docs/DocumentsApi.md#deleteDocument) | **DELETE** /documents/{documentId} | Delete Document
*YodleeCoreApis.DocumentsApi* | [**downloadDocument**](docs/DocumentsApi.md#downloadDocument) | **GET** /documents/{documentId} | Download a Document
*YodleeCoreApis.DocumentsApi* | [**getDocuments**](docs/DocumentsApi.md#getDocuments) | **GET** /documents | Get Documents
*YodleeCoreApis.HoldingsApi* | [**getAssetClassificationList**](docs/HoldingsApi.md#getAssetClassificationList) | **GET** /holdings/assetClassificationList | Get Asset Classification List
*YodleeCoreApis.HoldingsApi* | [**getHoldingTypeList**](docs/HoldingsApi.md#getHoldingTypeList) | **GET** /holdings/holdingTypeList | Get Holding Type List
*YodleeCoreApis.HoldingsApi* | [**getHoldings**](docs/HoldingsApi.md#getHoldings) | **GET** /holdings | Get Holdings
*YodleeCoreApis.HoldingsApi* | [**getSecurities**](docs/HoldingsApi.md#getSecurities) | **GET** /holdings/securities | Get Security Details
*YodleeCoreApis.ProviderAccountsApi* | [**deleteProviderAccount**](docs/ProviderAccountsApi.md#deleteProviderAccount) | **DELETE** /providerAccounts/{providerAccountId} | Delete Provider Account
*YodleeCoreApis.ProviderAccountsApi* | [**editCredentialsOrRefreshProviderAccount**](docs/ProviderAccountsApi.md#editCredentialsOrRefreshProviderAccount) | **PUT** /providerAccounts | Update Account
*YodleeCoreApis.ProviderAccountsApi* | [**getAllProviderAccounts**](docs/ProviderAccountsApi.md#getAllProviderAccounts) | **GET** /providerAccounts | Get Provider Accounts
*YodleeCoreApis.ProviderAccountsApi* | [**getProviderAccount**](docs/ProviderAccountsApi.md#getProviderAccount) | **GET** /providerAccounts/{providerAccountId} | Get Provider Account Details
*YodleeCoreApis.ProviderAccountsApi* | [**getProviderAccountProfiles**](docs/ProviderAccountsApi.md#getProviderAccountProfiles) | **GET** /providerAccounts/profile | Get User Profile Details
*YodleeCoreApis.ProviderAccountsApi* | [**refreshProviderAccount**](docs/ProviderAccountsApi.md#refreshProviderAccount) | **PUT** /providerAccounts/refresh | Refresh Provider Account
*YodleeCoreApis.ProviderAccountsApi* | [**updatePreferences**](docs/ProviderAccountsApi.md#updatePreferences) | **PUT** /providerAccounts/{providerAccountId}/preferences | Update Preferences
*YodleeCoreApis.ProvidersApi* | [**getAllProviders**](docs/ProvidersApi.md#getAllProviders) | **GET** /providers | Get Providers
*YodleeCoreApis.ProvidersApi* | [**getProvider**](docs/ProvidersApi.md#getProvider) | **GET** /providers/{providerId} | Get Provider Details
*YodleeCoreApis.ProvidersApi* | [**getProvidersCount**](docs/ProvidersApi.md#getProvidersCount) | **GET** /providers/count | Get Providers Count
*YodleeCoreApis.StatementsApi* | [**getStatements**](docs/StatementsApi.md#getStatements) | **GET** /statements | Get Statements
*YodleeCoreApis.TransactionsApi* | [**createOrRunTransactionCategorizationRules**](docs/TransactionsApi.md#createOrRunTransactionCategorizationRules) | **POST** /transactions/categories/rules | Create or Run Transaction Categorization Rule
*YodleeCoreApis.TransactionsApi* | [**createTransactionCategory**](docs/TransactionsApi.md#createTransactionCategory) | **POST** /transactions/categories | Create Category
*YodleeCoreApis.TransactionsApi* | [**deleteTransactionCategorizationRule**](docs/TransactionsApi.md#deleteTransactionCategorizationRule) | **DELETE** /transactions/categories/rules/{ruleId} | Delete Transaction Categorization Rule
*YodleeCoreApis.TransactionsApi* | [**deleteTransactionCategory**](docs/TransactionsApi.md#deleteTransactionCategory) | **DELETE** /transactions/categories/{categoryId} | Delete Category
*YodleeCoreApis.TransactionsApi* | [**getTransactionCategories**](docs/TransactionsApi.md#getTransactionCategories) | **GET** /transactions/categories | Get Transaction Category List
*YodleeCoreApis.TransactionsApi* | [**getTransactionCategorizationRules**](docs/TransactionsApi.md#getTransactionCategorizationRules) | **GET** /transactions/categories/txnRules | Get Transaction Categorization Rules
*YodleeCoreApis.TransactionsApi* | [**getTransactionCategorizationRulesDeprecated**](docs/TransactionsApi.md#getTransactionCategorizationRulesDeprecated) | **GET** /transactions/categories/rules | Get Transaction Categorization Rules
*YodleeCoreApis.TransactionsApi* | [**getTransactions**](docs/TransactionsApi.md#getTransactions) | **GET** /transactions | Get Transactions
*YodleeCoreApis.TransactionsApi* | [**getTransactionsCount**](docs/TransactionsApi.md#getTransactionsCount) | **GET** /transactions/count | Get Transactions Count
*YodleeCoreApis.TransactionsApi* | [**runTransactionCategorizationRule**](docs/TransactionsApi.md#runTransactionCategorizationRule) | **POST** /transactions/categories/rules/{ruleId} | Run Transaction Categorization Rule
*YodleeCoreApis.TransactionsApi* | [**updateTransaction**](docs/TransactionsApi.md#updateTransaction) | **PUT** /transactions/{transactionId} | Update Transaction
*YodleeCoreApis.TransactionsApi* | [**updateTransactionCategorizationRule**](docs/TransactionsApi.md#updateTransactionCategorizationRule) | **PUT** /transactions/categories/rules/{ruleId} | Update Transaction Categorization Rule
*YodleeCoreApis.TransactionsApi* | [**updateTransactionCategory**](docs/TransactionsApi.md#updateTransactionCategory) | **PUT** /transactions/categories | Update Category
*YodleeCoreApis.UserApi* | [**getAccessTokens**](docs/UserApi.md#getAccessTokens) | **GET** /user/accessTokens | Get Access Tokens
*YodleeCoreApis.UserApi* | [**getUser**](docs/UserApi.md#getUser) | **GET** /user | Get User Details
*YodleeCoreApis.UserApi* | [**registerUser**](docs/UserApi.md#registerUser) | **POST** /user/register | Register User
*YodleeCoreApis.UserApi* | [**samlLogin**](docs/UserApi.md#samlLogin) | **POST** /user/samlLogin | Saml Login
*YodleeCoreApis.UserApi* | [**unregister**](docs/UserApi.md#unregister) | **DELETE** /user/unregister | Delete User
*YodleeCoreApis.UserApi* | [**updateUser**](docs/UserApi.md#updateUser) | **PUT** /user | Update User Details
*YodleeCoreApis.UserApi* | [**userLogout**](docs/UserApi.md#userLogout) | **POST** /user/logout | User Logout
*YodleeCoreApis.VerificationApi* | [**getHolderProfile**](docs/VerificationApi.md#getHolderProfile) | **GET** /verification/holderProfile | Get Holder Profile
*YodleeCoreApis.VerificationApi* | [**getVerificationStatus**](docs/VerificationApi.md#getVerificationStatus) | **GET** /verification | Get Verification Status
*YodleeCoreApis.VerificationApi* | [**getVerifiedAccounts**](docs/VerificationApi.md#getVerifiedAccounts) | **GET** /verification/verifiedAccounts | Get Verified Accounts
*YodleeCoreApis.VerificationApi* | [**initiateMatchingOrChallengeDepositeVerification**](docs/VerificationApi.md#initiateMatchingOrChallengeDepositeVerification) | **POST** /verification | Initiaite Challenge Deposit
*YodleeCoreApis.VerificationApi* | [**verifyChallengeDeposit**](docs/VerificationApi.md#verifyChallengeDeposit) | **PUT** /verification | Verify Challenge Deposit
*YodleeCoreApis.VerifyAccountApi* | [**initiateAccountVerification**](docs/VerifyAccountApi.md#initiateAccountVerification) | **POST** /verifyAccount/{providerAccountId} | Verify Accounts Using Transactions

## Documentation for Models

 - [YodleeCoreApis.AbstractAddress](docs/AbstractAddress.md)
 - [YodleeCoreApis.AccessTokens](docs/AccessTokens.md)
 - [YodleeCoreApis.Account](docs/Account.md)
 - [YodleeCoreApis.AccountAddress](docs/AccountAddress.md)
 - [YodleeCoreApis.AccountBalanceResponse](docs/AccountBalanceResponse.md)
 - [YodleeCoreApis.AccountDataset](docs/AccountDataset.md)
 - [YodleeCoreApis.AccountHistoricalBalancesResponse](docs/AccountHistoricalBalancesResponse.md)
 - [YodleeCoreApis.AccountHistory](docs/AccountHistory.md)
 - [YodleeCoreApis.AccountHolder](docs/AccountHolder.md)
 - [YodleeCoreApis.AccountLatestBalance](docs/AccountLatestBalance.md)
 - [YodleeCoreApis.AccountProfile](docs/AccountProfile.md)
 - [YodleeCoreApis.AccountResponse](docs/AccountResponse.md)
 - [YodleeCoreApis.ApiKeyOutput](docs/ApiKeyOutput.md)
 - [YodleeCoreApis.ApiKeyRequest](docs/ApiKeyRequest.md)
 - [YodleeCoreApis.ApiKeyResponse](docs/ApiKeyResponse.md)
 - [YodleeCoreApis.AssetClassification](docs/AssetClassification.md)
 - [YodleeCoreApis.AssetClassificationList](docs/AssetClassificationList.md)
 - [YodleeCoreApis.Attribute](docs/Attribute.md)
 - [YodleeCoreApis.AuthTokenBody](docs/AuthTokenBody.md)
 - [YodleeCoreApis.AutoRefresh](docs/AutoRefresh.md)
 - [YodleeCoreApis.BankTransferCode](docs/BankTransferCode.md)
 - [YodleeCoreApis.Capability](docs/Capability.md)
 - [YodleeCoreApis.ClientCredentialToken](docs/ClientCredentialToken.md)
 - [YodleeCoreApis.ClientCredentialTokenResponse](docs/ClientCredentialTokenResponse.md)
 - [YodleeCoreApis.Cobrand](docs/Cobrand.md)
 - [YodleeCoreApis.CobrandLoginRequest](docs/CobrandLoginRequest.md)
 - [YodleeCoreApis.CobrandLoginResponse](docs/CobrandLoginResponse.md)
 - [YodleeCoreApis.CobrandNotificationEvent](docs/CobrandNotificationEvent.md)
 - [YodleeCoreApis.CobrandNotificationResponse](docs/CobrandNotificationResponse.md)
 - [YodleeCoreApis.CobrandPublicKeyResponse](docs/CobrandPublicKeyResponse.md)
 - [YodleeCoreApis.CobrandSession](docs/CobrandSession.md)
 - [YodleeCoreApis.ConfigsNotificationEvent](docs/ConfigsNotificationEvent.md)
 - [YodleeCoreApis.ConfigsNotificationResponse](docs/ConfigsNotificationResponse.md)
 - [YodleeCoreApis.Contact](docs/Contact.md)
 - [YodleeCoreApis.ContainerAttributes](docs/ContainerAttributes.md)
 - [YodleeCoreApis.Coordinates](docs/Coordinates.md)
 - [YodleeCoreApis.Coverage](docs/Coverage.md)
 - [YodleeCoreApis.CoverageAmount](docs/CoverageAmount.md)
 - [YodleeCoreApis.CreateAccountInfo](docs/CreateAccountInfo.md)
 - [YodleeCoreApis.CreateAccountRequest](docs/CreateAccountRequest.md)
 - [YodleeCoreApis.CreateCobrandNotificationEvent](docs/CreateCobrandNotificationEvent.md)
 - [YodleeCoreApis.CreateCobrandNotificationEventRequest](docs/CreateCobrandNotificationEventRequest.md)
 - [YodleeCoreApis.CreateConfigsNotificationEvent](docs/CreateConfigsNotificationEvent.md)
 - [YodleeCoreApis.CreateConfigsNotificationEventRequest](docs/CreateConfigsNotificationEventRequest.md)
 - [YodleeCoreApis.CreatedAccountInfo](docs/CreatedAccountInfo.md)
 - [YodleeCoreApis.CreatedAccountResponse](docs/CreatedAccountResponse.md)
 - [YodleeCoreApis.DataExtractsAccount](docs/DataExtractsAccount.md)
 - [YodleeCoreApis.DataExtractsEvent](docs/DataExtractsEvent.md)
 - [YodleeCoreApis.DataExtractsEventData](docs/DataExtractsEventData.md)
 - [YodleeCoreApis.DataExtractsEventLinks](docs/DataExtractsEventLinks.md)
 - [YodleeCoreApis.DataExtractsEventResponse](docs/DataExtractsEventResponse.md)
 - [YodleeCoreApis.DataExtractsEventUserData](docs/DataExtractsEventUserData.md)
 - [YodleeCoreApis.DataExtractsHolding](docs/DataExtractsHolding.md)
 - [YodleeCoreApis.DataExtractsProviderAccount](docs/DataExtractsProviderAccount.md)
 - [YodleeCoreApis.DataExtractsTransaction](docs/DataExtractsTransaction.md)
 - [YodleeCoreApis.DataExtractsUser](docs/DataExtractsUser.md)
 - [YodleeCoreApis.DataExtractsUserData](docs/DataExtractsUserData.md)
 - [YodleeCoreApis.DataExtractsUserDataResponse](docs/DataExtractsUserDataResponse.md)
 - [YodleeCoreApis.DerivedCategorySummary](docs/DerivedCategorySummary.md)
 - [YodleeCoreApis.DerivedCategorySummaryDetails](docs/DerivedCategorySummaryDetails.md)
 - [YodleeCoreApis.DerivedHolding](docs/DerivedHolding.md)
 - [YodleeCoreApis.DerivedHoldingSummaryResponse](docs/DerivedHoldingSummaryResponse.md)
 - [YodleeCoreApis.DerivedHoldingsAccount](docs/DerivedHoldingsAccount.md)
 - [YodleeCoreApis.DerivedHoldingsLinks](docs/DerivedHoldingsLinks.md)
 - [YodleeCoreApis.DerivedHoldingsSummary](docs/DerivedHoldingsSummary.md)
 - [YodleeCoreApis.DerivedNetworth](docs/DerivedNetworth.md)
 - [YodleeCoreApis.DerivedNetworthHistoricalBalance](docs/DerivedNetworthHistoricalBalance.md)
 - [YodleeCoreApis.DerivedNetworthResponse](docs/DerivedNetworthResponse.md)
 - [YodleeCoreApis.DerivedTransactionSummaryResponse](docs/DerivedTransactionSummaryResponse.md)
 - [YodleeCoreApis.DerivedTransactionsLinks](docs/DerivedTransactionsLinks.md)
 - [YodleeCoreApis.DerivedTransactionsSummary](docs/DerivedTransactionsSummary.md)
 - [YodleeCoreApis.Description](docs/Description.md)
 - [YodleeCoreApis.DetailCategory](docs/DetailCategory.md)
 - [YodleeCoreApis.Document](docs/Document.md)
 - [YodleeCoreApis.DocumentDownload](docs/DocumentDownload.md)
 - [YodleeCoreApis.DocumentDownloadResponse](docs/DocumentDownloadResponse.md)
 - [YodleeCoreApis.DocumentResponse](docs/DocumentResponse.md)
 - [YodleeCoreApis.Email](docs/Email.md)
 - [YodleeCoreApis.EvaluateAccountAddress](docs/EvaluateAccountAddress.md)
 - [YodleeCoreApis.EvaluateAddressRequest](docs/EvaluateAddressRequest.md)
 - [YodleeCoreApis.EvaluateAddressResponse](docs/EvaluateAddressResponse.md)
 - [YodleeCoreApis.Field](docs/Field.md)
 - [YodleeCoreApis.FieldOperation](docs/FieldOperation.md)
 - [YodleeCoreApis.FullAccountNumberList](docs/FullAccountNumberList.md)
 - [YodleeCoreApis.HistoricalBalance](docs/HistoricalBalance.md)
 - [YodleeCoreApis.HolderProfileResponse](docs/HolderProfileResponse.md)
 - [YodleeCoreApis.Holding](docs/Holding.md)
 - [YodleeCoreApis.HoldingAssetClassificationListResponse](docs/HoldingAssetClassificationListResponse.md)
 - [YodleeCoreApis.HoldingResponse](docs/HoldingResponse.md)
 - [YodleeCoreApis.HoldingSecuritiesResponse](docs/HoldingSecuritiesResponse.md)
 - [YodleeCoreApis.HoldingTypeListResponse](docs/HoldingTypeListResponse.md)
 - [YodleeCoreApis.Identifier](docs/Identifier.md)
 - [YodleeCoreApis.LoanPayoffDetails](docs/LoanPayoffDetails.md)
 - [YodleeCoreApis.LoginForm](docs/LoginForm.md)
 - [YodleeCoreApis.Merchant](docs/Merchant.md)
 - [YodleeCoreApis.Money](docs/Money.md)
 - [YodleeCoreApis.Name](docs/Name.md)
 - [YodleeCoreApis.Option](docs/Option.md)
 - [YodleeCoreApis.PaymentBankTransferCode](docs/PaymentBankTransferCode.md)
 - [YodleeCoreApis.PaymentIdentifier](docs/PaymentIdentifier.md)
 - [YodleeCoreApis.PaymentProfile](docs/PaymentProfile.md)
 - [YodleeCoreApis.PhoneNumber](docs/PhoneNumber.md)
 - [YodleeCoreApis.Profile](docs/Profile.md)
 - [YodleeCoreApis.ProviderAccount](docs/ProviderAccount.md)
 - [YodleeCoreApis.ProviderAccountDetail](docs/ProviderAccountDetail.md)
 - [YodleeCoreApis.ProviderAccountDetailResponse](docs/ProviderAccountDetailResponse.md)
 - [YodleeCoreApis.ProviderAccountPreferences](docs/ProviderAccountPreferences.md)
 - [YodleeCoreApis.ProviderAccountPreferencesRequest](docs/ProviderAccountPreferencesRequest.md)
 - [YodleeCoreApis.ProviderAccountProfile](docs/ProviderAccountProfile.md)
 - [YodleeCoreApis.ProviderAccountRefreshRequest](docs/ProviderAccountRefreshRequest.md)
 - [YodleeCoreApis.ProviderAccountRequest](docs/ProviderAccountRequest.md)
 - [YodleeCoreApis.ProviderAccountResponse](docs/ProviderAccountResponse.md)
 - [YodleeCoreApis.ProviderAccountUserProfileResponse](docs/ProviderAccountUserProfileResponse.md)
 - [YodleeCoreApis.ProviderDetail](docs/ProviderDetail.md)
 - [YodleeCoreApis.ProviderDetailResponse](docs/ProviderDetailResponse.md)
 - [YodleeCoreApis.ProviderResponse](docs/ProviderResponse.md)
 - [YodleeCoreApis.Providers](docs/Providers.md)
 - [YodleeCoreApis.ProvidersCount](docs/ProvidersCount.md)
 - [YodleeCoreApis.ProvidersCountResponse](docs/ProvidersCountResponse.md)
 - [YodleeCoreApis.ProvidersDataset](docs/ProvidersDataset.md)
 - [YodleeCoreApis.RefreshProviderAccountResponse](docs/RefreshProviderAccountResponse.md)
 - [YodleeCoreApis.RewardBalance](docs/RewardBalance.md)
 - [YodleeCoreApis.Row](docs/Row.md)
 - [YodleeCoreApis.RuleClause](docs/RuleClause.md)
 - [YodleeCoreApis.Security](docs/Security.md)
 - [YodleeCoreApis.SecurityHolding](docs/SecurityHolding.md)
 - [YodleeCoreApis.Statement](docs/Statement.md)
 - [YodleeCoreApis.StatementResponse](docs/StatementResponse.md)
 - [YodleeCoreApis.StatusLink](docs/StatusLink.md)
 - [YodleeCoreApis.StockExchangeDetail](docs/StockExchangeDetail.md)
 - [YodleeCoreApis.TotalCount](docs/TotalCount.md)
 - [YodleeCoreApis.Transaction](docs/Transaction.md)
 - [YodleeCoreApis.TransactionCategorizationRule](docs/TransactionCategorizationRule.md)
 - [YodleeCoreApis.TransactionCategorizationRuleInfo](docs/TransactionCategorizationRuleInfo.md)
 - [YodleeCoreApis.TransactionCategorizationRuleRequest](docs/TransactionCategorizationRuleRequest.md)
 - [YodleeCoreApis.TransactionCategorizationRuleResponse](docs/TransactionCategorizationRuleResponse.md)
 - [YodleeCoreApis.TransactionCategory](docs/TransactionCategory.md)
 - [YodleeCoreApis.TransactionCategoryRequest](docs/TransactionCategoryRequest.md)
 - [YodleeCoreApis.TransactionCategoryResponse](docs/TransactionCategoryResponse.md)
 - [YodleeCoreApis.TransactionCount](docs/TransactionCount.md)
 - [YodleeCoreApis.TransactionCountResponse](docs/TransactionCountResponse.md)
 - [YodleeCoreApis.TransactionDays](docs/TransactionDays.md)
 - [YodleeCoreApis.TransactionRequest](docs/TransactionRequest.md)
 - [YodleeCoreApis.TransactionResponse](docs/TransactionResponse.md)
 - [YodleeCoreApis.TransactionTotal](docs/TransactionTotal.md)
 - [YodleeCoreApis.UpdateAccountInfo](docs/UpdateAccountInfo.md)
 - [YodleeCoreApis.UpdateAccountRequest](docs/UpdateAccountRequest.md)
 - [YodleeCoreApis.UpdateCategoryRequest](docs/UpdateCategoryRequest.md)
 - [YodleeCoreApis.UpdateCobrandNotificationEvent](docs/UpdateCobrandNotificationEvent.md)
 - [YodleeCoreApis.UpdateCobrandNotificationEventRequest](docs/UpdateCobrandNotificationEventRequest.md)
 - [YodleeCoreApis.UpdateConfigsNotificationEvent](docs/UpdateConfigsNotificationEvent.md)
 - [YodleeCoreApis.UpdateConfigsNotificationEventRequest](docs/UpdateConfigsNotificationEventRequest.md)
 - [YodleeCoreApis.UpdateTransaction](docs/UpdateTransaction.md)
 - [YodleeCoreApis.UpdateUserRegistration](docs/UpdateUserRegistration.md)
 - [YodleeCoreApis.UpdateUserRequest](docs/UpdateUserRequest.md)
 - [YodleeCoreApis.UpdateVerification](docs/UpdateVerification.md)
 - [YodleeCoreApis.UpdateVerificationRequest](docs/UpdateVerificationRequest.md)
 - [YodleeCoreApis.UpdatedProviderAccount](docs/UpdatedProviderAccount.md)
 - [YodleeCoreApis.UpdatedProviderAccountResponse](docs/UpdatedProviderAccountResponse.md)
 - [YodleeCoreApis.User](docs/User.md)
 - [YodleeCoreApis.UserAccessToken](docs/UserAccessToken.md)
 - [YodleeCoreApis.UserAccessTokensResponse](docs/UserAccessTokensResponse.md)
 - [YodleeCoreApis.UserAddress](docs/UserAddress.md)
 - [YodleeCoreApis.UserDetail](docs/UserDetail.md)
 - [YodleeCoreApis.UserDetailResponse](docs/UserDetailResponse.md)
 - [YodleeCoreApis.UserRegistration](docs/UserRegistration.md)
 - [YodleeCoreApis.UserRequest](docs/UserRequest.md)
 - [YodleeCoreApis.UserRequestPreferences](docs/UserRequestPreferences.md)
 - [YodleeCoreApis.UserResponse](docs/UserResponse.md)
 - [YodleeCoreApis.UserResponsePreferences](docs/UserResponsePreferences.md)
 - [YodleeCoreApis.UserSession](docs/UserSession.md)
 - [YodleeCoreApis.Verification](docs/Verification.md)
 - [YodleeCoreApis.VerificationAccount](docs/VerificationAccount.md)
 - [YodleeCoreApis.VerificationBankTransferCode](docs/VerificationBankTransferCode.md)
 - [YodleeCoreApis.VerificationHolder](docs/VerificationHolder.md)
 - [YodleeCoreApis.VerificationHolderProfile](docs/VerificationHolderProfile.md)
 - [YodleeCoreApis.VerificationRequest](docs/VerificationRequest.md)
 - [YodleeCoreApis.VerificationResponse](docs/VerificationResponse.md)
 - [YodleeCoreApis.VerificationStatus](docs/VerificationStatus.md)
 - [YodleeCoreApis.VerificationStatusResponse](docs/VerificationStatusResponse.md)
 - [YodleeCoreApis.VerificationTransaction](docs/VerificationTransaction.md)
 - [YodleeCoreApis.VerifiedAccount](docs/VerifiedAccount.md)
 - [YodleeCoreApis.VerifiedAccountResponse](docs/VerifiedAccountResponse.md)
 - [YodleeCoreApis.VerifiedAccounts](docs/VerifiedAccounts.md)
 - [YodleeCoreApis.VerifyAccount](docs/VerifyAccount.md)
 - [YodleeCoreApis.VerifyAccountRequest](docs/VerifyAccountRequest.md)
 - [YodleeCoreApis.VerifyAccountResponse](docs/VerifyAccountResponse.md)
 - [YodleeCoreApis.VerifyTransactionCriteria](docs/VerifyTransactionCriteria.md)
 - [YodleeCoreApis.YodleeError](docs/YodleeError.md)

## Documentation for Authorization

 All endpoints do not require authorization.

