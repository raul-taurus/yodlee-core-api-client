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
  public class Cobrand {
    /// <summary>
    /// Gets or Sets CobrandLogin
    /// </summary>
    [DataMember(Name="cobrandLogin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cobrandLogin")]
    public string CobrandLogin { get; set; }

    /// <summary>
    /// Gets or Sets CobrandPassword
    /// </summary>
    [DataMember(Name="cobrandPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cobrandPassword")]
    public string CobrandPassword { get; set; }

    /// <summary>
    /// The customer's locale that will be considered for the localization functionality.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul>
    /// </summary>
    /// <value>The customer's locale that will be considered for the localization functionality.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul></value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Cobrand {\n");
      sb.Append("  CobrandLogin: ").Append(CobrandLogin).Append("\n");
      sb.Append("  CobrandPassword: ").Append(CobrandPassword).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
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
