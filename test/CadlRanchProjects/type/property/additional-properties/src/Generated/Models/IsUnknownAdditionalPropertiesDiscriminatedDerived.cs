// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The derived discriminated type. </summary>
    public partial class IsUnknownAdditionalPropertiesDiscriminatedDerived : IsUnknownAdditionalPropertiesDiscriminated
    {
        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDiscriminatedDerived"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <param name="index"> The index property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IsUnknownAdditionalPropertiesDiscriminatedDerived(string name, int index) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = "derived";
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDiscriminatedDerived"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <param name="kind"> The discriminator. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="index"> The index property. </param>
        /// <param name="age"> The age property. </param>
        internal IsUnknownAdditionalPropertiesDiscriminatedDerived(string name, string kind, IDictionary<string, BinaryData> additionalProperties, int index, float? age) : base(name, kind, additionalProperties)
        {
            Index = index;
            Age = age;
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalPropertiesDiscriminatedDerived"/> for deserialization. </summary>
        internal IsUnknownAdditionalPropertiesDiscriminatedDerived()
        {
        }

        /// <summary> The index property. </summary>
        public int Index { get; set; }
        /// <summary> The age property. </summary>
        public float? Age { get; set; }
    }
}
