﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using AutoRest.CSharp.Output.Models.Shared;

namespace AutoRest.CSharp.Output.Models
{
    internal class OverloadMethodSignature
    {
        public MethodSignature MethodSignature { get; }
        public MethodSignature PreviousMethodSignature { get; }
        public IReadOnlyList<Parameter> MissingParameters { get; }
        public FormattableString? Description { get; }
        public bool IsHiddenFromUser { get; }

        public OverloadMethodSignature(MethodSignature methodSignature, MethodSignature previousMethodSignature, IReadOnlyList<Parameter> missingParameters, FormattableString? description, bool isHiddenFromUser)
        {
            MethodSignature = methodSignature;
            PreviousMethodSignature = previousMethodSignature;
            MissingParameters = missingParameters;
            Description = description;
            IsHiddenFromUser = isHiddenFromUser;
        }
    }
}
