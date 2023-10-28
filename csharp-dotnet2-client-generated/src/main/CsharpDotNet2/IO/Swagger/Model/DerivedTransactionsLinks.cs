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
  public class DerivedTransactionsLinks {
    /// <summary>
    /// Link of the transaction API service that corresponds to the value derivation.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>Link of the transaction API service that corresponds to the value derivation.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public string Transactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedTransactionsLinks {\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
