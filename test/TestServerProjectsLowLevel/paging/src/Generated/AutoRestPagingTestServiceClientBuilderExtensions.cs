// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using paging_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="PagingClient"/> to client builder. </summary>
    public static partial class AutoRestPagingTestServiceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="PagingClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        public static IAzureClientBuilder<PagingClient, PagingClientOptions> AddPagingClient<TBuilder>(this TBuilder builder, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<PagingClient, PagingClientOptions>((options) => new PagingClient(credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="PagingClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<PagingClient, PagingClientOptions> AddPagingClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<PagingClient, PagingClientOptions>(configuration);
        }
    }
}
