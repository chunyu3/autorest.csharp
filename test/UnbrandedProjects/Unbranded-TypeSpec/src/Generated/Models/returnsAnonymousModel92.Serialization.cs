// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ServiceModel.Rest.Core;
using System.Text.Json;

namespace UnbrandedTypeSpec.Models
{
    public partial class returnsAnonymousModel92
    {
        internal static returnsAnonymousModel92 DeserializereturnsAnonymousModel92(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            foreach (var property in element.EnumerateObject())
            {
            }
            return new returnsAnonymousModel92();
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static returnsAnonymousModel92 FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializereturnsAnonymousModel92(document.RootElement);
        }
    }
}