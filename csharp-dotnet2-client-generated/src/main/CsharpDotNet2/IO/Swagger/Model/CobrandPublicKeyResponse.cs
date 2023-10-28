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
  public class CobrandPublicKeyResponse {
    /// <summary>
    /// The key name used for encryption.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/publicKey</li></ul>
    /// </summary>
    /// <value>The key name used for encryption.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/publicKey</li></ul></value>
    [DataMember(Name="keyAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyAlias")]
    public string KeyAlias { get; set; }

    /// <summary>
    /// Public key that the customer should be using to encrypt the credentials and answers before sending to the add & update providerAccounts APIs.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/publicKey</li></ul>
    /// </summary>
    /// <value>Public key that the customer should be using to encrypt the credentials and answers before sending to the add & update providerAccounts APIs.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/publicKey</li></ul></value>
    [DataMember(Name="keyAsPemString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyAsPemString")]
    public string KeyAsPemString { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CobrandPublicKeyResponse {\n");
      sb.Append("  KeyAlias: ").Append(KeyAlias).Append("\n");
      sb.Append("  KeyAsPemString: ").Append(KeyAsPemString).Append("\n");
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
