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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest" /> class.
        /// </summary>
        /// <param name="keokProcessedId">keokProcessedId.</param>
        /// <param name="processedWasteMass">processedWasteMass.</param>
        /// <param name="wasteProcessId">Id procesu przetwarzania odpadów.</param>
        /// <param name="pcbContent">Zawartość PCB [%].</param>
        /// <param name="isRecycle">Recykling.</param>
        /// <param name="isFillingUpDisadvantagedAreas">Wypełnianie terenów niekorzystnie przekształconych.</param>
        /// <param name="isPreparationForReUse">Przygotowanie do ponownego uzycia.</param>
        /// <param name="isPreparationForReuse">isPreparationForReuse.</param>
        /// <param name="isAnotherRecoveryProcess">Inny proces odzysku.</param>
        /// <param name="isNeutralization">Un - unieszkodliwianie.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest(Guid? keokProcessedId = default(Guid?), double? processedWasteMass = default(double?), int? wasteProcessId = default(int?), double? pcbContent = default(double?), bool? isRecycle = default(bool?), bool? isFillingUpDisadvantagedAreas = default(bool?), bool? isPreparationForReUse = default(bool?), bool? isPreparationForReuse = default(bool?), bool? isAnotherRecoveryProcess = default(bool?), bool? isNeutralization = default(bool?), string installationName = default(string))
        {
            this.KeokProcessedId = keokProcessedId;
            this.ProcessedWasteMass = processedWasteMass;
            this.WasteProcessId = wasteProcessId;
            this.PcbContent = pcbContent;
            this.IsRecycle = isRecycle;
            this.IsFillingUpDisadvantagedAreas = isFillingUpDisadvantagedAreas;
            this.IsPreparationForReUse = isPreparationForReUse;
            this.IsPreparationForReuse = isPreparationForReuse;
            this.IsAnotherRecoveryProcess = isAnotherRecoveryProcess;
            this.IsNeutralization = isNeutralization;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Gets or Sets KeokProcessedId
        /// </summary>
        [DataMember(Name="keokProcessedId", EmitDefaultValue=false)]
        public Guid? KeokProcessedId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedWasteMass
        /// </summary>
        [DataMember(Name="processedWasteMass", EmitDefaultValue=false)]
        public double? ProcessedWasteMass { get; set; }

        /// <summary>
        /// Id procesu przetwarzania odpadów
        /// </summary>
        /// <value>Id procesu przetwarzania odpadów</value>
        [DataMember(Name="wasteProcessId", EmitDefaultValue=false)]
        public int? WasteProcessId { get; set; }

        /// <summary>
        /// Zawartość PCB [%]
        /// </summary>
        /// <value>Zawartość PCB [%]</value>
        [DataMember(Name="pcbContent", EmitDefaultValue=false)]
        public double? PcbContent { get; set; }

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
        /// Nazwa instalacji
        /// </summary>
        /// <value>Nazwa instalacji</value>
        [DataMember(Name="installationName", EmitDefaultValue=false)]
        public string InstallationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest {\n");
            sb.Append("  KeokProcessedId: ").Append(KeokProcessedId).Append("\n");
            sb.Append("  ProcessedWasteMass: ").Append(ProcessedWasteMass).Append("\n");
            sb.Append("  WasteProcessId: ").Append(WasteProcessId).Append("\n");
            sb.Append("  PcbContent: ").Append(PcbContent).Append("\n");
            sb.Append("  IsRecycle: ").Append(IsRecycle).Append("\n");
            sb.Append("  IsFillingUpDisadvantagedAreas: ").Append(IsFillingUpDisadvantagedAreas).Append("\n");
            sb.Append("  IsPreparationForReUse: ").Append(IsPreparationForReUse).Append("\n");
            sb.Append("  IsPreparationForReuse: ").Append(IsPreparationForReuse).Append("\n");
            sb.Append("  IsAnotherRecoveryProcess: ").Append(IsAnotherRecoveryProcess).Append("\n");
            sb.Append("  IsNeutralization: ").Append(IsNeutralization).Append("\n");
            sb.Append("  InstallationName: ").Append(InstallationName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1UpdateKeokProcessedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeokProcessedId == input.KeokProcessedId ||
                    (this.KeokProcessedId != null &&
                    this.KeokProcessedId.Equals(input.KeokProcessedId))
                ) && 
                (
                    this.ProcessedWasteMass == input.ProcessedWasteMass ||
                    (this.ProcessedWasteMass != null &&
                    this.ProcessedWasteMass.Equals(input.ProcessedWasteMass))
                ) && 
                (
                    this.WasteProcessId == input.WasteProcessId ||
                    (this.WasteProcessId != null &&
                    this.WasteProcessId.Equals(input.WasteProcessId))
                ) && 
                (
                    this.PcbContent == input.PcbContent ||
                    (this.PcbContent != null &&
                    this.PcbContent.Equals(input.PcbContent))
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
                    this.InstallationName == input.InstallationName ||
                    (this.InstallationName != null &&
                    this.InstallationName.Equals(input.InstallationName))
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
                if (this.KeokProcessedId != null)
                    hashCode = hashCode * 59 + this.KeokProcessedId.GetHashCode();
                if (this.ProcessedWasteMass != null)
                    hashCode = hashCode * 59 + this.ProcessedWasteMass.GetHashCode();
                if (this.WasteProcessId != null)
                    hashCode = hashCode * 59 + this.WasteProcessId.GetHashCode();
                if (this.PcbContent != null)
                    hashCode = hashCode * 59 + this.PcbContent.GetHashCode();
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
                if (this.InstallationName != null)
                    hashCode = hashCode * 59 + this.InstallationName.GetHashCode();
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
