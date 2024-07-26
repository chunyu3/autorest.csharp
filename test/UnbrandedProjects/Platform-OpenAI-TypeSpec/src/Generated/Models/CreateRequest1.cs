// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Models
{
    /// <summary> The CreateRequest1. </summary>
    internal partial class CreateRequest1
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/>. </summary>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messages"/> is null. </exception>
        internal CreateRequest1(CreateRequestModel1 model, IEnumerable<ChatCompletionRequestMessage> messages)
        {
            Argument.AssertNotNull(messages, nameof(messages));

            Model = model;
            Messages = messages.ToList();
            Functions = new ChangeTrackingList<ChatCompletionFunctions>();
            LogitBias = new ChangeTrackingDictionary<string, long>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/>. </summary>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
        /// </param>
        /// <param name="functions"> A list of functions the model may generate JSON inputs for. </param>
        /// <param name="functionCall">
        /// Controls how the model responds to function calls. `none` means the model does not call a
        /// function, and responds to the end-user. `auto` means the model can pick between an end-user or
        /// calling a function.  Specifying a particular function via `{\"name":\ \"my_function\"}` forces the
        /// model to call that function. `none` is the default when no functions are present. `auto` is the
        /// default if functions are present.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </param>
        /// <param name="n">
        /// How many completions to generate for each prompt.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of [tokens](/tokenizer) to generate in the completion.
        ///
        /// The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </param>
        /// <param name="stop"> Up to 4 sequences where the API will stop generating further tokens. </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// Accepts a json object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_stream_completions.ipynb).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateRequest1(CreateRequestModel1 model, IReadOnlyList<ChatCompletionRequestMessage> messages, IReadOnlyList<ChatCompletionFunctions> functions, BinaryData functionCall, double? temperature, double? topP, long? n, long? maxTokens, BinaryData stop, double? presencePenalty, double? frequencyPenalty, IReadOnlyDictionary<string, long> logitBias, string user, bool? stream, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Messages = messages;
            Functions = functions;
            FunctionCall = functionCall;
            Temperature = temperature;
            TopP = topP;
            N = n;
            MaxTokens = maxTokens;
            Stop = stop;
            PresencePenalty = presencePenalty;
            FrequencyPenalty = frequencyPenalty;
            LogitBias = logitBias;
            User = user;
            Stream = stream;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/> for deserialization. </summary>
        internal CreateRequest1()
        {
        }

        /// <summary>
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </summary>
        public CreateRequestModel1 Model { get; }
        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
        /// </summary>
        public IReadOnlyList<ChatCompletionRequestMessage> Messages { get; }
        /// <summary> A list of functions the model may generate JSON inputs for. </summary>
        public IReadOnlyList<ChatCompletionFunctions> Functions { get; }
        /// <summary>
        /// Controls how the model responds to function calls. `none` means the model does not call a
        /// function, and responds to the end-user. `auto` means the model can pick between an end-user or
        /// calling a function.  Specifying a particular function via `{\"name":\ \"my_function\"}` forces the
        /// model to call that function. `none` is the default when no functions are present. `auto` is the
        /// default if functions are present.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description>"none"</description>
        /// </item>
        /// <item>
        /// <description>"auto"</description>
        /// </item>
        /// <item>
        /// <description><see cref="ChatCompletionFunctionCallOption"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData FunctionCall { get; }
        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </summary>
        public double? Temperature { get; }
        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </summary>
        public double? TopP { get; }
        /// <summary>
        /// How many completions to generate for each prompt.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </summary>
        public long? N { get; }
        /// <summary>
        /// The maximum number of [tokens](/tokenizer) to generate in the completion.
        ///
        /// The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </summary>
        public long? MaxTokens { get; }
        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="IList{T}"/> where <c>T</c> is of type <see cref="string"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Stop { get; }
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </summary>
        public double? PresencePenalty { get; }
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </summary>
        public double? FrequencyPenalty { get; }
        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// Accepts a json object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </summary>
        public IReadOnlyDictionary<string, long> LogitBias { get; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </summary>
        public string User { get; }
        /// <summary>
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_stream_completions.ipynb).
        /// </summary>
        public bool? Stream { get; }
    }
}