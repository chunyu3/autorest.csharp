// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtAcronymMapping.Models;

namespace MgmtAcronymMapping
{
    public partial class VirtualMachineScaleSetVmData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Plan != null)
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteObjectValue(Plan);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (HardwareProfile != null)
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile);
            }
            if (StorageProfile != null)
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (AdditionalCapabilities != null)
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            if (OSProfile != null)
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (SecurityProfile != null)
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (NetworkProfile != null)
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (NetworkProfileConfiguration != null)
            {
                writer.WritePropertyName("networkProfileConfiguration"u8);
                writer.WriteObjectValue(NetworkProfileConfiguration);
            }
            if (DiagnosticsProfile != null)
            {
                writer.WritePropertyName("diagnosticsProfile"u8);
                writer.WriteObjectValue(DiagnosticsProfile);
            }
            if (AvailabilitySet != null)
            {
                writer.WritePropertyName("availabilitySet"u8);
                JsonSerializer.Serialize(writer, AvailabilitySet);
            }
            if (LicenseType != null)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (ProtectionPolicy != null)
            {
                writer.WritePropertyName("protectionPolicy"u8);
                writer.WriteObjectValue(ProtectionPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVmData DeserializeVirtualMachineScaleSetVmData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceId = default;
            MgmtAcronymMappingSku sku = default;
            MgmtAcronymMappingPlan plan = default;
            IReadOnlyList<string> zones = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            bool? latestModelApplied = default;
            string vmId = default;
            VirtualMachineScaleSetVmInstanceView instanceView = default;
            HardwareProfile hardwareProfile = default;
            StorageProfile storageProfile = default;
            AdditionalCapabilities additionalCapabilities = default;
            OSProfile osProfile = default;
            SecurityProfile securityProfile = default;
            NetworkProfile networkProfile = default;
            VirtualMachineScaleSetVmNetworkProfileConfiguration networkProfileConfiguration = default;
            DiagnosticsProfile diagnosticsProfile = default;
            WritableSubResource availabilitySet = default;
            string provisioningState = default;
            string licenseType = default;
            string modelDefinitionApplied = default;
            VirtualMachineScaleSetVmProtectionPolicy protectionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceId"u8))
                {
                    instanceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MgmtAcronymMappingSku.DeserializeMgmtAcronymMappingSku(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = MgmtAcronymMappingPlan.DeserializeMgmtAcronymMappingPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("latestModelApplied"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            latestModelApplied = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vmId"u8))
                        {
                            vmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = VirtualMachineScaleSetVmInstanceView.DeserializeVirtualMachineScaleSetVmInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hardwareProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareProfile = HardwareProfile.DeserializeHardwareProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = StorageProfile.DeserializeStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = OSProfile.DeserializeOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = SecurityProfile.DeserializeSecurityProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfileConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfileConfiguration = VirtualMachineScaleSetVmNetworkProfileConfiguration.DeserializeVirtualMachineScaleSetVmNetworkProfileConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilitySet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilitySet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            licenseType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("modelDefinitionApplied"u8))
                        {
                            modelDefinitionApplied = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protectionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectionPolicy = VirtualMachineScaleSetVmProtectionPolicy.DeserializeVirtualMachineScaleSetVmProtectionPolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineScaleSetVmData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                instanceId,
                sku,
                plan,
                zones ?? new ChangeTrackingList<string>(),
                latestModelApplied,
                vmId,
                instanceView,
                hardwareProfile,
                storageProfile,
                additionalCapabilities,
                osProfile,
                securityProfile,
                networkProfile,
                networkProfileConfiguration,
                diagnosticsProfile,
                availabilitySet,
                provisioningState,
                licenseType,
                modelDefinitionApplied,
                protectionPolicy);
        }
    }
}
