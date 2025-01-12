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
using _Type._Enum.Fixed;
using _Type._Enum.Fixed.Models;

namespace _Type._Enum.Fixed.Samples
{
    public partial class Samples_String
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_GetKnownValue_ShortVersion()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.GetKnownValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_GetKnownValue_ShortVersion_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.GetKnownValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_GetKnownValue_ShortVersion_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response<DaysOfWeekEnum> response = client.GetKnownValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_GetKnownValue_ShortVersion_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response<DaysOfWeekEnum> response = await client.GetKnownValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_GetKnownValue_AllParameters()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.GetKnownValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_GetKnownValue_AllParameters_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.GetKnownValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_GetKnownValue_AllParameters_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response<DaysOfWeekEnum> response = client.GetKnownValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_GetKnownValue_AllParameters_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response<DaysOfWeekEnum> response = await client.GetKnownValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutKnownValue_ShortVersion()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = client.PutKnownValue(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutKnownValue_ShortVersion_Async()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.PutKnownValueAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutKnownValue_ShortVersion_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.PutKnownValue(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutKnownValue_ShortVersion_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.PutKnownValueAsync(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutKnownValue_AllParameters()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = client.PutKnownValue(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutKnownValue_AllParameters_Async()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.PutKnownValueAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutKnownValue_AllParameters_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.PutKnownValue(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutKnownValue_AllParameters_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.PutKnownValueAsync(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutUnknownValue_ShortVersion()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = client.PutUnknownValue(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutUnknownValue_ShortVersion_Async()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.PutUnknownValueAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutUnknownValue_ShortVersion_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.PutUnknownValue(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutUnknownValue_ShortVersion_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.PutUnknownValueAsync(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutUnknownValue_AllParameters()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = client.PutUnknownValue(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutUnknownValue_AllParameters_Async()
        {
            String client = new FixedClient().GetStringClient();

            using RequestContent content = RequestContent.Create("Monday");
            Response response = await client.PutUnknownValueAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_String_PutUnknownValue_AllParameters_Convenience()
        {
            String client = new FixedClient().GetStringClient();

            Response response = client.PutUnknownValue(DaysOfWeekEnum.Monday);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_String_PutUnknownValue_AllParameters_Convenience_Async()
        {
            String client = new FixedClient().GetStringClient();

            Response response = await client.PutUnknownValueAsync(DaysOfWeekEnum.Monday);
        }
    }
}
