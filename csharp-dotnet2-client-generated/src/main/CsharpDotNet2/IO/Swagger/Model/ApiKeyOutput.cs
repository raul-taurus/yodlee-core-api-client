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
  public class ApiKeyOutput {
    /// <summary>
    /// Time in seconds after which the JWT token created for users expires.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>Time in seconds after which the JWT token created for users expires.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="expiresIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresIn")]
    public long? ExpiresIn { get; set; }

    /// <summary>
    /// The date on which the apiKey was created for the customer.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>The date on which the apiKey was created for the customer.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// Public key uploaded by the customer while generating ApiKey.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>Public key uploaded by the customer while generating ApiKey.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// ApiKey or the issuer key used to generate the JWT token for authentication.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul>
    /// </summary>
    /// <value>ApiKey or the issuer key used to generate the JWT token for authentication.<br><br><b>Endpoints</b>:<ul><li>GET /auth/apiKey</li><li>POST /auth/apiKey</li></ul></value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiKeyOutput {\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
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
