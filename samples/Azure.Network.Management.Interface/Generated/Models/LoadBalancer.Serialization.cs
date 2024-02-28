// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class LoadBalancer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(FrontendIPConfigurations is ChangeTrackingList<FrontendIPConfiguration> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("frontendIPConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(BackendAddressPools is ChangeTrackingList<BackendAddressPool> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("backendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in BackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LoadBalancingRules is ChangeTrackingList<LoadBalancingRule> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("loadBalancingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Probes is ChangeTrackingList<Probe> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("probes"u8);
                writer.WriteStartArray();
                foreach (var item in Probes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InboundNatRules is ChangeTrackingList<InboundNatRule> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("inboundNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InboundNatPools is ChangeTrackingList<InboundNatPool> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("inboundNatPools"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(OutboundRules is ChangeTrackingList<OutboundRule> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("outboundRules"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadBalancer DeserializeLoadBalancer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LoadBalancerSku sku = default;
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            IList<FrontendIPConfiguration> frontendIPConfigurations = default;
            IList<BackendAddressPool> backendAddressPools = default;
            IList<LoadBalancingRule> loadBalancingRules = default;
            IList<Probe> probes = default;
            IList<InboundNatRule> inboundNatRules = default;
            IList<InboundNatPool> inboundNatPools = default;
            IList<OutboundRule> outboundRules = default;
            string resourceGuid = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = LoadBalancerSku.DeserializeLoadBalancerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frontendIPConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontendIPConfiguration> array = new List<FrontendIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendIPConfiguration.DeserializeFrontendIPConfiguration(item));
                            }
                            frontendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BackendAddressPool> array = new List<BackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                            }
                            backendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LoadBalancingRule> array = new List<LoadBalancingRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancingRule.DeserializeLoadBalancingRule(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("probes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Probe> array = new List<Probe>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Probe.DeserializeProbe(item));
                            }
                            probes = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<InboundNatRule> array = new List<InboundNatRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundNatRule.DeserializeInboundNatRule(item));
                            }
                            inboundNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundNatPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<InboundNatPool> array = new List<InboundNatPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundNatPool.DeserializeInboundNatPool(item));
                            }
                            inboundNatPools = array;
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<OutboundRule> array = new List<OutboundRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(OutboundRule.DeserializeOutboundRule(item));
                            }
                            outboundRules = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadBalancer(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sku,
                etag,
                frontendIPConfigurations ?? new ChangeTrackingList<FrontendIPConfiguration>(),
                backendAddressPools ?? new ChangeTrackingList<BackendAddressPool>(),
                loadBalancingRules ?? new ChangeTrackingList<LoadBalancingRule>(),
                probes ?? new ChangeTrackingList<Probe>(),
                inboundNatRules ?? new ChangeTrackingList<InboundNatRule>(),
                inboundNatPools ?? new ChangeTrackingList<InboundNatPool>(),
                outboundRules ?? new ChangeTrackingList<OutboundRule>(),
                resourceGuid,
                provisioningState);
        }
    }
}
