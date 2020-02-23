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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest" /> class.
        /// </summary>
        /// <param name="dismantleProcessedWasteid">Prowadzący stację demontażu - Przetwarzne odpady.</param>
        /// <param name="dismantleProcessedWasteId">dismantleProcessedWasteId.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest(Guid? dismantleProcessedWasteid = default(Guid?), Guid? dismantleProcessedWasteId = default(Guid?))
        {
            this.DismantleProcessedWasteid = dismantleProcessedWasteid;
            this.DismantleProcessedWasteId = dismantleProcessedWasteId;
        }
        
        /// <summary>
        /// Prowadzący stację demontażu - Przetwarzne odpady
        /// </summary>
        /// <value>Prowadzący stację demontażu - Przetwarzne odpady</value>
        [DataMember(Name="dismantleProcessedWasteid", EmitDefaultValue=false)]
        public Guid? DismantleProcessedWasteid { get; set; }

        /// <summary>
        /// Gets or Sets DismantleProcessedWasteId
        /// </summary>
        [DataMember(Name="dismantleProcessedWasteId", EmitDefaultValue=false)]
        public Guid? DismantleProcessedWasteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest {\n");
            sb.Append("  DismantleProcessedWasteid: ").Append(DismantleProcessedWasteid).Append("\n");
            sb.Append("  DismantleProcessedWasteId: ").Append(DismantleProcessedWasteId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1DeleteDismantleProcessedWasteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DismantleProcessedWasteid == input.DismantleProcessedWasteid ||
                    (this.DismantleProcessedWasteid != null &&
                    this.DismantleProcessedWasteid.Equals(input.DismantleProcessedWasteid))
                ) && 
                (
                    this.DismantleProcessedWasteId == input.DismantleProcessedWasteId ||
                    (this.DismantleProcessedWasteId != null &&
                    this.DismantleProcessedWasteId.Equals(input.DismantleProcessedWasteId))
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
                if (this.DismantleProcessedWasteid != null)
                    hashCode = hashCode * 59 + this.DismantleProcessedWasteid.GetHashCode();
                if (this.DismantleProcessedWasteId != null)
                    hashCode = hashCode * 59 + this.DismantleProcessedWasteId.GetHashCode();
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
