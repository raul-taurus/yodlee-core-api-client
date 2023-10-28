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
  public class TransactionCategorizationRuleInfo {
    /// <summary>
    /// Gets or Sets RuleClause
    /// </summary>
    [DataMember(Name="ruleClause", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ruleClause")]
    public List<FieldOperation> RuleClause { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public int? CategoryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionCategorizationRuleInfo {\n");
      sb.Append("  RuleClause: ").Append(RuleClause).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
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
