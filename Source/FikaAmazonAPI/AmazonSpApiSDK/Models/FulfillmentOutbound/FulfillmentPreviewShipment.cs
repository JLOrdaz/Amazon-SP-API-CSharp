/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Delivery and item information for a shipment in a fulfillment order preview.
    /// </summary>
    [DataContract]
    public partial class FulfillmentPreviewShipment : IEquatable<FulfillmentPreviewShipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreviewShipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FulfillmentPreviewShipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreviewShipment" /> class.
        /// </summary>
        /// <param name="EarliestShipDate">The earliest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format. (required).</param>
        /// <param name="LatestShipDate">The latest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format. (required).</param>
        /// <param name="EarliestArrivalDate">The earliest date that the shipment is expected to arrive at its destination. (required).</param>
        /// <param name="LatestArrivalDate">The latest date that the shipment is expected to arrive at its destination, in ISO 8601 date time format. (required).</param>
        /// <param name="FulfillmentPreviewItems">Information about the items in the shipment. (required).</param>
        public FulfillmentPreviewShipment(DateTime? EarliestShipDate = default(DateTime?), DateTime? LatestShipDate = default(DateTime?), DateTime? EarliestArrivalDate = default(DateTime?), DateTime? LatestArrivalDate = default(DateTime?), FulfillmentPreviewItemList FulfillmentPreviewItems = default(FulfillmentPreviewItemList))
        {
            // to ensure "EarliestShipDate" is required (not null)
            if (EarliestShipDate == null)
            {
                throw new InvalidDataException("EarliestShipDate is a required property for FulfillmentPreviewShipment and cannot be null");
            }
            else
            {
                this.EarliestShipDateTime = EarliestShipDate.Value;
            }
            // to ensure "LatestShipDate" is required (not null)
            if (LatestShipDate == null)
            {
                throw new InvalidDataException("LatestShipDate is a required property for FulfillmentPreviewShipment and cannot be null");
            }
            else
            {
                this.LatestShipDateTime = LatestShipDate.Value;
            }
            // to ensure "EarliestArrivalDate" is required (not null)
            if (EarliestArrivalDate == null)
            {
                throw new InvalidDataException("EarliestArrivalDate is a required property for FulfillmentPreviewShipment and cannot be null");
            }
            else
            {
                this.EarliestArrivalDateTime = EarliestArrivalDate.Value;
            }
            // to ensure "LatestArrivalDate" is required (not null)
            if (LatestArrivalDate == null)
            {
                throw new InvalidDataException("LatestArrivalDate is a required property for FulfillmentPreviewShipment and cannot be null");
            }
            else
            {
                this.LatestArrivalDateTime = LatestArrivalDate.Value;
            }
            // to ensure "FulfillmentPreviewItems" is required (not null)
            if (FulfillmentPreviewItems == null)
            {
                throw new InvalidDataException("FulfillmentPreviewItems is a required property for FulfillmentPreviewShipment and cannot be null");
            }
            else
            {
                this.FulfillmentPreviewItems = FulfillmentPreviewItems;
            }
        }
        [Obsolete("Timestamp is no longer used, use the other constructor")]
        [EditorBrowsable(EditorBrowsableState.Never)]
		public FulfillmentPreviewShipment(Timestamp EarliestShipDate = default(Timestamp), Timestamp LatestShipDate = default(Timestamp), Timestamp EarliestArrivalDate = default(Timestamp), Timestamp LatestArrivalDate = default(Timestamp), FulfillmentPreviewItemList FulfillmentPreviewItems = default(FulfillmentPreviewItemList)) 
            : this(DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, FulfillmentPreviewItems) { }

		/// <summary>
		/// The earliest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format.
		/// </summary>
		/// <value>The earliest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format.</value>
		[DataMember(Name = "EarliestShipDate", EmitDefaultValue = false)]
        public DateTime EarliestShipDateTime { get; set; }
		[Obsolete("Use EarliestShipDateTime instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Timestamp EarliestShipDate { get; set; }

		/// <summary>
		/// The latest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format.
		/// </summary>
		/// <value>The latest date that the shipment is expected to be sent from the fulfillment center, in ISO 8601 date time format.</value>
		[DataMember(Name = "LatestShipDate", EmitDefaultValue = false)]
        public DateTime LatestShipDateTime { get; set; }
		[Obsolete("Use LatestShipDateTime instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Timestamp LatestShipDate { get; set; }

		/// <summary>
		/// The earliest date that the shipment is expected to arrive at its destination.
		/// </summary>
		/// <value>The earliest date that the shipment is expected to arrive at its destination.</value>
		[DataMember(Name = "EarliestArrivalDate", EmitDefaultValue = false)]
        public DateTime EarliestArrivalDateTime { get; set; }
		[Obsolete("Use EarliestArrivalDateTime instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Timestamp EarliestArrivalDate { get; set; }

		/// <summary>
		/// The latest date that the shipment is expected to arrive at its destination, in ISO 8601 date time format.
		/// </summary>
		/// <value>The latest date that the shipment is expected to arrive at its destination, in ISO 8601 date time format.</value>
		[DataMember(Name = "LatestArrivalDate", EmitDefaultValue = false)]
        public DateTime LatestArrivalDateTime { get; set; }
		[Obsolete("Use LatestArrivalDateTime instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Timestamp LatestArrivalDate { get; set; }

		/// <summary>
		/// Information about the items in the shipment.
		/// </summary>
		/// <value>Information about the items in the shipment.</value>
		[DataMember(Name = "FulfillmentPreviewItems", EmitDefaultValue = false)]
        public FulfillmentPreviewItemList FulfillmentPreviewItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPreviewShipment {\n");
            sb.Append("  EarliestShipDateTime: ").Append(EarliestShipDateTime).Append("\n");
            sb.Append("  LatestShipDateTime: ").Append(LatestShipDateTime).Append("\n");
            sb.Append("  EarliestArrivalDateTime: ").Append(EarliestArrivalDateTime).Append("\n");
            sb.Append("  LatestArrivalDateTime: ").Append(LatestArrivalDateTime).Append("\n");
            sb.Append("  FulfillmentPreviewItems: ").Append(FulfillmentPreviewItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as FulfillmentPreviewShipment);
        }

        /// <summary>
        /// Returns true if FulfillmentPreviewShipment instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentPreviewShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPreviewShipment input)
        {
            if (input == null)
                return false;

            return
                (
                    this.EarliestShipDateTime == input.EarliestShipDateTime ||
                    (this.EarliestShipDateTime.Equals(input.EarliestShipDateTime))
                ) &&
                (
                    this.LatestShipDateTime == input.LatestShipDateTime ||
                    (this.LatestShipDateTime.Equals(input.LatestShipDateTime))
                ) &&
                (
                    this.EarliestArrivalDateTime == input.EarliestArrivalDateTime ||
                    (this.EarliestArrivalDateTime.Equals(input.EarliestArrivalDateTime))
                ) &&
                (
                    this.LatestArrivalDateTime == input.LatestArrivalDateTime ||
                    (this.LatestArrivalDateTime.Equals(input.LatestArrivalDateTime))
                ) &&
                (
                    this.FulfillmentPreviewItems == input.FulfillmentPreviewItems ||
                    (this.FulfillmentPreviewItems != null &&
                    this.FulfillmentPreviewItems.Equals(input.FulfillmentPreviewItems))
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
                if (this.EarliestShipDate != null)
                    hashCode = hashCode * 59 + this.EarliestShipDate.GetHashCode();
                if (this.LatestShipDate != null)
                    hashCode = hashCode * 59 + this.LatestShipDate.GetHashCode();
                if (this.EarliestArrivalDate != null)
                    hashCode = hashCode * 59 + this.EarliestArrivalDate.GetHashCode();
                if (this.LatestArrivalDate != null)
                    hashCode = hashCode * 59 + this.LatestArrivalDate.GetHashCode();
                if (this.FulfillmentPreviewItems != null)
                    hashCode = hashCode * 59 + this.FulfillmentPreviewItems.GetHashCode();
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
