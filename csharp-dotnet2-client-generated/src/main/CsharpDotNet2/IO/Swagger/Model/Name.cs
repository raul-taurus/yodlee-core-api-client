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
  public class Name {
    /// <summary>
    /// Middle name.
    /// </summary>
    /// <value>Middle name.</value>
    [DataMember(Name="middle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middle")]
    public string Middle { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    /// <value>Last name.</value>
    [DataMember(Name="last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last")]
    public string Last { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    /// <value>Full name.</value>
    [DataMember(Name="fullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullName")]
    public string FullName { get; set; }

    /// <summary>
    /// First name.
    /// </summary>
    /// <value>First name.</value>
    [DataMember(Name="first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first")]
    public string First { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Name {\n");
      sb.Append("  Middle: ").Append(Middle).Append("\n");
      sb.Append("  Last: ").Append(Last).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  First: ").Append(First).Append("\n");
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
