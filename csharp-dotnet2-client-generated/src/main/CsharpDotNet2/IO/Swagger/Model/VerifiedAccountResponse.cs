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
  public class VerifiedAccountResponse {
    /// <summary>
    /// The unique identifier for the verification request that returns contextual data
    /// </summary>
    /// <value>The unique identifier for the verification request that returns contextual data</value>
    [DataMember(Name="requestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// The date of the verification request
    /// </summary>
    /// <value>The date of the verification request</value>
    [DataMember(Name="requestDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestDate")]
    public string RequestDate { get; set; }

    /// <summary>
    /// The overall status of the verification request
    /// </summary>
    /// <value>The overall status of the verification request</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets VerifiedAccount
    /// </summary>
    [DataMember(Name="verifiedAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verifiedAccount")]
    public List<VerifiedAccounts> VerifiedAccount { get; set; }

    /// <summary>
    /// The reason for the failure of the verification request
    /// </summary>
    /// <value>The reason for the failure of the verification request</value>
    [DataMember(Name="failedReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedReason")]
    public string FailedReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerifiedAccountResponse {\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  VerifiedAccount: ").Append(VerifiedAccount).Append("\n");
      sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
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
