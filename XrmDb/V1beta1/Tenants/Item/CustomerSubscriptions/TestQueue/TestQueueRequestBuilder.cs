// <auto-generated/>

using Microsoft.Kiota.Abstractions;
using Qwips.Core.PointerClientSdk.ErrorHandling;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.TestQueue
{
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\customerSubscriptions\:testQueue
    /// </summary>
    public class TestQueueRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new TestQueueRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TestQueueRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions/:testQueue", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TestQueueRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TestQueueRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions/:testQueue", rawUrl) {
        }
        /// <summary>
        /// List subscriptions queue
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TestQueueResponse?> PostAsync(TestQueuePostRequestBody body, Action<TestQueueRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TestQueueResponse> PostAsync(TestQueuePostRequestBody body, Action<TestQueueRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<TestQueueResponse>(requestInfo, TestQueueResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// List subscriptions queue
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(TestQueuePostRequestBody body, Action<TestQueueRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(TestQueuePostRequestBody body, Action<TestQueueRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new TestQueueRequestBuilderPostRequestConfiguration();
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
        public TestQueueRequestBuilder WithUrl(string rawUrl) {
            return new TestQueueRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TestQueueRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new TestQueueRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public TestQueueRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
