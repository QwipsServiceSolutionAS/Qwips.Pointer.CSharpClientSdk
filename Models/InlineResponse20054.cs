// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20054 : IParsable {
        /// <summary>Gets or Sets BaseUrl</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl { get; set; }
#nullable restore
#else
        public string BaseUrl { get; set; }
#endif
        /// <summary>Gets or Sets IsApiTokenSet</summary>
        public bool? IsApiTokenSet { get; set; }
        /// <summary>Gets or Sets IsEnabled</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20054 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20054();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"baseUrl", n => { BaseUrl = n.GetStringValue(); } },
                {"isApiTokenSet", n => { IsApiTokenSet = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("baseUrl", BaseUrl);
            writer.WriteBoolValue("isApiTokenSet", IsApiTokenSet);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
