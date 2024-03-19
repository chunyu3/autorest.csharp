// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using MgmtExtensionResource;

namespace MgmtExtensionResource.Models
{
    /// <summary> General metadata for the parameter. </summary>
    public partial class ParameterDefinitionsValueMetadata
    {
        /// <summary> Initializes a new instance of <see cref="ParameterDefinitionsValueMetadata"/>. </summary>
        public ParameterDefinitionsValueMetadata()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ParameterDefinitionsValueMetadata"/>. </summary>
        /// <param name="displayName"> The display name for the parameter. </param>
        /// <param name="description"> The description of the parameter. </param>
        /// <param name="strongType"> Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to choose from. </param>
        /// <param name="assignPermissions"> Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ParameterDefinitionsValueMetadata(string displayName, string description, string strongType, bool? assignPermissions, IDictionary<string, BinaryData> additionalProperties)
        {
            DisplayName = displayName;
            Description = description;
            StrongType = strongType;
            AssignPermissions = assignPermissions;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The display name for the parameter. </summary>
        public string DisplayName { get; set; }
        /// <summary> The description of the parameter. </summary>
        public string Description { get; set; }
        /// <summary> Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to choose from. </summary>
        public string StrongType { get; set; }
        /// <summary> Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope. </summary>
        public bool? AssignPermissions { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}