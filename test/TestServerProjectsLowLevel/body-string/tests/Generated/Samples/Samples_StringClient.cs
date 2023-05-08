// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace body_string_LowLevel.Samples
{
    public class Samples_StringClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNull()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNull();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNull_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNull(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNull_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNullAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNull_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNullAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutNull()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutNull(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutNull_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutNull(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutNull_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutNullAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutNull_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutNullAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetEmpty();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetEmpty(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetEmptyAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetEmptyAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutEmpty()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutEmpty(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutEmpty_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutEmpty(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutEmpty_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutEmptyAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutEmpty_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutEmptyAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMbcs()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetMbcs();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMbcs_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetMbcs(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMbcs_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetMbcsAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMbcs_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetMbcsAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutMbcs()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutMbcs(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutMbcs_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutMbcs(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutMbcs_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutMbcsAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutMbcs_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutMbcsAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWhitespace()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetWhitespace();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWhitespace_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetWhitespace(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWhitespace_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetWhitespaceAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWhitespace_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetWhitespaceAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutWhitespace()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutWhitespace(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutWhitespace_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = client.PutWhitespace(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutWhitespace_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutWhitespaceAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutWhitespace_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = "<String>";

            Response response = await client.PutWhitespaceAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNotProvided()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNotProvided();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNotProvided_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNotProvided(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNotProvided_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNotProvidedAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNotProvided_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNotProvidedAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64Encoded()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetBase64Encoded();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64Encoded_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetBase64Encoded(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64Encoded_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetBase64EncodedAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64Encoded_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetBase64EncodedAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64UrlEncoded()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetBase64UrlEncoded();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64UrlEncoded_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetBase64UrlEncoded(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64UrlEncoded_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetBase64UrlEncodedAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64UrlEncoded_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetBase64UrlEncodedAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutBase64UrlEncoded()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = new { };

            Response response = client.PutBase64UrlEncoded(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutBase64UrlEncoded_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = new { };

            Response response = client.PutBase64UrlEncoded(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutBase64UrlEncoded_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = new { };

            Response response = await client.PutBase64UrlEncodedAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutBase64UrlEncoded_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            var data = new { };

            Response response = await client.PutBase64UrlEncodedAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNullBase64UrlEncoded()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNullBase64UrlEncoded();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNullBase64UrlEncoded_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = client.GetNullBase64UrlEncoded(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNullBase64UrlEncoded_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNullBase64UrlEncodedAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNullBase64UrlEncoded_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new StringClient(credential);

            Response response = await client.GetNullBase64UrlEncodedAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
