// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.Models; 
 using Qwips.Core.PointerClientSdk.ErrorHandling;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.Pointer.XrmDrive.V1.Tenants.Item.DriveItemsBrowser {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-drive\v1\tenants\{tenantId}\driveItemsBrowser
    /// </summary>
    public class DriveItemsBrowserRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DriveItemsBrowserRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemsBrowserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/tenants/{tenantId}/driveItemsBrowser{?path*,includeContentUrl*,includeThumbnails*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DriveItemsBrowserRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemsBrowserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-drive/v1/tenants/{tenantId}/driveItemsBrowser{?path*,includeContentUrl*,includeThumbnails*}", rawUrl) {
        }
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InlineResponse20040?> GetAsync(Action<DriveItemsBrowserRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse20040> GetAsync(Action<DriveItemsBrowserRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<InlineResponse20040>(requestInfo, InlineResponse20040.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DriveItemsBrowserRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DriveItemsBrowserRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            if (requestConfiguration != null) {
                var requestConfig = new DriveItemsBrowserRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DriveItemsBrowserRequestBuilder WithUrl(string rawUrl) {
            return new DriveItemsBrowserRequestBuilder(rawUrl, RequestAdapter);
        }
        public class DriveItemsBrowserRequestBuilderGetQueryParameters {
            public bool? IncludeContentUrl { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? IncludeThumbnails { get; set; }
#nullable restore
#else
            public string IncludeThumbnails { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Path { get; set; }
#nullable restore
#else
            public string Path { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DriveItemsBrowserRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DriveItemsBrowserRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DriveItemsBrowserRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new driveItemsBrowserRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DriveItemsBrowserRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
