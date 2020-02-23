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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest" /> class.
        /// </summary>
        /// <param name="kezsEquipmentGroupCardId">Id grupy zebranego sprzętu.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="wasteMass">Masa odpadów.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest(Guid? kezsEquipmentGroupCardId = default(Guid?), int? wasteCodeId = default(int?), double? wasteMass = default(double?))
        {
            this.KezsEquipmentGroupCardId = kezsEquipmentGroupCardId;
            this.WasteCodeId = wasteCodeId;
            this.WasteMass = wasteMass;
        }
        
        /// <summary>
        /// Id grupy zebranego sprzętu
        /// </summary>
        /// <value>Id grupy zebranego sprzętu</value>
        [DataMember(Name="kezsEquipmentGroupCardId", EmitDefaultValue=false)]
        public Guid? KezsEquipmentGroupCardId { get; set; }

        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// Masa odpadów
        /// </summary>
        /// <value>Masa odpadów</value>
        [DataMember(Name="wasteMass", EmitDefaultValue=false)]
        public double? WasteMass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest {\n");
            sb.Append("  KezsEquipmentGroupCardId: ").Append(KezsEquipmentGroupCardId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsStockWasteMassGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KezsEquipmentGroupCardId == input.KezsEquipmentGroupCardId ||
                    (this.KezsEquipmentGroupCardId != null &&
                    this.KezsEquipmentGroupCardId.Equals(input.KezsEquipmentGroupCardId))
                ) && 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.WasteMass == input.WasteMass ||
                    (this.WasteMass != null &&
                    this.WasteMass.Equals(input.WasteMass))
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
                if (this.KezsEquipmentGroupCardId != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentGroupCardId.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
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
