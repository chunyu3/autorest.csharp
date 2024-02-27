// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    internal partial class NetworkInterfaceLoadBalancerListResult
    {
        internal static NetworkInterfaceLoadBalancerListResult DeserializeNetworkInterfaceLoadBalancerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LoadBalancer> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancer> array = new List<LoadBalancer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancer.DeserializeLoadBalancer(item));
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
            return new NetworkInterfaceLoadBalancerListResult(value ?? new ChangeTrackingList<LoadBalancer>(), nextLink.Value);
        }
    }
}
