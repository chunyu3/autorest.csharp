// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace body_complex.Models
{
    /// <summary> The DotFishMarket. </summary>
    public partial class DotFishMarket
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DotFishMarket"/>. </summary>
        internal DotFishMarket()
        {
            Salmons = new ChangeTrackingList<DotSalmon>();
            Fishes = new ChangeTrackingList<DotFish>();
        }

        /// <summary> Initializes a new instance of <see cref="DotFishMarket"/>. </summary>
        /// <param name="sampleSalmon"></param>
        /// <param name="salmons"></param>
        /// <param name="sampleFish">
        /// Please note <see cref="DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DotSalmon"/>.
        /// </param>
        /// <param name="fishes">
        /// Please note <see cref="DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DotSalmon"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DotFishMarket(DotSalmon sampleSalmon, IReadOnlyList<DotSalmon> salmons, DotFish sampleFish, IReadOnlyList<DotFish> fishes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SampleSalmon = sampleSalmon;
            Salmons = salmons;
            SampleFish = sampleFish;
            Fishes = fishes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the sample salmon. </summary>
        public DotSalmon SampleSalmon { get; }
        /// <summary> Gets the salmons. </summary>
        public IReadOnlyList<DotSalmon> Salmons { get; }
        /// <summary>
        /// Gets the sample fish
        /// Please note <see cref="DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DotSalmon"/>.
        /// </summary>
        public DotFish SampleFish { get; }
        /// <summary>
        /// Gets the fishes
        /// Please note <see cref="DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DotSalmon"/>.
        /// </summary>
        public IReadOnlyList<DotFish> Fishes { get; }
    }
}
