// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20046 : IParsable {
        /// <summary>The aggs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2002Aggs? Aggs { get; set; }
#nullable restore
#else
        public InlineResponse2002Aggs Aggs { get; set; }
#endif
        /// <summary>Gets or Sets NextPageToken</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextPageToken { get; set; }
#nullable restore
#else
        public string NextPageToken { get; set; }
#endif
        /// <summary>Gets or Sets TenantIntegrations</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20046TenantIntegrations>? TenantIntegrations { get; set; }
#nullable restore
#else
        public List<InlineResponse20046TenantIntegrations> TenantIntegrations { get; set; }
#endif
        /// <summary>Gets or Sets TotalSize</summary>
        public double? TotalSize { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20046 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20046();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggs", n => { Aggs = n.GetObjectValue<InlineResponse2002Aggs>(InlineResponse2002Aggs.CreateFromDiscriminatorValue); } },
                {"nextPageToken", n => { NextPageToken = n.GetStringValue(); } },
                {"tenantIntegrations", n => { TenantIntegrations = n.GetCollectionOfObjectValues<InlineResponse20046TenantIntegrations>(InlineResponse20046TenantIntegrations.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalSize", n => { TotalSize = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InlineResponse2002Aggs>("aggs", Aggs);
            writer.WriteStringValue("nextPageToken", NextPageToken);
            writer.WriteCollectionOfObjectValues<InlineResponse20046TenantIntegrations>("tenantIntegrations", TenantIntegrations);
            writer.WriteDoubleValue("totalSize", TotalSize);
        }
    }
}
