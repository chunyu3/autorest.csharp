﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoRest.CSharp.Common.Input.Examples
{
    internal sealed class TypeSpecInputExampleValueConverter : JsonConverter<InputExampleValue>
    {
        private const string KindPropertyName = "kind";
        private const string TypePropertyName = "type";
        private const string ValuePropertyName = "value";

        private readonly TypeSpecReferenceHandler _referenceHandler;

        public TypeSpecInputExampleValueConverter(TypeSpecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputExampleValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.ReadReferenceAndResolve<InputExampleValue>(_referenceHandler.CurrentResolver) ?? CreateObject(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, InputExampleValue value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        private InputExampleValue CreateObject(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            string? id = null;
            string? kind = null;
            InputExampleValue? result = null;
            var isFirstProperty = true;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isIdOrKind = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(KindPropertyName, ref kind);

                if (isIdOrKind)
                {
                    continue;
                }
                result = CreateDerivedType(ref reader, id, kind, options);
            }

            return result ?? CreateDerivedType(ref reader, id, kind, options);
        }

        private const string ModelKind = "model";
        private const string ArrayKind = "array";
        private const string DictionaryKind = "dict";
        private const string UnknownKind = "unknown";

        private InputExampleValue CreateDerivedType(ref Utf8JsonReader reader, string? id, string? kind, JsonSerializerOptions options) => kind switch
        {
            null => throw new JsonException($"InputTypeExample (id: '{id}') must have a 'kind' property"),
            ArrayKind => CreateArrayExample(ref reader, id, options, _referenceHandler.CurrentResolver),
            DictionaryKind or ModelKind => CreateObjectExample(ref reader, id, options, _referenceHandler.CurrentResolver),
            UnknownKind => CreateUnknownExample(ref reader, id, options, _referenceHandler.CurrentResolver),
            _ => CreateOtherExample(ref reader, id, options, _referenceHandler.CurrentResolver),
        };

        private InputExampleValue CreateArrayExample(ref Utf8JsonReader reader, string? id, JsonSerializerOptions options, ReferenceResolver referenceResolver)
        {
            bool isFirstProperty = id == null;
            InputType? type = null;
            IReadOnlyList<InputExampleValue>? value = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadWithConverter(TypePropertyName, options, ref type)
                    || reader.TryReadWithConverter(ValuePropertyName, options, ref value);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            var result = new InputExampleListValue(type ?? throw new JsonException(), value ?? throw new JsonException());

            if (id != null)
            {
                referenceResolver.AddReference(id, result);
            }

            return result;
        }

        private InputExampleValue CreateObjectExample(ref Utf8JsonReader reader, string? id, JsonSerializerOptions options, ReferenceResolver referenceResolver)
        {
            bool isFirstProperty = id == null;
            InputType? type = null;
            IReadOnlyDictionary<string, InputExampleValue>? value = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadWithConverter(TypePropertyName, options, ref type)
                    || reader.TryReadWithConverter(ValuePropertyName, options, ref value);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            var result = new InputExampleObjectValue(type ?? throw new JsonException(), value ?? throw new JsonException());

            if (id != null)
            {
                referenceResolver.AddReference(id, result);
            }

            return result;
        }

        private InputExampleValue CreateUnknownExample(ref Utf8JsonReader reader, string? id, JsonSerializerOptions options, ReferenceResolver referenceResolver)
        {
            bool isFirstProperty = id == null;
            InputType? type = null;
            JsonElement? rawValue = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadWithConverter(TypePropertyName, options, ref type)
                    || reader.TryReadWithConverter(ValuePropertyName, options, ref rawValue);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            var result = ParseUnknownValue(type ?? throw new JsonException(), rawValue);

            if (id != null)
            {
                referenceResolver.AddReference(id, result);
            }

            return result;

            static InputExampleValue ParseUnknownValue(InputType type, JsonElement? rawValue)
            {
                switch (rawValue?.ValueKind)
                {
                    case null or JsonValueKind.Null:
                        return InputExampleValue.Null(type);
                    case JsonValueKind.String:
                        return InputExampleValue.Value(type, rawValue.Value.GetString());
                    case JsonValueKind.True or JsonValueKind.False:
                        return InputExampleValue.Value(type, rawValue.Value.GetBoolean());
                    case JsonValueKind.Number:
                        if (rawValue.Value.TryGetInt32(out var int32Value))
                            return InputExampleValue.Value(type, int32Value);
                        else if (rawValue.Value.TryGetInt64(out var int64Value))
                            return InputExampleValue.Value(type, int64Value);
                        return InputExampleValue.Value(type, rawValue.Value.GetDouble());
                    case JsonValueKind.Array:
                        var length = rawValue.Value.GetArrayLength();
                        var values = new List<InputExampleValue>(length);
                        foreach (var item in rawValue.Value.EnumerateArray())
                        {
                            values.Add(ParseUnknownValue(type, item));
                        }
                        return InputExampleValue.List(type, values);
                    case JsonValueKind.Object:
                        var objValues = new Dictionary<string, InputExampleValue>();
                        foreach (var property in rawValue.Value.EnumerateObject())
                        {
                            objValues.Add(property.Name, ParseUnknownValue(type, property.Value));
                        }
                        return InputExampleValue.Object(type, objValues);
                    default:
                        throw new JsonException($"kind {rawValue?.ValueKind} is not expected here");
                }
            }
        }

        private InputExampleValue CreateOtherExample(ref Utf8JsonReader reader, string? id, JsonSerializerOptions options, ReferenceResolver referenceResolver)
        {
            bool isFirstProperty = id == null;
            InputType? type = null;
            JsonElement? rawValue = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadWithConverter(TypePropertyName, options, ref type)
                    || reader.TryReadWithConverter(ValuePropertyName, options, ref rawValue);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            object? value = rawValue?.ValueKind switch
            {
                null or JsonValueKind.Null => null,
                JsonValueKind.String => rawValue.Value.GetString(),
                JsonValueKind.False => false,
                JsonValueKind.True => true,
                JsonValueKind.Number => rawValue.Value.GetDouble(),
                _ => throw new JsonException($"kind {rawValue?.ValueKind} is not expected here")
            };

            var result = new InputExampleRawValue(type ?? throw new JsonException(), value);

            if (id != null)
            {
                referenceResolver.AddReference(id, result);
            }

            return result;
        }
    }
}