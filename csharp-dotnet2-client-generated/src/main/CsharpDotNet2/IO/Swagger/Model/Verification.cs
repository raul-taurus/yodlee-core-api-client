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
  public class Verification {
    /// <summary>
    /// Unique identifier for the account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
    /// </summary>
    /// <value>Unique identifier for the account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The reason the account verification failed.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
    /// </summary>
    /// <value>The reason the account verification failed.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul></value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The status of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b>
    /// </summary>
    /// <value>The status of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b></value>
    [DataMember(Name="verificationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationStatus")]
    public string VerificationStatus { get; set; }

    /// <summary>
    /// Unique identifier for the provider account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
    /// </summary>
    /// <value>Unique identifier for the provider account.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul></value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// The account verification type.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b>
    /// </summary>
    /// <value>The account verification type.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul><br><b>Applicable Values</b></value>
    [DataMember(Name="verificationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationType")]
    public string VerificationType { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public VerificationAccount Account { get; set; }

    /// <summary>
    /// The date of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
    /// </summary>
    /// <value>The date of the account verification.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul></value>
    [DataMember(Name="verificationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationDate")]
    public string VerificationDate { get; set; }

    /// <summary>
    /// Unique identifier for the verification request.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul>
    /// </summary>
    /// <value>Unique identifier for the verification request.<br><br><b>Endpoints</b>:<ul><li>POST verification</li><li>GET verification</li><li>PUT verification</li></ul></value>
    [DataMember(Name="verificationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationId")]
    public long? VerificationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Verification {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  VerificationType: ").Append(VerificationType).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  VerificationDate: ").Append(VerificationDate).Append("\n");
      sb.Append("  VerificationId: ").Append(VerificationId).Append("\n");
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
