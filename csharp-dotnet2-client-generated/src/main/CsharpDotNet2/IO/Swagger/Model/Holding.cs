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
  public class Holding {
    /// <summary>
    /// The symbol of the security.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The symbol of the security.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// The quantity of the employee stock options that are already exercised or bought by the employee.<br><b>Note</b>: Once the employee stock options is exercised, they are either converted to cash value or equity positions depending on the FI. The exercised quantity field is only applicable to employee stock options.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The quantity of the employee stock options that are already exercised or bought by the employee.<br><b>Note</b>: Once the employee stock options is exercised, they are either converted to cash value or equity positions depending on the FI. The exercised quantity field is only applicable to employee stock options.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="exercisedQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exercisedQuantity")]
    public double? ExercisedQuantity { get; set; }

    /// <summary>
    /// The CUSIP (Committee on Uniform Securities Identification Procedures) identifies most the financial instruments in the United States and Canada.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The CUSIP (Committee on Uniform Securities Identification Procedures) identifies most the financial instruments in the United States and Canada.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="cusipNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cusipNumber")]
    public string CusipNumber { get; set; }

    /// <summary>
    /// Asset classification applied to the holding. <br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>Asset classification applied to the holding. <br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="assetClassification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assetClassification")]
    public List<AssetClassification> AssetClassification { get; set; }

    /// <summary>
    /// The quantity of units or shares that are already vested on a vest date.<br><b>Note</b>: The vested quantity field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The quantity of units or shares that are already vested on a vest date.<br><b>Note</b>: The vested quantity field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="vestedQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vestedQuantity")]
    public double? VestedQuantity { get; set; }

    /// <summary>
    /// The description (name) for the holding (E.g., Cisco Systems)<br>For insurance container, the field is only applicable for insurance annuity and variable life insurance types. <br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The description (name) for the holding (E.g., Cisco Systems)<br>For insurance container, the field is only applicable for insurance annuity and variable life insurance types. <br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets UnvestedValue
    /// </summary>
    [DataMember(Name="unvestedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unvestedValue")]
    public Money UnvestedValue { get; set; }

    /// <summary>
    /// Indicates the security style of holding identified through the security service.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Indicates the security style of holding identified through the security service.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="securityStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityStyle")]
    public string SecurityStyle { get; set; }

    /// <summary>
    /// Gets or Sets VestedValue
    /// </summary>
    [DataMember(Name="vestedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vestedValue")]
    public Money VestedValue { get; set; }

    /// <summary>
    /// The type of the option position (i.e., put or call).<br><b>Note</b>: The option type field is only applicable to options.<br><br><b>Applicable containers</b>: investment<br><b>Applicable Values</b><br>
    /// </summary>
    /// <value>The type of the option position (i.e., put or call).<br><b>Note</b>: The option type field is only applicable to options.<br><br><b>Applicable containers</b>: investment<br><b>Applicable Values</b><br></value>
    [DataMember(Name="optionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optionType")]
    public string OptionType { get; set; }

    /// <summary>
    /// The date when the information was last updated in the system.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The date when the information was last updated in the system.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdated")]
    public string LastUpdated { get; set; }

    /// <summary>
    /// The providerAccountIds that share the account with the primary providerAccountId that was created when the user had added the account for the first time.<br><b>Additional Details</b>: This attribute is returned in the response only if the account deduplication feature is enabled and the same account is mapped to more than one provider account IDs indicating the account is owned by more than one user, for example, joint accounts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul>
    /// </summary>
    /// <value>The providerAccountIds that share the account with the primary providerAccountId that was created when the user had added the account for the first time.<br><b>Additional Details</b>: This attribute is returned in the response only if the account deduplication feature is enabled and the same account is mapped to more than one provider account IDs indicating the account is owned by more than one user, for example, joint accounts.<br><br><b>Aggregated / Manual</b>: Aggregated<br><b>Applicable containers</b>: All Containers<br><b>Endpoints</b>:<ul><li>GET accounts</li><li>GET accounts/{accountId}</li><li>GET dataExtracts/userData</li></ul></value>
    [DataMember(Name="associatedProviderAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associatedProviderAccountId")]
    public List<long?> AssociatedProviderAccountId { get; set; }

    /// <summary>
    /// Indicates the security match status id of the investment option identified during security normalization.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>Indicates the security match status id of the investment option identified during security normalization.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="matchStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matchStatus")]
    public string MatchStatus { get; set; }

    /// <summary>
    /// Type of holding<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Type of holding<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="holdingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holdingType")]
    public string HoldingType { get; set; }

    /// <summary>
    /// The stated maturity date of a bond or CD.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The stated maturity date of a bond or CD.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="maturityDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maturityDate")]
    public string MaturityDate { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public Money Price { get; set; }

    /// <summary>
    /// The fixed duration for which the bond or CD is issued.<br><b>Note</b>: The term field is only applicable to CD.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The fixed duration for which the bond or CD is issued.<br><b>Note</b>: The term field is only applicable to CD.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "term")]
    public string Term { get; set; }

    /// <summary>
    /// The quantity of tradeable units in a contract.<br><b>Note</b>: The contract quantity field is only applicable to commodity and currency.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The quantity of tradeable units in a contract.<br><b>Note</b>: The contract quantity field is only applicable to commodity and currency.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="contractQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractQuantity")]
    public double? ContractQuantity { get; set; }

    /// <summary>
    /// Unique identifier for the security added in the system. This is the primary key of the holding resource.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Unique identifier for the security added in the system. This is the primary key of the holding resource.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Indicates that the holding is a short trading.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>Indicates that the holding is a short trading.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="isShort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isShort")]
    public bool? IsShort { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Money Value { get; set; }

    /// <summary>
    /// The date on which an option, right or warrant expires.<br><b>Note</b>: The expiration date field is only applicable to options and employee stock options.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The date on which an option, right or warrant expires.<br><b>Note</b>: The expiration date field is only applicable to options and employee stock options.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public string ExpirationDate { get; set; }

    /// <summary>
    /// The interest rate on a CD.<br><b>Note</b>: The interest rate field is only applicable to CD.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The interest rate on a CD.<br><b>Note</b>: The interest rate field is only applicable to CD.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="interestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interestRate")]
    public double? InterestRate { get; set; }

    /// <summary>
    /// The quantity held for the holding.<br><b>Note</b>: Only for bonds the quantity field indicates the normalized quantity and not the quantity aggregated from the site. The quantity field is only applicable to restricted stock units/awards, performance units, currency, and commodity.<br>For insurance container, the field is only applicable for insurance annuity and variable life insurance types.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The quantity held for the holding.<br><b>Note</b>: Only for bonds the quantity field indicates the normalized quantity and not the quantity aggregated from the site. The quantity field is only applicable to restricted stock units/awards, performance units, currency, and commodity.<br>For insurance container, the field is only applicable for insurance annuity and variable life insurance types.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets AccruedInterest
    /// </summary>
    [DataMember(Name="accruedInterest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accruedInterest")]
    public Money AccruedInterest { get; set; }

    /// <summary>
    /// The date on which equity awards like ESOP, RSU, etc., are issued or granted.<br><b>Note</b>: The grant date field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The date on which equity awards like ESOP, RSU, etc., are issued or granted.<br><b>Note</b>: The grant date field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="grantDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantDate")]
    public string GrantDate { get; set; }

    /// <summary>
    /// The SEDOL (Stock Exchange Daily Official List) is a set of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><b>Note</b>: The SEDOL field is only applicable to the trade related transactions<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The SEDOL (Stock Exchange Daily Official List) is a set of security identifiers used in the United Kingdom and Ireland for clearing purposes.<br><b>Note</b>: The SEDOL field is only applicable to the trade related transactions<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="sedol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sedol")]
    public string Sedol { get; set; }

    /// <summary>
    /// The number of vested shares that can be exercised by the employee. It is usually equal to the vested quantity.<br><b>Note</b>: The vested shares exercisable field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The number of vested shares that can be exercised by the employee. It is usually equal to the vested quantity.<br><b>Note</b>: The vested shares exercisable field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="vestedSharesExercisable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vestedSharesExercisable")]
    public double? VestedSharesExercisable { get; set; }

    /// <summary>
    /// Gets or Sets Spread
    /// </summary>
    [DataMember(Name="spread", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spread")]
    public Money Spread { get; set; }

    /// <summary>
    /// Unique identifier of the account to which the security is linked.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Unique identifier of the account to which the security is linked.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The enrichedDescription is the security description of the normalized holding<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The enrichedDescription is the security description of the normalized holding<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="enrichedDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enrichedDescription")]
    public string EnrichedDescription { get; set; }

    /// <summary>
    /// The stated interest rate for a bond.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The stated interest rate for a bond.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="couponRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "couponRate")]
    public double? CouponRate { get; set; }

    /// <summary>
    /// The date on which the holding is created in the Yodlee system.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>The date on which the holding is created in the Yodlee system.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets AccruedIncome
    /// </summary>
    [DataMember(Name="accruedIncome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accruedIncome")]
    public Money AccruedIncome { get; set; }

    /// <summary>
    /// Indicates the security type of holding identified through the security service.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Indicates the security type of holding identified through the security service.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="securityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityType")]
    public string SecurityType { get; set; }

    /// <summary>
    /// Unique identifier for the user's association with the provider.<br><br><b>Applicable containers</b>: investment, insurance<br>
    /// </summary>
    /// <value>Unique identifier for the user's association with the provider.<br><br><b>Applicable containers</b>: investment, insurance<br></value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// Indicates the number of unvested quantity or units.<br><b>Note</b>: The unvested quantity field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>Indicates the number of unvested quantity or units.<br><b>Note</b>: The unvested quantity field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="unvestedQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unvestedQuantity")]
    public double? UnvestedQuantity { get; set; }

    /// <summary>
    /// Gets or Sets CostBasis
    /// </summary>
    [DataMember(Name="costBasis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costBasis")]
    public Money CostBasis { get; set; }

    /// <summary>
    /// The date on which a RSU, RSA, or an employee stock options become vested.<br><b>Note</b>: The vesting date field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The date on which a RSU, RSA, or an employee stock options become vested.<br><b>Note</b>: The vesting date field is only applicable to employee stock options, restricted stock units/awards, performance units, etc.<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="vestingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vestingDate")]
    public string VestingDate { get; set; }

    /// <summary>
    /// The ISIN (International Securities Identification Number) is used worldwide to identify specific securities. It is equivalent to CUSIP for international markets.<br><br><b>Note</b>: The ISIN field is only applicable to the trade related transactions<br><br><b>Applicable containers</b>: investment<br>
    /// </summary>
    /// <value>The ISIN (International Securities Identification Number) is used worldwide to identify specific securities. It is equivalent to CUSIP for international markets.<br><br><b>Note</b>: The ISIN field is only applicable to the trade related transactions<br><br><b>Applicable containers</b>: investment<br></value>
    [DataMember(Name="isin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isin")]
    public string Isin { get; set; }

    /// <summary>
    /// Gets or Sets StrikePrice
    /// </summary>
    [DataMember(Name="strikePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strikePrice")]
    public Money StrikePrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Holding {\n");
      sb.Append("  Symbol: ").Append(Symbol).Append("\n");
      sb.Append("  ExercisedQuantity: ").Append(ExercisedQuantity).Append("\n");
      sb.Append("  CusipNumber: ").Append(CusipNumber).Append("\n");
      sb.Append("  AssetClassification: ").Append(AssetClassification).Append("\n");
      sb.Append("  VestedQuantity: ").Append(VestedQuantity).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  UnvestedValue: ").Append(UnvestedValue).Append("\n");
      sb.Append("  SecurityStyle: ").Append(SecurityStyle).Append("\n");
      sb.Append("  VestedValue: ").Append(VestedValue).Append("\n");
      sb.Append("  OptionType: ").Append(OptionType).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  AssociatedProviderAccountId: ").Append(AssociatedProviderAccountId).Append("\n");
      sb.Append("  MatchStatus: ").Append(MatchStatus).Append("\n");
      sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
      sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Term: ").Append(Term).Append("\n");
      sb.Append("  ContractQuantity: ").Append(ContractQuantity).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsShort: ").Append(IsShort).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  AccruedInterest: ").Append(AccruedInterest).Append("\n");
      sb.Append("  GrantDate: ").Append(GrantDate).Append("\n");
      sb.Append("  Sedol: ").Append(Sedol).Append("\n");
      sb.Append("  VestedSharesExercisable: ").Append(VestedSharesExercisable).Append("\n");
      sb.Append("  Spread: ").Append(Spread).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  EnrichedDescription: ").Append(EnrichedDescription).Append("\n");
      sb.Append("  CouponRate: ").Append(CouponRate).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  AccruedIncome: ").Append(AccruedIncome).Append("\n");
      sb.Append("  SecurityType: ").Append(SecurityType).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  UnvestedQuantity: ").Append(UnvestedQuantity).Append("\n");
      sb.Append("  CostBasis: ").Append(CostBasis).Append("\n");
      sb.Append("  VestingDate: ").Append(VestingDate).Append("\n");
      sb.Append("  Isin: ").Append(Isin).Append("\n");
      sb.Append("  StrikePrice: ").Append(StrikePrice).Append("\n");
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
