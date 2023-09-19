// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes : IParsable {
        /// <summary>Gets or Sets BucketId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketId { get; set; }
#nullable restore
#else
        public string BucketId { get; set; }
#endif
        /// <summary>Gets or Sets EventTime</summary>
        public DateTimeOffset? EventTime { get; set; }
        /// <summary>Gets or Sets EventType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventType { get; set; }
#nullable restore
#else
        public string EventType { get; set; }
#endif
        /// <summary>Gets or Sets NotificationConfig</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationConfig { get; set; }
#nullable restore
#else
        public string NotificationConfig { get; set; }
#endif
        /// <summary>Gets or Sets ObjectGeneration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectGeneration { get; set; }
#nullable restore
#else
        public string ObjectGeneration { get; set; }
#endif
        /// <summary>Gets or Sets ObjectId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId { get; set; }
#nullable restore
#else
        public string ObjectId { get; set; }
#endif
        /// <summary>Gets or Sets PayloadFormat</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadFormat { get; set; }
#nullable restore
#else
        public string PayloadFormat { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bucketId", n => { BucketId = n.GetStringValue(); } },
                {"eventTime", n => { EventTime = n.GetDateTimeOffsetValue(); } },
                {"eventType", n => { EventType = n.GetStringValue(); } },
                {"notificationConfig", n => { NotificationConfig = n.GetStringValue(); } },
                {"objectGeneration", n => { ObjectGeneration = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"payloadFormat", n => { PayloadFormat = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteDateTimeOffsetValue("eventTime", EventTime);
            writer.WriteStringValue("eventType", EventType);
            writer.WriteStringValue("notificationConfig", NotificationConfig);
            writer.WriteStringValue("objectGeneration", ObjectGeneration);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("payloadFormat", PayloadFormat);
        }
    }
}