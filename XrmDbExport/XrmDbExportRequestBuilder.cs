// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDbExport.V1;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDbExport {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db-export
    /// </summary>
    public class XrmDbExportRequestBuilder : BaseRequestBuilder {
        /// <summary>The v1 property</summary>
        public V1RequestBuilder V1 { get =>
            new V1RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new XrmDbExportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public XrmDbExportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db-export", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new XrmDbExportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public XrmDbExportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db-export", rawUrl) {
        }
    }
}
