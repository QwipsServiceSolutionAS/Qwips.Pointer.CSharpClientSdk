// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SignableDocuments.Item;
using Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SignableDocuments.WithSignKeyDecision;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.Pointer.XrmDb.V1beta1.Tenants.Item.Public.SignableDocuments {
    /// <summary>
    /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\public\signableDocuments
    /// </summary>
    public class SignableDocumentsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.Pointer.xrmDb.v1beta1.tenants.item.public.signableDocuments.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithSignKeyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("signKey", position);
            return new WithSignKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SignableDocumentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignableDocumentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/public/signableDocuments", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SignableDocumentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignableDocumentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/xrm-db/v1beta1/tenants/{tenantId}/public/signableDocuments", rawUrl) {
        }
        /// <summary>
        /// Builds and executes requests for operations under \xrm-db\v1beta1\tenants\{tenantId}\public\signableDocuments\{signKey}:decision
        /// </summary>
        public WithSignKeyDecisionRequestBuilder WithSignKeyDecision(string signKey) {
            if(string.IsNullOrEmpty(signKey)) throw new ArgumentNullException(nameof(signKey));
            return new WithSignKeyDecisionRequestBuilder(PathParameters, RequestAdapter, signKey);
        }
    }
}
