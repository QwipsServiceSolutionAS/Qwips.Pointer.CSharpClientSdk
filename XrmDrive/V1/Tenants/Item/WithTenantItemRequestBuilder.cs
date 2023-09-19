// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDrive.V1.Tenants.Item.DriveItemsBrowser;
using Qwips.Core.Pointer.XrmDrive.V1.Tenants.Item.DriveItemsCancelUpload;
using Qwips.Core.Pointer.XrmDrive.V1.Tenants.Item.DriveItemsCreateUpload;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDrive.V1.Tenants.Item {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-drive\v1\tenants\{tenantId}
    /// </summary>
    public class WithTenantItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The driveItemsBrowser property</summary>
        public DriveItemsBrowserRequestBuilder DriveItemsBrowser { get =>
            new DriveItemsBrowserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The driveItemsCancelUpload property</summary>
        public DriveItemsCancelUploadRequestBuilder DriveItemsCancelUpload { get =>
            new DriveItemsCancelUploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The driveItemsCreateUpload property</summary>
        public DriveItemsCreateUploadRequestBuilder DriveItemsCreateUpload { get =>
            new DriveItemsCreateUploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/tenants/{tenantId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/tenants/{tenantId}", rawUrl) {
        }
    }
}
