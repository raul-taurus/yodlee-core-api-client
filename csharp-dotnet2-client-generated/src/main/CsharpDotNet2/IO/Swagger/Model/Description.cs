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
  public class Description {
    /// <summary>
    /// The description will provide the actual name of the security.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The description will provide the actual name of the security.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="security", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security")]
    public string Security { get; set; }

    /// <summary>
    /// Original transaction description as it appears at the FI site.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br>
    /// </summary>
    /// <value>Original transaction description as it appears at the FI site.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br></value>
    [DataMember(Name="original", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original")]
    public string Original { get; set; }

    /// <summary>
    /// The transaction description that appears at the FI site may not be self-explanatory, i.e., the source, purpose of the transaction may not be evident. Yodlee attempts to simplify and make the transaction meaningful to the consumer, and this simplified transaction description is provided in the simple description field.Note: The simple description field is available only in the United States, Canada, United Kingdom, and India.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br>
    /// </summary>
    /// <value>The transaction description that appears at the FI site may not be self-explanatory, i.e., the source, purpose of the transaction may not be evident. Yodlee attempts to simplify and make the transaction meaningful to the consumer, and this simplified transaction description is provided in the simple description field.Note: The simple description field is available only in the United States, Canada, United Kingdom, and India.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br></value>
    [DataMember(Name="simple", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "simple")]
    public string Simple { get; set; }

    /// <summary>
    /// The description of the transaction as defined by the consumer. The consumer can define or provide more details of the transaction in this field.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br>
    /// </summary>
    /// <value>The description of the transaction as defined by the consumer. The consumer can define or provide more details of the transaction in this field.<br><br><b>Applicable containers</b>: creditCard, insurance, loan<br></value>
    [DataMember(Name="consumer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consumer")]
    public string Consumer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Description {\n");
      sb.Append("  Security: ").Append(Security).Append("\n");
      sb.Append("  Original: ").Append(Original).Append("\n");
      sb.Append("  Simple: ").Append(Simple).Append("\n");
      sb.Append("  Consumer: ").Append(Consumer).Append("\n");
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
