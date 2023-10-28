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
  public class DerivedHoldingSummaryResponse {
    /// <summary>
    /// Gets or Sets HoldingSummary
    /// </summary>
    [DataMember(Name="holdingSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holdingSummary")]
    public List<DerivedHoldingsSummary> HoldingSummary { get; set; }

    /// <summary>
    /// Gets or Sets Link
    /// </summary>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public DerivedHoldingsLinks Link { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedHoldingSummaryResponse {\n");
      sb.Append("  HoldingSummary: ").Append(HoldingSummary).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
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
