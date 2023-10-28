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
  public class DerivedTransactionSummaryResponse {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public DerivedTransactionsLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets TransactionSummary
    /// </summary>
    [DataMember(Name="transactionSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionSummary")]
    public List<DerivedTransactionsSummary> TransactionSummary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedTransactionSummaryResponse {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  TransactionSummary: ").Append(TransactionSummary).Append("\n");
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
