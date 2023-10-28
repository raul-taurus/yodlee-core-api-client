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
  public class FieldOperation {
    /// <summary>
    /// Field for which the clause is created.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable Values</b>:<ul><li>amount</li><li>description</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Field for which the clause is created.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable Values</b>:<ul><li>amount</li><li>description</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }

    /// <summary>
    /// Operation for which the clause is created.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable values (depends on the value of field)</b>:<ul><li>field is <b>description</b> -> operation can be<ol><li>stringEquals</li><li>stringContains</li></ol></li><li>field is <b>amount</b> -> operation can be<ol><li>numberEquals</li><li>numberLessThan</li><li>numberLessThanEquals</li><li>numberGreaterThan</li><li>numberGreaterThanEquals</li></ol></li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Operation for which the clause is created.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable values (depends on the value of field)</b>:<ul><li>field is <b>description</b> -> operation can be<ol><li>stringEquals</li><li>stringContains</li></ol></li><li>field is <b>amount</b> -> operation can be<ol><li>numberEquals</li><li>numberLessThan</li><li>numberLessThanEquals</li><li>numberGreaterThan</li><li>numberGreaterThanEquals</li></ol></li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public string Operation { get; set; }

    /// <summary>
    /// The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable Values</b>:<ul><li>field is <b>description</b> -> value should be <b>min of 3 and max of 50 characters</b></li><li>field is <b>amount</b> -> value should be <b> min value of 0 and a max value of 99999999999.99</b></li></ul>
    /// </summary>
    /// <value>The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.<br><br><b>Applicable containers</b>: bank, creditCard, investment, insurance, loan<br><b>Applicable Values</b>:<ul><li>field is <b>description</b> -> value should be <b>min of 3 and max of 50 characters</b></li><li>field is <b>amount</b> -> value should be <b> min value of 0 and a max value of 99999999999.99</b></li></ul></value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Object Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FieldOperation {\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
