// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace MgmtLRO.Models
{
    public partial class BarProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Buzz))
            {
                writer.WritePropertyName("buzz");
                writer.WriteStringValue(Buzz.Value);
            }
            writer.WriteEndObject();
        }

        internal static BarProperties DeserializeBarProperties(JsonElement element)
        {
            Optional<Guid> buzz = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("buzz"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    buzz = property.Value.GetGuid();
                    continue;
                }
            }
            return new BarProperties(Optional.ToNullable(buzz));
        }
    }
}