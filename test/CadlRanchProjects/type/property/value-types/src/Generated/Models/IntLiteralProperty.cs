// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Property.ValueTypes.Models
{
    /// <summary> Model with a int literal property. </summary>
    public partial class IntLiteralProperty
    {
        /// <summary> Initializes a new instance of <see cref="IntLiteralProperty"/>. </summary>
        public IntLiteralProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntLiteralProperty"/>. </summary>
        /// <param name="property"> Property. </param>
        internal IntLiteralProperty(IntLiteralPropertyProperty property)
        {
            Property = property;
        }

        /// <summary> Property. </summary>
        public IntLiteralPropertyProperty Property { get; } = IntLiteralPropertyProperty._42;
    }
}
