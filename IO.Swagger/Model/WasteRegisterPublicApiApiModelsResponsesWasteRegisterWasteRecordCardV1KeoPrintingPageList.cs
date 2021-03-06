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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList" /> class.
        /// </summary>
        /// <param name="date">Data.</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="generatedWasteMassInstallation">Masa wytworzonych odpadów w związku z eksploatacją.</param>
        /// <param name="generatedWasteMassExcludingInstallation">Masa wytworzonych odpadów poza instalacją.</param>
        /// <param name="generatedWasteMassInstallationFromServices">Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych.</param>
        /// <param name="generatedWasteMassExcludingInstallationFromServices">Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych poza instalacją.</param>
        /// <param name="wasteFromServices">wytwarzanie odpadów - w wyniku świadczenia usług (w rozumieniu art. 3 ust. 1 pkt 32 ustawy o odpadach) i/lub działalności w zakresie obiektów liniowych (w rozumieniu art. 3 pkt 3a ustawy - Prawo budowlane).</param>
        /// <param name="excavatedWasteMass">Masa odpadów wydobytych ze składowiska.</param>
        /// <param name="collectedWasteMass">Odpady przyjęte przez posiadacza odpadów.</param>
        /// <param name="kpoCollectedCardNumber">Przyjęte - numer katy kpo.</param>
        /// <param name="isTreatedRecycle">Przetwarzanie - Recykling.</param>
        /// <param name="isTreatedFillingUpDisadvantagedAreas">Przetwarzanie - wypełnianie terenów niekorzystnie przekształconych.</param>
        /// <param name="isTreatedPreparationForReUse">Przetwarzanie - przygotowanie do ponownego uzycia.</param>
        /// <param name="isTreatedAnotherRecoveryProcess">Przetwarzanie - inny proces odzysku.</param>
        /// <param name="isTreatedNeutralization">Przetwarzanie - unieszkodliwianie.</param>
        /// <param name="treatedProcessR">Przetwarzanie - Odpady objęte procesem: R - odzysku.</param>
        /// <param name="treatedProcessD">Przetwarzanie - Odpady objęte procesem: D - unieszkodliwiania.</param>
        /// <param name="treatedProcess">Przetwarzanie - Proces przetwarzania.</param>
        /// <param name="treatedWasteMass">Masa przetworzonych odpadów.</param>
        /// <param name="treatedPcbContent">Przetwarzanie - Zawartość PCB w odpadzie [%].</param>
        /// <param name="forwardedCountryWasteMass">Masa przekazanych odpadów w kraju.</param>
        /// <param name="forwardedAbroadWasteMass">Masa przekazanych odpadów w kraju.</param>
        /// <param name="kpoForwardedCardNumber">Przekazane - numer karty kpo.</param>
        /// <param name="basedOnKpo">Wpis dokonywany na podstawie karty przekazania odpadów.</param>
        /// <param name="transferToPoland">Przywóz do RP.</param>
        /// <param name="transferToNaturalPersons">Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList(DateTime? date = default(DateTime?), string createdByUser = default(string), double? generatedWasteMassInstallation = default(double?), double? generatedWasteMassExcludingInstallation = default(double?), double? generatedWasteMassInstallationFromServices = default(double?), double? generatedWasteMassExcludingInstallationFromServices = default(double?), bool? wasteFromServices = default(bool?), double? excavatedWasteMass = default(double?), double? collectedWasteMass = default(double?), string kpoCollectedCardNumber = default(string), bool? isTreatedRecycle = default(bool?), bool? isTreatedFillingUpDisadvantagedAreas = default(bool?), bool? isTreatedPreparationForReUse = default(bool?), bool? isTreatedAnotherRecoveryProcess = default(bool?), bool? isTreatedNeutralization = default(bool?), bool? treatedProcessR = default(bool?), bool? treatedProcessD = default(bool?), string treatedProcess = default(string), double? treatedWasteMass = default(double?), double? treatedPcbContent = default(double?), double? forwardedCountryWasteMass = default(double?), double? forwardedAbroadWasteMass = default(double?), string kpoForwardedCardNumber = default(string), bool? basedOnKpo = default(bool?), bool? transferToPoland = default(bool?), bool? transferToNaturalPersons = default(bool?))
        {
            this.Date = date;
            this.CreatedByUser = createdByUser;
            this.GeneratedWasteMassInstallation = generatedWasteMassInstallation;
            this.GeneratedWasteMassExcludingInstallation = generatedWasteMassExcludingInstallation;
            this.GeneratedWasteMassInstallationFromServices = generatedWasteMassInstallationFromServices;
            this.GeneratedWasteMassExcludingInstallationFromServices = generatedWasteMassExcludingInstallationFromServices;
            this.WasteFromServices = wasteFromServices;
            this.ExcavatedWasteMass = excavatedWasteMass;
            this.CollectedWasteMass = collectedWasteMass;
            this.KpoCollectedCardNumber = kpoCollectedCardNumber;
            this.IsTreatedRecycle = isTreatedRecycle;
            this.IsTreatedFillingUpDisadvantagedAreas = isTreatedFillingUpDisadvantagedAreas;
            this.IsTreatedPreparationForReUse = isTreatedPreparationForReUse;
            this.IsTreatedAnotherRecoveryProcess = isTreatedAnotherRecoveryProcess;
            this.IsTreatedNeutralization = isTreatedNeutralization;
            this.TreatedProcessR = treatedProcessR;
            this.TreatedProcessD = treatedProcessD;
            this.TreatedProcess = treatedProcess;
            this.TreatedWasteMass = treatedWasteMass;
            this.TreatedPcbContent = treatedPcbContent;
            this.ForwardedCountryWasteMass = forwardedCountryWasteMass;
            this.ForwardedAbroadWasteMass = forwardedAbroadWasteMass;
            this.KpoForwardedCardNumber = kpoForwardedCardNumber;
            this.BasedOnKpo = basedOnKpo;
            this.TransferToPoland = transferToPoland;
            this.TransferToNaturalPersons = transferToNaturalPersons;
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
        /// Masa wytworzonych odpadów w związku z eksploatacją
        /// </summary>
        /// <value>Masa wytworzonych odpadów w związku z eksploatacją</value>
        [DataMember(Name="generatedWasteMassInstallation", EmitDefaultValue=false)]
        public double? GeneratedWasteMassInstallation { get; set; }

        /// <summary>
        /// Masa wytworzonych odpadów poza instalacją
        /// </summary>
        /// <value>Masa wytworzonych odpadów poza instalacją</value>
        [DataMember(Name="generatedWasteMassExcludingInstallation", EmitDefaultValue=false)]
        public double? GeneratedWasteMassExcludingInstallation { get; set; }

        /// <summary>
        /// Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych
        /// </summary>
        /// <value>Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych</value>
        [DataMember(Name="generatedWasteMassInstallationFromServices", EmitDefaultValue=false)]
        public double? GeneratedWasteMassInstallationFromServices { get; set; }

        /// <summary>
        /// Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych poza instalacją
        /// </summary>
        /// <value>Masa wytworzonych odpadów w wyniku świadczenia usług i/lub działalności w zakresie obiektów liniowych poza instalacją</value>
        [DataMember(Name="generatedWasteMassExcludingInstallationFromServices", EmitDefaultValue=false)]
        public double? GeneratedWasteMassExcludingInstallationFromServices { get; set; }

        /// <summary>
        /// wytwarzanie odpadów - w wyniku świadczenia usług (w rozumieniu art. 3 ust. 1 pkt 32 ustawy o odpadach) i/lub działalności w zakresie obiektów liniowych (w rozumieniu art. 3 pkt 3a ustawy - Prawo budowlane)
        /// </summary>
        /// <value>wytwarzanie odpadów - w wyniku świadczenia usług (w rozumieniu art. 3 ust. 1 pkt 32 ustawy o odpadach) i/lub działalności w zakresie obiektów liniowych (w rozumieniu art. 3 pkt 3a ustawy - Prawo budowlane)</value>
        [DataMember(Name="wasteFromServices", EmitDefaultValue=false)]
        public bool? WasteFromServices { get; set; }

        /// <summary>
        /// Masa odpadów wydobytych ze składowiska
        /// </summary>
        /// <value>Masa odpadów wydobytych ze składowiska</value>
        [DataMember(Name="excavatedWasteMass", EmitDefaultValue=false)]
        public double? ExcavatedWasteMass { get; set; }

        /// <summary>
        /// Odpady przyjęte przez posiadacza odpadów
        /// </summary>
        /// <value>Odpady przyjęte przez posiadacza odpadów</value>
        [DataMember(Name="collectedWasteMass", EmitDefaultValue=false)]
        public double? CollectedWasteMass { get; set; }

        /// <summary>
        /// Przyjęte - numer katy kpo
        /// </summary>
        /// <value>Przyjęte - numer katy kpo</value>
        [DataMember(Name="kpoCollectedCardNumber", EmitDefaultValue=false)]
        public string KpoCollectedCardNumber { get; set; }

        /// <summary>
        /// Przetwarzanie - Recykling
        /// </summary>
        /// <value>Przetwarzanie - Recykling</value>
        [DataMember(Name="isTreatedRecycle", EmitDefaultValue=false)]
        public bool? IsTreatedRecycle { get; set; }

        /// <summary>
        /// Przetwarzanie - wypełnianie terenów niekorzystnie przekształconych
        /// </summary>
        /// <value>Przetwarzanie - wypełnianie terenów niekorzystnie przekształconych</value>
        [DataMember(Name="isTreatedFillingUpDisadvantagedAreas", EmitDefaultValue=false)]
        public bool? IsTreatedFillingUpDisadvantagedAreas { get; set; }

        /// <summary>
        /// Przetwarzanie - przygotowanie do ponownego uzycia
        /// </summary>
        /// <value>Przetwarzanie - przygotowanie do ponownego uzycia</value>
        [DataMember(Name="isTreatedPreparationForReUse", EmitDefaultValue=false)]
        public bool? IsTreatedPreparationForReUse { get; set; }

        /// <summary>
        /// Przetwarzanie - inny proces odzysku
        /// </summary>
        /// <value>Przetwarzanie - inny proces odzysku</value>
        [DataMember(Name="isTreatedAnotherRecoveryProcess", EmitDefaultValue=false)]
        public bool? IsTreatedAnotherRecoveryProcess { get; set; }

        /// <summary>
        /// Przetwarzanie - unieszkodliwianie
        /// </summary>
        /// <value>Przetwarzanie - unieszkodliwianie</value>
        [DataMember(Name="isTreatedNeutralization", EmitDefaultValue=false)]
        public bool? IsTreatedNeutralization { get; set; }

        /// <summary>
        /// Przetwarzanie - Odpady objęte procesem: R - odzysku
        /// </summary>
        /// <value>Przetwarzanie - Odpady objęte procesem: R - odzysku</value>
        [DataMember(Name="treatedProcessR", EmitDefaultValue=false)]
        public bool? TreatedProcessR { get; set; }

        /// <summary>
        /// Przetwarzanie - Odpady objęte procesem: D - unieszkodliwiania
        /// </summary>
        /// <value>Przetwarzanie - Odpady objęte procesem: D - unieszkodliwiania</value>
        [DataMember(Name="treatedProcessD", EmitDefaultValue=false)]
        public bool? TreatedProcessD { get; set; }

        /// <summary>
        /// Przetwarzanie - Proces przetwarzania
        /// </summary>
        /// <value>Przetwarzanie - Proces przetwarzania</value>
        [DataMember(Name="treatedProcess", EmitDefaultValue=false)]
        public string TreatedProcess { get; set; }

        /// <summary>
        /// Masa przetworzonych odpadów
        /// </summary>
        /// <value>Masa przetworzonych odpadów</value>
        [DataMember(Name="treatedWasteMass", EmitDefaultValue=false)]
        public double? TreatedWasteMass { get; set; }

        /// <summary>
        /// Przetwarzanie - Zawartość PCB w odpadzie [%]
        /// </summary>
        /// <value>Przetwarzanie - Zawartość PCB w odpadzie [%]</value>
        [DataMember(Name="treatedPcbContent", EmitDefaultValue=false)]
        public double? TreatedPcbContent { get; set; }

        /// <summary>
        /// Masa przekazanych odpadów w kraju
        /// </summary>
        /// <value>Masa przekazanych odpadów w kraju</value>
        [DataMember(Name="forwardedCountryWasteMass", EmitDefaultValue=false)]
        public double? ForwardedCountryWasteMass { get; set; }

        /// <summary>
        /// Masa przekazanych odpadów w kraju
        /// </summary>
        /// <value>Masa przekazanych odpadów w kraju</value>
        [DataMember(Name="forwardedAbroadWasteMass", EmitDefaultValue=false)]
        public double? ForwardedAbroadWasteMass { get; set; }

        /// <summary>
        /// Przekazane - numer karty kpo
        /// </summary>
        /// <value>Przekazane - numer karty kpo</value>
        [DataMember(Name="kpoForwardedCardNumber", EmitDefaultValue=false)]
        public string KpoForwardedCardNumber { get; set; }

        /// <summary>
        /// Wpis dokonywany na podstawie karty przekazania odpadów
        /// </summary>
        /// <value>Wpis dokonywany na podstawie karty przekazania odpadów</value>
        [DataMember(Name="basedOnKpo", EmitDefaultValue=false)]
        public bool? BasedOnKpo { get; set; }

        /// <summary>
        /// Przywóz do RP
        /// </summary>
        /// <value>Przywóz do RP</value>
        [DataMember(Name="transferToPoland", EmitDefaultValue=false)]
        public bool? TransferToPoland { get; set; }

        /// <summary>
        /// Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami
        /// </summary>
        /// <value>Przekazane osobom fizycznym lub innym jednostkom organizacyjnym niebędącym przedsiębiorcami</value>
        [DataMember(Name="transferToNaturalPersons", EmitDefaultValue=false)]
        public bool? TransferToNaturalPersons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  GeneratedWasteMassInstallation: ").Append(GeneratedWasteMassInstallation).Append("\n");
            sb.Append("  GeneratedWasteMassExcludingInstallation: ").Append(GeneratedWasteMassExcludingInstallation).Append("\n");
            sb.Append("  GeneratedWasteMassInstallationFromServices: ").Append(GeneratedWasteMassInstallationFromServices).Append("\n");
            sb.Append("  GeneratedWasteMassExcludingInstallationFromServices: ").Append(GeneratedWasteMassExcludingInstallationFromServices).Append("\n");
            sb.Append("  WasteFromServices: ").Append(WasteFromServices).Append("\n");
            sb.Append("  ExcavatedWasteMass: ").Append(ExcavatedWasteMass).Append("\n");
            sb.Append("  CollectedWasteMass: ").Append(CollectedWasteMass).Append("\n");
            sb.Append("  KpoCollectedCardNumber: ").Append(KpoCollectedCardNumber).Append("\n");
            sb.Append("  IsTreatedRecycle: ").Append(IsTreatedRecycle).Append("\n");
            sb.Append("  IsTreatedFillingUpDisadvantagedAreas: ").Append(IsTreatedFillingUpDisadvantagedAreas).Append("\n");
            sb.Append("  IsTreatedPreparationForReUse: ").Append(IsTreatedPreparationForReUse).Append("\n");
            sb.Append("  IsTreatedAnotherRecoveryProcess: ").Append(IsTreatedAnotherRecoveryProcess).Append("\n");
            sb.Append("  IsTreatedNeutralization: ").Append(IsTreatedNeutralization).Append("\n");
            sb.Append("  TreatedProcessR: ").Append(TreatedProcessR).Append("\n");
            sb.Append("  TreatedProcessD: ").Append(TreatedProcessD).Append("\n");
            sb.Append("  TreatedProcess: ").Append(TreatedProcess).Append("\n");
            sb.Append("  TreatedWasteMass: ").Append(TreatedWasteMass).Append("\n");
            sb.Append("  TreatedPcbContent: ").Append(TreatedPcbContent).Append("\n");
            sb.Append("  ForwardedCountryWasteMass: ").Append(ForwardedCountryWasteMass).Append("\n");
            sb.Append("  ForwardedAbroadWasteMass: ").Append(ForwardedAbroadWasteMass).Append("\n");
            sb.Append("  KpoForwardedCardNumber: ").Append(KpoForwardedCardNumber).Append("\n");
            sb.Append("  BasedOnKpo: ").Append(BasedOnKpo).Append("\n");
            sb.Append("  TransferToPoland: ").Append(TransferToPoland).Append("\n");
            sb.Append("  TransferToNaturalPersons: ").Append(TransferToNaturalPersons).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoPrintingPageList input)
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
                    this.GeneratedWasteMassInstallation == input.GeneratedWasteMassInstallation ||
                    (this.GeneratedWasteMassInstallation != null &&
                    this.GeneratedWasteMassInstallation.Equals(input.GeneratedWasteMassInstallation))
                ) && 
                (
                    this.GeneratedWasteMassExcludingInstallation == input.GeneratedWasteMassExcludingInstallation ||
                    (this.GeneratedWasteMassExcludingInstallation != null &&
                    this.GeneratedWasteMassExcludingInstallation.Equals(input.GeneratedWasteMassExcludingInstallation))
                ) && 
                (
                    this.GeneratedWasteMassInstallationFromServices == input.GeneratedWasteMassInstallationFromServices ||
                    (this.GeneratedWasteMassInstallationFromServices != null &&
                    this.GeneratedWasteMassInstallationFromServices.Equals(input.GeneratedWasteMassInstallationFromServices))
                ) && 
                (
                    this.GeneratedWasteMassExcludingInstallationFromServices == input.GeneratedWasteMassExcludingInstallationFromServices ||
                    (this.GeneratedWasteMassExcludingInstallationFromServices != null &&
                    this.GeneratedWasteMassExcludingInstallationFromServices.Equals(input.GeneratedWasteMassExcludingInstallationFromServices))
                ) && 
                (
                    this.WasteFromServices == input.WasteFromServices ||
                    (this.WasteFromServices != null &&
                    this.WasteFromServices.Equals(input.WasteFromServices))
                ) && 
                (
                    this.ExcavatedWasteMass == input.ExcavatedWasteMass ||
                    (this.ExcavatedWasteMass != null &&
                    this.ExcavatedWasteMass.Equals(input.ExcavatedWasteMass))
                ) && 
                (
                    this.CollectedWasteMass == input.CollectedWasteMass ||
                    (this.CollectedWasteMass != null &&
                    this.CollectedWasteMass.Equals(input.CollectedWasteMass))
                ) && 
                (
                    this.KpoCollectedCardNumber == input.KpoCollectedCardNumber ||
                    (this.KpoCollectedCardNumber != null &&
                    this.KpoCollectedCardNumber.Equals(input.KpoCollectedCardNumber))
                ) && 
                (
                    this.IsTreatedRecycle == input.IsTreatedRecycle ||
                    (this.IsTreatedRecycle != null &&
                    this.IsTreatedRecycle.Equals(input.IsTreatedRecycle))
                ) && 
                (
                    this.IsTreatedFillingUpDisadvantagedAreas == input.IsTreatedFillingUpDisadvantagedAreas ||
                    (this.IsTreatedFillingUpDisadvantagedAreas != null &&
                    this.IsTreatedFillingUpDisadvantagedAreas.Equals(input.IsTreatedFillingUpDisadvantagedAreas))
                ) && 
                (
                    this.IsTreatedPreparationForReUse == input.IsTreatedPreparationForReUse ||
                    (this.IsTreatedPreparationForReUse != null &&
                    this.IsTreatedPreparationForReUse.Equals(input.IsTreatedPreparationForReUse))
                ) && 
                (
                    this.IsTreatedAnotherRecoveryProcess == input.IsTreatedAnotherRecoveryProcess ||
                    (this.IsTreatedAnotherRecoveryProcess != null &&
                    this.IsTreatedAnotherRecoveryProcess.Equals(input.IsTreatedAnotherRecoveryProcess))
                ) && 
                (
                    this.IsTreatedNeutralization == input.IsTreatedNeutralization ||
                    (this.IsTreatedNeutralization != null &&
                    this.IsTreatedNeutralization.Equals(input.IsTreatedNeutralization))
                ) && 
                (
                    this.TreatedProcessR == input.TreatedProcessR ||
                    (this.TreatedProcessR != null &&
                    this.TreatedProcessR.Equals(input.TreatedProcessR))
                ) && 
                (
                    this.TreatedProcessD == input.TreatedProcessD ||
                    (this.TreatedProcessD != null &&
                    this.TreatedProcessD.Equals(input.TreatedProcessD))
                ) && 
                (
                    this.TreatedProcess == input.TreatedProcess ||
                    (this.TreatedProcess != null &&
                    this.TreatedProcess.Equals(input.TreatedProcess))
                ) && 
                (
                    this.TreatedWasteMass == input.TreatedWasteMass ||
                    (this.TreatedWasteMass != null &&
                    this.TreatedWasteMass.Equals(input.TreatedWasteMass))
                ) && 
                (
                    this.TreatedPcbContent == input.TreatedPcbContent ||
                    (this.TreatedPcbContent != null &&
                    this.TreatedPcbContent.Equals(input.TreatedPcbContent))
                ) && 
                (
                    this.ForwardedCountryWasteMass == input.ForwardedCountryWasteMass ||
                    (this.ForwardedCountryWasteMass != null &&
                    this.ForwardedCountryWasteMass.Equals(input.ForwardedCountryWasteMass))
                ) && 
                (
                    this.ForwardedAbroadWasteMass == input.ForwardedAbroadWasteMass ||
                    (this.ForwardedAbroadWasteMass != null &&
                    this.ForwardedAbroadWasteMass.Equals(input.ForwardedAbroadWasteMass))
                ) && 
                (
                    this.KpoForwardedCardNumber == input.KpoForwardedCardNumber ||
                    (this.KpoForwardedCardNumber != null &&
                    this.KpoForwardedCardNumber.Equals(input.KpoForwardedCardNumber))
                ) && 
                (
                    this.BasedOnKpo == input.BasedOnKpo ||
                    (this.BasedOnKpo != null &&
                    this.BasedOnKpo.Equals(input.BasedOnKpo))
                ) && 
                (
                    this.TransferToPoland == input.TransferToPoland ||
                    (this.TransferToPoland != null &&
                    this.TransferToPoland.Equals(input.TransferToPoland))
                ) && 
                (
                    this.TransferToNaturalPersons == input.TransferToNaturalPersons ||
                    (this.TransferToNaturalPersons != null &&
                    this.TransferToNaturalPersons.Equals(input.TransferToNaturalPersons))
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
                if (this.GeneratedWasteMassInstallation != null)
                    hashCode = hashCode * 59 + this.GeneratedWasteMassInstallation.GetHashCode();
                if (this.GeneratedWasteMassExcludingInstallation != null)
                    hashCode = hashCode * 59 + this.GeneratedWasteMassExcludingInstallation.GetHashCode();
                if (this.GeneratedWasteMassInstallationFromServices != null)
                    hashCode = hashCode * 59 + this.GeneratedWasteMassInstallationFromServices.GetHashCode();
                if (this.GeneratedWasteMassExcludingInstallationFromServices != null)
                    hashCode = hashCode * 59 + this.GeneratedWasteMassExcludingInstallationFromServices.GetHashCode();
                if (this.WasteFromServices != null)
                    hashCode = hashCode * 59 + this.WasteFromServices.GetHashCode();
                if (this.ExcavatedWasteMass != null)
                    hashCode = hashCode * 59 + this.ExcavatedWasteMass.GetHashCode();
                if (this.CollectedWasteMass != null)
                    hashCode = hashCode * 59 + this.CollectedWasteMass.GetHashCode();
                if (this.KpoCollectedCardNumber != null)
                    hashCode = hashCode * 59 + this.KpoCollectedCardNumber.GetHashCode();
                if (this.IsTreatedRecycle != null)
                    hashCode = hashCode * 59 + this.IsTreatedRecycle.GetHashCode();
                if (this.IsTreatedFillingUpDisadvantagedAreas != null)
                    hashCode = hashCode * 59 + this.IsTreatedFillingUpDisadvantagedAreas.GetHashCode();
                if (this.IsTreatedPreparationForReUse != null)
                    hashCode = hashCode * 59 + this.IsTreatedPreparationForReUse.GetHashCode();
                if (this.IsTreatedAnotherRecoveryProcess != null)
                    hashCode = hashCode * 59 + this.IsTreatedAnotherRecoveryProcess.GetHashCode();
                if (this.IsTreatedNeutralization != null)
                    hashCode = hashCode * 59 + this.IsTreatedNeutralization.GetHashCode();
                if (this.TreatedProcessR != null)
                    hashCode = hashCode * 59 + this.TreatedProcessR.GetHashCode();
                if (this.TreatedProcessD != null)
                    hashCode = hashCode * 59 + this.TreatedProcessD.GetHashCode();
                if (this.TreatedProcess != null)
                    hashCode = hashCode * 59 + this.TreatedProcess.GetHashCode();
                if (this.TreatedWasteMass != null)
                    hashCode = hashCode * 59 + this.TreatedWasteMass.GetHashCode();
                if (this.TreatedPcbContent != null)
                    hashCode = hashCode * 59 + this.TreatedPcbContent.GetHashCode();
                if (this.ForwardedCountryWasteMass != null)
                    hashCode = hashCode * 59 + this.ForwardedCountryWasteMass.GetHashCode();
                if (this.ForwardedAbroadWasteMass != null)
                    hashCode = hashCode * 59 + this.ForwardedAbroadWasteMass.GetHashCode();
                if (this.KpoForwardedCardNumber != null)
                    hashCode = hashCode * 59 + this.KpoForwardedCardNumber.GetHashCode();
                if (this.BasedOnKpo != null)
                    hashCode = hashCode * 59 + this.BasedOnKpo.GetHashCode();
                if (this.TransferToPoland != null)
                    hashCode = hashCode * 59 + this.TransferToPoland.GetHashCode();
                if (this.TransferToNaturalPersons != null)
                    hashCode = hashCode * 59 + this.TransferToNaturalPersons.GetHashCode();
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
