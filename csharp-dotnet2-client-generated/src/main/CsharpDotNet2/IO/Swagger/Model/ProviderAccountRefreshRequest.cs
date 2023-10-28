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
  public class ProviderAccountRefreshRequest {
    /// <summary>
    /// The name of configuration created at the time onboarding or configuration creation.
    /// </summary>
    /// <value>The name of configuration created at the time onboarding or configuration creation.</value>
    [DataMember(Name="configName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configName")]
    public string ConfigName { get; set; }

    /// <summary>
    /// Comma separated providerAccountIds.
    /// </summary>
    /// <value>Comma separated providerAccountIds.</value>
    [DataMember(Name="providerAccountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountIds")]
    public List<long?> ProviderAccountIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProviderAccountRefreshRequest {\n");
      sb.Append("  ConfigName: ").Append(ConfigName).Append("\n");
      sb.Append("  ProviderAccountIds: ").Append(ProviderAccountIds).Append("\n");
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
