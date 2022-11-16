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
    /// The currency code.
    /// </summary>
    /// <value>The currency code.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum CurrencyCode
    {

        /// <summary>
        /// Enum USD for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD = 1,

        /// <summary>
        /// Enum GBP for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]

        GBP = 2,
        /// <summary>
        /// Enum EUR for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR = 3,

        [EnumMember(Value = "CAD")]
        CAD = 4,

        [EnumMember(Value = "CAD")]
        JPY,
        [EnumMember(Value = "CNY")]
        CNY,
        [EnumMember(Value = "INR")]
        INR,
        [EnumMember(Value = "MXN")]
        MXN,
        [EnumMember(Value = "BRL")]
        BRL,
        [EnumMember(Value = "AUD")]
        AUD,
        [EnumMember(Value = "TRY")]
        TRY,
        [EnumMember(Value = "SGD")]
        SGD,
        [EnumMember(Value = "SEK")]
        SEK,
        [EnumMember(Value = "PLN")]
        PLN,
        [EnumMember(Value = "AED")]
        AED,
        [EnumMember(Value = "SAR")]
        SAR,
        [EnumMember(Value = "EGP")]
        EGP,
    }

}
