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
    /// ProviderAccountPreferences
    /// </summary>
    [DataContract]
        public partial class ProviderAccountPreferences :  IEquatable<ProviderAccountPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountPreferences" /> class.
        /// </summary>
        /// <param name="isDataExtractsEnabled">Indicates if the updates to the provider account should be part of the data extracts event notification or the data extract data retrieval service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="linkedProviderAccountId">LinkedproviderAccountd is a providerAccountId linked by the user to the primary provider account. &lt;br&gt;LinkedProviderAccountId and the providerAccountId belongs to the same institution.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;li&gt;GET Provider Accounts&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="isAutoRefreshEnabled">Indicates if auto-refreshes have to be triggered for the provider account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;.</param>
        public ProviderAccountPreferences(bool? isDataExtractsEnabled = default(bool?), long? linkedProviderAccountId = default(long?), bool? isAutoRefreshEnabled = default(bool?))
        {
            this.IsDataExtractsEnabled = isDataExtractsEnabled;
            this.LinkedProviderAccountId = linkedProviderAccountId;
            this.IsAutoRefreshEnabled = isAutoRefreshEnabled;
        }
        
        /// <summary>
        /// Indicates if the updates to the provider account should be part of the data extracts event notification or the data extract data retrieval service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Indicates if the updates to the provider account should be part of the data extracts event notification or the data extract data retrieval service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="isDataExtractsEnabled", EmitDefaultValue=false)]
        public bool? IsDataExtractsEnabled { get; set; }

        /// <summary>
        /// LinkedproviderAccountd is a providerAccountId linked by the user to the primary provider account. &lt;br&gt;LinkedProviderAccountId and the providerAccountId belongs to the same institution.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;li&gt;GET Provider Accounts&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>LinkedproviderAccountd is a providerAccountId linked by the user to the primary provider account. &lt;br&gt;LinkedProviderAccountId and the providerAccountId belongs to the same institution.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;li&gt;GET Provider Accounts&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="linkedProviderAccountId", EmitDefaultValue=false)]
        public long? LinkedProviderAccountId { get; set; }

        /// <summary>
        /// Indicates if auto-refreshes have to be triggered for the provider account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Indicates if auto-refreshes have to be triggered for the provider account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts?include&#x3D;preferences&lt;/li&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}?include&#x3D;preferences&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="isAutoRefreshEnabled", EmitDefaultValue=false)]
        public bool? IsAutoRefreshEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderAccountPreferences {\n");
            sb.Append("  IsDataExtractsEnabled: ").Append(IsDataExtractsEnabled).Append("\n");
            sb.Append("  LinkedProviderAccountId: ").Append(LinkedProviderAccountId).Append("\n");
            sb.Append("  IsAutoRefreshEnabled: ").Append(IsAutoRefreshEnabled).Append("\n");
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
            return this.Equals(input as ProviderAccountPreferences);
        }

        /// <summary>
        /// Returns true if ProviderAccountPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of ProviderAccountPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProviderAccountPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsDataExtractsEnabled == input.IsDataExtractsEnabled ||
                    (this.IsDataExtractsEnabled != null &&
                    this.IsDataExtractsEnabled.Equals(input.IsDataExtractsEnabled))
                ) && 
                (
                    this.LinkedProviderAccountId == input.LinkedProviderAccountId ||
                    (this.LinkedProviderAccountId != null &&
                    this.LinkedProviderAccountId.Equals(input.LinkedProviderAccountId))
                ) && 
                (
                    this.IsAutoRefreshEnabled == input.IsAutoRefreshEnabled ||
                    (this.IsAutoRefreshEnabled != null &&
                    this.IsAutoRefreshEnabled.Equals(input.IsAutoRefreshEnabled))
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
                if (this.IsDataExtractsEnabled != null)
                    hashCode = hashCode * 59 + this.IsDataExtractsEnabled.GetHashCode();
                if (this.LinkedProviderAccountId != null)
                    hashCode = hashCode * 59 + this.LinkedProviderAccountId.GetHashCode();
                if (this.IsAutoRefreshEnabled != null)
                    hashCode = hashCode * 59 + this.IsAutoRefreshEnabled.GetHashCode();
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
