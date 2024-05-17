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

namespace body_string_LowLevel.Samples
{
    public partial class Samples_StringClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNull(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNullAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNull(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNullAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("<https://my-service.azure.com>");
            Response response = client.PutNull(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("<https://my-service.azure.com>");
            Response response = await client.PutNullAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("<stringBody>");
            Response response = client.PutNull(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("<stringBody>");
            Response response = await client.PutNullAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetEmpty(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetEmptyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetEmpty(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetEmptyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutEmpty_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("");
            Response response = client.PutEmpty(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutEmpty_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("");
            Response response = await client.PutEmptyAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutEmpty_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("");
            Response response = client.PutEmpty(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutEmpty_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("");
            Response response = await client.PutEmptyAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMbcs_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetMbcs(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMbcs_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetMbcsAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMbcs_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetMbcs(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMbcs_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetMbcsAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutMbcs_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€");
            Response response = client.PutMbcs(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutMbcs_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€");
            Response response = await client.PutMbcsAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutMbcs_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€");
            Response response = client.PutMbcs(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutMbcs_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€");
            Response response = await client.PutMbcsAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWhitespace_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetWhitespace(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWhitespace_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetWhitespaceAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWhitespace_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetWhitespace(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWhitespace_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetWhitespaceAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutWhitespace_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("    Now is the time for all good men to come to the aid of their country    ");
            Response response = client.PutWhitespace(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutWhitespace_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("    Now is the time for all good men to come to the aid of their country    ");
            Response response = await client.PutWhitespaceAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutWhitespace_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("    Now is the time for all good men to come to the aid of their country    ");
            Response response = client.PutWhitespace(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutWhitespace_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create("    Now is the time for all good men to come to the aid of their country    ");
            Response response = await client.PutWhitespaceAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNotProvided_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNotProvided(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNotProvided_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNotProvidedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNotProvided_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNotProvided(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNotProvided_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNotProvidedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64Encoded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetBase64Encoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64Encoded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetBase64EncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64Encoded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetBase64Encoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64Encoded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetBase64EncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64UrlEncoded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetBase64UrlEncoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64UrlEncoded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetBase64UrlEncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetBase64UrlEncoded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetBase64UrlEncoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetBase64UrlEncoded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetBase64UrlEncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutBase64UrlEncoded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutBase64UrlEncoded(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutBase64UrlEncoded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutBase64UrlEncodedAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutBase64UrlEncoded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutBase64UrlEncoded(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutBase64UrlEncoded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutBase64UrlEncodedAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNullBase64UrlEncoded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNullBase64UrlEncoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNullBase64UrlEncoded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNullBase64UrlEncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNullBase64UrlEncoded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = client.GetNullBase64UrlEncoded(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNullBase64UrlEncoded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            StringClient client = new StringClient(credential);

            Response response = await client.GetNullBase64UrlEncodedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
