// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class TimeSeriesPoint : IUtf8JsonSerializable, IJsonModel<TimeSeriesPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TimeSeriesPoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TimeSeriesPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeSeriesPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimeSeriesPoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Timestamp.HasValue)
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
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

        TimeSeriesPoint IJsonModel<TimeSeriesPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeSeriesPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimeSeriesPoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesPoint(document.RootElement, options);
        }

        internal static TimeSeriesPoint DeserializeTimeSeriesPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            float value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TimeSeriesPoint(Optional.ToNullable(timestamp), value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TimeSeriesPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeSeriesPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TimeSeriesPoint)} does not support '{options.Format}' format.");
            }
        }

        TimeSeriesPoint IPersistableModel<TimeSeriesPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeSeriesPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTimeSeriesPoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TimeSeriesPoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TimeSeriesPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TimeSeriesPoint FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTimeSeriesPoint(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
