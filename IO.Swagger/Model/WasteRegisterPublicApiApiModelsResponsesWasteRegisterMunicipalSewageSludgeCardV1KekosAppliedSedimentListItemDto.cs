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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto" /> class.
        /// </summary>
        /// <param name="kekosAppliedSedimentId">Id wpisu Zastosowane osady.</param>
        /// <param name="sludgeApplicationDate">Data zastosowania komunalnych osadów ściekowych.</param>
        /// <param name="batchNumber">batchNumber.</param>
        /// <param name="appliedSludgeMass">Masa zastosowanych komunalnych osadów ściekowych.</param>
        /// <param name="appliedSludgeDryMatterMass">Sucha masa zastosowanych komunalnych osadów ściekowych.</param>
        /// <param name="isApplicationPurposeCrops">Cel: w rolnictwie.</param>
        /// <param name="isApplicationPurposePlants">Cel: do uprawy roślin przeznaczonych do produkcji kompostu.</param>
        /// <param name="isApplicationPurposeInediblePlants">Cel: do uprawy roślin nieprzeznaczonych do spożycia i produkcji pasz.</param>
        /// <param name="isApplicationPurposeReclamation">Cel: do rekultywacji terenów w tym gruntów na cele rolne.</param>
        /// <param name="isApplicationPurposeLandAdjustment">Cel: przy dostosowywaniu gruntów do określonych potrzeb wynikających z planów gospodarki odpadami(..).</param>
        /// <param name="kekosLandSurfaceRuler">kekosLandSurfaceRuler.</param>
        /// <param name="createdByUserFirstNameAndLastName">Imię i nazwisko użytkownika tworzącego kartę.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto(Guid? kekosAppliedSedimentId = default(Guid?), DateTime? sludgeApplicationDate = default(DateTime?), string batchNumber = default(string), double? appliedSludgeMass = default(double?), double? appliedSludgeDryMatterMass = default(double?), bool? isApplicationPurposeCrops = default(bool?), bool? isApplicationPurposePlants = default(bool?), bool? isApplicationPurposeInediblePlants = default(bool?), bool? isApplicationPurposeReclamation = default(bool?), bool? isApplicationPurposeLandAdjustment = default(bool?), string kekosLandSurfaceRuler = default(string), string createdByUserFirstNameAndLastName = default(string))
        {
            this.KekosAppliedSedimentId = kekosAppliedSedimentId;
            this.SludgeApplicationDate = sludgeApplicationDate;
            this.BatchNumber = batchNumber;
            this.AppliedSludgeMass = appliedSludgeMass;
            this.AppliedSludgeDryMatterMass = appliedSludgeDryMatterMass;
            this.IsApplicationPurposeCrops = isApplicationPurposeCrops;
            this.IsApplicationPurposePlants = isApplicationPurposePlants;
            this.IsApplicationPurposeInediblePlants = isApplicationPurposeInediblePlants;
            this.IsApplicationPurposeReclamation = isApplicationPurposeReclamation;
            this.IsApplicationPurposeLandAdjustment = isApplicationPurposeLandAdjustment;
            this.KekosLandSurfaceRuler = kekosLandSurfaceRuler;
            this.CreatedByUserFirstNameAndLastName = createdByUserFirstNameAndLastName;
        }
        
        /// <summary>
        /// Id wpisu Zastosowane osady
        /// </summary>
        /// <value>Id wpisu Zastosowane osady</value>
        [DataMember(Name="kekosAppliedSedimentId", EmitDefaultValue=false)]
        public Guid? KekosAppliedSedimentId { get; set; }

        /// <summary>
        /// Data zastosowania komunalnych osadów ściekowych
        /// </summary>
        /// <value>Data zastosowania komunalnych osadów ściekowych</value>
        [DataMember(Name="sludgeApplicationDate", EmitDefaultValue=false)]
        public DateTime? SludgeApplicationDate { get; set; }

        /// <summary>
        /// Gets or Sets BatchNumber
        /// </summary>
        [DataMember(Name="batchNumber", EmitDefaultValue=false)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Masa zastosowanych komunalnych osadów ściekowych
        /// </summary>
        /// <value>Masa zastosowanych komunalnych osadów ściekowych</value>
        [DataMember(Name="appliedSludgeMass", EmitDefaultValue=false)]
        public double? AppliedSludgeMass { get; set; }

        /// <summary>
        /// Sucha masa zastosowanych komunalnych osadów ściekowych
        /// </summary>
        /// <value>Sucha masa zastosowanych komunalnych osadów ściekowych</value>
        [DataMember(Name="appliedSludgeDryMatterMass", EmitDefaultValue=false)]
        public double? AppliedSludgeDryMatterMass { get; set; }

        /// <summary>
        /// Cel: w rolnictwie
        /// </summary>
        /// <value>Cel: w rolnictwie</value>
        [DataMember(Name="isApplicationPurposeCrops", EmitDefaultValue=false)]
        public bool? IsApplicationPurposeCrops { get; set; }

        /// <summary>
        /// Cel: do uprawy roślin przeznaczonych do produkcji kompostu
        /// </summary>
        /// <value>Cel: do uprawy roślin przeznaczonych do produkcji kompostu</value>
        [DataMember(Name="isApplicationPurposePlants", EmitDefaultValue=false)]
        public bool? IsApplicationPurposePlants { get; set; }

        /// <summary>
        /// Cel: do uprawy roślin nieprzeznaczonych do spożycia i produkcji pasz
        /// </summary>
        /// <value>Cel: do uprawy roślin nieprzeznaczonych do spożycia i produkcji pasz</value>
        [DataMember(Name="isApplicationPurposeInediblePlants", EmitDefaultValue=false)]
        public bool? IsApplicationPurposeInediblePlants { get; set; }

        /// <summary>
        /// Cel: do rekultywacji terenów w tym gruntów na cele rolne
        /// </summary>
        /// <value>Cel: do rekultywacji terenów w tym gruntów na cele rolne</value>
        [DataMember(Name="isApplicationPurposeReclamation", EmitDefaultValue=false)]
        public bool? IsApplicationPurposeReclamation { get; set; }

        /// <summary>
        /// Cel: przy dostosowywaniu gruntów do określonych potrzeb wynikających z planów gospodarki odpadami(..)
        /// </summary>
        /// <value>Cel: przy dostosowywaniu gruntów do określonych potrzeb wynikających z planów gospodarki odpadami(..)</value>
        [DataMember(Name="isApplicationPurposeLandAdjustment", EmitDefaultValue=false)]
        public bool? IsApplicationPurposeLandAdjustment { get; set; }

        /// <summary>
        /// Gets or Sets KekosLandSurfaceRuler
        /// </summary>
        [DataMember(Name="kekosLandSurfaceRuler", EmitDefaultValue=false)]
        public string KekosLandSurfaceRuler { get; set; }

        /// <summary>
        /// Imię i nazwisko użytkownika tworzącego kartę
        /// </summary>
        /// <value>Imię i nazwisko użytkownika tworzącego kartę</value>
        [DataMember(Name="createdByUserFirstNameAndLastName", EmitDefaultValue=false)]
        public string CreatedByUserFirstNameAndLastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto {\n");
            sb.Append("  KekosAppliedSedimentId: ").Append(KekosAppliedSedimentId).Append("\n");
            sb.Append("  SludgeApplicationDate: ").Append(SludgeApplicationDate).Append("\n");
            sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
            sb.Append("  AppliedSludgeMass: ").Append(AppliedSludgeMass).Append("\n");
            sb.Append("  AppliedSludgeDryMatterMass: ").Append(AppliedSludgeDryMatterMass).Append("\n");
            sb.Append("  IsApplicationPurposeCrops: ").Append(IsApplicationPurposeCrops).Append("\n");
            sb.Append("  IsApplicationPurposePlants: ").Append(IsApplicationPurposePlants).Append("\n");
            sb.Append("  IsApplicationPurposeInediblePlants: ").Append(IsApplicationPurposeInediblePlants).Append("\n");
            sb.Append("  IsApplicationPurposeReclamation: ").Append(IsApplicationPurposeReclamation).Append("\n");
            sb.Append("  IsApplicationPurposeLandAdjustment: ").Append(IsApplicationPurposeLandAdjustment).Append("\n");
            sb.Append("  KekosLandSurfaceRuler: ").Append(KekosLandSurfaceRuler).Append("\n");
            sb.Append("  CreatedByUserFirstNameAndLastName: ").Append(CreatedByUserFirstNameAndLastName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosAppliedSedimentListItemDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KekosAppliedSedimentId == input.KekosAppliedSedimentId ||
                    (this.KekosAppliedSedimentId != null &&
                    this.KekosAppliedSedimentId.Equals(input.KekosAppliedSedimentId))
                ) && 
                (
                    this.SludgeApplicationDate == input.SludgeApplicationDate ||
                    (this.SludgeApplicationDate != null &&
                    this.SludgeApplicationDate.Equals(input.SludgeApplicationDate))
                ) && 
                (
                    this.BatchNumber == input.BatchNumber ||
                    (this.BatchNumber != null &&
                    this.BatchNumber.Equals(input.BatchNumber))
                ) && 
                (
                    this.AppliedSludgeMass == input.AppliedSludgeMass ||
                    (this.AppliedSludgeMass != null &&
                    this.AppliedSludgeMass.Equals(input.AppliedSludgeMass))
                ) && 
                (
                    this.AppliedSludgeDryMatterMass == input.AppliedSludgeDryMatterMass ||
                    (this.AppliedSludgeDryMatterMass != null &&
                    this.AppliedSludgeDryMatterMass.Equals(input.AppliedSludgeDryMatterMass))
                ) && 
                (
                    this.IsApplicationPurposeCrops == input.IsApplicationPurposeCrops ||
                    (this.IsApplicationPurposeCrops != null &&
                    this.IsApplicationPurposeCrops.Equals(input.IsApplicationPurposeCrops))
                ) && 
                (
                    this.IsApplicationPurposePlants == input.IsApplicationPurposePlants ||
                    (this.IsApplicationPurposePlants != null &&
                    this.IsApplicationPurposePlants.Equals(input.IsApplicationPurposePlants))
                ) && 
                (
                    this.IsApplicationPurposeInediblePlants == input.IsApplicationPurposeInediblePlants ||
                    (this.IsApplicationPurposeInediblePlants != null &&
                    this.IsApplicationPurposeInediblePlants.Equals(input.IsApplicationPurposeInediblePlants))
                ) && 
                (
                    this.IsApplicationPurposeReclamation == input.IsApplicationPurposeReclamation ||
                    (this.IsApplicationPurposeReclamation != null &&
                    this.IsApplicationPurposeReclamation.Equals(input.IsApplicationPurposeReclamation))
                ) && 
                (
                    this.IsApplicationPurposeLandAdjustment == input.IsApplicationPurposeLandAdjustment ||
                    (this.IsApplicationPurposeLandAdjustment != null &&
                    this.IsApplicationPurposeLandAdjustment.Equals(input.IsApplicationPurposeLandAdjustment))
                ) && 
                (
                    this.KekosLandSurfaceRuler == input.KekosLandSurfaceRuler ||
                    (this.KekosLandSurfaceRuler != null &&
                    this.KekosLandSurfaceRuler.Equals(input.KekosLandSurfaceRuler))
                ) && 
                (
                    this.CreatedByUserFirstNameAndLastName == input.CreatedByUserFirstNameAndLastName ||
                    (this.CreatedByUserFirstNameAndLastName != null &&
                    this.CreatedByUserFirstNameAndLastName.Equals(input.CreatedByUserFirstNameAndLastName))
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
                if (this.KekosAppliedSedimentId != null)
                    hashCode = hashCode * 59 + this.KekosAppliedSedimentId.GetHashCode();
                if (this.SludgeApplicationDate != null)
                    hashCode = hashCode * 59 + this.SludgeApplicationDate.GetHashCode();
                if (this.BatchNumber != null)
                    hashCode = hashCode * 59 + this.BatchNumber.GetHashCode();
                if (this.AppliedSludgeMass != null)
                    hashCode = hashCode * 59 + this.AppliedSludgeMass.GetHashCode();
                if (this.AppliedSludgeDryMatterMass != null)
                    hashCode = hashCode * 59 + this.AppliedSludgeDryMatterMass.GetHashCode();
                if (this.IsApplicationPurposeCrops != null)
                    hashCode = hashCode * 59 + this.IsApplicationPurposeCrops.GetHashCode();
                if (this.IsApplicationPurposePlants != null)
                    hashCode = hashCode * 59 + this.IsApplicationPurposePlants.GetHashCode();
                if (this.IsApplicationPurposeInediblePlants != null)
                    hashCode = hashCode * 59 + this.IsApplicationPurposeInediblePlants.GetHashCode();
                if (this.IsApplicationPurposeReclamation != null)
                    hashCode = hashCode * 59 + this.IsApplicationPurposeReclamation.GetHashCode();
                if (this.IsApplicationPurposeLandAdjustment != null)
                    hashCode = hashCode * 59 + this.IsApplicationPurposeLandAdjustment.GetHashCode();
                if (this.KekosLandSurfaceRuler != null)
                    hashCode = hashCode * 59 + this.KekosLandSurfaceRuler.GetHashCode();
                if (this.CreatedByUserFirstNameAndLastName != null)
                    hashCode = hashCode * 59 + this.CreatedByUserFirstNameAndLastName.GetHashCode();
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
