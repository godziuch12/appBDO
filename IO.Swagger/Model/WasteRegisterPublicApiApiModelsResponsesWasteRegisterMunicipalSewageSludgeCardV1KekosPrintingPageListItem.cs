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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem" /> class.
        /// </summary>
        /// <param name="batchNumber">batchNumber.</param>
        /// <param name="createdUserFullName">createdUserFullName.</param>
        /// <param name="dateOfSewageSludgeCreation">Data wytworzenia komunalnych osadów ściekowych.</param>
        /// <param name="isFermentation">Rodzaj obróbki: fermentacja.</param>
        /// <param name="isDrying">Rodzaj obróbki: suszenie.</param>
        /// <param name="isDehydration">Rodzaj obróbki: odwodnienie.</param>
        /// <param name="isComposting">Rodzaj obróbki: kompostowanie.</param>
        /// <param name="isHygienisation">Rodzaj obróbki: higienizacja.</param>
        /// <param name="isDifferentProcess">Rodzaj obróbki: inny.</param>
        /// <param name="differentProcess">Inny proces.</param>
        /// <param name="sludgeMassMg">Masa wytworzonych komunalnych osadów ściekowych [Mg].</param>
        /// <param name="sludgeMassMgSm">Sucha masa wytworzonych komunalnych osadów ściekowych [Mg s.m.].</param>
        /// <param name="appliedSludgeMass">Masa zastosowanych komunalnych osadów ściekowych.</param>
        /// <param name="appliedSludgeDryMatterMass">Sucha masa zastosowanych komunalnych osadów ściekowych.</param>
        /// <param name="kpoCardNumber">Numer karty kpo.</param>
        /// <param name="isApplicationPurposeCrops">Cel: w rolnictwie.</param>
        /// <param name="isApplicationPurposePlants">Cel: do uprawy roślin przeznaczonych do produkcji kompostu.</param>
        /// <param name="isApplicationPurposeInediblePlants">Cel: do uprawy roślin nieprzeznaczonych do spożycia i produkcji pasz.</param>
        /// <param name="isApplicationPurposeReclamation">Cel: do rekultywacji terenów w tym gruntów na cele rolne.</param>
        /// <param name="isApplicationPurposeLandAdjustment">Cel: przy dostosowywaniu gruntów do określonych potrzeb wynikających z planów gospodarki odpadami(..).</param>
        /// <param name="recordingUserFullName">recordingUserFullName.</param>
        /// <param name="sludgeApplicationDate">Data zastosowania komunalnych osadów ściekowych.</param>
        /// <param name="researchCardNumber">researchCardNumber.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem(string batchNumber = default(string), string createdUserFullName = default(string), DateTime? dateOfSewageSludgeCreation = default(DateTime?), bool? isFermentation = default(bool?), bool? isDrying = default(bool?), bool? isDehydration = default(bool?), bool? isComposting = default(bool?), bool? isHygienisation = default(bool?), bool? isDifferentProcess = default(bool?), string differentProcess = default(string), double? sludgeMassMg = default(double?), double? sludgeMassMgSm = default(double?), double? appliedSludgeMass = default(double?), double? appliedSludgeDryMatterMass = default(double?), string kpoCardNumber = default(string), bool? isApplicationPurposeCrops = default(bool?), bool? isApplicationPurposePlants = default(bool?), bool? isApplicationPurposeInediblePlants = default(bool?), bool? isApplicationPurposeReclamation = default(bool?), bool? isApplicationPurposeLandAdjustment = default(bool?), string recordingUserFullName = default(string), DateTime? sludgeApplicationDate = default(DateTime?), string researchCardNumber = default(string))
        {
            this.BatchNumber = batchNumber;
            this.CreatedUserFullName = createdUserFullName;
            this.DateOfSewageSludgeCreation = dateOfSewageSludgeCreation;
            this.IsFermentation = isFermentation;
            this.IsDrying = isDrying;
            this.IsDehydration = isDehydration;
            this.IsComposting = isComposting;
            this.IsHygienisation = isHygienisation;
            this.IsDifferentProcess = isDifferentProcess;
            this.DifferentProcess = differentProcess;
            this.SludgeMassMg = sludgeMassMg;
            this.SludgeMassMgSm = sludgeMassMgSm;
            this.AppliedSludgeMass = appliedSludgeMass;
            this.AppliedSludgeDryMatterMass = appliedSludgeDryMatterMass;
            this.KpoCardNumber = kpoCardNumber;
            this.IsApplicationPurposeCrops = isApplicationPurposeCrops;
            this.IsApplicationPurposePlants = isApplicationPurposePlants;
            this.IsApplicationPurposeInediblePlants = isApplicationPurposeInediblePlants;
            this.IsApplicationPurposeReclamation = isApplicationPurposeReclamation;
            this.IsApplicationPurposeLandAdjustment = isApplicationPurposeLandAdjustment;
            this.RecordingUserFullName = recordingUserFullName;
            this.SludgeApplicationDate = sludgeApplicationDate;
            this.ResearchCardNumber = researchCardNumber;
        }
        
        /// <summary>
        /// Gets or Sets BatchNumber
        /// </summary>
        [DataMember(Name="batchNumber", EmitDefaultValue=false)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreatedUserFullName
        /// </summary>
        [DataMember(Name="createdUserFullName", EmitDefaultValue=false)]
        public string CreatedUserFullName { get; set; }

        /// <summary>
        /// Data wytworzenia komunalnych osadów ściekowych
        /// </summary>
        /// <value>Data wytworzenia komunalnych osadów ściekowych</value>
        [DataMember(Name="dateOfSewageSludgeCreation", EmitDefaultValue=false)]
        public DateTime? DateOfSewageSludgeCreation { get; set; }

        /// <summary>
        /// Rodzaj obróbki: fermentacja
        /// </summary>
        /// <value>Rodzaj obróbki: fermentacja</value>
        [DataMember(Name="isFermentation", EmitDefaultValue=false)]
        public bool? IsFermentation { get; set; }

        /// <summary>
        /// Rodzaj obróbki: suszenie
        /// </summary>
        /// <value>Rodzaj obróbki: suszenie</value>
        [DataMember(Name="isDrying", EmitDefaultValue=false)]
        public bool? IsDrying { get; set; }

        /// <summary>
        /// Rodzaj obróbki: odwodnienie
        /// </summary>
        /// <value>Rodzaj obróbki: odwodnienie</value>
        [DataMember(Name="isDehydration", EmitDefaultValue=false)]
        public bool? IsDehydration { get; set; }

        /// <summary>
        /// Rodzaj obróbki: kompostowanie
        /// </summary>
        /// <value>Rodzaj obróbki: kompostowanie</value>
        [DataMember(Name="isComposting", EmitDefaultValue=false)]
        public bool? IsComposting { get; set; }

        /// <summary>
        /// Rodzaj obróbki: higienizacja
        /// </summary>
        /// <value>Rodzaj obróbki: higienizacja</value>
        [DataMember(Name="isHygienisation", EmitDefaultValue=false)]
        public bool? IsHygienisation { get; set; }

        /// <summary>
        /// Rodzaj obróbki: inny
        /// </summary>
        /// <value>Rodzaj obróbki: inny</value>
        [DataMember(Name="isDifferentProcess", EmitDefaultValue=false)]
        public bool? IsDifferentProcess { get; set; }

        /// <summary>
        /// Inny proces
        /// </summary>
        /// <value>Inny proces</value>
        [DataMember(Name="differentProcess", EmitDefaultValue=false)]
        public string DifferentProcess { get; set; }

        /// <summary>
        /// Masa wytworzonych komunalnych osadów ściekowych [Mg]
        /// </summary>
        /// <value>Masa wytworzonych komunalnych osadów ściekowych [Mg]</value>
        [DataMember(Name="sludgeMassMg", EmitDefaultValue=false)]
        public double? SludgeMassMg { get; set; }

        /// <summary>
        /// Sucha masa wytworzonych komunalnych osadów ściekowych [Mg s.m.]
        /// </summary>
        /// <value>Sucha masa wytworzonych komunalnych osadów ściekowych [Mg s.m.]</value>
        [DataMember(Name="sludgeMassMgSm", EmitDefaultValue=false)]
        public double? SludgeMassMgSm { get; set; }

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
        /// Numer karty kpo
        /// </summary>
        /// <value>Numer karty kpo</value>
        [DataMember(Name="kpoCardNumber", EmitDefaultValue=false)]
        public string KpoCardNumber { get; set; }

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
        /// Gets or Sets RecordingUserFullName
        /// </summary>
        [DataMember(Name="recordingUserFullName", EmitDefaultValue=false)]
        public string RecordingUserFullName { get; set; }

        /// <summary>
        /// Data zastosowania komunalnych osadów ściekowych
        /// </summary>
        /// <value>Data zastosowania komunalnych osadów ściekowych</value>
        [DataMember(Name="sludgeApplicationDate", EmitDefaultValue=false)]
        public DateTime? SludgeApplicationDate { get; set; }

        /// <summary>
        /// Gets or Sets ResearchCardNumber
        /// </summary>
        [DataMember(Name="researchCardNumber", EmitDefaultValue=false)]
        public string ResearchCardNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem {\n");
            sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
            sb.Append("  CreatedUserFullName: ").Append(CreatedUserFullName).Append("\n");
            sb.Append("  DateOfSewageSludgeCreation: ").Append(DateOfSewageSludgeCreation).Append("\n");
            sb.Append("  IsFermentation: ").Append(IsFermentation).Append("\n");
            sb.Append("  IsDrying: ").Append(IsDrying).Append("\n");
            sb.Append("  IsDehydration: ").Append(IsDehydration).Append("\n");
            sb.Append("  IsComposting: ").Append(IsComposting).Append("\n");
            sb.Append("  IsHygienisation: ").Append(IsHygienisation).Append("\n");
            sb.Append("  IsDifferentProcess: ").Append(IsDifferentProcess).Append("\n");
            sb.Append("  DifferentProcess: ").Append(DifferentProcess).Append("\n");
            sb.Append("  SludgeMassMg: ").Append(SludgeMassMg).Append("\n");
            sb.Append("  SludgeMassMgSm: ").Append(SludgeMassMgSm).Append("\n");
            sb.Append("  AppliedSludgeMass: ").Append(AppliedSludgeMass).Append("\n");
            sb.Append("  AppliedSludgeDryMatterMass: ").Append(AppliedSludgeDryMatterMass).Append("\n");
            sb.Append("  KpoCardNumber: ").Append(KpoCardNumber).Append("\n");
            sb.Append("  IsApplicationPurposeCrops: ").Append(IsApplicationPurposeCrops).Append("\n");
            sb.Append("  IsApplicationPurposePlants: ").Append(IsApplicationPurposePlants).Append("\n");
            sb.Append("  IsApplicationPurposeInediblePlants: ").Append(IsApplicationPurposeInediblePlants).Append("\n");
            sb.Append("  IsApplicationPurposeReclamation: ").Append(IsApplicationPurposeReclamation).Append("\n");
            sb.Append("  IsApplicationPurposeLandAdjustment: ").Append(IsApplicationPurposeLandAdjustment).Append("\n");
            sb.Append("  RecordingUserFullName: ").Append(RecordingUserFullName).Append("\n");
            sb.Append("  SludgeApplicationDate: ").Append(SludgeApplicationDate).Append("\n");
            sb.Append("  ResearchCardNumber: ").Append(ResearchCardNumber).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosPrintingPageListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchNumber == input.BatchNumber ||
                    (this.BatchNumber != null &&
                    this.BatchNumber.Equals(input.BatchNumber))
                ) && 
                (
                    this.CreatedUserFullName == input.CreatedUserFullName ||
                    (this.CreatedUserFullName != null &&
                    this.CreatedUserFullName.Equals(input.CreatedUserFullName))
                ) && 
                (
                    this.DateOfSewageSludgeCreation == input.DateOfSewageSludgeCreation ||
                    (this.DateOfSewageSludgeCreation != null &&
                    this.DateOfSewageSludgeCreation.Equals(input.DateOfSewageSludgeCreation))
                ) && 
                (
                    this.IsFermentation == input.IsFermentation ||
                    (this.IsFermentation != null &&
                    this.IsFermentation.Equals(input.IsFermentation))
                ) && 
                (
                    this.IsDrying == input.IsDrying ||
                    (this.IsDrying != null &&
                    this.IsDrying.Equals(input.IsDrying))
                ) && 
                (
                    this.IsDehydration == input.IsDehydration ||
                    (this.IsDehydration != null &&
                    this.IsDehydration.Equals(input.IsDehydration))
                ) && 
                (
                    this.IsComposting == input.IsComposting ||
                    (this.IsComposting != null &&
                    this.IsComposting.Equals(input.IsComposting))
                ) && 
                (
                    this.IsHygienisation == input.IsHygienisation ||
                    (this.IsHygienisation != null &&
                    this.IsHygienisation.Equals(input.IsHygienisation))
                ) && 
                (
                    this.IsDifferentProcess == input.IsDifferentProcess ||
                    (this.IsDifferentProcess != null &&
                    this.IsDifferentProcess.Equals(input.IsDifferentProcess))
                ) && 
                (
                    this.DifferentProcess == input.DifferentProcess ||
                    (this.DifferentProcess != null &&
                    this.DifferentProcess.Equals(input.DifferentProcess))
                ) && 
                (
                    this.SludgeMassMg == input.SludgeMassMg ||
                    (this.SludgeMassMg != null &&
                    this.SludgeMassMg.Equals(input.SludgeMassMg))
                ) && 
                (
                    this.SludgeMassMgSm == input.SludgeMassMgSm ||
                    (this.SludgeMassMgSm != null &&
                    this.SludgeMassMgSm.Equals(input.SludgeMassMgSm))
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
                    this.KpoCardNumber == input.KpoCardNumber ||
                    (this.KpoCardNumber != null &&
                    this.KpoCardNumber.Equals(input.KpoCardNumber))
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
                    this.RecordingUserFullName == input.RecordingUserFullName ||
                    (this.RecordingUserFullName != null &&
                    this.RecordingUserFullName.Equals(input.RecordingUserFullName))
                ) && 
                (
                    this.SludgeApplicationDate == input.SludgeApplicationDate ||
                    (this.SludgeApplicationDate != null &&
                    this.SludgeApplicationDate.Equals(input.SludgeApplicationDate))
                ) && 
                (
                    this.ResearchCardNumber == input.ResearchCardNumber ||
                    (this.ResearchCardNumber != null &&
                    this.ResearchCardNumber.Equals(input.ResearchCardNumber))
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
                if (this.BatchNumber != null)
                    hashCode = hashCode * 59 + this.BatchNumber.GetHashCode();
                if (this.CreatedUserFullName != null)
                    hashCode = hashCode * 59 + this.CreatedUserFullName.GetHashCode();
                if (this.DateOfSewageSludgeCreation != null)
                    hashCode = hashCode * 59 + this.DateOfSewageSludgeCreation.GetHashCode();
                if (this.IsFermentation != null)
                    hashCode = hashCode * 59 + this.IsFermentation.GetHashCode();
                if (this.IsDrying != null)
                    hashCode = hashCode * 59 + this.IsDrying.GetHashCode();
                if (this.IsDehydration != null)
                    hashCode = hashCode * 59 + this.IsDehydration.GetHashCode();
                if (this.IsComposting != null)
                    hashCode = hashCode * 59 + this.IsComposting.GetHashCode();
                if (this.IsHygienisation != null)
                    hashCode = hashCode * 59 + this.IsHygienisation.GetHashCode();
                if (this.IsDifferentProcess != null)
                    hashCode = hashCode * 59 + this.IsDifferentProcess.GetHashCode();
                if (this.DifferentProcess != null)
                    hashCode = hashCode * 59 + this.DifferentProcess.GetHashCode();
                if (this.SludgeMassMg != null)
                    hashCode = hashCode * 59 + this.SludgeMassMg.GetHashCode();
                if (this.SludgeMassMgSm != null)
                    hashCode = hashCode * 59 + this.SludgeMassMgSm.GetHashCode();
                if (this.AppliedSludgeMass != null)
                    hashCode = hashCode * 59 + this.AppliedSludgeMass.GetHashCode();
                if (this.AppliedSludgeDryMatterMass != null)
                    hashCode = hashCode * 59 + this.AppliedSludgeDryMatterMass.GetHashCode();
                if (this.KpoCardNumber != null)
                    hashCode = hashCode * 59 + this.KpoCardNumber.GetHashCode();
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
                if (this.RecordingUserFullName != null)
                    hashCode = hashCode * 59 + this.RecordingUserFullName.GetHashCode();
                if (this.SludgeApplicationDate != null)
                    hashCode = hashCode * 59 + this.SludgeApplicationDate.GetHashCode();
                if (this.ResearchCardNumber != null)
                    hashCode = hashCode * 59 + this.ResearchCardNumber.GetHashCode();
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
