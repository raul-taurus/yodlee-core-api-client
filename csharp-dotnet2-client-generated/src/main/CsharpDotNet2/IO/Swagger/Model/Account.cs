using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Account {
    /// <summary>
    /// Gets or Sets AvailableCash
    /// </summary>
    [DataMember(Name="availableCash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableCash")]
    public Money AvailableCash { get; set; }

    /// <summary>
    /// Used to determine  whether an account to be considered in the networth calculation.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank,creditCard,loan,investment,insurance,realEstate,otherAssets,otherLiabilities<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Used to determine  whether an account to be considered in the networth calculation.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank,creditCard,loan,investment,insurance,realEstate,otherAssets,otherLiabilities<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="includeInNetWorth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInNetWorth")]
    public bool? IncludeInNetWorth { get; set; }

    /// <summary>
    /// Gets or Sets MoneyMarketBalance
    /// </summary>
    [DataMember(Name="moneyMarketBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moneyMarketBalance")]
    public Money MoneyMarketBalance { get; set; }

    /// <summary>
    /// Date on which the user is enrolled on the rewards program.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Date on which the user is enrolled on the rewards program.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="enrollmentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enrollmentDate")]
    public string EnrollmentDate { get; set; }

    /// <summary>
    /// The date on which the home value was estimated.<br><br><b>Aggregated / Manual</b>: Manual<br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the home value was estimated.<br><br><b>Aggregated / Manual</b>: Manual<br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="estimatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "estimatedDate")]
    public string EstimatedDate { get; set; }

    /// <summary>
    /// The additional description or notes given by the user.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The additional description or notes given by the user.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="memo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memo")]
    public string Memo { get; set; }

    /// <summary>
    /// A nonprofit or state organization that works with lender, servicer, school, and the Department of Education to help successfully repay Federal Family Education Loan Program (FFELP) loans. If FFELP student loans default, the guarantor takes ownership of them.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>A nonprofit or state organization that works with lender, servicer, school, and the Department of Education to help successfully repay Federal Family Education Loan Program (FFELP) loans. If FFELP student loans default, the guarantor takes ownership of them.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="guarantor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guarantor")]
    public string Guarantor { get; set; }

    /// <summary>
    /// Gets or Sets InterestPaidLastYear
    /// </summary>
    [DataMember(Name="interestPaidLastYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestPaidLastYear")]
    public Money InterestPaidLastYear { get; set; }

    /// <summary>
    /// The date time the account information was last retrieved from the provider site and updated in the Yodlee system.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date time the account information was last retrieved from the provider site and updated in the Yodlee system.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Money Balance { get; set; }

    /// <summary>
    /// Type of home insurance, like -<ul><li>HOME_OWNER</li><li>RENTAL</li><li>RENTER</li><li>etc..</li></ul><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Type of home insurance, like -<ul><li>HOME_OWNER</li><li>RENTAL</li><li>RENTER</li><li>etc..</li></ul><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="homeInsuranceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeInsuranceType")]
    public string HomeInsuranceType { get; set; }

    /// <summary>
    /// The primary key of the account resource and the unique identifier for the account.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts </li><li>GET accounts/{accountId}</li><li>GET investmentOptions</li><li>GET accounts/historicalBalances</li><li>POST accounts</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The primary key of the account resource and the unique identifier for the account.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts </li><li>GET accounts/{accountId}</li><li>GET investmentOptions</li><li>GET accounts/historicalBalances</li><li>POST accounts</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Cash
    /// </summary>
    [DataMember(Name="cash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cash")]
    public Money Cash { get; set; }

    /// <summary>
    /// Gets or Sets TotalCreditLine
    /// </summary>
    [DataMember(Name="totalCreditLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCreditLine")]
    public Money TotalCreditLine { get; set; }

    /// <summary>
    /// Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="providerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerName")]
    public string ProviderName { get; set; }

    /// <summary>
    /// The valuation type indicates whether the home value is calculated either manually or by Yodlee Partners.<br><br><b>Aggregated / Manual</b>: Manual<br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The valuation type indicates whether the home value is calculated either manually or by Yodlee Partners.<br><br><b>Aggregated / Manual</b>: Manual<br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="valuationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valuationType")]
    public string ValuationType { get; set; }

    /// <summary>
    /// Gets or Sets MarginBalance
    /// </summary>
    [DataMember(Name="marginBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginBalance")]
    public Money MarginBalance { get; set; }

    /// <summary>
    /// The annual percentage rate (APR) is the yearly rate of interest on the credit card account.<br><b>Additional Details:</b> The yearly percentage rate charged when a balance is held on a credit card. This rate of interest is applied every month on the outstanding credit card balance.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The annual percentage rate (APR) is the yearly rate of interest on the credit card account.<br><b>Additional Details:</b> The yearly percentage rate charged when a balance is held on a credit card. This rate of interest is applied every month on the outstanding credit card balance.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="apr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apr")]
    public double? Apr { get; set; }

    /// <summary>
    /// Gets or Sets AvailableCredit
    /// </summary>
    [DataMember(Name="availableCredit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableCredit")]
    public Money AvailableCredit { get; set; }

    /// <summary>
    /// Gets or Sets CurrentBalance
    /// </summary>
    [DataMember(Name="currentBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentBalance")]
    public Money CurrentBalance { get; set; }

    /// <summary>
    /// Indicates if an account is aggregated from a site or it is a manual account i.e. account information manually provided by the user.<br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicates if an account is aggregated from a site or it is a manual account i.e. account information manually provided by the user.<br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="isManual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isManual")]
    public bool? IsManual { get; set; }

    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile")]
    public AccountProfile Profile { get; set; }

    /// <summary>
    /// Gets or Sets EscrowBalance
    /// </summary>
    [DataMember(Name="escrowBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "escrowBalance")]
    public Money EscrowBalance { get; set; }

    /// <summary>
    /// The eligible next level of the rewards program.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The eligible next level of the rewards program.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="nextLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextLevel")]
    public string NextLevel { get; set; }

    /// <summary>
    /// The classification of the account such as personal, corporate, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, creditCard, investment, reward, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The classification of the account such as personal, corporate, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, creditCard, investment, reward, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="classification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classification")]
    public string Classification { get; set; }

    /// <summary>
    /// Gets or Sets LoanPayoffAmount
    /// </summary>
    [DataMember(Name="loanPayoffAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loanPayoffAmount")]
    public Money LoanPayoffAmount { get; set; }

    /// <summary>
    /// The type of the interest rate, for example, fixed or variable.<br><b>Applicable containers</b>: loan<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of the interest rate, for example, fixed or variable.<br><b>Applicable containers</b>: loan<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="interestRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestRateType")]
    public string InterestRateType { get; set; }

    /// <summary>
    /// The date by which the payoff amount should be paid.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date by which the payoff amount should be paid.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="loanPayByDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loanPayByDate")]
    public string LoanPayByDate { get; set; }

    /// <summary>
    /// Gets or Sets FaceAmount
    /// </summary>
    [DataMember(Name="faceAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faceAmount")]
    public Money FaceAmount { get; set; }

    /// <summary>
    /// The date the insurance policy began.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date the insurance policy began.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="policyFromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyFromDate")]
    public string PolicyFromDate { get; set; }

    /// <summary>
    /// The number of years for which premium payments have to be made in a policy.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The number of years for which premium payments have to be made in a policy.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="premiumPaymentTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "premiumPaymentTerm")]
    public string PremiumPaymentTerm { get; set; }

    /// <summary>
    /// The duration for which the policy is valid or in effect. For example, one year, five years, etc.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The duration for which the policy is valid or in effect. For example, one year, five years, etc.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="policyTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyTerm")]
    public string PolicyTerm { get; set; }

    /// <summary>
    /// The type of repayment plan that the borrower prefers to repay the loan. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The type of repayment plan that the borrower prefers to repay the loan. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="repaymentPlanType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repaymentPlanType")]
    public string RepaymentPlanType { get; set; }

    /// <summary>
    /// The type of account that is aggregated.
    /// </summary>
    /// <value>The type of account that is aggregated.</value>
    [DataMember(Name="aggregatedAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregatedAccountType")]
    public string AggregatedAccountType { get; set; }

    /// <summary>
    /// Gets or Sets AvailableBalance
    /// </summary>
    [DataMember(Name="availableBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableBalance")]
    public Money AvailableBalance { get; set; }

    /// <summary>
    /// The status of the account that is updated by the consumer through an application or an API. Valid Values: AccountStatus<br><b>Additional Details:</b><br><b>ACTIVE:</b> All the added manual and aggregated accounts status will be made \"ACTIVE\" by default. <br><b>TO_BE_CLOSED:</b> If the aggregated accounts are not found or closed in the data provider site, Yodlee system marks the status as TO_BE_CLOSED<br><b>INACTIVE:</b> Users can update the status as INACTIVE to stop updating and to stop considering the account in other services<br><b>CLOSED:</b> Users can update the status as CLOSED, if the account is closed with the provider. <br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The status of the account that is updated by the consumer through an application or an API. Valid Values: AccountStatus<br><b>Additional Details:</b><br><b>ACTIVE:</b> All the added manual and aggregated accounts status will be made \"ACTIVE\" by default. <br><b>TO_BE_CLOSED:</b> If the aggregated accounts are not found or closed in the data provider site, Yodlee system marks the status as TO_BE_CLOSED<br><b>INACTIVE:</b> Users can update the status as INACTIVE to stop updating and to stop considering the account in other services<br><b>CLOSED:</b> Users can update the status as CLOSED, if the account is closed with the provider. <br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="accountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountStatus")]
    public string AccountStatus { get; set; }

    /// <summary>
    /// Type of life insurance.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Type of life insurance.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="lifeInsuranceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lifeInsuranceType")]
    public string LifeInsuranceType { get; set; }

    /// <summary>
    /// Full account number of the account that is included only when include = fullAccountNumber is provided in the request. For student loan account the account number that will be used for ACH or fund transfer<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward, otherAssets, otherLiabilities <br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><b> Note : </b> fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</ul>
    /// </summary>
    /// <value>Full account number of the account that is included only when include = fullAccountNumber is provided in the request. For student loan account the account number that will be used for ACH or fund transfer<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward, otherAssets, otherLiabilities <br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><b> Note : </b> fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</ul></value>
    [DataMember(Name="fullAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullAccountNumber")]
    public string FullAccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets Premium
    /// </summary>
    [DataMember(Name="premium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "premium")]
    public Money Premium { get; set; }

    /// <summary>
    /// The source through which the account(s) are added in the system.<br><b>Valid Values</b>: SYSTEM, USER<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The source through which the account(s) are added in the system.<br><b>Valid Values</b>: SYSTEM, USER<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="aggregationSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregationSource")]
    public string AggregationSource { get; set; }

    /// <summary>
    /// Gets or Sets OverDraftLimit
    /// </summary>
    [DataMember(Name="overDraftLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overDraftLimit")]
    public Money OverDraftLimit { get; set; }

    /// <summary>
    /// The nickname of the account as provided by the consumer to identify an account. The account nickname can be used instead of the account name.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The nickname of the account as provided by the consumer to identify an account. The account nickname can be used instead of the account name.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// The tenure for which the CD account is valid  or in case of loan, the number of years/months over which the loan amount  has to be repaid. <br><b>Additional Details:</b><br>  Bank: The Term field is only applicable for the account type CD.Loan: The period for which the loan agreement is in force. The period, before or at the end of which, the loan should either be repaid or renegotiated for another term.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The tenure for which the CD account is valid  or in case of loan, the number of years/months over which the loan amount  has to be repaid. <br><b>Additional Details:</b><br>  Bank: The Term field is only applicable for the account type CD.Loan: The period for which the loan agreement is in force. The period, before or at the end of which, the loan should either be repaid or renegotiated for another term.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "term")]
    public string Term { get; set; }

    /// <summary>
    /// <br><b>Bank:</b> The interest rate offered by a FI to its depositors on a bank account.<br><b>Loan:</b> Interest rate applied on the loan.<br><b>Additional Details:</b><br><b>Note:</b> The Interest Rate field is only applicable for the following account types: savings, checking, money market, and certificate of deposit.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value><br><b>Bank:</b> The interest rate offered by a FI to its depositors on a bank account.<br><b>Loan:</b> Interest rate applied on the loan.<br><b>Additional Details:</b><br><b>Note:</b> The Interest Rate field is only applicable for the following account types: savings, checking, money market, and certificate of deposit.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="interestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestRate")]
    public double? InterestRate { get; set; }

    /// <summary>
    /// Gets or Sets DeathBenefit
    /// </summary>
    [DataMember(Name="deathBenefit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deathBenefit")]
    public Money DeathBenefit { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public AccountAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets CashValue
    /// </summary>
    [DataMember(Name="cashValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashValue")]
    public Money CashValue { get; set; }

    /// <summary>
    /// Holder details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Holder details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="holder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holder")]
    public List<AccountHolder> Holder { get; set; }

    /// <summary>
    /// Gets or Sets _401kLoan
    /// </summary>
    [DataMember(Name="401kLoan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "401kLoan")]
    public Money _401kLoan { get; set; }

    /// <summary>
    /// Gets or Sets HomeValue
    /// </summary>
    [DataMember(Name="homeValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeValue")]
    public Money HomeValue { get; set; }

    /// <summary>
    /// The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank/ Loan/ Insurance/ Investment</b>:<br> The account number for the bank account as it appears at the site.<br><b>Credit Card</b>: The account number of the card account as it appears at the site,<br>i.e., the card number.The account number can be full or partial based on how it is displayed in the account summary page of the site.In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>POST accounts</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank/ Loan/ Insurance/ Investment</b>:<br> The account number for the bank account as it appears at the site.<br><b>Credit Card</b>: The account number of the card account as it appears at the site,<br>i.e., the card number.The account number can be full or partial based on how it is displayed in the account summary page of the site.In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>POST accounts</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// The date on which the account is created in the Yodlee system.<br><b>Additional Details:</b> It is the date when the user links or aggregates the account(s) that are held with the provider to the Yodlee system.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the account is created in the Yodlee system.<br><b>Additional Details:</b> It is the date when the user links or aggregates the account(s) that are held with the provider to the Yodlee system.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets InterestPaidYTD
    /// </summary>
    [DataMember(Name="interestPaidYTD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestPaidYTD")]
    public Money InterestPaidYTD { get; set; }

    /// <summary>
    /// The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// Property or possession offered to support a loan that can be seized on a default.<br><b>Applicable containers</b>: loan<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Property or possession offered to support a loan that can be seized on a default.<br><b>Applicable containers</b>: loan<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="collateral", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collateral")]
    public string Collateral { get; set; }

    /// <summary>
    /// Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="dataset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataset")]
    public List<AccountDataset> Dataset { get; set; }

    /// <summary>
    /// Gets or Sets RunningBalance
    /// </summary>
    [DataMember(Name="runningBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runningBalance")]
    public Money RunningBalance { get; set; }

    /// <summary>
    /// A unique ID that the provider site has assigned to the account. The source ID is only available for the HELD accounts.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>A unique ID that the provider site has assigned to the account. The source ID is only available for the HELD accounts.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="sourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceId")]
    public string SourceId { get; set; }

    /// <summary>
    /// The date on which the due amount has to be paid. <br><b>Additional Details:</b><br><b>Credit Card:</b> The monthly date by when the minimum payment is due to be paid on the credit card account. <br><b>Loan:</b> The date on or before which the due amount should be paid.<br><b>Note:</b> The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the due amount has to be paid. <br><b>Additional Details:</b><br><b>Credit Card:</b> The monthly date by when the minimum payment is due to be paid on the credit card account. <br><b>Loan:</b> The date on or before which the due amount should be paid.<br><b>Note:</b> The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public string DueDate { get; set; }

    /// <summary>
    /// The frequency of the billing cycle of the account in case of card. The frequency in which premiums are paid in an insurance policy such as monthly, quarterly, and annually. The frequency in which due amounts are paid in a loan  account.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: creditCard, insurance, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The frequency of the billing cycle of the account in case of card. The frequency in which premiums are paid in an insurance policy such as monthly, quarterly, and annually. The frequency in which due amounts are paid in a loan  account.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: creditCard, insurance, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public string Frequency { get; set; }

    /// <summary>
    /// Gets or Sets MaturityAmount
    /// </summary>
    [DataMember(Name="maturityAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maturityAmount")]
    public Money MaturityAmount { get; set; }

    /// <summary>
    /// The providerAccountIds that share the account with the primary providerAccountId that was created when the user had added the account for the first time.<br><b>Additional Details</b>: This attribute is returned in the response only if the account deduplication feature is enabled and the same account is mapped to more than one provider account IDs indicating the account is owned by more than one user, for example, joint accounts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The providerAccountIds that share the account with the primary providerAccountId that was created when the user had added the account for the first time.<br><b>Additional Details</b>: This attribute is returned in the response only if the account deduplication feature is enabled and the same account is mapped to more than one provider account IDs indicating the account is owned by more than one user, for example, joint accounts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="associatedProviderAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associatedProviderAccountId")]
    public List<long?> AssociatedProviderAccountId { get; set; }

    /// <summary>
    /// The account to be considered as an asset or liability.<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The account to be considered as an asset or liability.<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="isAsset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAsset")]
    public bool? IsAsset { get; set; }

    /// <summary>
    /// Gets or Sets PrincipalBalance
    /// </summary>
    [DataMember(Name="principalBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principalBalance")]
    public Money PrincipalBalance { get; set; }

    /// <summary>
    /// Gets or Sets TotalCashLimit
    /// </summary>
    [DataMember(Name="totalCashLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCashLimit")]
    public Money TotalCashLimit { get; set; }

    /// <summary>
    /// The date when a certificate of deposit (CD/FD) matures or the final payment date of a loan at which point the principal amount (including pending interest) is due to be paid.<br><b>Additional Details:</b> The date when a certificate of deposit (CD) matures, i.e., the money in the CD can be withdrawn without paying an early withdrawal penalty.The final payment date of a loan, i.e., the principal amount (including pending interest) is due to be paid.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date when a certificate of deposit (CD/FD) matures or the final payment date of a loan at which point the principal amount (including pending interest) is due to be paid.<br><b>Additional Details:</b> The date when a certificate of deposit (CD) matures, i.e., the money in the CD can be withdrawn without paying an early withdrawal penalty.The final payment date of a loan, i.e., the principal amount (including pending interest) is due to be paid.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="maturityDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maturityDate")]
    public string MaturityDate { get; set; }

    /// <summary>
    /// Gets or Sets MinimumAmountDue
    /// </summary>
    [DataMember(Name="minimumAmountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumAmountDue")]
    public Money MinimumAmountDue { get; set; }

    /// <summary>
    /// Annual percentage yield (APY) is a normalized representation of an interest rate, based on a compounding period of one year. APY generally refers to the rate paid to a depositor by a financial institution on an account.<br><b>Applicable containers</b>: bank<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Annual percentage yield (APY) is a normalized representation of an interest rate, based on a compounding period of one year. APY generally refers to the rate paid to a depositor by a financial institution on an account.<br><b>Applicable containers</b>: bank<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="annualPercentageYield", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annualPercentageYield")]
    public double? AnnualPercentageYield { get; set; }

    /// <summary>
    /// The type of account that is aggregated, i.e., savings, checking, credit card, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PPF</li><li>RECURRING_DEPOSIT</li><li>FSA</li><li>MONEY_MARKET</li><li>IRA</li><li>PREPAID</li></ul><b>creditCard</b><ul><li>OTHER</li><li>CREDIT</li><li>STORE</li><li>CHARGE</li><li>OTHER</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>HSA</li><li>IRA</li><li>BROKERAGE_CASH</li><li>401K</li><li>403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE</li><li>CUSTODIAL</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE</li><li>JTTIC</li><li>JTWROS</li><li>COMMUNITY_PROPERTY</li><li>JOINT_BY_ENTIRETY</li><li>CONSERVATORSHIP</li><li>ROTH</li><li>ROTH_CONVERSION</li><li>ROLLOVER</li><li>EDUCATIONAL</li><li>529_PLAN</li><li>457_DEFERRED_COMPENSATION</li><li>401A</li><li>PSP</li><li>MPP</li><li>STOCK_BASKET</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER</li><li>CHARITABLE_LEAD</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP</li><li>UTMA</li><li>UGMA</li><li>ESOPP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>SOLE_PROPRIETORSHIP</li><li>CHURCH</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CMA</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET</li><li>SUPER_ANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN</li><li>DEFERRED_PROFIT_SHARING_PLAN</li><li>NON_REGISTERED_SAVINGS_PLAN</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN</li><li>GROUP_RETIREMENT_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_ACCOUNT</li><li>REGISTERED_PENSION_PLAN</li><li>TAX_FREE_SAVINGS_ACCOUNT</li><li>LIFE_INCOME_FUND</li><li>REGISTERED_RETIREMENT_INCOME_FUND</li><li>SPOUSAL_RETIREMENT_INCOME_FUND</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND</li><li>GUARANTEED_INVESTMENT_CERTIFICATES</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_CASH</li><li>BROKERAGE_MARGIN</li><li>INDIVIDUAL_RETIREMENT_ACCOUNT_IRA</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_401K</li><li>EMPLOYEE_RETIREMENT_SAVINGS_PLAN_403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE_IRA</li><li>CUSTODIAL_ACCOUNT</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE_INVESTMENT_ACCOUNT</li><li>JOINT_TENANTS_TENANCY_IN_COMMON_JTIC</li><li>JOINT_TENANTS_WITH_RIGHTS_OF_SURVIVORSHIP_JTWROS</li><li>JOINT_TENANTS_COMMUNITY_PROPERTY</li><li>JOINT_TENANTS_TENANTS_BY_ENTIRETY</li><li>CONSERVATOR</li><li>ROTH_IRA</li><li>ROTH_CONVERSION</li><li>ROLLOVER_IRA</li><li>EDUCATIONAL</li><li>EDUCATIONAL_SAVINGS_PLAN_529</li><li>DEFERRED_COMPENSATION_PLAN_457</li><li>MONEY_PURCHASE_RETIREMENT_PLAN_401A</li><li>PROFIT_SHARING_PLAN</li><li>MONEY_PURCHASE_PLAN</li><li>STOCK_BASKET_ACCOUNT</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER_TRUST</li><li>CHARITABLE_LEAD_TRUST</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP_IRA</li><li>UNIFORM_TRANSFER_TO_MINORS_ACT_UTMA</li><li>UNIFORM_GIFT_TO_MINORS_ACT_UGMA</li><li>EMPLOYEE_STOCK_OWNERSHIP_PLAN_ESOP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>PROPRIETORSHIP</li><li>CHURCH_ACCOUNT</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CASH_MANAGEMENT_ACCOUNT</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN_ESPP</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET_ACCOUNT</li><li>SUPERANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN_RRSP</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN_SRSP</li><li>DEFERRED_PROFIT_SHARING_PLAN_DPSP</li><li>NON_REGISTERED_SAVINGS_PLAN_NRSP</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN_RESP</li><li>GROUP_RETIREMENT_SAVINGS_PLAN_GRSP</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN_LRSP</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN_RLSP</li><li>LOCKED_IN_RETIREMENT_ACCOUNT_LIRA</li><li>REGISTERED_PENSION_PLAN_RPP</li><li>TAX_FREE_SAVINGS_ACCOUNT_TFSA</li><li>LIFE_INCOME_FUND_LIF</li><li>REGISTERED_RETIREMENT_INCOME_FUND_RIF</li><li>SPOUSAL_RETIREMENT_INCOME_FUND_SRIF</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND_LRIF</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND_PRIF</li><li>GUARANTEED_INVESTMENT_CERTIFICATES_GIC</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN_RDSP</li><li>DEFINED_CONTRIBUTION_PLAN</li><li>DEFINED_BENEFIT_PLAN</li><li>EMPLOYEE_STOCK_OPTION_PLAN</li><li>NONQUALIFIED_DEFERRED_COMPENSATION_PLAN_409A</li><li>KEOGH_PLAN</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_ROTH_401K</li><li>DEFERRED_CONTINGENT_CAPITAL_PLAN_DCCP</li><li>EMPLOYEE_BENEFIT_PLAN</li><li>EMPLOYEE_SAVINGS_PLAN</li><li>HEALTH_SAVINGS_ACCOUNT_HSA</li><li>COVERDELL_EDUCATION_SAVINGS_ACCOUNT_ESA</li><li>TESTAMENTARY_TRUST</li><li>ESTATE</li><li>GRANTOR_RETAINED_ANNUITY_TRUST_GRAT</li><li>ADVISORY_ACCOUNT</li><li>NON_PROFIT_ORGANIZATION_501C</li><li>HEALTH_REIMBURSEMENT_ARRANGEMENT_HRA</li><li>INDIVIDUAL_SAVINGS_ACCOUNT_ISA</li><li>CASH_ISA</li><li>STOCKS_AND_SHARES_ISA</li><li>INNOVATIVE_FINANCE_ISA</li><li>JUNIOR_ISA</li><li>EMPLOYEES_PROVIDENT_FUND_ORGANIZATION_EPFO</li><li>PUBLIC_PROVIDENT_FUND_PPF</li><li>EMPLOYEES_PENSION_SCHEME_EPS</li><li>NATIONAL_PENSION_SYSTEM_NPS</li><li>INDEXED_ANNUITY</li><li>ANNUITIZED_ANNUITY</li><li>VARIABLE_ANNUITY</li><li>ROTH_403B</li><li>SPOUSAL_IRA</li><li>SPOUSAL_ROTH_IRA</li><li>SARSEP_IRA</li><li>SUBSTANTIALLY_EQUAL_PERIODIC_PAYMENTS_SEPP</li><li>OFFSHORE_TRUST</li><li>IRREVOCABLE_LIFE_INSURANCE_TRUST</li><li>INTERNATIONAL_TRUST</li><li>LIFE_INTEREST_TRUST</li><li>EMPLOYEE_BENEFIT_TRUST</li><li>PRECIOUS_METAL_ACCOUNT</li><li>INVESTMENT_LOAN_ACCOUNT</li><li>GRANTOR_RETAINED_INCOME_TRUST</li><li>PENSION_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>loan</b><ul><li>MORTGAGE</li><li>INSTALLMENT_LOAN</li><li>PERSONAL_LOAN</li><li>HOME_EQUITY_LINE_OF_CREDIT</li><li>LINE_OF_CREDIT</li><li>AUTO_LOAN</li><li>STUDENT_LOAN</li><li>HOME_LOAN</li></ul><b>insurance</b><ul><li>AUTO_INSURANCE</li><li>HEALTH_INSURANCE</li><li>HOME_INSURANCE</li><li>LIFE_INSURANCE</li><li>ANNUITY</li><li>TRAVEL_INSURANCE</li><li>INSURANCE</li></ul><b>realEstate</b><ul> <li>REAL_ESTATE</li></ul><b>reward</b><ul><li>REWARD_POINTS</li></ul><b>Manual Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PREPAID</li></ul><b>credit</b><ul>  <li>CREDIT</li></ul><b>loan</b><ul>  <li>PERSONAL_LOAN</li><li>HOME_LOAN</li></ul><b>insurance</b><ul><li>INSURANCE</li><li>ANNUITY</li></ul><b>investment</b><ul><li>BROKERAGE_CASH</li></ul><br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The type of account that is aggregated, i.e., savings, checking, credit card, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PPF</li><li>RECURRING_DEPOSIT</li><li>FSA</li><li>MONEY_MARKET</li><li>IRA</li><li>PREPAID</li></ul><b>creditCard</b><ul><li>OTHER</li><li>CREDIT</li><li>STORE</li><li>CHARGE</li><li>OTHER</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>HSA</li><li>IRA</li><li>BROKERAGE_CASH</li><li>401K</li><li>403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE</li><li>CUSTODIAL</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE</li><li>JTTIC</li><li>JTWROS</li><li>COMMUNITY_PROPERTY</li><li>JOINT_BY_ENTIRETY</li><li>CONSERVATORSHIP</li><li>ROTH</li><li>ROTH_CONVERSION</li><li>ROLLOVER</li><li>EDUCATIONAL</li><li>529_PLAN</li><li>457_DEFERRED_COMPENSATION</li><li>401A</li><li>PSP</li><li>MPP</li><li>STOCK_BASKET</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER</li><li>CHARITABLE_LEAD</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP</li><li>UTMA</li><li>UGMA</li><li>ESOPP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>SOLE_PROPRIETORSHIP</li><li>CHURCH</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CMA</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET</li><li>SUPER_ANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN</li><li>DEFERRED_PROFIT_SHARING_PLAN</li><li>NON_REGISTERED_SAVINGS_PLAN</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN</li><li>GROUP_RETIREMENT_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_ACCOUNT</li><li>REGISTERED_PENSION_PLAN</li><li>TAX_FREE_SAVINGS_ACCOUNT</li><li>LIFE_INCOME_FUND</li><li>REGISTERED_RETIREMENT_INCOME_FUND</li><li>SPOUSAL_RETIREMENT_INCOME_FUND</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND</li><li>GUARANTEED_INVESTMENT_CERTIFICATES</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_CASH</li><li>BROKERAGE_MARGIN</li><li>INDIVIDUAL_RETIREMENT_ACCOUNT_IRA</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_401K</li><li>EMPLOYEE_RETIREMENT_SAVINGS_PLAN_403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE_IRA</li><li>CUSTODIAL_ACCOUNT</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE_INVESTMENT_ACCOUNT</li><li>JOINT_TENANTS_TENANCY_IN_COMMON_JTIC</li><li>JOINT_TENANTS_WITH_RIGHTS_OF_SURVIVORSHIP_JTWROS</li><li>JOINT_TENANTS_COMMUNITY_PROPERTY</li><li>JOINT_TENANTS_TENANTS_BY_ENTIRETY</li><li>CONSERVATOR</li><li>ROTH_IRA</li><li>ROTH_CONVERSION</li><li>ROLLOVER_IRA</li><li>EDUCATIONAL</li><li>EDUCATIONAL_SAVINGS_PLAN_529</li><li>DEFERRED_COMPENSATION_PLAN_457</li><li>MONEY_PURCHASE_RETIREMENT_PLAN_401A</li><li>PROFIT_SHARING_PLAN</li><li>MONEY_PURCHASE_PLAN</li><li>STOCK_BASKET_ACCOUNT</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER_TRUST</li><li>CHARITABLE_LEAD_TRUST</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP_IRA</li><li>UNIFORM_TRANSFER_TO_MINORS_ACT_UTMA</li><li>UNIFORM_GIFT_TO_MINORS_ACT_UGMA</li><li>EMPLOYEE_STOCK_OWNERSHIP_PLAN_ESOP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>PROPRIETORSHIP</li><li>CHURCH_ACCOUNT</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CASH_MANAGEMENT_ACCOUNT</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN_ESPP</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET_ACCOUNT</li><li>SUPERANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN_RRSP</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN_SRSP</li><li>DEFERRED_PROFIT_SHARING_PLAN_DPSP</li><li>NON_REGISTERED_SAVINGS_PLAN_NRSP</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN_RESP</li><li>GROUP_RETIREMENT_SAVINGS_PLAN_GRSP</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN_LRSP</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN_RLSP</li><li>LOCKED_IN_RETIREMENT_ACCOUNT_LIRA</li><li>REGISTERED_PENSION_PLAN_RPP</li><li>TAX_FREE_SAVINGS_ACCOUNT_TFSA</li><li>LIFE_INCOME_FUND_LIF</li><li>REGISTERED_RETIREMENT_INCOME_FUND_RIF</li><li>SPOUSAL_RETIREMENT_INCOME_FUND_SRIF</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND_LRIF</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND_PRIF</li><li>GUARANTEED_INVESTMENT_CERTIFICATES_GIC</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN_RDSP</li><li>DEFINED_CONTRIBUTION_PLAN</li><li>DEFINED_BENEFIT_PLAN</li><li>EMPLOYEE_STOCK_OPTION_PLAN</li><li>NONQUALIFIED_DEFERRED_COMPENSATION_PLAN_409A</li><li>KEOGH_PLAN</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_ROTH_401K</li><li>DEFERRED_CONTINGENT_CAPITAL_PLAN_DCCP</li><li>EMPLOYEE_BENEFIT_PLAN</li><li>EMPLOYEE_SAVINGS_PLAN</li><li>HEALTH_SAVINGS_ACCOUNT_HSA</li><li>COVERDELL_EDUCATION_SAVINGS_ACCOUNT_ESA</li><li>TESTAMENTARY_TRUST</li><li>ESTATE</li><li>GRANTOR_RETAINED_ANNUITY_TRUST_GRAT</li><li>ADVISORY_ACCOUNT</li><li>NON_PROFIT_ORGANIZATION_501C</li><li>HEALTH_REIMBURSEMENT_ARRANGEMENT_HRA</li><li>INDIVIDUAL_SAVINGS_ACCOUNT_ISA</li><li>CASH_ISA</li><li>STOCKS_AND_SHARES_ISA</li><li>INNOVATIVE_FINANCE_ISA</li><li>JUNIOR_ISA</li><li>EMPLOYEES_PROVIDENT_FUND_ORGANIZATION_EPFO</li><li>PUBLIC_PROVIDENT_FUND_PPF</li><li>EMPLOYEES_PENSION_SCHEME_EPS</li><li>NATIONAL_PENSION_SYSTEM_NPS</li><li>INDEXED_ANNUITY</li><li>ANNUITIZED_ANNUITY</li><li>VARIABLE_ANNUITY</li><li>ROTH_403B</li><li>SPOUSAL_IRA</li><li>SPOUSAL_ROTH_IRA</li><li>SARSEP_IRA</li><li>SUBSTANTIALLY_EQUAL_PERIODIC_PAYMENTS_SEPP</li><li>OFFSHORE_TRUST</li><li>IRREVOCABLE_LIFE_INSURANCE_TRUST</li><li>INTERNATIONAL_TRUST</li><li>LIFE_INTEREST_TRUST</li><li>EMPLOYEE_BENEFIT_TRUST</li><li>PRECIOUS_METAL_ACCOUNT</li><li>INVESTMENT_LOAN_ACCOUNT</li><li>GRANTOR_RETAINED_INCOME_TRUST</li><li>PENSION_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>loan</b><ul><li>MORTGAGE</li><li>INSTALLMENT_LOAN</li><li>PERSONAL_LOAN</li><li>HOME_EQUITY_LINE_OF_CREDIT</li><li>LINE_OF_CREDIT</li><li>AUTO_LOAN</li><li>STUDENT_LOAN</li><li>HOME_LOAN</li></ul><b>insurance</b><ul><li>AUTO_INSURANCE</li><li>HEALTH_INSURANCE</li><li>HOME_INSURANCE</li><li>LIFE_INSURANCE</li><li>ANNUITY</li><li>TRAVEL_INSURANCE</li><li>INSURANCE</li></ul><b>realEstate</b><ul> <li>REAL_ESTATE</li></ul><b>reward</b><ul><li>REWARD_POINTS</li></ul><b>Manual Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PREPAID</li></ul><b>credit</b><ul>  <li>CREDIT</li></ul><b>loan</b><ul>  <li>PERSONAL_LOAN</li><li>HOME_LOAN</li></ul><b>insurance</b><ul><li>INSURANCE</li><li>ANNUITY</li></ul><b>investment</b><ul><li>BROKERAGE_CASH</li></ul><br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// The date on which the loan is disbursed.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the loan is disbursed.<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="originationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originationDate")]
    public string OriginationDate { get; set; }

    /// <summary>
    /// Gets or Sets TotalVestedBalance
    /// </summary>
    [DataMember(Name="totalVestedBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalVestedBalance")]
    public Money TotalVestedBalance { get; set; }

    /// <summary>
    /// Information of different reward balances associated with the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Information of different reward balances associated with the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="rewardBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardBalance")]
    public List<RewardBalance> RewardBalance { get; set; }

    /// <summary>
    /// Indicates the status of the loan account. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>Indicates the status of the loan account. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="sourceAccountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceAccountStatus")]
    public string SourceAccountStatus { get; set; }

    /// <summary>
    /// List of Loan accountId(s) to which the real-estate account is linked<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>List of Loan accountId(s) to which the real-estate account is linked<br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: realEstate<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="linkedAccountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedAccountIds")]
    public List<long?> LinkedAccountIds { get; set; }

    /// <summary>
    /// Derived APR will be an estimated purchase APR based on consumers credit card transactions and credit card purchase.<br><b>Aggregated / Manual / Derived</b>: Derived<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Derived APR will be an estimated purchase APR based on consumers credit card transactions and credit card purchase.<br><b>Aggregated / Manual / Derived</b>: Derived<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="derivedApr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "derivedApr")]
    public double? DerivedApr { get; set; }

    /// <summary>
    /// The date on which the insurance policy coverage commences.<br><b>Applicable containers</b>: insurance<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the insurance policy coverage commences.<br><b>Applicable containers</b>: insurance<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="policyEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyEffectiveDate")]
    public string PolicyEffectiveDate { get; set; }

    /// <summary>
    /// Gets or Sets TotalUnvestedBalance
    /// </summary>
    [DataMember(Name="totalUnvestedBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalUnvestedBalance")]
    public Money TotalUnvestedBalance { get; set; }

    /// <summary>
    /// Gets or Sets AnnuityBalance
    /// </summary>
    [DataMember(Name="annuityBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annuityBalance")]
    public Money AnnuityBalance { get; set; }

    /// <summary>
    /// The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets TotalCreditLimit
    /// </summary>
    [DataMember(Name="totalCreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCreditLimit")]
    public Money TotalCreditLimit { get; set; }

    /// <summary>
    /// The status of the policy.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The status of the policy.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="policyStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyStatus")]
    public string PolicyStatus { get; set; }

    /// <summary>
    /// Gets or Sets ShortBalance
    /// </summary>
    [DataMember(Name="shortBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortBalance")]
    public Money ShortBalance { get; set; }

    /// <summary>
    /// The financial institution that provides the loan.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The financial institution that provides the loan.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="lender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lender")]
    public string Lender { get; set; }

    /// <summary>
    /// Gets or Sets LastEmployeeContributionAmount
    /// </summary>
    [DataMember(Name="lastEmployeeContributionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastEmployeeContributionAmount")]
    public Money LastEmployeeContributionAmount { get; set; }

    /// <summary>
    /// Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Both <br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// The date on which the payment for the previous or current billing cycle is done.<br><b>Additional Details:</b> If the payment is already done for the current billing cycle, then the field indicates the payment date of the current billing cycle. If payment is yet to be done for the current billing cycle, then the field indicates the date on which the payment was made for any of the previous billing cycles. The last payment date at the account-level can differ from the last payment date at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the payment for the previous or current billing cycle is done.<br><b>Additional Details:</b> If the payment is already done for the current billing cycle, then the field indicates the payment date of the current billing cycle. If payment is yet to be done for the current billing cycle, then the field indicates the date on which the payment was made for any of the previous billing cycles. The last payment date at the account-level can differ from the last payment date at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: creditCard, loan, insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="lastPaymentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentDate")]
    public string LastPaymentDate { get; set; }

    /// <summary>
    /// Primary reward unit for this reward program. E.g. miles, points, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Primary reward unit for this reward program. E.g. miles, points, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="primaryRewardUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryRewardUnit")]
    public string PrimaryRewardUnit { get; set; }

    /// <summary>
    /// Gets or Sets LastPaymentAmount
    /// </summary>
    [DataMember(Name="lastPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentAmount")]
    public Money LastPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets RemainingBalance
    /// </summary>
    [DataMember(Name="remainingBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remainingBalance")]
    public Money RemainingBalance { get; set; }

    /// <summary>
    /// <b>Applicable containers</b>: reward, bank, creditCard, investment, loan, insurance, realEstate, otherLiabilities<br><b>Endpoints</b>:<ul><li>GET accounts </li><li>GET accounts/{accountId}</li><li>POST accounts</ul><li>GET dataExtracts/userData</li><b>Applicable Values</b><br>
    /// </summary>
    /// <value><b>Applicable containers</b>: reward, bank, creditCard, investment, loan, insurance, realEstate, otherLiabilities<br><b>Endpoints</b>:<ul><li>GET accounts </li><li>GET accounts/{accountId}</li><li>POST accounts</ul><li>GET dataExtracts/userData</li><b>Applicable Values</b><br></value>
    [DataMember(Name="userClassification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userClassification")]
    public string UserClassification { get; set; }

    /// <summary>
    /// Bank and branch identification information.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment, loan<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Bank and branch identification information.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment, loan<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="bankTransferCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankTransferCode")]
    public List<BankTransferCode> BankTransferCode { get; set; }

    /// <summary>
    /// The date on which the insurance policy expires or matures.<br><b>Additional Details:</b> The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the insurance policy expires or matures.<br><b>Additional Details:</b> The due date at the account-level can differ from the due date field at the statement-level, as the information in the aggregated card account data provides an up-to-date information to the consumer.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public string ExpirationDate { get; set; }

    /// <summary>
    /// The coverage-related details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The coverage-related details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="coverage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coverage")]
    public List<Coverage> Coverage { get; set; }

    /// <summary>
    /// Annual percentage rate applied to cash withdrawals on the card.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Annual percentage rate applied to cash withdrawals on the card.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: creditCard<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="cashApr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashApr")]
    public double? CashApr { get; set; }

    /// <summary>
    /// Gets or Sets AutoRefresh
    /// </summary>
    [DataMember(Name="autoRefresh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRefresh")]
    public AutoRefresh AutoRefresh { get; set; }

    /// <summary>
    /// Indicates the migration status of the account from screen-scraping provider to the Open Banking provider. <br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicates the migration status of the account from screen-scraping provider to the Open Banking provider. <br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="oauthMigrationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oauthMigrationStatus")]
    public string OauthMigrationStatus { get; set; }

    /// <summary>
    /// The name or identification of the account owner, as it appears at the FI site. <br><b>Note:</b> The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The name or identification of the account owner, as it appears at the FI site. <br><b>Note:</b> The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan, reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="displayedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayedName")]
    public string DisplayedName { get; set; }

    /// <summary>
    /// Gets or Sets FullAccountNumberList
    /// </summary>
    [DataMember(Name="fullAccountNumberList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullAccountNumberList")]
    public FullAccountNumberList FullAccountNumberList { get; set; }

    /// <summary>
    /// Gets or Sets AmountDue
    /// </summary>
    [DataMember(Name="amountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountDue")]
    public Money AmountDue { get; set; }

    /// <summary>
    /// Current level of the reward program the user is associated with. E.g. Silver, Jade etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Current level of the reward program the user is associated with. E.g. Silver, Jade etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="currentLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentLevel")]
    public string CurrentLevel { get; set; }

    /// <summary>
    /// Gets or Sets OriginalLoanAmount
    /// </summary>
    [DataMember(Name="originalLoanAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalLoanAmount")]
    public Money OriginalLoanAmount { get; set; }

    /// <summary>
    /// The date to which the policy exists.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date to which the policy exists.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="policyToDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyToDate")]
    public string PolicyToDate { get; set; }

    /// <summary>
    /// Gets or Sets LoanPayoffDetails
    /// </summary>
    [DataMember(Name="loanPayoffDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loanPayoffDetails")]
    public LoanPayoffDetails LoanPayoffDetails { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProfile
    /// </summary>
    [DataMember(Name="paymentProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentProfile")]
    public PaymentProfile PaymentProfile { get; set; }

    /// <summary>
    /// The type of service. E.g., Bank, Credit Card, Investment, Insurance, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of service. E.g., Bank, Credit Card, Investment, Insurance, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="CONTAINER", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CONTAINER")]
    public string CONTAINER { get; set; }

    /// <summary>
    /// The date on which the last employee contribution was made to the 401k account.<br><b>Note:</b> The last employee contribution date field is derived from the transaction data and not aggregated from the FI site. The field is only applicable to the 401k account type.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the last employee contribution was made to the 401k account.<br><b>Note:</b> The last employee contribution date field is derived from the transaction data and not aggregated from the FI site. The field is only applicable to the 401k account type.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="lastEmployeeContributionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastEmployeeContributionDate")]
    public string LastEmployeeContributionDate { get; set; }

    /// <summary>
    /// Gets or Sets LastPayment
    /// </summary>
    [DataMember(Name="lastPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPayment")]
    public Money LastPayment { get; set; }

    /// <summary>
    /// Gets or Sets RecurringPayment
    /// </summary>
    [DataMember(Name="recurringPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringPayment")]
    public Money RecurringPayment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Account {\n");
      sb.Append("  AvailableCash: ").Append(AvailableCash).Append("\n");
      sb.Append("  IncludeInNetWorth: ").Append(IncludeInNetWorth).Append("\n");
      sb.Append("  MoneyMarketBalance: ").Append(MoneyMarketBalance).Append("\n");
      sb.Append("  EnrollmentDate: ").Append(EnrollmentDate).Append("\n");
      sb.Append("  EstimatedDate: ").Append(EstimatedDate).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  Guarantor: ").Append(Guarantor).Append("\n");
      sb.Append("  InterestPaidLastYear: ").Append(InterestPaidLastYear).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  HomeInsuranceType: ").Append(HomeInsuranceType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Cash: ").Append(Cash).Append("\n");
      sb.Append("  TotalCreditLine: ").Append(TotalCreditLine).Append("\n");
      sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
      sb.Append("  ValuationType: ").Append(ValuationType).Append("\n");
      sb.Append("  MarginBalance: ").Append(MarginBalance).Append("\n");
      sb.Append("  Apr: ").Append(Apr).Append("\n");
      sb.Append("  AvailableCredit: ").Append(AvailableCredit).Append("\n");
      sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
      sb.Append("  IsManual: ").Append(IsManual).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  EscrowBalance: ").Append(EscrowBalance).Append("\n");
      sb.Append("  NextLevel: ").Append(NextLevel).Append("\n");
      sb.Append("  Classification: ").Append(Classification).Append("\n");
      sb.Append("  LoanPayoffAmount: ").Append(LoanPayoffAmount).Append("\n");
      sb.Append("  InterestRateType: ").Append(InterestRateType).Append("\n");
      sb.Append("  LoanPayByDate: ").Append(LoanPayByDate).Append("\n");
      sb.Append("  FaceAmount: ").Append(FaceAmount).Append("\n");
      sb.Append("  PolicyFromDate: ").Append(PolicyFromDate).Append("\n");
      sb.Append("  PremiumPaymentTerm: ").Append(PremiumPaymentTerm).Append("\n");
      sb.Append("  PolicyTerm: ").Append(PolicyTerm).Append("\n");
      sb.Append("  RepaymentPlanType: ").Append(RepaymentPlanType).Append("\n");
      sb.Append("  AggregatedAccountType: ").Append(AggregatedAccountType).Append("\n");
      sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
      sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
      sb.Append("  LifeInsuranceType: ").Append(LifeInsuranceType).Append("\n");
      sb.Append("  FullAccountNumber: ").Append(FullAccountNumber).Append("\n");
      sb.Append("  Premium: ").Append(Premium).Append("\n");
      sb.Append("  AggregationSource: ").Append(AggregationSource).Append("\n");
      sb.Append("  OverDraftLimit: ").Append(OverDraftLimit).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  Term: ").Append(Term).Append("\n");
      sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
      sb.Append("  DeathBenefit: ").Append(DeathBenefit).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  CashValue: ").Append(CashValue).Append("\n");
      sb.Append("  Holder: ").Append(Holder).Append("\n");
      sb.Append("  _401kLoan: ").Append(_401kLoan).Append("\n");
      sb.Append("  HomeValue: ").Append(HomeValue).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  InterestPaidYTD: ").Append(InterestPaidYTD).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  Collateral: ").Append(Collateral).Append("\n");
      sb.Append("  Dataset: ").Append(Dataset).Append("\n");
      sb.Append("  RunningBalance: ").Append(RunningBalance).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  MaturityAmount: ").Append(MaturityAmount).Append("\n");
      sb.Append("  AssociatedProviderAccountId: ").Append(AssociatedProviderAccountId).Append("\n");
      sb.Append("  IsAsset: ").Append(IsAsset).Append("\n");
      sb.Append("  PrincipalBalance: ").Append(PrincipalBalance).Append("\n");
      sb.Append("  TotalCashLimit: ").Append(TotalCashLimit).Append("\n");
      sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
      sb.Append("  MinimumAmountDue: ").Append(MinimumAmountDue).Append("\n");
      sb.Append("  AnnualPercentageYield: ").Append(AnnualPercentageYield).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  OriginationDate: ").Append(OriginationDate).Append("\n");
      sb.Append("  TotalVestedBalance: ").Append(TotalVestedBalance).Append("\n");
      sb.Append("  RewardBalance: ").Append(RewardBalance).Append("\n");
      sb.Append("  SourceAccountStatus: ").Append(SourceAccountStatus).Append("\n");
      sb.Append("  LinkedAccountIds: ").Append(LinkedAccountIds).Append("\n");
      sb.Append("  DerivedApr: ").Append(DerivedApr).Append("\n");
      sb.Append("  PolicyEffectiveDate: ").Append(PolicyEffectiveDate).Append("\n");
      sb.Append("  TotalUnvestedBalance: ").Append(TotalUnvestedBalance).Append("\n");
      sb.Append("  AnnuityBalance: ").Append(AnnuityBalance).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  TotalCreditLimit: ").Append(TotalCreditLimit).Append("\n");
      sb.Append("  PolicyStatus: ").Append(PolicyStatus).Append("\n");
      sb.Append("  ShortBalance: ").Append(ShortBalance).Append("\n");
      sb.Append("  Lender: ").Append(Lender).Append("\n");
      sb.Append("  LastEmployeeContributionAmount: ").Append(LastEmployeeContributionAmount).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  LastPaymentDate: ").Append(LastPaymentDate).Append("\n");
      sb.Append("  PrimaryRewardUnit: ").Append(PrimaryRewardUnit).Append("\n");
      sb.Append("  LastPaymentAmount: ").Append(LastPaymentAmount).Append("\n");
      sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
      sb.Append("  UserClassification: ").Append(UserClassification).Append("\n");
      sb.Append("  BankTransferCode: ").Append(BankTransferCode).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  Coverage: ").Append(Coverage).Append("\n");
      sb.Append("  CashApr: ").Append(CashApr).Append("\n");
      sb.Append("  AutoRefresh: ").Append(AutoRefresh).Append("\n");
      sb.Append("  OauthMigrationStatus: ").Append(OauthMigrationStatus).Append("\n");
      sb.Append("  DisplayedName: ").Append(DisplayedName).Append("\n");
      sb.Append("  FullAccountNumberList: ").Append(FullAccountNumberList).Append("\n");
      sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
      sb.Append("  CurrentLevel: ").Append(CurrentLevel).Append("\n");
      sb.Append("  OriginalLoanAmount: ").Append(OriginalLoanAmount).Append("\n");
      sb.Append("  PolicyToDate: ").Append(PolicyToDate).Append("\n");
      sb.Append("  LoanPayoffDetails: ").Append(LoanPayoffDetails).Append("\n");
      sb.Append("  PaymentProfile: ").Append(PaymentProfile).Append("\n");
      sb.Append("  CONTAINER: ").Append(CONTAINER).Append("\n");
      sb.Append("  LastEmployeeContributionDate: ").Append(LastEmployeeContributionDate).Append("\n");
      sb.Append("  LastPayment: ").Append(LastPayment).Append("\n");
      sb.Append("  RecurringPayment: ").Append(RecurringPayment).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
