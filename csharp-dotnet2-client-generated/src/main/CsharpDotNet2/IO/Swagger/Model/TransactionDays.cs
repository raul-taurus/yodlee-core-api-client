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
  public class TransactionDays {
    /// <summary>
    /// Gets or Sets FullAccountNumberFields
    /// </summary>
    [DataMember(Name="fullAccountNumberFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullAccountNumberFields")]
    public List<string> FullAccountNumberFields { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfTransactionDays
    /// </summary>
    [DataMember(Name="numberOfTransactionDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfTransactionDays")]
    public int? NumberOfTransactionDays { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionDays {\n");
      sb.Append("  FullAccountNumberFields: ").Append(FullAccountNumberFields).Append("\n");
      sb.Append("  NumberOfTransactionDays: ").Append(NumberOfTransactionDays).Append("\n");
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
