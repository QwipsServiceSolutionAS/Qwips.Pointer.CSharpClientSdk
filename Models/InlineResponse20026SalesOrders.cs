// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20026SalesOrders : IParsable {
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
        public InlineResponse2008Department? Customer { get; set; }
#nullable restore
#else
        public InlineResponse2008Department Customer { get; set; }
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
        /// <summary>The customerSubscription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Project? CustomerSubscription { get; set; }
#nullable restore
#else
        public InlineResponse20016Project CustomerSubscription { get; set; }
#endif
        /// <summary>Gets or Sets CustomerSubscriptionId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerSubscriptionId { get; set; }
#nullable restore
#else
        public string CustomerSubscriptionId { get; set; }
#endif
        /// <summary>The deliveryAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008MainAddress? DeliveryAddress { get; set; }
#nullable restore
#else
        public InlineResponse2008MainAddress DeliveryAddress { get; set; }
#endif
        /// <summary>Gets or Sets DeliveryPlannedAt</summary>
        public DateTimeOffset? DeliveryPlannedAt { get; set; }
        /// <summary>Gets or Sets DeliveryType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryType { get; set; }
#nullable restore
#else
        public string DeliveryType { get; set; }
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
        /// <summary>Gets or Sets InternalComment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalComment { get; set; }
#nullable restore
#else
        public string InternalComment { get; set; }
#endif
        /// <summary>The invoiceAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008MainAddress? InvoiceAddress { get; set; }
#nullable restore
#else
        public InlineResponse2008MainAddress InvoiceAddress { get; set; }
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
        /// <summary>Gets or Sets InvoiceEmail</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceEmail { get; set; }
#nullable restore
#else
        public string InvoiceEmail { get; set; }
#endif
        /// <summary>Gets or Sets InvoiceOurReference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceOurReference { get; set; }
#nullable restore
#else
        public string InvoiceOurReference { get; set; }
#endif
        /// <summary>Gets or Sets InvoiceType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceType { get; set; }
#nullable restore
#else
        public string InvoiceType { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets IsClosedLocally</summary>
        public bool? IsClosedLocally { get; set; }
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
        /// <summary>Gets or Sets OrderedAt</summary>
        public DateTimeOffset? OrderedAt { get; set; }
        /// <summary>Gets or Sets OrderLines</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20016OrderLines>? OrderLines { get; set; }
#nullable restore
#else
        public List<InlineResponse20016OrderLines> OrderLines { get; set; }
#endif
        /// <summary>Gets or Sets OrderLinesLogicalGroups</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderLinesLogicalGroups { get; set; }
#nullable restore
#else
        public List<string> OrderLinesLogicalGroups { get; set; }
#endif
        /// <summary>Gets or Sets OrderStatus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderStatus { get; set; }
#nullable restore
#else
        public string OrderStatus { get; set; }
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
        public InlineResponse20026SalesOrders_persistedPdfGenOptions? PersistedPdfGenOptions { get; set; }
#nullable restore
#else
        public InlineResponse20026SalesOrders_persistedPdfGenOptions PersistedPdfGenOptions { get; set; }
#endif
        /// <summary>The project property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008Department? Project { get; set; }
#nullable restore
#else
        public InlineResponse2008Department Project { get; set; }
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
        /// <summary>The salesOrderCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016OurContact? SalesOrderCategory { get; set; }
#nullable restore
#else
        public InlineResponse20016OurContact SalesOrderCategory { get; set; }
#endif
        /// <summary>Gets or Sets SalesOrderCategoryId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesOrderCategoryId { get; set; }
#nullable restore
#else
        public string SalesOrderCategoryId { get; set; }
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
        /// <summary>Gets or Sets SentToFinancialAccountingAt</summary>
        public DateTimeOffset? SentToFinancialAccountingAt { get; set; }
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
        public static InlineResponse20026SalesOrders CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20026SalesOrders();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"customerContact", n => { CustomerContact = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"customerContactId", n => { CustomerContactId = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerSubscription", n => { CustomerSubscription = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"customerSubscriptionId", n => { CustomerSubscriptionId = n.GetStringValue(); } },
                {"deliveryAddress", n => { DeliveryAddress = n.GetObjectValue<InlineResponse2008MainAddress>(InlineResponse2008MainAddress.CreateFromDiscriminatorValue); } },
                {"deliveryPlannedAt", n => { DeliveryPlannedAt = n.GetDateTimeOffsetValue(); } },
                {"deliveryType", n => { DeliveryType = n.GetStringValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"internalComment", n => { InternalComment = n.GetStringValue(); } },
                {"invoiceAddress", n => { InvoiceAddress = n.GetObjectValue<InlineResponse2008MainAddress>(InlineResponse2008MainAddress.CreateFromDiscriminatorValue); } },
                {"invoiceComment", n => { InvoiceComment = n.GetStringValue(); } },
                {"invoiceCustomerId", n => { InvoiceCustomerId = n.GetStringValue(); } },
                {"invoiceCustomerReference", n => { InvoiceCustomerReference = n.GetStringValue(); } },
                {"invoiceEmail", n => { InvoiceEmail = n.GetStringValue(); } },
                {"invoiceOurReference", n => { InvoiceOurReference = n.GetStringValue(); } },
                {"invoiceType", n => { InvoiceType = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isClosedLocally", n => { IsClosedLocally = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"orderedAt", n => { OrderedAt = n.GetDateTimeOffsetValue(); } },
                {"orderLines", n => { OrderLines = n.GetCollectionOfObjectValues<InlineResponse20016OrderLines>(InlineResponse20016OrderLines.CreateFromDiscriminatorValue)?.ToList(); } },
                {"orderLinesLogicalGroups", n => { OrderLinesLogicalGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"orderStatus", n => { OrderStatus = n.GetStringValue(); } },
                {"ourContact", n => { OurContact = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"ourContactId", n => { OurContactId = n.GetStringValue(); } },
                {"persistedPdfGenOptions", n => { PersistedPdfGenOptions = n.GetObjectValue<InlineResponse20026SalesOrders_persistedPdfGenOptions>(InlineResponse20026SalesOrders_persistedPdfGenOptions.CreateFromDiscriminatorValue); } },
                {"project", n => { Project = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrderCategory", n => { SalesOrderCategory = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"salesOrderCategoryId", n => { SalesOrderCategoryId = n.GetStringValue(); } },
                {"salesQuote", n => { SalesQuote = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"salesQuoteId", n => { SalesQuoteId = n.GetStringValue(); } },
                {"_score", n => { Score = n.GetDoubleValue(); } },
                {"sentToFinancialAccountingAt", n => { SentToFinancialAccountingAt = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<InlineResponse2008Department>("customer", Customer);
            writer.WriteObjectValue<InlineResponse20016OurContact>("customerContact", CustomerContact);
            writer.WriteStringValue("customerContactId", CustomerContactId);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteObjectValue<InlineResponse20016Project>("customerSubscription", CustomerSubscription);
            writer.WriteStringValue("customerSubscriptionId", CustomerSubscriptionId);
            writer.WriteObjectValue<InlineResponse2008MainAddress>("deliveryAddress", DeliveryAddress);
            writer.WriteDateTimeOffsetValue("deliveryPlannedAt", DeliveryPlannedAt);
            writer.WriteStringValue("deliveryType", DeliveryType);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("internalComment", InternalComment);
            writer.WriteObjectValue<InlineResponse2008MainAddress>("invoiceAddress", InvoiceAddress);
            writer.WriteStringValue("invoiceComment", InvoiceComment);
            writer.WriteStringValue("invoiceCustomerId", InvoiceCustomerId);
            writer.WriteStringValue("invoiceCustomerReference", InvoiceCustomerReference);
            writer.WriteStringValue("invoiceEmail", InvoiceEmail);
            writer.WriteStringValue("invoiceOurReference", InvoiceOurReference);
            writer.WriteStringValue("invoiceType", InvoiceType);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isClosedLocally", IsClosedLocally);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteDateTimeOffsetValue("orderedAt", OrderedAt);
            writer.WriteCollectionOfObjectValues<InlineResponse20016OrderLines>("orderLines", OrderLines);
            writer.WriteCollectionOfPrimitiveValues<string>("orderLinesLogicalGroups", OrderLinesLogicalGroups);
            writer.WriteStringValue("orderStatus", OrderStatus);
            writer.WriteObjectValue<InlineResponse20016OurContact>("ourContact", OurContact);
            writer.WriteStringValue("ourContactId", OurContactId);
            writer.WriteObjectValue<InlineResponse20026SalesOrders_persistedPdfGenOptions>("persistedPdfGenOptions", PersistedPdfGenOptions);
            writer.WriteObjectValue<InlineResponse2008Department>("project", Project);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteObjectValue<InlineResponse20016OurContact>("salesOrderCategory", SalesOrderCategory);
            writer.WriteStringValue("salesOrderCategoryId", SalesOrderCategoryId);
            writer.WriteObjectValue<InlineResponse20016Project>("salesQuote", SalesQuote);
            writer.WriteStringValue("salesQuoteId", SalesQuoteId);
            writer.WriteDoubleValue("_score", Score);
            writer.WriteDateTimeOffsetValue("sentToFinancialAccountingAt", SentToFinancialAccountingAt);
            writer.WriteObjectValue<InlineResponse20016Summary1>("summary", Summary);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
