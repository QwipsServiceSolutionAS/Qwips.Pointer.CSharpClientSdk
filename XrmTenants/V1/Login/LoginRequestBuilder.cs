// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmTenants.V1.Login.PortalConfig;
using Qwips.Core.Pointer.XrmTenants.V1.Login.WhoAmI;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmTenants.V1.Login {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-tenants\v1\login
    /// </summary>
    public class LoginRequestBuilder : BaseRequestBuilder {
        /// <summary>The portalConfig property</summary>
        public PortalConfigRequestBuilder PortalConfig { get =>
            new PortalConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The whoAmI property</summary>
        public WhoAmIRequestBuilder WhoAmI { get =>
            new WhoAmIRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new LoginRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoginRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-tenants/v1/login", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new LoginRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoginRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-tenants/v1/login", rawUrl) {
        }
    }
}
