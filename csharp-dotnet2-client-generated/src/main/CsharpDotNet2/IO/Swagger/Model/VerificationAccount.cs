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
  public class VerificationAccount {
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
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets UserClassification
    /// </summary>
    [DataMember(Name="userClassification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userClassification")]
    public string UserClassification { get; set; }

    /// <summary>
    /// Gets or Sets BankTransferCode
    /// </summary>
    [DataMember(Name="bankTransferCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankTransferCode")]
    public VerificationBankTransferCode BankTransferCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerificationAccount {\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  UserClassification: ").Append(UserClassification).Append("\n");
      sb.Append("  BankTransferCode: ").Append(BankTransferCode).Append("\n");
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
