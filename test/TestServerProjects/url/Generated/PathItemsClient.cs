// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace url
{
    /// <summary> The PathItems service client. </summary>
    public partial class PathItemsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PathItemsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PathItemsClient for mocking. </summary>
        protected PathItemsClient()
        {
        }

        /// <summary> Initializes a new instance of PathItemsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="globalStringPath"> A string value &apos;globalItemStringPath&apos; that appears in the path. </param>
        /// <param name="endpoint"> server parameter. The default is "http://localhost:3000". </param>
        /// <param name="globalStringQuery"> should contain value null. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="globalStringPath"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalStringPath"/> is an empty string, and was expected to be non-empty. </exception>
        internal PathItemsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string globalStringPath, Uri endpoint = null, string globalStringQuery = null)
        {
            RestClient = new PathItemsRestClient(clientDiagnostics, pipeline, globalStringPath, endpoint, globalStringQuery);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAllWithValuesAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetAllWithValues");
            scope.Start();
            try
            {
                return await RestClient.GetAllWithValuesAsync(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetAllWithValues(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetAllWithValues");
            scope.Start();
            try
            {
                return RestClient.GetAllWithValues(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetGlobalQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalQueryNull");
            scope.Start();
            try
            {
                return await RestClient.GetGlobalQueryNullAsync(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetGlobalQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalQueryNull");
            scope.Start();
            try
            {
                return RestClient.GetGlobalQueryNull(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=globalStringPath, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain null value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetGlobalAndLocalQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalAndLocalQueryNull");
            scope.Start();
            try
            {
                return await RestClient.GetGlobalAndLocalQueryNullAsync(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=globalStringPath, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain null value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetGlobalAndLocalQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalAndLocalQueryNull");
            scope.Start();
            try
            {
                return RestClient.GetGlobalAndLocalQueryNull(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=null, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> should contain value null. </param>
        /// <param name="localStringQuery"> should contain value null. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetLocalPathItemQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetLocalPathItemQueryNull");
            scope.Start();
            try
            {
                return await RestClient.GetLocalPathItemQueryNullAsync(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=null, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> should contain value null. </param>
        /// <param name="localStringQuery"> should contain value null. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetLocalPathItemQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetLocalPathItemQueryNull");
            scope.Start();
            try
            {
                return RestClient.GetLocalPathItemQueryNull(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
