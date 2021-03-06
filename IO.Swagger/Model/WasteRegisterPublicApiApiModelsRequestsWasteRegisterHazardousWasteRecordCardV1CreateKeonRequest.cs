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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest" /> class.
        /// </summary>
        /// <param name="wasteCodeId">Id kodu odpadu.</param>
        /// <param name="wasteCodeExtended">Kod ex.</param>
        /// <param name="wasteCodeExtendedDescription">Rodzaj odpadu ex.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest(int? wasteCodeId = default(int?), bool? wasteCodeExtended = default(bool?), string wasteCodeExtendedDescription = default(string))
        {
            this.WasteCodeId = wasteCodeId;
            this.WasteCodeExtended = wasteCodeExtended;
            this.WasteCodeExtendedDescription = wasteCodeExtendedDescription;
        }
        
        /// <summary>
        /// Id kodu odpadu
        /// </summary>
        /// <value>Id kodu odpadu</value>
        [DataMember(Name="wasteCodeId", EmitDefaultValue=false)]
        public int? WasteCodeId { get; set; }

        /// <summary>
        /// Kod ex
        /// </summary>
        /// <value>Kod ex</value>
        [DataMember(Name="wasteCodeExtended", EmitDefaultValue=false)]
        public bool? WasteCodeExtended { get; set; }

        /// <summary>
        /// Rodzaj odpadu ex
        /// </summary>
        /// <value>Rodzaj odpadu ex</value>
        [DataMember(Name="wasteCodeExtendedDescription", EmitDefaultValue=false)]
        public string WasteCodeExtendedDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest {\n");
            sb.Append("  WasteCodeId: ").Append(WasteCodeId).Append("\n");
            sb.Append("  WasteCodeExtended: ").Append(WasteCodeExtended).Append("\n");
            sb.Append("  WasteCodeExtendedDescription: ").Append(WasteCodeExtendedDescription).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WasteCodeId == input.WasteCodeId ||
                    (this.WasteCodeId != null &&
                    this.WasteCodeId.Equals(input.WasteCodeId))
                ) && 
                (
                    this.WasteCodeExtended == input.WasteCodeExtended ||
                    (this.WasteCodeExtended != null &&
                    this.WasteCodeExtended.Equals(input.WasteCodeExtended))
                ) && 
                (
                    this.WasteCodeExtendedDescription == input.WasteCodeExtendedDescription ||
                    (this.WasteCodeExtendedDescription != null &&
                    this.WasteCodeExtendedDescription.Equals(input.WasteCodeExtendedDescription))
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
                if (this.WasteCodeId != null)
                    hashCode = hashCode * 59 + this.WasteCodeId.GetHashCode();
                if (this.WasteCodeExtended != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtended.GetHashCode();
                if (this.WasteCodeExtendedDescription != null)
                    hashCode = hashCode * 59 + this.WasteCodeExtendedDescription.GetHashCode();
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
