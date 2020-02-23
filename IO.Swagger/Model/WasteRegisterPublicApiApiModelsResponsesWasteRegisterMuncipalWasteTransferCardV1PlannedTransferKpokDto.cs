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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto" /> class.
        /// </summary>
        /// <param name="kpokId">Id Karty Przekazania Odpadów Komunalnych.</param>
        /// <param name="year">Rok kalendarzowy.</param>
        /// <param name="cardStatusId">Id statusu karty.</param>
        /// <param name="senderCompanyId">Id przekazującego odpady.</param>
        /// <param name="senderEupId">Id miejsca prowadzenia działalności przekazującego.</param>
        /// <param name="carrierCompanyId">Id transportującego odpady.</param>
        /// <param name="receiverCompanyId">Id przejmującego odpady.</param>
        /// <param name="receiverEupId">Id miejsca prowadzenia działalności przejmującego.</param>
        /// <param name="communeId">Id gminy.</param>
        /// <param name="communeArea">Obszar gminy.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="vehicleRegNumber">Numer rejestracyjny środka transportu.</param>
        /// <param name="wasteMass">Masa odpadów.</param>
        /// <param name="plannedTransportTime">Planowana data rozpoczęcia transportu.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto(Guid? kpokId = default(Guid?), int? year = default(int?), int? cardStatusId = default(int?), Guid? senderCompanyId = default(Guid?), Guid? senderEupId = default(Guid?), Guid? carrierCompanyId = default(Guid?), Guid? receiverCompanyId = default(Guid?), Guid? receiverEupId = default(Guid?), string communeId = default(string), string communeArea = default(string), int? wasteCodeId = default(int?), string vehicleRegNumber = default(string), double? wasteMass = default(double?), DateTime? plannedTransportTime = default(DateTime?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?))
        {
            this.KpokId = kpokId;
            this.Year = year;
            this.CardStatusId = cardStatusId;
            this.SenderCompanyId = senderCompanyId;
            this.SenderEupId = senderEupId;
            this.CarrierCompanyId = carrierCompanyId;
            this.ReceiverCompanyId = receiverCompanyId;
            this.ReceiverEupId = receiverEupId;
            this.CommuneId = communeId;
            this.CommuneArea = communeArea;
            this.WasteCodeId = wasteCodeId;
            this.VehicleRegNumber = vehicleRegNumber;
            this.WasteMass = wasteMass;
            this.PlannedTransportTime = plannedTransportTime;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
        }
        
        /// <summary>
        /// Id Karty Przekazania Odpadów Komunalnych
        /// </summary>
        /// <value>Id Karty Przekazania Odpadów Komunalnych</value>
        [DataMember(Name="kpokId", EmitDefaultValue=false)]
        public Guid? KpokId { get; set; }

        /// <summary>
        /// Rok kalendarzowy
        /// </summary>
        /// <value>Rok kalendarzowy</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Id statusu karty
        /// </summary>
        /// <value>Id statusu karty</value>
        [DataMember(Name="cardStatusId", EmitDefaultValue=false)]
        public int? CardStatusId { get; set; }

        /// <summary>
        /// Id przekazującego odpady
        /// </summary>
        /// <value>Id przekazującego odpady</value>
        [DataMember(Name="senderCompanyId", EmitDefaultValue=false)]
        public Guid? SenderCompanyId { get; set; }

        /// <summary>
        /// Id miejsca prowadzenia działalności przekazującego
        /// </summary>
        /// <value>Id miejsca prowadzenia działalności przekazującego</value>
        [DataMember(Name="senderEupId", EmitDefaultValue=false)]
        public Guid? SenderEupId { get; set; }

        /// <summary>
        /// Id transportującego odpady
        /// </summary>
        /// <value>Id transportującego odpady</value>
        [DataMember(Name="carrierCompanyId", EmitDefaultValue=false)]
        public Guid? CarrierCompanyId { get; set; }

        /// <summary>
        /// Id przejmującego odpady
        /// </summary>
        /// <value>Id przejmującego odpady</value>
        [DataMember(Name="receiverCompanyId", EmitDefaultValue=false)]
        public Guid? ReceiverCompanyId { get; set; }

        /// <summary>
        /// Id miejsca prowadzenia działalności przejmującego
        /// </summary>
        /// <value>Id miejsca prowadzenia działalności przejmującego</value>
        [DataMember(Name="receiverEupId", EmitDefaultValue=false)]
        public Guid? ReceiverEupId { get; set; }

        /// <summary>
        /// Id gminy
        /// </summary>
        /// <value>Id gminy</value>
        [DataMember(Name="communeId", EmitDefaultValue=false)]
        public string CommuneId { get; set; }

        /// <summary>
        /// Obszar gminy
        /// </summary>
        /// <value>Obszar gminy</value>
        [DataMember(Name="communeArea", EmitDefaultValue=false)]
        public string CommuneArea { get; set; }

        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// Numer rejestracyjny środka transportu
        /// </summary>
        /// <value>Numer rejestracyjny środka transportu</value>
        [DataMember(Name="vehicleRegNumber", EmitDefaultValue=false)]
        public string VehicleRegNumber { get; set; }

        /// <summary>
        /// Masa odpadów
        /// </summary>
        /// <value>Masa odpadów</value>
        [DataMember(Name="wasteMass", EmitDefaultValue=false)]
        public double? WasteMass { get; set; }

        /// <summary>
        /// Planowana data rozpoczęcia transportu
        /// </summary>
        /// <value>Planowana data rozpoczęcia transportu</value>
        [DataMember(Name="plannedTransportTime", EmitDefaultValue=false)]
        public DateTime? PlannedTransportTime { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto {\n");
            sb.Append("  KpokId: ").Append(KpokId).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  CardStatusId: ").Append(CardStatusId).Append("\n");
            sb.Append("  SenderCompanyId: ").Append(SenderCompanyId).Append("\n");
            sb.Append("  SenderEupId: ").Append(SenderEupId).Append("\n");
            sb.Append("  CarrierCompanyId: ").Append(CarrierCompanyId).Append("\n");
            sb.Append("  ReceiverCompanyId: ").Append(ReceiverCompanyId).Append("\n");
            sb.Append("  ReceiverEupId: ").Append(ReceiverEupId).Append("\n");
            sb.Append("  CommuneId: ").Append(CommuneId).Append("\n");
            sb.Append("  CommuneArea: ").Append(CommuneArea).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  VehicleRegNumber: ").Append(VehicleRegNumber).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
            sb.Append("  PlannedTransportTime: ").Append(PlannedTransportTime).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1PlannedTransferKpokDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KpokId == input.KpokId ||
                    (this.KpokId != null &&
                    this.KpokId.Equals(input.KpokId))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.CardStatusId == input.CardStatusId ||
                    (this.CardStatusId != null &&
                    this.CardStatusId.Equals(input.CardStatusId))
                ) && 
                (
                    this.SenderCompanyId == input.SenderCompanyId ||
                    (this.SenderCompanyId != null &&
                    this.SenderCompanyId.Equals(input.SenderCompanyId))
                ) && 
                (
                    this.SenderEupId == input.SenderEupId ||
                    (this.SenderEupId != null &&
                    this.SenderEupId.Equals(input.SenderEupId))
                ) && 
                (
                    this.CarrierCompanyId == input.CarrierCompanyId ||
                    (this.CarrierCompanyId != null &&
                    this.CarrierCompanyId.Equals(input.CarrierCompanyId))
                ) && 
                (
                    this.ReceiverCompanyId == input.ReceiverCompanyId ||
                    (this.ReceiverCompanyId != null &&
                    this.ReceiverCompanyId.Equals(input.ReceiverCompanyId))
                ) && 
                (
                    this.ReceiverEupId == input.ReceiverEupId ||
                    (this.ReceiverEupId != null &&
                    this.ReceiverEupId.Equals(input.ReceiverEupId))
                ) && 
                (
                    this.CommuneId == input.CommuneId ||
                    (this.CommuneId != null &&
                    this.CommuneId.Equals(input.CommuneId))
                ) && 
                (
                    this.CommuneArea == input.CommuneArea ||
                    (this.CommuneArea != null &&
                    this.CommuneArea.Equals(input.CommuneArea))
                ) && 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.VehicleRegNumber == input.VehicleRegNumber ||
                    (this.VehicleRegNumber != null &&
                    this.VehicleRegNumber.Equals(input.VehicleRegNumber))
                ) && 
                (
                    this.WasteMass == input.WasteMass ||
                    (this.WasteMass != null &&
                    this.WasteMass.Equals(input.WasteMass))
                ) && 
                (
                    this.PlannedTransportTime == input.PlannedTransportTime ||
                    (this.PlannedTransportTime != null &&
                    this.PlannedTransportTime.Equals(input.PlannedTransportTime))
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
                if (this.KpokId != null)
                    hashCode = hashCode * 59 + this.KpokId.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.CardStatusId != null)
                    hashCode = hashCode * 59 + this.CardStatusId.GetHashCode();
                if (this.SenderCompanyId != null)
                    hashCode = hashCode * 59 + this.SenderCompanyId.GetHashCode();
                if (this.SenderEupId != null)
                    hashCode = hashCode * 59 + this.SenderEupId.GetHashCode();
                if (this.CarrierCompanyId != null)
                    hashCode = hashCode * 59 + this.CarrierCompanyId.GetHashCode();
                if (this.ReceiverCompanyId != null)
                    hashCode = hashCode * 59 + this.ReceiverCompanyId.GetHashCode();
                if (this.ReceiverEupId != null)
                    hashCode = hashCode * 59 + this.ReceiverEupId.GetHashCode();
                if (this.CommuneId != null)
                    hashCode = hashCode * 59 + this.CommuneId.GetHashCode();
                if (this.CommuneArea != null)
                    hashCode = hashCode * 59 + this.CommuneArea.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.VehicleRegNumber != null)
                    hashCode = hashCode * 59 + this.VehicleRegNumber.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
                if (this.PlannedTransportTime != null)
                    hashCode = hashCode * 59 + this.PlannedTransportTime.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
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
