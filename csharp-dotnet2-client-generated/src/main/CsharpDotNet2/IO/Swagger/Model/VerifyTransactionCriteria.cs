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
  public class VerifyTransactionCriteria {
    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// Gets or Sets VerifiedTransaction
    /// </summary>
    [DataMember(Name="verifiedTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verifiedTransaction")]
    public List<Transaction> VerifiedTransaction { get; set; }

    /// <summary>
    /// Indicates if the criteria is matched or not. <br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates if the criteria is matched or not. <br><b>Applicable Values</b><br></value>
    [DataMember(Name="matched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matched")]
    public string Matched { get; set; }

    /// <summary>
    /// Gets or Sets Keyword
    /// </summary>
    [DataMember(Name="keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyword")]
    public string Keyword { get; set; }

    /// <summary>
    /// Gets or Sets DateVariance
    /// </summary>
    [DataMember(Name="dateVariance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateVariance")]
    public string DateVariance { get; set; }

    /// <summary>
    /// Indicates if the transaction appears as a debit or a credit transaction in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates if the transaction appears as a debit or a credit transaction in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="baseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseType")]
    public string BaseType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerifyTransactionCriteria {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  VerifiedTransaction: ").Append(VerifiedTransaction).Append("\n");
      sb.Append("  Matched: ").Append(Matched).Append("\n");
      sb.Append("  Keyword: ").Append(Keyword).Append("\n");
      sb.Append("  DateVariance: ").Append(DateVariance).Append("\n");
      sb.Append("  BaseType: ").Append(BaseType).Append("\n");
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
