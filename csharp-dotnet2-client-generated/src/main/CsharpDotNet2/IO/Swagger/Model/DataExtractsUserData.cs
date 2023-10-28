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
  public class DataExtractsUserData {
    /// <summary>
    /// Gets or Sets Holding
    /// </summary>
    [DataMember(Name="holding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holding")]
    public List<DataExtractsHolding> Holding { get; set; }

    /// <summary>
    /// Gets or Sets TotalTransactionsCount
    /// </summary>
    [DataMember(Name="totalTransactionsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalTransactionsCount")]
    public long? TotalTransactionsCount { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public DataExtractsUser User { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public List<DataExtractsAccount> Account { get; set; }

    /// <summary>
    /// Gets or Sets Transaction
    /// </summary>
    [DataMember(Name="transaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction")]
    public List<DataExtractsTransaction> Transaction { get; set; }

    /// <summary>
    /// Gets or Sets ProviderAccount
    /// </summary>
    [DataMember(Name="providerAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccount")]
    public List<DataExtractsProviderAccount> ProviderAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataExtractsUserData {\n");
      sb.Append("  Holding: ").Append(Holding).Append("\n");
      sb.Append("  TotalTransactionsCount: ").Append(TotalTransactionsCount).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Transaction: ").Append(Transaction).Append("\n");
      sb.Append("  ProviderAccount: ").Append(ProviderAccount).Append("\n");
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
