// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace paging.Models
{
    /// <summary> The ProductResultValueWithXMSClientName. </summary>
    internal partial class ProductResultValueWithXMSClientName
    {
        /// <summary> Initializes a new instance of <see cref="ProductResultValueWithXMSClientName"/>. </summary>
        internal ProductResultValueWithXMSClientName()
        {
            Indexes = new ChangeTrackingList<Product>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductResultValueWithXMSClientName"/>. </summary>
        /// <param name="indexes"></param>
        /// <param name="nextLink"></param>
        internal ProductResultValueWithXMSClientName(IReadOnlyList<Product> indexes, string nextLink)
        {
            Indexes = indexes;
            NextLink = nextLink;
        }

        /// <summary> Gets the indexes. </summary>
        public IReadOnlyList<Product> Indexes { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
