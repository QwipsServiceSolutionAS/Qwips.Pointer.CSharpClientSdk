// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.Pointer.Models {
    public class InlineResponse2008MainAddress : IParsable {
        /// <summary>Gets or Sets AddressLine1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine1 { get; set; }
#nullable restore
#else
        public string AddressLine1 { get; set; }
#endif
        /// <summary>Gets or Sets AddressLine2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine2 { get; set; }
#nullable restore
#else
        public string AddressLine2 { get; set; }
#endif
        /// <summary>Gets or Sets AddressLine3</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine3 { get; set; }
#nullable restore
#else
        public string AddressLine3 { get; set; }
#endif
        /// <summary>Gets or Sets AddressType</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressType { get; set; }
#nullable restore
#else
        public string AddressType { get; set; }
#endif
        /// <summary>Gets or Sets City</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Gets or Sets Country</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The geoPoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InlineResponse2008MainAddressGeoPoint? GeoPoint { get; set; }
#nullable restore
#else
        public InlineResponse2008MainAddressGeoPoint GeoPoint { get; set; }
#endif
        /// <summary>Gets or Sets Gln</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gln { get; set; }
#nullable restore
#else
        public string Gln { get; set; }
#endif
        /// <summary>Gets or Sets MunicipalityCode</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MunicipalityCode { get; set; }
#nullable restore
#else
        public string MunicipalityCode { get; set; }
#endif
        /// <summary>Gets or Sets MunicipalityName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MunicipalityName { get; set; }
#nullable restore
#else
        public string MunicipalityName { get; set; }
#endif
        /// <summary>Gets or Sets Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or Sets Zip</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InlineResponse2008MainAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InlineResponse2008MainAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addressLine1", n => { AddressLine1 = n.GetStringValue(); } },
                {"addressLine2", n => { AddressLine2 = n.GetStringValue(); } },
                {"addressLine3", n => { AddressLine3 = n.GetStringValue(); } },
                {"addressType", n => { AddressType = n.GetStringValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"geoPoint", n => { GeoPoint = n.GetObjectValue<InlineResponse2008MainAddressGeoPoint>(InlineResponse2008MainAddressGeoPoint.CreateFromDiscriminatorValue); } },
                {"gln", n => { Gln = n.GetStringValue(); } },
                {"municipalityCode", n => { MunicipalityCode = n.GetStringValue(); } },
                {"municipalityName", n => { MunicipalityName = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressLine1", AddressLine1);
            writer.WriteStringValue("addressLine2", AddressLine2);
            writer.WriteStringValue("addressLine3", AddressLine3);
            writer.WriteStringValue("addressType", AddressType);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteObjectValue<InlineResponse2008MainAddressGeoPoint>("geoPoint", GeoPoint);
            writer.WriteStringValue("gln", Gln);
            writer.WriteStringValue("municipalityCode", MunicipalityCode);
            writer.WriteStringValue("municipalityName", MunicipalityName);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("zip", Zip);
        }
    }
}