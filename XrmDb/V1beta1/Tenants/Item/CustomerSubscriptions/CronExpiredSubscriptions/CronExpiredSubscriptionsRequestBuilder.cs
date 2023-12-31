// <auto-generated/>

using Microsoft.Kiota.Abstractions;
using Qwips.Core.PointerClientSdk.ErrorHandling;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.CronExpiredSubscriptions
{
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\customerSubscriptions\cron:expiredSubscriptions
    /// </summary>
    public class CronExpiredSubscriptionsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CronExpiredSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CronExpiredSubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions/cron:expiredSubscriptions", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CronExpiredSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CronExpiredSubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions/cron:expiredSubscriptions", rawUrl) {
        }
        /// <summary>
        /// Go through subscriptions and updates statuses if expired
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CronExpiredSubscriptionsResponse?> PostAsync(CronExpiredSubscriptionsPostRequestBody body, Action<CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CronExpiredSubscriptionsResponse> PostAsync(CronExpiredSubscriptionsPostRequestBody body, Action<CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<CronExpiredSubscriptionsResponse>(requestInfo, CronExpiredSubscriptionsResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Go through subscriptions and updates statuses if expired
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CronExpiredSubscriptionsPostRequestBody body, Action<CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CronExpiredSubscriptionsPostRequestBody body, Action<CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration();
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
        public CronExpiredSubscriptionsRequestBuilder WithUrl(string rawUrl) {
            return new CronExpiredSubscriptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new cronExpiredSubscriptionsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public CronExpiredSubscriptionsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
