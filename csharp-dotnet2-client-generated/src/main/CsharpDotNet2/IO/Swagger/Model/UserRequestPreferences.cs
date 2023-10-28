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
  public class UserRequestPreferences {
    /// <summary>
    /// The dateformat of the user.This attribute is just a place holder and has no impact on any other API services.
    /// </summary>
    /// <value>The dateformat of the user.This attribute is just a place holder and has no impact on any other API services.</value>
    [DataMember(Name="dateFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateFormat")]
    public string DateFormat { get; set; }

    /// <summary>
    /// The timezone of the user. This attribute is just a place holder and has no impact on any other API services.
    /// </summary>
    /// <value>The timezone of the user. This attribute is just a place holder and has no impact on any other API services.</value>
    [DataMember(Name="timeZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeZone")]
    public string TimeZone { get; set; }

    /// <summary>
    /// The currency of the user. This currency will be respected while providing the response for derived API services.<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The currency of the user. This currency will be respected while providing the response for derived API services.<br><b>Applicable Values</b><br></value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The locale of the user. This locale will be considered for localization features like providing the provider information in the supported locale or providing category names in the transaction related services.<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The locale of the user. This locale will be considered for localization features like providing the provider information in the supported locale or providing category names in the transaction related services.<br><b>Applicable Values</b><br></value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRequestPreferences {\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
      sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
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
