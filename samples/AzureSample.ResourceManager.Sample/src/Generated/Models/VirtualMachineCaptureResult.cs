// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using AzureSample.ResourceManager.Sample;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Output of virtual machine capture operation.
    /// Serialized Name: VirtualMachineCaptureResult
    /// </summary>
    public partial class VirtualMachineCaptureResult : SubResource
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineCaptureResult"/>. </summary>
        public VirtualMachineCaptureResult()
        {
            Resources = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineCaptureResult"/>. </summary>
        /// <param name="id">
        /// Resource Id
        /// Serialized Name: SubResource.id
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="schema">
        /// the schema of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.$schema
        /// </param>
        /// <param name="contentVersion">
        /// the version of the content
        /// Serialized Name: VirtualMachineCaptureResult.contentVersion
        /// </param>
        /// <param name="parameters">
        /// parameters of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.parameters
        /// </param>
        /// <param name="resources">
        /// a list of resource items of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.resources
        /// </param>
        internal VirtualMachineCaptureResult(string id, IDictionary<string, BinaryData> serializedAdditionalRawData, string schema, string contentVersion, BinaryData parameters, IReadOnlyList<BinaryData> resources) : base(id, serializedAdditionalRawData)
        {
            Schema = schema;
            ContentVersion = contentVersion;
            Parameters = parameters;
            Resources = resources;
        }

        /// <summary>
        /// the schema of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.$schema
        /// </summary>
        [WirePath("$schema")]
        public string Schema { get; }
        /// <summary>
        /// the version of the content
        /// Serialized Name: VirtualMachineCaptureResult.contentVersion
        /// </summary>
        [WirePath("contentVersion")]
        public string ContentVersion { get; }
        /// <summary>
        /// parameters of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.parameters
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("parameters")]
        public BinaryData Parameters { get; }
        /// <summary>
        /// a list of resource items of the captured virtual machine
        /// Serialized Name: VirtualMachineCaptureResult.resources
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("resources")]
        public IReadOnlyList<BinaryData> Resources { get; }
    }
}