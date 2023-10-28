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
  public class DataExtractsEventLinks {
    /// <summary>
    /// Gets or Sets MethodType
    /// </summary>
    [DataMember(Name="methodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methodType")]
    public string MethodType { get; set; }

    /// <summary>
    /// Gets or Sets Rel
    /// </summary>
    [DataMember(Name="rel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rel")]
    public string Rel { get; set; }

    /// <summary>
    /// Gets or Sets Href
    /// </summary>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataExtractsEventLinks {\n");
      sb.Append("  MethodType: ").Append(MethodType).Append("\n");
      sb.Append("  Rel: ").Append(Rel).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
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
