// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using azure_special_properties.Models;

namespace azure_special_properties
{
    /// <summary> The Header service client. </summary>
    public partial class HeaderClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal HeaderRestClient RestClient { get; }

        /// <summary> Initializes a new instance of HeaderClient for mocking. </summary>
        protected HeaderClient()
        {
        }

        /// <summary> Initializes a new instance of HeaderClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal HeaderClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new HeaderRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CustomNamedRequestIdAsync(string fooClientRequestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestId");
            scope.Start();
            try
            {
                return (await RestClient.CustomNamedRequestIdAsync(fooClientRequestId, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CustomNamedRequestId(string fooClientRequestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestId");
            scope.Start();
            try
            {
                return RestClient.CustomNamedRequestId(fooClientRequestId, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request, via a parameter group. </summary>
        /// <param name="headerCustomNamedRequestIdParamGroupingParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CustomNamedRequestIdParamGroupingAsync(HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestIdParamGrouping");
            scope.Start();
            try
            {
                return (await RestClient.CustomNamedRequestIdParamGroupingAsync(headerCustomNamedRequestIdParamGroupingParameters, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request, via a parameter group. </summary>
        /// <param name="headerCustomNamedRequestIdParamGroupingParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CustomNamedRequestIdParamGrouping(HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestIdParamGrouping");
            scope.Start();
            try
            {
                return RestClient.CustomNamedRequestIdParamGrouping(headerCustomNamedRequestIdParamGroupingParameters, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CustomNamedRequestIdHeadAsync(string fooClientRequestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestIdHead");
            scope.Start();
            try
            {
                return (await RestClient.CustomNamedRequestIdHeadAsync(fooClientRequestId, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CustomNamedRequestIdHead(string fooClientRequestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HeaderClient.CustomNamedRequestIdHead");
            scope.Start();
            try
            {
                return RestClient.CustomNamedRequestIdHead(fooClientRequestId, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
