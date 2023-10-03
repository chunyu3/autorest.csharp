// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Experimental.Core.Serialization;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateImageEditRequest : IUtf8JsonWriteable
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("prompt"u8);
            writer.WriteStringValue(Prompt);
            writer.WritePropertyName("image"u8);
            writer.WriteBase64StringValue(Image.ToArray(), "D");
            if (OptionalProperty.IsDefined(Mask))
            {
                writer.WritePropertyName("mask"u8);
                writer.WriteBase64StringValue(Mask.ToArray(), "D");
            }
            if (OptionalProperty.IsDefined(N))
            {
                if (N != null)
                {
                    writer.WritePropertyName("n"u8);
                    writer.WriteNumberValue(N.Value);
                }
                else
                {
                    writer.WriteNull("n");
                }
            }
            if (OptionalProperty.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size.Value.ToString());
            }
            if (OptionalProperty.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (OptionalProperty.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
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
