// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse2002AggsStringChartjs1Data : IParsable {
        /// <summary>Gets or Sets Datasets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002AggsStringChartjs1DataDatasets>? Datasets { get; set; }
#nullable restore
#else
        public List<InlineResponse2002AggsStringChartjs1DataDatasets> Datasets { get; set; }
#endif
        /// <summary>Gets or Sets Labels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Labels { get; set; }
#nullable restore
#else
        public List<string> Labels { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse2002AggsStringChartjs1Data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse2002AggsStringChartjs1Data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"datasets", n => { Datasets = n.GetCollectionOfObjectValues<InlineResponse2002AggsStringChartjs1DataDatasets>(InlineResponse2002AggsStringChartjs1DataDatasets.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<InlineResponse2002AggsStringChartjs1DataDatasets>("datasets", Datasets);
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
        }
    }
}
