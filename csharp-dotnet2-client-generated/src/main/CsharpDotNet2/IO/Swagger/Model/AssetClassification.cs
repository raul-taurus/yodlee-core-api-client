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
  public class AssetClassification {
    /// <summary>
    /// The allocation percentage of the holding.<br><br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The allocation percentage of the holding.<br><br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="allocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allocation")]
    public double? Allocation { get; set; }

    /// <summary>
    /// The type of classification to which the investment belongs (assetClass, country, sector, and style).<br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The type of classification to which the investment belongs (assetClass, country, sector, and style).<br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="classificationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classificationType")]
    public string ClassificationType { get; set; }

    /// <summary>
    /// The value for each classificationType.<br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The value for each classificationType.<br><b>Required Feature Enablement</b>: Asset classification feature<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="classificationValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classificationValue")]
    public string ClassificationValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetClassification {\n");
      sb.Append("  Allocation: ").Append(Allocation).Append("\n");
      sb.Append("  ClassificationType: ").Append(ClassificationType).Append("\n");
      sb.Append("  ClassificationValue: ").Append(ClassificationValue).Append("\n");
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
