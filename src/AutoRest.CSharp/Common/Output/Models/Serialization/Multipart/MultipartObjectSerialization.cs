﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Common.Output.Models.Serialization.Multipart
{
    internal class MultipartObjectSerialization
    {
        public MultipartObjectSerialization(SerializableObjectType model, IReadOnlyList<Parameter> constructorParameters, IReadOnlyList<MultipartPropertySerialization> properties, MultipartAdditionalPropertiesSerialization? additionalProperties, ObjectTypeDiscriminator? discriminator, bool includeConverter)
        {
            Type = model.Type;
            ConstructorParameters = constructorParameters;
            Properties = properties;
            AdditionalProperties = additionalProperties;
            Discriminator = discriminator;
            // select interface model type here
            var modelType = model.IsUnknownDerivedType && model.Inherits is { IsFrameworkType: false, Implementation: { } baseModel } ? baseModel.Type : model.Type;
        }
        public CSharpType Type { get; }
        public IReadOnlyList<Parameter> ConstructorParameters { get; }
        public IReadOnlyList<MultipartPropertySerialization> Properties { get; }
        public MultipartAdditionalPropertiesSerialization? AdditionalProperties { get; }
        public ObjectTypeDiscriminator? Discriminator { get; }
    }
}