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
    public partial class Samples_IsUnknownDiscriminated
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_ShortVersion()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response response = client.GetIsUnknownDiscriminated(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_ShortVersion_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response response = await client.GetIsUnknownDiscriminatedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_ShortVersion_Convenience()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response<IsUnknownAdditionalPropertiesDiscriminated> response = client.GetIsUnknownDiscriminated();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_ShortVersion_Convenience_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response<IsUnknownAdditionalPropertiesDiscriminated> response = await client.GetIsUnknownDiscriminatedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_AllParameters()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response response = client.GetIsUnknownDiscriminated(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_AllParameters_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response response = await client.GetIsUnknownDiscriminatedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_AllParameters_Convenience()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response<IsUnknownAdditionalPropertiesDiscriminated> response = client.GetIsUnknownDiscriminated();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_GetIsUnknownDiscriminated_AllParameters_Convenience_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            Response<IsUnknownAdditionalPropertiesDiscriminated> response = await client.GetIsUnknownDiscriminatedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_Put_ShortVersion()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
                kind = "derived",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_Put_ShortVersion_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
                kind = "derived",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_Put_ShortVersion_Convenience()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            IsUnknownAdditionalPropertiesDiscriminated body = new IsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_Put_ShortVersion_Convenience_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            IsUnknownAdditionalPropertiesDiscriminated body = new IsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_Put_AllParameters()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
                kind = "derived",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_Put_AllParameters_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
                kind = "derived",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDiscriminated_Put_AllParameters_Convenience()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            IsUnknownAdditionalPropertiesDiscriminated body = new IsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDiscriminated_Put_AllParameters_Convenience_Async()
        {
            IsUnknownDiscriminated client = new AdditionalPropertiesClient().GetIsUnknownDiscriminatedClient();

            IsUnknownAdditionalPropertiesDiscriminated body = new IsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = await client.PutAsync(body);
        }
    }
}
