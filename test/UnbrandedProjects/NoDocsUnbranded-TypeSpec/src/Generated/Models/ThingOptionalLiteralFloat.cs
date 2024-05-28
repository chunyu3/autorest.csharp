// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace NoDocsUnbrandedTypeSpec.Models
{
    /// <summary> The Thing_optionalLiteralFloat. </summary>
    public readonly partial struct ThingOptionalLiteralFloat : IEquatable<ThingOptionalLiteralFloat>
    {
        private readonly float _value;

        /// <summary> Initializes a new instance of <see cref="ThingOptionalLiteralFloat"/>. </summary>
        public ThingOptionalLiteralFloat(float value)
        {
            _value = value;
        }

        private const float _456Value = 4.56F;

        /// <summary> 4.56. </summary>
        public static ThingOptionalLiteralFloat _456 { get; } = new ThingOptionalLiteralFloat(_456Value);

        internal float ToSerialSingle() => _value;

        /// <summary> Determines if two <see cref="ThingOptionalLiteralFloat"/> values are the same. </summary>
        public static bool operator ==(ThingOptionalLiteralFloat left, ThingOptionalLiteralFloat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThingOptionalLiteralFloat"/> values are not the same. </summary>
        public static bool operator !=(ThingOptionalLiteralFloat left, ThingOptionalLiteralFloat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ThingOptionalLiteralFloat"/>. </summary>
        public static implicit operator ThingOptionalLiteralFloat(float value) => new ThingOptionalLiteralFloat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThingOptionalLiteralFloat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThingOptionalLiteralFloat other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
