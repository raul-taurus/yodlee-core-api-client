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
    /// CobrandLoginResponse
    /// </summary>
    [DataContract]
        public partial class CobrandLoginResponse :  IEquatable<CobrandLoginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandLoginResponse" /> class.
        /// </summary>
        /// <param name="session">session.</param>
        public CobrandLoginResponse(CobrandSession session = default(CobrandSession))
        {
            this.Session = session;
        }
        
        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public CobrandSession Session { get; set; }

        /// <summary>
        /// Unique identifier of the cobrand (customer) in the system.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Unique identifier of the cobrand (customer) in the system.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="cobrandId", EmitDefaultValue=false)]
        public long? CobrandId { get; private set; }

        /// <summary>
        /// The application identifier.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The application identifier.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; private set; }

        /// <summary>
        /// The customer&#x27;s locale that will be considered for the localization functionality.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The customer&#x27;s locale that will be considered for the localization functionality.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST cobrand/login&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CobrandLoginResponse {\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  CobrandId: ").Append(CobrandId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as CobrandLoginResponse);
        }

        /// <summary>
        /// Returns true if CobrandLoginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CobrandLoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CobrandLoginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.CobrandId == input.CobrandId ||
                    (this.CobrandId != null &&
                    this.CobrandId.Equals(input.CobrandId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.CobrandId != null)
                    hashCode = hashCode * 59 + this.CobrandId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
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
