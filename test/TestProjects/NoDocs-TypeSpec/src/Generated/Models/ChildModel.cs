// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace NoDocsTypeSpec.Models
{
    /// <summary> ChildModel. </summary>
    public partial class ChildModel : BaseModel
    {
        /// <summary> Initializes a new instance of <see cref="ChildModel"/>. </summary>
        /// <param name="level"></param>
        /// <param name="parent"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="parent"/> is null. </exception>
        public ChildModel(sbyte level, IEnumerable<BaseModel> parent) : base(level)
        {
            Argument.AssertNotNull(parent, nameof(parent));

            Parent = parent.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChildModel"/>. </summary>
        /// <param name="level"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parent"></param>
        internal ChildModel(sbyte level, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<BaseModel> parent) : base(level, serializedAdditionalRawData)
        {
            Parent = parent;
        }

        /// <summary> Initializes a new instance of <see cref="ChildModel"/> for deserialization. </summary>
        internal ChildModel()
        {
        }

        /// <summary> Gets the parent. </summary>
        public IList<BaseModel> Parent { get; }
    }
}
