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
  public class Document {
    /// <summary>
    /// The unique identifier for the account. The account ID to which the document is linked.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The unique identifier for the account. The account ID to which the document is linked.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="accountID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountID")]
    public long? AccountID { get; set; }

    /// <summary>
    /// Indicates the date and time the document was last updated.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the date and time the document was last updated.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// Indicates the type of the tax form.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the type of the tax form.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="formType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formType")]
    public string FormType { get; set; }

    /// <summary>
    /// Indicates the type of the document.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the type of the document.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="docType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docType")]
    public string DocType { get; set; }

    /// <summary>
    /// Indicates the name of the document.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the name of the document.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The document's primary key and unique identifier.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>The document's primary key and unique identifier.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Indicates the source of the document download.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the source of the document download.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Indicates the status of the document download.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br>
    /// </summary>
    /// <value>Indicates the status of the document download.<br><br><b>Applicable containers</b>: bank, investment, creditCard, loan, insurance<br></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Document {\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  FormType: ").Append(FormType).Append("\n");
      sb.Append("  DocType: ").Append(DocType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
