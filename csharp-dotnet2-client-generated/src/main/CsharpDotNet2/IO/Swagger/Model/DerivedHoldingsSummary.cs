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
  public class DerivedHoldingsSummary {
    /// <summary>
    /// Securities that belong to the asset classification type and contributed to the summary value.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Securities that belong to the asset classification type and contributed to the summary value.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="holding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holding")]
    public List<DerivedHolding> Holding { get; set; }

    /// <summary>
    /// The classification type of the security. The supported asset classification type and the values are provided in the /holdings/assetClassificationList.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The classification type of the security. The supported asset classification type and the values are provided in the /holdings/assetClassificationList.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="classificationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classificationType")]
    public string ClassificationType { get; set; }

    /// <summary>
    /// The classification value that corresponds to the classification type of the holding. The supported asset classification type and the values are provided in the /holdings/assetClassificationList.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The classification value that corresponds to the classification type of the holding. The supported asset classification type and the values are provided in the /holdings/assetClassificationList.<br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="classificationValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classificationValue")]
    public string ClassificationValue { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Money Value { get; set; }

    /// <summary>
    /// Accounts that contribute to the classification. <br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Accounts that contribute to the classification. <br><b>Required Feature Enablement</b>: Asset classification feature.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public List<DerivedHoldingsAccount> Account { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedHoldingsSummary {\n");
      sb.Append("  Holding: ").Append(Holding).Append("\n");
      sb.Append("  ClassificationType: ").Append(ClassificationType).Append("\n");
      sb.Append("  ClassificationValue: ").Append(ClassificationValue).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
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
