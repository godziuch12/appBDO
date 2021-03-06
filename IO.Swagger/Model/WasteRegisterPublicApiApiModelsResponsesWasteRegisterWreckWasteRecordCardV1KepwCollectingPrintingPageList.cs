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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList" /> class.
        /// </summary>
        /// <param name="date">Data.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="receivedVehicleMass">Masa przyjętych pojazdów [Mg].</param>
        /// <param name="receivedVehiclesCount">Liczba przyjętych pojazdów [szt.].</param>
        /// <param name="receivedKepwCardNumber">Przyjęte - Numer karty przekazania odpadów.</param>
        /// <param name="transferredVehicleMass">Masa przekazanych pojazdów [Mg].</param>
        /// <param name="transferredVehiclesCount">Liczba przekazanych pojazdów [szt.].</param>
        /// <param name="transferredKepwCardNumber">Przekazane - Numer karty przekazania odpadów.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList(DateTime? date = default(DateTime?), string createdByUser = default(string), double? receivedVehicleMass = default(double?), int? receivedVehiclesCount = default(int?), string receivedKepwCardNumber = default(string), double? transferredVehicleMass = default(double?), int? transferredVehiclesCount = default(int?), string transferredKepwCardNumber = default(string))
        {
            this.Date = date;
            this.CreatedByUser = createdByUser;
            this.ReceivedVehicleMass = receivedVehicleMass;
            this.ReceivedVehiclesCount = receivedVehiclesCount;
            this.ReceivedKepwCardNumber = receivedKepwCardNumber;
            this.TransferredVehicleMass = transferredVehicleMass;
            this.TransferredVehiclesCount = transferredVehiclesCount;
            this.TransferredKepwCardNumber = transferredKepwCardNumber;
        }
        
        /// <summary>
        /// Data
        /// </summary>
        /// <value>Data</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Utworzone przez użytkownika
        /// </summary>
        /// <value>Utworzone przez użytkownika</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Masa przyjętych pojazdów [Mg]
        /// </summary>
        /// <value>Masa przyjętych pojazdów [Mg]</value>
        [DataMember(Name="receivedVehicleMass", EmitDefaultValue=false)]
        public double? ReceivedVehicleMass { get; set; }

        /// <summary>
        /// Liczba przyjętych pojazdów [szt.]
        /// </summary>
        /// <value>Liczba przyjętych pojazdów [szt.]</value>
        [DataMember(Name="receivedVehiclesCount", EmitDefaultValue=false)]
        public int? ReceivedVehiclesCount { get; set; }

        /// <summary>
        /// Przyjęte - Numer karty przekazania odpadów
        /// </summary>
        /// <value>Przyjęte - Numer karty przekazania odpadów</value>
        [DataMember(Name="receivedKepwCardNumber", EmitDefaultValue=false)]
        public string ReceivedKepwCardNumber { get; set; }

        /// <summary>
        /// Masa przekazanych pojazdów [Mg]
        /// </summary>
        /// <value>Masa przekazanych pojazdów [Mg]</value>
        [DataMember(Name="transferredVehicleMass", EmitDefaultValue=false)]
        public double? TransferredVehicleMass { get; set; }

        /// <summary>
        /// Liczba przekazanych pojazdów [szt.]
        /// </summary>
        /// <value>Liczba przekazanych pojazdów [szt.]</value>
        [DataMember(Name="transferredVehiclesCount", EmitDefaultValue=false)]
        public int? TransferredVehiclesCount { get; set; }

        /// <summary>
        /// Przekazane - Numer karty przekazania odpadów
        /// </summary>
        /// <value>Przekazane - Numer karty przekazania odpadów</value>
        [DataMember(Name="transferredKepwCardNumber", EmitDefaultValue=false)]
        public string TransferredKepwCardNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  ReceivedVehicleMass: ").Append(ReceivedVehicleMass).Append("\n");
            sb.Append("  ReceivedVehiclesCount: ").Append(ReceivedVehiclesCount).Append("\n");
            sb.Append("  ReceivedKepwCardNumber: ").Append(ReceivedKepwCardNumber).Append("\n");
            sb.Append("  TransferredVehicleMass: ").Append(TransferredVehicleMass).Append("\n");
            sb.Append("  TransferredVehiclesCount: ").Append(TransferredVehiclesCount).Append("\n");
            sb.Append("  TransferredKepwCardNumber: ").Append(TransferredKepwCardNumber).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWreckWasteRecordCardV1KepwCollectingPrintingPageList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
                ) && 
                (
                    this.ReceivedVehicleMass == input.ReceivedVehicleMass ||
                    (this.ReceivedVehicleMass != null &&
                    this.ReceivedVehicleMass.Equals(input.ReceivedVehicleMass))
                ) && 
                (
                    this.ReceivedVehiclesCount == input.ReceivedVehiclesCount ||
                    (this.ReceivedVehiclesCount != null &&
                    this.ReceivedVehiclesCount.Equals(input.ReceivedVehiclesCount))
                ) && 
                (
                    this.ReceivedKepwCardNumber == input.ReceivedKepwCardNumber ||
                    (this.ReceivedKepwCardNumber != null &&
                    this.ReceivedKepwCardNumber.Equals(input.ReceivedKepwCardNumber))
                ) && 
                (
                    this.TransferredVehicleMass == input.TransferredVehicleMass ||
                    (this.TransferredVehicleMass != null &&
                    this.TransferredVehicleMass.Equals(input.TransferredVehicleMass))
                ) && 
                (
                    this.TransferredVehiclesCount == input.TransferredVehiclesCount ||
                    (this.TransferredVehiclesCount != null &&
                    this.TransferredVehiclesCount.Equals(input.TransferredVehiclesCount))
                ) && 
                (
                    this.TransferredKepwCardNumber == input.TransferredKepwCardNumber ||
                    (this.TransferredKepwCardNumber != null &&
                    this.TransferredKepwCardNumber.Equals(input.TransferredKepwCardNumber))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
                if (this.ReceivedVehicleMass != null)
                    hashCode = hashCode * 59 + this.ReceivedVehicleMass.GetHashCode();
                if (this.ReceivedVehiclesCount != null)
                    hashCode = hashCode * 59 + this.ReceivedVehiclesCount.GetHashCode();
                if (this.ReceivedKepwCardNumber != null)
                    hashCode = hashCode * 59 + this.ReceivedKepwCardNumber.GetHashCode();
                if (this.TransferredVehicleMass != null)
                    hashCode = hashCode * 59 + this.TransferredVehicleMass.GetHashCode();
                if (this.TransferredVehiclesCount != null)
                    hashCode = hashCode * 59 + this.TransferredVehiclesCount.GetHashCode();
                if (this.TransferredKepwCardNumber != null)
                    hashCode = hashCode * 59 + this.TransferredKepwCardNumber.GetHashCode();
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
