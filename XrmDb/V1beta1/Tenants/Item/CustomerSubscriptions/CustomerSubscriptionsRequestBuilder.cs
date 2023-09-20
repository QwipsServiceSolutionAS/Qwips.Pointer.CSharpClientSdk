// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.Models; 
 using Qwips.Core.PointerClientSdk.ErrorHandling;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.CronExpiredSubscriptions;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.Item;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.TestQueue;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions.WithRowIdMakeSalesOrder;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.CustomerSubscriptions {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\customerSubscriptions
    /// </summary>
    public class CustomerSubscriptionsRequestBuilder : BaseRequestBuilder {
        /// <summary>The cronExpiredSubscriptions property</summary>
        public CronExpiredSubscriptionsRequestBuilder CronExpiredSubscriptions { get =>
            new CronExpiredSubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TestQueue property</summary>
        public TestQueueRequestBuilder TestQueue { get =>
            new TestQueueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.Core.Pointer.xrmDb.v1beta1.tenants.item.customerSubscriptions.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithRowItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("rowId", position);
            return new WithRowItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CustomerSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerSubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions{?q*,qf*,offset*,limit*,orderBy*,pageToken*,totalSizeMax*,includeArchived*,includeAggs*,frowrels*,includeFk*,streaming*,useEm*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CustomerSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerSubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/customerSubscriptions{?q*,qf*,offset*,limit*,orderBy*,pageToken*,totalSizeMax*,includeArchived*,includeAggs*,frowrels*,includeFk*,streaming*,useEm*}", rawUrl) {
        }
        /// <summary>
        /// List Customer Subscriptions
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InlineResponse20016?> GetAsync(Action<CustomerSubscriptionsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse20016> GetAsync(Action<CustomerSubscriptionsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<InlineResponse20016>(requestInfo, InlineResponse20016.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Create Customer Subscription
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProductUpdateResponse?> PostAsync(Body9 body, Action<CustomerSubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InlineResponse2005> PostAsync(Body9 body, Action<CustomerSubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ProductUpdateResponse>(requestInfo, ProductUpdateResponse.CreateFromDiscriminatorValue, PointerErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// List Customer Subscriptions
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CustomerSubscriptionsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CustomerSubscriptionsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            if (requestConfiguration != null) {
                var requestConfig = new CustomerSubscriptionsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create Customer Subscription
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Body9 body, Action<CustomerSubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Body9 body, Action<CustomerSubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CustomerSubscriptionsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\customerSubscriptions\{rowId}:makeSalesOrder
        /// </summary>
        public WithRowIdMakeSalesOrderRequestBuilder WithRowIdMakeSalesOrder(string rowId) {
            if(string.IsNullOrEmpty(rowId)) throw new ArgumentNullException(nameof(rowId));
            return new WithRowIdMakeSalesOrderRequestBuilder(PathParameters, RequestAdapter, rowId);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CustomerSubscriptionsRequestBuilder WithUrl(string rawUrl) {
            return new CustomerSubscriptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List Customer Subscriptions
        /// </summary>
        public class CustomerSubscriptionsRequestBuilderGetQueryParameters {
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
        public class CustomerSubscriptionsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CustomerSubscriptionsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CustomerSubscriptionsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new customerSubscriptionsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CustomerSubscriptionsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CustomerSubscriptionsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new customerSubscriptionsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public CustomerSubscriptionsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
