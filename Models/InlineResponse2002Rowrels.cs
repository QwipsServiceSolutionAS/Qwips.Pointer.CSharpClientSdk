// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse2002Rowrels : IParsable {
        /// <summary>Gets or Sets Erid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Erid { get; set; }
#nullable restore
#else
        public string Erid { get; set; }
#endif
        /// <summary>Gets or Sets Etyp</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etyp { get; set; }
#nullable restore
#else
        public string Etyp { get; set; }
#endif
        /// <summary>Gets or Sets Rtyp</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rtyp { get; set; }
#nullable restore
#else
        public string Rtyp { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse2002Rowrels CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse2002Rowrels();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"erid", n => { Erid = n.GetStringValue(); } },
                {"etyp", n => { Etyp = n.GetStringValue(); } },
                {"rtyp", n => { Rtyp = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("erid", Erid);
            writer.WriteStringValue("etyp", Etyp);
            writer.WriteStringValue("rtyp", Rtyp);
        }
    }
}
