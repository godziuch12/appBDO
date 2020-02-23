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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest" /> class.
        /// </summary>
        /// <param name="kepwId">Id karty ewidencji pojazdów wycofanych z eksploatacji.</param>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="kpoId">Id karty przekazania odpadów.</param>
        /// <param name="recycledWasteMass">Masa odpadów poddanych recyklingowi [Mg].</param>
        /// <param name="energyRecoveryWasteMass">Masa odpadów poddanych odzyskowi energii [Mg].</param>
        /// <param name="otherThanRecycledWasteMass">Masa odpadów przekazanych w kraju innemu procesowi odzysku [Mg].</param>
        /// <param name="shreddedWasteMass">Masa odpadów przekazanych w kraju do rozdrobnienia w strzępiarce [Mg].</param>
        /// <param name="disposedWasteMass">Masa odpadów przekazanych w kraju do unieszkodliwienia [Mg].</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        /// <param name="transferredAbroad">Odpady przekazane do innego kraju.</param>
        /// <param name="transferredAbroadRecycled">Recykling.</param>
        /// <param name="transferredAbroadWasteMass">Masa odpadów przekazanych do innego kraju [Mg].</param>
        /// <param name="transferredAbroadTransferDate">Data rozpoczęcia transportu.</param>
        /// <param name="transferredAbroadWasteProcessId">Id przewidywanej metody przetwarzania.</param>
        /// <param name="countryId">Id kraju.</param>
        /// <param name="locality">Miejscowość.</param>
        /// <param name="street">Ulica.</param>
        /// <param name="buildingNumber">Numer budynku.</param>
        /// <param name="localNumber">Numer lokalu.</param>
        /// <param name="postalCode">Kod pocztowy.</param>
        /// <param name="isRoadTransport">Rodzaj środka transportu: drogowy.</param>
        /// <param name="isRailwayTransport">Rodzaj środka transportu: kolejowy.</param>
        /// <param name="isMaritimeTransport">Rodzaj środka transportu: morski.</param>
        /// <param name="isAirTransport">Rodzaj środka transportu: powietrzny.</param>
        /// <param name="isInlandWaterTransport">Rodzaj środka transportu: wodny-śródlądowy.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        /// <param name="hazardousWasteReclassification">Zmiana statusu odpadów niebezpiecznych na odpady inne niż niebezpieczne.</param>
        /// <param name="hazardousWasteReclassificationDescription">Rodzaj odpadu.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest(Guid? kepwId = default(Guid?), int? wasteCodeId = default(int?), Guid? kpoId = default(Guid?), double? recycledWasteMass = default(double?), double? energyRecoveryWasteMass = default(double?), double? otherThanRecycledWasteMass = default(double?), double? shreddedWasteMass = default(double?), double? disposedWasteMass = default(double?), string additionalInfo = default(string), bool? transferredAbroad = default(bool?), bool? transferredAbroadRecycled = default(bool?), double? transferredAbroadWasteMass = default(double?), DateTime? transferredAbroadTransferDate = default(DateTime?), int? transferredAbroadWasteProcessId = default(int?), int? countryId = default(int?), string locality = default(string), string street = default(string), string buildingNumber = default(string), string localNumber = default(string), string postalCode = default(string), bool? isRoadTransport = default(bool?), bool? isRailwayTransport = default(bool?), bool? isMaritimeTransport = default(bool?), bool? isAirTransport = default(bool?), bool? isInlandWaterTransport = default(bool?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string), bool? hazardousWasteReclassification = default(bool?), string hazardousWasteReclassificationDescription = default(string))
        {
            this.KepwId = kepwId;
            this.WasteCodeId = wasteCodeId;
            this.KpoId = kpoId;
            this.RecycledWasteMass = recycledWasteMass;
            this.EnergyRecoveryWasteMass = energyRecoveryWasteMass;
            this.OtherThanRecycledWasteMass = otherThanRecycledWasteMass;
            this.ShreddedWasteMass = shreddedWasteMass;
            this.DisposedWasteMass = disposedWasteMass;
            this.AdditionalInfo = additionalInfo;
            this.TransferredAbroad = transferredAbroad;
            this.TransferredAbroadRecycled = transferredAbroadRecycled;
            this.TransferredAbroadWasteMass = transferredAbroadWasteMass;
            this.TransferredAbroadTransferDate = transferredAbroadTransferDate;
            this.TransferredAbroadWasteProcessId = transferredAbroadWasteProcessId;
            this.CountryId = countryId;
            this.Locality = locality;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
            this.LocalNumber = localNumber;
            this.PostalCode = postalCode;
            this.IsRoadTransport = isRoadTransport;
            this.IsRailwayTransport = isRailwayTransport;
            this.IsMaritimeTransport = isMaritimeTransport;
            this.IsAirTransport = isAirTransport;
            this.IsInlandWaterTransport = isInlandWaterTransport;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
            this.HazardousWasteReclassification = hazardousWasteReclassification;
            this.HazardousWasteReclassificationDescription = hazardousWasteReclassificationDescription;
        }
        
        /// <summary>
        /// Id karty ewidencji pojazdów wycofanych z eksploatacji
        /// </summary>
        /// <value>Id karty ewidencji pojazdów wycofanych z eksploatacji</value>
        [DataMember(Name="kepwId", EmitDefaultValue=false)]
        public Guid? KepwId { get; set; }

        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// Id karty przekazania odpadów
        /// </summary>
        /// <value>Id karty przekazania odpadów</value>
        [DataMember(Name="kpoId", EmitDefaultValue=false)]
        public Guid? KpoId { get; set; }

        /// <summary>
        /// Masa odpadów poddanych recyklingowi [Mg]
        /// </summary>
        /// <value>Masa odpadów poddanych recyklingowi [Mg]</value>
        [DataMember(Name="recycledWasteMass", EmitDefaultValue=false)]
        public double? RecycledWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów poddanych odzyskowi energii [Mg]
        /// </summary>
        /// <value>Masa odpadów poddanych odzyskowi energii [Mg]</value>
        [DataMember(Name="energyRecoveryWasteMass", EmitDefaultValue=false)]
        public double? EnergyRecoveryWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów przekazanych w kraju innemu procesowi odzysku [Mg]
        /// </summary>
        /// <value>Masa odpadów przekazanych w kraju innemu procesowi odzysku [Mg]</value>
        [DataMember(Name="otherThanRecycledWasteMass", EmitDefaultValue=false)]
        public double? OtherThanRecycledWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów przekazanych w kraju do rozdrobnienia w strzępiarce [Mg]
        /// </summary>
        /// <value>Masa odpadów przekazanych w kraju do rozdrobnienia w strzępiarce [Mg]</value>
        [DataMember(Name="shreddedWasteMass", EmitDefaultValue=false)]
        public double? ShreddedWasteMass { get; set; }

        /// <summary>
        /// Masa odpadów przekazanych w kraju do unieszkodliwienia [Mg]
        /// </summary>
        /// <value>Masa odpadów przekazanych w kraju do unieszkodliwienia [Mg]</value>
        [DataMember(Name="disposedWasteMass", EmitDefaultValue=false)]
        public double? DisposedWasteMass { get; set; }

        /// <summary>
        /// Informacje dodatkowe
        /// </summary>
        /// <value>Informacje dodatkowe</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Odpady przekazane do innego kraju
        /// </summary>
        /// <value>Odpady przekazane do innego kraju</value>
        [DataMember(Name="transferredAbroad", EmitDefaultValue=false)]
        public bool? TransferredAbroad { get; set; }

        /// <summary>
        /// Recykling
        /// </summary>
        /// <value>Recykling</value>
        [DataMember(Name="transferredAbroadRecycled", EmitDefaultValue=false)]
        public bool? TransferredAbroadRecycled { get; set; }

        /// <summary>
        /// Masa odpadów przekazanych do innego kraju [Mg]
        /// </summary>
        /// <value>Masa odpadów przekazanych do innego kraju [Mg]</value>
        [DataMember(Name="transferredAbroadWasteMass", EmitDefaultValue=false)]
        public double? TransferredAbroadWasteMass { get; set; }

        /// <summary>
        /// Data rozpoczęcia transportu
        /// </summary>
        /// <value>Data rozpoczęcia transportu</value>
        [DataMember(Name="transferredAbroadTransferDate", EmitDefaultValue=false)]
        public DateTime? TransferredAbroadTransferDate { get; set; }

        /// <summary>
        /// Id przewidywanej metody przetwarzania
        /// </summary>
        /// <value>Id przewidywanej metody przetwarzania</value>
        [DataMember(Name="transferredAbroadWasteProcessId", EmitDefaultValue=false)]
        public int? TransferredAbroadWasteProcessId { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest {\n");
            sb.Append("  KepwId: ").Append(KepwId).Append("\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  KpoId: ").Append(KpoId).Append("\n");
            sb.Append("  RecycledWasteMass: ").Append(RecycledWasteMass).Append("\n");
            sb.Append("  EnergyRecoveryWasteMass: ").Append(EnergyRecoveryWasteMass).Append("\n");
            sb.Append("  OtherThanRecycledWasteMass: ").Append(OtherThanRecycledWasteMass).Append("\n");
            sb.Append("  ShreddedWasteMass: ").Append(ShreddedWasteMass).Append("\n");
            sb.Append("  DisposedWasteMass: ").Append(DisposedWasteMass).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  TransferredAbroad: ").Append(TransferredAbroad).Append("\n");
            sb.Append("  TransferredAbroadRecycled: ").Append(TransferredAbroadRecycled).Append("\n");
            sb.Append("  TransferredAbroadWasteMass: ").Append(TransferredAbroadWasteMass).Append("\n");
            sb.Append("  TransferredAbroadTransferDate: ").Append(TransferredAbroadTransferDate).Append("\n");
            sb.Append("  TransferredAbroadWasteProcessId: ").Append(TransferredAbroadWasteProcessId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  LocalNumber: ").Append(LocalNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  IsRoadTransport: ").Append(IsRoadTransport).Append("\n");
            sb.Append("  IsRailwayTransport: ").Append(IsRailwayTransport).Append("\n");
            sb.Append("  IsMaritimeTransport: ").Append(IsMaritimeTransport).Append("\n");
            sb.Append("  IsAirTransport: ").Append(IsAirTransport).Append("\n");
            sb.Append("  IsInlandWaterTransport: ").Append(IsInlandWaterTransport).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWreckWasteRecordCardDismantleTransferredWasteV1CreateDismantleTransferredWasteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KepwId == input.KepwId ||
                    (this.KepwId != null &&
                    this.KepwId.Equals(input.KepwId))
                ) && 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.KpoId == input.KpoId ||
                    (this.KpoId != null &&
                    this.KpoId.Equals(input.KpoId))
                ) && 
                (
                    this.RecycledWasteMass == input.RecycledWasteMass ||
                    (this.RecycledWasteMass != null &&
                    this.RecycledWasteMass.Equals(input.RecycledWasteMass))
                ) && 
                (
                    this.EnergyRecoveryWasteMass == input.EnergyRecoveryWasteMass ||
                    (this.EnergyRecoveryWasteMass != null &&
                    this.EnergyRecoveryWasteMass.Equals(input.EnergyRecoveryWasteMass))
                ) && 
                (
                    this.OtherThanRecycledWasteMass == input.OtherThanRecycledWasteMass ||
                    (this.OtherThanRecycledWasteMass != null &&
                    this.OtherThanRecycledWasteMass.Equals(input.OtherThanRecycledWasteMass))
                ) && 
                (
                    this.ShreddedWasteMass == input.ShreddedWasteMass ||
                    (this.ShreddedWasteMass != null &&
                    this.ShreddedWasteMass.Equals(input.ShreddedWasteMass))
                ) && 
                (
                    this.DisposedWasteMass == input.DisposedWasteMass ||
                    (this.DisposedWasteMass != null &&
                    this.DisposedWasteMass.Equals(input.DisposedWasteMass))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
                ) && 
                (
                    this.TransferredAbroad == input.TransferredAbroad ||
                    (this.TransferredAbroad != null &&
                    this.TransferredAbroad.Equals(input.TransferredAbroad))
                ) && 
                (
                    this.TransferredAbroadRecycled == input.TransferredAbroadRecycled ||
                    (this.TransferredAbroadRecycled != null &&
                    this.TransferredAbroadRecycled.Equals(input.TransferredAbroadRecycled))
                ) && 
                (
                    this.TransferredAbroadWasteMass == input.TransferredAbroadWasteMass ||
                    (this.TransferredAbroadWasteMass != null &&
                    this.TransferredAbroadWasteMass.Equals(input.TransferredAbroadWasteMass))
                ) && 
                (
                    this.TransferredAbroadTransferDate == input.TransferredAbroadTransferDate ||
                    (this.TransferredAbroadTransferDate != null &&
                    this.TransferredAbroadTransferDate.Equals(input.TransferredAbroadTransferDate))
                ) && 
                (
                    this.TransferredAbroadWasteProcessId == input.TransferredAbroadWasteProcessId ||
                    (this.TransferredAbroadWasteProcessId != null &&
                    this.TransferredAbroadWasteProcessId.Equals(input.TransferredAbroadWasteProcessId))
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
                if (this.KepwId != null)
                    hashCode = hashCode * 59 + this.KepwId.GetHashCode();
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.KpoId != null)
                    hashCode = hashCode * 59 + this.KpoId.GetHashCode();
                if (this.RecycledWasteMass != null)
                    hashCode = hashCode * 59 + this.RecycledWasteMass.GetHashCode();
                if (this.EnergyRecoveryWasteMass != null)
                    hashCode = hashCode * 59 + this.EnergyRecoveryWasteMass.GetHashCode();
                if (this.OtherThanRecycledWasteMass != null)
                    hashCode = hashCode * 59 + this.OtherThanRecycledWasteMass.GetHashCode();
                if (this.ShreddedWasteMass != null)
                    hashCode = hashCode * 59 + this.ShreddedWasteMass.GetHashCode();
                if (this.DisposedWasteMass != null)
                    hashCode = hashCode * 59 + this.DisposedWasteMass.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                if (this.TransferredAbroad != null)
                    hashCode = hashCode * 59 + this.TransferredAbroad.GetHashCode();
                if (this.TransferredAbroadRecycled != null)
                    hashCode = hashCode * 59 + this.TransferredAbroadRecycled.GetHashCode();
                if (this.TransferredAbroadWasteMass != null)
                    hashCode = hashCode * 59 + this.TransferredAbroadWasteMass.GetHashCode();
                if (this.TransferredAbroadTransferDate != null)
                    hashCode = hashCode * 59 + this.TransferredAbroadTransferDate.GetHashCode();
                if (this.TransferredAbroadWasteProcessId != null)
                    hashCode = hashCode * 59 + this.TransferredAbroadWasteProcessId.GetHashCode();
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
