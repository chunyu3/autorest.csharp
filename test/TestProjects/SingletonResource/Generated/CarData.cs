// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace SingletonResource
{
    /// <summary> A class representing the Car data model. </summary>
    public partial class CarData : Resource
    {
        /// <summary> Initializes a new instance of CarData. </summary>
        public CarData()
        {
        }

        /// <summary> Initializes a new instance of CarData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="horsepower"></param>
        internal CarData(ResourceIdentifier id, string name, ResourceType type, string horsepower) : base(id, name, type)
        {
            Horsepower = horsepower;
        }

        /// <summary> Gets or sets the horsepower. </summary>
        public string Horsepower { get; set; }
    }
}
