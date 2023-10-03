// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Experimental.Core.Serialization;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateTranslationRequest : IUtf8JsonWriteable
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("file"u8);
            writer.WriteBase64StringValue(File.ToArray(), "D");
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
            if (OptionalProperty.IsDefined(Prompt))
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (OptionalProperty.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (OptionalProperty.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}