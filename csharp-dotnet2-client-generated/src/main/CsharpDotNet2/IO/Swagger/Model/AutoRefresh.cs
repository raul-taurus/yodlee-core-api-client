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
  public class AutoRefresh {
    /// <summary>
    /// Indicates the reason for the status.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates the reason for the status.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="additionalStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalStatus")]
    public string AdditionalStatus { get; set; }

    /// <summary>
    /// Date on which the auto refresh status is determined.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Date on which the auto refresh status is determined.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="asOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asOfDate")]
    public string AsOfDate { get; set; }

    /// <summary>
    /// Indicates whether auto refresh is enabled or disabled.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates whether auto refresh is enabled or disabled.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutoRefresh {\n");
      sb.Append("  AdditionalStatus: ").Append(AdditionalStatus).Append("\n");
      sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
