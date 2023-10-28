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
  public class AccessTokens {
    /// <summary>
    /// The identifier of the application for which the access token is generated.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul>
    /// </summary>
    /// <value>The identifier of the application for which the access token is generated.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul></value>
    [DataMember(Name="appId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appId")]
    public string AppId { get; set; }

    /// <summary>
    /// Access token value used to invoke the widgets/apps.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul>
    /// </summary>
    /// <value>Access token value used to invoke the widgets/apps.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul></value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Base URL using which the application is accessed.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul>
    /// </summary>
    /// <value>Base URL using which the application is accessed.<br><br><b>Endpoints</b>:<ul><li>GET user/accessTokens</li></ul></value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessTokens {\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
