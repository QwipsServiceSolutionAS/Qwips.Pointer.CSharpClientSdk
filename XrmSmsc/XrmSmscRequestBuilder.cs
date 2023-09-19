// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmSmsc.V1;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmSmsc {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-smsc
    /// </summary>
    public class XrmSmscRequestBuilder : BaseRequestBuilder {
        /// <summary>The v1 property</summary>
        public V1RequestBuilder V1 { get =>
            new V1RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new XrmSmscRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public XrmSmscRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-smsc", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new XrmSmscRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public XrmSmscRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-smsc", rawUrl) {
        }
    }
}