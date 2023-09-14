// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using security_key_LowLevel;

namespace security_key_LowLevel.Samples
{
    public class Samples_AutorestSecurityKeyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AutorestSecurityKeyClient client = new AutorestSecurityKeyClient(credential);

            Response response = client.Head();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AutorestSecurityKeyClient client = new AutorestSecurityKeyClient(credential);

            Response response = client.Head();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AutorestSecurityKeyClient client = new AutorestSecurityKeyClient(credential);

            Response response = await client.HeadAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AutorestSecurityKeyClient client = new AutorestSecurityKeyClient(credential);

            Response response = await client.HeadAsync();
            Console.WriteLine(response.Status);
        }
    }
}
