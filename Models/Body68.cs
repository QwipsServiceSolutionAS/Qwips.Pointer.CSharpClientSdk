// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body68 : IParsable {
        /// <summary>Gets or Sets ActivityId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityId { get; set; }
#nullable restore
#else
        public string ActivityId { get; set; }
#endif
        /// <summary>Gets or Sets Body</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Gets or Sets ExpiresAt</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The _hashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2004Hashes? Hashes { get; set; }
#nullable restore
#else
        public InlineResponse2004Hashes Hashes { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets IsRead</summary>
        public bool? IsRead { get; set; }
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PrimaryRelation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryRelation { get; set; }
#nullable restore
#else
        public string PrimaryRelation { get; set; }
#endif
        /// <summary>Gets or Sets TenantUserId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantUserId { get; set; }
#nullable restore
#else
        public string TenantUserId { get; set; }
#endif
        /// <summary>Gets or Sets Title</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body68 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body68();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityId", n => { ActivityId = n.GetStringValue(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"expiresAt", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isRead", n => { IsRead = n.GetBoolValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"primaryRelation", n => { PrimaryRelation = n.GetStringValue(); } },
                {"tenantUserId", n => { TenantUserId = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityId", ActivityId);
            writer.WriteStringValue("body", Body);
            writer.WriteDateTimeOffsetValue("expiresAt", ExpiresAt);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteStringValue("no", No);
            writer.WriteStringValue("primaryRelation", PrimaryRelation);
            writer.WriteStringValue("tenantUserId", TenantUserId);
            writer.WriteStringValue("title", Title);
        }
    }
}