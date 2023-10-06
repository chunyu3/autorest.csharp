// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ServiceModel.Rest.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateTranscriptionRequest. </summary>
    public partial class CreateTranscriptionRequest
    {
        /// <summary> Initializes a new instance of CreateTranscriptionRequest. </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4,
        /// mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="model"> ID of the model to use. Only `whisper-1` is currently available. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public CreateTranscriptionRequest(BinaryData file, CreateTranscriptionRequestModel model)
        {
            ClientUtilities.AssertNotNull(file, nameof(file));

            File = file;
            Model = model;
        }

        /// <summary> Initializes a new instance of CreateTranscriptionRequest. </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4,
        /// mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="model"> ID of the model to use. Only `whisper-1` is currently available. </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The
        /// [prompt](/docs/guides/speech-to-text/prompting) should match the audio language.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the transcript output, in one of these options: json, text, srt, verbose_json, or
        /// vtt.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more
        /// random, while lower values like 0.2 will make it more focused and deterministic. If set to 0,
        /// the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to
        /// automatically increase the temperature until certain thresholds are hit.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy
        /// and latency.
        /// </param>
        internal CreateTranscriptionRequest(BinaryData file, CreateTranscriptionRequestModel model, string prompt, CreateTranscriptionRequestResponseFormat? responseFormat, double? temperature, string language)
        {
            File = file;
            Model = model;
            Prompt = prompt;
            ResponseFormat = responseFormat;
            Temperature = temperature;
            Language = language;
        }

        /// <summary>
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4,
        /// mpeg, mpga, m4a, ogg, wav, or webm.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData File { get; }
        /// <summary> ID of the model to use. Only `whisper-1` is currently available. </summary>
        public CreateTranscriptionRequestModel Model { get; }
        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio segment. The
        /// [prompt](/docs/guides/speech-to-text/prompting) should match the audio language.
        /// </summary>
        public string Prompt { get; set; }
        /// <summary>
        /// The format of the transcript output, in one of these options: json, text, srt, verbose_json, or
        /// vtt.
        /// </summary>
        public CreateTranscriptionRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more
        /// random, while lower values like 0.2 will make it more focused and deterministic. If set to 0,
        /// the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to
        /// automatically increase the temperature until certain thresholds are hit.
        /// </summary>
        public double? Temperature { get; set; }
        /// <summary>
        /// The language of the input audio. Supplying the input language in
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy
        /// and latency.
        /// </summary>
        public string Language { get; set; }
    }
}
