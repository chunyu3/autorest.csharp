// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Specs_.Azure.Core.Page.Models
{
    /// <summary> UserOrder for testing list with expand. </summary>
    public partial class UserOrder
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

        /// <summary> Initializes a new instance of <see cref="UserOrder"/>. </summary>
        /// <param name="userId"> The user's id. </param>
        /// <param name="detail"> The user's order detail. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detail"/> is null. </exception>
        internal UserOrder(int userId, string detail)
        {
            Argument.AssertNotNull(detail, nameof(detail));

            UserId = userId;
            Detail = detail;
        }

        /// <summary> Initializes a new instance of <see cref="UserOrder"/>. </summary>
        /// <param name="id"> The user's id. </param>
        /// <param name="userId"> The user's id. </param>
        /// <param name="detail"> The user's order detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserOrder(int id, int userId, string detail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            UserId = userId;
            Detail = detail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UserOrder"/> for deserialization. </summary>
        internal UserOrder()
        {
        }

        /// <summary> The user's id. </summary>
        public int Id { get; }
        /// <summary> The user's id. </summary>
        public int UserId { get; }
        /// <summary> The user's order detail. </summary>
        public string Detail { get; }
    }
}
