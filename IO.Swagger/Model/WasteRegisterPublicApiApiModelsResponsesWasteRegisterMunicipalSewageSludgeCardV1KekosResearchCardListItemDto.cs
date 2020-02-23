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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto" /> class.
        /// </summary>
        /// <param name="kekosResearchCardId">Id karty badań.</param>
        /// <param name="batchOfGeneratedSedimentId">Id wpisu wytworzone osady.</param>
        /// <param name="researchNumber">Numer badania.</param>
        /// <param name="researchDate">Data badania.</param>
        /// <param name="phReaction">phReaction.</param>
        /// <param name="dryMatterContent">Zawartość suchej masy [% s.m.].</param>
        /// <param name="contentOfOrganicSubstances">Zawartość substancji organicznych [% s.m.].</param>
        /// <param name="contentOfAmmoniumNitrogen">Zawartość azotu ogólnego [% s.m.].</param>
        /// <param name="contentOfTotalNitrogen">w tym azotu amonowego[% s.m.].</param>
        /// <param name="contentOfTotalPhosphorus">Zawartość fosforu ogólnego [% s.m.].</param>
        /// <param name="calciumContent">Zawartość wapnia [% s.m.].</param>
        /// <param name="magnesiumContent">Zawartość magnezu [% s.m.].</param>
        /// <param name="numberOfParasiticEggs">Łączna liczba żywych jaj pasożytów [liczba/kg s.m osadu].</param>
        /// <param name="salmonellaBacteria">Bakterie z rodzaju Salmonella w 100g osadów przeznaczonych do badań.</param>
        /// <param name="cadmiumContent">Kadm [mg/kg s.m.].</param>
        /// <param name="copperContent">Miedź [mg/kg s.m.].</param>
        /// <param name="leadContent">Ołów [mg/kg s.m.].</param>
        /// <param name="mercuryContent">Rtęć [mg/kg s.m.].</param>
        /// <param name="nickelContent">Nikiel [mg/kg s.m.].</param>
        /// <param name="chromeContent">Chrom [mg/kg s.m.].</param>
        /// <param name="zincContent">Cynk [mg/kg s.m.].</param>
        /// <param name="isSewageSludgeFormLiquid">Postać komunalnych osadów ściekowych: płynna.</param>
        /// <param name="isSewageSludgeFormMazist">Postać komunalnych osadów ściekowych: mazista.</param>
        /// <param name="isSewageSludgeFormEarthy">Postać komunalnych osadów ściekowych: ziemista.</param>
        /// <param name="canBeEdited">canBeEdited.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto(Guid? kekosResearchCardId = default(Guid?), Guid? batchOfGeneratedSedimentId = default(Guid?), string researchNumber = default(string), DateTime? researchDate = default(DateTime?), double? phReaction = default(double?), double? dryMatterContent = default(double?), double? contentOfOrganicSubstances = default(double?), double? contentOfAmmoniumNitrogen = default(double?), double? contentOfTotalNitrogen = default(double?), double? contentOfTotalPhosphorus = default(double?), double? calciumContent = default(double?), double? magnesiumContent = default(double?), double? numberOfParasiticEggs = default(double?), bool? salmonellaBacteria = default(bool?), double? cadmiumContent = default(double?), double? copperContent = default(double?), double? leadContent = default(double?), double? mercuryContent = default(double?), double? nickelContent = default(double?), double? chromeContent = default(double?), double? zincContent = default(double?), bool? isSewageSludgeFormLiquid = default(bool?), bool? isSewageSludgeFormMazist = default(bool?), bool? isSewageSludgeFormEarthy = default(bool?), bool? canBeEdited = default(bool?))
        {
            this.KekosResearchCardId = kekosResearchCardId;
            this.BatchOfGeneratedSedimentId = batchOfGeneratedSedimentId;
            this.ResearchNumber = researchNumber;
            this.ResearchDate = researchDate;
            this.PhReaction = phReaction;
            this.DryMatterContent = dryMatterContent;
            this.ContentOfOrganicSubstances = contentOfOrganicSubstances;
            this.ContentOfAmmoniumNitrogen = contentOfAmmoniumNitrogen;
            this.ContentOfTotalNitrogen = contentOfTotalNitrogen;
            this.ContentOfTotalPhosphorus = contentOfTotalPhosphorus;
            this.CalciumContent = calciumContent;
            this.MagnesiumContent = magnesiumContent;
            this.NumberOfParasiticEggs = numberOfParasiticEggs;
            this.SalmonellaBacteria = salmonellaBacteria;
            this.CadmiumContent = cadmiumContent;
            this.CopperContent = copperContent;
            this.LeadContent = leadContent;
            this.MercuryContent = mercuryContent;
            this.NickelContent = nickelContent;
            this.ChromeContent = chromeContent;
            this.ZincContent = zincContent;
            this.IsSewageSludgeFormLiquid = isSewageSludgeFormLiquid;
            this.IsSewageSludgeFormMazist = isSewageSludgeFormMazist;
            this.IsSewageSludgeFormEarthy = isSewageSludgeFormEarthy;
            this.CanBeEdited = canBeEdited;
        }
        
        /// <summary>
        /// Id karty badań
        /// </summary>
        /// <value>Id karty badań</value>
        [DataMember(Name="kekosResearchCardId", EmitDefaultValue=false)]
        public Guid? KekosResearchCardId { get; set; }

        /// <summary>
        /// Id wpisu wytworzone osady
        /// </summary>
        /// <value>Id wpisu wytworzone osady</value>
        [DataMember(Name="batchOfGeneratedSedimentId", EmitDefaultValue=false)]
        public Guid? BatchOfGeneratedSedimentId { get; set; }

        /// <summary>
        /// Numer badania
        /// </summary>
        /// <value>Numer badania</value>
        [DataMember(Name="researchNumber", EmitDefaultValue=false)]
        public string ResearchNumber { get; set; }

        /// <summary>
        /// Data badania
        /// </summary>
        /// <value>Data badania</value>
        [DataMember(Name="researchDate", EmitDefaultValue=false)]
        public DateTime? ResearchDate { get; set; }

        /// <summary>
        /// Gets or Sets PhReaction
        /// </summary>
        [DataMember(Name="phReaction", EmitDefaultValue=false)]
        public double? PhReaction { get; set; }

        /// <summary>
        /// Zawartość suchej masy [% s.m.]
        /// </summary>
        /// <value>Zawartość suchej masy [% s.m.]</value>
        [DataMember(Name="dryMatterContent", EmitDefaultValue=false)]
        public double? DryMatterContent { get; set; }

        /// <summary>
        /// Zawartość substancji organicznych [% s.m.]
        /// </summary>
        /// <value>Zawartość substancji organicznych [% s.m.]</value>
        [DataMember(Name="contentOfOrganicSubstances", EmitDefaultValue=false)]
        public double? ContentOfOrganicSubstances { get; set; }

        /// <summary>
        /// Zawartość azotu ogólnego [% s.m.]
        /// </summary>
        /// <value>Zawartość azotu ogólnego [% s.m.]</value>
        [DataMember(Name="contentOfAmmoniumNitrogen", EmitDefaultValue=false)]
        public double? ContentOfAmmoniumNitrogen { get; set; }

        /// <summary>
        /// w tym azotu amonowego[% s.m.]
        /// </summary>
        /// <value>w tym azotu amonowego[% s.m.]</value>
        [DataMember(Name="contentOfTotalNitrogen", EmitDefaultValue=false)]
        public double? ContentOfTotalNitrogen { get; set; }

        /// <summary>
        /// Zawartość fosforu ogólnego [% s.m.]
        /// </summary>
        /// <value>Zawartość fosforu ogólnego [% s.m.]</value>
        [DataMember(Name="contentOfTotalPhosphorus", EmitDefaultValue=false)]
        public double? ContentOfTotalPhosphorus { get; set; }

        /// <summary>
        /// Zawartość wapnia [% s.m.]
        /// </summary>
        /// <value>Zawartość wapnia [% s.m.]</value>
        [DataMember(Name="calciumContent", EmitDefaultValue=false)]
        public double? CalciumContent { get; set; }

        /// <summary>
        /// Zawartość magnezu [% s.m.]
        /// </summary>
        /// <value>Zawartość magnezu [% s.m.]</value>
        [DataMember(Name="magnesiumContent", EmitDefaultValue=false)]
        public double? MagnesiumContent { get; set; }

        /// <summary>
        /// Łączna liczba żywych jaj pasożytów [liczba/kg s.m osadu]
        /// </summary>
        /// <value>Łączna liczba żywych jaj pasożytów [liczba/kg s.m osadu]</value>
        [DataMember(Name="numberOfParasiticEggs", EmitDefaultValue=false)]
        public double? NumberOfParasiticEggs { get; set; }

        /// <summary>
        /// Bakterie z rodzaju Salmonella w 100g osadów przeznaczonych do badań
        /// </summary>
        /// <value>Bakterie z rodzaju Salmonella w 100g osadów przeznaczonych do badań</value>
        [DataMember(Name="salmonellaBacteria", EmitDefaultValue=false)]
        public bool? SalmonellaBacteria { get; set; }

        /// <summary>
        /// Kadm [mg/kg s.m.]
        /// </summary>
        /// <value>Kadm [mg/kg s.m.]</value>
        [DataMember(Name="cadmiumContent", EmitDefaultValue=false)]
        public double? CadmiumContent { get; set; }

        /// <summary>
        /// Miedź [mg/kg s.m.]
        /// </summary>
        /// <value>Miedź [mg/kg s.m.]</value>
        [DataMember(Name="copperContent", EmitDefaultValue=false)]
        public double? CopperContent { get; set; }

        /// <summary>
        /// Ołów [mg/kg s.m.]
        /// </summary>
        /// <value>Ołów [mg/kg s.m.]</value>
        [DataMember(Name="leadContent", EmitDefaultValue=false)]
        public double? LeadContent { get; set; }

        /// <summary>
        /// Rtęć [mg/kg s.m.]
        /// </summary>
        /// <value>Rtęć [mg/kg s.m.]</value>
        [DataMember(Name="mercuryContent", EmitDefaultValue=false)]
        public double? MercuryContent { get; set; }

        /// <summary>
        /// Nikiel [mg/kg s.m.]
        /// </summary>
        /// <value>Nikiel [mg/kg s.m.]</value>
        [DataMember(Name="nickelContent", EmitDefaultValue=false)]
        public double? NickelContent { get; set; }

        /// <summary>
        /// Chrom [mg/kg s.m.]
        /// </summary>
        /// <value>Chrom [mg/kg s.m.]</value>
        [DataMember(Name="chromeContent", EmitDefaultValue=false)]
        public double? ChromeContent { get; set; }

        /// <summary>
        /// Cynk [mg/kg s.m.]
        /// </summary>
        /// <value>Cynk [mg/kg s.m.]</value>
        [DataMember(Name="zincContent", EmitDefaultValue=false)]
        public double? ZincContent { get; set; }

        /// <summary>
        /// Postać komunalnych osadów ściekowych: płynna
        /// </summary>
        /// <value>Postać komunalnych osadów ściekowych: płynna</value>
        [DataMember(Name="isSewageSludgeFormLiquid", EmitDefaultValue=false)]
        public bool? IsSewageSludgeFormLiquid { get; set; }

        /// <summary>
        /// Postać komunalnych osadów ściekowych: mazista
        /// </summary>
        /// <value>Postać komunalnych osadów ściekowych: mazista</value>
        [DataMember(Name="isSewageSludgeFormMazist", EmitDefaultValue=false)]
        public bool? IsSewageSludgeFormMazist { get; set; }

        /// <summary>
        /// Postać komunalnych osadów ściekowych: ziemista
        /// </summary>
        /// <value>Postać komunalnych osadów ściekowych: ziemista</value>
        [DataMember(Name="isSewageSludgeFormEarthy", EmitDefaultValue=false)]
        public bool? IsSewageSludgeFormEarthy { get; set; }

        /// <summary>
        /// Gets or Sets CanBeEdited
        /// </summary>
        [DataMember(Name="canBeEdited", EmitDefaultValue=false)]
        public bool? CanBeEdited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto {\n");
            sb.Append("  KekosResearchCardId: ").Append(KekosResearchCardId).Append("\n");
            sb.Append("  BatchOfGeneratedSedimentId: ").Append(BatchOfGeneratedSedimentId).Append("\n");
            sb.Append("  ResearchNumber: ").Append(ResearchNumber).Append("\n");
            sb.Append("  ResearchDate: ").Append(ResearchDate).Append("\n");
            sb.Append("  PhReaction: ").Append(PhReaction).Append("\n");
            sb.Append("  DryMatterContent: ").Append(DryMatterContent).Append("\n");
            sb.Append("  ContentOfOrganicSubstances: ").Append(ContentOfOrganicSubstances).Append("\n");
            sb.Append("  ContentOfAmmoniumNitrogen: ").Append(ContentOfAmmoniumNitrogen).Append("\n");
            sb.Append("  ContentOfTotalNitrogen: ").Append(ContentOfTotalNitrogen).Append("\n");
            sb.Append("  ContentOfTotalPhosphorus: ").Append(ContentOfTotalPhosphorus).Append("\n");
            sb.Append("  CalciumContent: ").Append(CalciumContent).Append("\n");
            sb.Append("  MagnesiumContent: ").Append(MagnesiumContent).Append("\n");
            sb.Append("  NumberOfParasiticEggs: ").Append(NumberOfParasiticEggs).Append("\n");
            sb.Append("  SalmonellaBacteria: ").Append(SalmonellaBacteria).Append("\n");
            sb.Append("  CadmiumContent: ").Append(CadmiumContent).Append("\n");
            sb.Append("  CopperContent: ").Append(CopperContent).Append("\n");
            sb.Append("  LeadContent: ").Append(LeadContent).Append("\n");
            sb.Append("  MercuryContent: ").Append(MercuryContent).Append("\n");
            sb.Append("  NickelContent: ").Append(NickelContent).Append("\n");
            sb.Append("  ChromeContent: ").Append(ChromeContent).Append("\n");
            sb.Append("  ZincContent: ").Append(ZincContent).Append("\n");
            sb.Append("  IsSewageSludgeFormLiquid: ").Append(IsSewageSludgeFormLiquid).Append("\n");
            sb.Append("  IsSewageSludgeFormMazist: ").Append(IsSewageSludgeFormMazist).Append("\n");
            sb.Append("  IsSewageSludgeFormEarthy: ").Append(IsSewageSludgeFormEarthy).Append("\n");
            sb.Append("  CanBeEdited: ").Append(CanBeEdited).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1KekosResearchCardListItemDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KekosResearchCardId == input.KekosResearchCardId ||
                    (this.KekosResearchCardId != null &&
                    this.KekosResearchCardId.Equals(input.KekosResearchCardId))
                ) && 
                (
                    this.BatchOfGeneratedSedimentId == input.BatchOfGeneratedSedimentId ||
                    (this.BatchOfGeneratedSedimentId != null &&
                    this.BatchOfGeneratedSedimentId.Equals(input.BatchOfGeneratedSedimentId))
                ) && 
                (
                    this.ResearchNumber == input.ResearchNumber ||
                    (this.ResearchNumber != null &&
                    this.ResearchNumber.Equals(input.ResearchNumber))
                ) && 
                (
                    this.ResearchDate == input.ResearchDate ||
                    (this.ResearchDate != null &&
                    this.ResearchDate.Equals(input.ResearchDate))
                ) && 
                (
                    this.PhReaction == input.PhReaction ||
                    (this.PhReaction != null &&
                    this.PhReaction.Equals(input.PhReaction))
                ) && 
                (
                    this.DryMatterContent == input.DryMatterContent ||
                    (this.DryMatterContent != null &&
                    this.DryMatterContent.Equals(input.DryMatterContent))
                ) && 
                (
                    this.ContentOfOrganicSubstances == input.ContentOfOrganicSubstances ||
                    (this.ContentOfOrganicSubstances != null &&
                    this.ContentOfOrganicSubstances.Equals(input.ContentOfOrganicSubstances))
                ) && 
                (
                    this.ContentOfAmmoniumNitrogen == input.ContentOfAmmoniumNitrogen ||
                    (this.ContentOfAmmoniumNitrogen != null &&
                    this.ContentOfAmmoniumNitrogen.Equals(input.ContentOfAmmoniumNitrogen))
                ) && 
                (
                    this.ContentOfTotalNitrogen == input.ContentOfTotalNitrogen ||
                    (this.ContentOfTotalNitrogen != null &&
                    this.ContentOfTotalNitrogen.Equals(input.ContentOfTotalNitrogen))
                ) && 
                (
                    this.ContentOfTotalPhosphorus == input.ContentOfTotalPhosphorus ||
                    (this.ContentOfTotalPhosphorus != null &&
                    this.ContentOfTotalPhosphorus.Equals(input.ContentOfTotalPhosphorus))
                ) && 
                (
                    this.CalciumContent == input.CalciumContent ||
                    (this.CalciumContent != null &&
                    this.CalciumContent.Equals(input.CalciumContent))
                ) && 
                (
                    this.MagnesiumContent == input.MagnesiumContent ||
                    (this.MagnesiumContent != null &&
                    this.MagnesiumContent.Equals(input.MagnesiumContent))
                ) && 
                (
                    this.NumberOfParasiticEggs == input.NumberOfParasiticEggs ||
                    (this.NumberOfParasiticEggs != null &&
                    this.NumberOfParasiticEggs.Equals(input.NumberOfParasiticEggs))
                ) && 
                (
                    this.SalmonellaBacteria == input.SalmonellaBacteria ||
                    (this.SalmonellaBacteria != null &&
                    this.SalmonellaBacteria.Equals(input.SalmonellaBacteria))
                ) && 
                (
                    this.CadmiumContent == input.CadmiumContent ||
                    (this.CadmiumContent != null &&
                    this.CadmiumContent.Equals(input.CadmiumContent))
                ) && 
                (
                    this.CopperContent == input.CopperContent ||
                    (this.CopperContent != null &&
                    this.CopperContent.Equals(input.CopperContent))
                ) && 
                (
                    this.LeadContent == input.LeadContent ||
                    (this.LeadContent != null &&
                    this.LeadContent.Equals(input.LeadContent))
                ) && 
                (
                    this.MercuryContent == input.MercuryContent ||
                    (this.MercuryContent != null &&
                    this.MercuryContent.Equals(input.MercuryContent))
                ) && 
                (
                    this.NickelContent == input.NickelContent ||
                    (this.NickelContent != null &&
                    this.NickelContent.Equals(input.NickelContent))
                ) && 
                (
                    this.ChromeContent == input.ChromeContent ||
                    (this.ChromeContent != null &&
                    this.ChromeContent.Equals(input.ChromeContent))
                ) && 
                (
                    this.ZincContent == input.ZincContent ||
                    (this.ZincContent != null &&
                    this.ZincContent.Equals(input.ZincContent))
                ) && 
                (
                    this.IsSewageSludgeFormLiquid == input.IsSewageSludgeFormLiquid ||
                    (this.IsSewageSludgeFormLiquid != null &&
                    this.IsSewageSludgeFormLiquid.Equals(input.IsSewageSludgeFormLiquid))
                ) && 
                (
                    this.IsSewageSludgeFormMazist == input.IsSewageSludgeFormMazist ||
                    (this.IsSewageSludgeFormMazist != null &&
                    this.IsSewageSludgeFormMazist.Equals(input.IsSewageSludgeFormMazist))
                ) && 
                (
                    this.IsSewageSludgeFormEarthy == input.IsSewageSludgeFormEarthy ||
                    (this.IsSewageSludgeFormEarthy != null &&
                    this.IsSewageSludgeFormEarthy.Equals(input.IsSewageSludgeFormEarthy))
                ) && 
                (
                    this.CanBeEdited == input.CanBeEdited ||
                    (this.CanBeEdited != null &&
                    this.CanBeEdited.Equals(input.CanBeEdited))
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
                if (this.KekosResearchCardId != null)
                    hashCode = hashCode * 59 + this.KekosResearchCardId.GetHashCode();
                if (this.BatchOfGeneratedSedimentId != null)
                    hashCode = hashCode * 59 + this.BatchOfGeneratedSedimentId.GetHashCode();
                if (this.ResearchNumber != null)
                    hashCode = hashCode * 59 + this.ResearchNumber.GetHashCode();
                if (this.ResearchDate != null)
                    hashCode = hashCode * 59 + this.ResearchDate.GetHashCode();
                if (this.PhReaction != null)
                    hashCode = hashCode * 59 + this.PhReaction.GetHashCode();
                if (this.DryMatterContent != null)
                    hashCode = hashCode * 59 + this.DryMatterContent.GetHashCode();
                if (this.ContentOfOrganicSubstances != null)
                    hashCode = hashCode * 59 + this.ContentOfOrganicSubstances.GetHashCode();
                if (this.ContentOfAmmoniumNitrogen != null)
                    hashCode = hashCode * 59 + this.ContentOfAmmoniumNitrogen.GetHashCode();
                if (this.ContentOfTotalNitrogen != null)
                    hashCode = hashCode * 59 + this.ContentOfTotalNitrogen.GetHashCode();
                if (this.ContentOfTotalPhosphorus != null)
                    hashCode = hashCode * 59 + this.ContentOfTotalPhosphorus.GetHashCode();
                if (this.CalciumContent != null)
                    hashCode = hashCode * 59 + this.CalciumContent.GetHashCode();
                if (this.MagnesiumContent != null)
                    hashCode = hashCode * 59 + this.MagnesiumContent.GetHashCode();
                if (this.NumberOfParasiticEggs != null)
                    hashCode = hashCode * 59 + this.NumberOfParasiticEggs.GetHashCode();
                if (this.SalmonellaBacteria != null)
                    hashCode = hashCode * 59 + this.SalmonellaBacteria.GetHashCode();
                if (this.CadmiumContent != null)
                    hashCode = hashCode * 59 + this.CadmiumContent.GetHashCode();
                if (this.CopperContent != null)
                    hashCode = hashCode * 59 + this.CopperContent.GetHashCode();
                if (this.LeadContent != null)
                    hashCode = hashCode * 59 + this.LeadContent.GetHashCode();
                if (this.MercuryContent != null)
                    hashCode = hashCode * 59 + this.MercuryContent.GetHashCode();
                if (this.NickelContent != null)
                    hashCode = hashCode * 59 + this.NickelContent.GetHashCode();
                if (this.ChromeContent != null)
                    hashCode = hashCode * 59 + this.ChromeContent.GetHashCode();
                if (this.ZincContent != null)
                    hashCode = hashCode * 59 + this.ZincContent.GetHashCode();
                if (this.IsSewageSludgeFormLiquid != null)
                    hashCode = hashCode * 59 + this.IsSewageSludgeFormLiquid.GetHashCode();
                if (this.IsSewageSludgeFormMazist != null)
                    hashCode = hashCode * 59 + this.IsSewageSludgeFormMazist.GetHashCode();
                if (this.IsSewageSludgeFormEarthy != null)
                    hashCode = hashCode * 59 + this.IsSewageSludgeFormEarthy.GetHashCode();
                if (this.CanBeEdited != null)
                    hashCode = hashCode * 59 + this.CanBeEdited.GetHashCode();
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
