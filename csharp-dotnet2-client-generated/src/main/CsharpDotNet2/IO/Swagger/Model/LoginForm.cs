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
  public class LoginForm {
    /// <summary>
    /// The title for the MFA information demanded from the user.This is the title displayed in the provider site.This field is applicable for MFA form types only. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>The title for the MFA information demanded from the user.This is the title displayed in the provider site.This field is applicable for MFA form types only. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="mfaInfoTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mfaInfoTitle")]
    public string MfaInfoTitle { get; set; }

    /// <summary>
    /// The help that can be displayed to the customer in the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The help that can be displayed to the customer in the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="help", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "help")]
    public string Help { get; set; }

    /// <summary>
    /// The forget password URL of the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The forget password URL of the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="forgetPasswordURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forgetPasswordURL")]
    public string ForgetPasswordURL { get; set; }

    /// <summary>
    /// The type of the forms for which the user information is required.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of the forms for which the user information is required.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="formType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formType")]
    public string FormType { get; set; }

    /// <summary>
    /// The text displayed in the provider site while requesting the user's MFA information. This field is applicable for MFA form types only. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul>
    /// </summary>
    /// <value>The text displayed in the provider site while requesting the user's MFA information. This field is applicable for MFA form types only. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li></ul></value>
    [DataMember(Name="mfaInfoText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mfaInfoText")]
    public string MfaInfoText { get; set; }

    /// <summary>
    /// The help that can be displayed to the customer in the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The help that can be displayed to the customer in the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="loginHelp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginHelp")]
    public string LoginHelp { get; set; }

    /// <summary>
    /// The amount of time before which the user is expected to provide MFA information. This field is applicable for MFA form types only. This would be an useful information that could be displayed to the users. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The amount of time before which the user is expected to provide MFA information. This field is applicable for MFA form types only. This would be an useful information that could be displayed to the users. <br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="mfaTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mfaTimeout")]
    public long? MfaTimeout { get; set; }

    /// <summary>
    /// The identifier of the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The identifier of the login form.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// This indicates one row in the form. The row will have one label. But it may have single or multiple fields.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>This indicates one row in the form. The row will have one label. But it may have single or multiple fields.<br><br><b>Endpoints</b>:<ul><li>GET providerAccounts/{providerAccountId}</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="row", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "row")]
    public List<Row> Row { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginForm {\n");
      sb.Append("  MfaInfoTitle: ").Append(MfaInfoTitle).Append("\n");
      sb.Append("  Help: ").Append(Help).Append("\n");
      sb.Append("  ForgetPasswordURL: ").Append(ForgetPasswordURL).Append("\n");
      sb.Append("  FormType: ").Append(FormType).Append("\n");
      sb.Append("  MfaInfoText: ").Append(MfaInfoText).Append("\n");
      sb.Append("  LoginHelp: ").Append(LoginHelp).Append("\n");
      sb.Append("  MfaTimeout: ").Append(MfaTimeout).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Row: ").Append(Row).Append("\n");
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
