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
    /// VerifyTransactionCriteria
    /// </summary>
    [DataContract]
        public partial class VerifyTransactionCriteria :  IEquatable<VerifyTransactionCriteria>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the criteria is matched or not. &lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates if the criteria is matched or not. &lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MatchedEnum
        {
            /// <summary>
            /// Enum COMPLETE for value: COMPLETE
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE = 1,
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 2        }
        /// <summary>
        /// Indicates if the criteria is matched or not. &lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates if the criteria is matched or not. &lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name="matched", EmitDefaultValue=false)]
        public MatchedEnum? Matched { get; set; }
        /// <summary>
        /// Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BaseTypeEnum
        {
            /// <summary>
            /// Enum CREDIT for value: CREDIT
            /// </summary>
            [EnumMember(Value = "CREDIT")]
            CREDIT = 1,
            /// <summary>
            /// Enum DEBIT for value: DEBIT
            /// </summary>
            [EnumMember(Value = "DEBIT")]
            DEBIT = 2        }
        /// <summary>
        /// Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name="baseType", EmitDefaultValue=false)]
        public BaseTypeEnum? BaseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyTransactionCriteria" /> class.
        /// </summary>
        /// <param name="date">date (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="keyword">keyword.</param>
        /// <param name="dateVariance">dateVariance.</param>
        /// <param name="baseType">Indicates if the transaction appears as a debit or a credit transaction in the account. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;.</param>
        public VerifyTransactionCriteria(string date = default(string), double? amount = default(double?), string keyword = default(string), string dateVariance = default(string), BaseTypeEnum? baseType = default(BaseTypeEnum?))
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for VerifyTransactionCriteria and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for VerifyTransactionCriteria and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.Keyword = keyword;
            this.DateVariance = dateVariance;
            this.BaseType = baseType;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedTransaction
        /// </summary>
        [DataMember(Name="verifiedTransaction", EmitDefaultValue=false)]
        public List<Transaction> VerifiedTransaction { get; private set; }


        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name="keyword", EmitDefaultValue=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Gets or Sets DateVariance
        /// </summary>
        [DataMember(Name="dateVariance", EmitDefaultValue=false)]
        public string DateVariance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyTransactionCriteria {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  VerifiedTransaction: ").Append(VerifiedTransaction).Append("\n");
            sb.Append("  Matched: ").Append(Matched).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  DateVariance: ").Append(DateVariance).Append("\n");
            sb.Append("  BaseType: ").Append(BaseType).Append("\n");
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
            return this.Equals(input as VerifyTransactionCriteria);
        }

        /// <summary>
        /// Returns true if VerifyTransactionCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyTransactionCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyTransactionCriteria input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.VerifiedTransaction == input.VerifiedTransaction ||
                    this.VerifiedTransaction != null &&
                    input.VerifiedTransaction != null &&
                    this.VerifiedTransaction.SequenceEqual(input.VerifiedTransaction)
                ) && 
                (
                    this.Matched == input.Matched ||
                    (this.Matched != null &&
                    this.Matched.Equals(input.Matched))
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.DateVariance == input.DateVariance ||
                    (this.DateVariance != null &&
                    this.DateVariance.Equals(input.DateVariance))
                ) && 
                (
                    this.BaseType == input.BaseType ||
                    (this.BaseType != null &&
                    this.BaseType.Equals(input.BaseType))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.VerifiedTransaction != null)
                    hashCode = hashCode * 59 + this.VerifiedTransaction.GetHashCode();
                if (this.Matched != null)
                    hashCode = hashCode * 59 + this.Matched.GetHashCode();
                if (this.Keyword != null)
                    hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.DateVariance != null)
                    hashCode = hashCode * 59 + this.DateVariance.GetHashCode();
                if (this.BaseType != null)
                    hashCode = hashCode * 59 + this.BaseType.GetHashCode();
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
