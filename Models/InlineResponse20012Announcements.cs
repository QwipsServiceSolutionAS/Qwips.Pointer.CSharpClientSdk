// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20012Announcements : IParsable {
        /// <summary>Gets or Sets CreatedAt</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The _hashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2004Hashes? Hashes { get; set; }
#nullable restore
#else
        public InlineResponse2004Hashes Hashes { get; set; }
#endif
        /// <summary>Gets or Sets Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PublishedFrom</summary>
        public DateTimeOffset? PublishedFrom { get; set; }
        /// <summary>Gets or Sets PublishedTo</summary>
        public DateTimeOffset? PublishedTo { get; set; }
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>Gets or Sets Score</summary>
        public double? Score { get; set; }
        /// <summary>Gets or Sets TenantId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlDescription { get; set; }
#nullable restore
#else
        public string UnsafeHtmlDescription { get; set; }
#endif
        /// <summary>Gets or Sets UpdatedAt</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20012Announcements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20012Announcements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"publishedFrom", n => { PublishedFrom = n.GetDateTimeOffsetValue(); } },
                {"publishedTo", n => { PublishedTo = n.GetDateTimeOffsetValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"_score", n => { Score = n.GetDoubleValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"unsafeHtmlDescription", n => { UnsafeHtmlDescription = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteDateTimeOffsetValue("publishedFrom", PublishedFrom);
            writer.WriteDateTimeOffsetValue("publishedTo", PublishedTo);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteDoubleValue("_score", Score);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("unsafeHtmlDescription", UnsafeHtmlDescription);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
