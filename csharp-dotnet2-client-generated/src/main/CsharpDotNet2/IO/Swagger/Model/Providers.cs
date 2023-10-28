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
  public class Providers {
    /// <summary>
    /// The language in which the provider details are provided. For example, a site supports two languages English and French. English being the primary language, the provider response will be provided in French depending on the user's locale. The language follows the two letter ISO code.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The language in which the provider details are provided. For example, a site supports two languages English and French. English being the primary language, the provider response will be provided in French depending on the user's locale. The language follows the two letter ISO code.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="languageISOCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "languageISOCode")]
    public string LanguageISOCode { get; set; }

    /// <summary>
    /// The forget password URL of the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul>
    /// </summary>
    /// <value>The forget password URL of the provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul></value>
    [DataMember(Name="forgetPasswordUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forgetPasswordUrl")]
    public string ForgetPasswordUrl { get; set; }

    /// <summary>
    /// Favicon link of the provider.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Favicon link of the provider.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="favicon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "favicon")]
    public string Favicon { get; set; }

    /// <summary>
    /// AccountType supported by the provider, eg: Brokerage Cash, Current<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>AccountType supported by the provider, eg: Brokerage Cash, Current<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public List<string> AccountType { get; set; }

    /// <summary>
    /// Country to which the provider belongs.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Country to which the provider belongs.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="countryISOCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryISOCode")]
    public string CountryISOCode { get; set; }

    /// <summary>
    /// Indicates that the site has been added by the user at least once.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Indicates that the site has been added by the user at least once.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="isAddedByUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAddedByUser")]
    public string IsAddedByUser { get; set; }

    /// <summary>
    /// Indicates the priority for which the service is invoked.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates the priority for which the service is invoked.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="PRIORITY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PRIORITY")]
    public string PRIORITY { get; set; }

    /// <summary>
    /// The screen-scraping providers that are associated to the Open Banking provider ID.<br><br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul>
    /// </summary>
    /// <value>The screen-scraping providers that are associated to the Open Banking provider ID.<br><br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET providers</li><li>GET providers/{providerId}</li></ul></value>
    [DataMember(Name="associatedProviderIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associatedProviderIds")]
    public List<long?> AssociatedProviderIds { get; set; }

    /// <summary>
    /// Help text to guide the user to choose the correct provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul>
    /// </summary>
    /// <value>Help text to guide the user to choose the correct provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers</li></ul></value>
    [DataMember(Name="loginHelp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginHelp")]
    public string LoginHelp { get; set; }

    /// <summary>
    /// The primary language of the site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The primary language of the site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="primaryLanguageISOCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryLanguageISOCode")]
    public string PrimaryLanguageISOCode { get; set; }

    /// <summary>
    /// Text to guide user through linking an account that belongs to the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Text to guide user through linking an account that belongs to the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="help", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "help")]
    public string Help { get; set; }

    /// <summary>
    /// The base URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The base URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="baseUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// Capability of the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><br><b>Note : </b> capability has been deprecated
    /// </summary>
    /// <value>Capability of the site<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><br><b>Note : </b> capability has been deprecated</value>
    [DataMember(Name="capability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capability")]
    public List<Capability> Capability { get; set; }

    /// <summary>
    /// Indicates if a provider site requires consent.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Indicates if a provider site requires consent.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="isConsentRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isConsentRequired")]
    public bool? IsConsentRequired { get; set; }

    /// <summary>
    /// The login URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The login URL of the provider's site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="loginUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginUrl")]
    public string LoginUrl { get; set; }

    /// <summary>
    /// Indicates if a provider site is auto-refreshed.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Indicates if a provider site is auto-refreshed.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="isAutoRefreshEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAutoRefreshEnabled")]
    public bool? IsAutoRefreshEnabled { get; set; }

    /// <summary>
    /// The name of a provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The name of a provider site.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The logo link of the provider institution. The link will return the logo in the PNG format.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>The logo link of the provider institution. The link will return the logo in the PNG format.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Unique identifier for the provider site(e.g., financial institution sites, biller sites, lender sites, etc.).<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Unique identifier for the provider site(e.g., financial institution sites, biller sites, lender sites, etc.).<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Determines when the provider information was updated by Yodlee. If the customer caches the data, the cache is recommended to be refreshed based on this field.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Determines when the provider information was updated by Yodlee. If the customer caches the data, the cache is recommended to be refreshed based on this field.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public string LastModified { get; set; }

    /// <summary>
    /// AuthParameter appears in the response only in case of token-based aggregation sites.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>AuthParameter appears in the response only in case of token-based aggregation sites.<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="authParameter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authParameter")]
    public List<string> AuthParameter { get; set; }

    /// <summary>
    /// The authentication type enabled at the provider site. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The authentication type enabled at the provider site. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul><b>Applicable Values</b><br></value>
    [DataMember(Name="authType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authType")]
    public string AuthType { get; set; }

    /// <summary>
    /// Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Logical grouping of dataset attributes into datasets such as Basic Aggregation Data, Account Profile and Documents<br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="dataset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataset")]
    public List<ProvidersDataset> Dataset { get; set; }

    /// <summary>
    /// Determines if the provider is supported for the cobrand (customer), is in the beta stage, etc. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul>
    /// </summary>
    /// <value>Determines if the provider is supported for the cobrand (customer), is in the beta stage, etc. <br><br><b>Endpoints</b>:<ul><li>GET providers/{providerId}</li><li>GET providers</li></ul></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Providers {\n");
      sb.Append("  LanguageISOCode: ").Append(LanguageISOCode).Append("\n");
      sb.Append("  ForgetPasswordUrl: ").Append(ForgetPasswordUrl).Append("\n");
      sb.Append("  Favicon: ").Append(Favicon).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  CountryISOCode: ").Append(CountryISOCode).Append("\n");
      sb.Append("  IsAddedByUser: ").Append(IsAddedByUser).Append("\n");
      sb.Append("  PRIORITY: ").Append(PRIORITY).Append("\n");
      sb.Append("  AssociatedProviderIds: ").Append(AssociatedProviderIds).Append("\n");
      sb.Append("  LoginHelp: ").Append(LoginHelp).Append("\n");
      sb.Append("  PrimaryLanguageISOCode: ").Append(PrimaryLanguageISOCode).Append("\n");
      sb.Append("  Help: ").Append(Help).Append("\n");
      sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
      sb.Append("  Capability: ").Append(Capability).Append("\n");
      sb.Append("  IsConsentRequired: ").Append(IsConsentRequired).Append("\n");
      sb.Append("  LoginUrl: ").Append(LoginUrl).Append("\n");
      sb.Append("  IsAutoRefreshEnabled: ").Append(IsAutoRefreshEnabled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  AuthParameter: ").Append(AuthParameter).Append("\n");
      sb.Append("  AuthType: ").Append(AuthType).Append("\n");
      sb.Append("  Dataset: ").Append(Dataset).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
