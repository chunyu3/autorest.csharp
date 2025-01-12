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
    public partial class Samples_IsFloat
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_GetIsFloat_ShortVersion()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response response = client.GetIsFloat(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_GetIsFloat_ShortVersion_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response response = await client.GetIsFloatAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_GetIsFloat_ShortVersion_Convenience()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response<IsFloatAdditionalProperties> response = client.GetIsFloat();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_GetIsFloat_ShortVersion_Convenience_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response<IsFloatAdditionalProperties> response = await client.GetIsFloatAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_GetIsFloat_AllParameters()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response response = client.GetIsFloat(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_GetIsFloat_AllParameters_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response response = await client.GetIsFloatAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_GetIsFloat_AllParameters_Convenience()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response<IsFloatAdditionalProperties> response = client.GetIsFloat();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_GetIsFloat_AllParameters_Convenience_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            Response<IsFloatAdditionalProperties> response = await client.GetIsFloatAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_Put_ShortVersion()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = 123.45F,
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_Put_ShortVersion_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = 123.45F,
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_Put_ShortVersion_Convenience()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            IsFloatAdditionalProperties body = new IsFloatAdditionalProperties(123.45F);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_Put_ShortVersion_Convenience_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            IsFloatAdditionalProperties body = new IsFloatAdditionalProperties(123.45F);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_Put_AllParameters()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = 123.45F,
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_Put_AllParameters_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = 123.45F,
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsFloat_Put_AllParameters_Convenience()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            IsFloatAdditionalProperties body = new IsFloatAdditionalProperties(123.45F);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsFloat_Put_AllParameters_Convenience_Async()
        {
            IsFloat client = new AdditionalPropertiesClient().GetIsFloatClient();

            IsFloatAdditionalProperties body = new IsFloatAdditionalProperties(123.45F);
            Response response = await client.PutAsync(body);
        }
    }
}
