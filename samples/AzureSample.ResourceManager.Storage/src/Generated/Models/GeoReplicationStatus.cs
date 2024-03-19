// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AzureSample.ResourceManager.Storage.Models
{
    /// <summary> The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable. </summary>
    public readonly partial struct GeoReplicationStatus : IEquatable<GeoReplicationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GeoReplicationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GeoReplicationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LiveValue = "Live";
        private const string BootstrapValue = "Bootstrap";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Live. </summary>
        public static GeoReplicationStatus Live { get; } = new GeoReplicationStatus(LiveValue);
        /// <summary> Bootstrap. </summary>
        public static GeoReplicationStatus Bootstrap { get; } = new GeoReplicationStatus(BootstrapValue);
        /// <summary> Unavailable. </summary>
        public static GeoReplicationStatus Unavailable { get; } = new GeoReplicationStatus(UnavailableValue);
        /// <summary> Determines if two <see cref="GeoReplicationStatus"/> values are the same. </summary>
        public static bool operator ==(GeoReplicationStatus left, GeoReplicationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GeoReplicationStatus"/> values are not the same. </summary>
        public static bool operator !=(GeoReplicationStatus left, GeoReplicationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GeoReplicationStatus"/>. </summary>
        public static implicit operator GeoReplicationStatus(string value) => new GeoReplicationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeoReplicationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GeoReplicationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}