// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model is from Record&lt;ModelForRecord[]&gt; type. </summary>
    public partial class IsModelArrayAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="IsModelArrayAdditionalProperties"/>. </summary>
        public IsModelArrayAdditionalProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, IList<ModelForRecord>>();
        }

        /// <summary> Initializes a new instance of <see cref="IsModelArrayAdditionalProperties"/>. </summary>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IsModelArrayAdditionalProperties(IDictionary<string, IList<ModelForRecord>> additionalProperties)
        {
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Additional Properties. </summary>
        public IDictionary<string, IList<ModelForRecord>> AdditionalProperties { get; }
    }
}
