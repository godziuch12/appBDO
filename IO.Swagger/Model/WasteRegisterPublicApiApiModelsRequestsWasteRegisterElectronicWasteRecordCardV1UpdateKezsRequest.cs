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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest" /> class.
        /// </summary>
        /// <param name="kezsId">Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="isWasteGenerating">W - wytwarzanie odpadów.</param>
        /// <param name="isWasteCollecting">Zb - zbieranie odpadów.</param>
        /// <param name="isSalvage">Od - odzysk.</param>
        /// <param name="isNeutralization">Un - unieszkodliwianie.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        /// <param name="kezsEquipmentGroupCard">Lista obiektów Zebranego sprzętu.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest(Guid? kezsId = default(Guid?), int? wasteCodeId = default(int?), bool? isWasteGenerating = default(bool?), bool? isWasteCollecting = default(bool?), bool? isSalvage = default(bool?), bool? isNeutralization = default(bool?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string), List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto> kezsEquipmentGroupCard = default(List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto>))
        {
            this.KezsId = kezsId;
            this.WasteCodeId = wasteCodeId;
            this.IsWasteGenerating = isWasteGenerating;
            this.IsWasteCollecting = isWasteCollecting;
            this.IsSalvage = isSalvage;
            this.IsNeutralization = isNeutralization;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
            this.KezsEquipmentGroupCard = kezsEquipmentGroupCard;
        }
        
        /// <summary>
        /// Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego
        /// </summary>
        /// <value>Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego</value>
        [DataMember(Name="kezsId", EmitDefaultValue=false)]
        public Guid? KezsId { get; set; }

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
        /// Lista obiektów Zebranego sprzętu
        /// </summary>
        /// <value>Lista obiektów Zebranego sprzętu</value>
        [DataMember(Name="kezsEquipmentGroupCard", EmitDefaultValue=false)]
        public List<BdoServiceModelsDtoWasteRegisterElectronicWasteRecordCardUpdateKezsEquipmentGroupCardDto> KezsEquipmentGroupCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest {\n");
            sb.Append("  KezsId: ").Append(KezsId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  IsWasteGenerating: ").Append(IsWasteGenerating).Append("\n");
            sb.Append("  IsWasteCollecting: ").Append(IsWasteCollecting).Append("\n");
            sb.Append("  IsSalvage: ").Append(IsSalvage).Append("\n");
            sb.Append("  IsNeutralization: ").Append(IsNeutralization).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
            sb.Append("  HazardousWasteReclassificationDescription: ").Append(HazardousWasteReclassificationDescription).Append("\n");
            sb.Append("  KezsEquipmentGroupCard: ").Append(KezsEquipmentGroupCard).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1UpdateKezsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KezsId == input.KezsId ||
                    (this.KezsId != null &&
                    this.KezsId.Equals(input.KezsId))
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
                    this.KezsEquipmentGroupCard == input.KezsEquipmentGroupCard ||
                    this.KezsEquipmentGroupCard != null &&
                    this.KezsEquipmentGroupCard.SequenceEqual(input.KezsEquipmentGroupCard)
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
                if (this.KezsId != null)
                    hashCode = hashCode * 59 + this.KezsId.GetHashCode();
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
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
                if (this.HazardousWasteReclassificationDescription != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassificationDescription.GetHashCode();
                if (this.KezsEquipmentGroupCard != null)
                    hashCode = hashCode * 59 + this.KezsEquipmentGroupCard.GetHashCode();
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
