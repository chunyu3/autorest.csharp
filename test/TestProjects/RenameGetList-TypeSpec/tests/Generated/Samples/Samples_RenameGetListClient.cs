// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.RenameGetList.Samples
{
    public class Samples_RenameGetListClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProject()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = client.GetProject("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProject_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = client.GetProject("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProject_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = await client.GetProjectAsync("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProject_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = await client.GetProjectAsync("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeployment()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = client.GetDeployment("<projectName>", "<deploymentName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeployment_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = client.GetDeployment("<projectName>", "<deploymentName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeployment_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = await client.GetDeploymentAsync("<projectName>", "<deploymentName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeployment_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            Response response = await client.GetDeploymentAsync("<projectName>", "<deploymentName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProjects()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            foreach (var item in client.GetProjects())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProjects_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            foreach (var item in client.GetProjects())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("settings").GetProperty("<test>").ToString());
                Console.WriteLine(result.GetProperty("multilingual").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProjects_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            await foreach (var item in client.GetProjectsAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProjects_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            await foreach (var item in client.GetProjectsAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("settings").GetProperty("<test>").ToString());
                Console.WriteLine(result.GetProperty("multilingual").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeployments()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            foreach (var item in client.GetDeployments("<projectName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeployments_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            foreach (var item in client.GetDeployments("<projectName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeployments_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            await foreach (var item in client.GetDeploymentsAsync("<projectName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeployments_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RenameGetListClient(endpoint);

            await foreach (var item in client.GetDeploymentsAsync("<projectName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }
    }
}
