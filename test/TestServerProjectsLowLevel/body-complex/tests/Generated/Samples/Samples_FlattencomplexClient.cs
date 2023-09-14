// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using body_complex_LowLevel;

namespace body_complex_LowLevel.Samples
{
    public class Samples_FlattencomplexClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FlattencomplexClient client = new FlattencomplexClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FlattencomplexClient client = new FlattencomplexClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("propB1").ToString());
            Console.WriteLine(result.GetProperty("helper").GetProperty("propBH1").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FlattencomplexClient client = new FlattencomplexClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FlattencomplexClient client = new FlattencomplexClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("propB1").ToString());
            Console.WriteLine(result.GetProperty("helper").GetProperty("propBH1").ToString());
        }
    }
}
