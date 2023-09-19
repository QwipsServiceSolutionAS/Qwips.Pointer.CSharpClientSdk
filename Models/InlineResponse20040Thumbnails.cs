// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20040Thumbnails : IParsable {
        /// <summary>Gets or Sets Height</summary>
        public int? Height { get; set; }
        /// <summary>Gets or Sets Key</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>Gets or Sets Tset</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tset { get; set; }
#nullable restore
#else
        public string Tset { get; set; }
#endif
        /// <summary>Gets or Sets Tsize</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tsize { get; set; }
#nullable restore
#else
        public string Tsize { get; set; }
#endif
        /// <summary>Gets or Sets Url</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>Gets or Sets Width</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20040Thumbnails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20040Thumbnails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"height", n => { Height = n.GetIntValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"tset", n => { Tset = n.GetStringValue(); } },
                {"tsize", n => { Tsize = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("tset", Tset);
            writer.WriteStringValue("tsize", Tsize);
            writer.WriteStringValue("url", Url);
            writer.WriteIntValue("width", Width);
        }
    }
}
