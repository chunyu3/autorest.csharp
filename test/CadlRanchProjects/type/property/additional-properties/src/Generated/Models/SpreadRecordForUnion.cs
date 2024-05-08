// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model spread Record&lt;string | float32&gt;. </summary>
    public partial class SpreadRecordForUnion
    {
        /// <summary> Initializes a new instance of <see cref="SpreadRecordForUnion"/>. </summary>
        /// <param name="flag"> The name property. </param>
        public SpreadRecordForUnion(bool flag)
        {
            Flag = flag;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SpreadRecordForUnion"/>. </summary>
        /// <param name="flag"> The name property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SpreadRecordForUnion(bool flag, IDictionary<string, BinaryData> additionalProperties)
        {
            Flag = flag;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="SpreadRecordForUnion"/> for deserialization. </summary>
        internal SpreadRecordForUnion()
        {
        }

        /// <summary> The name property. </summary>
        public bool Flag { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="float"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
