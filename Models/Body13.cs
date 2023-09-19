// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body13 : IParsable {
        /// <summary>Gets or Sets AvailableQuantity</summary>
        public double? AvailableQuantity { get; set; }
        /// <summary>Gets or Sets Gtin</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gtin { get; set; }
#nullable restore
#else
        public string Gtin { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets IsBlocked</summary>
        public bool? IsBlocked { get; set; }
        /// <summary>Gets or Sets IsSoftBlocked</summary>
        public bool? IsSoftBlocked { get; set; }
        /// <summary>Gets or Sets IsStockItem</summary>
        public bool? IsStockItem { get; set; }
        /// <summary>Gets or Sets Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PurchasePrice</summary>
        public double? PurchasePrice { get; set; }
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>Gets or Sets SellingPrice</summary>
        public double? SellingPrice { get; set; }
        /// <summary>Gets or Sets SellingUnit</summary>
        public Body13_plus_SellingUnitEnum? SellingUnit { get; set; }
        /// <summary>Gets or Sets Sku</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sku { get; set; }
#nullable restore
#else
        public string Sku { get; set; }
#endif
        /// <summary>Gets or Sets VatGroupId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VatGroupId { get; set; }
#nullable restore
#else
        public string VatGroupId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body13 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body13();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availableQuantity", n => { AvailableQuantity = n.GetDoubleValue(); } },
                {"gtin", n => { Gtin = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isBlocked", n => { IsBlocked = n.GetBoolValue(); } },
                {"isSoftBlocked", n => { IsSoftBlocked = n.GetBoolValue(); } },
                {"isStockItem", n => { IsStockItem = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"purchasePrice", n => { PurchasePrice = n.GetDoubleValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sellingPrice", n => { SellingPrice = n.GetDoubleValue(); } },
                {"sellingUnit", n => { SellingUnit = n.GetEnumValue<Body13_plus_SellingUnitEnum>(); } },
                {"sku", n => { Sku = n.GetStringValue(); } },
                {"vatGroupId", n => { VatGroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("availableQuantity", AvailableQuantity);
            writer.WriteStringValue("gtin", Gtin);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isBlocked", IsBlocked);
            writer.WriteBoolValue("isSoftBlocked", IsSoftBlocked);
            writer.WriteBoolValue("isStockItem", IsStockItem);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteDoubleValue("purchasePrice", PurchasePrice);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteDoubleValue("sellingPrice", SellingPrice);
            writer.WriteEnumValue<Body13_plus_SellingUnitEnum>("sellingUnit", SellingUnit);
            writer.WriteStringValue("sku", Sku);
            writer.WriteStringValue("vatGroupId", VatGroupId);
        }
    }
}
