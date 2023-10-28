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
  public class DerivedCategorySummaryDetails {
    /// <summary>
    /// Date on which the credit and debit transactions had occured.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>Date on which the credit and debit transactions had occured.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets CreditTotal
    /// </summary>
    [DataMember(Name="creditTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditTotal")]
    public Money CreditTotal { get; set; }

    /// <summary>
    /// Gets or Sets DebitTotal
    /// </summary>
    [DataMember(Name="debitTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "debitTotal")]
    public Money DebitTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedCategorySummaryDetails {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  CreditTotal: ").Append(CreditTotal).Append("\n");
      sb.Append("  DebitTotal: ").Append(DebitTotal).Append("\n");
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
