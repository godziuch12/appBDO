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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse" /> class.
        /// </summary>
        /// <param name="initialVehiclesMass">Masa pojazdów [Mg].</param>
        /// <param name="initialVehiclesCount">Liczba pojazdów [szt.].</param>
        /// <param name="vehiclesMassSummary">Łączna masa przyjętych pojazdów [Mg].</param>
        /// <param name="vehiclesCountSummary">Łączna liczba przyjętych pojazdów [szt.].</param>
        /// <param name="wasteCode">Kod odpadu.</param>
        /// <param name="cardNumber">Numer karty.</param>
        /// <param name="year">Rok kalendarzowy.</param>
        /// <param name="isDismantle">Prowadzący stację demontażu.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        /// <param name="dismantleReceivedVehicles">dismantleReceivedVehicles.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse(double? initialVehiclesMass = default(double?), int? initialVehiclesCount = default(int?), double? vehiclesMassSummary = default(double?), int? vehiclesCountSummary = default(int?), string wasteCode = default(string), string cardNumber = default(string), int? year = default(int?), bool? isDismantle = default(bool?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string), WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1PaginatedPageDismantleReceivedVehicleListItem dismantleReceivedVehicles = default(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1PaginatedPageDismantleReceivedVehicleListItem))
        {
            this.InitialVehiclesMass = initialVehiclesMass;
            this.InitialVehiclesCount = initialVehiclesCount;
            this.VehiclesMassSummary = vehiclesMassSummary;
            this.VehiclesCountSummary = vehiclesCountSummary;
            this.WasteCode = wasteCode;
            this.CardNumber = cardNumber;
            this.Year = year;
            this.IsDismantle = isDismantle;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
            this.DismantleReceivedVehicles = dismantleReceivedVehicles;
        }
        
        /// <summary>
        /// Masa pojazdów [Mg]
        /// </summary>
        /// <value>Masa pojazdów [Mg]</value>
        [DataMember(Name="initialVehiclesMass", EmitDefaultValue=false)]
        public double? InitialVehiclesMass { get; set; }

        /// <summary>
        /// Liczba pojazdów [szt.]
        /// </summary>
        /// <value>Liczba pojazdów [szt.]</value>
        [DataMember(Name="initialVehiclesCount", EmitDefaultValue=false)]
        public int? InitialVehiclesCount { get; set; }

        /// <summary>
        /// Łączna masa przyjętych pojazdów [Mg]
        /// </summary>
        /// <value>Łączna masa przyjętych pojazdów [Mg]</value>
        [DataMember(Name="vehiclesMassSummary", EmitDefaultValue=false)]
        public double? VehiclesMassSummary { get; set; }

        /// <summary>
        /// Łączna liczba przyjętych pojazdów [szt.]
        /// </summary>
        /// <value>Łączna liczba przyjętych pojazdów [szt.]</value>
        [DataMember(Name="vehiclesCountSummary", EmitDefaultValue=false)]
        public int? VehiclesCountSummary { get; set; }

        /// <summary>
        /// Kod odpadu
        /// </summary>
        /// <value>Kod odpadu</value>
        [DataMember(Name="wasteCode", EmitDefaultValue=false)]
        public string WasteCode { get; set; }

        /// <summary>
        /// Numer karty
        /// </summary>
        /// <value>Numer karty</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Rok kalendarzowy
        /// </summary>
        /// <value>Rok kalendarzowy</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Prowadzący stację demontażu
        /// </summary>
        /// <value>Prowadzący stację demontażu</value>
        [DataMember(Name="isDismantle", EmitDefaultValue=false)]
        public bool? IsDismantle { get; set; }

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
        /// Gets or Sets DismantleReceivedVehicles
        /// </summary>
        [DataMember(Name="dismantleReceivedVehicles", EmitDefaultValue=false)]
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1PaginatedPageDismantleReceivedVehicleListItem DismantleReceivedVehicles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse {\n");
            sb.Append("  InitialVehiclesMass: ").Append(InitialVehiclesMass).Append("\n");
            sb.Append("  InitialVehiclesCount: ").Append(InitialVehiclesCount).Append("\n");
            sb.Append("  VehiclesMassSummary: ").Append(VehiclesMassSummary).Append("\n");
            sb.Append("  VehiclesCountSummary: ").Append(VehiclesCountSummary).Append("\n");
            sb.Append("  WasteCode: ").Append(WasteCode).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  IsDismantle: ").Append(IsDismantle).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
            sb.Append("  HazardousWasteReclassification: ").Append(HazardousWasteReclassification).Append("\n");
            sb.Append("  HazardousWasteReclassificationDescription: ").Append(HazardousWasteReclassificationDescription).Append("\n");
            sb.Append("  DismantleReceivedVehicles: ").Append(DismantleReceivedVehicles).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1GetDismantleReceivedVehiclesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InitialVehiclesMass == input.InitialVehiclesMass ||
                    (this.InitialVehiclesMass != null &&
                    this.InitialVehiclesMass.Equals(input.InitialVehiclesMass))
                ) && 
                (
                    this.InitialVehiclesCount == input.InitialVehiclesCount ||
                    (this.InitialVehiclesCount != null &&
                    this.InitialVehiclesCount.Equals(input.InitialVehiclesCount))
                ) && 
                (
                    this.VehiclesMassSummary == input.VehiclesMassSummary ||
                    (this.VehiclesMassSummary != null &&
                    this.VehiclesMassSummary.Equals(input.VehiclesMassSummary))
                ) && 
                (
                    this.VehiclesCountSummary == input.VehiclesCountSummary ||
                    (this.VehiclesCountSummary != null &&
                    this.VehiclesCountSummary.Equals(input.VehiclesCountSummary))
                ) && 
                (
                    this.WasteCode == input.WasteCode ||
                    (this.WasteCode != null &&
                    this.WasteCode.Equals(input.WasteCode))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.IsDismantle == input.IsDismantle ||
                    (this.IsDismantle != null &&
                    this.IsDismantle.Equals(input.IsDismantle))
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
                    this.DismantleReceivedVehicles == input.DismantleReceivedVehicles ||
                    (this.DismantleReceivedVehicles != null &&
                    this.DismantleReceivedVehicles.Equals(input.DismantleReceivedVehicles))
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
                if (this.InitialVehiclesMass != null)
                    hashCode = hashCode * 59 + this.InitialVehiclesMass.GetHashCode();
                if (this.InitialVehiclesCount != null)
                    hashCode = hashCode * 59 + this.InitialVehiclesCount.GetHashCode();
                if (this.VehiclesMassSummary != null)
                    hashCode = hashCode * 59 + this.VehiclesMassSummary.GetHashCode();
                if (this.VehiclesCountSummary != null)
                    hashCode = hashCode * 59 + this.VehiclesCountSummary.GetHashCode();
                if (this.WasteCode != null)
                    hashCode = hashCode * 59 + this.WasteCode.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.IsDismantle != null)
                    hashCode = hashCode * 59 + this.IsDismantle.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
                if (this.HazardousWasteReclassification != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassification.GetHashCode();
                if (this.HazardousWasteReclassificationDescription != null)
                    hashCode = hashCode * 59 + this.HazardousWasteReclassificationDescription.GetHashCode();
                if (this.DismantleReceivedVehicles != null)
                    hashCode = hashCode * 59 + this.DismantleReceivedVehicles.GetHashCode();
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
