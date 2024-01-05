// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Payload.MultiPart.Models
{
    /// <summary> The MultiPartRequest. </summary>
    public partial class MultiPartRequest
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

        /// <summary> Initializes a new instance of <see cref="MultiPartRequest"/>. </summary>
        /// <param name="id"></param>
        /// <param name="profileImage"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="profileImage"/> is null. </exception>
        public MultiPartRequest(string id, BinaryData profileImage)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(profileImage, nameof(profileImage));

            Id = id;
            ProfileImage = profileImage;
        }

        /// <summary> Initializes a new instance of <see cref="MultiPartRequest"/>. </summary>
        /// <param name="id"></param>
        /// <param name="profileImage"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultiPartRequest(string id, BinaryData profileImage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ProfileImage = profileImage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultiPartRequest"/> for deserialization. </summary>
        internal MultiPartRequest()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary>
        /// Gets the profile image
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ProfileImage { get; }
    }
}
