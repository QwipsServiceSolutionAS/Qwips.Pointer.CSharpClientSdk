// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body38 : IParsable {
        /// <summary>The _hashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2004Hashes? Hashes { get; set; }
#nullable restore
#else
        public InlineResponse2004Hashes Hashes { get; set; }
#endif
        /// <summary>Gets or Sets IsActive</summary>
        public bool? IsActive { get; set; }
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets MinimumQuantity</summary>
        public double? MinimumQuantity { get; set; }
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PriceType</summary>
        public Body38_plus_PriceTypeEnum? PriceType { get; set; }
        /// <summary>Gets or Sets ProductId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductId { get; set; }
#nullable restore
#else
        public string ProductId { get; set; }
#endif
        /// <summary>Gets or Sets SimplePriceListId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SimplePriceListId { get; set; }
#nullable restore
#else
        public string SimplePriceListId { get; set; }
#endif
        /// <summary>Gets or Sets Value</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body38 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body38();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"minimumQuantity", n => { MinimumQuantity = n.GetDoubleValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"priceType", n => { PriceType = n.GetEnumValue<Body38_plus_PriceTypeEnum>(); } },
                {"productId", n => { ProductId = n.GetStringValue(); } },
                {"simplePriceListId", n => { SimplePriceListId = n.GetStringValue(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteDoubleValue("minimumQuantity", MinimumQuantity);
            writer.WriteStringValue("no", No);
            writer.WriteEnumValue<Body38_plus_PriceTypeEnum>("priceType", PriceType);
            writer.WriteStringValue("productId", ProductId);
            writer.WriteStringValue("simplePriceListId", SimplePriceListId);
            writer.WriteDoubleValue("value", Value);
        }
    }
}
