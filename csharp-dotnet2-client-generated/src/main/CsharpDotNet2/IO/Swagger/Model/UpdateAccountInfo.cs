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
  public class UpdateAccountInfo {
    /// <summary>
    /// Gets or Sets Container
    /// </summary>
    [DataMember(Name="container", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container")]
    public string Container { get; set; }

    /// <summary>
    /// Gets or Sets IncludeInNetWorth
    /// </summary>
    [DataMember(Name="includeInNetWorth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInNetWorth")]
    public string IncludeInNetWorth { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public AccountAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets AccountName
    /// </summary>
    [DataMember(Name="accountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets DueDate
    /// </summary>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public string DueDate { get; set; }

    /// <summary>
    /// Gets or Sets Memo
    /// </summary>
    [DataMember(Name="memo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memo")]
    public string Memo { get; set; }

    /// <summary>
    /// Gets or Sets HomeValue
    /// </summary>
    [DataMember(Name="homeValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeValue")]
    public Money HomeValue { get; set; }

    /// <summary>
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public string Frequency { get; set; }

    /// <summary>
    /// Gets or Sets AccountStatus
    /// </summary>
    [DataMember(Name="accountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountStatus")]
    public string AccountStatus { get; set; }

    /// <summary>
    /// Gets or Sets AmountDue
    /// </summary>
    [DataMember(Name="amountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountDue")]
    public Money AmountDue { get; set; }

    /// <summary>
    /// List of loan accounts to which a real-estate account is linked.
    /// </summary>
    /// <value>List of loan accounts to which a real-estate account is linked.</value>
    [DataMember(Name="linkedAccountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedAccountIds")]
    public List<long?> LinkedAccountIds { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Money Balance { get; set; }

    /// <summary>
    /// Gets or Sets IsEbillEnrolled
    /// </summary>
    [DataMember(Name="isEbillEnrolled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEbillEnrolled")]
    public string IsEbillEnrolled { get; set; }

    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateAccountInfo {\n");
      sb.Append("  Container: ").Append(Container).Append("\n");
      sb.Append("  IncludeInNetWorth: ").Append(IncludeInNetWorth).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  HomeValue: ").Append(HomeValue).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
      sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
      sb.Append("  LinkedAccountIds: ").Append(LinkedAccountIds).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  IsEbillEnrolled: ").Append(IsEbillEnrolled).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
