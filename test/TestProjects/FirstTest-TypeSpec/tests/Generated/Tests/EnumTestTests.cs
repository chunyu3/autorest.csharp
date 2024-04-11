// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace FirstTestTypeSpec.Tests
{
    public partial class EnumTestTests : FirstTestTypeSpecTestBase
    {
        public EnumTestTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task EnumTest_CreateUnknownValue_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = null;
            EnumTest client = CreateFirstTestTypeSpecClient(endpoint, credential).GetEnumTestClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.CreateUnknownValueAsync(content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task EnumTest_CreateUnknownValue_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = null;
            EnumTest client = CreateFirstTestTypeSpecClient(endpoint, credential).GetEnumTestClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.CreateUnknownValueAsync(content);
        }
    }
}
