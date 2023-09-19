// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20027SalesQuotes : IParsable {
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
        /// <summary>Gets or Sets Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
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
        /// <summary>Gets or Sets OrderLinesLogicalGroups</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderLinesLogicalGroups { get; set; }
#nullable restore
#else
        public List<string> OrderLinesLogicalGroups { get; set; }
#endif
        /// <summary>Gets or Sets OrderLinesReadOnly</summary>
        public bool? OrderLinesReadOnly { get; set; }
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
        public InlineResponse20027SalesQuotes_persistedPdfGenOptions? PersistedPdfGenOptions { get; set; }
#nullable restore
#else
        public InlineResponse20027SalesQuotes_persistedPdfGenOptions PersistedPdfGenOptions { get; set; }
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
        /// <summary>Gets or Sets QuoteEmailSentAt</summary>
        public DateTimeOffset? QuoteEmailSentAt { get; set; }
        /// <summary>Gets or Sets QuoteStatus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuoteStatus { get; set; }
#nullable restore
#else
        public string QuoteStatus { get; set; }
#endif
        /// <summary>Gets or Sets QuoteVersionAcceptedAt</summary>
        public DateTimeOffset? QuoteVersionAcceptedAt { get; set; }
        /// <summary>Gets or Sets QuoteVersionSentAt</summary>
        public DateTimeOffset? QuoteVersionSentAt { get; set; }
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>The salesOpty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008Department? SalesOpty { get; set; }
#nullable restore
#else
        public InlineResponse2008Department SalesOpty { get; set; }
#endif
        /// <summary>Gets or Sets SalesOptyId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesOptyId { get; set; }
#nullable restore
#else
        public string SalesOptyId { get; set; }
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
        /// <summary>Gets or Sets Score</summary>
        public double? Score { get; set; }
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
        public static InlineResponse20027SalesQuotes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20027SalesQuotes();
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
                {"deliveryAddress", n => { DeliveryAddress = n.GetObjectValue<InlineResponse2008MainAddress>(InlineResponse2008MainAddress.CreateFromDiscriminatorValue); } },
                {"deliveryPlannedAt", n => { DeliveryPlannedAt = n.GetDateTimeOffsetValue(); } },
                {"expiresAt", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"invoiceAddress", n => { InvoiceAddress = n.GetObjectValue<InlineResponse2008MainAddress>(InlineResponse2008MainAddress.CreateFromDiscriminatorValue); } },
                {"invoiceComment", n => { InvoiceComment = n.GetStringValue(); } },
                {"invoiceCustomerReference", n => { InvoiceCustomerReference = n.GetStringValue(); } },
                {"invoiceEmail", n => { InvoiceEmail = n.GetStringValue(); } },
                {"invoiceOurReference", n => { InvoiceOurReference = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"orderLines", n => { OrderLines = n.GetCollectionOfObjectValues<InlineResponse20016OrderLines>(InlineResponse20016OrderLines.CreateFromDiscriminatorValue)?.ToList(); } },
                {"orderLinesLogicalGroups", n => { OrderLinesLogicalGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"orderLinesReadOnly", n => { OrderLinesReadOnly = n.GetBoolValue(); } },
                {"ourContact", n => { OurContact = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"ourContactId", n => { OurContactId = n.GetStringValue(); } },
                {"persistedPdfGenOptions", n => { PersistedPdfGenOptions = n.GetObjectValue<InlineResponse20027SalesQuotes_persistedPdfGenOptions>(InlineResponse20027SalesQuotes_persistedPdfGenOptions.CreateFromDiscriminatorValue); } },
                {"project", n => { Project = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"quoteEmailSentAt", n => { QuoteEmailSentAt = n.GetDateTimeOffsetValue(); } },
                {"quoteStatus", n => { QuoteStatus = n.GetStringValue(); } },
                {"quoteVersionAcceptedAt", n => { QuoteVersionAcceptedAt = n.GetDateTimeOffsetValue(); } },
                {"quoteVersionSentAt", n => { QuoteVersionSentAt = n.GetDateTimeOffsetValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOpty", n => { SalesOpty = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"salesOptyId", n => { SalesOptyId = n.GetStringValue(); } },
                {"salesOrderCategory", n => { SalesOrderCategory = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"salesOrderCategoryId", n => { SalesOrderCategoryId = n.GetStringValue(); } },
                {"_score", n => { Score = n.GetDoubleValue(); } },
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
            writer.WriteObjectValue<InlineResponse2008MainAddress>("deliveryAddress", DeliveryAddress);
            writer.WriteDateTimeOffsetValue("deliveryPlannedAt", DeliveryPlannedAt);
            writer.WriteDateTimeOffsetValue("expiresAt", ExpiresAt);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<InlineResponse2008MainAddress>("invoiceAddress", InvoiceAddress);
            writer.WriteStringValue("invoiceComment", InvoiceComment);
            writer.WriteStringValue("invoiceCustomerReference", InvoiceCustomerReference);
            writer.WriteStringValue("invoiceEmail", InvoiceEmail);
            writer.WriteStringValue("invoiceOurReference", InvoiceOurReference);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteCollectionOfObjectValues<InlineResponse20016OrderLines>("orderLines", OrderLines);
            writer.WriteCollectionOfPrimitiveValues<string>("orderLinesLogicalGroups", OrderLinesLogicalGroups);
            writer.WriteBoolValue("orderLinesReadOnly", OrderLinesReadOnly);
            writer.WriteObjectValue<InlineResponse20016OurContact>("ourContact", OurContact);
            writer.WriteStringValue("ourContactId", OurContactId);
            writer.WriteObjectValue<InlineResponse20027SalesQuotes_persistedPdfGenOptions>("persistedPdfGenOptions", PersistedPdfGenOptions);
            writer.WriteObjectValue<InlineResponse20016Project>("project", Project);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteDateTimeOffsetValue("quoteEmailSentAt", QuoteEmailSentAt);
            writer.WriteStringValue("quoteStatus", QuoteStatus);
            writer.WriteDateTimeOffsetValue("quoteVersionAcceptedAt", QuoteVersionAcceptedAt);
            writer.WriteDateTimeOffsetValue("quoteVersionSentAt", QuoteVersionSentAt);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteObjectValue<InlineResponse2008Department>("salesOpty", SalesOpty);
            writer.WriteStringValue("salesOptyId", SalesOptyId);
            writer.WriteObjectValue<InlineResponse20016OurContact>("salesOrderCategory", SalesOrderCategory);
            writer.WriteStringValue("salesOrderCategoryId", SalesOrderCategoryId);
            writer.WriteDoubleValue("_score", Score);
            writer.WriteObjectValue<InlineResponse20016Summary1>("summary", Summary);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
