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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest" /> class.
        /// </summary>
        /// <param name="kezsStockWasteMassGroupId">Id wpisu Wytworzone odpady.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest(Guid? kezsStockWasteMassGroupId = default(Guid?))
        {
            this.KezsStockWasteMassGroupId = kezsStockWasteMassGroupId;
        }
        
        /// <summary>
        /// Id wpisu Wytworzone odpady
        /// </summary>
        /// <value>Id wpisu Wytworzone odpady</value>
        [DataMember(Name="kezsStockWasteMassGroupId", EmitDefaultValue=false)]
        public Guid? KezsStockWasteMassGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest {\n");
            sb.Append("  KezsStockWasteMassGroupId: ").Append(KezsStockWasteMassGroupId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterElectronicWasteRecordCardV1DeleteKezsStockWasteMassGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KezsStockWasteMassGroupId == input.KezsStockWasteMassGroupId ||
                    (this.KezsStockWasteMassGroupId != null &&
                    this.KezsStockWasteMassGroupId.Equals(input.KezsStockWasteMassGroupId))
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
                if (this.KezsStockWasteMassGroupId != null)
                    hashCode = hashCode * 59 + this.KezsStockWasteMassGroupId.GetHashCode();
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
