// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> NetworkSecurityGroup resource. </summary>
    public partial class NetworkSecurityGroup : Resource
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroup"/>. </summary>
        public NetworkSecurityGroup()
        {
            SecurityRules = new ChangeTrackingList<SecurityRule>();
            DefaultSecurityRules = new ChangeTrackingList<SecurityRule>();
            NetworkInterfaces = new ChangeTrackingList<NetworkInterface>();
            Subnets = new ChangeTrackingList<Subnet>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroup"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="securityRules"> A collection of security rules of the network security group. </param>
        /// <param name="defaultSecurityRules"> The default security rules of network security group. </param>
        /// <param name="networkInterfaces"> A collection of references to network interfaces. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network security group resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network security group resource. </param>
        internal NetworkSecurityGroup(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<SecurityRule> securityRules, IReadOnlyList<SecurityRule> defaultSecurityRules, IReadOnlyList<NetworkInterface> networkInterfaces, IReadOnlyList<Subnet> subnets, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            SecurityRules = securityRules;
            DefaultSecurityRules = defaultSecurityRules;
            NetworkInterfaces = networkInterfaces;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A collection of security rules of the network security group. </summary>
        public IList<SecurityRule> SecurityRules { get; }
        /// <summary> The default security rules of network security group. </summary>
        public IReadOnlyList<SecurityRule> DefaultSecurityRules { get; }
        /// <summary> A collection of references to network interfaces. </summary>
        public IReadOnlyList<NetworkInterface> NetworkInterfaces { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<Subnet> Subnets { get; }
        /// <summary> The resource GUID property of the network security group resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the network security group resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
