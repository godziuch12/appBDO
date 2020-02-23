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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest" /> class.
        /// </summary>
        /// <param name="onlyContainingResearchCards">onlyContainingResearchCards.</param>
        /// <param name="kekosId">Id karty ewidencji komunalnych osadów ściekowych.</param>
        /// <param name="paginationParameters">Parametry paginacji.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest(bool? onlyContainingResearchCards = default(bool?), Guid? kekosId = default(Guid?), WasteRegisterPublicApiApiModelsCollectionsPaginationParameters paginationParameters = default(WasteRegisterPublicApiApiModelsCollectionsPaginationParameters))
        {
            this.OnlyContainingResearchCards = onlyContainingResearchCards;
            this.KekosId = kekosId;
            this.PaginationParameters = paginationParameters;
        }
        
        /// <summary>
        /// Gets or Sets OnlyContainingResearchCards
        /// </summary>
        [DataMember(Name="onlyContainingResearchCards", EmitDefaultValue=false)]
        public bool? OnlyContainingResearchCards { get; set; }

        /// <summary>
        /// Id karty ewidencji komunalnych osadów ściekowych
        /// </summary>
        /// <value>Id karty ewidencji komunalnych osadów ściekowych</value>
        [DataMember(Name="kekosId", EmitDefaultValue=false)]
        public Guid? KekosId { get; set; }

        /// <summary>
        /// Parametry paginacji
        /// </summary>
        /// <value>Parametry paginacji</value>
        [DataMember(Name="paginationParameters", EmitDefaultValue=false)]
        public WasteRegisterPublicApiApiModelsCollectionsPaginationParameters PaginationParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest {\n");
            sb.Append("  OnlyContainingResearchCards: ").Append(OnlyContainingResearchCards).Append("\n");
            sb.Append("  KekosId: ").Append(KekosId).Append("\n");
            sb.Append("  PaginationParameters: ").Append(PaginationParameters).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalSewageSludgeCardV1GetBatchGeneratedSedimentsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlyContainingResearchCards == input.OnlyContainingResearchCards ||
                    (this.OnlyContainingResearchCards != null &&
                    this.OnlyContainingResearchCards.Equals(input.OnlyContainingResearchCards))
                ) && 
                (
                    this.KekosId == input.KekosId ||
                    (this.KekosId != null &&
                    this.KekosId.Equals(input.KekosId))
                ) && 
                (
                    this.PaginationParameters == input.PaginationParameters ||
                    (this.PaginationParameters != null &&
                    this.PaginationParameters.Equals(input.PaginationParameters))
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
                if (this.OnlyContainingResearchCards != null)
                    hashCode = hashCode * 59 + this.OnlyContainingResearchCards.GetHashCode();
                if (this.KekosId != null)
                    hashCode = hashCode * 59 + this.KekosId.GetHashCode();
                if (this.PaginationParameters != null)
                    hashCode = hashCode * 59 + this.PaginationParameters.GetHashCode();
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
