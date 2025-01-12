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
using Pagination;
using Pagination.Models;

namespace Pagination.Samples
{
    public partial class Samples_UseFoundationsResourceList
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_LedgerEntry_GetLedgerEntries_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            foreach (BinaryData item in client.GetLedgerEntries(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("contents").ToString());
                Console.WriteLine(result.GetProperty("collectionId").ToString());
                Console.WriteLine(result.GetProperty("transactionId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_LedgerEntry_GetLedgerEntries_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            await foreach (BinaryData item in client.GetLedgerEntriesAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("contents").ToString());
                Console.WriteLine(result.GetProperty("collectionId").ToString());
                Console.WriteLine(result.GetProperty("transactionId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_LedgerEntry_GetLedgerEntries_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            foreach (LedgerEntry item in client.GetLedgerEntries())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_LedgerEntry_GetLedgerEntries_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            await foreach (LedgerEntry item in client.GetLedgerEntriesAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_LedgerEntry_GetLedgerEntries_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            foreach (BinaryData item in client.GetLedgerEntries(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("contents").ToString());
                Console.WriteLine(result.GetProperty("collectionId").ToString());
                Console.WriteLine(result.GetProperty("transactionId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_LedgerEntry_GetLedgerEntries_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            await foreach (BinaryData item in client.GetLedgerEntriesAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("contents").ToString());
                Console.WriteLine(result.GetProperty("collectionId").ToString());
                Console.WriteLine(result.GetProperty("transactionId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_LedgerEntry_GetLedgerEntries_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            foreach (LedgerEntry item in client.GetLedgerEntries())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_LedgerEntry_GetLedgerEntries_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            UseFoundationsResourceList client = new PaginationClient(endpoint, credential).GetUseFoundationsResourceListClient();

            await foreach (LedgerEntry item in client.GetLedgerEntriesAsync())
            {
            }
        }
    }
}
