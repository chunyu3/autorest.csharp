// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AdditionalPropertiesEx.Models
{
    public partial class InputAdditionalPropertiesModel : IUtf8JsonSerializable, IJsonModel<InputAdditionalPropertiesModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InputAdditionalPropertiesModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InputAdditionalPropertiesModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InputAdditionalPropertiesModel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        InputAdditionalPropertiesModel IJsonModel<InputAdditionalPropertiesModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InputAdditionalPropertiesModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInputAdditionalPropertiesModel(document.RootElement, options);
        }

        internal static InputAdditionalPropertiesModel DeserializeInputAdditionalPropertiesModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int id = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new InputAdditionalPropertiesModel(id, additionalProperties);
        }

        BinaryData IPersistableModel<InputAdditionalPropertiesModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InputAdditionalPropertiesModel)} does not support '{options.Format}' format.");
            }
        }

        InputAdditionalPropertiesModel IPersistableModel<InputAdditionalPropertiesModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInputAdditionalPropertiesModel(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InputAdditionalPropertiesModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InputAdditionalPropertiesModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
