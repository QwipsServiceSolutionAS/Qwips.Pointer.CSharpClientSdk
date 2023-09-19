// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.DriveCopyFilesFromTo;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.DriveCreateFolder;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.GraphProxy;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.Mail;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.Sync;
using Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item.UserProxy;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmAzureAdmin.V1.Tenants.Item {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-azure-admin\v1\tenants\{tenantId}
    /// </summary>
    public class WithTenantItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The driveCopyFilesFromTo property</summary>
        public DriveCopyFilesFromToRequestBuilder DriveCopyFilesFromTo { get =>
            new DriveCopyFilesFromToRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The driveCreateFolder property</summary>
        public DriveCreateFolderRequestBuilder DriveCreateFolder { get =>
            new DriveCreateFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The graphProxy property</summary>
        public GraphProxyRequestBuilder GraphProxy { get =>
            new GraphProxyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mail property</summary>
        public MailRequestBuilder Mail { get =>
            new MailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sync property</summary>
        public SyncRequestBuilder Sync { get =>
            new SyncRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userProxy property</summary>
        public UserProxyRequestBuilder UserProxy { get =>
            new UserProxyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-azure-admin/v1/tenants/{tenantId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTenantItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTenantItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-azure-admin/v1/tenants/{tenantId}", rawUrl) {
        }
    }
}