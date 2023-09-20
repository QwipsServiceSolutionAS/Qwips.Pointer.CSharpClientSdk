// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.Models; 
 using Qwips.Core.PointerClientSdk.ErrorHandling;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.SalesBudgetEntries.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.SalesBudgetEntries {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\salesBudgetEntries
    /// </summary>
    public class SalesBudgetEntriesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.Pointer.xrmDb.v1beta1.tenants.item.salesBudgetEntries.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithRowItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("rowId", position);
            return new WithRowItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SalesBudgetEntriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesBudgetEntriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/salesBudgetEntries{?q*,qf*,offset*,limit*,orderBy*,pageToken*,totalSizeMax*,includeArchived*,includeAggs*,frowrels*,includeFk*,streaming*,useEm*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SalesBudgetEntriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesBudgetEntriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/salesBudgetEntries{?q*,qf*,offset*,limit*,orderBy*,pageToken*,totalSizeMax*,includeArchived*,includeAggs*,frowrels*,includeFk*,streaming*,useEm*}", rawUrl) {
        }
        /// <summary>
        /// List Sales Budget Entries
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InlineResponse20022?> GetAsync(Action<SalesBudgetEntriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse20022> GetAsync(Action<SalesBudgetEntriesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<InlineResponse20022>(requestInfo, InlineResponse20022.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Create Sales Budget Entry
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProductUpdateResponse?> PostAsync(Body15 body, Action<SalesBudgetEntriesRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse2005> PostAsync(Body15 body, Action<SalesBudgetEntriesRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ProductUpdateResponse>(requestInfo, ProductUpdateResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// List Sales Budget Entries
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SalesBudgetEntriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SalesBudgetEntriesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            if (requestConfiguration != null) {
                var requestConfig = new SalesBudgetEntriesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create Sales Budget Entry
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Body15 body, Action<SalesBudgetEntriesRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Body15 body, Action<SalesBudgetEntriesRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SalesBudgetEntriesRequestBuilderPostRequestConfiguration();
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
        public SalesBudgetEntriesRequestBuilder WithUrl(string rawUrl) {
            return new SalesBudgetEntriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List Sales Budget Entries
        /// </summary>
        public class SalesBudgetEntriesRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Frowrels { get; set; }
#nullable restore
#else
            public string Frowrels { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? IncludeAggs { get; set; }
#nullable restore
#else
            public string IncludeAggs { get; set; }
#endif
            public bool? IncludeArchived { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? IncludeFk { get; set; }
#nullable restore
#else
            public string IncludeFk { get; set; }
#endif
            public int? Limit { get; set; }
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? OrderBy { get; set; }
#nullable restore
#else
            public string OrderBy { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? PageToken { get; set; }
#nullable restore
#else
            public string PageToken { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Q { get; set; }
#nullable restore
#else
            public string Q { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Qf { get; set; }
#nullable restore
#else
            public string Qf { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Streaming { get; set; }
#nullable restore
#else
            public string Streaming { get; set; }
#endif
            public int? TotalSizeMax { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UseEm { get; set; }
#nullable restore
#else
            public string UseEm { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SalesBudgetEntriesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SalesBudgetEntriesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SalesBudgetEntriesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new salesBudgetEntriesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SalesBudgetEntriesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SalesBudgetEntriesRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new salesBudgetEntriesRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public SalesBudgetEntriesRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
