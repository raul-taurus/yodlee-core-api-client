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
  public class Security {
    /// <summary>
    /// Securities exchange provide the securities information at the corresponding exchanges. <br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Securities exchange provide the securities information at the corresponding exchanges. <br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="stockExchangeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stockExchangeDetails")]
    public List<StockExchangeDetail> StockExchangeDetails { get; set; }

    /// <summary>
    /// Price units corresponding to the security style. This is used to derive actual price of the security from market value.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Price units corresponding to the security style. This is used to derive actual price of the security from market value.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="issueTypeMultiplier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueTypeMultiplier")]
    public double? IssueTypeMultiplier { get; set; }

    /// <summary>
    /// The state in which the security is taxed.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The state in which the security is taxed.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="stateTaxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateTaxable")]
    public bool? StateTaxable { get; set; }

    /// <summary>
    /// Next call date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Next call date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="callDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callDate")]
    public string CallDate { get; set; }

    /// <summary>
    /// cdsc fund flag of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>cdsc fund flag of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="cdscFundFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cdscFundFlag")]
    public bool? CdscFundFlag { get; set; }

    /// <summary>
    /// A CUSIP is a nine-character alphanumeric code that identifies a North American financial security for the purposes of facilitating clearing and settlement of trades.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>A CUSIP is a nine-character alphanumeric code that identifies a North American financial security for the purposes of facilitating clearing and settlement of trades.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="cusip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cusip")]
    public string Cusip { get; set; }

    /// <summary>
    /// Flag indicating federal taxable.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Flag indicating federal taxable.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="federalTaxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federalTaxable")]
    public bool? FederalTaxable { get; set; }

    /// <summary>
    /// Unique identifier for S&P rating on Envestnet platform.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Unique identifier for S&P rating on Envestnet platform.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="sAndPRating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sAndPRating")]
    public string SAndPRating { get; set; }

    /// <summary>
    /// Share class of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Share class of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="shareClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shareClass")]
    public string ShareClass { get; set; }

    /// <summary>
    /// Flag indicating a dummy security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Flag indicating a dummy security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="isEnvestnetDummySecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnvestnetDummySecurity")]
    public bool? IsEnvestnetDummySecurity { get; set; }

    /// <summary>
    /// The description (name) of the security. For example, Cisco Systems.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The description (name) of the security. For example, Cisco Systems.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Minimum purchase of security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Minimum purchase of security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="minimumPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumPurchase")]
    public int? MinimumPurchase { get; set; }

    /// <summary>
    /// Indicates the type of security like stocks, mutual fund, etc. <br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Indicates the type of security like stocks, mutual fund, etc. <br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// First coupon date of security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>First coupon date of security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="firstCouponDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstCouponDate")]
    public string FirstCouponDate { get; set; }

    /// <summary>
    /// Coupon Frequency.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Coupon Frequency.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public int? Frequency { get; set; }

    /// <summary>
    /// The method in which interest is accrued or earned.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The method in which interest is accrued or earned.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="accrualMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accrualMethod")]
    public string AccrualMethod { get; set; }

    /// <summary>
    /// ISO 4217 currency code indicating income currency of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>ISO 4217 currency code indicating income currency of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="incomeCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "incomeCurrency")]
    public string IncomeCurrency { get; set; }

    /// <summary>
    /// Maturity date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Maturity date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="maturityDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maturityDate")]
    public string MaturityDate { get; set; }

    /// <summary>
    /// Next call price of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Next call price of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="callPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callPrice")]
    public double? CallPrice { get; set; }

    /// <summary>
    /// The unique identifier of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The unique identifier of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Issue date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Issue date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="issueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueDate")]
    public string IssueDate { get; set; }

    /// <summary>
    /// Identifier of the sector to which the security belongs to.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Identifier of the sector to which the security belongs to.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="sector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sector")]
    public string Sector { get; set; }

    /// <summary>
    /// Agency factor of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Agency factor of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="agencyFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agencyFactor")]
    public double? AgencyFactor { get; set; }

    /// <summary>
    /// The rate of interest paid annually, expressed as a percentage of the bond's par or face value.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The rate of interest paid annually, expressed as a percentage of the bond's par or face value.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="interestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestRate")]
    public double? InterestRate { get; set; }

    /// <summary>
    /// The last updated date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The last updated date of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModifiedDate")]
    public string LastModifiedDate { get; set; }

    /// <summary>
    /// GICS Sector is a categorization the S&P assigns to all publically traded companies. <br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>GICS Sector is a categorization the S&P assigns to all publically traded companies. <br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="gicsSector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gicsSector")]
    public string GicsSector { get; set; }

    /// <summary>
    /// <b>true</b>:Closed for all investors , <b>false</b>: Open to all investors.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value><b>true</b>:Closed for all investors , <b>false</b>: Open to all investors.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="closedFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closedFlag")]
    public bool? ClosedFlag { get; set; }

    /// <summary>
    /// The Stock Exchange Daily Official List (SEDOL) is a set of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><b>Note</b>: The SEDOL field is only applicable to the trade related transactions.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The Stock Exchange Daily Official List (SEDOL) is a set of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><b>Note</b>: The SEDOL field is only applicable to the trade related transactions.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="sedol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sedol")]
    public string Sedol { get; set; }

    /// <summary>
    /// GICS sector ID to which the security belongs to.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>GICS sector ID to which the security belongs to.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="subSector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subSector")]
    public string SubSector { get; set; }

    /// <summary>
    /// Last coupon date of security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Last coupon date of security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="lastCouponDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastCouponDate")]
    public string LastCouponDate { get; set; }

    /// <summary>
    /// Indicates whether the security is a simulated security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Indicates whether the security is a simulated security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="isSyntheticSecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSyntheticSecurity")]
    public bool? IsSyntheticSecurity { get; set; }

    /// <summary>
    /// ISO 4217 currency code indicating trading currency of the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>ISO 4217 currency code indicating trading currency of the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="tradeCurrencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeCurrencyCode")]
    public string TradeCurrencyCode { get; set; }

    /// <summary>
    /// Indicates whether the security is a dummy security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Indicates whether the security is a dummy security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="isDummySecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDummySecurity")]
    public bool? IsDummySecurity { get; set; }

    /// <summary>
    /// Unique identifier for Moody rating on Envestnet platform.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Unique identifier for Moody rating on Envestnet platform.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="moodyRating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moodyRating")]
    public string MoodyRating { get; set; }

    /// <summary>
    /// Classification of the style for the security.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Classification of the style for the security.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "style")]
    public string Style { get; set; }

    /// <summary>
    /// <b>1</b>- indicates Eligible,<b>0</b>- indicates firm is not eligible.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value><b>1</b>- indicates Eligible,<b>0</b>- indicates firm is not eligible.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="firmEligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firmEligible")]
    public string FirmEligible { get; set; }

    /// <summary>
    /// Mutual Fund Family Name.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Mutual Fund Family Name.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="fundFamily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundFamily")]
    public string FundFamily { get; set; }

    /// <summary>
    /// The International Securities Identification Number (ISIN) is used worldwide to identify specific securities. It is equivalent to CUSIP for international markets.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The International Securities Identification Number (ISIN) is used worldwide to identify specific securities. It is equivalent to CUSIP for international markets.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="isin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isin")]
    public string Isin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Security {\n");
      sb.Append("  StockExchangeDetails: ").Append(StockExchangeDetails).Append("\n");
      sb.Append("  IssueTypeMultiplier: ").Append(IssueTypeMultiplier).Append("\n");
      sb.Append("  StateTaxable: ").Append(StateTaxable).Append("\n");
      sb.Append("  CallDate: ").Append(CallDate).Append("\n");
      sb.Append("  CdscFundFlag: ").Append(CdscFundFlag).Append("\n");
      sb.Append("  Cusip: ").Append(Cusip).Append("\n");
      sb.Append("  FederalTaxable: ").Append(FederalTaxable).Append("\n");
      sb.Append("  SAndPRating: ").Append(SAndPRating).Append("\n");
      sb.Append("  ShareClass: ").Append(ShareClass).Append("\n");
      sb.Append("  IsEnvestnetDummySecurity: ").Append(IsEnvestnetDummySecurity).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MinimumPurchase: ").Append(MinimumPurchase).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  FirstCouponDate: ").Append(FirstCouponDate).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  AccrualMethod: ").Append(AccrualMethod).Append("\n");
      sb.Append("  IncomeCurrency: ").Append(IncomeCurrency).Append("\n");
      sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
      sb.Append("  CallPrice: ").Append(CallPrice).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
      sb.Append("  Sector: ").Append(Sector).Append("\n");
      sb.Append("  AgencyFactor: ").Append(AgencyFactor).Append("\n");
      sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
      sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
      sb.Append("  GicsSector: ").Append(GicsSector).Append("\n");
      sb.Append("  ClosedFlag: ").Append(ClosedFlag).Append("\n");
      sb.Append("  Sedol: ").Append(Sedol).Append("\n");
      sb.Append("  SubSector: ").Append(SubSector).Append("\n");
      sb.Append("  LastCouponDate: ").Append(LastCouponDate).Append("\n");
      sb.Append("  IsSyntheticSecurity: ").Append(IsSyntheticSecurity).Append("\n");
      sb.Append("  TradeCurrencyCode: ").Append(TradeCurrencyCode).Append("\n");
      sb.Append("  IsDummySecurity: ").Append(IsDummySecurity).Append("\n");
      sb.Append("  MoodyRating: ").Append(MoodyRating).Append("\n");
      sb.Append("  Style: ").Append(Style).Append("\n");
      sb.Append("  FirmEligible: ").Append(FirmEligible).Append("\n");
      sb.Append("  FundFamily: ").Append(FundFamily).Append("\n");
      sb.Append("  Isin: ").Append(Isin).Append("\n");
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
