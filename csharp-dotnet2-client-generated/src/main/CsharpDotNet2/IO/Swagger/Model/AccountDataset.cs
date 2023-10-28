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
  public class AccountDataset {
    /// <summary>
    /// Indicate when the dataset is last updated successfully for the given provider account.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Indicate when the dataset is last updated successfully for the given provider account.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// Indicate whether the dataset is eligible for update or not.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicate whether the dataset is eligible for update or not.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="updateEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateEligibility")]
    public string UpdateEligibility { get; set; }

    /// <summary>
    /// The status of last update attempted for the dataset. <br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The status of last update attempted for the dataset. <br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="additionalStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalStatus")]
    public string AdditionalStatus { get; set; }

    /// <summary>
    /// Indicates when the next attempt to update the dataset is scheduled.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Indicates when the next attempt to update the dataset is scheduled.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="nextUpdateScheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextUpdateScheduled")]
    public string NextUpdateScheduled { get; set; }

    /// <summary>
    /// The name of the dataset requested from the provider site<br><br><b>Account Type</b>: Manual<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The name of the dataset requested from the provider site<br><br><b>Account Type</b>: Manual<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Indicate when the last attempt was performed to update the dataset for the given provider account<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Indicate when the last attempt was performed to update the dataset for the given provider account<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="lastUpdateAttempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdateAttempt")]
    public string LastUpdateAttempt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountDataset {\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  UpdateEligibility: ").Append(UpdateEligibility).Append("\n");
      sb.Append("  AdditionalStatus: ").Append(AdditionalStatus).Append("\n");
      sb.Append("  NextUpdateScheduled: ").Append(NextUpdateScheduled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LastUpdateAttempt: ").Append(LastUpdateAttempt).Append("\n");
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
