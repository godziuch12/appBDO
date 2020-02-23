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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest" /> class.
        /// </summary>
        /// <param name="keokTransferredId">keokTransferredId.</param>
        /// <param name="kpokId">Id Karty Przekazania Odpadów Komunalnych.</param>
        /// <param name="additionalInfo">Informacje dodatkowe.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest(Guid? keokTransferredId = default(Guid?), Guid? kpokId = default(Guid?), string additionalInfo = default(string))
        {
            this.KeokTransferredId = keokTransferredId;
            this.KpokId = kpokId;
            this.AdditionalInfo = additionalInfo;
        }
        
        /// <summary>
        /// Gets or Sets KeokTransferredId
        /// </summary>
        [DataMember(Name="keokTransferredId", EmitDefaultValue=false)]
        public Guid? KeokTransferredId { get; set; }

        /// <summary>
        /// Id Karty Przekazania Odpadów Komunalnych
        /// </summary>
        /// <value>Id Karty Przekazania Odpadów Komunalnych</value>
        [DataMember(Name="kpokId", EmitDefaultValue=false)]
        public Guid? KpokId { get; set; }

        /// <summary>
        /// Informacje dodatkowe
        /// </summary>
        /// <value>Informacje dodatkowe</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest {\n");
            sb.Append("  KeokTransferredId: ").Append(KeokTransferredId).Append("\n");
            sb.Append("  KpokId: ").Append(KpokId).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterMunicipalWasteRecordCardKeokTransferredV1UpdateKeokTransferredRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeokTransferredId == input.KeokTransferredId ||
                    (this.KeokTransferredId != null &&
                    this.KeokTransferredId.Equals(input.KeokTransferredId))
                ) && 
                (
                    this.KpokId == input.KpokId ||
                    (this.KpokId != null &&
                    this.KpokId.Equals(input.KpokId))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
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
                if (this.KeokTransferredId != null)
                    hashCode = hashCode * 59 + this.KeokTransferredId.GetHashCode();
                if (this.KpokId != null)
                    hashCode = hashCode * 59 + this.KpokId.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
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
