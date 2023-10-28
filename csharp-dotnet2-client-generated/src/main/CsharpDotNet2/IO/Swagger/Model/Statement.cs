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
  public class Statement {
    /// <summary>
    /// The APR applied to the balance on the credit card account, as available in the statement.<br><b>Note:</b> In case of variable APR, the APR available on the statement might differ from the APR available at the account-level.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The APR applied to the balance on the credit card account, as available in the statement.<br><b>Note:</b> In case of variable APR, the APR available on the statement might differ from the APR available at the account-level.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="apr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apr")]
    public double? Apr { get; set; }

    /// <summary>
    /// The APR applicable to cash withdrawals on the credit card account.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The APR applicable to cash withdrawals on the credit card account.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="cashApr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashApr")]
    public double? CashApr { get; set; }

    /// <summary>
    /// The start date of the statement period.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The start date of the statement period.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="billingPeriodStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodStart")]
    public string BillingPeriodStart { get; set; }

    /// <summary>
    /// The date by when the minimum payment is due to be paid.<br><b>Note:</b> The due date that appears in the statement may differ from the due date at the account-level.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The date by when the minimum payment is due to be paid.<br><b>Note:</b> The due date that appears in the statement may differ from the due date at the account-level.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public string DueDate { get; set; }

    /// <summary>
    /// Gets or Sets InterestAmount
    /// </summary>
    [DataMember(Name="interestAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestAmount")]
    public Money InterestAmount { get; set; }

    /// <summary>
    /// The date on which the statement is generated.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The date on which the statement is generated.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="statementDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statementDate")]
    public string StatementDate { get; set; }

    /// <summary>
    /// Gets or Sets CashAdvance
    /// </summary>
    [DataMember(Name="cashAdvance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashAdvance")]
    public Money CashAdvance { get; set; }

    /// <summary>
    /// The end date of the statement period.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The end date of the statement period.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="billingPeriodEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPeriodEnd")]
    public string BillingPeriodEnd { get; set; }

    /// <summary>
    /// Gets or Sets PrincipalAmount
    /// </summary>
    [DataMember(Name="principalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principalAmount")]
    public Money PrincipalAmount { get; set; }

    /// <summary>
    /// Gets or Sets LoanBalance
    /// </summary>
    [DataMember(Name="loanBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loanBalance")]
    public Money LoanBalance { get; set; }

    /// <summary>
    /// Gets or Sets AmountDue
    /// </summary>
    [DataMember(Name="amountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountDue")]
    public Money AmountDue { get; set; }

    /// <summary>
    /// Account to which the statement belongs to.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Account to which the statement belongs to.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The date when the account was last updated by Yodlee.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The date when the account was last updated by Yodlee.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// The field is set to true if the statement is the latest generated statement.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The field is set to true if the statement is the latest generated statement.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="isLatest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLatest")]
    public bool? IsLatest { get; set; }

    /// <summary>
    /// Gets or Sets MinimumPayment
    /// </summary>
    [DataMember(Name="minimumPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumPayment")]
    public Money MinimumPayment { get; set; }

    /// <summary>
    /// The date on which the last payment was done during the billing cycle.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The date on which the last payment was done during the billing cycle.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="lastPaymentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentDate")]
    public string LastPaymentDate { get; set; }

    /// <summary>
    /// Gets or Sets LastPaymentAmount
    /// </summary>
    [DataMember(Name="lastPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPaymentAmount")]
    public Money LastPaymentAmount { get; set; }

    /// <summary>
    /// Unique identifier for the statement.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Unique identifier for the statement.<br><br><b>Applicable containers</b>: creditCard, loan, insurance<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets NewCharges
    /// </summary>
    [DataMember(Name="newCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newCharges")]
    public Money NewCharges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Statement {\n");
      sb.Append("  Apr: ").Append(Apr).Append("\n");
      sb.Append("  CashApr: ").Append(CashApr).Append("\n");
      sb.Append("  BillingPeriodStart: ").Append(BillingPeriodStart).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  InterestAmount: ").Append(InterestAmount).Append("\n");
      sb.Append("  StatementDate: ").Append(StatementDate).Append("\n");
      sb.Append("  CashAdvance: ").Append(CashAdvance).Append("\n");
      sb.Append("  BillingPeriodEnd: ").Append(BillingPeriodEnd).Append("\n");
      sb.Append("  PrincipalAmount: ").Append(PrincipalAmount).Append("\n");
      sb.Append("  LoanBalance: ").Append(LoanBalance).Append("\n");
      sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
      sb.Append("  MinimumPayment: ").Append(MinimumPayment).Append("\n");
      sb.Append("  LastPaymentDate: ").Append(LastPaymentDate).Append("\n");
      sb.Append("  LastPaymentAmount: ").Append(LastPaymentAmount).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NewCharges: ").Append(NewCharges).Append("\n");
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
