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
  public class PaymentProfile {
    /// <summary>
    /// Gets or Sets Identifier
    /// </summary>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public PaymentIdentifier Identifier { get; set; }

    /// <summary>
    /// The address of the lender to which the monthly payments or the loan payoff amount should be paid. <br><b>Additional Details:</b>The address field applies only to the student loan account type.<br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>The address of the lender to which the monthly payments or the loan payoff amount should be paid. <br><b>Additional Details:</b>The address field applies only to the student loan account type.<br><b>Account Type</b>: Aggregated<br><b>Applicable containers</b>: loan<br><b>Endpoints</b>:<br><ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public List<AccountAddress> Address { get; set; }

    /// <summary>
    /// Gets or Sets PaymentBankTransferCode
    /// </summary>
    [DataMember(Name="paymentBankTransferCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentBankTransferCode")]
    public PaymentBankTransferCode PaymentBankTransferCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentProfile {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PaymentBankTransferCode: ").Append(PaymentBankTransferCode).Append("\n");
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
