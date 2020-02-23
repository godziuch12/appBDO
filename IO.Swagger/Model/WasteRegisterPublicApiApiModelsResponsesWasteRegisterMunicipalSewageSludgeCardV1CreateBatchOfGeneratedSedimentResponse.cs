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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse" /> class.
        /// </summary>
        /// <param name="batchOfGeneratedSedimentId">Id wpisu wytworzone osady.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse(Guid? batchOfGeneratedSedimentId = default(Guid?))
        {
            this.BatchOfGeneratedSedimentId = batchOfGeneratedSedimentId;
        }
        
        /// <summary>
        /// Id wpisu wytworzone osady
        /// </summary>
        /// <value>Id wpisu wytworzone osady</value>
        [DataMember(Name="batchOfGeneratedSedimentId", EmitDefaultValue=false)]
        public Guid? BatchOfGeneratedSedimentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse {\n");
            sb.Append("  BatchOfGeneratedSedimentId: ").Append(BatchOfGeneratedSedimentId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterMunicipalSewageSludgeCardV1CreateBatchOfGeneratedSedimentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchOfGeneratedSedimentId == input.BatchOfGeneratedSedimentId ||
                    (this.BatchOfGeneratedSedimentId != null &&
                    this.BatchOfGeneratedSedimentId.Equals(input.BatchOfGeneratedSedimentId))
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
                if (this.BatchOfGeneratedSedimentId != null)
                    hashCode = hashCode * 59 + this.BatchOfGeneratedSedimentId.GetHashCode();
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
