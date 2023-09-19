// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20063 : IParsable {
        /// <summary>The azureConfig property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20063AzureConfig? AzureConfig { get; set; }
#nullable restore
#else
        public InlineResponse20063AzureConfig AzureConfig { get; set; }
#endif
        /// <summary>Gets or Sets AzureDrives</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20063AzureDrives>? AzureDrives { get; set; }
#nullable restore
#else
        public List<InlineResponse20063AzureDrives> AzureDrives { get; set; }
#endif
        /// <summary>Gets or Sets CreateAzureAccessTokenSuccess</summary>
        public bool? CreateAzureAccessTokenSuccess { get; set; }
        /// <summary>Gets or Sets ListRootDrivesSuccess</summary>
        public bool? ListRootDrivesSuccess { get; set; }
        /// <summary>Gets or Sets ListSiteDrivesSuccess</summary>
        public bool? ListSiteDrivesSuccess { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20063 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20063();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureConfig", n => { AzureConfig = n.GetObjectValue<InlineResponse20063AzureConfig>(InlineResponse20063AzureConfig.CreateFromDiscriminatorValue); } },
                {"azureDrives", n => { AzureDrives = n.GetCollectionOfObjectValues<InlineResponse20063AzureDrives>(InlineResponse20063AzureDrives.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createAzureAccessTokenSuccess", n => { CreateAzureAccessTokenSuccess = n.GetBoolValue(); } },
                {"listRootDrivesSuccess", n => { ListRootDrivesSuccess = n.GetBoolValue(); } },
                {"listSiteDrivesSuccess", n => { ListSiteDrivesSuccess = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InlineResponse20063AzureConfig>("azureConfig", AzureConfig);
            writer.WriteCollectionOfObjectValues<InlineResponse20063AzureDrives>("azureDrives", AzureDrives);
            writer.WriteBoolValue("createAzureAccessTokenSuccess", CreateAzureAccessTokenSuccess);
            writer.WriteBoolValue("listRootDrivesSuccess", ListRootDrivesSuccess);
            writer.WriteBoolValue("listSiteDrivesSuccess", ListSiteDrivesSuccess);
        }
    }
}
