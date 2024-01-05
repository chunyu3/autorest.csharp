// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type._Dictionary;

namespace _Type._Dictionary.Samples
{
    public partial class Samples_Float32Value
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_GetFloat32Value_ShortVersion()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = client.GetFloat32Value(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_GetFloat32Value_ShortVersion_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = await client.GetFloat32ValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_GetFloat32Value_ShortVersion_Convenience()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response<IReadOnlyDictionary<string, float>> response = client.GetFloat32Value();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_GetFloat32Value_ShortVersion_Convenience_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response<IReadOnlyDictionary<string, float>> response = await client.GetFloat32ValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_GetFloat32Value_AllParameters()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = client.GetFloat32Value(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_GetFloat32Value_AllParameters_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = await client.GetFloat32ValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_GetFloat32Value_AllParameters_Convenience()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response<IReadOnlyDictionary<string, float>> response = client.GetFloat32Value();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_GetFloat32Value_AllParameters_Convenience_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response<IReadOnlyDictionary<string, float>> response = await client.GetFloat32ValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_Put_ShortVersion()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = 123.45F,
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_Put_ShortVersion_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = 123.45F,
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_Put_ShortVersion_Convenience()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = client.Put(new Dictionary<string, float>
            {
                ["key"] = 123.45F
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_Put_ShortVersion_Convenience_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = await client.PutAsync(new Dictionary<string, float>
            {
                ["key"] = 123.45F
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_Put_AllParameters()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = 123.45F,
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_Put_AllParameters_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = 123.45F,
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Float32Value_Put_AllParameters_Convenience()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = client.Put(new Dictionary<string, float>
            {
                ["key"] = 123.45F
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Float32Value_Put_AllParameters_Convenience_Async()
        {
            Float32Value client = new DictionaryClient().GetFloat32ValueClient();

            Response response = await client.PutAsync(new Dictionary<string, float>
            {
                ["key"] = 123.45F
            });
        }
    }
}
