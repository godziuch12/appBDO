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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto" /> class.
        /// </summary>
        /// <param name="kezsEquipmentGroupId">kezsEquipmentGroupId.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="codeName">codeName.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto(int? kezsEquipmentGroupId = default(int?), string name = default(string), string description = default(string), string codeName = default(string))
        {
            this.KezsEquipmentGroupId = kezsEquipmentGroupId;
            this.Name = name;
            this.Description = description;
            this.CodeName = codeName;
        }
        
        /// <summary>
        /// Gets or Sets KezsEquipmentGroupId
        /// </summary>
        [DataMember(Name="kezsEquipmentGroupId", EmitDefaultValue=false)]
        public int? KezsEquipmentGroupId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CodeName
        /// </summary>
        [DataMember(Name="codeName", EmitDefaultValue=false)]
        public string CodeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto {\n");
            sb.Append("  KezsEquipmentGroupId: ").Append(KezsEquipmentGroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CodeName: ").Append(CodeName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1KezsEquipmentGroupDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KezsEquipmentGroupId == input.KezsEquipmentGroupId ||
                    (this.KezsEquipmentGroupId != null &&
                    this.KezsEquipmentGroupId.Equals(input.KezsEquipmentGroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CodeName == input.CodeName ||
                    (this.CodeName != null &&
                    this.CodeName.Equals(input.CodeName))
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
                if (this.KezsEquipmentGroupId != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentGroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CodeName != null)
                    hashCode = hashCode * 59 + this.CodeName.GetHashCode();
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
