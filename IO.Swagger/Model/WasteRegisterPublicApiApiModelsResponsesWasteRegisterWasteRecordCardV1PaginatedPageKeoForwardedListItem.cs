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
    /// WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem :  IEquatable<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem" /> class.
        /// </summary>
        /// <param name="pageSize">Liczba wyników na stronie.</param>
        /// <param name="pageNumber">Numer strony.</param>
        /// <param name="totalPagesNumber">Liczba wszystkich stron.</param>
        /// <param name="totalResultNumber">Liczba wszystkich wyników.</param>
        /// <param name="hasPreviousPage">Ma poprzednią stronę.</param>
        /// <param name="hasNextPage">Ma następną stronę.</param>
        /// <param name="items">Lista wyników.</param>
        public WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem(long? pageSize = default(long?), long? pageNumber = default(long?), long? totalPagesNumber = default(long?), long? totalResultNumber = default(long?), bool? hasPreviousPage = default(bool?), bool? hasNextPage = default(bool?), List<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedListItem> items = default(List<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedListItem>))
        {
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.TotalPagesNumber = totalPagesNumber;
            this.TotalResultNumber = totalResultNumber;
            this.HasPreviousPage = hasPreviousPage;
            this.HasNextPage = hasNextPage;
            this.Items = items;
        }
        
        /// <summary>
        /// Liczba wyników na stronie
        /// </summary>
        /// <value>Liczba wyników na stronie</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Numer strony
        /// </summary>
        /// <value>Numer strony</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// Liczba wszystkich stron
        /// </summary>
        /// <value>Liczba wszystkich stron</value>
        [DataMember(Name="totalPagesNumber", EmitDefaultValue=false)]
        public long? TotalPagesNumber { get; set; }

        /// <summary>
        /// Liczba wszystkich wyników
        /// </summary>
        /// <value>Liczba wszystkich wyników</value>
        [DataMember(Name="totalResultNumber", EmitDefaultValue=false)]
        public long? TotalResultNumber { get; set; }

        /// <summary>
        /// Ma poprzednią stronę
        /// </summary>
        /// <value>Ma poprzednią stronę</value>
        [DataMember(Name="hasPreviousPage", EmitDefaultValue=false)]
        public bool? HasPreviousPage { get; set; }

        /// <summary>
        /// Ma następną stronę
        /// </summary>
        /// <value>Ma następną stronę</value>
        [DataMember(Name="hasNextPage", EmitDefaultValue=false)]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// Lista wyników
        /// </summary>
        /// <value>Lista wyników</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1KeoForwardedListItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  TotalPagesNumber: ").Append(TotalPagesNumber).Append("\n");
            sb.Append("  TotalResultNumber: ").Append(TotalResultNumber).Append("\n");
            sb.Append("  HasPreviousPage: ").Append(HasPreviousPage).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteRecordCardV1PaginatedPageKeoForwardedListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.TotalPagesNumber == input.TotalPagesNumber ||
                    (this.TotalPagesNumber != null &&
                    this.TotalPagesNumber.Equals(input.TotalPagesNumber))
                ) && 
                (
                    this.TotalResultNumber == input.TotalResultNumber ||
                    (this.TotalResultNumber != null &&
                    this.TotalResultNumber.Equals(input.TotalResultNumber))
                ) && 
                (
                    this.HasPreviousPage == input.HasPreviousPage ||
                    (this.HasPreviousPage != null &&
                    this.HasPreviousPage.Equals(input.HasPreviousPage))
                ) && 
                (
                    this.HasNextPage == input.HasNextPage ||
                    (this.HasNextPage != null &&
                    this.HasNextPage.Equals(input.HasNextPage))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.TotalPagesNumber != null)
                    hashCode = hashCode * 59 + this.TotalPagesNumber.GetHashCode();
                if (this.TotalResultNumber != null)
                    hashCode = hashCode * 59 + this.TotalResultNumber.GetHashCode();
                if (this.HasPreviousPage != null)
                    hashCode = hashCode * 59 + this.HasPreviousPage.GetHashCode();
                if (this.HasNextPage != null)
                    hashCode = hashCode * 59 + this.HasNextPage.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
