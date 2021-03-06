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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse" /> class.
        /// </summary>
        /// <param name="kekosId">Id karty ewidencji komunalnych osadów ściekowych.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse(Guid? kekosId = default(Guid?))
        {
            this.KekosId = kekosId;
        }
        
        /// <summary>
        /// Id karty ewidencji komunalnych osadów ściekowych
        /// </summary>
        /// <value>Id karty ewidencji komunalnych osadów ściekowych</value>
        [DataMember(Name="kekosId", EmitDefaultValue=false)]
        public Guid? KekosId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse {\n");
            sb.Append("  KekosId: ").Append(KekosId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateKekosResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KekosId == input.KekosId ||
                    (this.KekosId != null &&
                    this.KekosId.Equals(input.KekosId))
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
                if (this.KekosId != null)
                    hashCode = hashCode * 59 + this.KekosId.GetHashCode();
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
