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
    /// CobrandLoginRequest
    /// </summary>
    [DataContract]
        public partial class CobrandLoginRequest :  IEquatable<CobrandLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandLoginRequest" /> class.
        /// </summary>
        /// <param name="cobrand">cobrand (required).</param>
        public CobrandLoginRequest(Cobrand cobrand = default(Cobrand))
        {
            // to ensure "cobrand" is required (not null)
            if (cobrand == null)
            {
                throw new InvalidDataException("cobrand is a required property for CobrandLoginRequest and cannot be null");
            }
            else
            {
                this.Cobrand = cobrand;
            }
        }
        
        /// <summary>
        /// Gets or Sets Cobrand
        /// </summary>
        [DataMember(Name="cobrand", EmitDefaultValue=false)]
        public Cobrand Cobrand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CobrandLoginRequest {\n");
            sb.Append("  Cobrand: ").Append(Cobrand).Append("\n");
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
            return this.Equals(input as CobrandLoginRequest);
        }

        /// <summary>
        /// Returns true if CobrandLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CobrandLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CobrandLoginRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cobrand == input.Cobrand ||
                    (this.Cobrand != null &&
                    this.Cobrand.Equals(input.Cobrand))
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
                if (this.Cobrand != null)
                    hashCode = hashCode * 59 + this.Cobrand.GetHashCode();
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
