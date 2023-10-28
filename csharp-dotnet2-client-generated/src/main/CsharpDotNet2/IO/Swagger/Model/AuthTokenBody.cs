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
  public class AuthTokenBody {
    /// <summary>
    /// clientId issued by Yodlee is used to generate the OAuth token for authentication.
    /// </summary>
    /// <value>clientId issued by Yodlee is used to generate the OAuth token for authentication.</value>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// secret issued by Yodlee is used to generate the OAuth token for authentication.
    /// </summary>
    /// <value>secret issued by Yodlee is used to generate the OAuth token for authentication.</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthTokenBody {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
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
