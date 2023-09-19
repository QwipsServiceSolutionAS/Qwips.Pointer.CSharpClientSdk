// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDrive.V1.EventHandlers.UserUploadPubSubV1;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDrive.V1.EventHandlers {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-drive\v1\eventHandlers
    /// </summary>
    public class EventHandlersRequestBuilder : BaseRequestBuilder {
        /// <summary>The userUploadPubSubV1 property</summary>
        public UserUploadPubSubV1RequestBuilder UserUploadPubSubV1 { get =>
            new UserUploadPubSubV1RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new EventHandlersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventHandlersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/eventHandlers", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EventHandlersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventHandlersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/eventHandlers", rawUrl) {
        }
    }
}