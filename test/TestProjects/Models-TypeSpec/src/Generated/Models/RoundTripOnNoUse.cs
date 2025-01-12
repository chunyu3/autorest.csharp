// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> Derived model. </summary>
    public partial class RoundTripOnNoUse : NoUseBase
    {
        /// <summary> Initializes a new instance of <see cref="RoundTripOnNoUse"/>. </summary>
        /// <param name="baseModelProp"> base model property. </param>
        /// <param name="requiredList"> Required collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="baseModelProp"/> or <paramref name="requiredList"/> is null. </exception>
        public RoundTripOnNoUse(string baseModelProp, IEnumerable<CollectionItem> requiredList) : base(baseModelProp)
        {
            Argument.AssertNotNull(baseModelProp, nameof(baseModelProp));
            Argument.AssertNotNull(requiredList, nameof(requiredList));

            RequiredList = requiredList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripOnNoUse"/>. </summary>
        /// <param name="baseModelProp"> base model property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="requiredList"> Required collection. </param>
        internal RoundTripOnNoUse(string baseModelProp, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<CollectionItem> requiredList) : base(baseModelProp, serializedAdditionalRawData)
        {
            RequiredList = requiredList;
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripOnNoUse"/> for deserialization. </summary>
        internal RoundTripOnNoUse()
        {
        }

        /// <summary> Required collection. </summary>
        public IList<CollectionItem> RequiredList { get; }
    }
}
