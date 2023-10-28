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
  public class DataExtractsProviderAccount {
    /// <summary>
    /// The providerAccountId that is retained as part of the many-to-one OAuth migration process.<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The providerAccountId that is retained as part of the many-to-one OAuth migration process.<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="destinationProviderAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationProviderAccountId")]
    public long? DestinationProviderAccountId { get; set; }

    /// <summary>
    /// Indicates the migration status of the provider account from screen-scraping provider to the Open Banking provider. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>GET providerAccounts/{providerAccountId}</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicates the migration status of the provider account from screen-scraping provider to the Open Banking provider. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>GET providerAccounts/{providerAccountId}</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="oauthMigrationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oauthMigrationStatus")]
    public string OauthMigrationStatus { get; set; }

    /// <summary>
    /// Indicates whether account is a manual or aggregated provider account.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicates whether account is a manual or aggregated provider account.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="isManual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isManual")]
    public bool? IsManual { get; set; }

    /// <summary>
    /// Attribute to specify whether the user has to input(credentials/MFA) for refreshing an account.<br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>GET GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Attribute to specify whether the user has to input(credentials/MFA) for refreshing an account.<br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>GET GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="isRealTimeMFA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRealTimeMFA")]
    public bool? IsRealTimeMFA { get; set; }

    /// <summary>
    /// Indicate when the providerAccount is last updated successfully.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicate when the providerAccount is last updated successfully.<br><br><b>Account Type</b>: Aggregated<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// Consent Id generated through POST Consent.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Consent Id generated through POST Consent.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="consentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consentId")]
    public long? ConsentId { get; set; }

    /// <summary>
    /// The date on when the provider account is created in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>The date on when the provider account is created in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// The source through which the providerAccount is added in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The source through which the providerAccount is added in the system.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="aggregationSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregationSource")]
    public string AggregationSource { get; set; }

    /// <summary>
    /// Indicates if the provider account is deleted from the system.<b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Indicates if the provider account is deleted from the system.<b>Applicable containers</b>: All Containers<br><b>Aggregated / Manual</b>: Both <br><b>Endpoints</b>:<br><ul><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="isDeleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDeleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Unique identifier for the provider resource. This denotes the provider for which the provider account id is generated by the user.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Unique identifier for the provider resource. This denotes the provider for which the provider account id is generated by the user.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public long? ProviderId { get; set; }

    /// <summary>
    /// Unique id generated to indicate the request.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Unique id generated to indicate the request.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="requestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// The providerAccountIds that are deleted and merged into the destinationProviderAccountId as part of the many-to-one OAuth migration process.<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The providerAccountIds that are deleted and merged into the destinationProviderAccountId as part of the many-to-one OAuth migration process.<br><b>Endpoints</b>:<ul><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="sourceProviderAccountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceProviderAccountIds")]
    public List<long?> SourceProviderAccountIds { get; set; }

    /// <summary>
    /// Unique identifier for the provider account resource. This is created during account addition.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Unique identifier for the provider account resource. This is created during account addition.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="dataset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataset")]
    public List<AccountDataset> Dataset { get; set; }

    /// <summary>
    /// The status of last update attempted for the account. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The status of last update attempted for the account. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts</li><li>POST providerAccounts</li><li>PUT providerAccounts/{providerAccountId}</li><li>GET providerAccounts/{providerAccountId}</li><li>GET dataExtracts/userData</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataExtractsProviderAccount {\n");
      sb.Append("  DestinationProviderAccountId: ").Append(DestinationProviderAccountId).Append("\n");
      sb.Append("  OauthMigrationStatus: ").Append(OauthMigrationStatus).Append("\n");
      sb.Append("  IsManual: ").Append(IsManual).Append("\n");
      sb.Append("  IsRealTimeMFA: ").Append(IsRealTimeMFA).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  AggregationSource: ").Append(AggregationSource).Append("\n");
      sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  SourceProviderAccountIds: ").Append(SourceProviderAccountIds).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Dataset: ").Append(Dataset).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
