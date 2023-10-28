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
  public class Money {
    /// <summary>
    /// Value of amount.
    /// </summary>
    /// <value>Value of amount.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// Value of the converted amount.
    /// </summary>
    /// <value>Value of the converted amount.</value>
    [DataMember(Name="convertedAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "convertedAmount")]
    public double? ConvertedAmount { get; set; }

    /// <summary>
    /// Currency should be a valid three-letter ISO Code.
    /// </summary>
    /// <value>Currency should be a valid three-letter ISO Code.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Currency should be a valid three-letter ISO Code.
    /// </summary>
    /// <value>Currency should be a valid three-letter ISO Code.</value>
    [DataMember(Name="convertedCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "convertedCurrency")]
    public string ConvertedCurrency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Money {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ConvertedAmount: ").Append(ConvertedAmount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  ConvertedCurrency: ").Append(ConvertedCurrency).Append("\n");
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
