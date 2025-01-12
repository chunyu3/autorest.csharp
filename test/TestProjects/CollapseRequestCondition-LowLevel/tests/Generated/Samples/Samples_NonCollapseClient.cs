// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using CollapseRequestCondition_LowLevel;
using NUnit.Framework;

namespace CollapseRequestCondition_LowLevel.Samples
{
    public partial class Samples_NonCollapseClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IfMatchPut_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = null;
            Response response = client.IfMatchPut(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IfMatchPut_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = null;
            Response response = await client.IfMatchPutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IfMatchPut_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = client.IfMatchPut(content, ifMatch: new ETag("<ifMatch>"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IfMatchPut_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = await client.IfMatchPutAsync(content, ifMatch: new ETag("<ifMatch>"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IfNoneMatchPut_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = null;
            Response response = client.IfNoneMatchPut(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IfNoneMatchPut_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = null;
            Response response = await client.IfNoneMatchPutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IfNoneMatchPut_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = client.IfNoneMatchPut(content, ifNoneMatch: new ETag("<ifNoneMatch>"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IfNoneMatchPut_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            NonCollapseClient client = new NonCollapseClient(credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = await client.IfNoneMatchPutAsync(content, ifNoneMatch: new ETag("<ifNoneMatch>"));

            Console.WriteLine(response.Status);
        }
    }
}
