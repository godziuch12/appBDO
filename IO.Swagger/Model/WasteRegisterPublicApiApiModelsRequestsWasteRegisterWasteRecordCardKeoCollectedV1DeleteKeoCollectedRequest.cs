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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest" /> class.
        /// </summary>
        /// <param name="keoCollectedId">Id wpisu o statusie \&quot;Przyjęte\&quot;.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest(Guid? keoCollectedId = default(Guid?))
        {
            this.KeoCollectedId = keoCollectedId;
        }
        
        /// <summary>
        /// Id wpisu o statusie \&quot;Przyjęte\&quot;
        /// </summary>
        /// <value>Id wpisu o statusie \&quot;Przyjęte\&quot;</value>
        [DataMember(Name="keoCollectedId", EmitDefaultValue=false)]
        public Guid? KeoCollectedId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest {\n");
            sb.Append("  KeoCollectedId: ").Append(KeoCollectedId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoCollectedV1DeleteKeoCollectedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeoCollectedId == input.KeoCollectedId ||
                    (this.KeoCollectedId != null &&
                    this.KeoCollectedId.Equals(input.KeoCollectedId))
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
                if (this.KeoCollectedId != null)
                    hashCode = hashCode * 59 + this.KeoCollectedId.GetHashCode();
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
