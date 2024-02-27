// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using MgmtPropertyChooser;

namespace MgmtPropertyChooser.Models
{
    /// <summary> The List Virtual Machine operation response. </summary>
    internal partial class VirtualMachineListResult
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineListResult"/>. </summary>
        /// <param name="value"> The list of virtual machines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineListResult(IEnumerable<VirtualMachineData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineListResult"/>. </summary>
        /// <param name="value"> The list of virtual machines. </param>
        /// <param name="nextLink"> The URI to fetch the next page of VMs. Call ListNext() with this URI to fetch the next page of Virtual Machines. </param>
        internal VirtualMachineListResult(IReadOnlyList<VirtualMachineData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of virtual machines. </summary>
        public IReadOnlyList<VirtualMachineData> Value { get; }
        /// <summary> The URI to fetch the next page of VMs. Call ListNext() with this URI to fetch the next page of Virtual Machines. </summary>
        public string NextLink { get; }
    }
}
