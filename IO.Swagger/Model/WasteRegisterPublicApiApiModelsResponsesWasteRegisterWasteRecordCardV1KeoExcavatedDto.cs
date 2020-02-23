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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto" /> class.
        /// </summary>
        /// <param name="keoExcavatedId">Id wpisu Wydobyte odpady.</param>
        /// <param name="keoId">Id karty ewidencji odpadów.</param>
        /// <param name="wasteMassExcavated">Masa odpadów wydobytych ze składowiska [Mg].</param>
        /// <param name="excavatedDate">Data wydobycia.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto(Guid? keoExcavatedId = default(Guid?), Guid? keoId = default(Guid?), double? wasteMassExcavated = default(double?), DateTime? excavatedDate = default(DateTime?), string installationName = default(string))
        {
            this.KeoExcavatedId = keoExcavatedId;
            this.KeoId = keoId;
            this.WasteMassExcavated = wasteMassExcavated;
            this.ExcavatedDate = excavatedDate;
            this.InstallationName = installationName;
        }
        
        /// <summary>
        /// Id wpisu Wydobyte odpady
        /// </summary>
        /// <value>Id wpisu Wydobyte odpady</value>
        [DataMember(Name="keoExcavatedId", EmitDefaultValue=false)]
        public Guid? KeoExcavatedId { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto {\n");
            sb.Append("  KeoExcavatedId: ").Append(KeoExcavatedId).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeoExcavatedId == input.KeoExcavatedId ||
                    (this.KeoExcavatedId != null &&
                    this.KeoExcavatedId.Equals(input.KeoExcavatedId))
                ) && 
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
                if (this.KeoExcavatedId != null)
                    hashCode = hashCode * 59 + this.KeoExcavatedId.GetHashCode();
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
