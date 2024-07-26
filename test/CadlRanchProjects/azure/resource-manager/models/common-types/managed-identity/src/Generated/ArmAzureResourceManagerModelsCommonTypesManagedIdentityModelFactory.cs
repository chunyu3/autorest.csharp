// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace _Azure.ResourceManager.Models.CommonTypes.ManagedIdentity.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAzureResourceManagerModelsCommonTypesManagedIdentityModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ManagedIdentity.ManagedIdentityTrackedResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedIdentityTrackedResourceProvisioningState"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <returns> A new <see cref="ManagedIdentity.ManagedIdentityTrackedResourceData"/> instance for mocking. </returns>
        public static ManagedIdentityTrackedResourceData ManagedIdentityTrackedResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string managedIdentityTrackedResourceProvisioningState = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ManagedIdentityTrackedResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                managedIdentityTrackedResourceProvisioningState != null ? new ManagedIdentityTrackedResourceProperties(managedIdentityTrackedResourceProvisioningState, serializedAdditionalRawData: null) : null,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServiceIdentity"/>. </summary>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> The type of managed identity assigned to this resource. </param>
        /// <param name="userAssignedIdentities"> The identities assigned to this resource by the user. </param>
        /// <returns> A new <see cref="Models.ManagedServiceIdentity"/> instance for mocking. </returns>
        public static ManagedServiceIdentity ManagedServiceIdentity(Guid? principalId = null, Guid? tenantId = null, ManagedServiceIdentityType type = default, IDictionary<string, UserAssignedIdentity> userAssignedIdentities = null)
        {
            userAssignedIdentities ??= new Dictionary<string, UserAssignedIdentity>();

            return new ManagedServiceIdentity(principalId, tenantId, type, userAssignedIdentities, serializedAdditionalRawData: null);
        }
    }
}