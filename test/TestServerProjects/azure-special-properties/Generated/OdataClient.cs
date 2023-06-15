// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    /// <summary> The Odata service client. </summary>
    public partial class OdataClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OdataRestClient RestClient { get; }

        /// <summary> Initializes a new instance of OdataClient for mocking. </summary>
        protected OdataClient()
        {
        }

        /// <summary> Initializes a new instance of OdataClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal OdataClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new OdataRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'. </summary>
        /// <param name="filter"> The filter parameter with value '$filter=id gt 5 and name eq 'foo''. </param>
        /// <param name="top"> The top parameter with value 10. </param>
        /// <param name="orderby"> The orderby parameter with value id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetWithFilterAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OdataClient.GetWithFilter");
            scope.Start();
            try
            {
                return await RestClient.GetWithFilterAsync(filter, top, orderby, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'. </summary>
        /// <param name="filter"> The filter parameter with value '$filter=id gt 5 and name eq 'foo''. </param>
        /// <param name="top"> The top parameter with value 10. </param>
        /// <param name="orderby"> The orderby parameter with value id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetWithFilter(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OdataClient.GetWithFilter");
            scope.Start();
            try
            {
                return RestClient.GetWithFilter(filter, top, orderby, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
