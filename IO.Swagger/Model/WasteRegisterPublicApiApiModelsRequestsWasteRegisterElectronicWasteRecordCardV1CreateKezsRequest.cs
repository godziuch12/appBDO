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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest" /> class.
        /// </summary>
        /// <param name="eupId">Id miejsca prowadzenia działalności.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="isWasteGenerating">W - wytwarzanie odpadów.</param>
        /// <param name="isWasteCollecting">Zb - zbieranie odpadów.</param>
        /// <param name="isSalvage">Od - odzysk.</param>
        /// <param name="isNeutralization">Un - unieszkodliwianie.</param>
        /// <param name="year">Rok kalendarzowy.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        /// <param name="kezsEquipmentGroupCards">Lista grup zebranego sprzętu.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest(Guid? eupId = default(Guid?), int? wasteCodeId = default(int?), bool? isWasteGenerating = default(bool?), bool? isWasteCollecting = default(bool?), bool? isSalvage = default(bool?), bool? isNeutralization = default(bool?), int? year = default(int?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string), List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardCreateKezsEquipmentGroupCardDto> kezsEquipmentGroupCards = default(List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardCreateKezsEquipmentGroupCardDto>))
        {
            this.EupId = eupId;
            this.WasteCodeId = wasteCodeId;
            this.IsWasteGenerating = isWasteGenerating;
            this.IsWasteCollecting = isWasteCollecting;
            this.IsSalvage = isSalvage;
            this.IsNeutralization = isNeutralization;
            this.Year = year;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
            this.KezsEquipmentGroupCards = kezsEquipmentGroupCards;
        }
        
        /// <summary>
        /// Id miejsca prowadzenia działalności
        /// </summary>
        /// <value>Id miejsca prowadzenia działalności</value>
        [DataMember(Name="eupId", EmitDefaultValue=false)]
        public Guid? EupId { get; set; }

        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// W - wytwarzanie odpadów
        /// </summary>
        /// <value>W - wytwarzanie odpadów</value>
        [DataMember(Name="isWasteGenerating", EmitDefaultValue=false)]
        public bool? IsWasteGenerating { get; set; }

        /// <summary>
        /// Zb - zbieranie odpadów
        /// </summary>
        /// <value>Zb - zbieranie odpadów</value>
        [DataMember(Name="isWasteCollecting", EmitDefaultValue=false)]
        public bool? IsWasteCollecting { get; set; }

        /// <summary>
        /// Od - odzysk
        /// </summary>
        /// <value>Od - odzysk</value>
        [DataMember(Name="isSalvage", EmitDefaultValue=false)]
        public bool? IsSalvage { get; set; }

        /// <summary>
        /// Un - unieszkodliwianie
        /// </summary>
        /// <value>Un - unieszkodliwianie</value>
        [DataMember(Name="isNeutralization", EmitDefaultValue=false)]
        public bool? IsNeutralization { get; set; }

        /// <summary>
        /// Rok kalendarzowy
        /// </summary>
        /// <value>Rok kalendarzowy</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

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
        /// Lista grup zebranego sprzętu
        /// </summary>
        /// <value>Lista grup zebranego sprzętu</value>
        [DataMember(Name="kezsEquipmentGroupCards", EmitDefaultValue=false)]
        public List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardCreateKezsEquipmentGroupCardDto> KezsEquipmentGroupCards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest {\n");
            sb.Append("  EupId: ").Append(EupId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  IsWasteGenerating: ").Append(IsWasteGenerating).Append("\n");
            sb.Append("  IsWasteCollecting: ").Append(IsWasteCollecting).Append("\n");
            sb.Append("  IsSalvage: ").Append(IsSalvage).Append("\n");
            sb.Append("  IsNeutralization: ").Append(IsNeutralization).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
            sb.Append("  HazardousWasteReclassificationDescription: ").Append(HazardousWasteReclassificationDescription).Append("\n");
            sb.Append("  KezsEquipmentGroupCards: ").Append(KezsEquipmentGroupCards).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1CreateKezsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EupId == input.EupId ||
                    (this.EupId != null &&
                    this.EupId.Equals(input.EupId))
                ) && 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.IsWasteGenerating == input.IsWasteGenerating ||
                    (this.IsWasteGenerating != null &&
                    this.IsWasteGenerating.Equals(input.IsWasteGenerating))
                ) && 
                (
                    this.IsWasteCollecting == input.IsWasteCollecting ||
                    (this.IsWasteCollecting != null &&
                    this.IsWasteCollecting.Equals(input.IsWasteCollecting))
                ) && 
                (
                    this.IsSalvage == input.IsSalvage ||
                    (this.IsSalvage != null &&
                    this.IsSalvage.Equals(input.IsSalvage))
                ) && 
                (
                    this.IsNeutralization == input.IsNeutralization ||
                    (this.IsNeutralization != null &&
                    this.IsNeutralization.Equals(input.IsNeutralization))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                    this.KezsEquipmentGroupCards == input.KezsEquipmentGroupCards ||
                    this.KezsEquipmentGroupCards != null &&
                    this.KezsEquipmentGroupCards.SequenceEqual(input.KezsEquipmentGroupCards)
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
                if (this.EupId != null)
                    hashCode = hashCode * 59 + this.EupId.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.IsWasteGenerating != null)
                    hashCode = hashCode * 59 + this.IsWasteGenerating.GetHashCode();
                if (this.IsWasteCollecting != null)
                    hashCode = hashCode * 59 + this.IsWasteCollecting.GetHashCode();
                if (this.IsSalvage != null)
                    hashCode = hashCode * 59 + this.IsSalvage.GetHashCode();
                if (this.IsNeutralization != null)
                    hashCode = hashCode * 59 + this.IsNeutralization.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
                if (this.HazardousWasteReclassificationDescription != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassificationDescription.GetHashCode();
                if (this.KezsEquipmentGroupCards != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentGroupCards.GetHashCode();
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
