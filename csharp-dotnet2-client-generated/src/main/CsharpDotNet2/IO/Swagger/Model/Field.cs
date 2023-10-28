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
  public class Field {
    /// <summary>
    /// Image displayed at the endsite.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>Image displayed at the endsite.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// The prefix string that has to be displayed before the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The prefix string that has to be displayed before the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// The minimum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The minimum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="minLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minLength")]
    public long? MinLength { get; set; }

    /// <summary>
    /// Indicates whether the field is editable or not.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Indicates whether the field is editable or not.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="valueEditable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueEditable")]
    public string ValueEditable { get; set; }

    /// <summary>
    /// Indicates if a field is an optional field or a mandatory field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Indicates if a field is an optional field or a mandatory field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="isOptional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isOptional")]
    public bool? IsOptional { get; set; }

    /// <summary>
    /// The suffix string that has to be displayed next to the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The suffix string that has to be displayed next to the field value.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="suffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suffix")]
    public string Suffix { get; set; }

    /// <summary>
    /// This indicates the display type of the field. For example, text box, image, etc. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>This indicates the display type of the field. For example, text box, image, etc. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Indicates that the answer to the security question already exists in the Yodlee system.Persuading the user to provide the answer to the security question again during the edit-credential flow can be avoided.<br><br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=questions</li><li>GET providerAccounts/{providerAccountId}? include=questions</li></ul>
    /// </summary>
    /// <value>Indicates that the answer to the security question already exists in the Yodlee system.Persuading the user to provide the answer to the security question again during the edit-credential flow can be avoided.<br><br><br><b>Endpoints</b>:<ul><li>GET providerAccounts?include=questions</li><li>GET providerAccounts/{providerAccountId}? include=questions</li></ul></value>
    [DataMember(Name="isValueProvided", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isValueProvided")]
    public bool? IsValueProvided { get; set; }

    /// <summary>
    /// Name of the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Name of the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Identifier for the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Identifier for the field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Value expected from the user for the field. This will be blank and is expected to be filled and sent back when submitting the login or MFA information.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Value expected from the user for the field. This will be blank and is expected to be filled and sent back when submitting the login or MFA information.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The maximum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The maximum length of the login form field.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public long? MaxLength { get; set; }

    /// <summary>
    /// Provides the different values that are available for the user to choose. This field is applicable for drop-down or radio field types.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>Provides the different values that are available for the user to choose. This field is applicable for drop-down or radio field types.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option")]
    public List<Option> Option { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Field {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Prefix: ").Append(Prefix).Append("\n");
      sb.Append("  MinLength: ").Append(MinLength).Append("\n");
      sb.Append("  ValueEditable: ").Append(ValueEditable).Append("\n");
      sb.Append("  IsOptional: ").Append(IsOptional).Append("\n");
      sb.Append("  Suffix: ").Append(Suffix).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  IsValueProvided: ").Append(IsValueProvided).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("  Option: ").Append(Option).Append("\n");
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
