/* 
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. You can generate a client SDK for Python, Java, JavaScript, PHP, or other languages according to your development needs. For more details about the APIs, refer to <a href=\"https://developer.envestnet.com/resources/yodlee/yodlee-api-overview/docs\">Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// StockExchangeDetail
    /// </summary>
    [DataContract]
        public partial class StockExchangeDetail :  IEquatable<StockExchangeDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchangeDetail" /> class.
        /// </summary>
        public StockExchangeDetail()
        {
        }
        
        /// <summary>
        /// Ticker symbol representing particular securities listed on an exchange.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;
        /// </summary>
        /// <value>Ticker symbol representing particular securities listed on an exchange.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; private set; }

        /// <summary>
        /// Country codes are geocodes developed to represent countries and dependent areas.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;
        /// </summary>
        /// <value>Country codes are geocodes developed to represent countries and dependent areas.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// ISO codes of currency.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;
        /// </summary>
        /// <value>ISO codes of currency.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// An Exchange code is a four-character code used to identify stock markets and other trading exchanges within global trading.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;
        /// </summary>
        /// <value>An Exchange code is a four-character code used to identify stock markets and other trading exchanges within global trading.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment, insurance&lt;br&gt;</value>
        [DataMember(Name="exchangeCode", EmitDefaultValue=false)]
        public string ExchangeCode { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockExchangeDetail {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ExchangeCode: ").Append(ExchangeCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StockExchangeDetail);
        }

        /// <summary>
        /// Returns true if StockExchangeDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of StockExchangeDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockExchangeDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.ExchangeCode == input.ExchangeCode ||
                    (this.ExchangeCode != null &&
                    this.ExchangeCode.Equals(input.ExchangeCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.ExchangeCode != null)
                    hashCode = hashCode * 59 + this.ExchangeCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}