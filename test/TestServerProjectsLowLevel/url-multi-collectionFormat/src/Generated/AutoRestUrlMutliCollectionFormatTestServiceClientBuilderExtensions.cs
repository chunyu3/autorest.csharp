// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using url_multi_collectionFormat_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="QueriesClient"/> to client builder. </summary>
    public static partial class AutoRestUrlMutliCollectionFormatTestServiceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="QueriesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        public static IAzureClientBuilder<QueriesClient, QueriesClientOptions> AddQueriesClient<TBuilder>(this TBuilder builder, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<QueriesClient, QueriesClientOptions>((options) => new QueriesClient(credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="QueriesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<QueriesClient, QueriesClientOptions> AddQueriesClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<QueriesClient, QueriesClientOptions>(configuration);
        }
    }
}
