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
  public class DocumentDownload {
    /// <summary>
    /// Contents of the document in Base64 format.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Contents of the document in Base64 format.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="docContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docContent")]
    public string DocContent { get; set; }

    /// <summary>
    /// The document's primary key and unique identifier.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The document's primary key and unique identifier.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentDownload {\n");
      sb.Append("  DocContent: ").Append(DocContent).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
