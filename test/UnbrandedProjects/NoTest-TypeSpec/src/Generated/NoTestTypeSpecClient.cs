// <auto-generated/>

#nullable disable

using System;
using System.ServiceModel.Rest;
using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Core.Pipeline;
using System.ServiceModel.Rest.Internal;
using System.Threading;
using System.Threading.Tasks;
using NoTestTypeSpec.Models;

namespace NoTestTypeSpec
{
    // Data plane generated client.
    /// <summary> This is a sample typespec project. </summary>
    public partial class NoTestTypeSpecClient
    {
        private const string AuthorizationHeader = "my-api-key";
        private readonly KeyCredential _keyCredential;
        private readonly MessagePipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal TelemetrySource ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual MessagePipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of NoTestTypeSpecClient for mocking. </summary>
        protected NoTestTypeSpecClient()
        {
        }

        /// <summary> Initializes a new instance of NoTestTypeSpecClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public NoTestTypeSpecClient(Uri endpoint, KeyCredential credential) : this(endpoint, credential, new NoTestTypeSpecClientOptions())
        {
        }

        /// <summary> Initializes a new instance of NoTestTypeSpecClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public NoTestTypeSpecClient(Uri endpoint, KeyCredential credential, NoTestTypeSpecClientOptions options)
        {
            ClientUtilities.AssertNotNull(endpoint, nameof(endpoint));
            ClientUtilities.AssertNotNull(credential, nameof(credential));
            options ??= new NoTestTypeSpecClientOptions();

            ClientDiagnostics = new TelemetrySource(options, true);
            _keyCredential = credential;
            _pipeline = MessagePipeline.Create(options, new IPipelinePolicy<PipelineMessage>[] { new KeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, Array.Empty<IPipelinePolicy<PipelineMessage>>());
            _endpoint = endpoint;
        }

        /// <summary> Return hi. </summary>
        /// <param name="headParameter"> The String to use. </param>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="optionalQuery"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        public virtual async Task<Result<Thing>> SayHiAsync(string headParameter, string queryParameter, string optionalQuery = null, CancellationToken cancellationToken = default)
        {
            ClientUtilities.AssertNotNull(headParameter, nameof(headParameter));
            ClientUtilities.AssertNotNull(queryParameter, nameof(queryParameter));

            RequestOptions context = FromCancellationToken(cancellationToken);
            Result result = await SayHiAsync(headParameter, queryParameter, optionalQuery, context).ConfigureAwait(false);
            return Result.FromValue(Thing.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Return hi. </summary>
        /// <param name="headParameter"> The String to use. </param>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="optionalQuery"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        public virtual Result<Thing> SayHi(string headParameter, string queryParameter, string optionalQuery = null, CancellationToken cancellationToken = default)
        {
            ClientUtilities.AssertNotNull(headParameter, nameof(headParameter));
            ClientUtilities.AssertNotNull(queryParameter, nameof(queryParameter));

            RequestOptions context = FromCancellationToken(cancellationToken);
            Result result = SayHi(headParameter, queryParameter, optionalQuery, context);
            return Result.FromValue(Thing.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Return hi
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SayHiAsync(string,string,string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="headParameter"> The String to use. </param>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="optionalQuery"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        /// <exception cref="RequestErrorException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Result> SayHiAsync(string headParameter, string queryParameter, string optionalQuery, RequestOptions context)
        {
            ClientUtilities.AssertNotNull(headParameter, nameof(headParameter));
            ClientUtilities.AssertNotNull(queryParameter, nameof(queryParameter));

            using var scope = ClientDiagnostics.CreateSpan("NoTestTypeSpecClient.SayHi");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateSayHiRequest(headParameter, queryParameter, optionalQuery, context);
                return Result.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Return hi
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="SayHi(string,string,string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="headParameter"> The String to use. </param>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="optionalQuery"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        /// <exception cref="RequestErrorException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Result SayHi(string headParameter, string queryParameter, string optionalQuery, RequestOptions context)
        {
            ClientUtilities.AssertNotNull(headParameter, nameof(headParameter));
            ClientUtilities.AssertNotNull(queryParameter, nameof(queryParameter));

            using var scope = ClientDiagnostics.CreateSpan("NoTestTypeSpecClient.SayHi");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateSayHiRequest(headParameter, queryParameter, optionalQuery, context);
                return Result.FromResponse(_pipeline.ProcessMessage(message, context));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal PipelineMessage CreateSayHiRequest(string headParameter, string queryParameter, string optionalQuery, RequestOptions context)
        {
            var message = _pipeline.CreateMessage(context, ResponseErrorClassifier200);
            var request = message.Request;
            request.SetMethod("GET");
            var uri = new RequestUri();
            uri.Reset(_endpoint);
            uri.AppendPath("/hello", false);
            uri.AppendQuery("queryParameter", queryParameter, true);
            if (optionalQuery != null)
            {
                uri.AppendQuery("optionalQuery", optionalQuery, true);
            }
            request.Uri = uri.ToUri();
            request.SetHeaderValue("head-parameter", headParameter);
            request.SetHeaderValue("Accept", "application/json");
            return message;
        }

        private static RequestOptions DefaultRequestContext = new RequestOptions();
        internal static RequestOptions FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestOptions() { CancellationToken = cancellationToken };
        }

        private static ResponseErrorClassifier _responseErrorClassifier200;
        private static ResponseErrorClassifier ResponseErrorClassifier200 => _responseErrorClassifier200 ??= new StatusResponseClassifier(stackalloc ushort[] { 200 });
    }
}
