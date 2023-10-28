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
  public class DerivedTransactionsSummary {
    /// <summary>
    /// Type of categories provided by transactions/categories service.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Type of categories provided by transactions/categories service.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br><b>Applicable Values</b><br></value>
    [DataMember(Name="categoryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryType")]
    public string CategoryType { get; set; }

    /// <summary>
    /// Summary of transaction amouts at category level.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br>
    /// </summary>
    /// <value>Summary of transaction amouts at category level.<br><br><b>Applicable containers</b>: creditCard, bank, investment<br></value>
    [DataMember(Name="categorySummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorySummary")]
    public List<DerivedCategorySummary> CategorySummary { get; set; }

    /// <summary>
    /// Gets or Sets CreditTotal
    /// </summary>
    [DataMember(Name="creditTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditTotal")]
    public Money CreditTotal { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public DerivedTransactionsLinks Links { get; set; }

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
      sb.Append("class DerivedTransactionsSummary {\n");
      sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
      sb.Append("  CategorySummary: ").Append(CategorySummary).Append("\n");
      sb.Append("  CreditTotal: ").Append(CreditTotal).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
