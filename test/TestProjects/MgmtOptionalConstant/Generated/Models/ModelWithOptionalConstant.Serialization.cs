// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtOptionalConstant.Models
{
    public partial class ModelWithOptionalConstant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PassName))
            {
                writer.WritePropertyName("passName");
                writer.WriteStringValue(PassName.Value.ToString());
            }
            if (Optional.IsDefined(SettingName))
            {
                writer.WritePropertyName("settingName");
                writer.WriteStringValue(SettingName.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static ModelWithOptionalConstant DeserializeModelWithOptionalConstant(JsonElement element)
        {
            Optional<PassName> passName = default;
            Optional<SettingName> settingName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("passName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    passName = new PassName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("settingName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    settingName = property.Value.GetString().ToSettingName();
                    continue;
                }
            }
            return new ModelWithOptionalConstant(Optional.ToNullable(passName), Optional.ToNullable(settingName));
        }
    }
}
