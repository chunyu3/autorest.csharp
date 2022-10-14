// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    internal partial class EventDataCollection
    {
        internal static EventDataCollection DeserializeEventDataCollection(JsonElement element)
        {
            IReadOnlyList<EventData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<EventData> array = new List<EventData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventData.DeserializeEventData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EventDataCollection(value, nextLink.Value);
        }
    }
}
