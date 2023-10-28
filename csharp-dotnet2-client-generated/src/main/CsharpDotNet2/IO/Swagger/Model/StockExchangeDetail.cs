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
  public class StockExchangeDetail {
    /// <summary>
    /// Ticker symbol representing particular securities listed on an exchange.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Ticker symbol representing particular securities listed on an exchange.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Country codes are geocodes developed to represent countries and dependent areas.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Country codes are geocodes developed to represent countries and dependent areas.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// ISO codes of currency.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>ISO codes of currency.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// An Exchange code is a four-character code used to identify stock markets and other trading exchanges within global trading.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>An Exchange code is a four-character code used to identify stock markets and other trading exchanges within global trading.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="exchangeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeCode")]
    public string ExchangeCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StockExchangeDetail {\n");
      sb.Append("  Symbol: ").Append(Symbol).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  ExchangeCode: ").Append(ExchangeCode).Append("\n");
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
