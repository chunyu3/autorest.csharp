// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace body_complex.Models
{
    /// <summary> The UnknownMyBaseType. </summary>
    internal partial class UnknownMyBaseType : MyBaseType
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMyBaseType"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="propB1"></param>
        /// <param name="propBH1"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMyBaseType(MyKind kind, string propB1, string propBH1, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, propB1, propBH1, serializedAdditionalRawData)
        {
            Kind = kind;
        }
    }
}
