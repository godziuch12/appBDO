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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest" /> class.
        /// </summary>
        /// <param name="keokId">keokId.</param>
        /// <param name="paginationParameters">Parametry paginacji.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest(Guid? keokId = default(Guid?), WasteRegisterPublicApiApiModelsCollectionsPaginationParameters paginationParameters = default(WasteRegisterPublicApiApiModelsCollectionsPaginationParameters))
        {
            this.KeokId = keokId;
            this.PaginationParameters = paginationParameters;
        }
        
        /// <summary>
        /// Gets or Sets KeokId
        /// </summary>
        [DataMember(Name="keokId", EmitDefaultValue=false)]
        public Guid? KeokId { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest {\n");
            sb.Append("  KeokId: ").Append(KeokId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokProcessedV1SearchKeokProcessedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeokId == input.KeokId ||
                    (this.KeokId != null &&
                    this.KeokId.Equals(input.KeokId))
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
                if (this.KeokId != null)
                    hashCode = hashCode * 59 + this.KeokId.GetHashCode();
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
