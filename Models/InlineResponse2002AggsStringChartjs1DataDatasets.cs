// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse2002AggsStringChartjs1DataDatasets : IParsable {
        /// <summary>Gets or Sets Data</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Data { get; set; }
#nullable restore
#else
        public List<string> Data { get; set; }
#endif
        /// <summary>Gets or Sets Fill</summary>
        public double? Fill { get; set; }
        /// <summary>Gets or Sets Label</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>Gets or Sets Order</summary>
        public double? Order { get; set; }
        /// <summary>Gets or Sets Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse2002AggsStringChartjs1DataDatasets CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse2002AggsStringChartjs1DataDatasets();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"fill", n => { Fill = n.GetDoubleValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"order", n => { Order = n.GetDoubleValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("data", Data);
            writer.WriteDoubleValue("fill", Fill);
            writer.WriteStringValue("label", Label);
            writer.WriteDoubleValue("order", Order);
            writer.WriteStringValue("type", Type);
        }
    }
}
