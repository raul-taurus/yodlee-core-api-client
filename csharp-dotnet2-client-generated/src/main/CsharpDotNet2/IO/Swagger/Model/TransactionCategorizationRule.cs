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
  public class TransactionCategorizationRule {
    /// <summary>
    /// Details of rules. <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Details of rules. <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="ruleClauses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ruleClauses")]
    public List<RuleClause> RuleClauses { get; set; }

    /// <summary>
    /// Unique identifier generated for every rule the user creates.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Unique identifier generated for every rule the user creates.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="userDefinedRuleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefinedRuleId")]
    public long? UserDefinedRuleId { get; set; }

    /// <summary>
    /// The level of the category for which the rule is created.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br>
    /// </summary>
    /// <value>The level of the category for which the rule is created.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br></value>
    [DataMember(Name="categoryLevelId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryLevelId")]
    public int? CategoryLevelId { get; set; }

    /// <summary>
    /// Category id that is assigned to the transaction when the transaction matches the rule clause. This is the id field of the transaction category resource.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Category id that is assigned to the transaction when the transaction matches the rule clause. This is the id field of the transaction category resource.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="transactionCategorisationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionCategorisationId")]
    public long? TransactionCategorisationId { get; set; }

    /// <summary>
    /// Unique identifier of the user.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Unique identifier of the user.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="memId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memId")]
    public long? MemId { get; set; }

    /// <summary>
    /// The order in which the rules get executed on transactions.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>The order in which the rules get executed on transactions.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="rulePriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rulePriority")]
    public int? RulePriority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionCategorizationRule {\n");
      sb.Append("  RuleClauses: ").Append(RuleClauses).Append("\n");
      sb.Append("  UserDefinedRuleId: ").Append(UserDefinedRuleId).Append("\n");
      sb.Append("  CategoryLevelId: ").Append(CategoryLevelId).Append("\n");
      sb.Append("  TransactionCategorisationId: ").Append(TransactionCategorisationId).Append("\n");
      sb.Append("  MemId: ").Append(MemId).Append("\n");
      sb.Append("  RulePriority: ").Append(RulePriority).Append("\n");
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
