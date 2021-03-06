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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest" /> class.
        /// </summary>
        /// <param name="carrierCompanyId">Id podmiotu transportującego odpady.</param>
        /// <param name="receiverCompanyId">Id podmiotu przejmującego odpady.</param>
        /// <param name="receiverEupId">Id miejsca prowadzenia działalności podmiotu przejmującego odpady.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="vehicleRegNumber">Numer rejestracyjny środka transportu.</param>
        /// <param name="wasteMass">Masa odpadów.</param>
        /// <param name="plannedTransportTime">Data i godzina rozpoczęcia transportu.</param>
        /// <param name="wasteProcessId">Id rodzaju procesu przetwarzania.</param>
        /// <param name="certificateNumberAndBoxNumbers">Numer certyfikatu oraz numery pojemników.</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest(Guid? carrierCompanyId = default(Guid?), Guid? receiverCompanyId = default(Guid?), Guid? receiverEupId = default(Guid?), int? wasteCodeId = default(int?), string vehicleRegNumber = default(string), double? wasteMass = default(double?), DateTime? plannedTransportTime = default(DateTime?), int? wasteProcessId = default(int?), string certificateNumberAndBoxNumbers = default(string), string additionalInfo = default(string), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string))
        {
            this.CarrierCompanyId = carrierCompanyId;
            this.ReceiverCompanyId = receiverCompanyId;
            this.ReceiverEupId = receiverEupId;
            this.WasteCodeId = wasteCodeId;
            this.VehicleRegNumber = vehicleRegNumber;
            this.WasteMass = wasteMass;
            this.PlannedTransportTime = plannedTransportTime;
            this.WasteProcessId = wasteProcessId;
            this.CertificateNumberAndBoxNumbers = certificateNumberAndBoxNumbers;
            this.AdditionalInfo = additionalInfo;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
        }
        
        /// <summary>
        /// Id podmiotu transportującego odpady
        /// </summary>
        /// <value>Id podmiotu transportującego odpady</value>
        [DataMember(Name="carrierCompanyId", EmitDefaultValue=false)]
        public Guid? CarrierCompanyId { get; set; }

        /// <summary>
        /// Id podmiotu przejmującego odpady
        /// </summary>
        /// <value>Id podmiotu przejmującego odpady</value>
        [DataMember(Name="receiverCompanyId", EmitDefaultValue=false)]
        public Guid? ReceiverCompanyId { get; set; }

        /// <summary>
        /// Id miejsca prowadzenia działalności podmiotu przejmującego odpady
        /// </summary>
        /// <value>Id miejsca prowadzenia działalności podmiotu przejmującego odpady</value>
        [DataMember(Name="receiverEupId", EmitDefaultValue=false)]
        public Guid? ReceiverEupId { get; set; }

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
        /// Data i godzina rozpoczęcia transportu
        /// </summary>
        /// <value>Data i godzina rozpoczęcia transportu</value>
        [DataMember(Name="plannedTransportTime", EmitDefaultValue=false)]
        public DateTime? PlannedTransportTime { get; set; }

        /// <summary>
        /// Id rodzaju procesu przetwarzania
        /// </summary>
        /// <value>Id rodzaju procesu przetwarzania</value>
        [DataMember(Name="wasteProcessId", EmitDefaultValue=false)]
        public int? WasteProcessId { get; set; }

        /// <summary>
        /// Numer certyfikatu oraz numery pojemników
        /// </summary>
        /// <value>Numer certyfikatu oraz numery pojemników</value>
        [DataMember(Name="certificateNumberAndBoxNumbers", EmitDefaultValue=false)]
        public string CertificateNumberAndBoxNumbers { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest {\n");
            sb.Append("  CarrierCompanyId: ").Append(CarrierCompanyId).Append("\n");
            sb.Append("  ReceiverCompanyId: ").Append(ReceiverCompanyId).Append("\n");
            sb.Append("  ReceiverEupId: ").Append(ReceiverEupId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  VehicleRegNumber: ").Append(VehicleRegNumber).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
            sb.Append("  PlannedTransportTime: ").Append(PlannedTransportTime).Append("\n");
            sb.Append("  WasteProcessId: ").Append(WasteProcessId).Append("\n");
            sb.Append("  CertificateNumberAndBoxNumbers: ").Append(CertificateNumberAndBoxNumbers).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteTransferCardV1PlanKpoRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.WasteProcessId == input.WasteProcessId ||
                    (this.WasteProcessId != null &&
                    this.WasteProcessId.Equals(input.WasteProcessId))
                ) && 
                (
                    this.CertificateNumberAndBoxNumbers == input.CertificateNumberAndBoxNumbers ||
                    (this.CertificateNumberAndBoxNumbers != null &&
                    this.CertificateNumberAndBoxNumbers.Equals(input.CertificateNumberAndBoxNumbers))
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
                if (this.CarrierCompanyId != null)
                    hashCode = hashCode * 59 + this.CarrierCompanyId.GetHashCode();
                if (this.ReceiverCompanyId != null)
                    hashCode = hashCode * 59 + this.ReceiverCompanyId.GetHashCode();
                if (this.ReceiverEupId != null)
                    hashCode = hashCode * 59 + this.ReceiverEupId.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.VehicleRegNumber != null)
                    hashCode = hashCode * 59 + this.VehicleRegNumber.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
                if (this.PlannedTransportTime != null)
                    hashCode = hashCode * 59 + this.PlannedTransportTime.GetHashCode();
                if (this.WasteProcessId != null)
                    hashCode = hashCode * 59 + this.WasteProcessId.GetHashCode();
                if (this.CertificateNumberAndBoxNumbers != null)
                    hashCode = hashCode * 59 + this.CertificateNumberAndBoxNumbers.GetHashCode();
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
