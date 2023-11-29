// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Encode.Datetime;
using NUnit.Framework;

namespace Encode.Datetime.Samples
{
    public partial class Samples_ResponseHeader
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Default_ShortVersion()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Default();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Default_ShortVersion_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Default_AllParameters()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Default();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Default_AllParameters_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Rfc3339_ShortVersion()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Rfc3339();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Rfc3339_ShortVersion_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.Rfc3339Async();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Rfc3339_AllParameters()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Rfc3339();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Rfc3339_AllParameters_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.Rfc3339Async();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Rfc7231_ShortVersion()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Rfc7231();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Rfc7231_ShortVersion_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.Rfc7231Async();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_Rfc7231_AllParameters()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.Rfc7231();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_Rfc7231_AllParameters_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.Rfc7231Async();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_UnixTimestamp_ShortVersion()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.UnixTimestamp();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_UnixTimestamp_ShortVersion_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.UnixTimestampAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResponseHeader_UnixTimestamp_AllParameters()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = client.UnixTimestamp();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResponseHeader_UnixTimestamp_AllParameters_Async()
        {
            ResponseHeader client = new DatetimeClient().GetResponseHeaderClient(apiVersion: "1.0.0");

            Response response = await client.UnixTimestampAsync();

            Console.WriteLine(response.Status);
        }
    }
}
