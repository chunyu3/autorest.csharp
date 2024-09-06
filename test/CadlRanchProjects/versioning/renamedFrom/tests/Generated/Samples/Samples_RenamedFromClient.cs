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
using Versioning.RenamedFrom.Models;

namespace Versioning.RenamedFrom.Samples
{
    public partial class Samples_RenamedFromClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenamedFrom_NewOp_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                newProp = "<newProp>",
                enumProp = "newEnumMember",
                unionProp = "<unionProp>",
            });
            Response response = client.NewOp("<newQuery>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("newProp").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenamedFrom_NewOp_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                newProp = "<newProp>",
                enumProp = "newEnumMember",
                unionProp = "<unionProp>",
            });
            Response response = await client.NewOpAsync("<newQuery>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("newProp").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenamedFrom_NewOp_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            NewModel body = new NewModel("<newProp>", NewEnum.NewEnumMember, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<NewModel> response = client.NewOp("<newQuery>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenamedFrom_NewOp_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            NewModel body = new NewModel("<newProp>", NewEnum.NewEnumMember, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<NewModel> response = await client.NewOpAsync("<newQuery>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenamedFrom_NewOp_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                newProp = "<newProp>",
                enumProp = "newEnumMember",
                unionProp = "<unionProp>",
            });
            Response response = client.NewOp("<newQuery>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("newProp").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenamedFrom_NewOp_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            using RequestContent content = RequestContent.Create(new
            {
                newProp = "<newProp>",
                enumProp = "newEnumMember",
                unionProp = "<unionProp>",
            });
            Response response = await client.NewOpAsync("<newQuery>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("newProp").ToString());
            Console.WriteLine(result.GetProperty("enumProp").ToString());
            Console.WriteLine(result.GetProperty("unionProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RenamedFrom_NewOp_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            NewModel body = new NewModel("<newProp>", NewEnum.NewEnumMember, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<NewModel> response = client.NewOp("<newQuery>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RenamedFrom_NewOp_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            RenamedFromClient client = new RenamedFromClient(endpoint, Versions.V1);

            NewModel body = new NewModel("<newProp>", NewEnum.NewEnumMember, BinaryData.FromObjectAsJson("<unionProp>"));
            Response<NewModel> response = await client.NewOpAsync("<newQuery>", body);
        }
    }
}
