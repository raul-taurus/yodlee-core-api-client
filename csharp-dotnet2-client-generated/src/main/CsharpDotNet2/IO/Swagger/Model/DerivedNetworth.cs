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
  public class DerivedNetworth {
    /// <summary>
    /// The date as of when the networth information is provided.<br><br><b>Applicable containers</b>: bank, creditcard, investment, insurance, realEstate, loan<br>
    /// </summary>
    /// <value>The date as of when the networth information is provided.<br><br><b>Applicable containers</b>: bank, creditcard, investment, insurance, realEstate, loan<br></value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets Liability
    /// </summary>
    [DataMember(Name="liability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liability")]
    public Money Liability { get; set; }

    /// <summary>
    /// Balances of the accounts over the period of time.<br><br><b>Applicable containers</b>: bank, creditcard, investment, insurance, realEstate, loan<br>
    /// </summary>
    /// <value>Balances of the accounts over the period of time.<br><br><b>Applicable containers</b>: bank, creditcard, investment, insurance, realEstate, loan<br></value>
    [DataMember(Name="historicalBalances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "historicalBalances")]
    public List<DerivedNetworthHistoricalBalance> HistoricalBalances { get; set; }

    /// <summary>
    /// Gets or Sets Networth
    /// </summary>
    [DataMember(Name="networth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networth")]
    public Money Networth { get; set; }

    /// <summary>
    /// Gets or Sets Asset
    /// </summary>
    [DataMember(Name="asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asset")]
    public Money Asset { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedNetworth {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Liability: ").Append(Liability).Append("\n");
      sb.Append("  HistoricalBalances: ").Append(HistoricalBalances).Append("\n");
      sb.Append("  Networth: ").Append(Networth).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
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
