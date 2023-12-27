﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Common.Output.Models.Serialization.Multipart
{
    internal class MultipartAdditionalPropertiesSerialization: MultipartPropertySerialization
    {
        public CSharpType Type { get; }

        public MultipartAdditionalPropertiesSerialization(ObjectTypeProperty property, MulitipartSerialization valueSerialization, CSharpType type, ValueExpression toBinaryDataExpress, bool shouldExcludeInWireSerialization)
            : base(property.Declaration.Name.ToVariableName(), new TypedMemberExpression(null, property.Declaration.Name, property.Declaration.Type), property.Declaration.Name, property.ValueType, true, toBinaryDataExpress, shouldExcludeInWireSerialization)
        {
            Type = type;
        }
    }
}