// <auto-generated/>

using Microsoft.Kiota.Abstractions;
using Qwips.Core.PointerClientSdk.ErrorHandling;
namespace Qwips.Core.Pointer.XrmTenants.V1beta1.Tenants.Item.TodoInitTenant
{
    /// <summary>
    /// Builds and executes requests for operations under \xrm-tenants\v1beta1\tenants\{tenantId}\todoInitTenant
    /// </summary>
    public class TodoInitTenantRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new TodoInitTenantRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TodoInitTenantRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-tenants/v1beta1/tenants/{tenantId}/todoInitTenant{?newTenantId*,tenantName*,runAutoUsers*,usersIncludeSA*,runDeleteAllTenantData*,deleteAllTenantDataConfirm*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TodoInitTenantRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TodoInitTenantRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-tenants/v1beta1/tenants/{tenantId}/todoInitTenant{?newTenantId*,tenantName*,runAutoUsers*,usersIncludeSA*,runDeleteAllTenantData*,deleteAllTenantDataConfirm*}", rawUrl) {
        }
        /// <summary>
        /// Init Tenant
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TodoInitTenantResponse?> GetAsync(Action<TodoInitTenantRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TodoInitTenantResponse> GetAsync(Action<TodoInitTenantRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<TodoInitTenantResponse>(requestInfo, TodoInitTenantResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Init Tenant
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<TodoInitTenantRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<TodoInitTenantRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new TodoInitTenantRequestBuilderGetRequestConfiguration();
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
        public TodoInitTenantRequestBuilder WithUrl(string rawUrl) {
            return new TodoInitTenantRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Init Tenant
        /// </summary>
        public class TodoInitTenantRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? DeleteAllTenantDataConfirm { get; set; }
#nullable restore
#else
            public string DeleteAllTenantDataConfirm { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? NewTenantId { get; set; }
#nullable restore
#else
            public string NewTenantId { get; set; }
#endif
            public bool? RunAutoUsers { get; set; }
            /// <summary>DANGER ZONE! BE CAREFUL!</summary>
            public bool? RunDeleteAllTenantData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? TenantName { get; set; }
#nullable restore
#else
            public string TenantName { get; set; }
#endif
            /// <summary>Add service account to tenantUsers if runAutoUsers is true</summary>
            public bool? UsersIncludeSA { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TodoInitTenantRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public TodoInitTenantRequestBuilderGetQueryParameters QueryParameters { get; set; } = new TodoInitTenantRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new todoInitTenantRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public TodoInitTenantRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
