// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Inheritance.Models
{
    internal partial class UnknownFish
    {
        internal static UnknownFish DeserializeUnknownFish(JsonElement element)
        {
            string kind = "Unknown";
            int age = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("age"))
                {
                    age = property.Value.GetInt32();
                    continue;
                }
            }
            return new UnknownFish(kind, age);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal new static UnknownFish FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownFish(document.RootElement);
        }
    }
}