// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace CognitiveSearch.Models
{
    public partial class SearchResult
    {
        internal static SearchResult DeserializeSearchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double searchScore = default;
            IReadOnlyDictionary<string, IList<string>> searchHighlights = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"u8))
                {
                    searchScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.highlights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchHighlights = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SearchResult(searchScore, searchHighlights ?? new ChangeTrackingDictionary<string, IList<string>>(), additionalProperties);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSearchResult(document.RootElement);
        }
    }
}
