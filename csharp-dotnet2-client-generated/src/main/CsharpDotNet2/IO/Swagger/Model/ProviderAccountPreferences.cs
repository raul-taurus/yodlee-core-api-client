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
  public class ProviderAccountPreferences {
    /// <summary>
    /// Indicates if the updates to the provider account should be part of the data extracts event notification or the data extract data retrieval service.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=preferences</li><li>GET providerAccounts/{providerAccountId}?include=preferences</li></ul>
    /// </summary>
    /// <value>Indicates if the updates to the provider account should be part of the data extracts event notification or the data extract data retrieval service.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=preferences</li><li>GET providerAccounts/{providerAccountId}?include=preferences</li></ul></value>
    [DataMember(Name="isDataExtractsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDataExtractsEnabled")]
    public bool? IsDataExtractsEnabled { get; set; }

    /// <summary>
    /// LinkedproviderAccountd is a providerAccountId linked by the user to the primary provider account. <br>LinkedProviderAccountId and the providerAccountId belongs to the same institution.<br><br><b>Endpoints</b>:<ul><li>POST Provider Account</li><li>PUT Provider Account</li><li>GET Provider Accounts</li></ul>
    /// </summary>
    /// <value>LinkedproviderAccountd is a providerAccountId linked by the user to the primary provider account. <br>LinkedProviderAccountId and the providerAccountId belongs to the same institution.<br><br><b>Endpoints</b>:<ul><li>POST Provider Account</li><li>PUT Provider Account</li><li>GET Provider Accounts</li></ul></value>
    [DataMember(Name="linkedProviderAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedProviderAccountId")]
    public long? LinkedProviderAccountId { get; set; }

    /// <summary>
    /// Indicates if auto-refreshes have to be triggered for the provider account.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=preferences</li><li>GET providerAccounts/{providerAccountId}?include=preferences</li></ul>
    /// </summary>
    /// <value>Indicates if auto-refreshes have to be triggered for the provider account.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=preferences</li><li>GET providerAccounts/{providerAccountId}?include=preferences</li></ul></value>
    [DataMember(Name="isAutoRefreshEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAutoRefreshEnabled")]
    public bool? IsAutoRefreshEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProviderAccountPreferences {\n");
      sb.Append("  IsDataExtractsEnabled: ").Append(IsDataExtractsEnabled).Append("\n");
      sb.Append("  LinkedProviderAccountId: ").Append(LinkedProviderAccountId).Append("\n");
      sb.Append("  IsAutoRefreshEnabled: ").Append(IsAutoRefreshEnabled).Append("\n");
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
