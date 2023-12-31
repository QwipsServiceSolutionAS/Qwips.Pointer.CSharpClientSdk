// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmAutomation.V1beta1.Tenants.Item.Workflows;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmAutomation.V1beta1.Tenants.Item {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-automation\v1beta1\tenants\{tenantId}
    /// </summary>
    public class WithTenantItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The workflows property</summary>
        public WorkflowsRequestBuilder Workflows { get =>
            new WorkflowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-automation/v1beta1/tenants/{tenantId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-automation/v1beta1/tenants/{tenantId}", rawUrl) {
        }
    }
}
