// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> moderation models. </summary>
    public readonly partial struct ModerationModels : IEquatable<ModerationModels>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModerationModels"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModerationModels(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextModerationLatestValue = "text-moderation-latest";
        private const string TextModerationStableValue = "text-moderation-stable";

        /// <summary> text-moderation-latest. </summary>
        public static ModerationModels TextModerationLatest { get; } = new ModerationModels(TextModerationLatestValue);
        /// <summary> text-moderation-stable. </summary>
        public static ModerationModels TextModerationStable { get; } = new ModerationModels(TextModerationStableValue);
        /// <summary> Determines if two <see cref="ModerationModels"/> values are the same. </summary>
        public static bool operator ==(ModerationModels left, ModerationModels right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModerationModels"/> values are not the same. </summary>
        public static bool operator !=(ModerationModels left, ModerationModels right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModerationModels"/>. </summary>
        public static implicit operator ModerationModels(string value) => new ModerationModels(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModerationModels other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModerationModels other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}