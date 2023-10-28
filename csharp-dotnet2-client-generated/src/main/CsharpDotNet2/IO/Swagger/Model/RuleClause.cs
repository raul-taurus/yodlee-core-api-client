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
  public class RuleClause {
    /// <summary>
    /// Field for which the clause is created.<br><br><br><b>Valid Values</b>:amount,description<b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Field for which the clause is created.<br><br><br><b>Valid Values</b>:amount,description<b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }

    /// <summary>
    /// Unique identifier generated for every rule the user creates.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Unique identifier generated for every rule the user creates.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="userDefinedRuleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefinedRuleId")]
    public long? UserDefinedRuleId { get; set; }

    /// <summary>
    /// The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="fieldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldValue")]
    public string FieldValue { get; set; }

    /// <summary>
    /// Operation for which the clause is created.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Operation for which the clause is created.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public string Operation { get; set; }

    /// <summary>
    /// Unique identifier generated for the rule clause.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Unique identifier generated for the rule clause.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="ruleClauseId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ruleClauseId")]
    public long? RuleClauseId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RuleClause {\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  UserDefinedRuleId: ").Append(UserDefinedRuleId).Append("\n");
      sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      sb.Append("  RuleClauseId: ").Append(RuleClauseId).Append("\n");
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
