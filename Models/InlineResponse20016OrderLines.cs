// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse20016OrderLines : IParsable {
        /// <summary>Gets or Sets Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? _id { get; set; }
#nullable restore
#else
        public string _id { get; set; }
#endif
        /// <summary>Gets or Sets CostPrice</summary>
        public double? CostPrice { get; set; }
        /// <summary>Gets or Sets Coverage</summary>
        public double? Coverage { get; set; }
        /// <summary>Gets or Sets CreatedBy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>Gets or Sets CustomerId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
        /// <summary>Gets or Sets DepartmentId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DepartmentId { get; set; }
#nullable restore
#else
        public string DepartmentId { get; set; }
#endif
        /// <summary>Gets or Sets DepartmentProject</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DepartmentProject { get; set; }
#nullable restore
#else
        public string DepartmentProject { get; set; }
#endif
        /// <summary>Gets or Sets EnvironmentDuty</summary>
        public double? EnvironmentDuty { get; set; }
        /// <summary>Gets or Sets FinancialAccountingResourceId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinancialAccountingResourceId { get; set; }
#nullable restore
#else
        public string FinancialAccountingResourceId { get; set; }
#endif
        /// <summary>Gets or Sets HeightInCm</summary>
        public double? HeightInCm { get; set; }
        /// <summary>Gets or Sets Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets or Sets IntendedQuantity</summary>
        public double? IntendedQuantity { get; set; }
        /// <summary>Gets or Sets IsClosedLocally</summary>
        public bool? IsClosedLocally { get; set; }
        /// <summary>Gets or Sets IsDeleted</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>Gets or Sets IsDescriptionOnly</summary>
        public bool? IsDescriptionOnly { get; set; }
        /// <summary>Gets or Sets IsOption</summary>
        public bool? IsOption { get; set; }
        /// <summary>Gets or Sets LengthInCm</summary>
        public double? LengthInCm { get; set; }
        /// <summary>Gets or Sets LineComment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineComment { get; set; }
#nullable restore
#else
        public string LineComment { get; set; }
#endif
        /// <summary>Gets or Sets LineDescription</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineDescription { get; set; }
#nullable restore
#else
        public string LineDescription { get; set; }
#endif
        /// <summary>Gets or Sets ListUnitPrice</summary>
        public double? ListUnitPrice { get; set; }
        /// <summary>Gets or Sets LogicalGroupIndex</summary>
        public int? LogicalGroupIndex { get; set; }
        /// <summary>Gets or Sets PosNote</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PosNote { get; set; }
#nullable restore
#else
        public string PosNote { get; set; }
#endif
        /// <summary>Gets or Sets ProductId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductId { get; set; }
#nullable restore
#else
        public string ProductId { get; set; }
#endif
        /// <summary>Gets or Sets ProductName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>Gets or Sets ProductNo</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNo { get; set; }
#nullable restore
#else
        public string ProductNo { get; set; }
#endif
        /// <summary>Gets or Sets Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Gets or Sets RoomId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoomId { get; set; }
#nullable restore
#else
        public string RoomId { get; set; }
#endif
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>Gets or Sets SalesOrderCategoryId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesOrderCategoryId { get; set; }
#nullable restore
#else
        public string SalesOrderCategoryId { get; set; }
#endif
        /// <summary>Gets or Sets SellerId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellerId { get; set; }
#nullable restore
#else
        public string SellerId { get; set; }
#endif
        /// <summary>Gets or Sets SellingUnit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellingUnit { get; set; }
#nullable restore
#else
        public string SellingUnit { get; set; }
#endif
        /// <summary>Gets or Sets SpecialDuty</summary>
        public double? SpecialDuty { get; set; }
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse20016Summary? Summary { get; set; }
#nullable restore
#else
        public InlineResponse20016Summary Summary { get; set; }
#endif
        /// <summary>Gets or Sets Tags</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>Gets or Sets UnitDiscountPct</summary>
        public double? UnitDiscountPct { get; set; }
        /// <summary>unitPrice before surcharge and discount is applied!</summary>
        public double? UnitPrice { get; set; }
        /// <summary>Gets or Sets UnitSurchargePct</summary>
        public double? UnitSurchargePct { get; set; }
        /// <summary>Gets or Sets VatGroupId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VatGroupId { get; set; }
#nullable restore
#else
        public string VatGroupId { get; set; }
#endif
        /// <summary>Gets or Sets VatRatePct</summary>
        public int? VatRatePct { get; set; }
        /// <summary>Gets or Sets WarehouseIdentifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseIdentifier { get; set; }
#nullable restore
#else
        public string WarehouseIdentifier { get; set; }
#endif
        /// <summary>Gets or Sets WidthInCm</summary>
        public double? WidthInCm { get; set; }
        /// <summary>Gets or Sets WorkSeconds</summary>
        public int? WorkSeconds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse20016OrderLines CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse20016OrderLines();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"_id", n => { _id = n.GetStringValue(); } },
                {"costPrice", n => { CostPrice = n.GetDoubleValue(); } },
                {"coverage", n => { Coverage = n.GetDoubleValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"departmentId", n => { DepartmentId = n.GetStringValue(); } },
                {"departmentProject", n => { DepartmentProject = n.GetStringValue(); } },
                {"environmentDuty", n => { EnvironmentDuty = n.GetDoubleValue(); } },
                {"financialAccountingResourceId", n => { FinancialAccountingResourceId = n.GetStringValue(); } },
                {"heightInCm", n => { HeightInCm = n.GetDoubleValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"intendedQuantity", n => { IntendedQuantity = n.GetDoubleValue(); } },
                {"isClosedLocally", n => { IsClosedLocally = n.GetBoolValue(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"isDescriptionOnly", n => { IsDescriptionOnly = n.GetBoolValue(); } },
                {"isOption", n => { IsOption = n.GetBoolValue(); } },
                {"lengthInCm", n => { LengthInCm = n.GetDoubleValue(); } },
                {"lineComment", n => { LineComment = n.GetStringValue(); } },
                {"lineDescription", n => { LineDescription = n.GetStringValue(); } },
                {"listUnitPrice", n => { ListUnitPrice = n.GetDoubleValue(); } },
                {"logicalGroupIndex", n => { LogicalGroupIndex = n.GetIntValue(); } },
                {"posNote", n => { PosNote = n.GetStringValue(); } },
                {"productId", n => { ProductId = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"productNo", n => { ProductNo = n.GetStringValue(); } },
                {"quantity", n => { Quantity = n.GetDoubleValue(); } },
                {"roomId", n => { RoomId = n.GetStringValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrderCategoryId", n => { SalesOrderCategoryId = n.GetStringValue(); } },
                {"sellerId", n => { SellerId = n.GetStringValue(); } },
                {"sellingUnit", n => { SellingUnit = n.GetStringValue(); } },
                {"specialDuty", n => { SpecialDuty = n.GetDoubleValue(); } },
                {"summary", n => { Summary = n.GetObjectValue<InlineResponse20016Summary>(InlineResponse20016Summary.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"unitDiscountPct", n => { UnitDiscountPct = n.GetDoubleValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
                {"unitSurchargePct", n => { UnitSurchargePct = n.GetDoubleValue(); } },
                {"vatGroupId", n => { VatGroupId = n.GetStringValue(); } },
                {"vatRatePct", n => { VatRatePct = n.GetIntValue(); } },
                {"warehouseIdentifier", n => { WarehouseIdentifier = n.GetStringValue(); } },
                {"widthInCm", n => { WidthInCm = n.GetDoubleValue(); } },
                {"workSeconds", n => { WorkSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("_id", _id);
            writer.WriteDoubleValue("costPrice", CostPrice);
            writer.WriteDoubleValue("coverage", Coverage);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("departmentId", DepartmentId);
            writer.WriteStringValue("departmentProject", DepartmentProject);
            writer.WriteDoubleValue("environmentDuty", EnvironmentDuty);
            writer.WriteStringValue("financialAccountingResourceId", FinancialAccountingResourceId);
            writer.WriteDoubleValue("heightInCm", HeightInCm);
            writer.WriteStringValue("id", Id);
            writer.WriteDoubleValue("intendedQuantity", IntendedQuantity);
            writer.WriteBoolValue("isClosedLocally", IsClosedLocally);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteBoolValue("isDescriptionOnly", IsDescriptionOnly);
            writer.WriteBoolValue("isOption", IsOption);
            writer.WriteDoubleValue("lengthInCm", LengthInCm);
            writer.WriteStringValue("lineComment", LineComment);
            writer.WriteStringValue("lineDescription", LineDescription);
            writer.WriteDoubleValue("listUnitPrice", ListUnitPrice);
            writer.WriteIntValue("logicalGroupIndex", LogicalGroupIndex);
            writer.WriteStringValue("posNote", PosNote);
            writer.WriteStringValue("productId", ProductId);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("productNo", ProductNo);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteStringValue("roomId", RoomId);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteStringValue("salesOrderCategoryId", SalesOrderCategoryId);
            writer.WriteStringValue("sellerId", SellerId);
            writer.WriteStringValue("sellingUnit", SellingUnit);
            writer.WriteDoubleValue("specialDuty", SpecialDuty);
            writer.WriteObjectValue<InlineResponse20016Summary>("summary", Summary);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteDoubleValue("unitDiscountPct", UnitDiscountPct);
            writer.WriteDoubleValue("unitPrice", UnitPrice);
            writer.WriteDoubleValue("unitSurchargePct", UnitSurchargePct);
            writer.WriteStringValue("vatGroupId", VatGroupId);
            writer.WriteIntValue("vatRatePct", VatRatePct);
            writer.WriteStringValue("warehouseIdentifier", WarehouseIdentifier);
            writer.WriteDoubleValue("widthInCm", WidthInCm);
            writer.WriteIntValue("workSeconds", WorkSeconds);
        }
    }
}
