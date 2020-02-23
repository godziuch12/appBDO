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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest" /> class.
        /// </summary>
        /// <param name="kpoId">Id karty przekazania odpadów.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest(Guid? kpoId = default(Guid?))
        {
            this.KpoId = kpoId;
        }
        
        /// <summary>
        /// Id karty przekazania odpadów
        /// </summary>
        /// <value>Id karty przekazania odpadów</value>
        [DataMember(Name="kpoId", EmitDefaultValue=false)]
        public Guid? KpoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest {\n");
            sb.Append("  KpoId: ").Append(KpoId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1ChangeKpoStatusToTransportConfirmationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KpoId == input.KpoId ||
                    (this.KpoId != null &&
                    this.KpoId.Equals(input.KpoId))
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
                if (this.KpoId != null)
                    hashCode = hashCode * 59 + this.KpoId.GetHashCode();
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
