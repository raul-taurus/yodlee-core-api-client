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
  public class AccountLatestBalance {
    /// <summary>
    /// The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets TotalBalance
    /// </summary>
    [DataMember(Name="totalBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalBalance")]
    public Money TotalBalance { get; set; }

    /// <summary>
    /// The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PPF</li><li>RECURRING_DEPOSIT</li><li>FSA</li><li>MONEY_MARKET</li><li>IRA</li><li>PREPAID</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>HSA</li><li>IRA</li><li>BROKERAGE_CASH</li><li>401K</li><li>403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE</li><li>CUSTODIAL</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE</li><li>JTTIC</li><li>JTWROS</li><li>COMMUNITY_PROPERTY</li><li>JOINT_BY_ENTIRETY</li><li>CONSERVATORSHIP</li><li>ROTH</li><li>ROTH_CONVERSION</li><li>ROLLOVER</li><li>EDUCATIONAL</li><li>529_PLAN</li><li>457_DEFERRED_COMPENSATION</li><li>401A</li><li>PSP</li><li>MPP</li><li>STOCK_BASKET</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER</li><li>CHARITABLE_LEAD</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP</li><li>UTMA</li><li>UGMA</li><li>ESOPP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>SOLE_PROPRIETORSHIP</li><li>CHURCH</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CMA</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET</li><li>SUPER_ANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN</li><li>DEFERRED_PROFIT_SHARING_PLAN</li><li>NON_REGISTERED_SAVINGS_PLAN</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN</li><li>GROUP_RETIREMENT_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_ACCOUNT</li><li>REGISTERED_PENSION_PLAN</li><li>TAX_FREE_SAVINGS_ACCOUNT</li><li>LIFE_INCOME_FUND</li><li>REGISTERED_RETIREMENT_INCOME_FUND</li><li>SPOUSAL_RETIREMENT_INCOME_FUND</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND</li><li>GUARANTEED_INVESTMENT_CERTIFICATES</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_CASH</li><li>BROKERAGE_MARGIN</li><li>INDIVIDUAL_RETIREMENT_ACCOUNT_IRA</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_401K</li><li>EMPLOYEE_RETIREMENT_SAVINGS_PLAN_403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE_IRA</li><li>CUSTODIAL_ACCOUNT</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE_INVESTMENT_ACCOUNT</li><li>JOINT_TENANTS_TENANCY_IN_COMMON_JTIC</li><li>JOINT_TENANTS_WITH_RIGHTS_OF_SURVIVORSHIP_JTWROS</li><li>JOINT_TENANTS_COMMUNITY_PROPERTY</li><li>JOINT_TENANTS_TENANTS_BY_ENTIRETY</li><li>CONSERVATOR</li><li>ROTH_IRA</li><li>ROTH_CONVERSION</li><li>ROLLOVER_IRA</li><li>EDUCATIONAL</li><li>EDUCATIONAL_SAVINGS_PLAN_529</li><li>DEFERRED_COMPENSATION_PLAN_457</li><li>MONEY_PURCHASE_RETIREMENT_PLAN_401A</li><li>PROFIT_SHARING_PLAN</li><li>MONEY_PURCHASE_PLAN</li><li>STOCK_BASKET_ACCOUNT</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER_TRUST</li><li>CHARITABLE_LEAD_TRUST</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP_IRA</li><li>UNIFORM_TRANSFER_TO_MINORS_ACT_UTMA</li><li>UNIFORM_GIFT_TO_MINORS_ACT_UGMA</li><li>EMPLOYEE_STOCK_OWNERSHIP_PLAN_ESOP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>PROPRIETORSHIP</li><li>CHURCH_ACCOUNT</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CASH_MANAGEMENT_ACCOUNT</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN_ESPP</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET_ACCOUNT</li><li>SUPERANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN_RRSP</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN_SRSP</li><li>DEFERRED_PROFIT_SHARING_PLAN_DPSP</li><li>NON_REGISTERED_SAVINGS_PLAN_NRSP</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN_RESP</li><li>GROUP_RETIREMENT_SAVINGS_PLAN_GRSP</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN_LRSP</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN_RLSP</li><li>LOCKED_IN_RETIREMENT_ACCOUNT_LIRA</li><li>REGISTERED_PENSION_PLAN_RPP</li><li>TAX_FREE_SAVINGS_ACCOUNT_TFSA</li><li>LIFE_INCOME_FUND_LIF</li><li>REGISTERED_RETIREMENT_INCOME_FUND_RIF</li><li>SPOUSAL_RETIREMENT_INCOME_FUND_SRIF</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND_LRIF</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND_PRIF</li><li>GUARANTEED_INVESTMENT_CERTIFICATES_GIC</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN_RDSP</li><li>DEFINED_CONTRIBUTION_PLAN</li><li>DEFINED_BENEFIT_PLAN</li><li>EMPLOYEE_STOCK_OPTION_PLAN</li><li>NONQUALIFIED_DEFERRED_COMPENSATION_PLAN_409A</li><li>KEOGH_PLAN</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_ROTH_401K</li><li>DEFERRED_CONTINGENT_CAPITAL_PLAN_DCCP</li><li>EMPLOYEE_BENEFIT_PLAN</li><li>EMPLOYEE_SAVINGS_PLAN</li><li>HEALTH_SAVINGS_ACCOUNT_HSA</li><li>COVERDELL_EDUCATION_SAVINGS_ACCOUNT_ESA</li><li>TESTAMENTARY_TRUST</li><li>ESTATE</li><li>GRANTOR_RETAINED_ANNUITY_TRUST_GRAT</li><li>ADVISORY_ACCOUNT</li><li>NON_PROFIT_ORGANIZATION_501C</li><li>HEALTH_REIMBURSEMENT_ARRANGEMENT_HRA</li><li>INDIVIDUAL_SAVINGS_ACCOUNT_ISA</li><li>CASH_ISA</li><li>STOCKS_AND_SHARES_ISA</li><li>INNOVATIVE_FINANCE_ISA</li><li>JUNIOR_ISA</li><li>EMPLOYEES_PROVIDENT_FUND_ORGANIZATION_EPFO</li><li>PUBLIC_PROVIDENT_FUND_PPF</li><li>EMPLOYEES_PENSION_SCHEME_EPS</li><li>NATIONAL_PENSION_SYSTEM_NPS</li><li>INDEXED_ANNUITY</li><li>ANNUITIZED_ANNUITY</li><li>VARIABLE_ANNUITY</li><li>ROTH_403B</li><li>SPOUSAL_IRA</li><li>SPOUSAL_ROTH_IRA</li><li>SARSEP_IRA</li><li>SUBSTANTIALLY_EQUAL_PERIODIC_PAYMENTS_SEPP</li><li>OFFSHORE_TRUST</li><li>IRREVOCABLE_LIFE_INSURANCE_TRUST</li><li>INTERNATIONAL_TRUST</li><li>LIFE_INTEREST_TRUST</li><li>EMPLOYEE_BENEFIT_TRUST</li><li>PRECIOUS_METAL_ACCOUNT</li><li>INVESTMENT_LOAN_ACCOUNT</li><li>GRANTOR_RETAINED_INCOME_TRUST</li><li>PENSION_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>CD</li><li>PPF</li><li>RECURRING_DEPOSIT</li><li>FSA</li><li>MONEY_MARKET</li><li>IRA</li><li>PREPAID</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>HSA</li><li>IRA</li><li>BROKERAGE_CASH</li><li>401K</li><li>403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE</li><li>CUSTODIAL</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE</li><li>JTTIC</li><li>JTWROS</li><li>COMMUNITY_PROPERTY</li><li>JOINT_BY_ENTIRETY</li><li>CONSERVATORSHIP</li><li>ROTH</li><li>ROTH_CONVERSION</li><li>ROLLOVER</li><li>EDUCATIONAL</li><li>529_PLAN</li><li>457_DEFERRED_COMPENSATION</li><li>401A</li><li>PSP</li><li>MPP</li><li>STOCK_BASKET</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER</li><li>CHARITABLE_LEAD</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP</li><li>UTMA</li><li>UGMA</li><li>ESOPP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>SOLE_PROPRIETORSHIP</li><li>CHURCH</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CMA</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET</li><li>SUPER_ANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN</li><li>DEFERRED_PROFIT_SHARING_PLAN</li><li>NON_REGISTERED_SAVINGS_PLAN</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN</li><li>GROUP_RETIREMENT_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN</li><li>LOCKED_IN_RETIREMENT_ACCOUNT</li><li>REGISTERED_PENSION_PLAN</li><li>TAX_FREE_SAVINGS_ACCOUNT</li><li>LIFE_INCOME_FUND</li><li>REGISTERED_RETIREMENT_INCOME_FUND</li><li>SPOUSAL_RETIREMENT_INCOME_FUND</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND</li><li>GUARANTEED_INVESTMENT_CERTIFICATES</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_CASH</li><li>BROKERAGE_MARGIN</li><li>INDIVIDUAL_RETIREMENT_ACCOUNT_IRA</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_401K</li><li>EMPLOYEE_RETIREMENT_SAVINGS_PLAN_403B</li><li>TRUST</li><li>ANNUITY</li><li>SIMPLE_IRA</li><li>CUSTODIAL_ACCOUNT</li><li>BROKERAGE_CASH_OPTION</li><li>BROKERAGE_MARGIN_OPTION</li><li>INDIVIDUAL</li><li>CORPORATE_INVESTMENT_ACCOUNT</li><li>JOINT_TENANTS_TENANCY_IN_COMMON_JTIC</li><li>JOINT_TENANTS_WITH_RIGHTS_OF_SURVIVORSHIP_JTWROS</li><li>JOINT_TENANTS_COMMUNITY_PROPERTY</li><li>JOINT_TENANTS_TENANTS_BY_ENTIRETY</li><li>CONSERVATOR</li><li>ROTH_IRA</li><li>ROTH_CONVERSION</li><li>ROLLOVER_IRA</li><li>EDUCATIONAL</li><li>EDUCATIONAL_SAVINGS_PLAN_529</li><li>DEFERRED_COMPENSATION_PLAN_457</li><li>MONEY_PURCHASE_RETIREMENT_PLAN_401A</li><li>PROFIT_SHARING_PLAN</li><li>MONEY_PURCHASE_PLAN</li><li>STOCK_BASKET_ACCOUNT</li><li>LIVING_TRUST</li><li>REVOCABLE_TRUST</li><li>IRREVOCABLE_TRUST</li><li>CHARITABLE_REMAINDER_TRUST</li><li>CHARITABLE_LEAD_TRUST</li><li>CHARITABLE_GIFT_ACCOUNT</li><li>SEP_IRA</li><li>UNIFORM_TRANSFER_TO_MINORS_ACT_UTMA</li><li>UNIFORM_GIFT_TO_MINORS_ACT_UGMA</li><li>EMPLOYEE_STOCK_OWNERSHIP_PLAN_ESOP</li><li>ADMINISTRATOR</li><li>EXECUTOR</li><li>PARTNERSHIP</li><li>PROPRIETORSHIP</li><li>CHURCH_ACCOUNT</li><li>INVESTMENT_CLUB</li><li>RESTRICTED_STOCK_AWARD</li><li>CASH_MANAGEMENT_ACCOUNT</li><li>EMPLOYEE_STOCK_PURCHASE_PLAN_ESPP</li><li>PERFORMANCE_PLAN</li><li>BROKERAGE_LINK_ACCOUNT</li><li>MONEY_MARKET_ACCOUNT</li><li>SUPERANNUATION</li><li>REGISTERED_RETIREMENT_SAVINGS_PLAN_RRSP</li><li>SPOUSAL_RETIREMENT_SAVINGS_PLAN_SRSP</li><li>DEFERRED_PROFIT_SHARING_PLAN_DPSP</li><li>NON_REGISTERED_SAVINGS_PLAN_NRSP</li><li>REGISTERED_EDUCATION_SAVINGS_PLAN_RESP</li><li>GROUP_RETIREMENT_SAVINGS_PLAN_GRSP</li><li>LOCKED_IN_RETIREMENT_SAVINGS_PLAN_LRSP</li><li>RESTRICTED_LOCKED_IN_SAVINGS_PLAN_RLSP</li><li>LOCKED_IN_RETIREMENT_ACCOUNT_LIRA</li><li>REGISTERED_PENSION_PLAN_RPP</li><li>TAX_FREE_SAVINGS_ACCOUNT_TFSA</li><li>LIFE_INCOME_FUND_LIF</li><li>REGISTERED_RETIREMENT_INCOME_FUND_RIF</li><li>SPOUSAL_RETIREMENT_INCOME_FUND_SRIF</li><li>LOCKED_IN_REGISTERED_INVESTMENT_FUND_LRIF</li><li>PRESCRIBED_REGISTERED_RETIREMENT_INCOME_FUND_PRIF</li><li>GUARANTEED_INVESTMENT_CERTIFICATES_GIC</li><li>REGISTERED_DISABILITY_SAVINGS_PLAN_RDSP</li><li>DEFINED_CONTRIBUTION_PLAN</li><li>DEFINED_BENEFIT_PLAN</li><li>EMPLOYEE_STOCK_OPTION_PLAN</li><li>NONQUALIFIED_DEFERRED_COMPENSATION_PLAN_409A</li><li>KEOGH_PLAN</li><li>EMPLOYEE_RETIREMENT_ACCOUNT_ROTH_401K</li><li>DEFERRED_CONTINGENT_CAPITAL_PLAN_DCCP</li><li>EMPLOYEE_BENEFIT_PLAN</li><li>EMPLOYEE_SAVINGS_PLAN</li><li>HEALTH_SAVINGS_ACCOUNT_HSA</li><li>COVERDELL_EDUCATION_SAVINGS_ACCOUNT_ESA</li><li>TESTAMENTARY_TRUST</li><li>ESTATE</li><li>GRANTOR_RETAINED_ANNUITY_TRUST_GRAT</li><li>ADVISORY_ACCOUNT</li><li>NON_PROFIT_ORGANIZATION_501C</li><li>HEALTH_REIMBURSEMENT_ARRANGEMENT_HRA</li><li>INDIVIDUAL_SAVINGS_ACCOUNT_ISA</li><li>CASH_ISA</li><li>STOCKS_AND_SHARES_ISA</li><li>INNOVATIVE_FINANCE_ISA</li><li>JUNIOR_ISA</li><li>EMPLOYEES_PROVIDENT_FUND_ORGANIZATION_EPFO</li><li>PUBLIC_PROVIDENT_FUND_PPF</li><li>EMPLOYEES_PENSION_SCHEME_EPS</li><li>NATIONAL_PENSION_SYSTEM_NPS</li><li>INDEXED_ANNUITY</li><li>ANNUITIZED_ANNUITY</li><li>VARIABLE_ANNUITY</li><li>ROTH_403B</li><li>SPOUSAL_IRA</li><li>SPOUSAL_ROTH_IRA</li><li>SARSEP_IRA</li><li>SUBSTANTIALLY_EQUAL_PERIODIC_PAYMENTS_SEPP</li><li>OFFSHORE_TRUST</li><li>IRREVOCABLE_LIFE_INSURANCE_TRUST</li><li>INTERNATIONAL_TRUST</li><li>LIFE_INTEREST_TRUST</li><li>EMPLOYEE_BENEFIT_TRUST</li><li>PRECIOUS_METAL_ACCOUNT</li><li>INVESTMENT_LOAN_ACCOUNT</li><li>GRANTOR_RETAINED_INCOME_TRUST</li><li>PENSION_PLAN</li><li>DIGITAL_WALLET</li><li>OTHER</li></ul><ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or Sets CurrentBalance
    /// </summary>
    [DataMember(Name="currentBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentBalance")]
    public Money CurrentBalance { get; set; }

    /// <summary>
    /// The status of the account balance refresh request.
    /// </summary>
    /// <value>The status of the account balance refresh request.</value>
    [DataMember(Name="refreshStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshStatus")]
    public string RefreshStatus { get; set; }

    /// <summary>
    /// The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank / Investment</b>:<br> The account number for the bank account as it appears at the site.<br>In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank / Investment</b>:<br> The account number for the bank account as it appears at the site.<br>In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets AvailableBalance
    /// </summary>
    [DataMember(Name="availableBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableBalance")]
    public Money AvailableBalance { get; set; }

    /// <summary>
    /// The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The date time the account information was last retrieved from the provider site and updated in the Yodlee system.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The date time the account information was last retrieved from the provider site and updated in the Yodlee system.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul></value>
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
    /// Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// The type of service. E.g., Bank, Investment <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of service. E.g., Bank, Investment <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="CONTAINER", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CONTAINER")]
    public string CONTAINER { get; set; }

    /// <summary>
    /// Gets or Sets Cash
    /// </summary>
    [DataMember(Name="cash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cash")]
    public Money Cash { get; set; }

    /// <summary>
    /// Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul>
    /// </summary>
    /// <value>Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET accounts/latestBalances</li></ul></value>
    [DataMember(Name="providerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerName")]
    public string ProviderName { get; set; }

    /// <summary>
    /// The reason the account balance refresh failed.
    /// </summary>
    /// <value>The reason the account balance refresh failed.</value>
    [DataMember(Name="failedReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedReason")]
    public string FailedReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountLatestBalance {\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  TotalBalance: ").Append(TotalBalance).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
      sb.Append("  RefreshStatus: ").Append(RefreshStatus).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  CONTAINER: ").Append(CONTAINER).Append("\n");
      sb.Append("  Cash: ").Append(Cash).Append("\n");
      sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
      sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
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
