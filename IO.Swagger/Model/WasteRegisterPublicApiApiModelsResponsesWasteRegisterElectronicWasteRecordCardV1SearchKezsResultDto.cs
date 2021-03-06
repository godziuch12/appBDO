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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto" /> class.
        /// </summary>
        /// <param name="kezsId">Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego.</param>
        /// <param name="cardNumber">Numer karty.</param>
        /// <param name="wasteCode">Kod odpadu.</param>
        /// <param name="wasteCodeDescription">Opis odpadu.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="canBeDeleted">Czy może być usunięta.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto(Guid? kezsId = default(Guid?), string cardNumber = default(string), string wasteCode = default(string), string wasteCodeDescription = default(string), string createdByUser = default(string), bool? canBeDeleted = default(bool?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string))
        {
            this.KezsId = kezsId;
            this.CardNumber = cardNumber;
            this.WasteCode = wasteCode;
            this.WasteCodeDescription = wasteCodeDescription;
            this.CreatedByUser = createdByUser;
            this.CanBeDeleted = canBeDeleted;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
        }
        
        /// <summary>
        /// Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego
        /// </summary>
        /// <value>Id karty ewidencji zużytego sprzętu elektrycznego i elektronicznego</value>
        [DataMember(Name="kezsId", EmitDefaultValue=false)]
        public Guid? KezsId { get; set; }

        /// <summary>
        /// Numer karty
        /// </summary>
        /// <value>Numer karty</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Kod odpadu
        /// </summary>
        /// <value>Kod odpadu</value>
        [DataMember(Name="wasteCode", EmitDefaultValue=false)]
        public string WasteCode { get; set; }

        /// <summary>
        /// Opis odpadu
        /// </summary>
        /// <value>Opis odpadu</value>
        [DataMember(Name="wasteCodeDescription", EmitDefaultValue=false)]
        public string WasteCodeDescription { get; set; }

        /// <summary>
        /// Utworzone przez użytkownika
        /// </summary>
        /// <value>Utworzone przez użytkownika</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Czy może być usunięta
        /// </summary>
        /// <value>Czy może być usunięta</value>
        [DataMember(Name="canBeDeleted", EmitDefaultValue=false)]
        public bool? CanBeDeleted { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto {\n");
            sb.Append("  KezsId: ").Append(KezsId).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  WasteCode: ").Append(WasteCode).Append("\n");
            sb.Append("  WasteCodeDescription: ").Append(WasteCodeDescription).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  CanBeDeleted: ").Append(CanBeDeleted).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
            sb.Append("  HazardousWasteReclassificationDescription: ").Append(HazardousWasteReclassificationDescription).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterElectronicWasteRecordCardV1SearchKezsResultDto input)
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
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.WasteCode == input.WasteCode ||
                    (this.WasteCode != null &&
                    this.WasteCode.Equals(input.WasteCode))
                ) && 
                (
                    this.WasteCodeDescription == input.WasteCodeDescription ||
                    (this.WasteCodeDescription != null &&
                    this.WasteCodeDescription.Equals(input.WasteCodeDescription))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
                ) && 
                (
                    this.CanBeDeleted == input.CanBeDeleted ||
                    (this.CanBeDeleted != null &&
                    this.CanBeDeleted.Equals(input.CanBeDeleted))
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
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.WasteCode != null)
                    hashCode = hashCode * 59 + this.WasteCode.GetHashCode();
                if (this.WasteCodeDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeDescription.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
                if (this.CanBeDeleted != null)
                    hashCode = hashCode * 59 + this.CanBeDeleted.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
                if (this.HazardousWasteReclassificationDescription != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassificationDescription.GetHashCode();
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
