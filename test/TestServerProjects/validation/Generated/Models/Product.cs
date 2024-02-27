// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace validation.Models
{
    /// <summary> The product documentation. </summary>
    public partial class Product
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

        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        /// <param name="child"> The product documentation. </param>
        /// <param name="constChild"> The product documentation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="child"/> or <paramref name="constChild"/> is null. </exception>
        public Product(ChildProduct child, ConstantProduct constChild)
        {
            if (child == null)
            {
                throw new ArgumentNullException(nameof(child));
            }
            if (constChild == null)
            {
                throw new ArgumentNullException(nameof(constChild));
            }

            DisplayNames = new ChangeTrackingList<string>();
            Child = child;
            ConstChild = constChild;
            ConstInt = ProductConstInt._0;
            ConstString = ProductConstString.Constant;
        }

        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        /// <param name="displayNames"> Non required array of unique items from 0 to 6 elements. </param>
        /// <param name="capacity"> Non required int betwen 0 and 100 exclusive. </param>
        /// <param name="image"> Image URL representing the product. </param>
        /// <param name="child"> The product documentation. </param>
        /// <param name="constChild"> The product documentation. </param>
        /// <param name="constInt"> Constant int. </param>
        /// <param name="constString"> Constant string. </param>
        /// <param name="constStringAsEnum"> Constant string as Enum. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Product(IList<string> displayNames, int? capacity, string image, ChildProduct child, ConstantProduct constChild, ProductConstInt constInt, ProductConstString constString, EnumConst? constStringAsEnum, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayNames = displayNames;
            Capacity = capacity;
            Image = image;
            Child = child;
            ConstChild = constChild;
            ConstInt = constInt;
            ConstString = constString;
            ConstStringAsEnum = constStringAsEnum;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Product"/> for deserialization. </summary>
        internal Product()
        {
        }

        /// <summary> Non required array of unique items from 0 to 6 elements. </summary>
        public IList<string> DisplayNames { get; }
        /// <summary> Non required int betwen 0 and 100 exclusive. </summary>
        public int? Capacity { get; set; }
        /// <summary> Image URL representing the product. </summary>
        public string Image { get; set; }
        /// <summary> The product documentation. </summary>
        public ChildProduct Child { get; set; }
        /// <summary> The product documentation. </summary>
        public ConstantProduct ConstChild { get; set; }
        /// <summary> Constant int. </summary>
        public ProductConstInt ConstInt { get; }
        /// <summary> Constant string. </summary>
        public ProductConstString ConstString { get; }
        /// <summary> Constant string as Enum. </summary>
        public EnumConst? ConstStringAsEnum { get; set; }
    }
}
