// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body123 : IParsable {
        /// <summary>Gets or Sets Files</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Xrmdbv1beta1tenantstenantIddriveItemscreateUploadFiles>? Files { get; set; }
#nullable restore
#else
        public List<Xrmdbv1beta1tenantstenantIddriveItemscreateUploadFiles> Files { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body123 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body123();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"files", n => { Files = n.GetCollectionOfObjectValues<Xrmdbv1beta1tenantstenantIddriveItemscreateUploadFiles>(Xrmdbv1beta1tenantstenantIddriveItemscreateUploadFiles.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Xrmdbv1beta1tenantstenantIddriveItemscreateUploadFiles>("files", Files);
        }
    }
}
