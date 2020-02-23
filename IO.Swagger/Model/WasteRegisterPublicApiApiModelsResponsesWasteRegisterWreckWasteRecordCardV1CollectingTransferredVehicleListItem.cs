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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem" /> class.
        /// </summary>
        /// <param name="collectingTransferredVehiclesId">Id wpisu Prowadzący punkt zbierania pojazdów - Przekazane.</param>
        /// <param name="transferDate">Data przekazania.</param>
        /// <param name="vehiclesMass">Masa [Mg].</param>
        /// <param name="vehiclesCount">Liczba [szt.].</param>
        /// <param name="kpoCardNumber">Numer karty kpo.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem(Guid? collectingTransferredVehiclesId = default(Guid?), DateTime? transferDate = default(DateTime?), double? vehiclesMass = default(double?), int? vehiclesCount = default(int?), string kpoCardNumber = default(string), string createdByUser = default(string))
        {
            this.CollectingTransferredVehiclesId = collectingTransferredVehiclesId;
            this.TransferDate = transferDate;
            this.VehiclesMass = vehiclesMass;
            this.VehiclesCount = vehiclesCount;
            this.KpoCardNumber = kpoCardNumber;
            this.CreatedByUser = createdByUser;
        }
        
        /// <summary>
        /// Id wpisu Prowadzący punkt zbierania pojazdów - Przekazane
        /// </summary>
        /// <value>Id wpisu Prowadzący punkt zbierania pojazdów - Przekazane</value>
        [DataMember(Name="collectingTransferredVehiclesId", EmitDefaultValue=false)]
        public Guid? CollectingTransferredVehiclesId { get; set; }

        /// <summary>
        /// Data przekazania
        /// </summary>
        /// <value>Data przekazania</value>
        [DataMember(Name="transferDate", EmitDefaultValue=false)]
        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// Masa [Mg]
        /// </summary>
        /// <value>Masa [Mg]</value>
        [DataMember(Name="vehiclesMass", EmitDefaultValue=false)]
        public double? VehiclesMass { get; set; }

        /// <summary>
        /// Liczba [szt.]
        /// </summary>
        /// <value>Liczba [szt.]</value>
        [DataMember(Name="vehiclesCount", EmitDefaultValue=false)]
        public int? VehiclesCount { get; set; }

        /// <summary>
        /// Numer karty kpo
        /// </summary>
        /// <value>Numer karty kpo</value>
        [DataMember(Name="kpoCardNumber", EmitDefaultValue=false)]
        public string KpoCardNumber { get; set; }

        /// <summary>
        /// Utworzone przez użytkownika
        /// </summary>
        /// <value>Utworzone przez użytkownika</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem {\n");
            sb.Append("  CollectingTransferredVehiclesId: ").Append(CollectingTransferredVehiclesId).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  VehiclesMass: ").Append(VehiclesMass).Append("\n");
            sb.Append("  VehiclesCount: ").Append(VehiclesCount).Append("\n");
            sb.Append("  KpoCardNumber: ").Append(KpoCardNumber).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1CollectingTransferredVehicleListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectingTransferredVehiclesId == input.CollectingTransferredVehiclesId ||
                    (this.CollectingTransferredVehiclesId != null &&
                    this.CollectingTransferredVehiclesId.Equals(input.CollectingTransferredVehiclesId))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                ) && 
                (
                    this.VehiclesMass == input.VehiclesMass ||
                    (this.VehiclesMass != null &&
                    this.VehiclesMass.Equals(input.VehiclesMass))
                ) && 
                (
                    this.VehiclesCount == input.VehiclesCount ||
                    (this.VehiclesCount != null &&
                    this.VehiclesCount.Equals(input.VehiclesCount))
                ) && 
                (
                    this.KpoCardNumber == input.KpoCardNumber ||
                    (this.KpoCardNumber != null &&
                    this.KpoCardNumber.Equals(input.KpoCardNumber))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
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
                if (this.CollectingTransferredVehiclesId != null)
                    hashCode = hashCode * 59 + this.CollectingTransferredVehiclesId.GetHashCode();
                if (this.TransferDate != null)
                    hashCode = hashCode * 59 + this.TransferDate.GetHashCode();
                if (this.VehiclesMass != null)
                    hashCode = hashCode * 59 + this.VehiclesMass.GetHashCode();
                if (this.VehiclesCount != null)
                    hashCode = hashCode * 59 + this.VehiclesCount.GetHashCode();
                if (this.KpoCardNumber != null)
                    hashCode = hashCode * 59 + this.KpoCardNumber.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
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
