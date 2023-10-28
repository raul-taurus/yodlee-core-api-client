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
  public class DerivedNetworthHistoricalBalance {
    /// <summary>
    /// Date for which the account balance was provided.  This balance could be a carryforward, calculated or a scraped balance. AdditIonal Details: scraped: Balance shown in the provider site. This balance gets stored in Yodlee system during system/user account updates. carryForward : Balance carried forward from the scraped balance to the days for which the balance was not available in the system. Balance may not be available for all the days in the system due to MFA information required, error in the site, credential changes, etc. calculated: Balances that gets calculated for the days that are prior to the account added date.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li><li>GET derived/networth</li></ul>
    /// </summary>
    /// <value>Date for which the account balance was provided.  This balance could be a carryforward, calculated or a scraped balance. AdditIonal Details: scraped: Balance shown in the provider site. This balance gets stored in Yodlee system during system/user account updates. carryForward : Balance carried forward from the scraped balance to the days for which the balance was not available in the system. Balance may not be available for all the days in the system due to MFA information required, error in the site, credential changes, etc. calculated: Balances that gets calculated for the days that are prior to the account added date.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li><li>GET derived/networth</li></ul></value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Indicates whether the balance is an asset or liability.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul>
    /// </summary>
    /// <value>Indicates whether the balance is an asset or liability.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul></value>
    [DataMember(Name="isAsset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAsset")]
    public bool? IsAsset { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Money Balance { get; set; }

    /// <summary>
    /// Date as of when the balance is last  updated due to the auto account updates or user triggered updates. This balance will be carry forward for the days where there is no balance available in the system. <br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul>
    /// </summary>
    /// <value>Date as of when the balance is last  updated due to the auto account updates or user triggered updates. This balance will be carry forward for the days where there is no balance available in the system. <br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul></value>
    [DataMember(Name="asOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asOfDate")]
    public string AsOfDate { get; set; }

    /// <summary>
    /// The source of balance information.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The source of balance information.<br><br><b>Account Type</b>: Aggregated and Manual<br><b>Applicable containers</b>: bank, creditCard, investment, insurance, realEstate, loan<br><b>Endpoints</b>:<ul><li>GET accounts/historicalBalances</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="dataSourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataSourceType")]
    public string DataSourceType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedNetworthHistoricalBalance {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  IsAsset: ").Append(IsAsset).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
      sb.Append("  DataSourceType: ").Append(DataSourceType).Append("\n");
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
