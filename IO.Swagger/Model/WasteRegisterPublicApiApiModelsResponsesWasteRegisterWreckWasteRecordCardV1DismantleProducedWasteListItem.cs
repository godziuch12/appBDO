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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem" /> class.
        /// </summary>
        /// <param name="dismantleProducedWasteId">Prowadzący stację demontażu - Wytwarzane odpady.</param>
        /// <param name="productionDate">Data wytworzenia.</param>
        /// <param name="wasteCode">Kod odpadu.</param>
        /// <param name="wasteMass">Masa odpadów powstałych z demontażu pojazdów [Mg].</param>
        /// <param name="reusablePartsMass">Masa przedmiotów wyposażenia i części przeznaczonych do ponownego użycia [Mg].</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem(Guid? dismantleProducedWasteId = default(Guid?), DateTime? productionDate = default(DateTime?), string wasteCode = default(string), double? wasteMass = default(double?), double? reusablePartsMass = default(double?), string createdByUser = default(string), string installationName = default(string), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string))
        {
            this.DismantleProducedWasteId = dismantleProducedWasteId;
            this.ProductionDate = productionDate;
            this.WasteCode = wasteCode;
            this.WasteMass = wasteMass;
            this.ReusablePartsMass = reusablePartsMass;
            this.CreatedByUser = createdByUser;
            this.InstallationName = installationName;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
        }
        
        /// <summary>
        /// Prowadzący stację demontażu - Wytwarzane odpady
        /// </summary>
        /// <value>Prowadzący stację demontażu - Wytwarzane odpady</value>
        [DataMember(Name="dismantleProducedWasteId", EmitDefaultValue=false)]
        public Guid? DismantleProducedWasteId { get; set; }

        /// <summary>
        /// Data wytworzenia
        /// </summary>
        /// <value>Data wytworzenia</value>
        [DataMember(Name="productionDate", EmitDefaultValue=false)]
        public DateTime? ProductionDate { get; set; }

        /// <summary>
        /// Kod odpadu
        /// </summary>
        /// <value>Kod odpadu</value>
        [DataMember(Name="wasteCode", EmitDefaultValue=false)]
        public string WasteCode { get; set; }

        /// <summary>
        /// Masa odpadów powstałych z demontażu pojazdów [Mg]
        /// </summary>
        /// <value>Masa odpadów powstałych z demontażu pojazdów [Mg]</value>
        [DataMember(Name="wasteMass", EmitDefaultValue=false)]
        public double? WasteMass { get; set; }

        /// <summary>
        /// Masa przedmiotów wyposażenia i części przeznaczonych do ponownego użycia [Mg]
        /// </summary>
        /// <value>Masa przedmiotów wyposażenia i części przeznaczonych do ponownego użycia [Mg]</value>
        [DataMember(Name="reusablePartsMass", EmitDefaultValue=false)]
        public double? ReusablePartsMass { get; set; }

        /// <summary>
        /// Utworzone przez użytkownika
        /// </summary>
        /// <value>Utworzone przez użytkownika</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Nazwa instalacji
        /// </summary>
        /// <value>Nazwa instalacji</value>
        [DataMember(Name="installationName", EmitDefaultValue=false)]
        public string InstallationName { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem {\n");
            sb.Append("  DismantleProducedWasteId: ").Append(DismantleProducedWasteId).Append("\n");
            sb.Append("  ProductionDate: ").Append(ProductionDate).Append("\n");
            sb.Append("  WasteCode: ").Append(WasteCode).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
            sb.Append("  ReusablePartsMass: ").Append(ReusablePartsMass).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  InstallationName: ").Append(InstallationName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1DismantleProducedWasteListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DismantleProducedWasteId == input.DismantleProducedWasteId ||
                    (this.DismantleProducedWasteId != null &&
                    this.DismantleProducedWasteId.Equals(input.DismantleProducedWasteId))
                ) && 
                (
                    this.ProductionDate == input.ProductionDate ||
                    (this.ProductionDate != null &&
                    this.ProductionDate.Equals(input.ProductionDate))
                ) && 
                (
                    this.WasteCode == input.WasteCode ||
                    (this.WasteCode != null &&
                    this.WasteCode.Equals(input.WasteCode))
                ) && 
                (
                    this.WasteMass == input.WasteMass ||
                    (this.WasteMass != null &&
                    this.WasteMass.Equals(input.WasteMass))
                ) && 
                (
                    this.ReusablePartsMass == input.ReusablePartsMass ||
                    (this.ReusablePartsMass != null &&
                    this.ReusablePartsMass.Equals(input.ReusablePartsMass))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
                ) && 
                (
                    this.InstallationName == input.InstallationName ||
                    (this.InstallationName != null &&
                    this.InstallationName.Equals(input.InstallationName))
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
                if (this.DismantleProducedWasteId != null)
                    hashCode = hashCode * 59 + this.DismantleProducedWasteId.GetHashCode();
                if (this.ProductionDate != null)
                    hashCode = hashCode * 59 + this.ProductionDate.GetHashCode();
                if (this.WasteCode != null)
                    hashCode = hashCode * 59 + this.WasteCode.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
                if (this.ReusablePartsMass != null)
                    hashCode = hashCode * 59 + this.ReusablePartsMass.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
                if (this.InstallationName != null)
                    hashCode = hashCode * 59 + this.InstallationName.GetHashCode();
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
