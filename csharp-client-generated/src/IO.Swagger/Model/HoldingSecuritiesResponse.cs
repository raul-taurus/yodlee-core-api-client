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
    /// HoldingSecuritiesResponse
    /// </summary>
    [DataContract]
        public partial class HoldingSecuritiesResponse :  IEquatable<HoldingSecuritiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingSecuritiesResponse" /> class.
        /// </summary>
        public HoldingSecuritiesResponse()
        {
        }
        
        /// <summary>
        /// Gets or Sets Holding
        /// </summary>
        [DataMember(Name="holding", EmitDefaultValue=false)]
        public List<SecurityHolding> Holding { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HoldingSecuritiesResponse {\n");
            sb.Append("  Holding: ").Append(Holding).Append("\n");
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
            return this.Equals(input as HoldingSecuritiesResponse);
        }

        /// <summary>
        /// Returns true if HoldingSecuritiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingSecuritiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingSecuritiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Holding == input.Holding ||
                    this.Holding != null &&
                    input.Holding != null &&
                    this.Holding.SequenceEqual(input.Holding)
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
                if (this.Holding != null)
                    hashCode = hashCode * 59 + this.Holding.GetHashCode();
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
