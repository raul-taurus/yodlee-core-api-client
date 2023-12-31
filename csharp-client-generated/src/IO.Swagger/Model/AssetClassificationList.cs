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
    /// AssetClassificationList
    /// </summary>
    [DataContract]
        public partial class AssetClassificationList :  IEquatable<AssetClassificationList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetClassificationList" /> class.
        /// </summary>
        public AssetClassificationList()
        {
        }
        
        /// <summary>
        /// The type of classification to which the investment belongs (assetClass, country, sector, and style).&lt;br&gt;&lt;b&gt;Required Feature Enablement&lt;/b&gt;: Asset classification feature&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt;
        /// </summary>
        /// <value>The type of classification to which the investment belongs (assetClass, country, sector, and style).&lt;br&gt;&lt;b&gt;Required Feature Enablement&lt;/b&gt;: Asset classification feature&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt;</value>
        [DataMember(Name="classificationType", EmitDefaultValue=false)]
        public string ClassificationType { get; private set; }

        /// <summary>
        /// The value for each classificationType.&lt;br&gt;&lt;b&gt;Required Feature Enablement&lt;/b&gt;: Asset classification feature&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt;
        /// </summary>
        /// <value>The value for each classificationType.&lt;br&gt;&lt;b&gt;Required Feature Enablement&lt;/b&gt;: Asset classification feature&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt;</value>
        [DataMember(Name="classificationValue", EmitDefaultValue=false)]
        public List<string> ClassificationValue { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetClassificationList {\n");
            sb.Append("  ClassificationType: ").Append(ClassificationType).Append("\n");
            sb.Append("  ClassificationValue: ").Append(ClassificationValue).Append("\n");
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
            return this.Equals(input as AssetClassificationList);
        }

        /// <summary>
        /// Returns true if AssetClassificationList instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetClassificationList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetClassificationList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassificationType == input.ClassificationType ||
                    (this.ClassificationType != null &&
                    this.ClassificationType.Equals(input.ClassificationType))
                ) && 
                (
                    this.ClassificationValue == input.ClassificationValue ||
                    this.ClassificationValue != null &&
                    input.ClassificationValue != null &&
                    this.ClassificationValue.SequenceEqual(input.ClassificationValue)
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
                if (this.ClassificationType != null)
                    hashCode = hashCode * 59 + this.ClassificationType.GetHashCode();
                if (this.ClassificationValue != null)
                    hashCode = hashCode * 59 + this.ClassificationValue.GetHashCode();
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
