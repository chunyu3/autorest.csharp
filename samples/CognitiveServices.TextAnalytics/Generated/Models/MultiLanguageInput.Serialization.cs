// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class MultiLanguageInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            writer.WriteEndObject();
        }
    }
}
