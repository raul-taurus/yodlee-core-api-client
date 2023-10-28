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
  public class FullAccountNumberList {
    /// <summary>
    /// Payment Account Number of given account.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Payment Account Number of given account.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="paymentAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentAccountNumber")]
    public string PaymentAccountNumber { get; set; }

    /// <summary>
    /// Unmasked account number of given account.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul>
    /// </summary>
    /// <value>Unmasked account number of given account.<br><br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li></ul></value>
    [DataMember(Name="unmaskedAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unmaskedAccountNumber")]
    public string UnmaskedAccountNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FullAccountNumberList {\n");
      sb.Append("  PaymentAccountNumber: ").Append(PaymentAccountNumber).Append("\n");
      sb.Append("  UnmaskedAccountNumber: ").Append(UnmaskedAccountNumber).Append("\n");
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
