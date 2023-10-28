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
  public class Transaction {
    /// <summary>
    /// The value provided will be either postDate or transactionDate. postDate takes higher priority than transactionDate, except for the investment container as only transactionDate is available. The availability of postDate or transactionDate depends on the provider site.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The value provided will be either postDate or transactionDate. postDate takes higher priority than transactionDate, except for the investment container as only transactionDate is available. The availability of postDate or transactionDate depends on the provider site.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public string Date { get; set; }

    /// <summary>
    /// A unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts.<br>Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.
    /// </summary>
    /// <value>A unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts.<br>Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.</value>
    [DataMember(Name="sourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceId")]
    public string SourceId { get; set; }

    /// <summary>
    /// The symbol of the security being traded.<br><b>Note</b>: The settle date field applies only to trade-related transactions. <br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The symbol of the security being traded.<br><b>Note</b>: The settle date field applies only to trade-related transactions. <br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// The CUSIP (Committee on Uniform Securities Identification Procedures) identifies the financial instruments in the United States and Canada.<br><b><br><b>Note</b></b>: The CUSIP number field applies only to trade related transactions.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The CUSIP (Committee on Uniform Securities Identification Procedures) identifies the financial instruments in the United States and Canada.<br><b><br><b>Note</b></b>: The CUSIP number field applies only to trade related transactions.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="cusipNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cusipNumber")]
    public string CusipNumber { get; set; }

    /// <summary>
    /// The high level category assigned to the transaction. The supported values are provided by the GET transactions/categories. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The high level category assigned to the transaction. The supported values are provided by the GET transactions/categories. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="highLevelCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highLevelCategoryId")]
    public long? HighLevelCategoryId { get; set; }

    /// <summary>
    /// The id of the detail category that is assigned to the transaction. The supported values are provided by GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard<br>
    /// </summary>
    /// <value>The id of the detail category that is assigned to the transaction. The supported values are provided by GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard<br></value>
    [DataMember(Name="detailCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailCategoryId")]
    public long? DetailCategoryId { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public Description Description { get; set; }

    /// <summary>
    /// Additional notes provided by the user for a particular  transaction through application or API services. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>Additional notes provided by the user for a particular  transaction through application or API services. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="memo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memo")]
    public string Memo { get; set; }

    /// <summary>
    /// It is the date on which the transaction is finalized, that is, the date the ownership of the security is transferred to the buyer. The settlement date is usually few days after the transaction date.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>It is the date on which the transaction is finalized, that is, the date the ownership of the security is transferred to the buyer. The settlement date is usually few days after the transaction date.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="settleDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settleDate")]
    public string SettleDate { get; set; }

    /// <summary>
    /// The nature of the transaction, i.e., deposit, refund, payment, etc.<br><b>Note</b>: The transaction type field is available only for the United States, Canada, United Kingdom, and India based provider sites. <br><br><b>Applicable containers</b>: bank,creditCard,investment<br>
    /// </summary>
    /// <value>The nature of the transaction, i.e., deposit, refund, payment, etc.<br><b>Note</b>: The transaction type field is available only for the United States, Canada, United Kingdom, and India based provider sites. <br><br><b>Applicable containers</b>: bank,creditCard,investment<br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The intermediary of the transaction.<br><br><b>Applicable containers</b>:  bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>The intermediary of the transaction.<br><br><b>Applicable containers</b>:  bank,creditCard,investment,loan<br></value>
    [DataMember(Name="intermediary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intermediary")]
    public List<string> Intermediary { get; set; }

    /// <summary>
    /// Indicates if the transaction appears as a debit or a credit transaction in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates if the transaction appears as a debit or a credit transaction in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="baseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseType")]
    public string BaseType { get; set; }

    /// <summary>
    /// Indicates the source of the category, i.e., categories derived by the system or assigned/provided by the consumer. This is the source field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>Indicates the source of the category, i.e., categories derived by the system or assigned/provided by the consumer. This is the source field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="categorySource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorySource")]
    public string CategorySource { get; set; }

    /// <summary>
    /// Gets or Sets Principal
    /// </summary>
    [DataMember(Name="principal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principal")]
    public Money Principal { get; set; }

    /// <summary>
    /// Gets or Sets LastUpdated
    /// </summary>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// Gets or Sets Interest
    /// </summary>
    [DataMember(Name="interest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interest")]
    public Money Interest { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public Money Price { get; set; }

    /// <summary>
    /// Gets or Sets Commission
    /// </summary>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public Money Commission { get; set; }

    /// <summary>
    /// An unique identifier for the transaction. The combination of the id and account container are unique in the system. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>An unique identifier for the transaction. The combination of the id and account container are unique in the system. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Indicates the merchantType of the transaction.e.g:-BILLERS,SUBSCRIPTION,OTHERS <br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>Indicates the merchantType of the transaction.e.g:-BILLERS,SUBSCRIPTION,OTHERS <br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="merchantType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantType")]
    public string MerchantType { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Money Amount { get; set; }

    /// <summary>
    /// The checkNumber of the transaction.<br><br><b>Applicable containers</b>: bank<br>
    /// </summary>
    /// <value>The checkNumber of the transaction.<br><br><b>Applicable containers</b>: bank<br></value>
    [DataMember(Name="checkNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkNumber")]
    public string CheckNumber { get; set; }

    /// <summary>
    /// Indicates if the transaction is happened online or in-store. <br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br>
    /// </summary>
    /// <value>Indicates if the transaction is happened online or in-store. <br><br><b>Applicable containers</b>: bank,creditCard,investment,loan<br></value>
    [DataMember(Name="isPhysical", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPhysical")]
    public bool? IsPhysical { get; set; }

    /// <summary>
    /// The quantity associated with the transaction.<br><b>Note</b>: The quantity field applies only to trade-related transactions.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The quantity associated with the transaction.<br><b>Note</b>: The quantity field applies only to trade-related transactions.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// It is an identification number that is assigned to financial instruments such as stocks and bonds trading in Switzerland.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>It is an identification number that is assigned to financial instruments such as stocks and bonds trading in Switzerland.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="valoren", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valoren")]
    public string Valoren { get; set; }

    /// <summary>
    /// Indicates if the transaction is aggregated from the FI site or the consumer has manually created the transaction using the application or an API. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>Indicates if the transaction is aggregated from the FI site or the consumer has manually created the transaction using the application or an API. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="isManual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isManual")]
    public bool? IsManual { get; set; }

    /// <summary>
    /// Gets or Sets Merchant
    /// </summary>
    [DataMember(Name="merchant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant")]
    public Merchant Merchant { get; set; }

    /// <summary>
    /// SEDOL stands for Stock Exchange Daily Official List, a list of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>SEDOL stands for Stock Exchange Daily Official List, a list of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="sedol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sedol")]
    public string Sedol { get; set; }

    /// <summary>
    /// The date the transaction happens in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The date the transaction happens in the account. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="transactionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionDate")]
    public string TransactionDate { get; set; }

    /// <summary>
    /// The categoryType of the category assigned to the transaction. This is the type field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The categoryType of the category assigned to the transaction. This is the type field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="categoryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryType")]
    public string CategoryType { get; set; }

    /// <summary>
    /// The account from which the transaction was made. This is basically the primary key of the account resource. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The account from which the transaction was made. This is basically the primary key of the account resource. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// The source through which the transaction is added to the Yodlee system.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loann<br><b>Applicable Values:</b><br>
    /// </summary>
    /// <value>The source through which the transaction is added to the Yodlee system.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loann<br><b>Applicable Values:</b><br></value>
    [DataMember(Name="sourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceType")]
    public string SourceType { get; set; }

    /// <summary>
    /// The account's container.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The account's container.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="CONTAINER", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CONTAINER")]
    public string CONTAINER { get; set; }

    /// <summary>
    /// The date on which the transaction is posted to the account.<br><br><b>Applicable containers</b>: bank,creditCard,insurance,loan<br>
    /// </summary>
    /// <value>The date on which the transaction is posted to the account.<br><br><b>Applicable containers</b>: bank,creditCard,insurance,loan<br></value>
    [DataMember(Name="postDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postDate")]
    public string PostDate { get; set; }

    /// <summary>
    /// The parentCategoryId of the category assigned to the transaction.<br><b>Note</b>: This field will be provided in the response if the transaction is assigned to a user-created category. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The parentCategoryId of the category assigned to the transaction.<br><b>Note</b>: This field will be provided in the response if the transaction is assigned to a user-created category. <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="parentCategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentCategoryId")]
    public long? ParentCategoryId { get; set; }

    /// <summary>
    /// The transaction subtype field provides a detailed transaction type. For example, purchase is a transaction type and the transaction subtype field indicates if the purchase was made using a debit or credit card.<br><b>Note</b>: The transaction subtype field is available only in the United States, Canada, United Kingdom, and India.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The transaction subtype field provides a detailed transaction type. For example, purchase is a transaction type and the transaction subtype field indicates if the purchase was made using a debit or credit card.<br><b>Note</b>: The transaction subtype field is available only in the United States, Canada, United Kingdom, and India.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="subType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subType")]
    public string SubType { get; set; }

    /// <summary>
    /// The name of the category assigned to the transaction. This is the category field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The name of the category assigned to the transaction. This is the category field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets RunningBalance
    /// </summary>
    [DataMember(Name="runningBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runningBalance")]
    public Money RunningBalance { get; set; }

    /// <summary>
    /// The id of the category assigned to the transaction. This is the id field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br>
    /// </summary>
    /// <value>The id of the category assigned to the transaction. This is the id field of the transaction category resource. The supported values are provided by the GET transactions/categories.<br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br></value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public long? CategoryId { get; set; }

    /// <summary>
    /// For transactions involving securities, this captures the securities description.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>For transactions involving securities, this captures the securities description.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="holdingDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holdingDescription")]
    public string HoldingDescription { get; set; }

    /// <summary>
    /// International Securities Identification Number (ISIN) standard is used worldwide to identify specific securities.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>International Securities Identification Number (ISIN) standard is used worldwide to identify specific securities.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="isin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isin")]
    public string Isin { get; set; }

    /// <summary>
    /// The status of the transaction: pending or posted.<br><b>Note</b>: Most FI sites only display posted transactions. If the FI site displays transaction status, same will be aggregated.  <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The status of the transaction: pending or posted.<br><b>Note</b>: Most FI sites only display posted transactions. If the FI site displays transaction status, same will be aggregated.  <br><br><b>Applicable containers</b>: bank,creditCard,investment,insurance,loan<br><b>Applicable Values</b><br></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Transaction {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  Symbol: ").Append(Symbol).Append("\n");
      sb.Append("  CusipNumber: ").Append(CusipNumber).Append("\n");
      sb.Append("  HighLevelCategoryId: ").Append(HighLevelCategoryId).Append("\n");
      sb.Append("  DetailCategoryId: ").Append(DetailCategoryId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  SettleDate: ").Append(SettleDate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Intermediary: ").Append(Intermediary).Append("\n");
      sb.Append("  BaseType: ").Append(BaseType).Append("\n");
      sb.Append("  CategorySource: ").Append(CategorySource).Append("\n");
      sb.Append("  Principal: ").Append(Principal).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  Interest: ").Append(Interest).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
      sb.Append("  IsPhysical: ").Append(IsPhysical).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Valoren: ").Append(Valoren).Append("\n");
      sb.Append("  IsManual: ").Append(IsManual).Append("\n");
      sb.Append("  Merchant: ").Append(Merchant).Append("\n");
      sb.Append("  Sedol: ").Append(Sedol).Append("\n");
      sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
      sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  SourceType: ").Append(SourceType).Append("\n");
      sb.Append("  CONTAINER: ").Append(CONTAINER).Append("\n");
      sb.Append("  PostDate: ").Append(PostDate).Append("\n");
      sb.Append("  ParentCategoryId: ").Append(ParentCategoryId).Append("\n");
      sb.Append("  SubType: ").Append(SubType).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  RunningBalance: ").Append(RunningBalance).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  HoldingDescription: ").Append(HoldingDescription).Append("\n");
      sb.Append("  Isin: ").Append(Isin).Append("\n");
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
