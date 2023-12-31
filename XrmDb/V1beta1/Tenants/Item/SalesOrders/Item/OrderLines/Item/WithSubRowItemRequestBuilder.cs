// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.SalesOrders.Item.OrderLines.Item.Associations;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.SalesOrders.Item.OrderLines.Item {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\salesOrders\{rowId}\orderLines\{subRowId}
    /// </summary>
    public class WithSubRowItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The associations property</summary>
        public AssociationsRequestBuilder Associations { get =>
            new AssociationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithSubRowItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubRowItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/salesOrders/{rowId}/orderLines/{subRowId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithSubRowItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubRowItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/salesOrders/{rowId}/orderLines/{subRowId}", rawUrl) {
        }
    }
}
