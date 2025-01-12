// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using Parameters.CollectionFormat;

namespace Parameters.CollectionFormat.Samples
{
    public partial class Samples_Header
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Header_Csv_ShortVersion()
        {
            Header client = new CollectionFormatClient().GetHeaderClient();

            Response response = client.Csv(new string[] { "<colors>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Header_Csv_ShortVersion_Async()
        {
            Header client = new CollectionFormatClient().GetHeaderClient();

            Response response = await client.CsvAsync(new string[] { "<colors>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Header_Csv_AllParameters()
        {
            Header client = new CollectionFormatClient().GetHeaderClient();

            Response response = client.Csv(new string[] { "<colors>" });

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Header_Csv_AllParameters_Async()
        {
            Header client = new CollectionFormatClient().GetHeaderClient();

            Response response = await client.CsvAsync(new string[] { "<colors>" });

            Console.WriteLine(response.Status);
        }
    }
}
