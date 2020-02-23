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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem" /> class.
        /// </summary>
        /// <param name="keokReceivedId">keokReceivedId.</param>
        /// <param name="receiveDate">Data przyjęcia.</param>
        /// <param name="kpokCardNumber">kpokCardNumber.</param>
        /// <param name="receivedWasteMass">receivedWasteMass.</param>
        /// <param name="receivedWithKpok">receivedWithKpok.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem(Guid? keokReceivedId = default(Guid?), DateTime? receiveDate = default(DateTime?), string kpokCardNumber = default(string), double? receivedWasteMass = default(double?), bool? receivedWithKpok = default(bool?), string createdByUser = default(string), string installationName = default(string))
        {
            this.KeokReceivedId = keokReceivedId;
            this.ReceiveDate = receiveDate;
            this.KpokCardNumber = kpokCardNumber;
            this.ReceivedWasteMass = receivedWasteMass;
            this.ReceivedWithKpok = receivedWithKpok;
            this.CreatedByUser = createdByUser;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Gets or Sets KeokReceivedId
        /// </summary>
        [DataMember(Name="keokReceivedId", EmitDefaultValue=false)]
        public Guid? KeokReceivedId { get; set; }

        /// <summary>
        /// Data przyjęcia
        /// </summary>
        /// <value>Data przyjęcia</value>
        [DataMember(Name="receiveDate", EmitDefaultValue=false)]
        public DateTime? ReceiveDate { get; set; }

        /// <summary>
        /// Gets or Sets KpokCardNumber
        /// </summary>
        [DataMember(Name="kpokCardNumber", EmitDefaultValue=false)]
        public string KpokCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedWasteMass
        /// </summary>
        [DataMember(Name="receivedWasteMass", EmitDefaultValue=false)]
        public double? ReceivedWasteMass { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedWithKpok
        /// </summary>
        [DataMember(Name="receivedWithKpok", EmitDefaultValue=false)]
        public bool? ReceivedWithKpok { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem {\n");
            sb.Append("  KeokReceivedId: ").Append(KeokReceivedId).Append("\n");
            sb.Append("  ReceiveDate: ").Append(ReceiveDate).Append("\n");
            sb.Append("  KpokCardNumber: ").Append(KpokCardNumber).Append("\n");
            sb.Append("  ReceivedWasteMass: ").Append(ReceivedWasteMass).Append("\n");
            sb.Append("  ReceivedWithKpok: ").Append(ReceivedWithKpok).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  InstallationName: ").Append(InstallationName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMuncipalWasteRecordCardV1KeokReceivedListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeokReceivedId == input.KeokReceivedId ||
                    (this.KeokReceivedId != null &&
                    this.KeokReceivedId.Equals(input.KeokReceivedId))
                ) && 
                (
                    this.ReceiveDate == input.ReceiveDate ||
                    (this.ReceiveDate != null &&
                    this.ReceiveDate.Equals(input.ReceiveDate))
                ) && 
                (
                    this.KpokCardNumber == input.KpokCardNumber ||
                    (this.KpokCardNumber != null &&
                    this.KpokCardNumber.Equals(input.KpokCardNumber))
                ) && 
                (
                    this.ReceivedWasteMass == input.ReceivedWasteMass ||
                    (this.ReceivedWasteMass != null &&
                    this.ReceivedWasteMass.Equals(input.ReceivedWasteMass))
                ) && 
                (
                    this.ReceivedWithKpok == input.ReceivedWithKpok ||
                    (this.ReceivedWithKpok != null &&
                    this.ReceivedWithKpok.Equals(input.ReceivedWithKpok))
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
                if (this.KeokReceivedId != null)
                    hashCode = hashCode * 59 + this.KeokReceivedId.GetHashCode();
                if (this.ReceiveDate != null)
                    hashCode = hashCode * 59 + this.ReceiveDate.GetHashCode();
                if (this.KpokCardNumber != null)
                    hashCode = hashCode * 59 + this.KpokCardNumber.GetHashCode();
                if (this.ReceivedWasteMass != null)
                    hashCode = hashCode * 59 + this.ReceivedWasteMass.GetHashCode();
                if (this.ReceivedWithKpok != null)
                    hashCode = hashCode * 59 + this.ReceivedWithKpok.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
                if (this.InstallationName != null)
                    hashCode = hashCode * 59 + this.InstallationName.GetHashCode();
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
