/* 
 * v1 Waste Register public Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest" /> class.
        /// </summary>
        /// <param name="kpokId">Id Karty Przekazania Odpadów Komunalnych.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest(Guid? kpokId = default(Guid?))
        {
            this.KpokId = kpokId;
        }
        
        /// <summary>
        /// Id Karty Przekazania Odpadów Komunalnych
        /// </summary>
        /// <value>Id Karty Przekazania Odpadów Komunalnych</value>
        [DataMember(Name="kpokId", EmitDefaultValue=false)]
        public Guid? KpokId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest {\n");
            sb.Append("  KpokId: ").Append(KpokId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardV1PromoteKpokToConfirmationGeneratedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KpokId == input.KpokId ||
                    (this.KpokId != null &&
                    this.KpokId.Equals(input.KpokId))
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
                if (this.KpokId != null)
                    hashCode = hashCode * 59 + this.KpokId.GetHashCode();
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
