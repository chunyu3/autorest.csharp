// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using MgmtExactMatchFlattenInheritance;

namespace MgmtExactMatchFlattenInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class AzureResourceFlattenModel4ListResult
    {
        /// <summary> Initializes a new instance of <see cref="AzureResourceFlattenModel4ListResult"/>. </summary>
        internal AzureResourceFlattenModel4ListResult()
        {
            Value = new ChangeTrackingList<AzureResourceFlattenModel4>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureResourceFlattenModel4ListResult"/>. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal AzureResourceFlattenModel4ListResult(IReadOnlyList<AzureResourceFlattenModel4> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<AzureResourceFlattenModel4> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}