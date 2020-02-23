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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse" /> class.
        /// </summary>
        /// <param name="collectingReceivedVehicleId">Id wpisu Prowadzący punkt zbierania pojazdów - Przyjęte.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse(Guid? collectingReceivedVehicleId = default(Guid?))
        {
            this.CollectingReceivedVehicleId = collectingReceivedVehicleId;
        }
        
        /// <summary>
        /// Id wpisu Prowadzący punkt zbierania pojazdów - Przyjęte
        /// </summary>
        /// <value>Id wpisu Prowadzący punkt zbierania pojazdów - Przyjęte</value>
        [DataMember(Name="collectingReceivedVehicleId", EmitDefaultValue=false)]
        public Guid? CollectingReceivedVehicleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse {\n");
            sb.Append("  CollectingReceivedVehicleId: ").Append(CollectingReceivedVehicleId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CreateCollectingReceivedVehicleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectingReceivedVehicleId == input.CollectingReceivedVehicleId ||
                    (this.CollectingReceivedVehicleId != null &&
                    this.CollectingReceivedVehicleId.Equals(input.CollectingReceivedVehicleId))
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
                if (this.CollectingReceivedVehicleId != null)
                    hashCode = hashCode * 59 + this.CollectingReceivedVehicleId.GetHashCode();
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
