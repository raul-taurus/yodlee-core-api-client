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
  public class ApiKeyResponse {
    /// <summary>
    /// ApiKey customer details.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>ApiKey customer details.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="apiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiKey")]
    public List<ApiKeyOutput> ApiKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiKeyResponse {\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
