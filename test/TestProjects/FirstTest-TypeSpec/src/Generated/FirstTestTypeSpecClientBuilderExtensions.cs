// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using FirstTestTypeSpec;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="FirstTestTypeSpecClient"/> to client builder. </summary>
    public static partial class FirstTestTypeSpecClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="FirstTestTypeSpecClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="clientRequestId"> The request id. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions> AddFirstTestTypeSpecClient<TBuilder>(this TBuilder builder, Uri endpoint, string clientRequestId, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions>((options) => new FirstTestTypeSpecClient(endpoint, clientRequestId, credential, options));
        }

        /// <summary> Registers a <see cref="FirstTestTypeSpecClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="clientRequestId"> The request id. </param>
        public static IAzureClientBuilder<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions> AddFirstTestTypeSpecClient<TBuilder>(this TBuilder builder, Uri endpoint, string clientRequestId)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions>((options, cred) => new FirstTestTypeSpecClient(endpoint, clientRequestId, cred, options));
        }

        /// <summary> Registers a <see cref="FirstTestTypeSpecClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions> AddFirstTestTypeSpecClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<FirstTestTypeSpecClient, FirstTestTypeSpecClientOptions>(configuration);
        }
    }
}
