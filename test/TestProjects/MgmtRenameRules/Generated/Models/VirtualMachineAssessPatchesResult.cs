// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    /// <summary>
    /// Describes the properties of an AssessPatches result.
    /// Serialized Name: VirtualMachineAssessPatchesResult
    /// </summary>
    public partial class VirtualMachineAssessPatchesResult
    {
        /// <summary> Initializes a new instance of VirtualMachineAssessPatchesResult. </summary>
        internal VirtualMachineAssessPatchesResult()
        {
            Patches = new ChangeTrackingList<VirtualMachineSoftwarePatchProperties>();
        }

        /// <summary> Initializes a new instance of VirtualMachineAssessPatchesResult. </summary>
        /// <param name="status">
        /// The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes. At that point it will become &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;
        /// Serialized Name: VirtualMachineAssessPatchesResult.status
        /// </param>
        /// <param name="assessmentActivityId">
        /// The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs.
        /// Serialized Name: VirtualMachineAssessPatchesResult.assessmentActivityId
        /// </param>
        /// <param name="rebootPending">
        /// The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred.
        /// Serialized Name: VirtualMachineAssessPatchesResult.rebootPending
        /// </param>
        /// <param name="criticalAndSecurityPatchCount">
        /// The number of critical or security patches that have been detected as available and not yet installed.
        /// Serialized Name: VirtualMachineAssessPatchesResult.criticalAndSecurityPatchCount
        /// </param>
        /// <param name="otherPatchCount">
        /// The number of all available patches excluding critical and security.
        /// Serialized Name: VirtualMachineAssessPatchesResult.otherPatchCount
        /// </param>
        /// <param name="startOn">
        /// The UTC timestamp when the operation began.
        /// Serialized Name: VirtualMachineAssessPatchesResult.startDateTime
        /// </param>
        /// <param name="patches">
        /// The list of patches that have been detected as available for installation.
        /// Serialized Name: VirtualMachineAssessPatchesResult.patches
        /// </param>
        /// <param name="error">
        /// The errors that were encountered during execution of the operation. The details array contains the list of them.
        /// Serialized Name: VirtualMachineAssessPatchesResult.error
        /// </param>
        internal VirtualMachineAssessPatchesResult(PatchOperationStatus? status, string assessmentActivityId, bool? rebootPending, int? criticalAndSecurityPatchCount, int? otherPatchCount, DateTimeOffset? startOn, IReadOnlyList<VirtualMachineSoftwarePatchProperties> patches, ApiError error)
        {
            Status = status;
            AssessmentActivityId = assessmentActivityId;
            RebootPending = rebootPending;
            CriticalAndSecurityPatchCount = criticalAndSecurityPatchCount;
            OtherPatchCount = otherPatchCount;
            StartOn = startOn;
            Patches = patches;
            Error = error;
        }

        /// <summary>
        /// The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes. At that point it will become &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;
        /// Serialized Name: VirtualMachineAssessPatchesResult.status
        /// </summary>
        public PatchOperationStatus? Status { get; }
        /// <summary>
        /// The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs.
        /// Serialized Name: VirtualMachineAssessPatchesResult.assessmentActivityId
        /// </summary>
        public string AssessmentActivityId { get; }
        /// <summary>
        /// The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred.
        /// Serialized Name: VirtualMachineAssessPatchesResult.rebootPending
        /// </summary>
        public bool? RebootPending { get; }
        /// <summary>
        /// The number of critical or security patches that have been detected as available and not yet installed.
        /// Serialized Name: VirtualMachineAssessPatchesResult.criticalAndSecurityPatchCount
        /// </summary>
        public int? CriticalAndSecurityPatchCount { get; }
        /// <summary>
        /// The number of all available patches excluding critical and security.
        /// Serialized Name: VirtualMachineAssessPatchesResult.otherPatchCount
        /// </summary>
        public int? OtherPatchCount { get; }
        /// <summary>
        /// The UTC timestamp when the operation began.
        /// Serialized Name: VirtualMachineAssessPatchesResult.startDateTime
        /// </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary>
        /// The list of patches that have been detected as available for installation.
        /// Serialized Name: VirtualMachineAssessPatchesResult.patches
        /// </summary>
        public IReadOnlyList<VirtualMachineSoftwarePatchProperties> Patches { get; }
        /// <summary>
        /// The errors that were encountered during execution of the operation. The details array contains the list of them.
        /// Serialized Name: VirtualMachineAssessPatchesResult.error
        /// </summary>
        public ApiError Error { get; }
    }
}
