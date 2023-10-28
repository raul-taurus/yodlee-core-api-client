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
  public class CreateAccountInfo {
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
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

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
    /// Gets or Sets AmountDue
    /// </summary>
    [DataMember(Name="amountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountDue")]
    public Money AmountDue { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Money Balance { get; set; }

    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Gets or Sets ValuationType
    /// </summary>
    [DataMember(Name="valuationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valuationType")]
    public string ValuationType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateAccountInfo {\n");
      sb.Append("  IncludeInNetWorth: ").Append(IncludeInNetWorth).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  HomeValue: ").Append(HomeValue).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  ValuationType: ").Append(ValuationType).Append("\n");
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
