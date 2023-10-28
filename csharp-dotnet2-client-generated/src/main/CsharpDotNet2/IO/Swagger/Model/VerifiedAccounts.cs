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
  public class VerifiedAccounts {
    /// <summary>
    /// The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The account name as it appears at the site.<br>(The POST accounts service response return this field as name)<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// The status of the account verification.
    /// </summary>
    /// <value>The status of the account verification.</value>
    [DataMember(Name="verificationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationStatus")]
    public string VerificationStatus { get; set; }

    /// <summary>
    /// The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>MONEY_MARKET</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The type of account that is aggregated, i.e., savings, checking, charge, HELOC, etc. The account type is derived based on the attributes of the account. <br><b>Valid Values:</b><br><b>Aggregated Account Type</b><br><b>bank</b><ul><li>CHECKING</li><li>SAVINGS</li><li>MONEY_MARKET</li></ul><b>investment (SN 1.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><b>investment (SN 2.0)</b><ul><li>BROKERAGE_MARGIN</li><li>BROKERAGE_CASH</li><li>BROKERAGE_LINK_ACCOUNT</li><li>INDIVIDUAL</li><li>CMA</li></ul><ul><li>GET /verification/verifiedAccounts</li></ul></value>
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
    /// The name or identification of the account owner, as it appears at the FI site. <br><b>Note:</b> The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The name or identification of the account owner, as it appears at the FI site. <br><b>Note:</b> The account holder name can be full or partial based on how it is displayed in the account summary page of the FI site. In most cases, the FI site does not display the full account holder name in the account summary page.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="displayedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayedName")]
    public string DisplayedName { get; set; }

    /// <summary>
    /// Holder details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>Holder details of the account.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="holder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holder")]
    public List<AccountHolder> Holder { get; set; }

    /// <summary>
    /// The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank / Investment</b>:<br> The account number for the bank account as it appears at the site.<br>In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The account number as it appears on the site. (The POST accounts service response return this field as number)<br><b>Additional Details</b>:<b> Bank / Investment</b>:<br> The account number for the bank account as it appears at the site.<br>In most cases, the site does not display the full account number in the account summary page and additional navigation is required to aggregate it.<br><b>Applicable containers</b>: bank, investment<br><b>Aggregated / Manual</b>: Aggregated<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// The classification of the account such as personal, corporate, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<li>GET /verification/verifiedAccounts</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The classification of the account such as personal, corporate, etc.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<li>GET /verification/verifiedAccounts</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="classification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classification")]
    public string Classification { get; set; }

    /// <summary>
    /// Gets or Sets AvailableBalance
    /// </summary>
    [DataMember(Name="availableBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableBalance")]
    public Money AvailableBalance { get; set; }

    /// <summary>
    /// Gets or Sets FullAccountNumberList
    /// </summary>
    [DataMember(Name="fullAccountNumberList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullAccountNumberList")]
    public FullAccountNumberList FullAccountNumberList { get; set; }

    /// <summary>
    /// The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Attribute to return the classification of the account age by specifying whether the account is old/new/recent as relevant for a verification use case. If it could not be classified into any one of these values, the attribute would return the value as 'unclassified'
    /// </summary>
    /// <value>Attribute to return the classification of the account age by specifying whether the account is old/new/recent as relevant for a verification use case. If it could not be classified into any one of these values, the attribute would return the value as 'unclassified'</value>
    [DataMember(Name="accountAgeClassification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountAgeClassification")]
    public string AccountAgeClassification { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Money Balance { get; set; }

    /// <summary>
    /// Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>Identifier of the provider site. The primary key of provider resource. <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>The primary key of the provider account resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// The type of service. E.g., Bank, Investment <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of service. E.g., Bank, Investment <br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</ul><b>Applicable Values</b><br></value>
    [DataMember(Name="CONTAINER", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CONTAINER")]
    public string CONTAINER { get; set; }

    /// <summary>
    /// Indicates if an account is selected by the user in the FastLink 4 application
    /// </summary>
    /// <value>Indicates if an account is selected by the user in the FastLink 4 application</value>
    [DataMember(Name="isSelected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSelected")]
    public bool? IsSelected { get; set; }

    /// <summary>
    /// Gets or Sets Cash
    /// </summary>
    [DataMember(Name="cash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cash")]
    public Money Cash { get; set; }

    /// <summary>
    /// Bank and branch identification information.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>Bank and branch identification information.<br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<br><ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="bankTransferCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankTransferCode")]
    public List<BankTransferCode> BankTransferCode { get; set; }

    /// <summary>
    /// Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul>
    /// </summary>
    /// <value>Service provider or institution name where the account originates. This belongs to the provider resource.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: bank, investment<br><b>Endpoints</b>:<ul><li>GET /verification/verifiedAccounts</li></ul></value>
    [DataMember(Name="providerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerName")]
    public string ProviderName { get; set; }

    /// <summary>
    /// The reason for the verification failure of the account.
    /// </summary>
    /// <value>The reason for the verification failure of the account.</value>
    [DataMember(Name="failedReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedReason")]
    public string FailedReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerifiedAccounts {\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
      sb.Append("  DisplayedName: ").Append(DisplayedName).Append("\n");
      sb.Append("  Holder: ").Append(Holder).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Classification: ").Append(Classification).Append("\n");
      sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
      sb.Append("  FullAccountNumberList: ").Append(FullAccountNumberList).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountAgeClassification: ").Append(AccountAgeClassification).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  CONTAINER: ").Append(CONTAINER).Append("\n");
      sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
      sb.Append("  Cash: ").Append(Cash).Append("\n");
      sb.Append("  BankTransferCode: ").Append(BankTransferCode).Append("\n");
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
