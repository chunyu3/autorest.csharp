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
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    internal class Samples_Float
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFloat()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response response = client.GetFloat(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFloat_AllParameters()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response response = client.GetFloat(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFloat_Convenience()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response<FloatProperty> response = client.GetFloat();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFloat_AllParameters_Convenience()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response<FloatProperty> response = client.GetFloat();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFloat_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response response = await client.GetFloatAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFloat_AllParameters_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response response = await client.GetFloatAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFloat_Convenience_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response<FloatProperty> response = await client.GetFloatAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFloat_AllParameters_Convenience_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            Response<FloatProperty> response = await client.GetFloatAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 123.45F,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 123.45F,
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_Convenience()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            FloatProperty body = new FloatProperty(123.45F);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            FloatProperty body = new FloatProperty(123.45F);
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 123.45F,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = 123.45F,
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            FloatProperty body = new FloatProperty(123.45F);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            Float client = new ValueTypesClient().GetFloatClient(apiVersion: "1.0.0");

            FloatProperty body = new FloatProperty(123.45F);
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}
