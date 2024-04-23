﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using YamlDotNet.Serialization.TypeInspectors;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class TypeSpecInputModelTypeConverter : JsonConverter<InputModelType>
    {
        private readonly TypeSpecReferenceHandler _referenceHandler;

        public TypeSpecInputModelTypeConverter(TypeSpecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputModelType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => ReadModelType(ref reader, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputModelType value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        private static InputModelType? ReadModelType(ref Utf8JsonReader reader, JsonSerializerOptions options, ReferenceResolver resolver)
            => reader.ReadReferenceAndResolve<InputModelType>(resolver) ?? CreateModelType(ref reader, null, null, options, resolver);

        public static InputModelType CreateModelType(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = id == null && name == null;
            var mediaTypes = new List<string>();
            var properties = new List<InputModelProperty>();
            bool isNullable = false;
            string? ns = null;
            string? accessibility = null;
            string? deprecated = null;
            string? description = null;
            string? usageString = null;
            string? discriminatorPropertyName = null;
            string? discriminatorValue = null;
            InputDictionaryType? inheritedDictionaryType = null;
            InputModelType? baseModel = null;
            InputModelType? model = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputModelType.Name), ref name)
                    || reader.TryReadBoolean(nameof(InputModelType.IsNullable), ref isNullable)
                    || reader.TryReadString(nameof(InputModelType.Namespace), ref ns)
                    || reader.TryReadString(nameof(InputModelType.Accessibility), ref accessibility)
                    || reader.TryReadString(nameof(InputModelType.Deprecated), ref deprecated)
                    || reader.TryReadString(nameof(InputModelType.Description), ref description)
                    || reader.TryReadString(nameof(InputModelType.Usage), ref usageString)
                    || reader.TryReadString(nameof(InputModelType.DiscriminatorPropertyName), ref discriminatorPropertyName)
                    || reader.TryReadString(nameof(InputModelType.DiscriminatorValue), ref discriminatorValue)
                    || reader.TryReadWithConverter(nameof(InputModelType.InheritedDictionaryType), options, ref inheritedDictionaryType);

                if (isKnownProperty)
                {
                    continue;
                }
                if (reader.GetString() == nameof(InputModelType.MediaTypes))
                {
                    reader.Read();
                    CreatMediaTypes(ref reader, mediaTypes, options);
                    continue;
                }
                /**
                 * If the model has base model, `BaseModel` and `Properties` should be the last two items in tspCodeModel.
                 * and `BaseModel` should be last but one, and `Properties` should be the last one.
                 */
                if (reader.GetString() == nameof(InputModelType.BaseModel))
                {
                    model = CreateInputModelTypeInstance(id, name, ns, accessibility, deprecated, description, usageString, discriminatorValue, discriminatorPropertyName, baseModel, properties, inheritedDictionaryType, isNullable, mediaTypes, resolver);
                    reader.TryReadWithConverter(nameof(InputModelType.BaseModel), options, ref baseModel);
                    if (baseModel != null)
                    {
                        model.SetBaseModel(baseModel);
                        var baseModelDerived = (List<InputModelType>)resolver.ResolveReference($"{baseModel.Name}.{nameof(InputModelType.DerivedModels)}");
                        baseModelDerived.Add(model);
                    }
                    continue;
                }
                if (reader.GetString() == nameof(InputModelType.Properties))
                {
                    model = model ?? CreateInputModelTypeInstance(id, name, ns, accessibility, deprecated, description, usageString, discriminatorValue, discriminatorPropertyName, baseModel, properties, inheritedDictionaryType, isNullable, mediaTypes, resolver);
                    reader.Read();
                    CreateProperties(ref reader, properties, options, mediaTypes.Contains("multipart/form-data"));
                    if (reader.TokenType != JsonTokenType.EndObject)
                    {
                        throw new JsonException($"{nameof(InputModelType)}.{nameof(InputModelType.Properties)} must be the last defined property.");
                    }
                }
                else
                {
                    reader.SkipProperty();
                }
            }

            return model ?? CreateInputModelTypeInstance(id, name, ns, accessibility, deprecated, description, usageString, discriminatorValue, discriminatorPropertyName, baseModel, properties, inheritedDictionaryType, isNullable, mediaTypes, resolver);
        }

        private static void CreatMediaTypes(ref Utf8JsonReader reader, ICollection<string> mediaTypes, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                var type = reader.ReadWithConverter<string>(options);
                mediaTypes.Add(type ?? throw new JsonException($"null item isn't allowed"));
            }
            reader.Read();
        }
        private static InputModelType CreateInputModelTypeInstance(string? id, string? name, string? ns, string? accessibility, string? deprecated, string? description, string? usageString, string? discriminatorValue, string? discriminatorPropertyValue, InputModelType? baseModel, IReadOnlyList<InputModelProperty> properties, InputDictionaryType? inheritedDictionaryType, bool isNullable, IReadOnlyList<string> mediaTypes, ReferenceResolver resolver)
        {
            name = name ?? throw new JsonException("Model must have name");
            InputModelTypeUsage usage = InputModelTypeUsage.None;
            if (usageString != null)
            {
                Enum.TryParse(usageString, ignoreCase: true, out usage);
            }

            var derivedModels = new List<InputModelType>();
            var model = new InputModelType(name, ns, accessibility, deprecated, description, usage, properties, baseModel, derivedModels, discriminatorValue, discriminatorPropertyValue, inheritedDictionaryType, IsNullable: isNullable, mediaTypes);

            if (id is not null)
            {
                resolver.AddReference(id, model);
                resolver.AddReference($"{model.Name}.{nameof(InputModelType.DerivedModels)}", derivedModels);
            }

            if (baseModel is not null)
            {
                var baseModelDerived = (List<InputModelType>)resolver.ResolveReference($"{baseModel.Name}.{nameof(InputModelType.DerivedModels)}");
                baseModelDerived.Add(model);
            }

            return model;
        }

        private static void CreateProperties(ref Utf8JsonReader reader, ICollection<InputModelProperty> properties, JsonSerializerOptions options, bool isMultipartType)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                var property = reader.ReadWithConverter<InputModelProperty>(options);
                if (property != null && isMultipartType)
                {
                    var propertyType = property.Type;
                    switch (property.Type)
                    {
                        case InputPrimitiveType primitiveType when primitiveType.Name.Equals("Bytes"):
                            propertyType = InputPrimitiveType.Stream;
                            break;
                        case InputListType listType when listType.ElementType.Name.Equals("Bytes"):
                            propertyType = new InputListType(listType.Name, InputPrimitiveType.Stream, listType.IsEmbeddingsVector, listType.IsNullable);
                            break;
                        case InputDictionaryType dictionaryType when dictionaryType.ValueType.Name.Equals("Bytes"):
                            propertyType = new InputDictionaryType(dictionaryType.Name, dictionaryType.KeyType, InputPrimitiveType.Stream, dictionaryType.IsNullable);
                            break;
                        default:
                            break;
                    }

                    property = new InputModelProperty(property.Name,
                                                    property.SerializedName,
                                                    property.Description,
                                                    propertyType,
                                                    property.ConstantValue,
                                                    property.IsRequired,
                                                    property.IsReadOnly,
                                                    property.IsDiscriminator,
                                                    property.FlattenedNames);
                }
                properties.Add(property ?? throw new JsonException($"null {nameof(InputModelProperty)} is not allowed"));
            }
            reader.Read();
        }
    }
}
