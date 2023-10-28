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
  public class DerivedCategorySummary {
    /// <summary>
    /// Gets or Sets CreditTotal
    /// </summary>
    [DataMember(Name="creditTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditTotal")]
    public Money CreditTotal { get; set; }

    /// <summary>
    /// Credit and debit summary per date.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>Credit and debit summary per date.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public List<DerivedCategorySummaryDetails> Details { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public DerivedTransactionsLinks Links { get; set; }

    /// <summary>
    /// The name of the category.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>The name of the category.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="categoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryName")]
    public string CategoryName { get; set; }

    /// <summary>
    /// Id of the category. This information is provided by transactions/categories service.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>Id of the category. This information is provided by transactions/categories service.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }

    /// <summary>
    /// Gets or Sets DebitTotal
    /// </summary>
    [DataMember(Name="debitTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "debitTotal")]
    public Money DebitTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DerivedCategorySummary {\n");
      sb.Append("  CreditTotal: ").Append(CreditTotal).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  DebitTotal: ").Append(DebitTotal).Append("\n");
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
