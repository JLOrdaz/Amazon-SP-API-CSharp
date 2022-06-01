/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    /// Description of a classification that can be used to get more fine-grained search results.
    /// </summary>
    [DataContract]
    public partial class ClassificationRefinement : IEquatable<ClassificationRefinement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationRefinement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ClassificationRefinement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationRefinement" /> class.
        /// </summary>
        /// <param name="numberOfResults">The estimated number of results that would still be returned if refinement key applied. (required).</param>
        /// <param name="displayName">Display name for the classification. (required).</param>
        /// <param name="classificationId">Identifier for the classification that can be used for search refinement purposes. (required).</param>
        public ClassificationRefinement(int? numberOfResults = default(int?), string displayName = default(string), string classificationId = default(string))
        {
            // to ensure "numberOfResults" is required (not null)
            if (numberOfResults == null)
            {
                throw new InvalidDataException("numberOfResults is a required property for ClassificationRefinement and cannot be null");
            }
            else
            {
                this.NumberOfResults = numberOfResults;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for ClassificationRefinement and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "classificationId" is required (not null)
            if (classificationId == null)
            {
                throw new InvalidDataException("classificationId is a required property for ClassificationRefinement and cannot be null");
            }
            else
            {
                this.ClassificationId = classificationId;
            }
        }

        /// <summary>
        /// The estimated number of results that would still be returned if refinement key applied.
        /// </summary>
        /// <value>The estimated number of results that would still be returned if refinement key applied.</value>
        [DataMember(Name = "numberOfResults", EmitDefaultValue = false)]
        public int? NumberOfResults { get; set; }

        /// <summary>
        /// Display name for the classification.
        /// </summary>
        /// <value>Display name for the classification.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Identifier for the classification that can be used for search refinement purposes.
        /// </summary>
        /// <value>Identifier for the classification that can be used for search refinement purposes.</value>
        [DataMember(Name = "classificationId", EmitDefaultValue = false)]
        public string ClassificationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassificationRefinement {\n");
            sb.Append("  NumberOfResults: ").Append(NumberOfResults).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
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
            return this.Equals(input as ClassificationRefinement);
        }

        /// <summary>
        /// Returns true if ClassificationRefinement instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassificationRefinement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassificationRefinement input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NumberOfResults == input.NumberOfResults ||
                    (this.NumberOfResults != null &&
                    this.NumberOfResults.Equals(input.NumberOfResults))
                ) &&
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    this.ClassificationId == input.ClassificationId ||
                    (this.ClassificationId != null &&
                    this.ClassificationId.Equals(input.ClassificationId))
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
                if (this.NumberOfResults != null)
                    hashCode = hashCode * 59 + this.NumberOfResults.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ClassificationId != null)
                    hashCode = hashCode * 59 + this.ClassificationId.GetHashCode();
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
