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
  public class Merchant {
    /// <summary>
    /// The website of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>The website of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public AccountAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// The business categories of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The business categories of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard<br><b>Applicable Values</b><br></value>
    [DataMember(Name="categoryLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryLabel")]
    public List<string> CategoryLabel { get; set; }

    /// <summary>
    /// Gets or Sets Coordinates
    /// </summary>
    [DataMember(Name="coordinates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coordinates")]
    public Coordinates Coordinates { get; set; }

    /// <summary>
    /// The name of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The name of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Identifier of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>Identifier of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The source through which merchant information is retrieved.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The source through which merchant information is retrieved.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// The logoURL of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>The logoURL of the merchant.<br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="logoURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logoURL")]
    public string LogoURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Merchant {\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  CategoryLabel: ").Append(CategoryLabel).Append("\n");
      sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
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
