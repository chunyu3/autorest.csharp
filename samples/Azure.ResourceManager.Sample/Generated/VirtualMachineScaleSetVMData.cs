// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the VirtualMachineScaleSetVM data model. </summary>
    public partial class VirtualMachineScaleSetVMData : TrackedResource
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineScaleSetVMData(Location location) : base(location)
        {
            Resources = new ChangeTrackingList<VirtualMachineExtensionData>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="instanceId"> The virtual machine instance ID. </param>
        /// <param name="sku"> The virtual machine SKU. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="resources"> The virtual machine child extension resources. </param>
        /// <param name="zones"> The virtual machine zones. </param>
        /// <param name="latestModelApplied"> Specifies whether the latest model has been applied to the virtual machine. </param>
        /// <param name="vmId"> Azure VM unique ID. </param>
        /// <param name="instanceView"> The virtual machine instance view. </param>
        /// <param name="hardwareProfile"> Specifies the hardware settings for the virtual machine. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="additionalCapabilities"> Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machine. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machine. </param>
        /// <param name="networkProfile"> Specifies the network interfaces of the virtual machine. </param>
        /// <param name="networkProfileConfiguration"> Specifies the network profile configuration of the virtual machine. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </param>
        /// <param name="availabilitySet"> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="modelDefinitionApplied"> Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine. </param>
        /// <param name="protectionPolicy"> Specifies the protection policy of the virtual machine. </param>
        internal VirtualMachineScaleSetVMData(ResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, string instanceId, Models.Sku sku, Models.Plan plan, IReadOnlyList<VirtualMachineExtensionData> resources, IReadOnlyList<string> zones, bool? latestModelApplied, string vmId, VirtualMachineScaleSetVMInstanceView instanceView, HardwareProfile hardwareProfile, StorageProfile storageProfile, AdditionalCapabilities additionalCapabilities, OSProfile osProfile, SecurityProfile securityProfile, NetworkProfile networkProfile, VirtualMachineScaleSetVMNetworkProfileConfiguration networkProfileConfiguration, DiagnosticsProfile diagnosticsProfile, Models.SubResource availabilitySet, string provisioningState, string licenseType, string modelDefinitionApplied, VirtualMachineScaleSetVMProtectionPolicy protectionPolicy) : base(id, name, type, location, tags)
        {
            InstanceId = instanceId;
            Sku = sku;
            Plan = plan;
            Resources = resources;
            Zones = zones;
            LatestModelApplied = latestModelApplied;
            VmId = vmId;
            InstanceView = instanceView;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OsProfile = osProfile;
            SecurityProfile = securityProfile;
            NetworkProfile = networkProfile;
            NetworkProfileConfiguration = networkProfileConfiguration;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            LicenseType = licenseType;
            ModelDefinitionApplied = modelDefinitionApplied;
            ProtectionPolicy = protectionPolicy;
        }

        /// <summary> The virtual machine instance ID. </summary>
        public string InstanceId { get; }
        /// <summary> The virtual machine SKU. </summary>
        public Models.Sku Sku { get; }
        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public Models.Plan Plan { get; set; }
        /// <summary> The virtual machine child extension resources. </summary>
        public IReadOnlyList<VirtualMachineExtensionData> Resources { get; }
        /// <summary> The virtual machine zones. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Specifies whether the latest model has been applied to the virtual machine. </summary>
        public bool? LatestModelApplied { get; }
        /// <summary> Azure VM unique ID. </summary>
        public string VmId { get; }
        /// <summary> The virtual machine instance view. </summary>
        public VirtualMachineScaleSetVMInstanceView InstanceView { get; }
        /// <summary> Specifies the hardware settings for the virtual machine. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public StorageProfile StorageProfile { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the operating system settings for the virtual machine. </summary>
        public OSProfile OsProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machine. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the network interfaces of the virtual machine. </summary>
        public NetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the network profile configuration of the virtual machine. </summary>
        public VirtualMachineScaleSetVMNetworkProfileConfiguration NetworkProfileConfiguration { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </summary>
        public Models.SubResource AvailabilitySet { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine. </summary>
        public string ModelDefinitionApplied { get; }
        /// <summary> Specifies the protection policy of the virtual machine. </summary>
        public VirtualMachineScaleSetVMProtectionPolicy ProtectionPolicy { get; set; }
    }
}