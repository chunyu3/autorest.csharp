// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ServiceModel.Rest.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateImageRequest. </summary>
    public partial class CreateImageRequest
    {
        /// <summary> Initializes a new instance of CreateImageRequest. </summary>
        /// <param name="prompt"> A text description of the desired image(s). The maximum length is 1000 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> is null. </exception>
        public CreateImageRequest(string prompt)
        {
            ClientUtilities.AssertNotNull(prompt, nameof(prompt));

            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of CreateImageRequest. </summary>
        /// <param name="prompt"> A text description of the desired image(s). The maximum length is 1000 characters. </param>
        /// <param name="n"> The number of images to generate. Must be between 1 and 10. </param>
        /// <param name="size"> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </param>
        /// <param name="responseFormat"> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </param>
        /// <param name="user"></param>
        internal CreateImageRequest(string prompt, long? n, CreateImageRequestSize? size, CreateImageRequestResponseFormat? responseFormat, string user)
        {
            Prompt = prompt;
            N = n;
            Size = size;
            ResponseFormat = responseFormat;
            User = user;
        }

        /// <summary> A text description of the desired image(s). The maximum length is 1000 characters. </summary>
        public string Prompt { get; }
        /// <summary> The number of images to generate. Must be between 1 and 10. </summary>
        public long? N { get; set; }
        /// <summary> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </summary>
        public CreateImageRequestSize? Size { get; set; }
        /// <summary> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </summary>
        public CreateImageRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary> Gets or sets the user. </summary>
        public string User { get; set; }
    }
}
