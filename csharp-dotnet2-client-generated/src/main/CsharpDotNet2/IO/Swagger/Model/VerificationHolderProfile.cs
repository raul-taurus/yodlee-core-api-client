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
  public class VerificationHolderProfile {
    /// <summary>
    /// The primary key of the account resource and the unique identifier for the account
    /// </summary>
    /// <value>The primary key of the account resource and the unique identifier for the account</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public long? AccountId { get; set; }

    /// <summary>
    /// The account holder's address available at the profile and account levels
    /// </summary>
    /// <value>The account holder's address available at the profile and account levels</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public List<AbstractAddress> Address { get; set; }

    /// <summary>
    /// The account holder's phone number available at the profile and account levels
    /// </summary>
    /// <value>The account holder's phone number available at the profile and account levels</value>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public List<PhoneNumber> PhoneNumber { get; set; }

    /// <summary>
    /// The primary key of the provider account resource
    /// </summary>
    /// <value>The primary key of the provider account resource</value>
    [DataMember(Name="providerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerAccountId")]
    public long? ProviderAccountId { get; set; }

    /// <summary>
    /// The holder entity is account-specific and captures the ownership status and the name details of the user
    /// </summary>
    /// <value>The holder entity is account-specific and captures the ownership status and the name details of the user</value>
    [DataMember(Name="holder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holder")]
    public List<VerificationHolder> Holder { get; set; }

    /// <summary>
    /// The account holder's email ID available at the profile and account levels
    /// </summary>
    /// <value>The account holder's email ID available at the profile and account levels</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public List<Email> Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VerificationHolderProfile {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  ProviderAccountId: ").Append(ProviderAccountId).Append("\n");
      sb.Append("  Holder: ").Append(Holder).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
