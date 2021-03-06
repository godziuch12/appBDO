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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto" /> class.
        /// </summary>
        /// <param name="keoForwardedId">Id wpisu Przekazane odpady.</param>
        /// <param name="keoId">Id karty ewidencji odpadów.</param>
        /// <param name="kpoId">Id karty przekazania odpadów.</param>
        /// <param name="kpoCardNumber">Numer karty kpo.</param>
        /// <param name="basedOnKpo">Wpis dokonywany na podstawie karty przekazania odpadów.</param>
        /// <param name="transferAbroad">Wywóz poza RP.</param>
        /// <param name="transferToNaturalPersons">Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami.</param>
        /// <param name="ownerExemptFromRecords">Posiadacz odpadów zwolniony z obowiązku prowadzenia ewidencji odpadów.</param>
        /// <param name="wasteCollectionDate">wasteCollectionDate.</param>
        /// <param name="wasteMass">Masa odpadów.</param>
        /// <param name="countryId">Id kraju.</param>
        /// <param name="locality">Miejscowość.</param>
        /// <param name="street">Ulica.</param>
        /// <param name="buildingNumber">Numer budynku.</param>
        /// <param name="localNumber">Numer lokalu.</param>
        /// <param name="postalCode">Kod pocztowy.</param>
        /// <param name="transportDate">transportDate.</param>
        /// <param name="isRoadTransport">Rodzaj środka transportu: drogowy.</param>
        /// <param name="isRailwayTransport">Rodzaj środka transportu: kolejowy.</param>
        /// <param name="isMaritimeTransport">Rodzaj środka transportu: morski.</param>
        /// <param name="isAirTransport">Rodzaj środka transportu: powietrzny.</param>
        /// <param name="isInlandWaterTransport">Rodzaj środka transportu: wodny-śródlądowy.</param>
        /// <param name="processR">Odpady objęte procesem: R - odzysku.</param>
        /// <param name="processD">Odpady objęte procesem: D - unieszkodliwiania.</param>
        /// <param name="wasteProcessId">Id procesu przetwarzania odpadów.</param>
        /// <param name="isRecycle">Recykling.</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto(Guid? keoForwardedId = default(Guid?), Guid? keoId = default(Guid?), Guid? kpoId = default(Guid?), string kpoCardNumber = default(string), bool? basedOnKpo = default(bool?), bool? transferAbroad = default(bool?), bool? transferToNaturalPersons = default(bool?), bool? ownerExemptFromRecords = default(bool?), DateTime? wasteCollectionDate = default(DateTime?), double? wasteMass = default(double?), int? countryId = default(int?), string locality = default(string), string street = default(string), string buildingNumber = default(string), string localNumber = default(string), string postalCode = default(string), DateTime? transportDate = default(DateTime?), bool? isRoadTransport = default(bool?), bool? isRailwayTransport = default(bool?), bool? isMaritimeTransport = default(bool?), bool? isAirTransport = default(bool?), bool? isInlandWaterTransport = default(bool?), bool? processR = default(bool?), bool? processD = default(bool?), int? wasteProcessId = default(int?), bool? isRecycle = default(bool?), string additionalInfo = default(string))
        {
            this.KeoForwardedId = keoForwardedId;
            this.KeoId = keoId;
            this.KpoId = kpoId;
            this.KpoCardNumber = kpoCardNumber;
            this.BasedOnKpo = basedOnKpo;
            this.TransferAbroad = transferAbroad;
            this.TransferToNaturalPersons = transferToNaturalPersons;
            this.OwnerExemptFromRecords = ownerExemptFromRecords;
            this.WasteCollectionDate = wasteCollectionDate;
            this.WasteMass = wasteMass;
            this.CountryId = countryId;
            this.Locality = locality;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
            this.LocalNumber = localNumber;
            this.PostalCode = postalCode;
            this.TransportDate = transportDate;
            this.IsRoadTransport = isRoadTransport;
            this.IsRailwayTransport = isRailwayTransport;
            this.IsMaritimeTransport = isMaritimeTransport;
            this.IsAirTransport = isAirTransport;
            this.IsInlandWaterTransport = isInlandWaterTransport;
            this.ProcessR = processR;
            this.ProcessD = processD;
            this.WasteProcessId = wasteProcessId;
            this.IsRecycle = isRecycle;
            this.AdditionalInfo = additionalInfo;
        }
        
        /// <summary>
        /// Id wpisu Przekazane odpady
        /// </summary>
        /// <value>Id wpisu Przekazane odpady</value>
        [DataMember(Name="keoForwardedId", EmitDefaultValue=false)]
        public Guid? KeoForwardedId { get; set; }

        /// <summary>
        /// Id karty ewidencji odpadów
        /// </summary>
        /// <value>Id karty ewidencji odpadów</value>
        [DataMember(Name="keoId", EmitDefaultValue=false)]
        public Guid? KeoId { get; set; }

        /// <summary>
        /// Id karty przekazania odpadów
        /// </summary>
        /// <value>Id karty przekazania odpadów</value>
        [DataMember(Name="kpoId", EmitDefaultValue=false)]
        public Guid? KpoId { get; set; }

        /// <summary>
        /// Numer karty kpo
        /// </summary>
        /// <value>Numer karty kpo</value>
        [DataMember(Name="kpoCardNumber", EmitDefaultValue=false)]
        public string KpoCardNumber { get; set; }

        /// <summary>
        /// Wpis dokonywany na podstawie karty przekazania odpadów
        /// </summary>
        /// <value>Wpis dokonywany na podstawie karty przekazania odpadów</value>
        [DataMember(Name="basedOnKpo", EmitDefaultValue=false)]
        public bool? BasedOnKpo { get; set; }

        /// <summary>
        /// Wywóz poza RP
        /// </summary>
        /// <value>Wywóz poza RP</value>
        [DataMember(Name="transferAbroad", EmitDefaultValue=false)]
        public bool? TransferAbroad { get; set; }

        /// <summary>
        /// Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami
        /// </summary>
        /// <value>Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami</value>
        [DataMember(Name="transferToNaturalPersons", EmitDefaultValue=false)]
        public bool? TransferToNaturalPersons { get; set; }

        /// <summary>
        /// Posiadacz odpadów zwolniony z obowiązku prowadzenia ewidencji odpadów
        /// </summary>
        /// <value>Posiadacz odpadów zwolniony z obowiązku prowadzenia ewidencji odpadów</value>
        [DataMember(Name="ownerExemptFromRecords", EmitDefaultValue=false)]
        public bool? OwnerExemptFromRecords { get; set; }

        /// <summary>
        /// Gets or Sets WasteCollectionDate
        /// </summary>
        [DataMember(Name="wasteCollectionDate", EmitDefaultValue=false)]
        public DateTime? WasteCollectionDate { get; set; }

        /// <summary>
        /// Masa odpadów
        /// </summary>
        /// <value>Masa odpadów</value>
        [DataMember(Name="wasteMass", EmitDefaultValue=false)]
        public double? WasteMass { get; set; }

        /// <summary>
        /// Id kraju
        /// </summary>
        /// <value>Id kraju</value>
        [DataMember(Name="countryId", EmitDefaultValue=false)]
        public int? CountryId { get; set; }

        /// <summary>
        /// Miejscowość
        /// </summary>
        /// <value>Miejscowość</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Ulica
        /// </summary>
        /// <value>Ulica</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Numer budynku
        /// </summary>
        /// <value>Numer budynku</value>
        [DataMember(Name="buildingNumber", EmitDefaultValue=false)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Numer lokalu
        /// </summary>
        /// <value>Numer lokalu</value>
        [DataMember(Name="localNumber", EmitDefaultValue=false)]
        public string LocalNumber { get; set; }

        /// <summary>
        /// Kod pocztowy
        /// </summary>
        /// <value>Kod pocztowy</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets TransportDate
        /// </summary>
        [DataMember(Name="transportDate", EmitDefaultValue=false)]
        public DateTime? TransportDate { get; set; }

        /// <summary>
        /// Rodzaj środka transportu: drogowy
        /// </summary>
        /// <value>Rodzaj środka transportu: drogowy</value>
        [DataMember(Name="isRoadTransport", EmitDefaultValue=false)]
        public bool? IsRoadTransport { get; set; }

        /// <summary>
        /// Rodzaj środka transportu: kolejowy
        /// </summary>
        /// <value>Rodzaj środka transportu: kolejowy</value>
        [DataMember(Name="isRailwayTransport", EmitDefaultValue=false)]
        public bool? IsRailwayTransport { get; set; }

        /// <summary>
        /// Rodzaj środka transportu: morski
        /// </summary>
        /// <value>Rodzaj środka transportu: morski</value>
        [DataMember(Name="isMaritimeTransport", EmitDefaultValue=false)]
        public bool? IsMaritimeTransport { get; set; }

        /// <summary>
        /// Rodzaj środka transportu: powietrzny
        /// </summary>
        /// <value>Rodzaj środka transportu: powietrzny</value>
        [DataMember(Name="isAirTransport", EmitDefaultValue=false)]
        public bool? IsAirTransport { get; set; }

        /// <summary>
        /// Rodzaj środka transportu: wodny-śródlądowy
        /// </summary>
        /// <value>Rodzaj środka transportu: wodny-śródlądowy</value>
        [DataMember(Name="isInlandWaterTransport", EmitDefaultValue=false)]
        public bool? IsInlandWaterTransport { get; set; }

        /// <summary>
        /// Odpady objęte procesem: R - odzysku
        /// </summary>
        /// <value>Odpady objęte procesem: R - odzysku</value>
        [DataMember(Name="processR", EmitDefaultValue=false)]
        public bool? ProcessR { get; set; }

        /// <summary>
        /// Odpady objęte procesem: D - unieszkodliwiania
        /// </summary>
        /// <value>Odpady objęte procesem: D - unieszkodliwiania</value>
        [DataMember(Name="processD", EmitDefaultValue=false)]
        public bool? ProcessD { get; set; }

        /// <summary>
        /// Id procesu przetwarzania odpadów
        /// </summary>
        /// <value>Id procesu przetwarzania odpadów</value>
        [DataMember(Name="wasteProcessId", EmitDefaultValue=false)]
        public int? WasteProcessId { get; set; }

        /// <summary>
        /// Recykling
        /// </summary>
        /// <value>Recykling</value>
        [DataMember(Name="isRecycle", EmitDefaultValue=false)]
        public bool? IsRecycle { get; set; }

        /// <summary>
        /// Informacje dodatkowe
        /// </summary>
        /// <value>Informacje dodatkowe</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto {\n");
            sb.Append("  KeoForwardedId: ").Append(KeoForwardedId).Append("\n");
            sb.Append("  KeoId: ").Append(KeoId).Append("\n");
            sb.Append("  KpoId: ").Append(KpoId).Append("\n");
            sb.Append("  KpoCardNumber: ").Append(KpoCardNumber).Append("\n");
            sb.Append("  BasedOnKpo: ").Append(BasedOnKpo).Append("\n");
            sb.Append("  TransferAbroad: ").Append(TransferAbroad).Append("\n");
            sb.Append("  TransferToNaturalPersons: ").Append(TransferToNaturalPersons).Append("\n");
            sb.Append("  OwnerExemptFromRecords: ").Append(OwnerExemptFromRecords).Append("\n");
            sb.Append("  WasteCollectionDate: ").Append(WasteCollectionDate).Append("\n");
            sb.Append("  WasteMass: ").Append(WasteMass).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  LocalNumber: ").Append(LocalNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  TransportDate: ").Append(TransportDate).Append("\n");
            sb.Append("  IsRoadTransport: ").Append(IsRoadTransport).Append("\n");
            sb.Append("  IsRailwayTransport: ").Append(IsRailwayTransport).Append("\n");
            sb.Append("  IsMaritimeTransport: ").Append(IsMaritimeTransport).Append("\n");
            sb.Append("  IsAirTransport: ").Append(IsAirTransport).Append("\n");
            sb.Append("  IsInlandWaterTransport: ").Append(IsInlandWaterTransport).Append("\n");
            sb.Append("  ProcessR: ").Append(ProcessR).Append("\n");
            sb.Append("  ProcessD: ").Append(ProcessD).Append("\n");
            sb.Append("  WasteProcessId: ").Append(WasteProcessId).Append("\n");
            sb.Append("  IsRecycle: ").Append(IsRecycle).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeoForwardedId == input.KeoForwardedId ||
                    (this.KeoForwardedId != null &&
                    this.KeoForwardedId.Equals(input.KeoForwardedId))
                ) && 
                (
                    this.KeoId == input.KeoId ||
                    (this.KeoId != null &&
                    this.KeoId.Equals(input.KeoId))
                ) && 
                (
                    this.KpoId == input.KpoId ||
                    (this.KpoId != null &&
                    this.KpoId.Equals(input.KpoId))
                ) && 
                (
                    this.KpoCardNumber == input.KpoCardNumber ||
                    (this.KpoCardNumber != null &&
                    this.KpoCardNumber.Equals(input.KpoCardNumber))
                ) && 
                (
                    this.BasedOnKpo == input.BasedOnKpo ||
                    (this.BasedOnKpo != null &&
                    this.BasedOnKpo.Equals(input.BasedOnKpo))
                ) && 
                (
                    this.TransferAbroad == input.TransferAbroad ||
                    (this.TransferAbroad != null &&
                    this.TransferAbroad.Equals(input.TransferAbroad))
                ) && 
                (
                    this.TransferToNaturalPersons == input.TransferToNaturalPersons ||
                    (this.TransferToNaturalPersons != null &&
                    this.TransferToNaturalPersons.Equals(input.TransferToNaturalPersons))
                ) && 
                (
                    this.OwnerExemptFromRecords == input.OwnerExemptFromRecords ||
                    (this.OwnerExemptFromRecords != null &&
                    this.OwnerExemptFromRecords.Equals(input.OwnerExemptFromRecords))
                ) && 
                (
                    this.WasteCollectionDate == input.WasteCollectionDate ||
                    (this.WasteCollectionDate != null &&
                    this.WasteCollectionDate.Equals(input.WasteCollectionDate))
                ) && 
                (
                    this.WasteMass == input.WasteMass ||
                    (this.WasteMass != null &&
                    this.WasteMass.Equals(input.WasteMass))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.BuildingNumber == input.BuildingNumber ||
                    (this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(input.BuildingNumber))
                ) && 
                (
                    this.LocalNumber == input.LocalNumber ||
                    (this.LocalNumber != null &&
                    this.LocalNumber.Equals(input.LocalNumber))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.TransportDate == input.TransportDate ||
                    (this.TransportDate != null &&
                    this.TransportDate.Equals(input.TransportDate))
                ) && 
                (
                    this.IsRoadTransport == input.IsRoadTransport ||
                    (this.IsRoadTransport != null &&
                    this.IsRoadTransport.Equals(input.IsRoadTransport))
                ) && 
                (
                    this.IsRailwayTransport == input.IsRailwayTransport ||
                    (this.IsRailwayTransport != null &&
                    this.IsRailwayTransport.Equals(input.IsRailwayTransport))
                ) && 
                (
                    this.IsMaritimeTransport == input.IsMaritimeTransport ||
                    (this.IsMaritimeTransport != null &&
                    this.IsMaritimeTransport.Equals(input.IsMaritimeTransport))
                ) && 
                (
                    this.IsAirTransport == input.IsAirTransport ||
                    (this.IsAirTransport != null &&
                    this.IsAirTransport.Equals(input.IsAirTransport))
                ) && 
                (
                    this.IsInlandWaterTransport == input.IsInlandWaterTransport ||
                    (this.IsInlandWaterTransport != null &&
                    this.IsInlandWaterTransport.Equals(input.IsInlandWaterTransport))
                ) && 
                (
                    this.ProcessR == input.ProcessR ||
                    (this.ProcessR != null &&
                    this.ProcessR.Equals(input.ProcessR))
                ) && 
                (
                    this.ProcessD == input.ProcessD ||
                    (this.ProcessD != null &&
                    this.ProcessD.Equals(input.ProcessD))
                ) && 
                (
                    this.WasteProcessId == input.WasteProcessId ||
                    (this.WasteProcessId != null &&
                    this.WasteProcessId.Equals(input.WasteProcessId))
                ) && 
                (
                    this.IsRecycle == input.IsRecycle ||
                    (this.IsRecycle != null &&
                    this.IsRecycle.Equals(input.IsRecycle))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
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
                if (this.KeoForwardedId != null)
                    hashCode = hashCode * 59 + this.KeoForwardedId.GetHashCode();
                if (this.KeoId != null)
                    hashCode = hashCode * 59 + this.KeoId.GetHashCode();
                if (this.KpoId != null)
                    hashCode = hashCode * 59 + this.KpoId.GetHashCode();
                if (this.KpoCardNumber != null)
                    hashCode = hashCode * 59 + this.KpoCardNumber.GetHashCode();
                if (this.BasedOnKpo != null)
                    hashCode = hashCode * 59 + this.BasedOnKpo.GetHashCode();
                if (this.TransferAbroad != null)
                    hashCode = hashCode * 59 + this.TransferAbroad.GetHashCode();
                if (this.TransferToNaturalPersons != null)
                    hashCode = hashCode * 59 + this.TransferToNaturalPersons.GetHashCode();
                if (this.OwnerExemptFromRecords != null)
                    hashCode = hashCode * 59 + this.OwnerExemptFromRecords.GetHashCode();
                if (this.WasteCollectionDate != null)
                    hashCode = hashCode * 59 + this.WasteCollectionDate.GetHashCode();
                if (this.WasteMass != null)
                    hashCode = hashCode * 59 + this.WasteMass.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.BuildingNumber != null)
                    hashCode = hashCode * 59 + this.BuildingNumber.GetHashCode();
                if (this.LocalNumber != null)
                    hashCode = hashCode * 59 + this.LocalNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.TransportDate != null)
                    hashCode = hashCode * 59 + this.TransportDate.GetHashCode();
                if (this.IsRoadTransport != null)
                    hashCode = hashCode * 59 + this.IsRoadTransport.GetHashCode();
                if (this.IsRailwayTransport != null)
                    hashCode = hashCode * 59 + this.IsRailwayTransport.GetHashCode();
                if (this.IsMaritimeTransport != null)
                    hashCode = hashCode * 59 + this.IsMaritimeTransport.GetHashCode();
                if (this.IsAirTransport != null)
                    hashCode = hashCode * 59 + this.IsAirTransport.GetHashCode();
                if (this.IsInlandWaterTransport != null)
                    hashCode = hashCode * 59 + this.IsInlandWaterTransport.GetHashCode();
                if (this.ProcessR != null)
                    hashCode = hashCode * 59 + this.ProcessR.GetHashCode();
                if (this.ProcessD != null)
                    hashCode = hashCode * 59 + this.ProcessD.GetHashCode();
                if (this.WasteProcessId != null)
                    hashCode = hashCode * 59 + this.WasteProcessId.GetHashCode();
                if (this.IsRecycle != null)
                    hashCode = hashCode * 59 + this.IsRecycle.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
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
