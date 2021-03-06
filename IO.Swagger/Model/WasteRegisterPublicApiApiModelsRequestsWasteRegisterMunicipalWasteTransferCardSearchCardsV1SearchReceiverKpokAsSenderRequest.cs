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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest" /> class.
        /// </summary>
        /// <param name="pageSize">Maksymalna liczba wyników wyszukiwania.</param>
        /// <param name="receiverIdentificationNumber">Numer identyfikacyjny podmiotu przejmującego.</param>
        /// <param name="receiverName">Nazwa podmiotu przejmującego.</param>
        /// <param name="receiverNip">NIP podmiotu przejmującego.</param>
        /// <param name="cardNumber">Numer karty.</param>
        /// <param name="receiveConfirmationTime">Data otrzymania potwierdzenia.</param>
        /// <param name="cardStatusCodeNames">Lista statusów Kart Przekazania Odpadów Komunalnych rozdzielona średnikami. Słownik wartości dostępny w kontrolerze CardStatus.</param>
        /// <param name="wasteCodeName">Kod odpadów.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest(long? pageSize = default(long?), string receiverIdentificationNumber = default(string), string receiverName = default(string), string receiverNip = default(string), string cardNumber = default(string), DateTime? receiveConfirmationTime = default(DateTime?), string cardStatusCodeNames = default(string), string wasteCodeName = default(string))
        {
            this.PageSize = pageSize;
            this.ReceiverIdentificationNumber = receiverIdentificationNumber;
            this.ReceiverName = receiverName;
            this.ReceiverNip = receiverNip;
            this.CardNumber = cardNumber;
            this.ReceiveConfirmationTime = receiveConfirmationTime;
            this.CardStatusCodeNames = cardStatusCodeNames;
            this.WasteCodeName = wasteCodeName;
        }
        
        /// <summary>
        /// Maksymalna liczba wyników wyszukiwania
        /// </summary>
        /// <value>Maksymalna liczba wyników wyszukiwania</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Numer identyfikacyjny podmiotu przejmującego
        /// </summary>
        /// <value>Numer identyfikacyjny podmiotu przejmującego</value>
        [DataMember(Name="receiverIdentificationNumber", EmitDefaultValue=false)]
        public string ReceiverIdentificationNumber { get; set; }

        /// <summary>
        /// Nazwa podmiotu przejmującego
        /// </summary>
        /// <value>Nazwa podmiotu przejmującego</value>
        [DataMember(Name="receiverName", EmitDefaultValue=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// NIP podmiotu przejmującego
        /// </summary>
        /// <value>NIP podmiotu przejmującego</value>
        [DataMember(Name="receiverNip", EmitDefaultValue=false)]
        public string ReceiverNip { get; set; }

        /// <summary>
        /// Numer karty
        /// </summary>
        /// <value>Numer karty</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Data otrzymania potwierdzenia
        /// </summary>
        /// <value>Data otrzymania potwierdzenia</value>
        [DataMember(Name="receiveConfirmationTime", EmitDefaultValue=false)]
        public DateTime? ReceiveConfirmationTime { get; set; }

        /// <summary>
        /// Lista statusów Kart Przekazania Odpadów Komunalnych rozdzielona średnikami. Słownik wartości dostępny w kontrolerze CardStatus
        /// </summary>
        /// <value>Lista statusów Kart Przekazania Odpadów Komunalnych rozdzielona średnikami. Słownik wartości dostępny w kontrolerze CardStatus</value>
        [DataMember(Name="cardStatusCodeNames", EmitDefaultValue=false)]
        public string CardStatusCodeNames { get; set; }

        /// <summary>
        /// Kod odpadów
        /// </summary>
        /// <value>Kod odpadów</value>
        [DataMember(Name="wasteCodeName", EmitDefaultValue=false)]
        public string WasteCodeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ReceiverIdentificationNumber: ").Append(ReceiverIdentificationNumber).Append("\n");
            sb.Append("  ReceiverName: ").Append(ReceiverName).Append("\n");
            sb.Append("  ReceiverNip: ").Append(ReceiverNip).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  ReceiveConfirmationTime: ").Append(ReceiveConfirmationTime).Append("\n");
            sb.Append("  CardStatusCodeNames: ").Append(CardStatusCodeNames).Append("\n");
            sb.Append("  WasteCodeName: ").Append(WasteCodeName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteTransferCardSearchCardsV1SearchReceiverKpokAsSenderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.ReceiverIdentificationNumber == input.ReceiverIdentificationNumber ||
                    (this.ReceiverIdentificationNumber != null &&
                    this.ReceiverIdentificationNumber.Equals(input.ReceiverIdentificationNumber))
                ) && 
                (
                    this.ReceiverName == input.ReceiverName ||
                    (this.ReceiverName != null &&
                    this.ReceiverName.Equals(input.ReceiverName))
                ) && 
                (
                    this.ReceiverNip == input.ReceiverNip ||
                    (this.ReceiverNip != null &&
                    this.ReceiverNip.Equals(input.ReceiverNip))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.ReceiveConfirmationTime == input.ReceiveConfirmationTime ||
                    (this.ReceiveConfirmationTime != null &&
                    this.ReceiveConfirmationTime.Equals(input.ReceiveConfirmationTime))
                ) && 
                (
                    this.CardStatusCodeNames == input.CardStatusCodeNames ||
                    (this.CardStatusCodeNames != null &&
                    this.CardStatusCodeNames.Equals(input.CardStatusCodeNames))
                ) && 
                (
                    this.WasteCodeName == input.WasteCodeName ||
                    (this.WasteCodeName != null &&
                    this.WasteCodeName.Equals(input.WasteCodeName))
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
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.ReceiverIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.ReceiverIdentificationNumber.GetHashCode();
                if (this.ReceiverName != null)
                    hashCode = hashCode * 59 + this.ReceiverName.GetHashCode();
                if (this.ReceiverNip != null)
                    hashCode = hashCode * 59 + this.ReceiverNip.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.ReceiveConfirmationTime != null)
                    hashCode = hashCode * 59 + this.ReceiveConfirmationTime.GetHashCode();
                if (this.CardStatusCodeNames != null)
                    hashCode = hashCode * 59 + this.CardStatusCodeNames.GetHashCode();
                if (this.WasteCodeName != null)
                    hashCode = hashCode * 59 + this.WasteCodeName.GetHashCode();
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
