// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20034Tasks : IParsable {
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016OurContact? AssignedTo { get; set; }
#nullable restore
#else
        public InlineResponse20016OurContact AssignedTo { get; set; }
#endif
        /// <summary>Gets or Sets AssignedToId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedToId { get; set; }
#nullable restore
#else
        public string AssignedToId { get; set; }
#endif
        /// <summary>Gets or Sets AzureResourceId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureResourceId { get; set; }
#nullable restore
#else
        public string AzureResourceId { get; set; }
#endif
        /// <summary>Gets or Sets ChecklistItems</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20034ChecklistItems>? ChecklistItems { get; set; }
#nullable restore
#else
        public List<InlineResponse20034ChecklistItems> ChecklistItems { get; set; }
#endif
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
        public InlineResponse20034CustomerContact? CustomerContact { get; set; }
#nullable restore
#else
        public InlineResponse20034CustomerContact CustomerContact { get; set; }
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
        /// <summary>Gets or Sets DeadlineAt</summary>
        public DateTimeOffset? DeadlineAt { get; set; }
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
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets LineItems</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse20016OrderLines>? LineItems { get; set; }
#nullable restore
#else
        public List<InlineResponse20016OrderLines> LineItems { get; set; }
#endif
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
        /// <summary>The parentProject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008Department? ParentProject { get; set; }
#nullable restore
#else
        public InlineResponse2008Department ParentProject { get; set; }
#endif
        /// <summary>Gets or Sets ParentProjectId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentProjectId { get; set; }
#nullable restore
#else
        public string ParentProjectId { get; set; }
#endif
        /// <summary>The parentSalesOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Project? ParentSalesOrder { get; set; }
#nullable restore
#else
        public InlineResponse20016Project ParentSalesOrder { get; set; }
#endif
        /// <summary>Gets or Sets ParentSalesOrderId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentSalesOrderId { get; set; }
#nullable restore
#else
        public string ParentSalesOrderId { get; set; }
#endif
        /// <summary>The parentTask property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008Department? ParentTask { get; set; }
#nullable restore
#else
        public InlineResponse2008Department ParentTask { get; set; }
#endif
        /// <summary>Gets or Sets ParentTaskId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentTaskId { get; set; }
#nullable restore
#else
        public string ParentTaskId { get; set; }
#endif
        /// <summary>Gets or Sets PlannedEndAt</summary>
        public DateTimeOffset? PlannedEndAt { get; set; }
        /// <summary>Gets or Sets PlannedHours</summary>
        public double? PlannedHours { get; set; }
        /// <summary>Gets or Sets PlannedStartAt</summary>
        public DateTimeOffset? PlannedStartAt { get; set; }
        /// <summary>Gets or Sets PricingType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PricingType { get; set; }
#nullable restore
#else
        public string PricingType { get; set; }
#endif
        /// <summary>Gets or Sets Priority</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Priority { get; set; }
#nullable restore
#else
        public string Priority { get; set; }
#endif
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
        /// <summary>Gets or Sets Score</summary>
        public double? Score { get; set; }
        /// <summary>The serviceCase property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Project? ServiceCase { get; set; }
#nullable restore
#else
        public InlineResponse20016Project ServiceCase { get; set; }
#endif
        /// <summary>Gets or Sets ServiceCaseId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceCaseId { get; set; }
#nullable restore
#else
        public string ServiceCaseId { get; set; }
#endif
        /// <summary>Gets or Sets StatusPhase</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusPhase { get; set; }
#nullable restore
#else
        public string StatusPhase { get; set; }
#endif
        /// <summary>Gets or Sets StatusProgress</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusProgress { get; set; }
#nullable restore
#else
        public string StatusProgress { get; set; }
#endif
        /// <summary>The taskCollection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016OurContact? TaskCollection { get; set; }
#nullable restore
#else
        public InlineResponse20016OurContact TaskCollection { get; set; }
#endif
        /// <summary>Gets or Sets TaskCollectionId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskCollectionId { get; set; }
#nullable restore
#else
        public string TaskCollectionId { get; set; }
#endif
        /// <summary>Gets or Sets TenantId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>Gets or Sets TypeCategory1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TypeCategory1 { get; set; }
#nullable restore
#else
        public string TypeCategory1 { get; set; }
#endif
        /// <summary>Gets or Sets UnsafeHtmlDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnsafeHtmlDescription { get; set; }
#nullable restore
#else
        public string UnsafeHtmlDescription { get; set; }
#endif
        /// <summary>Gets or Sets UpdatedAt</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20034Tasks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20034Tasks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTo", n => { AssignedTo = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"assignedToId", n => { AssignedToId = n.GetStringValue(); } },
                {"azureResourceId", n => { AzureResourceId = n.GetStringValue(); } },
                {"checklistItems", n => { ChecklistItems = n.GetCollectionOfObjectValues<InlineResponse20034ChecklistItems>(InlineResponse20034ChecklistItems.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"customerContact", n => { CustomerContact = n.GetObjectValue<InlineResponse20034CustomerContact>(InlineResponse20034CustomerContact.CreateFromDiscriminatorValue); } },
                {"customerContactId", n => { CustomerContactId = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"deadlineAt", n => { DeadlineAt = n.GetDateTimeOffsetValue(); } },
                {"_hashes", n => { Hashes = n.GetObjectValue<InlineResponse2004Hashes>(InlineResponse2004Hashes.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"lineItems", n => { LineItems = n.GetCollectionOfObjectValues<InlineResponse20016OrderLines>(InlineResponse20016OrderLines.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"parentProject", n => { ParentProject = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"parentProjectId", n => { ParentProjectId = n.GetStringValue(); } },
                {"parentSalesOrder", n => { ParentSalesOrder = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"parentSalesOrderId", n => { ParentSalesOrderId = n.GetStringValue(); } },
                {"parentTask", n => { ParentTask = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"parentTaskId", n => { ParentTaskId = n.GetStringValue(); } },
                {"plannedEndAt", n => { PlannedEndAt = n.GetDateTimeOffsetValue(); } },
                {"plannedHours", n => { PlannedHours = n.GetDoubleValue(); } },
                {"plannedStartAt", n => { PlannedStartAt = n.GetDateTimeOffsetValue(); } },
                {"pricingType", n => { PricingType = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetStringValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOpty", n => { SalesOpty = n.GetObjectValue<InlineResponse2008Department>(InlineResponse2008Department.CreateFromDiscriminatorValue); } },
                {"salesOptyId", n => { SalesOptyId = n.GetStringValue(); } },
                {"_score", n => { Score = n.GetDoubleValue(); } },
                {"serviceCase", n => { ServiceCase = n.GetObjectValue<InlineResponse20016Project>(InlineResponse20016Project.CreateFromDiscriminatorValue); } },
                {"serviceCaseId", n => { ServiceCaseId = n.GetStringValue(); } },
                {"statusPhase", n => { StatusPhase = n.GetStringValue(); } },
                {"statusProgress", n => { StatusProgress = n.GetStringValue(); } },
                {"taskCollection", n => { TaskCollection = n.GetObjectValue<InlineResponse20016OurContact>(InlineResponse20016OurContact.CreateFromDiscriminatorValue); } },
                {"taskCollectionId", n => { TaskCollectionId = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"typeCategory1", n => { TypeCategory1 = n.GetStringValue(); } },
                {"unsafeHtmlDescription", n => { UnsafeHtmlDescription = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InlineResponse20016OurContact>("assignedTo", AssignedTo);
            writer.WriteStringValue("assignedToId", AssignedToId);
            writer.WriteStringValue("azureResourceId", AzureResourceId);
            writer.WriteCollectionOfObjectValues<InlineResponse20034ChecklistItems>("checklistItems", ChecklistItems);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("currency", Currency);
            writer.WriteObjectValue<InlineResponse2008Department>("customer", Customer);
            writer.WriteObjectValue<InlineResponse20034CustomerContact>("customerContact", CustomerContact);
            writer.WriteStringValue("customerContactId", CustomerContactId);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteDateTimeOffsetValue("deadlineAt", DeadlineAt);
            writer.WriteObjectValue<InlineResponse2004Hashes>("_hashes", Hashes);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteCollectionOfObjectValues<InlineResponse20016OrderLines>("lineItems", LineItems);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("no", No);
            writer.WriteObjectValue<InlineResponse2008Department>("parentProject", ParentProject);
            writer.WriteStringValue("parentProjectId", ParentProjectId);
            writer.WriteObjectValue<InlineResponse20016Project>("parentSalesOrder", ParentSalesOrder);
            writer.WriteStringValue("parentSalesOrderId", ParentSalesOrderId);
            writer.WriteObjectValue<InlineResponse2008Department>("parentTask", ParentTask);
            writer.WriteStringValue("parentTaskId", ParentTaskId);
            writer.WriteDateTimeOffsetValue("plannedEndAt", PlannedEndAt);
            writer.WriteDoubleValue("plannedHours", PlannedHours);
            writer.WriteDateTimeOffsetValue("plannedStartAt", PlannedStartAt);
            writer.WriteStringValue("pricingType", PricingType);
            writer.WriteStringValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteObjectValue<InlineResponse2008Department>("salesOpty", SalesOpty);
            writer.WriteStringValue("salesOptyId", SalesOptyId);
            writer.WriteDoubleValue("_score", Score);
            writer.WriteObjectValue<InlineResponse20016Project>("serviceCase", ServiceCase);
            writer.WriteStringValue("serviceCaseId", ServiceCaseId);
            writer.WriteStringValue("statusPhase", StatusPhase);
            writer.WriteStringValue("statusProgress", StatusProgress);
            writer.WriteObjectValue<InlineResponse20016OurContact>("taskCollection", TaskCollection);
            writer.WriteStringValue("taskCollectionId", TaskCollectionId);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("typeCategory1", TypeCategory1);
            writer.WriteStringValue("unsafeHtmlDescription", UnsafeHtmlDescription);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
