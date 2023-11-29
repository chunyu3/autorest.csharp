// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Inheritance.Models
{
    /// <summary> The ClassThatAlsoDefinesBaseClassProperty. </summary>
    internal partial class ClassThatAlsoDefinesBaseClassProperty
    {
        /// <summary> Initializes a new instance of <see cref="ClassThatAlsoDefinesBaseClassProperty"/>. </summary>
        internal ClassThatAlsoDefinesBaseClassProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClassThatAlsoDefinesBaseClassProperty"/>. </summary>
        /// <param name="baseClassProperty"></param>
        internal ClassThatAlsoDefinesBaseClassProperty(string baseClassProperty)
        {
            BaseClassProperty = baseClassProperty;
        }

        /// <summary> Gets the base class property. </summary>
        public string BaseClassProperty { get; }
    }
}
