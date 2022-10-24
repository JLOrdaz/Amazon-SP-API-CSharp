/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Preparation instructions for shipping an item to Amazon&#39;s fulfillment network. For more information about preparing items for shipment to Amazon&#39;s fulfillment network, see the Seller Central Help for your marketplace.
    /// </summary>
    /// <value>Preparation instructions for shipping an item to Amazon&#39;s fulfillment network. For more information about preparing items for shipment to Amazon&#39;s fulfillment network, see the Seller Central Help for your marketplace.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PrepInstruction
    {

        /// <summary>
        /// Enum Polybagging for value: Polybagging
        /// </summary>
        [EnumMember(Value = "Polybagging")]
        Polybagging = 1,

        /// <summary>
        /// Enum BubbleWrapping for value: BubbleWrapping
        /// </summary>
        [EnumMember(Value = "BubbleWrapping")]
        BubbleWrapping = 2,

        /// <summary>
        /// Enum Taping for value: Taping
        /// </summary>
        [EnumMember(Value = "Taping")]
        Taping = 3,

        /// <summary>
        /// Enum BlackShrinkWrapping for value: BlackShrinkWrapping
        /// </summary>
        [EnumMember(Value = "BlackShrinkWrapping")]
        BlackShrinkWrapping = 4,

        /// <summary>
        /// Enum Labeling for value: Labeling
        /// </summary>
        [EnumMember(Value = "Labeling")]
        Labeling = 5,

        /// <summary>
        /// Enum HangGarment for value: HangGarment
        /// </summary>
        [EnumMember(Value = "HangGarment")]
        HangGarment = 6,

        /// <summary>
        /// Enum Boxing for value: Boxing
        /// </summary>
        [EnumMember(Value = "Boxing")]
        Boxing = 7,

        /// <summary>
        /// Enum SuffocationStickering for value: SuffocationStickering
        /// </summary>
        [EnumMember(Value = "SuffocationStickering")]
        SuffocationStickering = 8,

        /// <summary>
        /// Enum SetCreation for value: SetCreation
        /// </summary>
        [EnumMember(Value = "SetCreation")]
        SetCreation = 9
    }
}
