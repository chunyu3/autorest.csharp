// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ListFineTunesResponse
    {
        internal static ListFineTunesResponse DeserializeListFineTunesResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @object = default;
            IReadOnlyList<FineTune> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<FineTune> array = new List<FineTune>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FineTune.DeserializeFineTune(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new ListFineTunesResponse(@object, data);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static ListFineTunesResponse FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeListFineTunesResponse(document.RootElement);
        }
    }
}
