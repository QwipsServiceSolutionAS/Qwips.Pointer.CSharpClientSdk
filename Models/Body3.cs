// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class Body3 : IParsable {
        /// <summary>Gets or Sets CompanyName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>Gets or Sets DepartmentId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DepartmentId { get; set; }
#nullable restore
#else
        public string DepartmentId { get; set; }
#endif
        /// <summary>Gets or Sets Email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Gets or Sets Firstname</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Firstname { get; set; }
#nullable restore
#else
        public string Firstname { get; set; }
#endif
        /// <summary>Gets or Sets IsArchived</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Gets or Sets JobTitle</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>Gets or Sets Lastname</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Lastname { get; set; }
#nullable restore
#else
        public string Lastname { get; set; }
#endif
        /// <summary>The mainAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress? MainAddress { get; set; }
#nullable restore
#else
        public Xrmdbv1beta1tenantstenantIdemployeesMainAddress MainAddress { get; set; }
#endif
        /// <summary>Gets or Sets Mobile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mobile { get; set; }
#nullable restore
#else
        public string Mobile { get; set; }
#endif
        /// <summary>Gets or Sets No</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? No { get; set; }
#nullable restore
#else
        public string No { get; set; }
#endif
        /// <summary>Gets or Sets Rowrels</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InlineResponse2002Rowrels>? Rowrels { get; set; }
#nullable restore
#else
        public List<InlineResponse2002Rowrels> Rowrels { get; set; }
#endif
        /// <summary>Gets or Sets SentToFinancialAccountingAt</summary>
        public DateTimeOffset? SentToFinancialAccountingAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Body3 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Body3();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"departmentId", n => { DepartmentId = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"firstname", n => { Firstname = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"lastname", n => { Lastname = n.GetStringValue(); } },
                {"mainAddress", n => { MainAddress = n.GetObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>(Xrmdbv1beta1tenantstenantIdemployeesMainAddress.CreateFromDiscriminatorValue); } },
                {"mobile", n => { Mobile = n.GetStringValue(); } },
                {"no", n => { No = n.GetStringValue(); } },
                {"rowrels", n => { Rowrels = n.GetCollectionOfObjectValues<InlineResponse2002Rowrels>(InlineResponse2002Rowrels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sentToFinancialAccountingAt", n => { SentToFinancialAccountingAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("departmentId", DepartmentId);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstname", Firstname);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("lastname", Lastname);
            writer.WriteObjectValue<Xrmdbv1beta1tenantstenantIdemployeesMainAddress>("mainAddress", MainAddress);
            writer.WriteStringValue("mobile", Mobile);
            writer.WriteStringValue("no", No);
            writer.WriteCollectionOfObjectValues<InlineResponse2002Rowrels>("rowrels", Rowrels);
            writer.WriteDateTimeOffsetValue("sentToFinancialAccountingAt", SentToFinancialAccountingAt);
        }
    }
}
