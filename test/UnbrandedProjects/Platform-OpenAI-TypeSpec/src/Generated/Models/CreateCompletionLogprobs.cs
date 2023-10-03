// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Rest.Experimental;

namespace OpenAI.Models
{
    /// <summary> The CreateCompletionLogprobs. </summary>
    public partial class CreateCompletionLogprobs
    {
        /// <summary> Initializes a new instance of CreateCompletionLogprobs. </summary>
        /// <param name="tokens"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="textOffset"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="tokens"/>, <paramref name="tokenLogprobs"/>, <paramref name="topLogprobs"/> or <paramref name="textOffset"/> is null. </exception>
        internal CreateCompletionLogprobs(IEnumerable<string> tokens, IEnumerable<double> tokenLogprobs, IEnumerable<IDictionary<string, long>> topLogprobs, IEnumerable<long> textOffset)
        {
            ClientUtilities.AssertNotNull(tokens, nameof(tokens));
            ClientUtilities.AssertNotNull(tokenLogprobs, nameof(tokenLogprobs));
            ClientUtilities.AssertNotNull(topLogprobs, nameof(topLogprobs));
            ClientUtilities.AssertNotNull(textOffset, nameof(textOffset));

            Tokens = tokens.ToList();
            TokenLogprobs = tokenLogprobs.ToList();
            TopLogprobs = topLogprobs.ToList();
            TextOffset = textOffset.ToList();
        }

        /// <summary> Initializes a new instance of CreateCompletionLogprobs. </summary>
        /// <param name="tokens"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="textOffset"></param>
        internal CreateCompletionLogprobs(IReadOnlyList<string> tokens, IReadOnlyList<double> tokenLogprobs, IReadOnlyList<IDictionary<string, long>> topLogprobs, IReadOnlyList<long> textOffset)
        {
            Tokens = tokens;
            TokenLogprobs = tokenLogprobs;
            TopLogprobs = topLogprobs;
            TextOffset = textOffset;
        }

        /// <summary> Gets the tokens. </summary>
        public IReadOnlyList<string> Tokens { get; }
        /// <summary> Gets the token logprobs. </summary>
        public IReadOnlyList<double> TokenLogprobs { get; }
        /// <summary> Gets the top logprobs. </summary>
        public IReadOnlyList<IDictionary<string, long>> TopLogprobs { get; }
        /// <summary> Gets the text offset. </summary>
        public IReadOnlyList<long> TextOffset { get; }
    }
}