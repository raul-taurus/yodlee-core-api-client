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
  public class UserSession {
    /// <summary>
    /// Session provided for a valid user to access API services upon successful authentication.<br><br><b>Endpoints</b>:<ul><li>POST user/samlLogin</li><li>POST user/register</li></ul>
    /// </summary>
    /// <value>Session provided for a valid user to access API services upon successful authentication.<br><br><b>Endpoints</b>:<ul><li>POST user/samlLogin</li><li>POST user/register</li></ul></value>
    [DataMember(Name="userSession", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userSession")]
    public string _UserSession { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSession {\n");
      sb.Append("  _UserSession: ").Append(_UserSession).Append("\n");
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
