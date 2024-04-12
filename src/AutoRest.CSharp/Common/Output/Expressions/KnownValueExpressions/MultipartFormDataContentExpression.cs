﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net.Http;
using AutoRest.CSharp.Common.Output.Expressions.Statements;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;

namespace AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions
{
    internal sealed record MultipartFormDataContentExpression(ValueExpression Untyped) : TypedValueExpression<MultipartFormDataContent>(Untyped)
    {
        public MethodBodyStatement Add(ValueExpression content, ValueExpression name, ValueExpression fileName) => new InvokeInstanceMethodStatement(Untyped, nameof(MultipartFormDataContent.Add), new[] { content, name, fileName }, false);
        public MethodBodyStatement Add(ValueExpression content, ValueExpression name) => new InvokeInstanceMethodStatement(Untyped, nameof(MultipartFormDataContent.Add), new[] { content, name }, false);
        public ValueExpression Headers => Property(nameof(MultipartFormDataContent.Headers));
    }
}
