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
  public class AccountHolder {
    /// <summary>
    /// Identifiers of the account holder.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Identifiers of the account holder.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public List<Identifier> Identifier { get; set; }

    /// <summary>
    /// Identifiers of the account holder.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Identifiers of the account holder.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Indicates the ownership of the account.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates the ownership of the account.<br><br><b>Aggregated / Manual</b>: Aggregated <br><b>Applicable containers</b>: bank<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="ownership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownership")]
    public string Ownership { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public Name Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountHolder {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Ownership: ").Append(Ownership).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
