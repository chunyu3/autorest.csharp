// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AppConfiguration.Models;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace AppConfiguration
{
    /// <summary> The AppConfiguration service client. </summary>
    public partial class AppConfigurationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AppConfigurationRestClient RestClient { get; }

        /// <summary> Initializes a new instance of AppConfigurationClient for mocking. </summary>
        protected AppConfigurationClient()
        {
        }

        /// <summary> Initializes a new instance of AppConfigurationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the App Configuration instance to send requests to. </param>
        /// <param name="syncToken"> Used to guarantee real-time consistency between requests. </param>
        /// <param name="apiVersion"> Api Version. The default is "1.0". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        internal AppConfigurationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string syncToken = null, string apiVersion = "1.0")
        {
            RestClient = new AppConfigurationRestClient(clientDiagnostics, pipeline, endpoint, syncToken, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="name"> A filter for the name of the returned keys. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckKeysAsync(string name = null, string after = null, string acceptDatetime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeys");
            scope.Start();
            try
            {
                return (await RestClient.CheckKeysAsync(name, after, acceptDatetime, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="name"> A filter for the name of the returned keys. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckKeys(string name = null, string after = null, string acceptDatetime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeys");
            scope.Start();
            try
            {
                return RestClient.CheckKeys(name, after, acceptDatetime, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckKeyValuesAsync(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Head6ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeyValues");
            scope.Start();
            try
            {
                return (await RestClient.CheckKeyValuesAsync(key, label, after, acceptDatetime, select, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckKeyValues(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Head6ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeyValues");
            scope.Start();
            try
            {
                return RestClient.CheckKeyValues(key, label, after, acceptDatetime, select, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a single key-value. </summary>
        /// <param name="key"> The key of the key-value to retrieve. </param>
        /// <param name="label"> The label of the key-value to retrieve. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> GetKeyValueAsync(string key, string label = null, string acceptDatetime = null, string ifMatch = null, string ifNoneMatch = null, IEnumerable<Get7ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.GetKeyValue");
            scope.Start();
            try
            {
                return await RestClient.GetKeyValueAsync(key, label, acceptDatetime, ifMatch, ifNoneMatch, select, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a single key-value. </summary>
        /// <param name="key"> The key of the key-value to retrieve. </param>
        /// <param name="label"> The label of the key-value to retrieve. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> GetKeyValue(string key, string label = null, string acceptDatetime = null, string ifMatch = null, string ifNoneMatch = null, IEnumerable<Get7ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.GetKeyValue");
            scope.Start();
            try
            {
                return RestClient.GetKeyValue(key, label, acceptDatetime, ifMatch, ifNoneMatch, select, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a key-value. </summary>
        /// <param name="key"> The key of the key-value to create. </param>
        /// <param name="label"> The label of the key-value to create. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="entity"> The key-value to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> PutKeyValueAsync(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, KeyValue entity = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.PutKeyValue");
            scope.Start();
            try
            {
                return await RestClient.PutKeyValueAsync(key, label, ifMatch, ifNoneMatch, entity, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a key-value. </summary>
        /// <param name="key"> The key of the key-value to create. </param>
        /// <param name="label"> The label of the key-value to create. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="entity"> The key-value to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> PutKeyValue(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, KeyValue entity = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.PutKeyValue");
            scope.Start();
            try
            {
                return RestClient.PutKeyValue(key, label, ifMatch, ifNoneMatch, entity, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a key-value. </summary>
        /// <param name="key"> The key of the key-value to delete. </param>
        /// <param name="label"> The label of the key-value to delete. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> DeleteKeyValueAsync(string key, string label = null, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.DeleteKeyValue");
            scope.Start();
            try
            {
                return await RestClient.DeleteKeyValueAsync(key, label, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a key-value. </summary>
        /// <param name="key"> The key of the key-value to delete. </param>
        /// <param name="label"> The label of the key-value to delete. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> DeleteKeyValue(string key, string label = null, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.DeleteKeyValue");
            scope.Start();
            try
            {
                return RestClient.DeleteKeyValue(key, label, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> The key of the key-value to retrieve. </param>
        /// <param name="label"> The label of the key-value to retrieve. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckKeyValueAsync(string key, string label = null, string acceptDatetime = null, string ifMatch = null, string ifNoneMatch = null, IEnumerable<Head7ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeyValue");
            scope.Start();
            try
            {
                return (await RestClient.CheckKeyValueAsync(key, label, acceptDatetime, ifMatch, ifNoneMatch, select, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> The key of the key-value to retrieve. </param>
        /// <param name="label"> The label of the key-value to retrieve. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckKeyValue(string key, string label = null, string acceptDatetime = null, string ifMatch = null, string ifNoneMatch = null, IEnumerable<Head7ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckKeyValue");
            scope.Start();
            try
            {
                return RestClient.CheckKeyValue(key, label, acceptDatetime, ifMatch, ifNoneMatch, select, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="name"> A filter for the name of the returned labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckLabelsAsync(string name = null, string after = null, string acceptDatetime = null, IEnumerable<Head5ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckLabels");
            scope.Start();
            try
            {
                return (await RestClient.CheckLabelsAsync(name, after, acceptDatetime, select, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="name"> A filter for the name of the returned labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckLabels(string name = null, string after = null, string acceptDatetime = null, IEnumerable<Head5ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckLabels");
            scope.Start();
            try
            {
                return RestClient.CheckLabels(name, after, acceptDatetime, select, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Locks a key-value. </summary>
        /// <param name="key"> The key of the key-value to lock. </param>
        /// <param name="label"> The label, if any, of the key-value to lock. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> PutLockAsync(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.PutLock");
            scope.Start();
            try
            {
                return await RestClient.PutLockAsync(key, label, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Locks a key-value. </summary>
        /// <param name="key"> The key of the key-value to lock. </param>
        /// <param name="label"> The label, if any, of the key-value to lock. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> PutLock(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.PutLock");
            scope.Start();
            try
            {
                return RestClient.PutLock(key, label, ifMatch, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unlocks a key-value. </summary>
        /// <param name="key"> The key of the key-value to unlock. </param>
        /// <param name="label"> The label, if any, of the key-value to unlock. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> DeleteLockAsync(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.DeleteLock");
            scope.Start();
            try
            {
                return await RestClient.DeleteLockAsync(key, label, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unlocks a key-value. </summary>
        /// <param name="key"> The key of the key-value to unlock. </param>
        /// <param name="label"> The label, if any, of the key-value to unlock. </param>
        /// <param name="ifMatch"> Used to perform an operation only if the targeted resource's etag matches the value provided. </param>
        /// <param name="ifNoneMatch"> Used to perform an operation only if the targeted resource's etag does not match the value provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> DeleteLock(string key, string label = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.DeleteLock");
            scope.Start();
            try
            {
                return RestClient.DeleteLock(key, label, ifMatch, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckRevisionsAsync(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Enum7> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckRevisions");
            scope.Start();
            try
            {
                return (await RestClient.CheckRevisionsAsync(key, label, after, acceptDatetime, select, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests the headers and status of the given resource. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckRevisions(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Enum7> select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppConfigurationClient.CheckRevisions");
            scope.Start();
            try
            {
                return RestClient.CheckRevisions(key, label, after, acceptDatetime, select, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of keys. </summary>
        /// <param name="name"> A filter for the name of the returned keys. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Key> GetKeysAsync(string name = null, string after = null, string acceptDatetime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetKeysRequest(name, after, acceptDatetime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetKeysNextPageRequest(nextLink, name, after, acceptDatetime);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Key.DeserializeKey, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetKeys", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of keys. </summary>
        /// <param name="name"> A filter for the name of the returned keys. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Key> GetKeys(string name = null, string after = null, string acceptDatetime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetKeysRequest(name, after, acceptDatetime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetKeysNextPageRequest(nextLink, name, after, acceptDatetime);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Key.DeserializeKey, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetKeys", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of key-values. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<KeyValue> GetKeyValuesAsync(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Get6ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetKeyValuesRequest(key, label, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetKeyValuesNextPageRequest(nextLink, key, label, after, acceptDatetime, select);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, KeyValue.DeserializeKeyValue, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetKeyValues", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of key-values. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<KeyValue> GetKeyValues(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Get6ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetKeyValuesRequest(key, label, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetKeyValuesNextPageRequest(nextLink, key, label, after, acceptDatetime, select);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, KeyValue.DeserializeKeyValue, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetKeyValues", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of labels. </summary>
        /// <param name="name"> A filter for the name of the returned labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Label> GetLabelsAsync(string name = null, string after = null, string acceptDatetime = null, IEnumerable<Get5ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetLabelsRequest(name, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetLabelsNextPageRequest(nextLink, name, after, acceptDatetime, select);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Label.DeserializeLabel, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetLabels", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of labels. </summary>
        /// <param name="name"> A filter for the name of the returned labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Label> GetLabels(string name = null, string after = null, string acceptDatetime = null, IEnumerable<Get5ItemsItem> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetLabelsRequest(name, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetLabelsNextPageRequest(nextLink, name, after, acceptDatetime, select);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Label.DeserializeLabel, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetLabels", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of key-value revisions. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<KeyValue> GetRevisionsAsync(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Enum6> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetRevisionsRequest(key, label, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetRevisionsNextPageRequest(nextLink, key, label, after, acceptDatetime, select);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, KeyValue.DeserializeKeyValue, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetRevisions", "items", "@nextLink", cancellationToken);
        }

        /// <summary> Gets a list of key-value revisions. </summary>
        /// <param name="key"> A filter used to match keys. </param>
        /// <param name="label"> A filter used to match labels. </param>
        /// <param name="after"> Instructs the server to return elements that appear after the element referred to by the specified token. </param>
        /// <param name="acceptDatetime"> Requests the server to respond with the state of the resource at the specified time. </param>
        /// <param name="select"> Used to select what fields are present in the returned resource(s). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<KeyValue> GetRevisions(string key = null, string label = null, string after = null, string acceptDatetime = null, IEnumerable<Enum6> select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetRevisionsRequest(key, label, after, acceptDatetime, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetRevisionsNextPageRequest(nextLink, key, label, after, acceptDatetime, select);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, KeyValue.DeserializeKeyValue, _clientDiagnostics, _pipeline, "AppConfigurationClient.GetRevisions", "items", "@nextLink", cancellationToken);
        }
    }
}
