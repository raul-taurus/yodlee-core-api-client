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
  public class UpdateCobrandNotificationEvent {
    /// <summary>
    /// URL to which the notification should be posted.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/config/notifications/events</li></ul>
    /// </summary>
    /// <value>URL to which the notification should be posted.<br><br><b>Endpoints</b>:<ul><li>GET cobrand/config/notifications/events</li></ul></value>
    [DataMember(Name="callbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackUrl")]
    public string CallbackUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateCobrandNotificationEvent {\n");
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
