// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Xrmdrivev1eventHandlersuserUploadPubSubV1Message : IParsable {
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes? Attributes { get; set; }
#nullable restore
#else
        public Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes Attributes { get; set; }
#endif
        /// <summary>Gets or Sets Data</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Data { get; set; }
#nullable restore
#else
        public string Data { get; set; }
#endif
        /// <summary>Gets or Sets MessageId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageId { get; set; }
#nullable restore
#else
        public string MessageId { get; set; }
#endif
        /// <summary>Gets or Sets PublishTime</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublishTime { get; set; }
#nullable restore
#else
        public string PublishTime { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Xrmdrivev1eventHandlersuserUploadPubSubV1Message CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Xrmdrivev1eventHandlersuserUploadPubSubV1Message();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributes", n => { Attributes = n.GetObjectValue<Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes>(Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes.CreateFromDiscriminatorValue); } },
                {"data", n => { Data = n.GetStringValue(); } },
                {"messageId", n => { MessageId = n.GetStringValue(); } },
                {"publishTime", n => { PublishTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Xrmdrivev1eventHandlersuserUploadPubSubV1MessageAttributes>("attributes", Attributes);
            writer.WriteStringValue("data", Data);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("publishTime", PublishTime);
        }
    }
}
