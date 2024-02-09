// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.TestFramework;
using body_complex_LowLevel;

namespace body_complex_LowLevel.Tests
{
    public partial class body_complex_LowLevelTestBase : RecordedTestBase<body_complex_LowLevelTestEnvironment>
    {
        public body_complex_LowLevelTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected BasicClient CreateBasicClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            BasicClient client = new BasicClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected PrimitiveClient CreatePrimitiveClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            PrimitiveClient client = new PrimitiveClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected ArrayClient CreateArrayClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            ArrayClient client = new ArrayClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected DictionaryClient CreateDictionaryClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            DictionaryClient client = new DictionaryClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected InheritanceClient CreateInheritanceClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            InheritanceClient client = new InheritanceClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected PolymorphismClient CreatePolymorphismClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            PolymorphismClient client = new PolymorphismClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected PolymorphicrecursiveClient CreatePolymorphicrecursiveClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected ReadonlypropertyClient CreateReadonlypropertyClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            ReadonlypropertyClient client = new ReadonlypropertyClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected FlattencomplexClient CreateFlattencomplexClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestComplexTestServiceClientOptions options = InstrumentClientOptions(new AutoRestComplexTestServiceClientOptions());
            FlattencomplexClient client = new FlattencomplexClient(endpoint, credential, options);
            return InstrumentClient(client);
        }
    }
}