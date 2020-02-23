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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto" /> class.
        /// </summary>
        /// <param name="plannedTransportTime">Planowana data rozpoczęcia transportu.</param>
        /// <param name="realTransportTime">Data rozpoczęcia transportu.</param>
        /// <param name="wasteCode">Kod odpadu.</param>
        /// <param name="wasteCodeDescription">Opis odpadu.</param>
        /// <param name="vehicleRegNumber">Numer rejestracyjny środka transportu.</param>
        /// <param name="cardStatus">Status karty.</param>
        /// <param name="cardNumber">Numer karty.</param>
        /// <param name="cardStatusCodeName">Kod statusu karty.</param>
        /// <param name="cardSubtype">Podtyp karty.</param>
        /// <param name="senderName">Nazwa przekazującego.</param>
        /// <param name="receiverName">Nazwa przejmującego.</param>
        /// <param name="kpokId">Id Karty Przekazania Odpadów Komunalnych.</param>
        /// <param name="kpokLastModifiedAt">Data ostatnie modyfikacji.</param>
        /// <param name="senderFirstNameAndLastName">Imię i Nazwisko przekazującego.</param>
        /// <param name="receiverFirstAndLastName">Imię i Nazwisko przejmującego.</param>
        /// <param name="revisionNumber">Numer korekty.</param>
        /// <param name="cardRejectionTime">Data odrzucenia.</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto(DateTime? plannedTransportTime = default(DateTime?), DateTime? realTransportTime = default(DateTime?), string wasteCode = default(string), string wasteCodeDescription = default(string), string vehicleRegNumber = default(string), string cardStatus = default(string), string cardNumber = default(string), string cardStatusCodeName = default(string), string cardSubtype = default(string), string senderName = default(string), string receiverName = default(string), Guid? kpokId = default(Guid?), DateTime? kpokLastModifiedAt = default(DateTime?), string senderFirstNameAndLastName = default(string), string receiverFirstAndLastName = default(string), int? revisionNumber = default(int?), DateTime? cardRejectionTime = default(DateTime?), string additionalInfo = default(string), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string))
        {
            this.PlannedTransportTime = plannedTransportTime;
            this.RealTransportTime = realTransportTime;
            this.WasteCode = wasteCode;
            this.WasteCodeDescription = wasteCodeDescription;
            this.VehicleRegNumber = vehicleRegNumber;
            this.CardStatus = cardStatus;
            this.CardNumber = cardNumber;
            this.CardStatusCodeName = cardStatusCodeName;
            this.CardSubtype = cardSubtype;
            this.SenderName = senderName;
            this.ReceiverName = receiverName;
            this.KpokId = kpokId;
            this.KpokLastModifiedAt = kpokLastModifiedAt;
            this.SenderFirstNameAndLastName = senderFirstNameAndLastName;
            this.ReceiverFirstAndLastName = receiverFirstAndLastName;
            this.RevisionNumber = revisionNumber;
            this.CardRejectionTime = cardRejectionTime;
            this.AdditionalInfo = additionalInfo;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
        }
        
        /// <summary>
        /// Planowana data rozpoczęcia transportu
        /// </summary>
        /// <value>Planowana data rozpoczęcia transportu</value>
        [DataMember(Name="plannedTransportTime", EmitDefaultValue=false)]
        public DateTime? PlannedTransportTime { get; set; }

        /// <summary>
        /// Data rozpoczęcia transportu
        /// </summary>
        /// <value>Data rozpoczęcia transportu</value>
        [DataMember(Name="realTransportTime", EmitDefaultValue=false)]
        public DateTime? RealTransportTime { get; set; }

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
        /// Numer rejestracyjny środka transportu
        /// </summary>
        /// <value>Numer rejestracyjny środka transportu</value>
        [DataMember(Name="vehicleRegNumber", EmitDefaultValue=false)]
        public string VehicleRegNumber { get; set; }

        /// <summary>
        /// Status karty
        /// </summary>
        /// <value>Status karty</value>
        [DataMember(Name="cardStatus", EmitDefaultValue=false)]
        public string CardStatus { get; set; }

        /// <summary>
        /// Numer karty
        /// </summary>
        /// <value>Numer karty</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Kod statusu karty
        /// </summary>
        /// <value>Kod statusu karty</value>
        [DataMember(Name="cardStatusCodeName", EmitDefaultValue=false)]
        public string CardStatusCodeName { get; set; }

        /// <summary>
        /// Podtyp karty
        /// </summary>
        /// <value>Podtyp karty</value>
        [DataMember(Name="cardSubtype", EmitDefaultValue=false)]
        public string CardSubtype { get; set; }

        /// <summary>
        /// Nazwa przekazującego
        /// </summary>
        /// <value>Nazwa przekazującego</value>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Nazwa przejmującego
        /// </summary>
        /// <value>Nazwa przejmującego</value>
        [DataMember(Name="receiverName", EmitDefaultValue=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Id Karty Przekazania Odpadów Komunalnych
        /// </summary>
        /// <value>Id Karty Przekazania Odpadów Komunalnych</value>
        [DataMember(Name="kpokId", EmitDefaultValue=false)]
        public Guid? KpokId { get; set; }

        /// <summary>
        /// Data ostatnie modyfikacji
        /// </summary>
        /// <value>Data ostatnie modyfikacji</value>
        [DataMember(Name="kpokLastModifiedAt", EmitDefaultValue=false)]
        public DateTime? KpokLastModifiedAt { get; set; }

        /// <summary>
        /// Imię i Nazwisko przekazującego
        /// </summary>
        /// <value>Imię i Nazwisko przekazującego</value>
        [DataMember(Name="senderFirstNameAndLastName", EmitDefaultValue=false)]
        public string SenderFirstNameAndLastName { get; set; }

        /// <summary>
        /// Imię i Nazwisko przejmującego
        /// </summary>
        /// <value>Imię i Nazwisko przejmującego</value>
        [DataMember(Name="receiverFirstAndLastName", EmitDefaultValue=false)]
        public string ReceiverFirstAndLastName { get; set; }

        /// <summary>
        /// Numer korekty
        /// </summary>
        /// <value>Numer korekty</value>
        [DataMember(Name="revisionNumber", EmitDefaultValue=false)]
        public int? RevisionNumber { get; set; }

        /// <summary>
        /// Data odrzucenia
        /// </summary>
        /// <value>Data odrzucenia</value>
        [DataMember(Name="cardRejectionTime", EmitDefaultValue=false)]
        public DateTime? CardRejectionTime { get; set; }

        /// <summary>
        /// Informacje dodatkowe
        /// </summary>
        /// <value>Informacje dodatkowe</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public string AdditionalInfo { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto {\n");
            sb.Append("  PlannedTransportTime: ").Append(PlannedTransportTime).Append("\n");
            sb.Append("  RealTransportTime: ").Append(RealTransportTime).Append("\n");
            sb.Append("  WasteCode: ").Append(WasteCode).Append("\n");
            sb.Append("  WasteCodeDescription: ").Append(WasteCodeDescription).Append("\n");
            sb.Append("  VehicleRegNumber: ").Append(VehicleRegNumber).Append("\n");
            sb.Append("  CardStatus: ").Append(CardStatus).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardStatusCodeName: ").Append(CardStatusCodeName).Append("\n");
            sb.Append("  CardSubtype: ").Append(CardSubtype).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  ReceiverName: ").Append(ReceiverName).Append("\n");
            sb.Append("  KpokId: ").Append(KpokId).Append("\n");
            sb.Append("  KpokLastModifiedAt: ").Append(KpokLastModifiedAt).Append("\n");
            sb.Append("  SenderFirstNameAndLastName: ").Append(SenderFirstNameAndLastName).Append("\n");
            sb.Append("  ReceiverFirstAndLastName: ").Append(ReceiverFirstAndLastName).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  CardRejectionTime: ").Append(CardRejectionTime).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteTransferCardV1KpokAsSenderSearchResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlannedTransportTime == input.PlannedTransportTime ||
                    (this.PlannedTransportTime != null &&
                    this.PlannedTransportTime.Equals(input.PlannedTransportTime))
                ) && 
                (
                    this.RealTransportTime == input.RealTransportTime ||
                    (this.RealTransportTime != null &&
                    this.RealTransportTime.Equals(input.RealTransportTime))
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
                    this.VehicleRegNumber == input.VehicleRegNumber ||
                    (this.VehicleRegNumber != null &&
                    this.VehicleRegNumber.Equals(input.VehicleRegNumber))
                ) && 
                (
                    this.CardStatus == input.CardStatus ||
                    (this.CardStatus != null &&
                    this.CardStatus.Equals(input.CardStatus))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.CardStatusCodeName == input.CardStatusCodeName ||
                    (this.CardStatusCodeName != null &&
                    this.CardStatusCodeName.Equals(input.CardStatusCodeName))
                ) && 
                (
                    this.CardSubtype == input.CardSubtype ||
                    (this.CardSubtype != null &&
                    this.CardSubtype.Equals(input.CardSubtype))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.ReceiverName == input.ReceiverName ||
                    (this.ReceiverName != null &&
                    this.ReceiverName.Equals(input.ReceiverName))
                ) && 
                (
                    this.KpokId == input.KpokId ||
                    (this.KpokId != null &&
                    this.KpokId.Equals(input.KpokId))
                ) && 
                (
                    this.KpokLastModifiedAt == input.KpokLastModifiedAt ||
                    (this.KpokLastModifiedAt != null &&
                    this.KpokLastModifiedAt.Equals(input.KpokLastModifiedAt))
                ) && 
                (
                    this.SenderFirstNameAndLastName == input.SenderFirstNameAndLastName ||
                    (this.SenderFirstNameAndLastName != null &&
                    this.SenderFirstNameAndLastName.Equals(input.SenderFirstNameAndLastName))
                ) && 
                (
                    this.ReceiverFirstAndLastName == input.ReceiverFirstAndLastName ||
                    (this.ReceiverFirstAndLastName != null &&
                    this.ReceiverFirstAndLastName.Equals(input.ReceiverFirstAndLastName))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    (this.RevisionNumber != null &&
                    this.RevisionNumber.Equals(input.RevisionNumber))
                ) && 
                (
                    this.CardRejectionTime == input.CardRejectionTime ||
                    (this.CardRejectionTime != null &&
                    this.CardRejectionTime.Equals(input.CardRejectionTime))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
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
                if (this.PlannedTransportTime != null)
                    hashCode = hashCode * 59 + this.PlannedTransportTime.GetHashCode();
                if (this.RealTransportTime != null)
                    hashCode = hashCode * 59 + this.RealTransportTime.GetHashCode();
                if (this.WasteCode != null)
                    hashCode = hashCode * 59 + this.WasteCode.GetHashCode();
                if (this.WasteCodeDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeDescription.GetHashCode();
                if (this.VehicleRegNumber != null)
                    hashCode = hashCode * 59 + this.VehicleRegNumber.GetHashCode();
                if (this.CardStatus != null)
                    hashCode = hashCode * 59 + this.CardStatus.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.CardStatusCodeName != null)
                    hashCode = hashCode * 59 + this.CardStatusCodeName.GetHashCode();
                if (this.CardSubtype != null)
                    hashCode = hashCode * 59 + this.CardSubtype.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.ReceiverName != null)
                    hashCode = hashCode * 59 + this.ReceiverName.GetHashCode();
                if (this.KpokId != null)
                    hashCode = hashCode * 59 + this.KpokId.GetHashCode();
                if (this.KpokLastModifiedAt != null)
                    hashCode = hashCode * 59 + this.KpokLastModifiedAt.GetHashCode();
                if (this.SenderFirstNameAndLastName != null)
                    hashCode = hashCode * 59 + this.SenderFirstNameAndLastName.GetHashCode();
                if (this.ReceiverFirstAndLastName != null)
                    hashCode = hashCode * 59 + this.ReceiverFirstAndLastName.GetHashCode();
                if (this.RevisionNumber != null)
                    hashCode = hashCode * 59 + this.RevisionNumber.GetHashCode();
                if (this.CardRejectionTime != null)
                    hashCode = hashCode * 59 + this.CardRejectionTime.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
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
