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
    /// BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto
    /// </summary>
    [DataContract]
    public partial class BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto :  IEquatable<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto" /> class.
        /// </summary>
        /// <param name="kezsEquipmentGroupCardId">kezsEquipmentGroupCardId.</param>
        /// <param name="kezsEquipmentGroupCodeName">kezsEquipmentGroupCodeName.</param>
        /// <param name="stockMass">stockMass.</param>
        public BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto(Guid? kezsEquipmentGroupCardId = default(Guid?), string kezsEquipmentGroupCodeName = default(string), double? stockMass = default(double?))
        {
            this.KezsEquipmentGroupCardId = kezsEquipmentGroupCardId;
            this.KezsEquipmentGroupCodeName = kezsEquipmentGroupCodeName;
            this.StockMass = stockMass;
        }
        
        /// <summary>
        /// Gets or Sets KezsEquipmentGroupCardId
        /// </summary>
        [DataMember(Name="kezsEquipmentGroupCardId", EmitDefaultValue=false)]
        public Guid? KezsEquipmentGroupCardId { get; set; }

        /// <summary>
        /// Gets or Sets KezsEquipmentGroupCodeName
        /// </summary>
        [DataMember(Name="kezsEquipmentGroupCodeName", EmitDefaultValue=false)]
        public string KezsEquipmentGroupCodeName { get; set; }

        /// <summary>
        /// Gets or Sets StockMass
        /// </summary>
        [DataMember(Name="stockMass", EmitDefaultValue=false)]
        public double? StockMass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto {\n");
            sb.Append("  KezsEquipmentGroupCardId: ").Append(KezsEquipmentGroupCardId).Append("\n");
            sb.Append("  KezsEquipmentGroupCodeName: ").Append(KezsEquipmentGroupCodeName).Append("\n");
            sb.Append("  StockMass: ").Append(StockMass).Append("\n");
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
            return this.Equals(input as BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto);
        }

        /// <summary>
        /// Returns true if BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto input)
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
                    this.KezsEquipmentGroupCodeName == input.KezsEquipmentGroupCodeName ||
                    (this.KezsEquipmentGroupCodeName != null &&
                    this.KezsEquipmentGroupCodeName.Equals(input.KezsEquipmentGroupCodeName))
                ) && 
                (
                    this.StockMass == input.StockMass ||
                    (this.StockMass != null &&
                    this.StockMass.Equals(input.StockMass))
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
                if (this.KezsEquipmentGroupCodeName != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentGroupCodeName.GetHashCode();
                if (this.StockMass != null)
                    hashCode = hashCode * 59 + this.StockMass.GetHashCode();
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
