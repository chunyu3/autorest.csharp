// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace CadlGenerateAllModels.Models
{
    public partial class RoundTripModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requiredString"u8);
            writer.WriteStringValue(RequiredString);
            writer.WritePropertyName("requiredInt"u8);
            writer.WriteNumberValue(RequiredInt);
            writer.WritePropertyName("requiredCollection"u8);
            writer.WriteStartArray();
            foreach (var item in RequiredCollection)
            {
                writer.WriteStringValue(item.ToSerialString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("requiredDictionary"u8);
            writer.WriteStartObject();
            foreach (var item in RequiredDictionary)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("requiredModel"u8);
            writer.WriteObjectValue(RequiredModel);
            writer.WriteEndObject();
        }

        internal static RoundTripModel DeserializeRoundTripModel(JsonElement element)
        {
            string requiredString = default;
            int requiredInt = default;
            IList<SimpleEnum> requiredCollection = default;
            IDictionary<string, ExtensibleEnum> requiredDictionary = default;
            Thing requiredModel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requiredString"u8))
                {
                    requiredString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredInt"u8))
                {
                    requiredInt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requiredCollection"u8))
                {
                    List<SimpleEnum> array = new List<SimpleEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToSimpleEnum());
                    }
                    requiredCollection = array;
                    continue;
                }
                if (property.NameEquals("requiredDictionary"u8))
                {
                    Dictionary<string, ExtensibleEnum> dictionary = new Dictionary<string, ExtensibleEnum>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, new ExtensibleEnum(property0.Value.GetString()));
                    }
                    requiredDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("requiredModel"u8))
                {
                    requiredModel = Thing.DeserializeThing(property.Value);
                    continue;
                }
            }
            return new RoundTripModel(requiredString, requiredInt, requiredCollection, requiredDictionary, requiredModel);
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
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
