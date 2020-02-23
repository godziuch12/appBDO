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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto" /> class.
        /// </summary>
        /// <param name="lotNumber">Numer działki.</param>
        /// <param name="geodesicPrecinctNumber">Numer obrębu geodezyjnego.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto(string lotNumber = default(string), string geodesicPrecinctNumber = default(string))
        {
            this.LotNumber = lotNumber;
            this.GeodesicPrecinctNumber = geodesicPrecinctNumber;
        }
        
        /// <summary>
        /// Numer działki
        /// </summary>
        /// <value>Numer działki</value>
        [DataMember(Name="lotNumber", EmitDefaultValue=false)]
        public string LotNumber { get; set; }

        /// <summary>
        /// Numer obrębu geodezyjnego
        /// </summary>
        /// <value>Numer obrębu geodezyjnego</value>
        [DataMember(Name="geodesicPrecinctNumber", EmitDefaultValue=false)]
        public string GeodesicPrecinctNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto {\n");
            sb.Append("  LotNumber: ").Append(LotNumber).Append("\n");
            sb.Append("  GeodesicPrecinctNumber: ").Append(GeodesicPrecinctNumber).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1NewLotPrecinctDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LotNumber == input.LotNumber ||
                    (this.LotNumber != null &&
                    this.LotNumber.Equals(input.LotNumber))
                ) && 
                (
                    this.GeodesicPrecinctNumber == input.GeodesicPrecinctNumber ||
                    (this.GeodesicPrecinctNumber != null &&
                    this.GeodesicPrecinctNumber.Equals(input.GeodesicPrecinctNumber))
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
                if (this.LotNumber != null)
                    hashCode = hashCode * 59 + this.LotNumber.GetHashCode();
                if (this.GeodesicPrecinctNumber != null)
                    hashCode = hashCode * 59 + this.GeodesicPrecinctNumber.GetHashCode();
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
