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
  public class HolderProfileResponse {
    /// <summary>
    /// The holder profile entity encapsulates all the user's details, such as the corresponding accounts and the userâ€™s profile data under it
    /// </summary>
    /// <value>The holder profile entity encapsulates all the user's details, such as the corresponding accounts and the userâ€™s profile data under it</value>
    [DataMember(Name="holderProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderProfile")]
    public List<VerificationHolderProfile> HolderProfile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HolderProfileResponse {\n");
      sb.Append("  HolderProfile: ").Append(HolderProfile).Append("\n");
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
