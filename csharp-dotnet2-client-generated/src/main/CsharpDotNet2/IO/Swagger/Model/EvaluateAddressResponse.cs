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
  public class EvaluateAddressResponse {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public List<AccountAddress> Address { get; set; }

    /// <summary>
    /// Gets or Sets IsValidAddress
    /// </summary>
    [DataMember(Name="isValidAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isValidAddress")]
    public bool? IsValidAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EvaluateAddressResponse {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  IsValidAddress: ").Append(IsValidAddress).Append("\n");
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
