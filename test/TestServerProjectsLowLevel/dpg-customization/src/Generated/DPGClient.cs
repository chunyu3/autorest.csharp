// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace dpg_customization_LowLevel
{
    // Data plane generated client.
    /// <summary> The DPG service client. </summary>
    public partial class DPGClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DPGClient for mocking. </summary>
        protected DPGClient()
        {
        }

        /// <summary> Initializes a new instance of DPGClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public DPGClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new DPGClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DPGClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public DPGClient(AzureKeyCredential credential, Uri endpoint, DPGClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new DPGClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary>
        /// [Protocol Method] Get models that you will either return to end users as a raw body, or with a model added during grow up.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='GetModelAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetModelAsync(string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.GetModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelRequest(mode, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get models that you will either return to end users as a raw body, or with a model added during grow up.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='GetModel(string,RequestContext)']/*" />
        public virtual Response GetModel(string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.GetModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelRequest(mode, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Post either raw response as a model and pass in &apos;raw&apos; for mode, or grow up your operation to take a model instead, and put in &apos;model&apos; as mode. 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='PostModelAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> PostModelAsync(string mode, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.PostModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostModelRequest(mode, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Post either raw response as a model and pass in &apos;raw&apos; for mode, or grow up your operation to take a model instead, and put in &apos;model&apos; as mode. 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='PostModel(string,RequestContent,RequestContext)']/*" />
        public virtual Response PostModel(string mode, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.PostModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostModelRequest(mode, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get pages that you will either return to users in pages of raw bodies, or pages of models following growup.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='GetPagesAsync(string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetPagesAsync(string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetPagesRequest(mode, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetPagesNextPageRequest(nextLink, mode, context);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "DPGClient.GetPages", "values", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Get pages that you will either return to users in pages of raw bodies, or pages of models following growup.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='GetPages(string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetPages(string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetPagesRequest(mode, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetPagesNextPageRequest(nextLink, mode, context);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "DPGClient.GetPages", "values", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Long running put request that will either return to end users a final payload of a raw body, or a final payload of a model after the SDK has grown up.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='LroAsync(WaitUntil,string,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> LroAsync(WaitUntil waitUntil, string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.Lro");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLroRequest(mode, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "DPGClient.Lro", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Long running put request that will either return to end users a final payload of a raw body, or a final payload of a model after the SDK has grown up.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mode"> The mode with which you&apos;ll be handling your returned body. &apos;raw&apos; for just dealing with the raw body, and &apos;model&apos; if you are going to convert the raw body to a customized body before returning to users. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DPGClient.xml" path="doc/members/member[@name='Lro(WaitUntil,string,RequestContext)']/*" />
        public virtual Operation<BinaryData> Lro(WaitUntil waitUntil, string mode, RequestContext context = null)
        {
            Argument.AssertNotNull(mode, nameof(mode));

            using var scope = ClientDiagnostics.CreateScope("DPGClient.Lro");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLroRequest(mode, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "DPGClient.Lro", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetModelRequest(string mode, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/customization/model/", false);
            uri.AppendPath(mode, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePostModelRequest(string mode, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/customization/model/", false);
            uri.AppendPath(mode, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetPagesRequest(string mode, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/customization/paging/", false);
            uri.AppendPath(mode, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateLroRequest(string mode, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/customization/lro/", false);
            uri.AppendPath(mode, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPagesNextPageRequest(string nextLink, string mode, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
