// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Client.Naming.Models;
using NUnit.Framework;

namespace Client.Naming.Samples
{
    public partial class Samples_ClientModel
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Client_ShortVersion()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Client(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Client_ShortVersion_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.ClientAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Client_ShortVersion_Convenience()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            Models.ClientModel clientModel = new Models.ClientModel(true);
            Response response = client.Client(clientModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Client_ShortVersion_Convenience_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            Models.ClientModel clientModel = new Models.ClientModel(true);
            Response response = await client.ClientAsync(clientModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Client_AllParameters()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Client(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Client_AllParameters_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.ClientAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Client_AllParameters_Convenience()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            Models.ClientModel clientModel = new Models.ClientModel(true);
            Response response = client.Client(clientModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Client_AllParameters_Convenience_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            Models.ClientModel clientModel = new Models.ClientModel(true);
            Response response = await client.ClientAsync(clientModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Language_ShortVersion()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Language(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Language_ShortVersion_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.LanguageAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Language_ShortVersion_Convenience()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            ModelWithLanguageClientName modelWithLanguageClientName = new ModelWithLanguageClientName(true);
            Response response = client.Language(modelWithLanguageClientName);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Language_ShortVersion_Convenience_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            ModelWithLanguageClientName modelWithLanguageClientName = new ModelWithLanguageClientName(true);
            Response response = await client.LanguageAsync(modelWithLanguageClientName);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Language_AllParameters()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = client.Language(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Language_AllParameters_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            using RequestContent content = RequestContent.Create(new
            {
                defaultName = true,
            });
            Response response = await client.LanguageAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Model_Language_AllParameters_Convenience()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            ModelWithLanguageClientName modelWithLanguageClientName = new ModelWithLanguageClientName(true);
            Response response = client.Language(modelWithLanguageClientName);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Model_Language_AllParameters_Convenience_Async()
        {
            ClientModel client = new NamingClient().GetClientModelClient();

            ModelWithLanguageClientName modelWithLanguageClientName = new ModelWithLanguageClientName(true);
            Response response = await client.LanguageAsync(modelWithLanguageClientName);
        }
    }
}
