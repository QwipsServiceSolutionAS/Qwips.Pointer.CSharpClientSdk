// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body : IParsable {
        /// <summary>Gets or Sets ActivityIcon</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityIcon { get; set; }
#nullable restore
#else
        public string ActivityIcon { get; set; }
#endif
        /// <summary>Gets or Sets ActivityTag</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityTag { get; set; }
#nullable restore
#else
        public string ActivityTag { get; set; }
#endif
        /// <summary>Gets or Sets ActivityType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType { get; set; }
#nullable restore
#else
        public string ActivityType { get; set; }
#endif
        /// <summary>Gets or Sets Comment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets IsPinned</summary>
        public bool? IsPinned { get; set; }
        /// <summary>Gets or Sets Labels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Labels>? Labels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Labels> Labels { get; set; }
#endif
        /// <summary>Gets or Sets OccurredAt</summary>
        public DateTimeOffset? OccurredAt { get; set; }
        /// <summary>Gets or Sets PrimaryRelation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryRelation { get; set; }
#nullable restore
#else
        public string PrimaryRelation { get; set; }
#endif
        /// <summary>Gets or Sets RelatedTo</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RelatedTo { get; set; }
#nullable restore
#else
        public List<string> RelatedTo { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlBody</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlBody { get; set; }
#nullable restore
#else
        public string UnsafeHtmlBody { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlTitle</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlTitle { get; set; }
#nullable restore
#else
        public string UnsafeHtmlTitle { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityIcon", n => { ActivityIcon = n.GetStringValue(); } },
                {"activityTag", n => { ActivityTag = n.GetStringValue(); } },
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isPinned", n => { IsPinned = n.GetBoolValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<InlineResponse2002Labels>(InlineResponse2002Labels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"occurredAt", n => { OccurredAt = n.GetDateTimeOffsetValue(); } },
                {"primaryRelation", n => { PrimaryRelation = n.GetStringValue(); } },
                {"relatedTo", n => { RelatedTo = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"unsafeHtmlBody", n => { UnsafeHtmlBody = n.GetStringValue(); } },
                {"unsafeHtmlTitle", n => { UnsafeHtmlTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityIcon", ActivityIcon);
            writer.WriteStringValue("activityTag", ActivityTag);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteStringValue("comment", Comment);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isPinned", IsPinned);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Labels>("labels", Labels);
            writer.WriteDateTimeOffsetValue("occurredAt", OccurredAt);
            writer.WriteStringValue("primaryRelation", PrimaryRelation);
            writer.WriteCollectionOfPrimitiveValues<string>("relatedTo", RelatedTo);
            writer.WriteStringValue("unsafeHtmlBody", UnsafeHtmlBody);
            writer.WriteStringValue("unsafeHtmlTitle", UnsafeHtmlTitle);
        }
    }
}
