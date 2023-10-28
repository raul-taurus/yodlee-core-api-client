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
  public class Attribute {
    /// <summary>
    /// Containers for which the attributes are supported.<br><br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Containers for which the attributes are supported.<br><br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="container", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container")]
    public List<string> Container { get; set; }

    /// <summary>
    /// Applicable only to EBILLS and STATEMENTS attributes of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul>
    /// </summary>
    /// <value>Applicable only to EBILLS and STATEMENTS attributes of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul></value>
    [DataMember(Name="fromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromDate")]
    public string FromDate { get; set; }

    /// <summary>
    /// Applicable only to TAX attribute of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul>
    /// </summary>
    /// <value>Applicable only to TAX attribute of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul></value>
    [DataMember(Name="toFinYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toFinYear")]
    public string ToFinYear { get; set; }

    /// <summary>
    /// Applicable only to TAX attribute of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul>
    /// </summary>
    /// <value>Applicable only to TAX attribute of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul></value>
    [DataMember(Name="fromFinYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromFinYear")]
    public string FromFinYear { get; set; }

    /// <summary>
    /// Gets or Sets ContainerAttributes
    /// </summary>
    [DataMember(Name="containerAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerAttributes")]
    public ContainerAttributes ContainerAttributes { get; set; }

    /// <summary>
    /// Applicable only to EBILLS and STATEMENTS attributes of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul>
    /// </summary>
    /// <value>Applicable only to EBILLS and STATEMENTS attributes of DOCUMENT dataset.<br><br><b>Endpoints</b>:<ul><li>POST providerAccounts</li><li>PUT providerAccounts</li></ul></value>
    [DataMember(Name="toDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toDate")]
    public string ToDate { get; set; }

    /// <summary>
    /// Attributes that are supported for a dataset.<br><br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Attributes that are supported for a dataset.<br><br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Attribute {\n");
      sb.Append("  Container: ").Append(Container).Append("\n");
      sb.Append("  FromDate: ").Append(FromDate).Append("\n");
      sb.Append("  ToFinYear: ").Append(ToFinYear).Append("\n");
      sb.Append("  FromFinYear: ").Append(FromFinYear).Append("\n");
      sb.Append("  ContainerAttributes: ").Append(ContainerAttributes).Append("\n");
      sb.Append("  ToDate: ").Append(ToDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
