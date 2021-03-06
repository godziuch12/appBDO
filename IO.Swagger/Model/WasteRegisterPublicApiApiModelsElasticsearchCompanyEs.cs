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
    /// WasteRegisterPublicApiApiModelsElasticsearchCompanyEs
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsElasticsearchCompanyEs :  IEquatable<WasteRegisterPublicApiApiModelsElasticsearchCompanyEs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsElasticsearchCompanyEs" /> class.
        /// </summary>
        /// <param name="companyId">Id podmiotu.</param>
        /// <param name="registrationNumber">Numer rejestrowy podmiotu.</param>
        /// <param name="name">Nazwa podmiotu.</param>
        /// <param name="nip">NIP podmiotu.</param>
        /// <param name="nipEu">Europejski NIP podmiotu.</param>
        /// <param name="pesel">PESEL, jeśli podmiot nie posiada NIP.</param>
        /// <param name="country">Kraj.</param>
        /// <param name="address">Adres.</param>
        /// <param name="buildingNumber">Numer budynku.</param>
        /// <param name="localNumber">Numer lokalu.</param>
        /// <param name="postalCode">Kod pocztowy.</param>
        /// <param name="teryt">Teryt.</param>
        public WasteRegisterPublicApiApiModelsElasticsearchCompanyEs(string companyId = default(string), string registrationNumber = default(string), string name = default(string), string nip = default(string), string nipEu = default(string), string pesel = default(string), string country = default(string), string address = default(string), string buildingNumber = default(string), string localNumber = default(string), string postalCode = default(string), string teryt = default(string))
        {
            this.CompanyId = companyId;
            this.RegistrationNumber = registrationNumber;
            this.Name = name;
            this.Nip = nip;
            this.NipEu = nipEu;
            this.Pesel = pesel;
            this.Country = country;
            this.Address = address;
            this.BuildingNumber = buildingNumber;
            this.LocalNumber = localNumber;
            this.PostalCode = postalCode;
            this.Teryt = teryt;
        }
        
        /// <summary>
        /// Id podmiotu
        /// </summary>
        /// <value>Id podmiotu</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Numer rejestrowy podmiotu
        /// </summary>
        /// <value>Numer rejestrowy podmiotu</value>
        [DataMember(Name="registrationNumber", EmitDefaultValue=false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Nazwa podmiotu
        /// </summary>
        /// <value>Nazwa podmiotu</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// NIP podmiotu
        /// </summary>
        /// <value>NIP podmiotu</value>
        [DataMember(Name="nip", EmitDefaultValue=false)]
        public string Nip { get; set; }

        /// <summary>
        /// Europejski NIP podmiotu
        /// </summary>
        /// <value>Europejski NIP podmiotu</value>
        [DataMember(Name="nipEu", EmitDefaultValue=false)]
        public string NipEu { get; set; }

        /// <summary>
        /// PESEL, jeśli podmiot nie posiada NIP
        /// </summary>
        /// <value>PESEL, jeśli podmiot nie posiada NIP</value>
        [DataMember(Name="pesel", EmitDefaultValue=false)]
        public string Pesel { get; set; }

        /// <summary>
        /// Kraj
        /// </summary>
        /// <value>Kraj</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Adres
        /// </summary>
        /// <value>Adres</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

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
        /// Teryt
        /// </summary>
        /// <value>Teryt</value>
        [DataMember(Name="teryt", EmitDefaultValue=false)]
        public string Teryt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsElasticsearchCompanyEs {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nip: ").Append(Nip).Append("\n");
            sb.Append("  NipEu: ").Append(NipEu).Append("\n");
            sb.Append("  Pesel: ").Append(Pesel).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  LocalNumber: ").Append(LocalNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Teryt: ").Append(Teryt).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsElasticsearchCompanyEs);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsElasticsearchCompanyEs instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsElasticsearchCompanyEs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsElasticsearchCompanyEs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nip == input.Nip ||
                    (this.Nip != null &&
                    this.Nip.Equals(input.Nip))
                ) && 
                (
                    this.NipEu == input.NipEu ||
                    (this.NipEu != null &&
                    this.NipEu.Equals(input.NipEu))
                ) && 
                (
                    this.Pesel == input.Pesel ||
                    (this.Pesel != null &&
                    this.Pesel.Equals(input.Pesel))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                    this.Teryt == input.Teryt ||
                    (this.Teryt != null &&
                    this.Teryt.Equals(input.Teryt))
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nip != null)
                    hashCode = hashCode * 59 + this.Nip.GetHashCode();
                if (this.NipEu != null)
                    hashCode = hashCode * 59 + this.NipEu.GetHashCode();
                if (this.Pesel != null)
                    hashCode = hashCode * 59 + this.Pesel.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BuildingNumber != null)
                    hashCode = hashCode * 59 + this.BuildingNumber.GetHashCode();
                if (this.LocalNumber != null)
                    hashCode = hashCode * 59 + this.LocalNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Teryt != null)
                    hashCode = hashCode * 59 + this.Teryt.GetHashCode();
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
