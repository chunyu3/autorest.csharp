// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    internal partial class VaultListKeysResult
    {
        internal static VaultListKeysResult DeserializeVaultListKeysResult(JsonElement element)
        {
            Optional<IReadOnlyList<VaultKey>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VaultKey> array = new List<VaultKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultKey.DeserializeVaultKey(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VaultListKeysResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
