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
  public class Contact {
    /// <summary>
    /// Phone number of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>Phone number of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Email Id of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>Email Id of the merchant<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Contact {\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
