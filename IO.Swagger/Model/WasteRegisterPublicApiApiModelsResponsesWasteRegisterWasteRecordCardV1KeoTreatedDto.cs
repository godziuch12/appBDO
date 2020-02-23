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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto" /> class.
        /// </summary>
        /// <param name="keoTreatedId">Id wpisu Przetwarzane odpady.</param>
        /// <param name="keoId">Id karty ewidencji odpadów.</param>
        /// <param name="treatedWasteMass">Masa przetworzonych odpadów.</param>
        /// <param name="pcbContent">Zawartość PCB [%].</param>
        /// <param name="processR">Odpady objęte procesem: R - odzysku.</param>
        /// <param name="processD">Odpady objęte procesem: D - unieszkodliwiania.</param>
        /// <param name="wasteProcessId">Id procesu przetwarzania odpadów.</param>
        /// <param name="isRecycle">Recykling.</param>
        /// <param name="isFillingUpDisadvantagedAreas">Wypełnianie terenów niekorzystnie przekształconych.</param>
        /// <param name="isPreparationForReUse">Przygotowanie do ponownego uzycia.</param>
        /// <param name="isAnotherRecoveryProcess">Inny proces odzysku.</param>
        /// <param name="isNeutralization">Un - unieszkodliwianie.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto(Guid? keoTreatedId = default(Guid?), Guid? keoId = default(Guid?), double? treatedWasteMass = default(double?), double? pcbContent = default(double?), bool? processR = default(bool?), bool? processD = default(bool?), int? wasteProcessId = default(int?), bool? isRecycle = default(bool?), bool? isFillingUpDisadvantagedAreas = default(bool?), bool? isPreparationForReUse = default(bool?), bool? isAnotherRecoveryProcess = default(bool?), bool? isNeutralization = default(bool?), string installationName = default(string))
        {
            this.KeoTreatedId = keoTreatedId;
            this.KeoId = keoId;
            this.TreatedWasteMass = treatedWasteMass;
            this.PcbContent = pcbContent;
            this.ProcessR = processR;
            this.ProcessD = processD;
            this.WasteProcessId = wasteProcessId;
            this.IsRecycle = isRecycle;
            this.IsFillingUpDisadvantagedAreas = isFillingUpDisadvantagedAreas;
            this.IsPreparationForReUse = isPreparationForReUse;
            this.IsAnotherRecoveryProcess = isAnotherRecoveryProcess;
            this.IsNeutralization = isNeutralization;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Id wpisu Przetwarzane odpady
        /// </summary>
        /// <value>Id wpisu Przetwarzane odpady</value>
        [DataMember(Name="keoTreatedId", EmitDefaultValue=false)]
        public Guid? KeoTreatedId { get; set; }

        /// <summary>
        /// Id karty ewidencji odpadów
        /// </summary>
        /// <value>Id karty ewidencji odpadów</value>
        [DataMember(Name="keoId", EmitDefaultValue=false)]
        public Guid? KeoId { get; set; }

        /// <summary>
        /// Masa przetworzonych odpadów
        /// </summary>
        /// <value>Masa przetworzonych odpadów</value>
        [DataMember(Name="treatedWasteMass", EmitDefaultValue=false)]
        public double? TreatedWasteMass { get; set; }

        /// <summary>
        /// Zawartość PCB [%]
        /// </summary>
        /// <value>Zawartość PCB [%]</value>
        [DataMember(Name="pcbContent", EmitDefaultValue=false)]
        public double? PcbContent { get; set; }

        /// <summary>
        /// Odpady objęte procesem: R - odzysku
        /// </summary>
        /// <value>Odpady objęte procesem: R - odzysku</value>
        [DataMember(Name="processR", EmitDefaultValue=false)]
        public bool? ProcessR { get; set; }

        /// <summary>
        /// Odpady objęte procesem: D - unieszkodliwiania
        /// </summary>
        /// <value>Odpady objęte procesem: D - unieszkodliwiania</value>
        [DataMember(Name="processD", EmitDefaultValue=false)]
        public bool? ProcessD { get; set; }

        /// <summary>
        /// Id procesu przetwarzania odpadów
        /// </summary>
        /// <value>Id procesu przetwarzania odpadów</value>
        [DataMember(Name="wasteProcessId", EmitDefaultValue=false)]
        public int? WasteProcessId { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto {\n");
            sb.Append("  KeoTreatedId: ").Append(KeoTreatedId).Append("\n");
            sb.Append("  KeoId: ").Append(KeoId).Append("\n");
            sb.Append("  TreatedWasteMass: ").Append(TreatedWasteMass).Append("\n");
            sb.Append("  PcbContent: ").Append(PcbContent).Append("\n");
            sb.Append("  ProcessR: ").Append(ProcessR).Append("\n");
            sb.Append("  ProcessD: ").Append(ProcessD).Append("\n");
            sb.Append("  WasteProcessId: ").Append(WasteProcessId).Append("\n");
            sb.Append("  IsRecycle: ").Append(IsRecycle).Append("\n");
            sb.Append("  IsFillingUpDisadvantagedAreas: ").Append(IsFillingUpDisadvantagedAreas).Append("\n");
            sb.Append("  IsPreparationForReUse: ").Append(IsPreparationForReUse).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoTreatedDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeoTreatedId == input.KeoTreatedId ||
                    (this.KeoTreatedId != null &&
                    this.KeoTreatedId.Equals(input.KeoTreatedId))
                ) && 
                (
                    this.KeoId == input.KeoId ||
                    (this.KeoId != null &&
                    this.KeoId.Equals(input.KeoId))
                ) && 
                (
                    this.TreatedWasteMass == input.TreatedWasteMass ||
                    (this.TreatedWasteMass != null &&
                    this.TreatedWasteMass.Equals(input.TreatedWasteMass))
                ) && 
                (
                    this.PcbContent == input.PcbContent ||
                    (this.PcbContent != null &&
                    this.PcbContent.Equals(input.PcbContent))
                ) && 
                (
                    this.ProcessR == input.ProcessR ||
                    (this.ProcessR != null &&
                    this.ProcessR.Equals(input.ProcessR))
                ) && 
                (
                    this.ProcessD == input.ProcessD ||
                    (this.ProcessD != null &&
                    this.ProcessD.Equals(input.ProcessD))
                ) && 
                (
                    this.WasteProcessId == input.WasteProcessId ||
                    (this.WasteProcessId != null &&
                    this.WasteProcessId.Equals(input.WasteProcessId))
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
                if (this.KeoTreatedId != null)
                    hashCode = hashCode * 59 + this.KeoTreatedId.GetHashCode();
                if (this.KeoId != null)
                    hashCode = hashCode * 59 + this.KeoId.GetHashCode();
                if (this.TreatedWasteMass != null)
                    hashCode = hashCode * 59 + this.TreatedWasteMass.GetHashCode();
                if (this.PcbContent != null)
                    hashCode = hashCode * 59 + this.PcbContent.GetHashCode();
                if (this.ProcessR != null)
                    hashCode = hashCode * 59 + this.ProcessR.GetHashCode();
                if (this.ProcessD != null)
                    hashCode = hashCode * 59 + this.ProcessD.GetHashCode();
                if (this.WasteProcessId != null)
                    hashCode = hashCode * 59 + this.WasteProcessId.GetHashCode();
                if (this.IsRecycle != null)
                    hashCode = hashCode * 59 + this.IsRecycle.GetHashCode();
                if (this.IsFillingUpDisadvantagedAreas != null)
                    hashCode = hashCode * 59 + this.IsFillingUpDisadvantagedAreas.GetHashCode();
                if (this.IsPreparationForReUse != null)
                    hashCode = hashCode * 59 + this.IsPreparationForReUse.GetHashCode();
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
