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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest" /> class.
        /// </summary>
        /// <param name="keonItemId">Id wpisu keon.</param>
        /// <param name="receiveConfirmationTime">Data otrzymania potwierdzenia.</param>
        /// <param name="documentNumber">Numer dokumentu.</param>
        /// <param name="wasteMass">Masa odpadów.</param>
        /// <param name="senderCompanyId">Id przekazującego odpady.</param>
        /// <param name="receiverCompanyId">Id przejmującego odpady.</param>
        /// <param name="isDealer">Działalność jako sprzedawca odpadów.</param>
        /// <param name="isBroker">Działalność jako pośrednik w obrocie odpadami.</param>
        /// <param name="isKpo">Rodzaj dokumentu karta przekazania odpadów.</param>
        /// <param name="isKpok">Rodzaj dokumentu karta przekazania odpadów komunalnych.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest(Guid? keonItemId = default(Guid?), DateTime? receiveConfirmationTime = default(DateTime?), string documentNumber = default(string), double? wasteMass = default(double?), Guid? senderCompanyId = default(Guid?), Guid? receiverCompanyId = default(Guid?), bool? isDealer = default(bool?), bool? isBroker = default(bool?), bool? isKpo = default(bool?), bool? isKpok = default(bool?))
        {
            this.KeonItemId = keonItemId;
            this.ReceiveConfirmationTime = receiveConfirmationTime;
            this.DocumentNumber = documentNumber;
            this.WasteMass = wasteMass;
            this.SenderCompanyId = senderCompanyId;
            this.ReceiverCompanyId = receiverCompanyId;
            this.IsDealer = isDealer;
            this.IsBroker = isBroker;
            this.IsKpo = isKpo;
            this.IsKpok = isKpok;
        }
        
        /// <summary>
        /// Id wpisu keon
        /// </summary>
        /// <value>Id wpisu keon</value>
        [DataMember(Name="keonItemId", EmitDefaultValue=false)]
        public Guid? KeonItemId { get; set; }

        /// <summary>
        /// Data otrzymania potwierdzenia
        /// </summary>
        /// <value>Data otrzymania potwierdzenia</value>
        [DataMember(Name="receiveConfirmationTime", EmitDefaultValue=false)]
        public DateTime? ReceiveConfirmationTime { get; set; }

        /// <summary>
        /// Numer dokumentu
        /// </summary>
        /// <value>Numer dokumentu</value>
        [DataMember(Name="documentNumber", EmitDefaultValue=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Masa odpadów
        /// </summary>
        /// <value>Masa odpadów</value>
        [DataMember(Name="wasteMass", EmitDefaultValue=false)]
        public double? WasteMass { get; set; }

        /// <summary>
        /// Id przekazującego odpady
        /// </summary>
        /// <value>Id przekazującego odpady</value>
        [DataMember(Name="senderCompanyId", EmitDefaultValue=false)]
        public Guid? SenderCompanyId { get; set; }

        /// <summary>
        /// Id przejmującego odpady
        /// </summary>
        /// <value>Id przejmującego odpady</value>
        [DataMember(Name="receiverCompanyId", EmitDefaultValue=false)]
        public Guid? ReceiverCompanyId { get; set; }

        /// <summary>
        /// Działalność jako sprzedawca odpadów
        /// </summary>
        /// <value>Działalność jako sprzedawca odpadów</value>
        [DataMember(Name="isDealer", EmitDefaultValue=false)]
        public bool? IsDealer { get; set; }

        /// <summary>
        /// Działalność jako pośrednik w obrocie odpadami
        /// </summary>
        /// <value>Działalność jako pośrednik w obrocie odpadami</value>
        [DataMember(Name="isBroker", EmitDefaultValue=false)]
        public bool? IsBroker { get; set; }

        /// <summary>
        /// Rodzaj dokumentu karta przekazania odpadów
        /// </summary>
        /// <value>Rodzaj dokumentu karta przekazania odpadów</value>
        [DataMember(Name="isKpo", EmitDefaultValue=false)]
        public bool? IsKpo { get; set; }

        /// <summary>
        /// Rodzaj dokumentu karta przekazania odpadów komunalnych
        /// </summary>
        /// <value>Rodzaj dokumentu karta przekazania odpadów komunalnych</value>
        [DataMember(Name="isKpok", EmitDefaultValue=false)]
        public bool? IsKpok { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest {\n");
            sb.Append("  KeonItemId: ").Append(KeonItemId).Append("\n");
            sb.Append("  ReceiveConfirmationTime: ").Append(ReceiveConfirmationTime).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
            sb.Append("  SenderCompanyId: ").Append(SenderCompanyId).Append("\n");
            sb.Append("  ReceiverCompanyId: ").Append(ReceiverCompanyId).Append("\n");
            sb.Append("  IsDealer: ").Append(IsDealer).Append("\n");
            sb.Append("  IsBroker: ").Append(IsBroker).Append("\n");
            sb.Append("  IsKpo: ").Append(IsKpo).Append("\n");
            sb.Append("  IsKpok: ").Append(IsKpok).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeonItemId == input.KeonItemId ||
                    (this.KeonItemId != null &&
                    this.KeonItemId.Equals(input.KeonItemId))
                ) && 
                (
                    this.ReceiveConfirmationTime == input.ReceiveConfirmationTime ||
                    (this.ReceiveConfirmationTime != null &&
                    this.ReceiveConfirmationTime.Equals(input.ReceiveConfirmationTime))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.WasteMass == input.WasteMass ||
                    (this.WasteMass != null &&
                    this.WasteMass.Equals(input.WasteMass))
                ) && 
                (
                    this.SenderCompanyId == input.SenderCompanyId ||
                    (this.SenderCompanyId != null &&
                    this.SenderCompanyId.Equals(input.SenderCompanyId))
                ) && 
                (
                    this.ReceiverCompanyId == input.ReceiverCompanyId ||
                    (this.ReceiverCompanyId != null &&
                    this.ReceiverCompanyId.Equals(input.ReceiverCompanyId))
                ) && 
                (
                    this.IsDealer == input.IsDealer ||
                    (this.IsDealer != null &&
                    this.IsDealer.Equals(input.IsDealer))
                ) && 
                (
                    this.IsBroker == input.IsBroker ||
                    (this.IsBroker != null &&
                    this.IsBroker.Equals(input.IsBroker))
                ) && 
                (
                    this.IsKpo == input.IsKpo ||
                    (this.IsKpo != null &&
                    this.IsKpo.Equals(input.IsKpo))
                ) && 
                (
                    this.IsKpok == input.IsKpok ||
                    (this.IsKpok != null &&
                    this.IsKpok.Equals(input.IsKpok))
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
                if (this.KeonItemId != null)
                    hashCode = hashCode * 59 + this.KeonItemId.GetHashCode();
                if (this.ReceiveConfirmationTime != null)
                    hashCode = hashCode * 59 + this.ReceiveConfirmationTime.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
                if (this.SenderCompanyId != null)
                    hashCode = hashCode * 59 + this.SenderCompanyId.GetHashCode();
                if (this.ReceiverCompanyId != null)
                    hashCode = hashCode * 59 + this.ReceiverCompanyId.GetHashCode();
                if (this.IsDealer != null)
                    hashCode = hashCode * 59 + this.IsDealer.GetHashCode();
                if (this.IsBroker != null)
                    hashCode = hashCode * 59 + this.IsBroker.GetHashCode();
                if (this.IsKpo != null)
                    hashCode = hashCode * 59 + this.IsKpo.GetHashCode();
                if (this.IsKpok != null)
                    hashCode = hashCode * 59 + this.IsKpok.GetHashCode();
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
