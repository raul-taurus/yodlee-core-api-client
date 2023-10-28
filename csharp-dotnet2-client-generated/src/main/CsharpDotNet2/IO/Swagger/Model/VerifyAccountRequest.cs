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
  public class VerifyAccountRequest {
    /// <summary>
    /// Gets or Sets Container
    /// </summary>
    [DataMember(Name="container", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container")]
    public string Container { get; set; }

    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets TransactionCriteria
    /// </summary>
    [DataMember(Name="transactionCriteria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionCriteria")]
    public List<VerifyTransactionCriteria> TransactionCriteria { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerifyAccountRequest {\n");
      sb.Append("  Container: ").Append(Container).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  TransactionCriteria: ").Append(TransactionCriteria).Append("\n");
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
