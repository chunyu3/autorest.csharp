// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    /// <summary> The base model. </summary>
    public partial class BaseModel
    {
        /// <summary> Initializes a new instance of BaseModel. </summary>
        /// <param name="name"> The name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BaseModel(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of BaseModel. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="size"> The size. </param>
        internal BaseModel(string name, double? size)
        {
            Name = name;
            Size = size;
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The size. </summary>
        public double? Size { get; }
    }
}
