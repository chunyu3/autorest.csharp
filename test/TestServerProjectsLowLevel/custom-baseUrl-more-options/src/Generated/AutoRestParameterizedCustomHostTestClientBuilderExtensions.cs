// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core.Extensions;
using custom_baseUrl_more_options_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="PathsClient"/> to client builder. </summary>
    public static partial class AutoRestParameterizedCustomHostTestClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="PathsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="dnsSuffix"> A string value that is used as a global part of the parameterized host. Default value 'host'. The default is "host". </param>
        /// <param name="subscriptionId"> The subscription id with value 'test12'. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<PathsClient, PathsClientOptions> AddPathsClient<TBuilder>(this TBuilder builder, string dnsSuffix, string subscriptionId, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<PathsClient, PathsClientOptions>((options) => new PathsClient(dnsSuffix, subscriptionId, credential, options));
        }

        /// <summary> Registers a <see cref="PathsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<PathsClient, PathsClientOptions> AddPathsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<PathsClient, PathsClientOptions>(configuration);
        }
    }
}
