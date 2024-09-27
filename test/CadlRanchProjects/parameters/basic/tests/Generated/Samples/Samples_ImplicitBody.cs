// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Parameters.Basic.Samples
{
    public partial class Samples_ImplicitBody
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ImplicitBody_Simple_ShortVersion()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Simple(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ImplicitBody_Simple_ShortVersion_Async()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.SimpleAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ImplicitBody_Simple_ShortVersion_Convenience()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            Response response = client.Simple("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ImplicitBody_Simple_ShortVersion_Convenience_Async()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            Response response = await client.SimpleAsync("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ImplicitBody_Simple_AllParameters()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Simple(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ImplicitBody_Simple_AllParameters_Async()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.SimpleAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ImplicitBody_Simple_AllParameters_Convenience()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            Response response = client.Simple("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ImplicitBody_Simple_AllParameters_Convenience_Async()
        {
            ImplicitBody client = new BasicClient().GetImplicitBodyClient();

            Response response = await client.SimpleAsync("<name>");
        }
    }
}
