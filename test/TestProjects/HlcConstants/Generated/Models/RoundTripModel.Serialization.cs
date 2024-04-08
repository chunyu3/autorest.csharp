// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace HlcConstants.Models
{
    public partial class RoundTripModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RequiredConstantModel))
            {
                writer.WritePropertyName("requiredConstantModel"u8);
                writer.WriteObjectValue<ModelWithRequiredConstant>(RequiredConstantModel);
            }
            if (Optional.IsDefined(OptionalConstantModel))
            {
                writer.WritePropertyName("optionalConstantModel"u8);
                writer.WriteObjectValue<ModelWithOptionalConstant>(OptionalConstantModel);
            }
            writer.WriteEndObject();
        }

        internal static RoundTripModel DeserializeRoundTripModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ModelWithRequiredConstant requiredConstantModel = default;
            ModelWithOptionalConstant optionalConstantModel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requiredConstantModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiredConstantModel = ModelWithRequiredConstant.DeserializeModelWithRequiredConstant(property.Value);
                    continue;
                }
                if (property.NameEquals("optionalConstantModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalConstantModel = ModelWithOptionalConstant.DeserializeModelWithOptionalConstant(property.Value);
                    continue;
                }
            }
            return new RoundTripModel(requiredConstantModel, optionalConstantModel);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RoundTripModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRoundTripModel(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<RoundTripModel>(this);
            return content;
        }
    }
}
