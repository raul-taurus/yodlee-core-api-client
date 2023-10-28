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
  public class UserAddress {
    /// <summary>
    /// Zip.
    /// </summary>
    /// <value>Zip.</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    /// <value>Country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Address Line 3.
    /// </summary>
    /// <value>Address Line 3.</value>
    [DataMember(Name="address3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address3")]
    public string Address3 { get; set; }

    /// <summary>
    /// Address Line 2.
    /// </summary>
    /// <value>Address Line 2.</value>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    /// <value>City.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Address Line 1.
    /// </summary>
    /// <value>Address Line 1.</value>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// State.
    /// </summary>
    /// <value>State.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAddress {\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Address3: ").Append(Address3).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
