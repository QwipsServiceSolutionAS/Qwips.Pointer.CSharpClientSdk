// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDrive.V1.EventHandlers;
using Qwips.Core.Pointer.XrmDrive.V1.Tenants;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDrive.V1 {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-drive\v1
    /// </summary>
    public class V1RequestBuilder : BaseRequestBuilder {
        /// <summary>The eventHandlers property</summary>
        public EventHandlersRequestBuilder EventHandlers { get =>
            new EventHandlersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenants property</summary>
        public TenantsRequestBuilder Tenants { get =>
            new TenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new V1RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new V1RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1", rawUrl) {
        }
    }
}
