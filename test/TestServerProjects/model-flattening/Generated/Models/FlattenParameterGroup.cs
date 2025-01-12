// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace model_flattening.Models
{
    /// <summary> Parameter group. </summary>
    public partial class FlattenParameterGroup
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

        /// <summary> Initializes a new instance of <see cref="FlattenParameterGroup"/>. </summary>
        /// <param name="name"> Product name with value 'groupproduct'. </param>
        /// <param name="productId"> Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="productId"/> is null. </exception>
        public FlattenParameterGroup(string name, string productId)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(productId, nameof(productId));

            Name = name;
            ProductId = productId;
        }

        /// <summary> Initializes a new instance of <see cref="FlattenParameterGroup"/>. </summary>
        /// <param name="name"> Product name with value 'groupproduct'. </param>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="productId"> Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. </param>
        /// <param name="description"> Description of product. </param>
        /// <param name="maxProductDisplayName"> Display name of product. </param>
        /// <param name="capacity"> Capacity of product. For example, 4 people. </param>
        /// <param name="genericValue"> Generic URL value. </param>
        /// <param name="odataValue"> URL value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FlattenParameterGroup(string name, SimpleProduct simpleBodyProduct, string productId, string description, string maxProductDisplayName, SimpleProductPropertiesMaxProductCapacity? capacity, string genericValue, string odataValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SimpleBodyProduct = simpleBodyProduct;
            ProductId = productId;
            Description = description;
            MaxProductDisplayName = maxProductDisplayName;
            Capacity = capacity;
            GenericValue = genericValue;
            OdataValue = odataValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FlattenParameterGroup"/> for deserialization. </summary>
        internal FlattenParameterGroup()
        {
        }

        /// <summary> Product name with value 'groupproduct'. </summary>
        public string Name { get; }
        /// <summary> Simple body product to put. </summary>
        public SimpleProduct SimpleBodyProduct { get; set; }
        /// <summary> Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. </summary>
        public string ProductId { get; }
        /// <summary> Description of product. </summary>
        public string Description { get; set; }
        /// <summary> Display name of product. </summary>
        public string MaxProductDisplayName { get; set; }
        /// <summary> Capacity of product. For example, 4 people. </summary>
        public SimpleProductPropertiesMaxProductCapacity? Capacity { get; set; }
        /// <summary> Generic URL value. </summary>
        public string GenericValue { get; set; }
        /// <summary> URL value. </summary>
        public string OdataValue { get; set; }
    }
}
