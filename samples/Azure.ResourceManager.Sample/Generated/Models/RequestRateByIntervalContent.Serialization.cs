// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class RequestRateByIntervalContent : IUtf8JsonSerializable, IJsonModel<RequestRateByIntervalContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestRateByIntervalContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestRateByIntervalContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestRateByIntervalContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestRateByIntervalContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("intervalLength"u8);
            writer.WriteStringValue(IntervalLength.ToSerialString());
            writer.WritePropertyName("blobContainerSasUri"u8);
            writer.WriteStringValue(BlobContainerSasUri.AbsoluteUri);
            writer.WritePropertyName("fromTime"u8);
            writer.WriteStringValue(FromTime, "O");
            writer.WritePropertyName("toTime"u8);
            writer.WriteStringValue(ToTime, "O");
            if (Optional.IsDefined(GroupByThrottlePolicy))
            {
                writer.WritePropertyName("groupByThrottlePolicy"u8);
                writer.WriteBooleanValue(GroupByThrottlePolicy.Value);
            }
            if (Optional.IsDefined(GroupByOperationName))
            {
                writer.WritePropertyName("groupByOperationName"u8);
                writer.WriteBooleanValue(GroupByOperationName.Value);
            }
            if (Optional.IsDefined(GroupByResourceName))
            {
                writer.WritePropertyName("groupByResourceName"u8);
                writer.WriteBooleanValue(GroupByResourceName.Value);
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

        RequestRateByIntervalContent IJsonModel<RequestRateByIntervalContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestRateByIntervalContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestRateByIntervalContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestRateByIntervalContent(document.RootElement, options);
        }

        internal static RequestRateByIntervalContent DeserializeRequestRateByIntervalContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntervalInMin intervalLength = default;
            Uri blobContainerSasUri = default;
            DateTimeOffset fromTime = default;
            DateTimeOffset toTime = default;
            Optional<bool> groupByThrottlePolicy = default;
            Optional<bool> groupByOperationName = default;
            Optional<bool> groupByResourceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalLength"u8))
                {
                    intervalLength = property.Value.GetString().ToIntervalInMin();
                    continue;
                }
                if (property.NameEquals("blobContainerSasUri"u8))
                {
                    blobContainerSasUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fromTime"u8))
                {
                    fromTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("toTime"u8))
                {
                    toTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("groupByThrottlePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupByThrottlePolicy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupByOperationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupByOperationName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupByResourceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    groupByResourceName = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestRateByIntervalContent(blobContainerSasUri, fromTime, toTime, Optional.ToNullable(groupByThrottlePolicy), Optional.ToNullable(groupByOperationName), Optional.ToNullable(groupByResourceName), serializedAdditionalRawData, intervalLength);
        }

        BinaryData IPersistableModel<RequestRateByIntervalContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestRateByIntervalContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequestRateByIntervalContent)} does not support '{options.Format}' format.");
            }
        }

        RequestRateByIntervalContent IPersistableModel<RequestRateByIntervalContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestRateByIntervalContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestRateByIntervalContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequestRateByIntervalContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestRateByIntervalContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
