// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts : IParsable {
        /// <summary>Gets or Sets Format</summary>
        public Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts_plus_FormatEnum? Format { get; set; }
        /// <summary>Gets or Sets OutputFileName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputFileName { get; set; }
#nullable restore
#else
        public string OutputFileName { get; set; }
#endif
        /// <summary>Gets or Sets Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Template { get; set; }
#nullable restore
#else
        public string Template { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"format", n => { Format = n.GetEnumValue<Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts_plus_FormatEnum>(); } },
                {"outputFileName", n => { OutputFileName = n.GetStringValue(); } },
                {"template", n => { Template = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Xrmpdfgenv1beta1tenantstenantIdgotenberghtml1TemplateParts_plus_FormatEnum>("format", Format);
            writer.WriteStringValue("outputFileName", OutputFileName);
            writer.WriteStringValue("template", Template);
        }
    }
}
