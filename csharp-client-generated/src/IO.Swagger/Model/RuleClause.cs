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
    /// RuleClause
    /// </summary>
    [DataContract]
        public partial class RuleClause :  IEquatable<RuleClause>, IValidatableObject
    {
        /// <summary>
        /// Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FieldEnum
        {
            /// <summary>
            /// Enum Amount for value: amount
            /// </summary>
            [EnumMember(Value = "amount")]
            Amount = 1,
            /// <summary>
            /// Enum Description for value: description
            /// </summary>
            [EnumMember(Value = "description")]
            Description = 2        }
        /// <summary>
        /// Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OperationEnum
        {
            /// <summary>
            /// Enum NumberEquals for value: numberEquals
            /// </summary>
            [EnumMember(Value = "numberEquals")]
            NumberEquals = 1,
            /// <summary>
            /// Enum NumberLessThan for value: numberLessThan
            /// </summary>
            [EnumMember(Value = "numberLessThan")]
            NumberLessThan = 2,
            /// <summary>
            /// Enum NumberLessThanEquals for value: numberLessThanEquals
            /// </summary>
            [EnumMember(Value = "numberLessThanEquals")]
            NumberLessThanEquals = 3,
            /// <summary>
            /// Enum NumberGreaterThan for value: numberGreaterThan
            /// </summary>
            [EnumMember(Value = "numberGreaterThan")]
            NumberGreaterThan = 4,
            /// <summary>
            /// Enum NumberGreaterThanEquals for value: numberGreaterThanEquals
            /// </summary>
            [EnumMember(Value = "numberGreaterThanEquals")]
            NumberGreaterThanEquals = 5,
            /// <summary>
            /// Enum StringEquals for value: stringEquals
            /// </summary>
            [EnumMember(Value = "stringEquals")]
            StringEquals = 6,
            /// <summary>
            /// Enum StringContains for value: stringContains
            /// </summary>
            [EnumMember(Value = "stringContains")]
            StringContains = 7        }
        /// <summary>
        /// Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleClause" /> class.
        /// </summary>
        public RuleClause()
        {
        }
        

        /// <summary>
        /// Unique identifier generated for every rule the user creates.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Unique identifier generated for every rule the user creates.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [DataMember(Name="userDefinedRuleId", EmitDefaultValue=false)]
        public long? UserDefinedRuleId { get; private set; }

        /// <summary>
        /// The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [DataMember(Name="fieldValue", EmitDefaultValue=false)]
        public string FieldValue { get; private set; }


        /// <summary>
        /// Unique identifier generated for the rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;
        /// </summary>
        /// <value>Unique identifier generated for the rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;</value>
        [DataMember(Name="ruleClauseId", EmitDefaultValue=false)]
        public long? RuleClauseId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleClause {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  UserDefinedRuleId: ").Append(UserDefinedRuleId).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  RuleClauseId: ").Append(RuleClauseId).Append("\n");
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
            return this.Equals(input as RuleClause);
        }

        /// <summary>
        /// Returns true if RuleClause instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.UserDefinedRuleId == input.UserDefinedRuleId ||
                    (this.UserDefinedRuleId != null &&
                    this.UserDefinedRuleId.Equals(input.UserDefinedRuleId))
                ) && 
                (
                    this.FieldValue == input.FieldValue ||
                    (this.FieldValue != null &&
                    this.FieldValue.Equals(input.FieldValue))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.RuleClauseId == input.RuleClauseId ||
                    (this.RuleClauseId != null &&
                    this.RuleClauseId.Equals(input.RuleClauseId))
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.UserDefinedRuleId != null)
                    hashCode = hashCode * 59 + this.UserDefinedRuleId.GetHashCode();
                if (this.FieldValue != null)
                    hashCode = hashCode * 59 + this.FieldValue.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.RuleClauseId != null)
                    hashCode = hashCode * 59 + this.RuleClauseId.GetHashCode();
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
