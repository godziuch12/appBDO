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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage" /> class.
        /// </summary>
        /// <param name="date">Data.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="receivedWasteMass">receivedWasteMass.</param>
        /// <param name="receivedCardNumber">receivedCardNumber.</param>
        /// <param name="collecteddWasteMass">collecteddWasteMass.</param>
        /// <param name="collectedCardNumber">collectedCardNumber.</param>
        /// <param name="processedWasteMass">processedWasteMass.</param>
        /// <param name="rd">rd.</param>
        /// <param name="pcbCpntent">pcbCpntent.</param>
        /// <param name="isRecycle">Recykling.</param>
        /// <param name="isFillingUpDisadvantagedAreas">Wypełnianie terenów niekorzystnie przekształconych.</param>
        /// <param name="isPreparationForReUse">Przygotowanie do ponownego uzycia.</param>
        /// <param name="isPreparationForReuse">isPreparationForReuse.</param>
        /// <param name="isAnotherRecoveryProcess">Inny proces odzysku.</param>
        /// <param name="isNeutralization">Un - unieszkodliwianie.</param>
        /// <param name="transferredWasteMass">transferredWasteMass.</param>
        /// <param name="transferredCardNumber">transferredCardNumber.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage(DateTime? date = default(DateTime?), string fullName = default(string), double? receivedWasteMass = default(double?), string receivedCardNumber = default(string), double? collecteddWasteMass = default(double?), string collectedCardNumber = default(string), double? processedWasteMass = default(double?), string rd = default(string), double? pcbCpntent = default(double?), bool? isRecycle = default(bool?), bool? isFillingUpDisadvantagedAreas = default(bool?), bool? isPreparationForReUse = default(bool?), bool? isPreparationForReuse = default(bool?), bool? isAnotherRecoveryProcess = default(bool?), bool? isNeutralization = default(bool?), double? transferredWasteMass = default(double?), string transferredCardNumber = default(string))
        {
            this.Date = date;
            this.FullName = fullName;
            this.ReceivedWasteMass = receivedWasteMass;
            this.ReceivedCardNumber = receivedCardNumber;
            this.CollecteddWasteMass = collecteddWasteMass;
            this.CollectedCardNumber = collectedCardNumber;
            this.ProcessedWasteMass = processedWasteMass;
            this.Rd = rd;
            this.PcbCpntent = pcbCpntent;
            this.IsRecycle = isRecycle;
            this.IsFillingUpDisadvantagedAreas = isFillingUpDisadvantagedAreas;
            this.IsPreparationForReUse = isPreparationForReUse;
            this.IsPreparationForReuse = isPreparationForReuse;
            this.IsAnotherRecoveryProcess = isAnotherRecoveryProcess;
            this.IsNeutralization = isNeutralization;
            this.TransferredWasteMass = transferredWasteMass;
            this.TransferredCardNumber = transferredCardNumber;
        }
        
        /// <summary>
        /// Data
        /// </summary>
        /// <value>Data</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedWasteMass
        /// </summary>
        [DataMember(Name="receivedWasteMass", EmitDefaultValue=false)]
        public double? ReceivedWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedCardNumber
        /// </summary>
        [DataMember(Name="receivedCardNumber", EmitDefaultValue=false)]
        public string ReceivedCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets CollecteddWasteMass
        /// </summary>
        [DataMember(Name="collecteddWasteMass", EmitDefaultValue=false)]
        public double? CollecteddWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets CollectedCardNumber
        /// </summary>
        [DataMember(Name="collectedCardNumber", EmitDefaultValue=false)]
        public string CollectedCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedWasteMass
        /// </summary>
        [DataMember(Name="processedWasteMass", EmitDefaultValue=false)]
        public double? ProcessedWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets Rd
        /// </summary>
        [DataMember(Name="rd", EmitDefaultValue=false)]
        public string Rd { get; set; }

        /// <summary>
        /// Gets or Sets PcbCpntent
        /// </summary>
        [DataMember(Name="pcbCpntent", EmitDefaultValue=false)]
        public double? PcbCpntent { get; set; }

        /// <summary>
        /// Recykling
        /// </summary>
        /// <value>Recykling</value>
        [DataMember(Name="isRecycle", EmitDefaultValue=false)]
        public bool? IsRecycle { get; set; }

        /// <summary>
        /// Wypełnianie terenów niekorzystnie przekształconych
        /// </summary>
        /// <value>Wypełnianie terenów niekorzystnie przekształconych</value>
        [DataMember(Name="isFillingUpDisadvantagedAreas", EmitDefaultValue=false)]
        public bool? IsFillingUpDisadvantagedAreas { get; set; }

        /// <summary>
        /// Przygotowanie do ponownego uzycia
        /// </summary>
        /// <value>Przygotowanie do ponownego uzycia</value>
        [DataMember(Name="isPreparationForReUse", EmitDefaultValue=false)]
        public bool? IsPreparationForReUse { get; set; }

        /// <summary>
        /// Gets or Sets IsPreparationForReuse
        /// </summary>
        [DataMember(Name="isPreparationForReuse", EmitDefaultValue=false)]
        public bool? IsPreparationForReuse { get; set; }

        /// <summary>
        /// Inny proces odzysku
        /// </summary>
        /// <value>Inny proces odzysku</value>
        [DataMember(Name="isAnotherRecoveryProcess", EmitDefaultValue=false)]
        public bool? IsAnotherRecoveryProcess { get; set; }

        /// <summary>
        /// Un - unieszkodliwianie
        /// </summary>
        /// <value>Un - unieszkodliwianie</value>
        [DataMember(Name="isNeutralization", EmitDefaultValue=false)]
        public bool? IsNeutralization { get; set; }

        /// <summary>
        /// Gets or Sets TransferredWasteMass
        /// </summary>
        [DataMember(Name="transferredWasteMass", EmitDefaultValue=false)]
        public double? TransferredWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets TransferredCardNumber
        /// </summary>
        [DataMember(Name="transferredCardNumber", EmitDefaultValue=false)]
        public string TransferredCardNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  ReceivedWasteMass: ").Append(ReceivedWasteMass).Append("\n");
            sb.Append("  ReceivedCardNumber: ").Append(ReceivedCardNumber).Append("\n");
            sb.Append("  CollecteddWasteMass: ").Append(CollecteddWasteMass).Append("\n");
            sb.Append("  CollectedCardNumber: ").Append(CollectedCardNumber).Append("\n");
            sb.Append("  ProcessedWasteMass: ").Append(ProcessedWasteMass).Append("\n");
            sb.Append("  Rd: ").Append(Rd).Append("\n");
            sb.Append("  PcbCpntent: ").Append(PcbCpntent).Append("\n");
            sb.Append("  IsRecycle: ").Append(IsRecycle).Append("\n");
            sb.Append("  IsFillingUpDisadvantagedAreas: ").Append(IsFillingUpDisadvantagedAreas).Append("\n");
            sb.Append("  IsPreparationForReUse: ").Append(IsPreparationForReUse).Append("\n");
            sb.Append("  IsPreparationForReuse: ").Append(IsPreparationForReuse).Append("\n");
            sb.Append("  IsAnotherRecoveryProcess: ").Append(IsAnotherRecoveryProcess).Append("\n");
            sb.Append("  IsNeutralization: ").Append(IsNeutralization).Append("\n");
            sb.Append("  TransferredWasteMass: ").Append(TransferredWasteMass).Append("\n");
            sb.Append("  TransferredCardNumber: ").Append(TransferredCardNumber).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokListItemPrintingPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.ReceivedWasteMass == input.ReceivedWasteMass ||
                    (this.ReceivedWasteMass != null &&
                    this.ReceivedWasteMass.Equals(input.ReceivedWasteMass))
                ) && 
                (
                    this.ReceivedCardNumber == input.ReceivedCardNumber ||
                    (this.ReceivedCardNumber != null &&
                    this.ReceivedCardNumber.Equals(input.ReceivedCardNumber))
                ) && 
                (
                    this.CollecteddWasteMass == input.CollecteddWasteMass ||
                    (this.CollecteddWasteMass != null &&
                    this.CollecteddWasteMass.Equals(input.CollecteddWasteMass))
                ) && 
                (
                    this.CollectedCardNumber == input.CollectedCardNumber ||
                    (this.CollectedCardNumber != null &&
                    this.CollectedCardNumber.Equals(input.CollectedCardNumber))
                ) && 
                (
                    this.ProcessedWasteMass == input.ProcessedWasteMass ||
                    (this.ProcessedWasteMass != null &&
                    this.ProcessedWasteMass.Equals(input.ProcessedWasteMass))
                ) && 
                (
                    this.Rd == input.Rd ||
                    (this.Rd != null &&
                    this.Rd.Equals(input.Rd))
                ) && 
                (
                    this.PcbCpntent == input.PcbCpntent ||
                    (this.PcbCpntent != null &&
                    this.PcbCpntent.Equals(input.PcbCpntent))
                ) && 
                (
                    this.IsRecycle == input.IsRecycle ||
                    (this.IsRecycle != null &&
                    this.IsRecycle.Equals(input.IsRecycle))
                ) && 
                (
                    this.IsFillingUpDisadvantagedAreas == input.IsFillingUpDisadvantagedAreas ||
                    (this.IsFillingUpDisadvantagedAreas != null &&
                    this.IsFillingUpDisadvantagedAreas.Equals(input.IsFillingUpDisadvantagedAreas))
                ) && 
                (
                    this.IsPreparationForReUse == input.IsPreparationForReUse ||
                    (this.IsPreparationForReUse != null &&
                    this.IsPreparationForReUse.Equals(input.IsPreparationForReUse))
                ) && 
                (
                    this.IsPreparationForReuse == input.IsPreparationForReuse ||
                    (this.IsPreparationForReuse != null &&
                    this.IsPreparationForReuse.Equals(input.IsPreparationForReuse))
                ) && 
                (
                    this.IsAnotherRecoveryProcess == input.IsAnotherRecoveryProcess ||
                    (this.IsAnotherRecoveryProcess != null &&
                    this.IsAnotherRecoveryProcess.Equals(input.IsAnotherRecoveryProcess))
                ) && 
                (
                    this.IsNeutralization == input.IsNeutralization ||
                    (this.IsNeutralization != null &&
                    this.IsNeutralization.Equals(input.IsNeutralization))
                ) && 
                (
                    this.TransferredWasteMass == input.TransferredWasteMass ||
                    (this.TransferredWasteMass != null &&
                    this.TransferredWasteMass.Equals(input.TransferredWasteMass))
                ) && 
                (
                    this.TransferredCardNumber == input.TransferredCardNumber ||
                    (this.TransferredCardNumber != null &&
                    this.TransferredCardNumber.Equals(input.TransferredCardNumber))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.ReceivedWasteMass != null)
                    hashCode = hashCode * 59 + this.ReceivedWasteMass.GetHashCode();
                if (this.ReceivedCardNumber != null)
                    hashCode = hashCode * 59 + this.ReceivedCardNumber.GetHashCode();
                if (this.CollecteddWasteMass != null)
                    hashCode = hashCode * 59 + this.CollecteddWasteMass.GetHashCode();
                if (this.CollectedCardNumber != null)
                    hashCode = hashCode * 59 + this.CollectedCardNumber.GetHashCode();
                if (this.ProcessedWasteMass != null)
                    hashCode = hashCode * 59 + this.ProcessedWasteMass.GetHashCode();
                if (this.Rd != null)
                    hashCode = hashCode * 59 + this.Rd.GetHashCode();
                if (this.PcbCpntent != null)
                    hashCode = hashCode * 59 + this.PcbCpntent.GetHashCode();
                if (this.IsRecycle != null)
                    hashCode = hashCode * 59 + this.IsRecycle.GetHashCode();
                if (this.IsFillingUpDisadvantagedAreas != null)
                    hashCode = hashCode * 59 + this.IsFillingUpDisadvantagedAreas.GetHashCode();
                if (this.IsPreparationForReUse != null)
                    hashCode = hashCode * 59 + this.IsPreparationForReUse.GetHashCode();
                if (this.IsPreparationForReuse != null)
                    hashCode = hashCode * 59 + this.IsPreparationForReuse.GetHashCode();
                if (this.IsAnotherRecoveryProcess != null)
                    hashCode = hashCode * 59 + this.IsAnotherRecoveryProcess.GetHashCode();
                if (this.IsNeutralization != null)
                    hashCode = hashCode * 59 + this.IsNeutralization.GetHashCode();
                if (this.TransferredWasteMass != null)
                    hashCode = hashCode * 59 + this.TransferredWasteMass.GetHashCode();
                if (this.TransferredCardNumber != null)
                    hashCode = hashCode * 59 + this.TransferredCardNumber.GetHashCode();
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
