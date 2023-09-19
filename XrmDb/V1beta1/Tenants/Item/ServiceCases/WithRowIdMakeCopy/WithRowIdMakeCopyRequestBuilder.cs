// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.ServiceCases.WithRowIdMakeCopy {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\serviceCases\{rowId}:makeCopy
    /// </summary>
    public class WithRowIdMakeCopyRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithRowIdMakeCopyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRowIdMakeCopyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string rowId = "") : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/serviceCases/{rowId}:makeCopy", pathParameters) {
            if (!string.IsNullOrWhiteSpace(rowId)) PathParameters.Add("rowId", rowId);
        }
        /// <summary>
        /// Instantiates a new WithRowIdMakeCopyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRowIdMakeCopyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/serviceCases/{rowId}:makeCopy", rawUrl) {
        }
        /// <summary>
        /// Copy Service Case
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InlineResponse20064?> PostAsync(WithRowIdMakeCopyPostRequestBody body, Action<WithRowIdMakeCopyRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse20064> PostAsync(WithRowIdMakeCopyPostRequestBody body, Action<WithRowIdMakeCopyRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<InlineResponse20064>(requestInfo, InlineResponse20064.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Copy Service Case
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WithRowIdMakeCopyPostRequestBody body, Action<WithRowIdMakeCopyRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WithRowIdMakeCopyPostRequestBody body, Action<WithRowIdMakeCopyRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json-patch+json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WithRowIdMakeCopyRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithRowIdMakeCopyRequestBuilder WithUrl(string rawUrl) {
            return new WithRowIdMakeCopyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithRowIdMakeCopyRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithRowIdMakeCopyRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public WithRowIdMakeCopyRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
