// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.AdditionalProperties;
using _Type.Property.AdditionalProperties.Models;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_ExtendsUnknownDerived
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_ShortVersion()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response response = client.GetExtendsUnknownDerived(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_ShortVersion_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response response = await client.GetExtendsUnknownDerivedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_ShortVersion_Convenience()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response<ExtendsUnknownAdditionalPropertiesDerived> response = client.GetExtendsUnknownDerived();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_ShortVersion_Convenience_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response<ExtendsUnknownAdditionalPropertiesDerived> response = await client.GetExtendsUnknownDerivedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_AllParameters()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response response = client.GetExtendsUnknownDerived(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_AllParameters_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response response = await client.GetExtendsUnknownDerivedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_AllParameters_Convenience()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response<ExtendsUnknownAdditionalPropertiesDerived> response = client.GetExtendsUnknownDerived();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_GetExtendsUnknownDerived_AllParameters_Convenience_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            Response<ExtendsUnknownAdditionalPropertiesDerived> response = await client.GetExtendsUnknownDerivedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_Put_ShortVersion()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_Put_ShortVersion_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_Put_ShortVersion_Convenience()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            ExtendsUnknownAdditionalPropertiesDerived body = new ExtendsUnknownAdditionalPropertiesDerived("<name>", 1234);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_Put_ShortVersion_Convenience_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            ExtendsUnknownAdditionalPropertiesDerived body = new ExtendsUnknownAdditionalPropertiesDerived("<name>", 1234);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_Put_AllParameters()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_Put_AllParameters_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDerived_Put_AllParameters_Convenience()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            ExtendsUnknownAdditionalPropertiesDerived body = new ExtendsUnknownAdditionalPropertiesDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDerived_Put_AllParameters_Convenience_Async()
        {
            ExtendsUnknownDerived client = new AdditionalPropertiesClient().GetExtendsUnknownDerivedClient();

            ExtendsUnknownAdditionalPropertiesDerived body = new ExtendsUnknownAdditionalPropertiesDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = await client.PutAsync(body);
        }
    }
}
