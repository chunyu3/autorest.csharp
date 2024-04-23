// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace FirstTestTypeSpec.Models
{
    internal static partial class VersionsExtensions
    {
        public static string ToSerialString(this Versions value) => value switch
        {
            Versions._20220515Preview => "2022-05-15-preview",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Versions value.")
        };

        public static Versions ToVersions(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "2022-05-15-preview")) return Versions._20220515Preview;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Versions value.");
        }
    }
}