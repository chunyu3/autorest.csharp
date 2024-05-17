// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace AutoRest.CSharp.Common.Input;

internal record InputGenericType(Type Type, InputType ArgumentType) : InputType(Type.Name);
