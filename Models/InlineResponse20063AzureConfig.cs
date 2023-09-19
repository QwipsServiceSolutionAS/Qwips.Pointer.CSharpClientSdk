// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20063AzureConfig : IParsable {
        /// <summary>Gets or Sets AzureDriveId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureDriveId { get; set; }
#nullable restore
#else
        public string AzureDriveId { get; set; }
#endif
        /// <summary>Gets or Sets AzureDriveRootPath</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureDriveRootPath { get; set; }
#nullable restore
#else
        public string AzureDriveRootPath { get; set; }
#endif
        /// <summary>Gets or Sets ClientId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>Gets or Sets DirectoryId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryId { get; set; }
#nullable restore
#else
        public string DirectoryId { get; set; }
#endif
        /// <summary>Gets or Sets IsEnabled</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20063AzureConfig CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20063AzureConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureDriveId", n => { AzureDriveId = n.GetStringValue(); } },
                {"azureDriveRootPath", n => { AzureDriveRootPath = n.GetStringValue(); } },
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"directoryId", n => { DirectoryId = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureDriveId", AzureDriveId);
            writer.WriteStringValue("azureDriveRootPath", AzureDriveRootPath);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("directoryId", DirectoryId);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
