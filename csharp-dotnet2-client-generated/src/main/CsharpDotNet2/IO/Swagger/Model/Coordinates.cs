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
  public class Coordinates {
    /// <summary>
    /// Latitude of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,loan<br>
    /// </summary>
    /// <value>Latitude of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,loan<br></value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,loan<br>
    /// </summary>
    /// <value>Longitude of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,loan<br></value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public double? Longitude { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Coordinates {\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
