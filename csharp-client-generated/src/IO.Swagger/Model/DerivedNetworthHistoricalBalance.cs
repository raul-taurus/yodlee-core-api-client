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
    /// DerivedNetworthHistoricalBalance
    /// </summary>
    [DataContract]
        public partial class DerivedNetworthHistoricalBalance :  IEquatable<DerivedNetworthHistoricalBalance>, IValidatableObject
    {
        /// <summary>
        /// The source of balance information.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The source of balance information.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DataSourceTypeEnum
        {
            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 1,
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2,
            /// <summary>
            /// Enum CF for value: CF
            /// </summary>
            [EnumMember(Value = "CF")]
            CF = 3        }
        /// <summary>
        /// The source of balance information.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The source of balance information.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name="dataSourceType", EmitDefaultValue=false)]
        public DataSourceTypeEnum? DataSourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedNetworthHistoricalBalance" /> class.
        /// </summary>
        /// <param name="balance">balance.</param>
        public DerivedNetworthHistoricalBalance(Money balance = default(Money))
        {
            this.Balance = balance;
        }
        
        /// <summary>
        /// Date for which the account balance was provided.  This balance could be a carryforward, calculated or a scraped balance. AdditIonal Details: scraped: Balance shown in the provider site. This balance gets stored in Yodlee system during system/user account updates. carryForward : Balance carried forward from the scraped balance to the days for which the balance was not available in the system. Balance may not be available for all the days in the system due to MFA information required, error in the site, credential changes, etc. calculated: Balances that gets calculated for the days that are prior to the account added date.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;li&gt;GET derived/networth&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Date for which the account balance was provided.  This balance could be a carryforward, calculated or a scraped balance. AdditIonal Details: scraped: Balance shown in the provider site. This balance gets stored in Yodlee system during system/user account updates. carryForward : Balance carried forward from the scraped balance to the days for which the balance was not available in the system. Balance may not be available for all the days in the system due to MFA information required, error in the site, credential changes, etc. calculated: Balances that gets calculated for the days that are prior to the account added date.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;li&gt;GET derived/networth&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; private set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; private set; }

        /// <summary>
        /// Indicates whether the balance is an asset or liability.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Indicates whether the balance is an asset or liability.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="isAsset", EmitDefaultValue=false)]
        public bool? IsAsset { get; private set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public Money Balance { get; set; }

        /// <summary>
        /// Date as of when the balance is last  updated due to the auto account updates or user triggered updates. This balance will be carry forward for the days where there is no balance available in the system. &lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Date as of when the balance is last  updated due to the auto account updates or user triggered updates. This balance will be carry forward for the days where there is no balance available in the system. &lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated and Manual&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, realEstate, loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts/historicalBalances&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="asOfDate", EmitDefaultValue=false)]
        public string AsOfDate { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DerivedNetworthHistoricalBalance {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  IsAsset: ").Append(IsAsset).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  DataSourceType: ").Append(DataSourceType).Append("\n");
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
            return this.Equals(input as DerivedNetworthHistoricalBalance);
        }

        /// <summary>
        /// Returns true if DerivedNetworthHistoricalBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of DerivedNetworthHistoricalBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DerivedNetworthHistoricalBalance input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.IsAsset == input.IsAsset ||
                    (this.IsAsset != null &&
                    this.IsAsset.Equals(input.IsAsset))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.DataSourceType == input.DataSourceType ||
                    (this.DataSourceType != null &&
                    this.DataSourceType.Equals(input.DataSourceType))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.IsAsset != null)
                    hashCode = hashCode * 59 + this.IsAsset.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.AsOfDate != null)
                    hashCode = hashCode * 59 + this.AsOfDate.GetHashCode();
                if (this.DataSourceType != null)
                    hashCode = hashCode * 59 + this.DataSourceType.GetHashCode();
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