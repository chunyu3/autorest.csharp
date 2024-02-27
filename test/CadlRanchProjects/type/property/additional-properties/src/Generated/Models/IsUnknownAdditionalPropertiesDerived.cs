// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model extends from a type that is Record&lt;unknown&gt; type. </summary>
    public partial class IsUnknownAdditionalPropertiesDerived : IsUnknownAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDerived"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <param name="index"> The index property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IsUnknownAdditionalPropertiesDerived(string name, int index) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDerived"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="index"> The index property. </param>
        /// <param name="age"> The age property. </param>
        internal IsUnknownAdditionalPropertiesDerived(string name, IDictionary<string, BinaryData> additionalProperties, int index, float? age) : base(name, additionalProperties)
        {
            Index = index;
            Age = age;
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDerived"/> for deserialization. </summary>
        internal IsUnknownAdditionalPropertiesDerived()
        {
        }

        /// <summary> The index property. </summary>
        public int Index { get; set; }
        /// <summary> The age property. </summary>
        public float? Age { get; set; }
    }
}
