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
namespace Qwips.Core.Pointer.XrmUsers.V1.UserAccounts.WithEmailSetPassword {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-users\v1\userAccounts\{email}:setPassword
    /// </summary>
    public class WithEmailSetPasswordRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithEmailSetPasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEmailSetPasswordRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string email = "") : base(requestAdapter, "{+baseurl}/xrm-users/v1/userAccounts/{email}:setPassword{?createMissing*,emailNotVerified*}", pathParameters) {
            if (!string.IsNullOrWhiteSpace(email)) PathParameters.Add("email", email);
        }
        /// <summary>
        /// Instantiates a new WithEmailSetPasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEmailSetPasswordRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-users/v1/userAccounts/{email}:setPassword{?createMissing*,emailNotVerified*}", rawUrl) {
        }
        /// <summary>
        /// Set password
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithEmailSetPasswordResponse?> PostAsync(Body116 body, Action<WithEmailSetPasswordRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithEmailSetPasswordResponse> PostAsync(Body116 body, Action<WithEmailSetPasswordRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<WithEmailSetPasswordResponse>(requestInfo, WithEmailSetPasswordResponse.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Set password
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Body116 body, Action<WithEmailSetPasswordRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Body116 body, Action<WithEmailSetPasswordRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json-patch+json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WithEmailSetPasswordRequestBuilderPostRequestConfiguration();
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
        public WithEmailSetPasswordRequestBuilder WithUrl(string rawUrl) {
            return new WithEmailSetPasswordRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Set password
        /// </summary>
        public class WithEmailSetPasswordRequestBuilderPostQueryParameters {
            public bool? CreateMissing { get; set; }
            public bool? EmailNotVerified { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithEmailSetPasswordRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithEmailSetPasswordRequestBuilderPostQueryParameters QueryParameters { get; set; } = new WithEmailSetPasswordRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new WithEmailSetPasswordRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public WithEmailSetPasswordRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
