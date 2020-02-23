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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest" /> class.
        /// </summary>
        /// <param name="kepwDismantleProcessedWasteId">Prowadzący stację demontażu - Przetwarzne odpady.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="recycledWasteMass">Masa odpadów poddanych recyklingowi [Mg].</param>
        /// <param name="energyRecoveryWasteMass">Masa odpadów poddanych odzyskowi energii [Mg].</param>
        /// <param name="otherThanRecyclingWasteMass">Masa odpadów poddanych innemu procesowi odzysku [Mg].</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest(Guid? kepwDismantleProcessedWasteId = default(Guid?), int? wasteCodeId = default(int?), double? recycledWasteMass = default(double?), double? energyRecoveryWasteMass = default(double?), double? otherThanRecyclingWasteMass = default(double?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string), string installationName = default(string))
        {
            this.KepwDismantleProcessedWasteId = kepwDismantleProcessedWasteId;
            this.WasteCodeId = wasteCodeId;
            this.RecycledWasteMass = recycledWasteMass;
            this.EnergyRecoveryWasteMass = energyRecoveryWasteMass;
            this.OtherThanRecyclingWasteMass = otherThanRecyclingWasteMass;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Prowadzący stację demontażu - Przetwarzne odpady
        /// </summary>
        /// <value>Prowadzący stację demontażu - Przetwarzne odpady</value>
        [DataMember(Name="kepwDismantleProcessedWasteId", EmitDefaultValue=false)]
        public Guid? KepwDismantleProcessedWasteId { get; set; }

        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// Masa odpadów poddanych recyklingowi [Mg]
        /// </summary>
        /// <value>Masa odpadów poddanych recyklingowi [Mg]</value>
        [DataMember(Name="recycledWasteMass", EmitDefaultValue=false)]
        public double? RecycledWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów poddanych odzyskowi energii [Mg]
        /// </summary>
        /// <value>Masa odpadów poddanych odzyskowi energii [Mg]</value>
        [DataMember(Name="energyRecoveryWasteMass", EmitDefaultValue=false)]
        public double? EnergyRecoveryWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów poddanych innemu procesowi odzysku [Mg]
        /// </summary>
        /// <value>Masa odpadów poddanych innemu procesowi odzysku [Mg]</value>
        [DataMember(Name="otherThanRecyclingWasteMass", EmitDefaultValue=false)]
        public double? OtherThanRecyclingWasteMass { get; set; }

        /// <summary>
        /// Kod ex
        /// </summary>
        /// <value>Kod ex</value>
        [DataMember(Name="wasteCodeExtended", EmitDefaultValue=false)]
        public bool? WasteCodeExtended { get; set; }

        /// <summary>
        /// Rodzaj odpadu ex
        /// </summary>
        /// <value>Rodzaj odpadu ex</value>
        [DataMember(Name="wasteCodeExtendedDescription", EmitDefaultValue=false)]
        public string WasteCodeExtendedDescription { get; set; }

        /// <summary>
        /// Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne
        /// </summary>
        /// <value>Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne</value>
        [DataMember(Name="hazardousWasteReclassification", EmitDefaultValue=false)]
        public bool? HazardousWasteReclassification { get; set; }

        /// <summary>
        /// Rodzaj odpadu
        /// </summary>
        /// <value>Rodzaj odpadu</value>
        [DataMember(Name="hazardousWasteReclassificationDescription", EmitDefaultValue=false)]
        public string HazardousWasteReclassificationDescription { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest {\n");
            sb.Append("  KepwDismantleProcessedWasteId: ").Append(KepwDismantleProcessedWasteId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  RecycledWasteMass: ").Append(RecycledWasteMass).Append("\n");
            sb.Append("  EnergyRecoveryWasteMass: ").Append(EnergyRecoveryWasteMass).Append("\n");
            sb.Append("  OtherThanRecyclingWasteMass: ").Append(OtherThanRecyclingWasteMass).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
            sb.Append("  HazardousWasteReclassificationDescription: ").Append(HazardousWasteReclassificationDescription).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleProcessedWasteV1UpdateDismantleProcessedWasteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KepwDismantleProcessedWasteId == input.KepwDismantleProcessedWasteId ||
                    (this.KepwDismantleProcessedWasteId != null &&
                    this.KepwDismantleProcessedWasteId.Equals(input.KepwDismantleProcessedWasteId))
                ) && 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.RecycledWasteMass == input.RecycledWasteMass ||
                    (this.RecycledWasteMass != null &&
                    this.RecycledWasteMass.Equals(input.RecycledWasteMass))
                ) && 
                (
                    this.EnergyRecoveryWasteMass == input.EnergyRecoveryWasteMass ||
                    (this.EnergyRecoveryWasteMass != null &&
                    this.EnergyRecoveryWasteMass.Equals(input.EnergyRecoveryWasteMass))
                ) && 
                (
                    this.OtherThanRecyclingWasteMass == input.OtherThanRecyclingWasteMass ||
                    (this.OtherThanRecyclingWasteMass != null &&
                    this.OtherThanRecyclingWasteMass.Equals(input.OtherThanRecyclingWasteMass))
                ) && 
                (
                    this.WasteCodeExtended == input.WasteCodeExtended ||
                    (this.WasteCodeExtended != null &&
                    this.WasteCodeExtended.Equals(input.WasteCodeExtended))
                ) && 
                (
                    this.WasteCodeExtendedDescription == input.WasteCodeExtendedDescription ||
                    (this.WasteCodeExtendedDescription != null &&
                    this.WasteCodeExtendedDescription.Equals(input.WasteCodeExtendedDescription))
                ) && 
                (
                    this.HazardousWasteReclassification == input.HazardousWasteReclassification ||
                    (this.HazardousWasteReclassification != null &&
                    this.HazardousWasteReclassification.Equals(input.HazardousWasteReclassification))
                ) && 
                (
                    this.HazardousWasteReclassificationDescription == input.HazardousWasteReclassificationDescription ||
                    (this.HazardousWasteReclassificationDescription != null &&
                    this.HazardousWasteReclassificationDescription.Equals(input.HazardousWasteReclassificationDescription))
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
                if (this.KepwDismantleProcessedWasteId != null)
                    hashCode = hashCode * 59 + this.KepwDismantleProcessedWasteId.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.RecycledWasteMass != null)
                    hashCode = hashCode * 59 + this.RecycledWasteMass.GetHashCode();
                if (this.EnergyRecoveryWasteMass != null)
                    hashCode = hashCode * 59 + this.EnergyRecoveryWasteMass.GetHashCode();
                if (this.OtherThanRecyclingWasteMass != null)
                    hashCode = hashCode * 59 + this.OtherThanRecyclingWasteMass.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
                if (this.HazardousWasteReclassificationDescription != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassificationDescription.GetHashCode();
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
