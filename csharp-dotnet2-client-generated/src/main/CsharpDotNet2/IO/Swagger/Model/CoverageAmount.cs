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
  public class CoverageAmount {
    /// <summary>
    /// Gets or Sets Cover
    /// </summary>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover")]
    public Money Cover { get; set; }

    /// <summary>
    /// The type of coverage unit indicates if the coverage is for an individual or a family.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The type of coverage unit indicates if the coverage is for an individual or a family.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="unitType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitType")]
    public string UnitType { get; set; }

    /// <summary>
    /// The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The type of coverage limit indicates if the coverage is in-network or out-of-network.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The type of coverage limit indicates if the coverage is in-network or out-of-network.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="limitType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitType")]
    public string LimitType { get; set; }

    /// <summary>
    /// Gets or Sets Met
    /// </summary>
    [DataMember(Name="met", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "met")]
    public Money Met { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CoverageAmount {\n");
      sb.Append("  Cover: ").Append(Cover).Append("\n");
      sb.Append("  UnitType: ").Append(UnitType).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  LimitType: ").Append(LimitType).Append("\n");
      sb.Append("  Met: ").Append(Met).Append("\n");
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
