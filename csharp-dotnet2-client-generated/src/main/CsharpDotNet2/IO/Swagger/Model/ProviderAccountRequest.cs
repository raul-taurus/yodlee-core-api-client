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
  public class ProviderAccountRequest {
    /// <summary>
    /// Consent Id generated for the request through POST Consent.<br><br><b>Endpoints</b>:<ul><li>POST Provider Account</li><li>PUT Provider Account</li></ul>
    /// </summary>
    /// <value>Consent Id generated for the request through POST Consent.<br><br><b>Endpoints</b>:<ul><li>POST Provider Account</li><li>PUT Provider Account</li></ul></value>
    [DataMember(Name="consentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consentId")]
    public long? ConsentId { get; set; }

    /// <summary>
    /// Gets or Sets Preferences
    /// </summary>
    [DataMember(Name="preferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferences")]
    public ProviderAccountPreferences Preferences { get; set; }

    /// <summary>
    /// Gets or Sets AggregationSource
    /// </summary>
    [DataMember(Name="aggregationSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregationSource")]
    public string AggregationSource { get; set; }

    /// <summary>
    /// Gets or Sets Field
    /// </summary>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public List<Field> Field { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProviderAccountRequest {\n");
      sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
      sb.Append("  Preferences: ").Append(Preferences).Append("\n");
      sb.Append("  AggregationSource: ").Append(AggregationSource).Append("\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
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
