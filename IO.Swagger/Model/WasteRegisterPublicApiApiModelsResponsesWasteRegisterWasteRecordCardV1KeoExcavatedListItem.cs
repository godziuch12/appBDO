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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem" /> class.
        /// </summary>
        /// <param name="keoExcavatedId">Id wpisu Wydobyte odpady.</param>
        /// <param name="wasteMassExcavated">Masa odpadów wydobytych ze składowiska [Mg].</param>
        /// <param name="createdByUser">Utworzone przez użytkownika.</param>
        /// <param name="excavatedDate">Data wydobycia.</param>
        /// <param name="installationName">Nazwa instalacji.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem(Guid? keoExcavatedId = default(Guid?), double? wasteMassExcavated = default(double?), string createdByUser = default(string), DateTime? excavatedDate = default(DateTime?), string installationName = default(string))
        {
            this.KeoExcavatedId = keoExcavatedId;
            this.WasteMassExcavated = wasteMassExcavated;
            this.CreatedByUser = createdByUser;
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
        /// Masa odpadów wydobytych ze składowiska [Mg]
        /// </summary>
        /// <value>Masa odpadów wydobytych ze składowiska [Mg]</value>
        [DataMember(Name="wasteMassExcavated", EmitDefaultValue=false)]
        public double? WasteMassExcavated { get; set; }

        /// <summary>
        /// Utworzone przez użytkownika
        /// </summary>
        /// <value>Utworzone przez użytkownika</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

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
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem {\n");
            sb.Append("  KeoExcavatedId: ").Append(KeoExcavatedId).Append("\n");
            sb.Append("  WasteMassExcavated: ").Append(WasteMassExcavated).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoExcavatedListItem input)
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
                    this.WasteMassExcavated == input.WasteMassExcavated ||
                    (this.WasteMassExcavated != null &&
                    this.WasteMassExcavated.Equals(input.WasteMassExcavated))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
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
                if (this.WasteMassExcavated != null)
                    hashCode = hashCode * 59 + this.WasteMassExcavated.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
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
