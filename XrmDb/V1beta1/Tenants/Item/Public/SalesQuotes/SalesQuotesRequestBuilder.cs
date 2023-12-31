// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SalesQuotes.Item;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SalesQuotes.WithSignKeyDecision;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SalesQuotes {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\public\salesQuotes
    /// </summary>
    public class SalesQuotesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.Pointer.xrmDb.v1beta1.tenants.item.public.salesQuotes.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithSignKeyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("signKey", position);
            return new WithSignKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SalesQuotesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesQuotesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/public/salesQuotes", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SalesQuotesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesQuotesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/public/salesQuotes", rawUrl) {
        }
        /// <summary>
        /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\public\salesQuotes\{signKey}:decision
        /// </summary>
        public WithSignKeyDecisionRequestBuilder WithSignKeyDecision(string signKey) {
            if(string.IsNullOrEmpty(signKey)) throw new ArgumentNullException(nameof(signKey));
            return new WithSignKeyDecisionRequestBuilder(PathParameters, RequestAdapter, signKey);
        }
    }
}
