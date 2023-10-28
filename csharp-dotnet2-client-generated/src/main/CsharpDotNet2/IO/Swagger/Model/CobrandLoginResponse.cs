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
  public class CobrandLoginResponse {
    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    [DataMember(Name="session", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "session")]
    public CobrandSession Session { get; set; }

    /// <summary>
    /// Unique identifier of the cobrand (customer) in the system.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul>
    /// </summary>
    /// <value>Unique identifier of the cobrand (customer) in the system.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul></value>
    [DataMember(Name="cobrandId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cobrandId")]
    public long? CobrandId { get; set; }

    /// <summary>
    /// The application identifier.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul>
    /// </summary>
    /// <value>The application identifier.<br><br><b>Endpoints</b>:<ul><li>POST cobrand/login</li></ul></value>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

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
      sb.Append("class CobrandLoginResponse {\n");
      sb.Append("  Session: ").Append(Session).Append("\n");
      sb.Append("  CobrandId: ").Append(CobrandId).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
