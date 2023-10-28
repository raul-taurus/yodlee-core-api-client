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
  public class DataExtractsEventData {
    /// <summary>
    /// Gets or Sets FromDate
    /// </summary>
    [DataMember(Name="fromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromDate")]
    public string FromDate { get; set; }

    /// <summary>
    /// Gets or Sets UserData
    /// </summary>
    [DataMember(Name="userData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userData")]
    public List<DataExtractsEventUserData> UserData { get; set; }

    /// <summary>
    /// Gets or Sets UserCount
    /// </summary>
    [DataMember(Name="userCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userCount")]
    public int? UserCount { get; set; }

    /// <summary>
    /// Gets or Sets ToDate
    /// </summary>
    [DataMember(Name="toDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toDate")]
    public string ToDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataExtractsEventData {\n");
      sb.Append("  FromDate: ").Append(FromDate).Append("\n");
      sb.Append("  UserData: ").Append(UserData).Append("\n");
      sb.Append("  UserCount: ").Append(UserCount).Append("\n");
      sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
