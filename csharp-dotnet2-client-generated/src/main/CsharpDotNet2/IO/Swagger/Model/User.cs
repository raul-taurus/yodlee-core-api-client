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
  public class User {
    /// <summary>
    /// Gets or Sets Preferences
    /// </summary>
    [DataMember(Name="preferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferences")]
    public UserResponsePreferences Preferences { get; set; }

    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    [DataMember(Name="session", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "session")]
    public UserSession Session { get; set; }

    /// <summary>
    /// The login name of the user used for authentication.<br><br><b>Endpoints</b>:<ul><li>POST user/register</li><li>GET user</li></ul>
    /// </summary>
    /// <value>The login name of the user used for authentication.<br><br><b>Endpoints</b>:<ul><li>POST user/register</li><li>GET user</li></ul></value>
    [DataMember(Name="loginName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginName")]
    public string LoginName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public Name Name { get; set; }

    /// <summary>
    /// The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.<br><br><b>Endpoints</b>:<ul><li>POST user/samlLogin</li><li>POST user/register</li><li>GET user</li></ul>
    /// </summary>
    /// <value>The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.<br><br><b>Endpoints</b>:<ul><li>POST user/samlLogin</li><li>POST user/register</li><li>GET user</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets RoleType
    /// </summary>
    [DataMember(Name="roleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roleType")]
    public string RoleType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Preferences: ").Append(Preferences).Append("\n");
      sb.Append("  Session: ").Append(Session).Append("\n");
      sb.Append("  LoginName: ").Append(LoginName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RoleType: ").Append(RoleType).Append("\n");
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
