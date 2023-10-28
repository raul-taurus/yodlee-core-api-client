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
  public class Coverage {
    /// <summary>
    /// The coverage amount-related details.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>The coverage amount-related details.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public List<CoverageAmount> Amount { get; set; }

    /// <summary>
    /// The plan type for an insurance provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The plan type for an insurance provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="planType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planType")]
    public string PlanType { get; set; }

    /// <summary>
    /// The date on which the coverage for the account ends or expires.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>The date on which the coverage for the account ends or expires.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public string EndDate { get; set; }

    /// <summary>
    /// The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The type of coverage provided to an individual or an entity.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values:</b><br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The date on which the coverage for the account starts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>The date on which the coverage for the account starts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: insurance,investment<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public string StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Coverage {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  PlanType: ").Append(PlanType).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
