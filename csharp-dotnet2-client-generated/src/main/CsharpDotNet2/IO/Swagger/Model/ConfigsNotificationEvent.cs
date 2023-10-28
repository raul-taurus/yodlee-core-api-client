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
  public class ConfigsNotificationEvent {
    /// <summary>
    /// Name of the event for which the customers must subscribe to receive notifications.<br><b>Valid Value:</b> Notification Events Name<br><br><b>Endpoints</b>:<ul><li>GET configs/notifications/events</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Name of the event for which the customers must subscribe to receive notifications.<br><b>Valid Value:</b> Notification Events Name<br><br><b>Endpoints</b>:<ul><li>GET configs/notifications/events</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// URL to which the notification should be posted.<br><br><b>Endpoints</b>:<ul><li>GET configs/notifications/events</li></ul>
    /// </summary>
    /// <value>URL to which the notification should be posted.<br><br><b>Endpoints</b>:<ul><li>GET configs/notifications/events</li></ul></value>
    [DataMember(Name="callbackUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackUrl")]
    public string CallbackUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigsNotificationEvent {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
