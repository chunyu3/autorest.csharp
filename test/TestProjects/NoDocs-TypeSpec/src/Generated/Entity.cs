// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using NoDocsTypeSpec.Models;

namespace NoDocsTypeSpec
{
    // Data plane generated sub-client.
    /// <summary> The Entity sub-client. </summary>
    public partial class Entity
    {
        private const string AuthorizationHeader = "x-ms-api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://api.example.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Entity for mocking. </summary>
        protected Entity()
        {
        }

        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal Entity(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
        }

        /// <summary> doSomething for entity. </summary>
        /// <param name="p2"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="p2"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="p2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/Entity.xml" path="doc/members/member[@name='DoSomethingAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response<Thing>> DoSomethingAsync(string p2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await DoSomethingAsync(p2, context).ConfigureAwait(false);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        /// <summary> doSomething for entity. </summary>
        /// <param name="p2"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="p2"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="p2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/Entity.xml" path="doc/members/member[@name='DoSomething(string,CancellationToken)']/*" />
        public virtual Response<Thing> DoSomething(string p2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = DoSomething(p2, context);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] doSomething for entity
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DoSomethingAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="p2"> The <see cref="string"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="p2"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="p2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Entity.xml" path="doc/members/member[@name='DoSomethingAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> DoSomethingAsync(string p2, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            using var scope = ClientDiagnostics.CreateScope("Entity.DoSomething");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDoSomethingRequest(p2, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] doSomething for entity
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DoSomething(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="p2"> The <see cref="string"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="p2"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="p2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Entity.xml" path="doc/members/member[@name='DoSomething(string,RequestContext)']/*" />
        public virtual Response DoSomething(string p2, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            using var scope = ClientDiagnostics.CreateScope("Entity.DoSomething");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDoSomethingRequest(p2, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateDoSomethingRequest(string p2, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/entity/doSomething/", false);
            uri.AppendPath(p2, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
