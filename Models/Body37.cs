// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body37 : IParsable {
        /// <summary>The _hashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2004Hashes? Hashes { get; set; }
#nullable restore
#else
        public InlineResponse2004Hashes Hashes { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets IsDefault</summary>
        public bool? IsDefault { get; set; }
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
        /// <summary>Gets or Sets PdfGenOptionsWidgetId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PdfGenOptionsWidgetId { get; set; }
#nullable restore
#else
        public string PdfGenOptionsWidgetId { get; set; }
#endif
        /// <summary>Gets or Sets TemplateCategory</summary>
        public Body37_plus_TemplateCategoryEnum? TemplateCategory { get; set; }
        /// <summary>Gets or Sets TemplateParts</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20038TemplateParts>? TemplateParts { get; set; }
#nullable restore
#else
        public List<InlineResponse20038TemplateParts> TemplateParts { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body37 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body37();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"pdfGenOptionsWidgetId", n => { PdfGenOptionsWidgetId = n.GetStringValue(); } },
                {"templateCategory", n => { TemplateCategory = n.GetEnumValue<Body37_plus_TemplateCategoryEnum>(); } },
                {"templateParts", n => { TemplateParts = n.GetCollectionOfObjectValues<InlineResponse20038TemplateParts>(InlineResponse20038TemplateParts.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteStringValue("pdfGenOptionsWidgetId", PdfGenOptionsWidgetId);
            writer.WriteEnumValue<Body37_plus_TemplateCategoryEnum>("templateCategory", TemplateCategory);
            writer.WriteCollectionOfObjectValues<InlineResponse20038TemplateParts>("templateParts", TemplateParts);
        }
    }
}
