/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
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
using SwaggerDateConverter = com.telstra.messaging.Client.SwaggerDateConverter;

namespace com.telstra.messaging.Model
{
    /// <summary>
    /// ProvisionNumberResponse
    /// </summary>
    [DataContract]
    public partial class ProvisionNumberResponse :  IEquatable<ProvisionNumberResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionNumberResponse" /> class.
        /// </summary>
        /// <param name="DestinationAddress">The mobile phone number that was allocated.</param>
        public ProvisionNumberResponse(string DestinationAddress = default(string))
        {
            this.DestinationAddress = DestinationAddress;
        }
        
        /// <summary>
        /// The mobile phone number that was allocated
        /// </summary>
        /// <value>The mobile phone number that was allocated</value>
        [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisionNumberResponse {\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ProvisionNumberResponse);
        }

        /// <summary>
        /// Returns true if ProvisionNumberResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvisionNumberResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvisionNumberResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationAddress == input.DestinationAddress ||
                    (this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(input.DestinationAddress))
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
                if (this.DestinationAddress != null)
                    hashCode = hashCode * 59 + this.DestinationAddress.GetHashCode();
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
