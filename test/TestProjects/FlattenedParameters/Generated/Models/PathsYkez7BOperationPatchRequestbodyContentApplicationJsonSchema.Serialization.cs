// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace FlattenedParameters.Models
{
    internal partial class PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Items))
            {
                if (Items != null)
                {
                    writer.WritePropertyName("items");
                    writer.WriteStartArray();
                    foreach (var item in Items)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("items");
                }
            }
            writer.WriteEndObject();
        }
    }
}