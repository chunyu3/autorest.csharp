// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    [PersistableModelProxy(typeof(UnknownDotFish))]
    public partial class DotFish : IUtf8JsonSerializable, IJsonModel<DotFish>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DotFish>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DotFish>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DotFish)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fish.type"u8);
            writer.WriteStringValue(FishType);
            if (Optional.IsDefined(Species))
            {
                writer.WritePropertyName("species"u8);
                writer.WriteStringValue(Species);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DotFish IJsonModel<DotFish>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DotFish)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDotFish(document.RootElement, options);
        }

        internal static DotFish DeserializeDotFish(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("fish.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DotSalmon": return DotSalmon.DeserializeDotSalmon(element);
                }
            }
            return UnknownDotFish.DeserializeUnknownDotFish(element);
        }

        BinaryData IPersistableModel<DotFish>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DotFish)} does not support '{options.Format}' format.");
            }
        }

        DotFish IPersistableModel<DotFish>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DotFish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDotFish(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DotFish)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DotFish>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
