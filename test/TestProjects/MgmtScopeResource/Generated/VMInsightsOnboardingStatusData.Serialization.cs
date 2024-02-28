// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    public partial class VMInsightsOnboardingStatusData
    {
        internal static VMInsightsOnboardingStatusData DeserializeVMInsightsOnboardingStatusData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string resourceId = default;
            OnboardingStatus? onboardingStatus = default;
            DataStatus? dataStatus = default;
            IReadOnlyList<DataContainer> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"u8))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("onboardingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onboardingStatus = new OnboardingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataStatus = new DataStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("data"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataContainer> array = new List<DataContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataContainer.DeserializeDataContainer(item));
                            }
                            data = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VMInsightsOnboardingStatusData(
                id,
                name,
                type,
                systemData,
                resourceId,
                onboardingStatus,
                dataStatus,
                data ?? new ChangeTrackingList<DataContainer>());
        }
    }
}
