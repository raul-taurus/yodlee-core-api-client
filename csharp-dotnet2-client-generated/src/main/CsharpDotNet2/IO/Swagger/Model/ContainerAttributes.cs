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
  public class ContainerAttributes {
    /// <summary>
    /// Gets or Sets BANK
    /// </summary>
    [DataMember(Name="BANK", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BANK")]
    public TransactionDays BANK { get; set; }

    /// <summary>
    /// Gets or Sets LOAN
    /// </summary>
    [DataMember(Name="LOAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LOAN")]
    public TransactionDays LOAN { get; set; }

    /// <summary>
    /// Gets or Sets CREDITCARD
    /// </summary>
    [DataMember(Name="CREDITCARD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CREDITCARD")]
    public TransactionDays CREDITCARD { get; set; }

    /// <summary>
    /// Gets or Sets INVESTMENT
    /// </summary>
    [DataMember(Name="INVESTMENT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "INVESTMENT")]
    public TransactionDays INVESTMENT { get; set; }

    /// <summary>
    /// Gets or Sets INSURANCE
    /// </summary>
    [DataMember(Name="INSURANCE", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "INSURANCE")]
    public TransactionDays INSURANCE { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContainerAttributes {\n");
      sb.Append("  BANK: ").Append(BANK).Append("\n");
      sb.Append("  LOAN: ").Append(LOAN).Append("\n");
      sb.Append("  CREDITCARD: ").Append(CREDITCARD).Append("\n");
      sb.Append("  INVESTMENT: ").Append(INVESTMENT).Append("\n");
      sb.Append("  INSURANCE: ").Append(INSURANCE).Append("\n");
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
