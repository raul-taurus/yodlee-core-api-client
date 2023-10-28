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
  public class YodleeError {
    /// <summary>
    /// The descriptive message that explains the error scenario.
    /// </summary>
    /// <value>The descriptive message that explains the error scenario.</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// The error code follows the format YNNN. The error codes do not change. New error codes may be added as we introduce new features and enhance functionalities.
    /// </summary>
    /// <value>The error code follows the format YNNN. The error codes do not change. New error codes may be added as we introduce new features and enhance functionalities.</value>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// Unique Yodlee identifier used to troubleshoot issues at Yodleeâ€™s end.
    /// </summary>
    /// <value>Unique Yodlee identifier used to troubleshoot issues at Yodleeâ€™s end.</value>
    [DataMember(Name="referenceCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceCode")]
    public string ReferenceCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class YodleeError {\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ReferenceCode: ").Append(ReferenceCode).Append("\n");
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
