// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Payload.MultiPart.Models
{
    public partial class ComplexPartsRequest : IJsonModel<ComplexPartsRequest>
    {
        void IJsonModel<ComplexPartsRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComplexPartsRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComplexPartsRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("address"u8);
            writer.WriteObjectValue(Address, options);
            writer.WritePropertyName("profileImage"u8);
            writer.WriteBase64StringValue(ProfileImage.ToArray(), "D");
            writer.WritePropertyName("previousAddresses"u8);
            writer.WriteStartArray();
            foreach (var item in PreviousAddresses)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("pictures"u8);
            writer.WriteStartArray();
            foreach (var item in Pictures)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteBase64StringValue(item.ToArray(), "D");
            }
            writer.WriteEndArray();
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

        ComplexPartsRequest IJsonModel<ComplexPartsRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComplexPartsRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComplexPartsRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComplexPartsRequest(document.RootElement, options);
        }

        internal static ComplexPartsRequest DeserializeComplexPartsRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Address address = default;
            BinaryData profileImage = default;
            IList<Address> previousAddresses = default;
            IList<BinaryData> pictures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = Address.DeserializeAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("profileImage"u8))
                {
                    profileImage = BinaryData.FromBytes(property.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (property.NameEquals("previousAddresses"u8))
                {
                    List<Address> array = new List<Address>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Address.DeserializeAddress(item, options));
                    }
                    previousAddresses = array;
                    continue;
                }
                if (property.NameEquals("pictures"u8))
                {
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromBytes(item.GetBytesFromBase64("D")));
                        }
                    }
                    pictures = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComplexPartsRequest(
                id,
                address,
                profileImage,
                previousAddresses,
                pictures,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeMultipart(ModelReaderWriterOptions options)
        {
            using MultipartFormDataBinaryContent content = ToMultipartBinaryBody();
            using MemoryStream stream = new MemoryStream();
            content.WriteTo(stream);
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        internal virtual MultipartFormDataBinaryContent ToMultipartBinaryBody()
        {
            MultipartFormDataBinaryContent content = new MultipartFormDataBinaryContent();
            content.Add(Id, "id");
            content.Add(ModelReaderWriter.Write(Address, ModelSerializationExtensions.WireOptions), "address");
            content.Add(ProfileImage, "profileImage", "profileImage" + ".wav", "application/octet-stream");
            foreach (Address item in PreviousAddresses)
            {
                content.Add(ModelReaderWriter.Write(item, ModelSerializationExtensions.WireOptions), "previousAddresses");
            }
            foreach (BinaryData item in Pictures)
            {
                content.Add(item, "pictures", "pictures" + ".wav", "application/octet-stream");
            }
            return content;
        }

        BinaryData IPersistableModel<ComplexPartsRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComplexPartsRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "MFD":
                    return SerializeMultipart(options);
                default:
                    throw new FormatException($"The model {nameof(ComplexPartsRequest)} does not support writing '{options.Format}' format.");
            }
        }

        ComplexPartsRequest IPersistableModel<ComplexPartsRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComplexPartsRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComplexPartsRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComplexPartsRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComplexPartsRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ComplexPartsRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeComplexPartsRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
