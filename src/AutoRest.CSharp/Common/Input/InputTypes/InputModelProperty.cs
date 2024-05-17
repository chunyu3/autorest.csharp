﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace AutoRest.CSharp.Common.Input;

internal record InputModelProperty(string Name, string SerializedName, string Description, InputType Type, InputConstant? ConstantValue, bool IsRequired, bool IsReadOnly, bool IsDiscriminator, bool IsNullable, IReadOnlyList<string>? FlattenedNames = null)
{
    public FormattableString? DefaultValue { get; init; }
}
