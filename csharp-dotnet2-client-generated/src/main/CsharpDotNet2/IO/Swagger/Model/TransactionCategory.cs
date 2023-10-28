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
  public class TransactionCategory {
    /// <summary>
    /// The name of the high level category. A group of similar transaction categories are clubbed together to form a high-level category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>The name of the high level category. A group of similar transaction categories are clubbed together to form a high-level category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="highLevelCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highLevelCategoryName")]
    public string HighLevelCategoryName { get; set; }

    /// <summary>
    /// A attribute which will always hold the first value(initial name) of Yodlee defined highLevelCategoryName attribute.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>A attribute which will always hold the first value(initial name) of Yodlee defined highLevelCategoryName attribute.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="defaultHighLevelCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultHighLevelCategoryName")]
    public string DefaultHighLevelCategoryName { get; set; }

    /// <summary>
    /// The unique identifier of the high level category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>The unique identifier of the high level category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="highLevelCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highLevelCategoryId")]
    public long? HighLevelCategoryId { get; set; }

    /// <summary>
    /// Entity that provides detail category attributes<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Entity that provides detail category attributes<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="detailCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailCategory")]
    public List<DetailCategory> DetailCategory { get; set; }

    /// <summary>
    /// Unique identifier of the category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>Unique identifier of the category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Source used to identify whether the transaction category is user defined category or system created category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Source used to identify whether the transaction category is user defined category or system created category.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// The name of the category.<br><b>Note</b>: Transaction categorization is one of the core features offered by Yodlee and the categories are assigned to the transactions by the system. Transactions can be clubbed together by the category that is assigned to them.  <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>The name of the category.<br><b>Note</b>: Transaction categorization is one of the core features offered by Yodlee and the categories are assigned to the transactions by the system. Transactions can be clubbed together by the category that is assigned to them.  <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Category Classification.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Category Classification.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="classification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classification")]
    public string Classification { get; set; }

    /// <summary>
    /// Transaction categories and high-level categories are further mapped to five transaction category types. Customers, based on their needs can either use the transaction categories, the high-level categories, or the transaction category types. <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Transaction categories and high-level categories are further mapped to five transaction category types. Customers, based on their needs can either use the transaction categories, the high-level categories, or the transaction category types. <br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// A attribute which will always hold the first value(initial name) of Yodlee defined category attribute.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br>
    /// </summary>
    /// <value>A attribute which will always hold the first value(initial name) of Yodlee defined category attribute.<br><br><b>Applicable containers</b>: creditCard, investment, insurance, loan<br></value>
    [DataMember(Name="defaultCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultCategoryName")]
    public string DefaultCategoryName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionCategory {\n");
      sb.Append("  HighLevelCategoryName: ").Append(HighLevelCategoryName).Append("\n");
      sb.Append("  DefaultHighLevelCategoryName: ").Append(DefaultHighLevelCategoryName).Append("\n");
      sb.Append("  HighLevelCategoryId: ").Append(HighLevelCategoryId).Append("\n");
      sb.Append("  DetailCategory: ").Append(DetailCategory).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Classification: ").Append(Classification).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DefaultCategoryName: ").Append(DefaultCategoryName).Append("\n");
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
