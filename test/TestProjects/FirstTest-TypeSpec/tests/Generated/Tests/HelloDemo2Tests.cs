// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using FirstTestTypeSpec.Models;
using NUnit.Framework;

namespace FirstTestTypeSpec.Tests
{
    public partial class HelloDemo2Tests : FirstTestTypeSpecTestBase
    {
        public HelloDemo2Tests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloAgain_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                requiredString = "<requiredString>",
                requiredInt = 1234,
                requiredCollection = new object[]
            {
"1"
            },
                requiredDictionary = new
                {
                    key = "1",
                },
                requiredModel = new
                {
                    name = "<name>",
                    requiredUnion = "<requiredUnion>",
                    requiredLiteralString = "accept",
                    requiredLiteralInt = 123,
                    requiredLiteralFloat = 1.23F,
                    requiredLiteralBool = false,
                    requiredBadDescription = "<requiredBadDescription>",
                    requiredNullableList = new object[]
            {
1234
            },
                },
                requiredUnknown = new object(),
                requiredRecordUnknown = new
                {
                    key = new object(),
                },
                modelWithRequiredNullable = new
                {
                    requiredNullablePrimitive = 1234,
                    requiredExtensibleEnum = "1",
                    requiredFixedEnum = "1",
                },
            });
            Response response = await client.HelloAgainAsync("<p2>", "<p1>", content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloAgain_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            RoundTripModel action = new RoundTripModel(
                "<requiredString>",
                1234,
                new StringFixedEnum?[] { StringFixedEnum.One },
                new Dictionary<string, StringExtensibleEnum?>
                {
                    ["key"] = StringExtensibleEnum.One
                },
                new Thing("<name>", BinaryData.FromObjectAsJson("<requiredUnion>"), "<requiredBadDescription>", new int[] { 1234 }),
                BinaryData.FromObjectAsJson(new object()),
                new Dictionary<string, BinaryData>
                {
                    ["key"] = BinaryData.FromObjectAsJson(new object())
                },
                new ModelWithRequiredNullableProperties(1234, StringExtensibleEnum.One, StringFixedEnum.One));
            Response<RoundTripModel> response = await client.HelloAgainAsync("<p2>", "<p1>", action);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloAgain_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                requiredString = "<requiredString>",
                requiredInt = 1234,
                requiredCollection = new object[]
            {
"1"
            },
                requiredDictionary = new
                {
                    key = "1",
                },
                requiredModel = new
                {
                    name = "<name>",
                    requiredUnion = "<requiredUnion>",
                    requiredLiteralString = "accept",
                    requiredLiteralInt = 123,
                    requiredLiteralFloat = 1.23F,
                    requiredLiteralBool = false,
                    optionalLiteralString = "reject",
                    optionalLiteralInt = 456,
                    optionalLiteralFloat = 4.56F,
                    optionalLiteralBool = true,
                    requiredBadDescription = "<requiredBadDescription>",
                    optionalNullableList = new object[]
            {
1234
            },
                    requiredNullableList = new object[]
            {
1234
            },
                },
                intExtensibleEnum = 1,
                intExtensibleEnumCollection = new object[]
            {
1
            },
                floatExtensibleEnum = 1,
                floatExtensibleEnumCollection = new object[]
            {
1
            },
                floatFixedEnum = 1.1F,
                floatFixedEnumCollection = new object[]
            {
1.1F
            },
                intFixedEnum = 1,
                intFixedEnumCollection = new object[]
            {
1
            },
                stringFixedEnum = "1",
                requiredUnknown = new object(),
                optionalUnknown = new object(),
                requiredRecordUnknown = new
                {
                    key = new object(),
                },
                optionalRecordUnknown = new
                {
                    key = new object(),
                },
                modelWithRequiredNullable = new
                {
                    requiredNullablePrimitive = 1234,
                    requiredExtensibleEnum = "1",
                    requiredFixedEnum = "1",
                },
            });
            Response response = await client.HelloAgainAsync("<p2>", "<p1>", content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloAgain_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            RoundTripModel action = new RoundTripModel(
                "<requiredString>",
                1234,
                new StringFixedEnum?[] { StringFixedEnum.One },
                new Dictionary<string, StringExtensibleEnum?>
                {
                    ["key"] = StringExtensibleEnum.One
                },
                new Thing("<name>", BinaryData.FromObjectAsJson("<requiredUnion>"), "<requiredBadDescription>", new int[] { 1234 })
                {
                    OptionalLiteralString = ThingOptionalLiteralString.Reject,
                    OptionalLiteralInt = ThingOptionalLiteralInt._456,
                    OptionalLiteralFloat = ThingOptionalLiteralFloat._456,
                    OptionalLiteralBool = true,
                    OptionalNullableList = { 1234 },
                },
                BinaryData.FromObjectAsJson(new object()),
                new Dictionary<string, BinaryData>
                {
                    ["key"] = BinaryData.FromObjectAsJson(new object())
                },
                new ModelWithRequiredNullableProperties(1234, StringExtensibleEnum.One, StringFixedEnum.One))
            {
                IntExtensibleEnum = IntExtensibleEnum.One,
                IntExtensibleEnumCollection = { IntExtensibleEnum.One },
                FloatExtensibleEnum = FloatExtensibleEnum.One,
                FloatExtensibleEnumCollection = { FloatExtensibleEnum.One },
                FloatFixedEnum = FloatFixedEnum.One,
                FloatFixedEnumCollection = { FloatFixedEnum.One },
                IntFixedEnum = IntFixedEnum.One,
                IntFixedEnumCollection = { IntFixedEnum.One },
                StringFixedEnum = StringFixedEnum.One,
                OptionalUnknown = BinaryData.FromObjectAsJson(new object()),
                OptionalRecordUnknown =
{
["key"] = BinaryData.FromObjectAsJson(new object())
},
            };
            Response<RoundTripModel> response = await client.HelloAgainAsync("<p2>", "<p1>", action);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_NoContentType_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                requiredString = "<requiredString>",
                requiredInt = 1234,
                requiredCollection = new object[]
            {
"1"
            },
                requiredDictionary = new
                {
                    key = "1",
                },
                requiredModel = new
                {
                    name = "<name>",
                    requiredUnion = "<requiredUnion>",
                    requiredLiteralString = "accept",
                    requiredLiteralInt = 123,
                    requiredLiteralFloat = 1.23F,
                    requiredLiteralBool = false,
                    requiredBadDescription = "<requiredBadDescription>",
                    requiredNullableList = new object[]
            {
1234
            },
                },
                requiredUnknown = new object(),
                requiredRecordUnknown = new
                {
                    key = new object(),
                },
                modelWithRequiredNullable = new
                {
                    requiredNullablePrimitive = 1234,
                    requiredExtensibleEnum = "1",
                    requiredFixedEnum = "1",
                },
            });
            Response response = await client.NoContentTypeAsync("<p2>", "<p1>", content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_NoContentType_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                requiredString = "<requiredString>",
                requiredInt = 1234,
                requiredCollection = new object[]
            {
"1"
            },
                requiredDictionary = new
                {
                    key = "1",
                },
                requiredModel = new
                {
                    name = "<name>",
                    requiredUnion = "<requiredUnion>",
                    requiredLiteralString = "accept",
                    requiredLiteralInt = 123,
                    requiredLiteralFloat = 1.23F,
                    requiredLiteralBool = false,
                    optionalLiteralString = "reject",
                    optionalLiteralInt = 456,
                    optionalLiteralFloat = 4.56F,
                    optionalLiteralBool = true,
                    requiredBadDescription = "<requiredBadDescription>",
                    optionalNullableList = new object[]
            {
1234
            },
                    requiredNullableList = new object[]
            {
1234
            },
                },
                intExtensibleEnum = 1,
                intExtensibleEnumCollection = new object[]
            {
1
            },
                floatExtensibleEnum = 1,
                floatExtensibleEnumCollection = new object[]
            {
1
            },
                floatFixedEnum = 1.1F,
                floatFixedEnumCollection = new object[]
            {
1.1F
            },
                intFixedEnum = 1,
                intFixedEnumCollection = new object[]
            {
1
            },
                stringFixedEnum = "1",
                requiredUnknown = new object(),
                optionalUnknown = new object(),
                requiredRecordUnknown = new
                {
                    key = new object(),
                },
                optionalRecordUnknown = new
                {
                    key = new object(),
                },
                modelWithRequiredNullable = new
                {
                    requiredNullablePrimitive = 1234,
                    requiredExtensibleEnum = "1",
                    requiredFixedEnum = "1",
                },
            });
            Response response = await client.NoContentTypeAsync("<p2>", "<p1>", content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloDemoAgain_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response response = await client.HelloDemoAgainAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloDemoAgain_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response<Thing> response = await client.HelloDemoAgainAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloDemoAgain_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response response = await client.HelloDemoAgainAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloDemoAgain_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response<Thing> response = await client.HelloDemoAgainAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_CreateLiteral_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
                requiredUnion = "<requiredUnion>",
                requiredLiteralString = "accept",
                requiredLiteralInt = 123,
                requiredLiteralFloat = 1.23F,
                requiredLiteralBool = false,
                requiredBadDescription = "<requiredBadDescription>",
                requiredNullableList = new object[]
            {
1234
            },
            });
            Response response = await client.CreateLiteralAsync(content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_CreateLiteral_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Thing body = new Thing("<name>", BinaryData.FromObjectAsJson("<requiredUnion>"), "<requiredBadDescription>", new int[] { 1234 });
            Response<Thing> response = await client.CreateLiteralAsync(body);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_CreateLiteral_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
                requiredUnion = "<requiredUnion>",
                requiredLiteralString = "accept",
                requiredLiteralInt = 123,
                requiredLiteralFloat = 1.23F,
                requiredLiteralBool = false,
                optionalLiteralString = "reject",
                optionalLiteralInt = 456,
                optionalLiteralFloat = 4.56F,
                optionalLiteralBool = true,
                requiredBadDescription = "<requiredBadDescription>",
                optionalNullableList = new object[]
            {
1234
            },
                requiredNullableList = new object[]
            {
1234
            },
            });
            Response response = await client.CreateLiteralAsync(content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_CreateLiteral_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Thing body = new Thing("<name>", BinaryData.FromObjectAsJson("<requiredUnion>"), "<requiredBadDescription>", new int[] { 1234 })
            {
                OptionalLiteralString = ThingOptionalLiteralString.Reject,
                OptionalLiteralInt = ThingOptionalLiteralInt._456,
                OptionalLiteralFloat = ThingOptionalLiteralFloat._456,
                OptionalLiteralBool = true,
                OptionalNullableList = { 1234 },
            };
            Response<Thing> response = await client.CreateLiteralAsync(body);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloLiteral_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response response = await client.HelloLiteralAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloLiteral_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response<Thing> response = await client.HelloLiteralAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloLiteral_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response response = await client.HelloLiteralAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Demo2_HelloLiteral_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            HelloDemo2 client = CreateFirstTestTypeSpecClient(endpoint, credential).GetHelloClient().GetHelloDemo2Client();

            Response<Thing> response = await client.HelloLiteralAsync();
        }
    }
}
