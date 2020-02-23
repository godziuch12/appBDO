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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse" /> class.
        /// </summary>
        /// <param name="countryWasteMass">Łączna masa przekazanych odpadów w kraju [Mg].</param>
        /// <param name="abroadWasteMass">Łączna masa przekazanych odpadów poza granice RP. [Mg].</param>
        /// <param name="keoDto">Karta keo.</param>
        /// <param name="forwardedForwardedKeos">forwardedForwardedKeos.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse(double? countryWasteMass = default(double?), double? abroadWasteMass = default(double?), WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoDto keoDto = default(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoDto), WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem forwardedForwardedKeos = default(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem))
        {
            this.CountryWasteMass = countryWasteMass;
            this.AbroadWasteMass = abroadWasteMass;
            this.KeoDto = keoDto;
            this.ForwardedForwardedKeos = forwardedForwardedKeos;
        }
        
        /// <summary>
        /// Łączna masa przekazanych odpadów w kraju [Mg]
        /// </summary>
        /// <value>Łączna masa przekazanych odpadów w kraju [Mg]</value>
        [DataMember(Name="countryWasteMass", EmitDefaultValue=false)]
        public double? CountryWasteMass { get; set; }

        /// <summary>
        /// Łączna masa przekazanych odpadów poza granice RP. [Mg]
        /// </summary>
        /// <value>Łączna masa przekazanych odpadów poza granice RP. [Mg]</value>
        [DataMember(Name="abroadWasteMass", EmitDefaultValue=false)]
        public double? AbroadWasteMass { get; set; }

        /// <summary>
        /// Karta keo
        /// </summary>
        /// <value>Karta keo</value>
        [DataMember(Name="keoDto", EmitDefaultValue=false)]
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoDto KeoDto { get; set; }

        /// <summary>
        /// Gets or Sets ForwardedForwardedKeos
        /// </summary>
        [DataMember(Name="forwardedForwardedKeos", EmitDefaultValue=false)]
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem ForwardedForwardedKeos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse {\n");
            sb.Append("  CountryWasteMass: ").Append(CountryWasteMass).Append("\n");
            sb.Append("  AbroadWasteMass: ").Append(AbroadWasteMass).Append("\n");
            sb.Append("  KeoDto: ").Append(KeoDto).Append("\n");
            sb.Append("  ForwardedForwardedKeos: ").Append(ForwardedForwardedKeos).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1SearchKeoForwardedResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryWasteMass == input.CountryWasteMass ||
                    (this.CountryWasteMass != null &&
                    this.CountryWasteMass.Equals(input.CountryWasteMass))
                ) && 
                (
                    this.AbroadWasteMass == input.AbroadWasteMass ||
                    (this.AbroadWasteMass != null &&
                    this.AbroadWasteMass.Equals(input.AbroadWasteMass))
                ) && 
                (
                    this.KeoDto == input.KeoDto ||
                    (this.KeoDto != null &&
                    this.KeoDto.Equals(input.KeoDto))
                ) && 
                (
                    this.ForwardedForwardedKeos == input.ForwardedForwardedKeos ||
                    (this.ForwardedForwardedKeos != null &&
                    this.ForwardedForwardedKeos.Equals(input.ForwardedForwardedKeos))
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
                if (this.CountryWasteMass != null)
                    hashCode = hashCode * 59 + this.CountryWasteMass.GetHashCode();
                if (this.AbroadWasteMass != null)
                    hashCode = hashCode * 59 + this.AbroadWasteMass.GetHashCode();
                if (this.KeoDto != null)
                    hashCode = hashCode * 59 + this.KeoDto.GetHashCode();
                if (this.ForwardedForwardedKeos != null)
                    hashCode = hashCode * 59 + this.ForwardedForwardedKeos.GetHashCode();
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
