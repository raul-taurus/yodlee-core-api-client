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
  public class RewardBalance {
    /// <summary>
    /// The date on which the balance expires.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The date on which the balance expires.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="expiryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryDate")]
    public string ExpiryDate { get; set; }

    /// <summary>
    /// The balance required to qualify for a reward such as retaining membership, business reward, etc.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The balance required to qualify for a reward such as retaining membership, business reward, etc.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="balanceToReward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balanceToReward")]
    public string BalanceToReward { get; set; }

    /// <summary>
    /// The type of reward balance.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of reward balance.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="balanceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balanceType")]
    public string BalanceType { get; set; }

    /// <summary>
    /// The actual reward balance.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The actual reward balance.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// The description for the reward balance as available at provider source.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The description for the reward balance as available at provider source.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The balance required to reach a reward level.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The balance required to reach a reward level.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="balanceToLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balanceToLevel")]
    public string BalanceToLevel { get; set; }

    /// <summary>
    /// Unit of reward balance - miles, points, segments, dollars, credits.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Unit of reward balance - miles, points, segments, dollars, credits.<br><br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: reward<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RewardBalance {\n");
      sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
      sb.Append("  BalanceToReward: ").Append(BalanceToReward).Append("\n");
      sb.Append("  BalanceType: ").Append(BalanceType).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  BalanceToLevel: ").Append(BalanceToLevel).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
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
