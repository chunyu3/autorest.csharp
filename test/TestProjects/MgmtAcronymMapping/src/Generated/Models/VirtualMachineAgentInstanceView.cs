// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using MgmtAcronymMapping;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// The instance view of the VM Agent running on the virtual machine.
    /// Serialized Name: VirtualMachineAgentInstanceView
    /// </summary>
    public partial class VirtualMachineAgentInstanceView
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineAgentInstanceView"/>. </summary>
        internal VirtualMachineAgentInstanceView()
        {
            ExtensionHandlers = new ChangeTrackingList<VirtualMachineExtensionHandlerInstanceView>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineAgentInstanceView"/>. </summary>
        /// <param name="vmAgentVersion">
        /// The VM Agent full version.
        /// Serialized Name: VirtualMachineAgentInstanceView.vmAgentVersion
        /// </param>
        /// <param name="extensionHandlers">
        /// The virtual machine extension handler instance view.
        /// Serialized Name: VirtualMachineAgentInstanceView.extensionHandlers
        /// </param>
        /// <param name="statuses">
        /// The resource status information.
        /// Serialized Name: VirtualMachineAgentInstanceView.statuses
        /// </param>
        internal VirtualMachineAgentInstanceView(string vmAgentVersion, IReadOnlyList<VirtualMachineExtensionHandlerInstanceView> extensionHandlers, IReadOnlyList<InstanceViewStatus> statuses)
        {
            VmAgentVersion = vmAgentVersion;
            ExtensionHandlers = extensionHandlers;
            Statuses = statuses;
        }

        /// <summary>
        /// The VM Agent full version.
        /// Serialized Name: VirtualMachineAgentInstanceView.vmAgentVersion
        /// </summary>
        public string VmAgentVersion { get; }
        /// <summary>
        /// The virtual machine extension handler instance view.
        /// Serialized Name: VirtualMachineAgentInstanceView.extensionHandlers
        /// </summary>
        public IReadOnlyList<VirtualMachineExtensionHandlerInstanceView> ExtensionHandlers { get; }
        /// <summary>
        /// The resource status information.
        /// Serialized Name: VirtualMachineAgentInstanceView.statuses
        /// </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}