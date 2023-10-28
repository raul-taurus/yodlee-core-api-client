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
  public class Row {
    /// <summary>
    /// Fields that belong to a particular choice are collected together using this field.<br><b>Recommendations</b>: All the field row choices label to be grouped and displayed as options to the customer. On choosing a particular choice field, we recommend displaying the fields relevant to them. First field choice could be selected by default.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Fields that belong to a particular choice are collected together using this field.<br><b>Recommendations</b>: All the field row choices label to be grouped and displayed as options to the customer. On choosing a particular choice field, we recommend displaying the fields relevant to them. First field choice could be selected by default.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="fieldRowChoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldRowChoice")]
    public string FieldRowChoice { get; set; }

    /// <summary>
    /// Details of fields that belong to the row.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Details of fields that belong to the row.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public List<Field> Field { get; set; }

    /// <summary>
    /// Form denotes the set of the fields that are related. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Form denotes the set of the fields that are related. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="form", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "form")]
    public string Form { get; set; }

    /// <summary>
    /// Unique identifier of the row.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Unique identifier of the row.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The label text displayed for a row in the form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The label text displayed for a row in the form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Row {\n");
      sb.Append("  FieldRowChoice: ").Append(FieldRowChoice).Append("\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  Form: ").Append(Form).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
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
