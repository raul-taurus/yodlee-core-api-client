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
  public class TransactionCategoryRequest {
    /// <summary>
    /// Gets or Sets ParentCategoryId
    /// </summary>
    [DataMember(Name="parentCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentCategoryId")]
    public int? ParentCategoryId { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets CategoryName
    /// </summary>
    [DataMember(Name="categoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryName")]
    public string CategoryName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionCategoryRequest {\n");
      sb.Append("  ParentCategoryId: ").Append(ParentCategoryId).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
