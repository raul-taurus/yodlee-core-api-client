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
  public class ProviderAccountProfile {
    /// <summary>
    /// PII related data like address, name, phoneNumber, identifier and email.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/profile</li></ul>
    /// </summary>
    /// <value>PII related data like address, name, phoneNumber, identifier and email.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/profile</li></ul></value>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile")]
    public List<Profile> Profile { get; set; }

    /// <summary>
    /// Unique identifier for profile<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/profile</li></ul>
    /// </summary>
    /// <value>Unique identifier for profile<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/profile</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProviderAccountProfile {\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
