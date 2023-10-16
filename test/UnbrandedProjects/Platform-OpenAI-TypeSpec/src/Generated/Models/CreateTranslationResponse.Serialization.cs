// <auto-generated/>

#nullable disable

using System.ServiceModel.Rest.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateTranslationResponse
    {
        internal static CreateTranslationResponse DeserializeCreateTranslationResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
            }
            return new CreateTranslationResponse(text);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static CreateTranslationResponse FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeCreateTranslationResponse(document.RootElement);
        }
    }
}
