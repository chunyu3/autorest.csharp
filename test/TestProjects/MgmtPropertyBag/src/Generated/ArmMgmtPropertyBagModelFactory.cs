// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtPropertyBag;

namespace MgmtPropertyBag.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtPropertyBagModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="MgmtPropertyBag.FooData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="details"> The details of the resource. </param>
        /// <returns> A new <see cref="MgmtPropertyBag.FooData"/> instance for mocking. </returns>
        public static FooData FooData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string details = null)
        {
            return new FooData(id, name, resourceType, systemData, details);
        }

        /// <summary> Initializes a new instance of <see cref="MgmtPropertyBag.BarData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="details"> The details of the resource. </param>
        /// <returns> A new <see cref="MgmtPropertyBag.BarData"/> instance for mocking. </returns>
        public static BarData BarData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string details = null)
        {
            return new BarData(id, name, resourceType, systemData, details);
        }
    }
}