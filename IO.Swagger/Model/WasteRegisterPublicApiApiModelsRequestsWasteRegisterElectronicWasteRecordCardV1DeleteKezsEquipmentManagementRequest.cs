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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest" /> class.
        /// </summary>
        /// <param name="kezsEquipmentManagementId">Id wpisu Gospodarowanie sprzętem.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest(Guid? kezsEquipmentManagementId = default(Guid?))
        {
            this.KezsEquipmentManagementId = kezsEquipmentManagementId;
        }
        
        /// <summary>
        /// Id wpisu Gospodarowanie sprzętem
        /// </summary>
        /// <value>Id wpisu Gospodarowanie sprzętem</value>
        [DataMember(Name="kezsEquipmentManagementId", EmitDefaultValue=false)]
        public Guid? KezsEquipmentManagementId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest {\n");
            sb.Append("  KezsEquipmentManagementId: ").Append(KezsEquipmentManagementId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsEquipmentManagementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KezsEquipmentManagementId == input.KezsEquipmentManagementId ||
                    (this.KezsEquipmentManagementId != null &&
                    this.KezsEquipmentManagementId.Equals(input.KezsEquipmentManagementId))
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
                if (this.KezsEquipmentManagementId != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentManagementId.GetHashCode();
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
