// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.ServiceModel.Rest.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ListFineTuneEventsResponse
    {
        internal static ListFineTuneEventsResponse DeserializeListFineTuneEventsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @object = default;
            IReadOnlyList<FineTuneEvent> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<FineTuneEvent> array = new List<FineTuneEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FineTuneEvent.DeserializeFineTuneEvent(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new ListFineTuneEventsResponse(@object, data);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static ListFineTuneEventsResponse FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeListFineTuneEventsResponse(document.RootElement);
        }
    }
}