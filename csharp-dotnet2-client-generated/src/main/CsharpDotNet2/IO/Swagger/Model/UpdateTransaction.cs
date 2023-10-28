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
  public class UpdateTransaction {
    /// <summary>
    /// Gets or Sets CategorySource
    /// </summary>
    [DataMember(Name="categorySource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorySource")]
    public string CategorySource { get; set; }

    /// <summary>
    /// Gets or Sets Container
    /// </summary>
    [DataMember(Name="container", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container")]
    public string Container { get; set; }

    /// <summary>
    /// Gets or Sets IsPhysical
    /// </summary>
    [DataMember(Name="isPhysical", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPhysical")]
    public bool? IsPhysical { get; set; }

    /// <summary>
    /// Gets or Sets DetailCategoryId
    /// </summary>
    [DataMember(Name="detailCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailCategoryId")]
    public long? DetailCategoryId { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public Description Description { get; set; }

    /// <summary>
    /// Gets or Sets Memo
    /// </summary>
    [DataMember(Name="memo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memo")]
    public string Memo { get; set; }

    /// <summary>
    /// Gets or Sets MerchantType
    /// </summary>
    [DataMember(Name="merchantType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantType")]
    public string MerchantType { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTransaction {\n");
      sb.Append("  CategorySource: ").Append(CategorySource).Append("\n");
      sb.Append("  Container: ").Append(Container).Append("\n");
      sb.Append("  IsPhysical: ").Append(IsPhysical).Append("\n");
      sb.Append("  DetailCategoryId: ").Append(DetailCategoryId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
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
