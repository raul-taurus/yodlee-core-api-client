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
  public class ClientCredentialToken {
    /// <summary>
    /// Time in seconds after which the issued accessToken expires.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul>
    /// </summary>
    /// <value>Time in seconds after which the issued accessToken expires.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul></value>
    [DataMember(Name="expiresIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresIn")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// The date and time on which accessToken was created for the customer.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul>
    /// </summary>
    /// <value>The date and time on which accessToken was created for the customer.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul></value>
    [DataMember(Name="issuedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuedAt")]
    public string IssuedAt { get; set; }

    /// <summary>
    /// Access Token to access YSL 1.1 services.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul>
    /// </summary>
    /// <value>Access Token to access YSL 1.1 services.<br><br><b>Endpoints</b>:<ul><li>POST /auth/token</li></ul></value>
    [DataMember(Name="accessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessToken")]
    public string AccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientCredentialToken {\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
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
