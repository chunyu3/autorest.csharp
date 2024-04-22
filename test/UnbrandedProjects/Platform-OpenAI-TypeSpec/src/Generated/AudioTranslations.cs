// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The AudioTranslations sub-client. </summary>
    public partial class AudioTranslations
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AudioTranslations for mocking. </summary>
        protected AudioTranslations()
        {
        }

        /// <summary> Initializes a new instance of AudioTranslations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal AudioTranslations(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        /// <remarks> Create. </remarks>
        public virtual async Task<ClientResult<CreateTranslationResponse>> CreateAsync(CreateTranslationRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartBinaryBody();
            ClientResult result = await CreateAsync(content, content.ContentType, null).ConfigureAwait(false);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        /// <remarks> Create. </remarks>
        public virtual ClientResult<CreateTranslationResponse> Create(CreateTranslationRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartBinaryBody();
            ClientResult result = Create(content, content.ContentType, null);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateAsync(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, contentType, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Create(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, contentType, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateCreateRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/audio/translations", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", contentType);
            request.Content = content;
            if (options != null)
            {
                message.Apply(options);
            }
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
