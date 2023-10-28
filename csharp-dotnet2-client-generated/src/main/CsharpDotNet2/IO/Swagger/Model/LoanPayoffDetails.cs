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
  public class LoanPayoffDetails {
    /// <summary>
    /// The date by which the payoff amount should be paid.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>The date by which the payoff amount should be paid.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="payByDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payByDate")]
    public string PayByDate { get; set; }

    /// <summary>
    /// Gets or Sets PayoffAmount
    /// </summary>
    [DataMember(Name="payoffAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payoffAmount")]
    public Money PayoffAmount { get; set; }

    /// <summary>
    /// Gets or Sets OutstandingBalance
    /// </summary>
    [DataMember(Name="outstandingBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outstandingBalance")]
    public Money OutstandingBalance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoanPayoffDetails {\n");
      sb.Append("  PayByDate: ").Append(PayByDate).Append("\n");
      sb.Append("  PayoffAmount: ").Append(PayoffAmount).Append("\n");
      sb.Append("  OutstandingBalance: ").Append(OutstandingBalance).Append("\n");
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
