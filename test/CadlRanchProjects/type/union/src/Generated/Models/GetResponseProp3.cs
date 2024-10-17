// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace _Type.Union.Models
{
    /// <summary> The GetResponseProp3. </summary>
    public readonly partial struct GetResponseProp3 : IEquatable<GetResponseProp3>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GetResponseProp3"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GetResponseProp3(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BValue = "b";
        private const string CValue = "c";

        /// <summary> b. </summary>
        public static GetResponseProp3 B { get; } = new GetResponseProp3(BValue);
        /// <summary> c. </summary>
        public static GetResponseProp3 C { get; } = new GetResponseProp3(CValue);
        /// <summary> Determines if two <see cref="GetResponseProp3"/> values are the same. </summary>
        public static bool operator ==(GetResponseProp3 left, GetResponseProp3 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GetResponseProp3"/> values are not the same. </summary>
        public static bool operator !=(GetResponseProp3 left, GetResponseProp3 right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GetResponseProp3"/>. </summary>
        public static implicit operator GetResponseProp3(string value) => new GetResponseProp3(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GetResponseProp3 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GetResponseProp3 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
