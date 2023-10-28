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
  public class ProvidersDataset {
    /// <summary>
    /// The name of the dataset requested from the provider site<br><br><b>Account Type</b>: Manual<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The name of the dataset requested from the provider site<br><br><b>Account Type</b>: Manual<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The name of the dataset attribute suported by the provider.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The name of the dataset attribute suported by the provider.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="attribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attribute")]
    public List<Attribute> Attribute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProvidersDataset {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Attribute: ").Append(Attribute).Append("\n");
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
