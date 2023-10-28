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
  public class UserRegistration {
    /// <summary>
    /// Gets or Sets Preferences
    /// </summary>
    [DataMember(Name="preferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferences")]
    public UserRequestPreferences Preferences { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public UserAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets LoginName
    /// </summary>
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
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets SegmentName
    /// </summary>
    [DataMember(Name="segmentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segmentName")]
    public string SegmentName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRegistration {\n");
      sb.Append("  Preferences: ").Append(Preferences).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  LoginName: ").Append(LoginName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  SegmentName: ").Append(SegmentName).Append("\n");
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
