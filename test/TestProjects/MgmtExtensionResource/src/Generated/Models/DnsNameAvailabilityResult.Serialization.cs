// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace MgmtExtensionResource.Models
{
    public partial class DnsNameAvailabilityResult
    {
        internal static DnsNameAvailabilityResult DeserializeDnsNameAvailabilityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? available = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DnsNameAvailabilityResult(available);
        }
    }
}