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
using Projection.ProjectedName.Models;

namespace Projection.ProjectedName
{
    // Data plane generated sub-client.
    /// <summary> The Property sub-client. </summary>
    public partial class Property
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Property for mocking. </summary>
        protected Property()
        {
        }

        /// <summary> Initializes a new instance of Property. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. The default is "http://localhost:3000". </param>
        /// <param name="apiVersion"> The String to use. The default is "1.0.0". </param>
        internal Property(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <param name="jsonProjectedNameModel"> The JsonProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jsonProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAsync(JsonProjectedNameModel,CancellationToken)']/*" />
        public virtual async Task<Response> JsonAsync(JsonProjectedNameModel jsonProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(jsonProjectedNameModel, nameof(jsonProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await JsonAsync(jsonProjectedNameModel.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="jsonProjectedNameModel"> The JsonProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jsonProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Json(JsonProjectedNameModel,CancellationToken)']/*" />
        public virtual Response Json(JsonProjectedNameModel jsonProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(jsonProjectedNameModel, nameof(jsonProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Json(jsonProjectedNameModel.ToRequestContent(), context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="JsonAsync(JsonProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> JsonAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Json");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Json(JsonProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Json(RequestContent,RequestContext)']/*" />
        public virtual Response Json(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Json");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="clientProjectedNameModel"> The ClientProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='ClientAsync(ClientProjectedNameModel,CancellationToken)']/*" />
        public virtual async Task<Response> ClientAsync(ClientProjectedNameModel clientProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(clientProjectedNameModel, nameof(clientProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await ClientAsync(clientProjectedNameModel.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="clientProjectedNameModel"> The ClientProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Client(ClientProjectedNameModel,CancellationToken)']/*" />
        public virtual Response Client(ClientProjectedNameModel clientProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(clientProjectedNameModel, nameof(clientProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Client(clientProjectedNameModel.ToRequestContent(), context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ClientAsync(ClientProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='ClientAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> ClientAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Client");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClientRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Client(ClientProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Client(RequestContent,RequestContext)']/*" />
        public virtual Response Client(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Client");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClientRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="languageProjectedNameModel"> The LanguageProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="languageProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='LanguageAsync(LanguageProjectedNameModel,CancellationToken)']/*" />
        public virtual async Task<Response> LanguageAsync(LanguageProjectedNameModel languageProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(languageProjectedNameModel, nameof(languageProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await LanguageAsync(languageProjectedNameModel.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="languageProjectedNameModel"> The LanguageProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="languageProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Language(LanguageProjectedNameModel,CancellationToken)']/*" />
        public virtual Response Language(LanguageProjectedNameModel languageProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(languageProjectedNameModel, nameof(languageProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Language(languageProjectedNameModel.ToRequestContent(), context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="LanguageAsync(LanguageProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='LanguageAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> LanguageAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Language");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLanguageRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Language(LanguageProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='Language(RequestContent,RequestContext)']/*" />
        public virtual Response Language(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.Language");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLanguageRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="jsonAndClientProjectedNameModel"> The JsonAndClientProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jsonAndClientProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAndClientAsync(JsonAndClientProjectedNameModel,CancellationToken)']/*" />
        public virtual async Task<Response> JsonAndClientAsync(JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(jsonAndClientProjectedNameModel, nameof(jsonAndClientProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await JsonAndClientAsync(jsonAndClientProjectedNameModel.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="jsonAndClientProjectedNameModel"> The JsonAndClientProjectedNameModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jsonAndClientProjectedNameModel"/> is null. </exception>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAndClient(JsonAndClientProjectedNameModel,CancellationToken)']/*" />
        public virtual Response JsonAndClient(JsonAndClientProjectedNameModel jsonAndClientProjectedNameModel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(jsonAndClientProjectedNameModel, nameof(jsonAndClientProjectedNameModel));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = JsonAndClient(jsonAndClientProjectedNameModel.ToRequestContent(), context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="JsonAndClientAsync(JsonAndClientProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAndClientAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> JsonAndClientAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.JsonAndClient");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonAndClientRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="JsonAndClient(JsonAndClientProjectedNameModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Property.xml" path="doc/members/member[@name='JsonAndClient(RequestContent,RequestContext)']/*" />
        public virtual Response JsonAndClient(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Property.JsonAndClient");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonAndClientRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateJsonRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/projected-name/property/json", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateClientRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/projected-name/property/client", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateLanguageRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/projected-name/property/language", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateJsonAndClientRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/projected-name/property/json-and-client", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
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

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
