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
    /// WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull
    /// </summary>
    [DataContract]
    public partial class WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull :  IEquatable<WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull()
        {
        }
        
        /// <summary>
        /// Maksymalna liczba wyników na stronie
        /// </summary>
        /// <value>Maksymalna liczba wyników na stronie</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public long? PageSize { get; private set; }

        /// <summary>
        /// Numer strony
        /// </summary>
        /// <value>Numer strony</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public long? PageNumber { get; private set; }

        /// <summary>
        /// Całkowita liczba stron
        /// </summary>
        /// <value>Całkowita liczba stron</value>
        [DataMember(Name="totalPagesNumber", EmitDefaultValue=false)]
        public long? TotalPagesNumber { get; private set; }

        /// <summary>
        /// Całkowita liczba rekordów
        /// </summary>
        /// <value>Całkowita liczba rekordów</value>
        [DataMember(Name="totalResultNumber", EmitDefaultValue=false)]
        public long? TotalResultNumber { get; private set; }

        /// <summary>
        /// Flaga ustawiana na true, jeśli istnieje strona o numerze niższym niż bieżąca, false w przeciwnym wypadku
        /// </summary>
        /// <value>Flaga ustawiana na true, jeśli istnieje strona o numerze niższym niż bieżąca, false w przeciwnym wypadku</value>
        [DataMember(Name="hasPreviousPage", EmitDefaultValue=false)]
        public bool? HasPreviousPage { get; private set; }

        /// <summary>
        /// Flaga ustawiana na true, jeśli istnieje strona o numerze wyższym niż bieżąca, false w przeciwnym wypadku
        /// </summary>
        /// <value>Flaga ustawiana na true, jeśli istnieje strona o numerze wyższym niż bieżąca, false w przeciwnym wypadku</value>
        [DataMember(Name="hasNextPage", EmitDefaultValue=false)]
        public bool? HasNextPage { get; private set; }

        /// <summary>
        /// Lista wyników
        /// </summary>
        /// <value>Lista wyników</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDto> Items { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull {\n");
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
            return this.Equals(input as WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull);
        }

        /// <summary>
        /// Returns true if WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull instances are equal
        /// </summary>
        /// <param name="input">Instance of WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterWasteTransferCardV1KpoAsCarrierSearchResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull input)
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
