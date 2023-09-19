// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20016CustomerSubscriptions : IParsable {
        /// <summary>Gets or Sets CreatedAt</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Gets or Sets Currency</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Customer? Customer { get; set; }
#nullable restore
#else
        public InlineResponse20016Customer Customer { get; set; }
#endif
        /// <summary>The customerContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016OurContact? CustomerContact { get; set; }
#nullable restore
#else
        public InlineResponse20016OurContact CustomerContact { get; set; }
#endif
        /// <summary>Gets or Sets CustomerContactId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerContactId { get; set; }
#nullable restore
#else
        public string CustomerContactId { get; set; }
#endif
        /// <summary>Gets or Sets CustomerId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
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
        /// <summary>Gets or Sets InvoiceComment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceComment { get; set; }
#nullable restore
#else
        public string InvoiceComment { get; set; }
#endif
        /// <summary>Gets or Sets InvoiceCustomerId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceCustomerId { get; set; }
#nullable restore
#else
        public string InvoiceCustomerId { get; set; }
#endif
        /// <summary>Gets or Sets InvoiceCustomerReference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceCustomerReference { get; set; }
#nullable restore
#else
        public string InvoiceCustomerReference { get; set; }
#endif
        /// <summary>Gets or Sets InvoiceOurReference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceOurReference { get; set; }
#nullable restore
#else
        public string InvoiceOurReference { get; set; }
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
        /// <summary>Gets or Sets OrderLines</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20016OrderLines>? OrderLines { get; set; }
#nullable restore
#else
        public List<InlineResponse20016OrderLines> OrderLines { get; set; }
#endif
        /// <summary>The ourContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016OurContact? OurContact { get; set; }
#nullable restore
#else
        public InlineResponse20016OurContact OurContact { get; set; }
#endif
        /// <summary>Gets or Sets OurContactId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OurContactId { get; set; }
#nullable restore
#else
        public string OurContactId { get; set; }
#endif
        /// <summary>Gets or Sets PersistedPdfGenOptions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016CustomerSubscriptions_persistedPdfGenOptions? PersistedPdfGenOptions { get; set; }
#nullable restore
#else
        public InlineResponse20016CustomerSubscriptions_persistedPdfGenOptions PersistedPdfGenOptions { get; set; }
#endif
        /// <summary>The project property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Project? Project { get; set; }
#nullable restore
#else
        public InlineResponse20016Project Project { get; set; }
#endif
        /// <summary>Gets or Sets ProjectId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>The salesQuote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Project? SalesQuote { get; set; }
#nullable restore
#else
        public InlineResponse20016Project SalesQuote { get; set; }
#endif
        /// <summary>Gets or Sets SalesQuoteId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesQuoteId { get; set; }
#nullable restore
#else
        public string SalesQuoteId { get; set; }
#endif
        /// <summary>Gets or Sets Score</summary>
        public double? Score { get; set; }
        /// <summary>Gets or Sets SubscriptionBeginAt</summary>
        public DateTimeOffset? SubscriptionBeginAt { get; set; }
        /// <summary>Gets or Sets SubscriptionEndAt</summary>
        public DateTimeOffset? SubscriptionEndAt { get; set; }
        /// <summary>Gets or Sets SubscriptionEndRegisteredAt</summary>
        public DateTimeOffset? SubscriptionEndRegisteredAt { get; set; }
        /// <summary>Gets or Sets SubscriptionExecutedAt</summary>
        public DateTimeOffset? SubscriptionExecutedAt { get; set; }
        /// <summary>Gets or Sets SubscriptionNextExecutionAt</summary>
        public DateTimeOffset? SubscriptionNextExecutionAt { get; set; }
        /// <summary>Gets or Sets SubscriptionPeriodCount</summary>
        public double? SubscriptionPeriodCount { get; set; }
        /// <summary>Gets or Sets SubscriptionPeriodType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionPeriodType { get; set; }
#nullable restore
#else
        public string SubscriptionPeriodType { get; set; }
#endif
        /// <summary>Gets or Sets SubscriptionStatus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionStatus { get; set; }
#nullable restore
#else
        public string SubscriptionStatus { get; set; }
#endif
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Summary1? Summary { get; set; }
#nullable restore
#else
        public InlineResponse20016Summary1 Summary { get; set; }
#endif
        /// <summary>Gets or Sets TenantId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>Gets or Sets UpdatedAt</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20016CustomerSubscriptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20016CustomerSubscriptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<InlineResponse20016Customer>(InlineResponse20016Customer.CreateFromDiscriminatorValue); } },
                {"customerContact", n => { CustomerContact = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"customerContactId", n => { CustomerContactId = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"invoiceComment", n => { InvoiceComment = n.GetStringValue(); } },
                {"invoiceCustomerId", n => { InvoiceCustomerId = n.GetStringValue(); } },
                {"invoiceCustomerReference", n => { InvoiceCustomerReference = n.GetStringValue(); } },
                {"invoiceOurReference", n => { InvoiceOurReference = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"orderLines", n => { OrderLines = n.GetCollectionOfObjectValues<InlineResponse20016OrderLines>(InlineResponse20016OrderLines.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ourContact", n => { OurContact = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"ourContactId", n => { OurContactId = n.GetStringValue(); } },
                {"persistedPdfGenOptions", n => { PersistedPdfGenOptions = n.GetObjectValue<InlineResponse20016CustomerSubscriptions_persistedPdfGenOptions>(InlineResponse20016CustomerSubscriptions_persistedPdfGenOptions.CreateFromDiscriminatorValue); } },
                {"project", n => { Project = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesQuote", n => { SalesQuote = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"salesQuoteId", n => { SalesQuoteId = n.GetStringValue(); } },
                {"_score", n => { Score = n.GetDoubleValue(); } },
                {"subscriptionBeginAt", n => { SubscriptionBeginAt = n.GetDateTimeOffsetValue(); } },
                {"subscriptionEndAt", n => { SubscriptionEndAt = n.GetDateTimeOffsetValue(); } },
                {"subscriptionEndRegisteredAt", n => { SubscriptionEndRegisteredAt = n.GetDateTimeOffsetValue(); } },
                {"subscriptionExecutedAt", n => { SubscriptionExecutedAt = n.GetDateTimeOffsetValue(); } },
                {"subscriptionNextExecutionAt", n => { SubscriptionNextExecutionAt = n.GetDateTimeOffsetValue(); } },
                {"subscriptionPeriodCount", n => { SubscriptionPeriodCount = n.GetDoubleValue(); } },
                {"subscriptionPeriodType", n => { SubscriptionPeriodType = n.GetStringValue(); } },
                {"subscriptionStatus", n => { SubscriptionStatus = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetObjectValue<InlineResponse20016Summary1>(InlineResponse20016Summary1.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("currency", Currency);
            writer.WriteObjectValue<InlineResponse20016Customer>("customer", Customer);
            writer.WriteObjectValue<InlineResponse20016OurContact>("customerContact", CustomerContact);
            writer.WriteStringValue("customerContactId", CustomerContactId);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("invoiceComment", InvoiceComment);
            writer.WriteStringValue("invoiceCustomerId", InvoiceCustomerId);
            writer.WriteStringValue("invoiceCustomerReference", InvoiceCustomerReference);
            writer.WriteStringValue("invoiceOurReference", InvoiceOurReference);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteCollectionOfObjectValues<InlineResponse20016OrderLines>("orderLines", OrderLines);
            writer.WriteObjectValue<InlineResponse20016OurContact>("ourContact", OurContact);
            writer.WriteStringValue("ourContactId", OurContactId);
            writer.WriteObjectValue<InlineResponse20016CustomerSubscriptions_persistedPdfGenOptions>("persistedPdfGenOptions", PersistedPdfGenOptions);
            writer.WriteObjectValue<InlineResponse20016Project>("project", Project);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteObjectValue<InlineResponse20016Project>("salesQuote", SalesQuote);
            writer.WriteStringValue("salesQuoteId", SalesQuoteId);
            writer.WriteDoubleValue("_score", Score);
            writer.WriteDateTimeOffsetValue("subscriptionBeginAt", SubscriptionBeginAt);
            writer.WriteDateTimeOffsetValue("subscriptionEndAt", SubscriptionEndAt);
            writer.WriteDateTimeOffsetValue("subscriptionEndRegisteredAt", SubscriptionEndRegisteredAt);
            writer.WriteDateTimeOffsetValue("subscriptionExecutedAt", SubscriptionExecutedAt);
            writer.WriteDateTimeOffsetValue("subscriptionNextExecutionAt", SubscriptionNextExecutionAt);
            writer.WriteDoubleValue("subscriptionPeriodCount", SubscriptionPeriodCount);
            writer.WriteStringValue("subscriptionPeriodType", SubscriptionPeriodType);
            writer.WriteStringValue("subscriptionStatus", SubscriptionStatus);
            writer.WriteObjectValue<InlineResponse20016Summary1>("summary", Summary);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
