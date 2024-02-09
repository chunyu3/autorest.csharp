// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.TestFramework;
using SubClients_LowLevel;

namespace SubClients_LowLevel.Tests
{
    public partial class SubClients_LowLevelTestBase : RecordedTestBase<SubClients_LowLevelTestEnvironment>
    {
        public SubClients_LowLevelTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected RootClient CreateRootClient(Uri endpoint, string cachedParameter, AzureKeyCredential credential)
        {
            RootClientOptions options = InstrumentClientOptions(new RootClientOptions());
            RootClient client = new RootClient(endpoint, cachedParameter, credential, options);
            return InstrumentClient(client);
        }
    }
}