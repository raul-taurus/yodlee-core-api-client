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
  public class ApiKeyRequest {
    /// <summary>
    /// Public key uploaded by the customer while generating ApiKey.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>Public key uploaded by the customer while generating ApiKey.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiKeyRequest {\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
