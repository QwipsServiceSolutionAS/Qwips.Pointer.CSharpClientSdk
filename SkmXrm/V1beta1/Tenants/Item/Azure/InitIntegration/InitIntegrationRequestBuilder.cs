// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.PointerClientSdk.ErrorHandling;
namespace Qwips.Core.Pointer.SkmXrm.V1beta1.Tenants.Item.Azure.InitIntegration
{
    /// <summary>
    /// Builds and executes requests for operations under \skm-xrm\v1beta1\tenants\{tenantId}\azure\initIntegration
    /// </summary>
    public class InitIntegrationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new InitIntegrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InitIntegrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/skm-xrm/v1beta1/tenants/{tenantId}/azure/initIntegration", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new InitIntegrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InitIntegrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/skm-xrm/v1beta1/tenants/{tenantId}/azure/initIntegration", rawUrl)
        {
        }
        /// <summary>
        /// Init Integration
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InitIntegrationResponse?> PostAsync(InitIntegrationPostRequestBody body, Action<InitIntegrationRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<InitIntegrationResponse> PostAsync(InitIntegrationPostRequestBody body, Action<InitIntegrationRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<InitIntegrationResponse>(requestInfo, InitIntegrationResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Init Integration
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(InitIntegrationPostRequestBody body, Action<InitIntegrationRequestBuilderPostRequestConfiguration>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(InitIntegrationPostRequestBody body, Action<InitIntegrationRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation
            {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null)
            {
                var requestConfig = new InitIntegrationRequestBuilderPostRequestConfiguration();
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
        public InitIntegrationRequestBuilder WithUrl(string rawUrl)
        {
            return new InitIntegrationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InitIntegrationRequestBuilderPostRequestConfiguration
        {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new initIntegrationRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public InitIntegrationRequestBuilderPostRequestConfiguration()
            {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
