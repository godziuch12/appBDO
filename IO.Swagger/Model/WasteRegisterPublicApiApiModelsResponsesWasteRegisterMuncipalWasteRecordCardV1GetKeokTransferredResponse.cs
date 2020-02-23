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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse" /> class.
        /// </summary>
        /// <param name="keokTransferredId">keokTransferredId.</param>
        /// <param name="keokId">keokId.</param>
        /// <param name="transferredWasteMass">transferredWasteMass.</param>
        /// <param name="transportDate">transportDate.</param>
        /// <param name="kpokId">Id Karty Przekazania Odpadów Komunalnych.</param>
        /// <param name="kpokCardNumber">kpokCardNumber.</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse(Guid? keokTransferredId = default(Guid?), Guid? keokId = default(Guid?), double? transferredWasteMass = default(double?), DateTime? transportDate = default(DateTime?), Guid? kpokId = default(Guid?), string kpokCardNumber = default(string), string additionalInfo = default(string), string createdByUser = default(string))
        {
            this.KeokTransferredId = keokTransferredId;
            this.KeokId = keokId;
            this.TransferredWasteMass = transferredWasteMass;
            this.TransportDate = transportDate;
            this.KpokId = kpokId;
            this.KpokCardNumber = kpokCardNumber;
            this.AdditionalInfo = additionalInfo;
            this.CreatedByUser = createdByUser;
        }
        
        /// <summary>
        /// Gets or Sets KeokTransferredId
        /// </summary>
        [DataMember(Name="keokTransferredId", EmitDefaultValue=false)]
        public Guid? KeokTransferredId { get; set; }

        /// <summary>
        /// Gets or Sets KeokId
        /// </summary>
        [DataMember(Name="keokId", EmitDefaultValue=false)]
        public Guid? KeokId { get; set; }

        /// <summary>
        /// Gets or Sets TransferredWasteMass
        /// </summary>
        [DataMember(Name="transferredWasteMass", EmitDefaultValue=false)]
        public double? TransferredWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets TransportDate
        /// </summary>
        [DataMember(Name="transportDate", EmitDefaultValue=false)]
        public DateTime? TransportDate { get; set; }

        /// <summary>
        /// Id Karty Przekazania Odpadów Komunalnych
        /// </summary>
        /// <value>Id Karty Przekazania Odpadów Komunalnych</value>
        [DataMember(Name="kpokId", EmitDefaultValue=false)]
        public Guid? KpokId { get; set; }

        /// <summary>
        /// Gets or Sets KpokCardNumber
        /// </summary>
        [DataMember(Name="kpokCardNumber", EmitDefaultValue=false)]
        public string KpokCardNumber { get; set; }

        /// <summary>
        /// Informacje dodatkowe
        /// </summary>
        /// <value>Informacje dodatkowe</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public string AdditionalInfo { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse {\n");
            sb.Append("  KeokTransferredId: ").Append(KeokTransferredId).Append("\n");
            sb.Append("  KeokId: ").Append(KeokId).Append("\n");
            sb.Append("  TransferredWasteMass: ").Append(TransferredWasteMass).Append("\n");
            sb.Append("  TransportDate: ").Append(TransportDate).Append("\n");
            sb.Append("  KpokId: ").Append(KpokId).Append("\n");
            sb.Append("  KpokCardNumber: ").Append(KpokCardNumber).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1GetKeokTransferredResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeokTransferredId == input.KeokTransferredId ||
                    (this.KeokTransferredId != null &&
                    this.KeokTransferredId.Equals(input.KeokTransferredId))
                ) && 
                (
                    this.KeokId == input.KeokId ||
                    (this.KeokId != null &&
                    this.KeokId.Equals(input.KeokId))
                ) && 
                (
                    this.TransferredWasteMass == input.TransferredWasteMass ||
                    (this.TransferredWasteMass != null &&
                    this.TransferredWasteMass.Equals(input.TransferredWasteMass))
                ) && 
                (
                    this.TransportDate == input.TransportDate ||
                    (this.TransportDate != null &&
                    this.TransportDate.Equals(input.TransportDate))
                ) && 
                (
                    this.KpokId == input.KpokId ||
                    (this.KpokId != null &&
                    this.KpokId.Equals(input.KpokId))
                ) && 
                (
                    this.KpokCardNumber == input.KpokCardNumber ||
                    (this.KpokCardNumber != null &&
                    this.KpokCardNumber.Equals(input.KpokCardNumber))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
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
                if (this.KeokTransferredId != null)
                    hashCode = hashCode * 59 + this.KeokTransferredId.GetHashCode();
                if (this.KeokId != null)
                    hashCode = hashCode * 59 + this.KeokId.GetHashCode();
                if (this.TransferredWasteMass != null)
                    hashCode = hashCode * 59 + this.TransferredWasteMass.GetHashCode();
                if (this.TransportDate != null)
                    hashCode = hashCode * 59 + this.TransportDate.GetHashCode();
                if (this.KpokId != null)
                    hashCode = hashCode * 59 + this.KpokId.GetHashCode();
                if (this.KpokCardNumber != null)
                    hashCode = hashCode * 59 + this.KpokCardNumber.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
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
