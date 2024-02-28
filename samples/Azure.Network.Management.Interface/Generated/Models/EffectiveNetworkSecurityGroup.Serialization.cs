// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class EffectiveNetworkSecurityGroup
    {
        internal static EffectiveNetworkSecurityGroup DeserializeEffectiveNetworkSecurityGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubResource networkSecurityGroup = default;
            EffectiveNetworkSecurityGroupAssociation association = default;
            IReadOnlyList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default;
            string tagMap = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSecurityGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityGroup = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("association"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    association = EffectiveNetworkSecurityGroupAssociation.DeserializeEffectiveNetworkSecurityGroupAssociation(property.Value);
                    continue;
                }
                if (property.NameEquals("effectiveSecurityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveNetworkSecurityRule> array = new List<EffectiveNetworkSecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveNetworkSecurityRule.DeserializeEffectiveNetworkSecurityRule(item));
                    }
                    effectiveSecurityRules = array;
                    continue;
                }
                if (property.NameEquals("tagMap"u8))
                {
                    tagMap = property.Value.GetString();
                    continue;
                }
            }
            return new EffectiveNetworkSecurityGroup(networkSecurityGroup, association, effectiveSecurityRules ?? new ChangeTrackingList<EffectiveNetworkSecurityRule>(), tagMap);
        }
    }
}
