// <auto-generated/>

#nullable disable

using System;
using System.ServiceModel.Rest.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateEmbeddingRequest. </summary>
    public partial class CreateEmbeddingRequest
    {
        /// <summary> Initializes a new instance of CreateEmbeddingRequest. </summary>
        /// <param name="model"> ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </param>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a
        /// single request, pass an array of strings or array of token arrays. Each input must not exceed
        /// the max input tokens for the model (8191 tokens for `text-embedding-ada-002`) and cannot be an empty string.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public CreateEmbeddingRequest(CreateEmbeddingRequestModel model, BinaryData input)
        {
            ClientUtilities.AssertNotNull(input, nameof(input));

            Model = model;
            Input = input;
        }

        /// <summary> Initializes a new instance of CreateEmbeddingRequest. </summary>
        /// <param name="model"> ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </param>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a
        /// single request, pass an array of strings or array of token arrays. Each input must not exceed
        /// the max input tokens for the model (8191 tokens for `text-embedding-ada-002`) and cannot be an empty string.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </param>
        /// <param name="user"></param>
        internal CreateEmbeddingRequest(CreateEmbeddingRequestModel model, BinaryData input, string user)
        {
            Model = model;
            Input = input;
            User = user;
        }

        /// <summary> ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </summary>
        public CreateEmbeddingRequestModel Model { get; }
        /// <summary>
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a
        /// single request, pass an array of strings or array of token arrays. Each input must not exceed
        /// the max input tokens for the model (8191 tokens for `text-embedding-ada-002`) and cannot be an empty string.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Input { get; }
        /// <summary> Gets or sets the user. </summary>
        public string User { get; set; }
    }
}
