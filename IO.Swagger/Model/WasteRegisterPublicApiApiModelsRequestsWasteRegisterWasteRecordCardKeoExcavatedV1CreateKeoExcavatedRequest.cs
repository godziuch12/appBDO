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
    /// WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest :  IEquatable<WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest" /> class.
        /// </summary>
        /// <param name="keoId">Id karty ewidencji odpadów.</param>
        /// <param name="wasteMassExcavated">Masa odpadów wydobytych ze składowiska [Mg].</param>
        /// <param name="excavatedDate">Data wydobycia.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest(Guid? keoId = default(Guid?), double? wasteMassExcavated = default(double?), DateTime? excavatedDate = default(DateTime?), string installationName = default(string))
        {
            this.KeoId = keoId;
            this.WasteMassExcavated = wasteMassExcavated;
            this.ExcavatedDate = excavatedDate;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Id karty ewidencji odpadów
        /// </summary>
        /// <value>Id karty ewidencji odpadów</value>
        [DataMember(Name="keoId", EmitDefaultValue=false)]
        public Guid? KeoId { get; set; }

        /// <summary>
        /// Masa odpadów wydobytych ze składowiska [Mg]
        /// </summary>
        /// <value>Masa odpadów wydobytych ze składowiska [Mg]</value>
        [DataMember(Name="wasteMassExcavated", EmitDefaultValue=false)]
        public double? WasteMassExcavated { get; set; }

        /// <summary>
        /// Data wydobycia
        /// </summary>
        /// <value>Data wydobycia</value>
        [DataMember(Name="excavatedDate", EmitDefaultValue=false)]
        public DateTime? ExcavatedDate { get; set; }

        /// <summary>
        /// Nazwa instalacji
        /// </summary>
        /// <value>Nazwa instalacji</value>
        [DataMember(Name="installationName", EmitDefaultValue=false)]
        public string InstallationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest {\n");
            sb.Append("  KeoId: ").Append(KeoId).Append("\n");
            sb.Append("  WasteMassExcavated: ").Append(WasteMassExcavated).Append("\n");
            sb.Append("  ExcavatedDate: ").Append(ExcavatedDate).Append("\n");
            sb.Append("  InstallationName: ").Append(InstallationName).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsRequestsWasteRegisterWasteRecordCardKeoExcavatedV1CreateKeoExcavatedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeoId == input.KeoId ||
                    (this.KeoId != null &&
                    this.KeoId.Equals(input.KeoId))
                ) && 
                (
                    this.WasteMassExcavated == input.WasteMassExcavated ||
                    (this.WasteMassExcavated != null &&
                    this.WasteMassExcavated.Equals(input.WasteMassExcavated))
                ) && 
                (
                    this.ExcavatedDate == input.ExcavatedDate ||
                    (this.ExcavatedDate != null &&
                    this.ExcavatedDate.Equals(input.ExcavatedDate))
                ) && 
                (
                    this.InstallationName == input.InstallationName ||
                    (this.InstallationName != null &&
                    this.InstallationName.Equals(input.InstallationName))
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
                if (this.KeoId != null)
                    hashCode = hashCode * 59 + this.KeoId.GetHashCode();
                if (this.WasteMassExcavated != null)
                    hashCode = hashCode * 59 + this.WasteMassExcavated.GetHashCode();
                if (this.ExcavatedDate != null)
                    hashCode = hashCode * 59 + this.ExcavatedDate.GetHashCode();
                if (this.InstallationName != null)
                    hashCode = hashCode * 59 + this.InstallationName.GetHashCode();
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
