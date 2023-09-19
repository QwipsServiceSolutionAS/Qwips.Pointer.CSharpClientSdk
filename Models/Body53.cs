// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body53 : IParsable {
        /// <summary>Gets or Sets BudgetId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>Gets or Sets GoalEarnings</summary>
        public double? GoalEarnings { get; set; }
        /// <summary>Gets or Sets GoalTurnover</summary>
        public double? GoalTurnover { get; set; }
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
        /// <summary>Gets or Sets LinkedEntityId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedEntityId { get; set; }
#nullable restore
#else
        public string LinkedEntityId { get; set; }
#endif
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets PeriodId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeriodId { get; set; }
#nullable restore
#else
        public string PeriodId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body53 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body53();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"budgetId", n => { BudgetId = n.GetStringValue(); } },
                {"goalEarnings", n => { GoalEarnings = n.GetDoubleValue(); } },
                {"goalTurnover", n => { GoalTurnover = n.GetDoubleValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"linkedEntityId", n => { LinkedEntityId = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"periodId", n => { PeriodId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteDoubleValue("goalEarnings", GoalEarnings);
            writer.WriteDoubleValue("goalTurnover", GoalTurnover);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("linkedEntityId", LinkedEntityId);
            writer.WriteStringValue("no", No);
            writer.WriteStringValue("periodId", PeriodId);
        }
    }
}