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
  public class Option {
    /// <summary>
    /// The text that is displayed to the user for that option in the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The text that is displayed to the user for that option in the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="displayText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayText")]
    public string DisplayText { get; set; }

    /// <summary>
    /// The value that is associated with the option.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The value that is associated with the option.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="optionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optionValue")]
    public string OptionValue { get; set; }

    /// <summary>
    /// The option that is selected by default in the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The option that is selected by default in the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="isSelected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSelected")]
    public bool? IsSelected { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Option {\n");
      sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
      sb.Append("  OptionValue: ").Append(OptionValue).Append("\n");
      sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
