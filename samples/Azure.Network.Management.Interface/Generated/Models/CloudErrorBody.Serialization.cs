// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    internal partial class CloudErrorBody
    {
        internal static CloudErrorBody DeserializeCloudErrorBody(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<CloudErrorBody> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CloudErrorBody> array = new List<CloudErrorBody>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeCloudErrorBody(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new CloudErrorBody(code, message, target, details ?? new ChangeTrackingList<CloudErrorBody>());
        }
    }
}
