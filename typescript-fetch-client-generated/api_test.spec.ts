/**
 * Yodlee Core APIs
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: developer@yodlee.com
 *
 * NOTE: This file is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the file manually.
 */

import * as api from "./api"
import { Configuration } from "./configuration"

const config: Configuration = {}

describe("AccountsApi", () => {
  let instance: api.AccountsApi
  beforeEach(function() {
    instance = new api.AccountsApi(config)
  });

  test("createManualAccount", () => {
    const body: api.CreateAccountRequest = undefined
    return expect(instance.createManualAccount(body, {})).resolves.toBe(null)
  })
  test("deleteAccount", () => {
    const accountId: number = 789
    return expect(instance.deleteAccount(accountId, {})).resolves.toBe(null)
  })
  test("evaluateAddress", () => {
    const body: api.EvaluateAddressRequest = undefined
    return expect(instance.evaluateAddress(body, {})).resolves.toBe(null)
  })
  test("getAccount", () => {
    const accountId: number = 789
    const include: string = "include_example"
    return expect(instance.getAccount(accountId, include, {})).resolves.toBe(null)
  })
  test("getAllAccounts", () => {
    const accountId: string = "accountId_example"
    const container: string = "container_example"
    const include: string = "include_example"
    const providerAccountId: string = "providerAccountId_example"
    const requestId: string = "requestId_example"
    const status: string = "status_example"
    return expect(instance.getAllAccounts(accountId, container, include, providerAccountId, requestId, status, {})).resolves.toBe(null)
  })
  test("getHistoricalBalances", () => {
    const accountId: string = "accountId_example"
    const fromDate: string = "fromDate_example"
    const includeCF: boolean = true
    const interval: string = "interval_example"
    const skip: number = 56
    const toDate: string = "toDate_example"
    const top: number = 56
    return expect(instance.getHistoricalBalances(accountId, fromDate, includeCF, interval, skip, toDate, top, {})).resolves.toBe(null)
  })
  test("getLatestBalances", () => {
    const accountId: string = "accountId_example"
    const providerAccountId: string = "providerAccountId_example"
    return expect(instance.getLatestBalances(accountId, providerAccountId, {})).resolves.toBe(null)
  })
  test("updateAccount", () => {
    const body: api.UpdateAccountRequest = undefined
    const accountId: number = 789
    return expect(instance.updateAccount(body, accountId, {})).resolves.toBe(null)
  })
})

describe("AuthApi", () => {
  let instance: api.AuthApi
  beforeEach(function() {
    instance = new api.AuthApi(config)
  });

  test("deleteApiKey", () => {
    const key: string = "key_example"
    return expect(instance.deleteApiKey(key, {})).resolves.toBe(null)
  })
  test("deleteToken", () => {
    return expect(instance.deleteToken({})).resolves.toBe(null)
  })
  test("generateAccessToken", () => {
    const clientId: string = "clientId_example"
    const secret: string = "secret_example"
    return expect(instance.generateAccessToken(clientId, secret, {})).resolves.toBe(null)
  })
  test("generateApiKey", () => {
    const body: api.ApiKeyRequest = undefined
    return expect(instance.generateApiKey(body, {})).resolves.toBe(null)
  })
  test("getApiKeys", () => {
    return expect(instance.getApiKeys({})).resolves.toBe(null)
  })
})

describe("CobrandApi", () => {
  let instance: api.CobrandApi
  beforeEach(function() {
    instance = new api.CobrandApi(config)
  });

  test("cobrandLogin", () => {
    const body: api.CobrandLoginRequest = undefined
    return expect(instance.cobrandLogin(body, {})).resolves.toBe(null)
  })
  test("cobrandLogout", () => {
    return expect(instance.cobrandLogout({})).resolves.toBe(null)
  })
  test("createSubscriptionEvent", () => {
    const body: api.CreateCobrandNotificationEventRequest = undefined
    const eventName: string = "eventName_example"
    return expect(instance.createSubscriptionEvent(body, eventName, {})).resolves.toBe(null)
  })
  test("deleteSubscribedEvent", () => {
    const eventName: string = "eventName_example"
    return expect(instance.deleteSubscribedEvent(eventName, {})).resolves.toBe(null)
  })
  test("getPublicKey", () => {
    return expect(instance.getPublicKey({})).resolves.toBe(null)
  })
  test("getSubscribedEvents", () => {
    const eventName: string = "eventName_example"
    return expect(instance.getSubscribedEvents(eventName, {})).resolves.toBe(null)
  })
  test("updateSubscribedEvent", () => {
    const body: api.UpdateCobrandNotificationEventRequest = undefined
    const eventName: string = "eventName_example"
    return expect(instance.updateSubscribedEvent(body, eventName, {})).resolves.toBe(null)
  })
})

describe("ConfigsApi", () => {
  let instance: api.ConfigsApi
  beforeEach(function() {
    instance = new api.ConfigsApi(config)
  });

  test("createSubscriptionNotificationEvent", () => {
    const body: api.CreateConfigsNotificationEventRequest = undefined
    const eventName: string = "eventName_example"
    return expect(instance.createSubscriptionNotificationEvent(body, eventName, {})).resolves.toBe(null)
  })
  test("deleteSubscribedNotificationEvent", () => {
    const eventName: string = "eventName_example"
    return expect(instance.deleteSubscribedNotificationEvent(eventName, {})).resolves.toBe(null)
  })
  test("getSubscribedNotificationEvents", () => {
    const eventName: string = "eventName_example"
    return expect(instance.getSubscribedNotificationEvents(eventName, {})).resolves.toBe(null)
  })
  test("updateSubscribedNotificationEvent", () => {
    const body: api.UpdateConfigsNotificationEventRequest = undefined
    const eventName: string = "eventName_example"
    return expect(instance.updateSubscribedNotificationEvent(body, eventName, {})).resolves.toBe(null)
  })
})

describe("DataExtractsApi", () => {
  let instance: api.DataExtractsApi
  beforeEach(function() {
    instance = new api.DataExtractsApi(config)
  });

  test("getDataExtractsEvents", () => {
    const eventName: string = "eventName_example"
    const fromDate: string = "fromDate_example"
    const toDate: string = "toDate_example"
    return expect(instance.getDataExtractsEvents(eventName, fromDate, toDate, {})).resolves.toBe(null)
  })
  test("getDataExtractsUserData", () => {
    const fromDate: string = "fromDate_example"
    const loginName: string = "loginName_example"
    const toDate: string = "toDate_example"
    return expect(instance.getDataExtractsUserData(fromDate, loginName, toDate, {})).resolves.toBe(null)
  })
})

describe("DerivedApi", () => {
  let instance: api.DerivedApi
  beforeEach(function() {
    instance = new api.DerivedApi(config)
  });

  test("getHoldingSummary", () => {
    const accountIds: string = "accountIds_example"
    const classificationType: string = "classificationType_example"
    const include: string = "include_example"
    return expect(instance.getHoldingSummary(accountIds, classificationType, include, {})).resolves.toBe(null)
  })
  test("getNetworth", () => {
    const accountIds: string = "accountIds_example"
    const container: string = "container_example"
    const fromDate: string = "fromDate_example"
    const include: string = "include_example"
    const interval: string = "interval_example"
    const skip: number = 56
    const toDate: string = "toDate_example"
    const top: number = 56
    return expect(instance.getNetworth(accountIds, container, fromDate, include, interval, skip, toDate, top, {})).resolves.toBe(null)
  })
  test("getTransactionSummary", () => {
    const groupBy: string = "groupBy_example"
    const accountId: string = "accountId_example"
    const categoryId: string = "categoryId_example"
    const categoryType: string = "categoryType_example"
    const fromDate: string = "fromDate_example"
    const include: string = "include_example"
    const includeUserCategory: boolean = true
    const interval: string = "interval_example"
    const toDate: string = "toDate_example"
    return expect(instance.getTransactionSummary(groupBy, accountId, categoryId, categoryType, fromDate, include, includeUserCategory, interval, toDate, {})).resolves.toBe(null)
  })
})

describe("DocumentsApi", () => {
  let instance: api.DocumentsApi
  beforeEach(function() {
    instance = new api.DocumentsApi(config)
  });

  test("deleteDocument", () => {
    const documentId: string = "documentId_example"
    return expect(instance.deleteDocument(documentId, {})).resolves.toBe(null)
  })
  test("downloadDocument", () => {
    const documentId: string = "documentId_example"
    return expect(instance.downloadDocument(documentId, {})).resolves.toBe(null)
  })
  test("getDocuments", () => {
    const keyword: string = "keyword_example"
    const accountId: string = "accountId_example"
    const docType: string = "docType_example"
    const fromDate: string = "fromDate_example"
    const toDate: string = "toDate_example"
    return expect(instance.getDocuments(keyword, accountId, docType, fromDate, toDate, {})).resolves.toBe(null)
  })
})

describe("HoldingsApi", () => {
  let instance: api.HoldingsApi
  beforeEach(function() {
    instance = new api.HoldingsApi(config)
  });

  test("getAssetClassificationList", () => {
    return expect(instance.getAssetClassificationList({})).resolves.toBe(null)
  })
  test("getHoldingTypeList", () => {
    return expect(instance.getHoldingTypeList({})).resolves.toBe(null)
  })
  test("getHoldings", () => {
    const accountId: string = "accountId_example"
    const assetClassificationClassificationType: string = "assetClassificationClassificationType_example"
    const classificationValue: string = "classificationValue_example"
    const include: string = "include_example"
    const providerAccountId: string = "providerAccountId_example"
    return expect(instance.getHoldings(accountId, assetClassificationClassificationType, classificationValue, include, providerAccountId, {})).resolves.toBe(null)
  })
  test("getSecurities", () => {
    const holdingId: string = "holdingId_example"
    return expect(instance.getSecurities(holdingId, {})).resolves.toBe(null)
  })
})

describe("ProviderAccountsApi", () => {
  let instance: api.ProviderAccountsApi
  beforeEach(function() {
    instance = new api.ProviderAccountsApi(config)
  });

  test("deleteProviderAccount", () => {
    const providerAccountId: number = 789
    return expect(instance.deleteProviderAccount(providerAccountId, {})).resolves.toBe(null)
  })
  test("editCredentialsOrRefreshProviderAccount", () => {
    const providerAccountIds: string = "providerAccountIds_example"
    const body: api.ProviderAccountRequest = undefined
    return expect(instance.editCredentialsOrRefreshProviderAccount(providerAccountIds, body, {})).resolves.toBe(null)
  })
  test("getAllProviderAccounts", () => {
    const include: string = "include_example"
    const providerIds: string = "providerIds_example"
    return expect(instance.getAllProviderAccounts(include, providerIds, {})).resolves.toBe(null)
  })
  test("getProviderAccount", () => {
    const providerAccountId: number = 789
    const include: string = "include_example"
    const requestId: string = "requestId_example"
    return expect(instance.getProviderAccount(providerAccountId, include, requestId, {})).resolves.toBe(null)
  })
  test("getProviderAccountProfiles", () => {
    const providerAccountId: string = "providerAccountId_example"
    return expect(instance.getProviderAccountProfiles(providerAccountId, {})).resolves.toBe(null)
  })
  test("refreshProviderAccount", () => {
    const body: api.ProviderAccountRefreshRequest = undefined
    return expect(instance.refreshProviderAccount(body, {})).resolves.toBe(null)
  })
  test("updatePreferences", () => {
    const body: api.ProviderAccountPreferencesRequest = undefined
    const providerAccountId: number = 789
    return expect(instance.updatePreferences(body, providerAccountId, {})).resolves.toBe(null)
  })
})

describe("ProvidersApi", () => {
  let instance: api.ProvidersApi
  beforeEach(function() {
    instance = new api.ProvidersApi(config)
  });

  test("getAllProviders", () => {
    const capability: string = "capability_example"
    const institutionId: number = 789
    const name: string = "name_example"
    const priority: string = "priority_example"
    const providerId: string = "providerId_example"
    const skip: number = 56
    const top: number = 56
    return expect(instance.getAllProviders(capability, institutionId, name, priority, providerId, skip, top, {})).resolves.toBe(null)
  })
  test("getProvider", () => {
    const providerId: number = 789
    return expect(instance.getProvider(providerId, {})).resolves.toBe(null)
  })
  test("getProvidersCount", () => {
    const capability: string = "capability_example"
    const name: string = "name_example"
    const priority: string = "priority_example"
    return expect(instance.getProvidersCount(capability, name, priority, {})).resolves.toBe(null)
  })
})

describe("StatementsApi", () => {
  let instance: api.StatementsApi
  beforeEach(function() {
    instance = new api.StatementsApi(config)
  });

  test("getStatements", () => {
    const accountId: string = "accountId_example"
    const container: string = "container_example"
    const fromDate: string = "fromDate_example"
    const isLatest: string = "isLatest_example"
    const status: string = "status_example"
    return expect(instance.getStatements(accountId, container, fromDate, isLatest, status, {})).resolves.toBe(null)
  })
})

describe("TransactionsApi", () => {
  let instance: api.TransactionsApi
  beforeEach(function() {
    instance = new api.TransactionsApi(config)
  });

  test("createOrRunTransactionCategorizationRules", () => {
    const action: string = "action_example"
    const ruleParam: string = "ruleParam_example"
    return expect(instance.createOrRunTransactionCategorizationRules(action, ruleParam, {})).resolves.toBe(null)
  })
  test("createTransactionCategory", () => {
    const body: api.TransactionCategoryRequest = undefined
    return expect(instance.createTransactionCategory(body, {})).resolves.toBe(null)
  })
  test("deleteTransactionCategorizationRule", () => {
    const ruleId: number = 789
    return expect(instance.deleteTransactionCategorizationRule(ruleId, {})).resolves.toBe(null)
  })
  test("deleteTransactionCategory", () => {
    const categoryId: number = 789
    return expect(instance.deleteTransactionCategory(categoryId, {})).resolves.toBe(null)
  })
  test("getTransactionCategories", () => {
    return expect(instance.getTransactionCategories({})).resolves.toBe(null)
  })
  test("getTransactionCategorizationRules", () => {
    return expect(instance.getTransactionCategorizationRules({})).resolves.toBe(null)
  })
  test("getTransactionCategorizationRulesDeprecated", () => {
    return expect(instance.getTransactionCategorizationRulesDeprecated({})).resolves.toBe(null)
  })
  test("getTransactions", () => {
    const accountId: string = "accountId_example"
    const baseType: string = "baseType_example"
    const categoryId: string = "categoryId_example"
    const categoryType: string = "categoryType_example"
    const container: string = "container_example"
    const detailCategoryId: string = "detailCategoryId_example"
    const fromDate: string = "fromDate_example"
    const highLevelCategoryId: string = "highLevelCategoryId_example"
    const keyword: string = "keyword_example"
    const skip: number = 56
    const toDate: string = "toDate_example"
    const top: number = 56
    const type: string = "type_example"
    return expect(instance.getTransactions(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, skip, toDate, top, type, {})).resolves.toBe(null)
  })
  test("getTransactionsCount", () => {
    const accountId: string = "accountId_example"
    const baseType: string = "baseType_example"
    const categoryId: string = "categoryId_example"
    const categoryType: string = "categoryType_example"
    const container: string = "container_example"
    const detailCategoryId: string = "detailCategoryId_example"
    const fromDate: string = "fromDate_example"
    const highLevelCategoryId: string = "highLevelCategoryId_example"
    const keyword: string = "keyword_example"
    const toDate: string = "toDate_example"
    const type: string = "type_example"
    return expect(instance.getTransactionsCount(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, toDate, type, {})).resolves.toBe(null)
  })
  test("runTransactionCategorizationRule", () => {
    const action: string = "action_example"
    const ruleId: number = 789
    return expect(instance.runTransactionCategorizationRule(action, ruleId, {})).resolves.toBe(null)
  })
  test("updateTransaction", () => {
    const body: api.TransactionRequest = undefined
    const transactionId: number = 789
    return expect(instance.updateTransaction(body, transactionId, {})).resolves.toBe(null)
  })
  test("updateTransactionCategorizationRule", () => {
    const body: api.TransactionCategorizationRuleRequest = undefined
    const ruleId: number = 789
    return expect(instance.updateTransactionCategorizationRule(body, ruleId, {})).resolves.toBe(null)
  })
  test("updateTransactionCategory", () => {
    const body: api.UpdateCategoryRequest = undefined
    return expect(instance.updateTransactionCategory(body, {})).resolves.toBe(null)
  })
})

describe("UserApi", () => {
  let instance: api.UserApi
  beforeEach(function() {
    instance = new api.UserApi(config)
  });

  test("getAccessTokens", () => {
    const appIds: string = "appIds_example"
    return expect(instance.getAccessTokens(appIds, {})).resolves.toBe(null)
  })
  test("getUser", () => {
    return expect(instance.getUser({})).resolves.toBe(null)
  })
  test("registerUser", () => {
    const body: api.UserRequest = undefined
    return expect(instance.registerUser(body, {})).resolves.toBe(null)
  })
  test("samlLogin", () => {
    const issuer: string = "issuer_example"
    const samlResponse: string = "samlResponse_example"
    const source: string = "source_example"
    return expect(instance.samlLogin(issuer, samlResponse, source, {})).resolves.toBe(null)
  })
  test("unregister", () => {
    return expect(instance.unregister({})).resolves.toBe(null)
  })
  test("updateUser", () => {
    const body: api.UpdateUserRequest = undefined
    return expect(instance.updateUser(body, {})).resolves.toBe(null)
  })
  test("userLogout", () => {
    return expect(instance.userLogout({})).resolves.toBe(null)
  })
})

describe("VerificationApi", () => {
  let instance: api.VerificationApi
  beforeEach(function() {
    instance = new api.VerificationApi(config)
  });

  test("getHolderProfile", () => {
    const providerAccountId: string = "providerAccountId_example"
    const accountId: string = "accountId_example"
    return expect(instance.getHolderProfile(providerAccountId, accountId, {})).resolves.toBe(null)
  })
  test("getVerificationStatus", () => {
    const accountId: string = "accountId_example"
    const providerAccountId: string = "providerAccountId_example"
    const verificationType: string = "verificationType_example"
    return expect(instance.getVerificationStatus(accountId, providerAccountId, verificationType, {})).resolves.toBe(null)
  })
  test("getVerifiedAccounts", () => {
    const providerAccountId: string = "providerAccountId_example"
    const accountId: string = "accountId_example"
    const isSelected: string = "isSelected_example"
    const verificationStatus: string = "verificationStatus_example"
    return expect(instance.getVerifiedAccounts(providerAccountId, accountId, isSelected, verificationStatus, {})).resolves.toBe(null)
  })
  test("initiateMatchingOrChallengeDepositeVerification", () => {
    const body: api.VerificationRequest = undefined
    return expect(instance.initiateMatchingOrChallengeDepositeVerification(body, {})).resolves.toBe(null)
  })
  test("verifyChallengeDeposit", () => {
    const body: api.UpdateVerificationRequest = undefined
    return expect(instance.verifyChallengeDeposit(body, {})).resolves.toBe(null)
  })
})

describe("VerifyAccountApi", () => {
  let instance: api.VerifyAccountApi
  beforeEach(function() {
    instance = new api.VerifyAccountApi(config)
  });

  test("initiateAccountVerification", () => {
    const body: api.VerifyAccountRequest = undefined
    const providerAccountId: string = "providerAccountId_example"
    return expect(instance.initiateAccountVerification(body, providerAccountId, {})).resolves.toBe(null)
  })
})

