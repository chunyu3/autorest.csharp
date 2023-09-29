// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Encode.Bytes;
using NUnit.Framework;

namespace Encode.Bytes.Samples
{
    public partial class Samples_ResponseBody
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_ShortVersion()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Default(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_ShortVersion_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_ShortVersion_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Default();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_ShortVersion_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.DefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_AllParameters()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Default(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_AllParameters_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_AllParameters_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Default();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_AllParameters_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.DefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_ShortVersion()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.OctetStream(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_ShortVersion_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.OctetStreamAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_ShortVersion_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.OctetStream();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_ShortVersion_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.OctetStreamAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_AllParameters()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.OctetStream(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_AllParameters_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.OctetStreamAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_AllParameters_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.OctetStream();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_AllParameters_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.OctetStreamAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_ShortVersion()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.CustomContentType(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_ShortVersion_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.CustomContentTypeAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_ShortVersion_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.CustomContentType();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_ShortVersion_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.CustomContentTypeAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_AllParameters()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.CustomContentType(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_AllParameters_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.CustomContentTypeAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_AllParameters_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.CustomContentType();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_AllParameters_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.CustomContentTypeAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_ShortVersion()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_ShortVersion_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64Async(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_ShortVersion_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Base64();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_ShortVersion_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.Base64Async();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_AllParameters()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_AllParameters_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64Async(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_AllParameters_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Base64();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_AllParameters_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.Base64Async();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_ShortVersion()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64url(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_ShortVersion_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64urlAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_ShortVersion_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Base64url();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_ShortVersion_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.Base64urlAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_AllParameters()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64url(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_AllParameters_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64urlAsync(null);

            JsonElement element = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(element.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_AllParameters_Convenience()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = client.Base64url();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_AllParameters_Convenience_Async()
        {
            ResponseBody client = new BytesClient().GetResponseBodyClient(apiVersion: "1.0.0");

            Response<BinaryData> response = await client.Base64urlAsync();
        }
    }
}
