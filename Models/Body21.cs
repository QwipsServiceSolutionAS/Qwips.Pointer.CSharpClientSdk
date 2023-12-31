// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body21 : IParsable {
        /// <summary>Gets or Sets ActualDurationInMinutes</summary>
        public int? ActualDurationInMinutes { get; set; }
        /// <summary>Gets or Sets ActualEnd</summary>
        public DateTimeOffset? ActualEnd { get; set; }
        /// <summary>Gets or Sets ActualStart</summary>
        public DateTimeOffset? ActualStart { get; set; }
        /// <summary>Gets or Sets Invoiceable</summary>
        public bool? Invoiceable { get; set; }
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PriorityCode</summary>
        public Body21_plus_PriorityCodeEnum? PriorityCode { get; set; }
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>Gets or Sets ScheduledDurationInMinutes</summary>
        public int? ScheduledDurationInMinutes { get; set; }
        /// <summary>Gets or Sets ScheduledEnd</summary>
        public DateTimeOffset? ScheduledEnd { get; set; }
        /// <summary>Gets or Sets ScheduledStart</summary>
        public DateTimeOffset? ScheduledStart { get; set; }
        /// <summary>Gets or Sets ServiceCaseId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceCaseId { get; set; }
#nullable restore
#else
        public string ServiceCaseId { get; set; }
#endif
        /// <summary>Gets or Sets ServiceResourceId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceResourceId { get; set; }
#nullable restore
#else
        public string ServiceResourceId { get; set; }
#endif
        /// <summary>Gets or Sets Status</summary>
        public Body21_plus_StatusEnum? Status { get; set; }
        /// <summary>Gets or Sets Subject</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlActivityDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlActivityDescription { get; set; }
#nullable restore
#else
        public string UnsafeHtmlActivityDescription { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlResolutionDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlResolutionDescription { get; set; }
#nullable restore
#else
        public string UnsafeHtmlResolutionDescription { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body21 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body21();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actualDurationInMinutes", n => { ActualDurationInMinutes = n.GetIntValue(); } },
                {"actualEnd", n => { ActualEnd = n.GetDateTimeOffsetValue(); } },
                {"actualStart", n => { ActualStart = n.GetDateTimeOffsetValue(); } },
                {"invoiceable", n => { Invoiceable = n.GetBoolValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"priorityCode", n => { PriorityCode = n.GetEnumValue<Body21_plus_PriorityCodeEnum>(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scheduledDurationInMinutes", n => { ScheduledDurationInMinutes = n.GetIntValue(); } },
                {"scheduledEnd", n => { ScheduledEnd = n.GetDateTimeOffsetValue(); } },
                {"scheduledStart", n => { ScheduledStart = n.GetDateTimeOffsetValue(); } },
                {"serviceCaseId", n => { ServiceCaseId = n.GetStringValue(); } },
                {"serviceResourceId", n => { ServiceResourceId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<Body21_plus_StatusEnum>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"unsafeHtmlActivityDescription", n => { UnsafeHtmlActivityDescription = n.GetStringValue(); } },
                {"unsafeHtmlResolutionDescription", n => { UnsafeHtmlResolutionDescription = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("actualDurationInMinutes", ActualDurationInMinutes);
            writer.WriteDateTimeOffsetValue("actualEnd", ActualEnd);
            writer.WriteDateTimeOffsetValue("actualStart", ActualStart);
            writer.WriteBoolValue("invoiceable", Invoiceable);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("no", No);
            writer.WriteEnumValue<Body21_plus_PriorityCodeEnum>("priorityCode", PriorityCode);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteIntValue("scheduledDurationInMinutes", ScheduledDurationInMinutes);
            writer.WriteDateTimeOffsetValue("scheduledEnd", ScheduledEnd);
            writer.WriteDateTimeOffsetValue("scheduledStart", ScheduledStart);
            writer.WriteStringValue("serviceCaseId", ServiceCaseId);
            writer.WriteStringValue("serviceResourceId", ServiceResourceId);
            writer.WriteEnumValue<Body21_plus_StatusEnum>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("unsafeHtmlActivityDescription", UnsafeHtmlActivityDescription);
            writer.WriteStringValue("unsafeHtmlResolutionDescription", UnsafeHtmlResolutionDescription);
        }
    }
}
