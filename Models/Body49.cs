// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body49 : IParsable {
        /// <summary>Gets or Sets Currency</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
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
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress? DeliveryAddress { get; set; }
#nullable restore
#else
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress DeliveryAddress { get; set; }
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
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress? InvoiceAddress { get; set; }
#nullable restore
#else
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress InvoiceAddress { get; set; }
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
        public Body49_plus_InvoiceTypeEnum? InvoiceType { get; set; }
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
        public Body49_plus_OrderStatusEnum? OrderStatus { get; set; }
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
        public Body49_persistedPdfGenOptions? PersistedPdfGenOptions { get; set; }
#nullable restore
#else
        public Body49_persistedPdfGenOptions PersistedPdfGenOptions { get; set; }
#endif
        /// <summary>Gets or Sets ProjectId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>Gets or Sets SalesOrderCategoryId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesOrderCategoryId { get; set; }
#nullable restore
#else
        public string SalesOrderCategoryId { get; set; }
#endif
        /// <summary>Gets or Sets SalesQuoteId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesQuoteId { get; set; }
#nullable restore
#else
        public string SalesQuoteId { get; set; }
#endif
        /// <summary>Gets or Sets SentToFinancialAccountingAt</summary>
        public DateTimeOffset? SentToFinancialAccountingAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body49 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body49();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"customerContactId", n => { CustomerContactId = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerSubscriptionId", n => { CustomerSubscriptionId = n.GetStringValue(); } },
                {"deliveryAddress", n => { DeliveryAddress = n.GetObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>(Xrmdbv1beta1tenantstenantIdemployeesMainAddress.CreateFromDiscriminatorValue); } },
                {"deliveryPlannedAt", n => { DeliveryPlannedAt = n.GetDateTimeOffsetValue(); } },
                {"deliveryType", n => { DeliveryType = n.GetStringValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"internalComment", n => { InternalComment = n.GetStringValue(); } },
                {"invoiceAddress", n => { InvoiceAddress = n.GetObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>(Xrmdbv1beta1tenantstenantIdemployeesMainAddress.CreateFromDiscriminatorValue); } },
                {"invoiceComment", n => { InvoiceComment = n.GetStringValue(); } },
                {"invoiceCustomerId", n => { InvoiceCustomerId = n.GetStringValue(); } },
                {"invoiceCustomerReference", n => { InvoiceCustomerReference = n.GetStringValue(); } },
                {"invoiceEmail", n => { InvoiceEmail = n.GetStringValue(); } },
                {"invoiceOurReference", n => { InvoiceOurReference = n.GetStringValue(); } },
                {"invoiceType", n => { InvoiceType = n.GetEnumValue<Body49_plus_InvoiceTypeEnum>(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isClosedLocally", n => { IsClosedLocally = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"orderedAt", n => { OrderedAt = n.GetDateTimeOffsetValue(); } },
                {"orderLines", n => { OrderLines = n.GetCollectionOfObjectValues<InlineResponse20016OrderLines>(InlineResponse20016OrderLines.CreateFromDiscriminatorValue)?.ToList(); } },
                {"orderLinesLogicalGroups", n => { OrderLinesLogicalGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"orderStatus", n => { OrderStatus = n.GetEnumValue<Body49_plus_OrderStatusEnum>(); } },
                {"ourContactId", n => { OurContactId = n.GetStringValue(); } },
                {"persistedPdfGenOptions", n => { PersistedPdfGenOptions = n.GetObjectValue<Body49_persistedPdfGenOptions>(Body49_persistedPdfGenOptions.CreateFromDiscriminatorValue); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"salesOrderCategoryId", n => { SalesOrderCategoryId = n.GetStringValue(); } },
                {"salesQuoteId", n => { SalesQuoteId = n.GetStringValue(); } },
                {"sentToFinancialAccountingAt", n => { SentToFinancialAccountingAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("customerContactId", CustomerContactId);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerSubscriptionId", CustomerSubscriptionId);
            writer.WriteObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>("deliveryAddress", DeliveryAddress);
            writer.WriteDateTimeOffsetValue("deliveryPlannedAt", DeliveryPlannedAt);
            writer.WriteStringValue("deliveryType", DeliveryType);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("internalComment", InternalComment);
            writer.WriteObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>("invoiceAddress", InvoiceAddress);
            writer.WriteStringValue("invoiceComment", InvoiceComment);
            writer.WriteStringValue("invoiceCustomerId", InvoiceCustomerId);
            writer.WriteStringValue("invoiceCustomerReference", InvoiceCustomerReference);
            writer.WriteStringValue("invoiceEmail", InvoiceEmail);
            writer.WriteStringValue("invoiceOurReference", InvoiceOurReference);
            writer.WriteEnumValue<Body49_plus_InvoiceTypeEnum>("invoiceType", InvoiceType);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isClosedLocally", IsClosedLocally);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteDateTimeOffsetValue("orderedAt", OrderedAt);
            writer.WriteCollectionOfObjectValues<InlineResponse20016OrderLines>("orderLines", OrderLines);
            writer.WriteCollectionOfPrimitiveValues<string>("orderLinesLogicalGroups", OrderLinesLogicalGroups);
            writer.WriteEnumValue<Body49_plus_OrderStatusEnum>("orderStatus", OrderStatus);
            writer.WriteStringValue("ourContactId", OurContactId);
            writer.WriteObjectValue<Body49_persistedPdfGenOptions>("persistedPdfGenOptions", PersistedPdfGenOptions);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteStringValue("salesOrderCategoryId", SalesOrderCategoryId);
            writer.WriteStringValue("salesQuoteId", SalesQuoteId);
            writer.WriteDateTimeOffsetValue("sentToFinancialAccountingAt", SentToFinancialAccountingAt);
        }
    }
}
