// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse200PrimaryTenantMetaEnumOptions : IParsable {
        /// <summary>Gets or Sets Behaviors</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Behaviors { get; set; }
#nullable restore
#else
        public List<string> Behaviors { get; set; }
#endif
        /// <summary>Gets or Sets Label</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>Gets or Sets Value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse200PrimaryTenantMetaEnumOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse200PrimaryTenantMetaEnumOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"behaviors", n => { Behaviors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("behaviors", Behaviors);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("value", Value);
        }
    }
}
