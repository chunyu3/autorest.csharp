// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace dpg_update1_LowLevel
{
    // Data plane generated client.
    /// <summary> The Params service client. </summary>
    public partial class ParamsClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ParamsClient for mocking. </summary>
        protected ParamsClient()
        {
        }

        /// <summary> Initializes a new instance of ParamsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public ParamsClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new ParamsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ParamsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public ParamsClient(AzureKeyCredential credential, Uri endpoint, ParamsClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ParamsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary>
        /// [Protocol Method] Head request, no params. Initially has no query parameters. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='HeadNoParamsAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> HeadNoParamsAsync(string newParameter = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.HeadNoParams");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHeadNoParamsRequest(newParameter, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Head request, no params. Initially has no query parameters. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='HeadNoParams(string,RequestContext)']/*" />
        public virtual Response HeadNoParams(string newParameter = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.HeadNoParams");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHeadNoParamsRequest(newParameter, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get true Boolean value on path.
        ///  Initially only has one required Query Parameter. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parameter"> I am a required parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetRequiredAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> GetRequiredAsync(string parameter, string newParameter = null, RequestContext context = null)
        {
            Argument.AssertNotNull(parameter, nameof(parameter));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetRequired");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetRequiredRequest(parameter, newParameter, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get true Boolean value on path.
        ///  Initially only has one required Query Parameter. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parameter"> I am a required parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetRequired(string,string,RequestContext)']/*" />
        public virtual Response GetRequired(string parameter, string newParameter = null, RequestContext context = null)
        {
            Argument.AssertNotNull(parameter, nameof(parameter));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetRequired");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetRequiredRequest(parameter, newParameter, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Initially has one required query parameter and one optional query parameter.  After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requiredParam"> I am a required parameter. </param>
        /// <param name="optionalParam"> I am an optional parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='PutRequiredOptionalAsync(string,string,string,RequestContext)']/*" />
        public virtual async Task<Response> PutRequiredOptionalAsync(string requiredParam, string optionalParam = null, string newParameter = null, RequestContext context = null)
        {
            Argument.AssertNotNull(requiredParam, nameof(requiredParam));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.PutRequiredOptional");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequiredOptionalRequest(requiredParam, optionalParam, newParameter, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Initially has one required query parameter and one optional query parameter.  After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requiredParam"> I am a required parameter. </param>
        /// <param name="optionalParam"> I am an optional parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='PutRequiredOptional(string,string,string,RequestContext)']/*" />
        public virtual Response PutRequiredOptional(string requiredParam, string optionalParam = null, string newParameter = null, RequestContext context = null)
        {
            Argument.AssertNotNull(requiredParam, nameof(requiredParam));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.PutRequiredOptional");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequiredOptionalRequest(requiredParam, optionalParam, newParameter, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] POST a JSON or a JPEG
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Body Parameter content-type. Allowed values: "application/json" | "image/jpeg". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='PostParametersAsync(RequestContent,ContentType,RequestContext)']/*" />
        public virtual async Task<Response> PostParametersAsync(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.PostParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostParametersRequest(content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] POST a JSON or a JPEG
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Body Parameter content-type. Allowed values: "application/json" | "image/jpeg". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='PostParameters(RequestContent,ContentType,RequestContext)']/*" />
        public virtual Response PostParameters(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ParamsClient.PostParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostParametersRequest(content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Delete something.
        ///  Initially the path exists but there is no delete method. After evolution this is a new method in a known path
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='DeleteParametersAsync(RequestContext)']/*" />
        public virtual async Task<Response> DeleteParametersAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.DeleteParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteParametersRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Delete something.
        ///  Initially the path exists but there is no delete method. After evolution this is a new method in a known path
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='DeleteParameters(RequestContext)']/*" />
        public virtual Response DeleteParameters(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.DeleteParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteParametersRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get true Boolean value on path.
        ///  Initially has one optional query parameter. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="optionalParam"> I am an optional parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetOptionalAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> GetOptionalAsync(string optionalParam = null, string newParameter = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetOptional");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOptionalRequest(optionalParam, newParameter, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get true Boolean value on path.
        ///  Initially has one optional query parameter. After evolution, a new optional query parameter is added
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="optionalParam"> I am an optional parameter. </param>
        /// <param name="newParameter"> I'm a new input optional parameter. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetOptional(string,string,RequestContext)']/*" />
        public virtual Response GetOptional(string optionalParam = null, string newParameter = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetOptional");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOptionalRequest(optionalParam, newParameter, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] I'm a new operation.
        ///  Initiallty neither path or method exist for this operation. After evolution, this is a new method in a new path
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetNewOperationAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetNewOperationAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetNewOperation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNewOperationRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] I'm a new operation.
        ///  Initiallty neither path or method exist for this operation. After evolution, this is a new method in a new path
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ParamsClient.xml" path="doc/members/member[@name='GetNewOperation(RequestContext)']/*" />
        public virtual Response GetNewOperation(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ParamsClient.GetNewOperation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNewOperationRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateHeadNoParamsRequest(string newParameter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/parameters", false);
            if (newParameter != null)
            {
                uri.AppendQuery("new_parameter", newParameter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetRequiredRequest(string parameter, string newParameter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/parameters", false);
            uri.AppendQuery("parameter", parameter, true);
            if (newParameter != null)
            {
                uri.AppendQuery("new_parameter", newParameter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutRequiredOptionalRequest(string requiredParam, string optionalParam, string newParameter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/parameters", false);
            uri.AppendQuery("requiredParam", requiredParam, true);
            if (optionalParam != null)
            {
                uri.AppendQuery("optionalParam", optionalParam, true);
            }
            if (newParameter != null)
            {
                uri.AppendQuery("new_parameter", newParameter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePostParametersRequest(RequestContent content, ContentType contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/parameters", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteParametersRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/parameters", false);
            request.Uri = uri;
            return message;
        }

        internal HttpMessage CreateGetOptionalRequest(string optionalParam, string newParameter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/moreParameters", false);
            if (optionalParam != null)
            {
                uri.AppendQuery("optionalParam", optionalParam, true);
            }
            if (newParameter != null)
            {
                uri.AppendQuery("new_parameter", newParameter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetNewOperationRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serviceDriven/newPath", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
