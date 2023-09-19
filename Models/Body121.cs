// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body121 : IParsable {
        /// <summary>Gets or Sets Format</summary>
        public Body121_plus_FormatEnum? Format { get; set; }
        /// <summary>Gets or Sets Sheets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Xrmdbexportv1tenantstenantIdexportToExcelSheets>? Sheets { get; set; }
#nullable restore
#else
        public List<Xrmdbexportv1tenantstenantIdexportToExcelSheets> Sheets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body121 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body121();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"format", n => { Format = n.GetEnumValue<Body121_plus_FormatEnum>(); } },
                {"sheets", n => { Sheets = n.GetCollectionOfObjectValues<Xrmdbexportv1tenantstenantIdexportToExcelSheets>(Xrmdbexportv1tenantstenantIdexportToExcelSheets.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Body121_plus_FormatEnum>("format", Format);
            writer.WriteCollectionOfObjectValues<Xrmdbexportv1tenantstenantIdexportToExcelSheets>("sheets", Sheets);
        }
    }
}