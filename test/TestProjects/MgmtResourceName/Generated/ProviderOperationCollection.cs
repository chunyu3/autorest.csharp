// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtResourceName
{
    /// <summary>
    /// A class representing a collection of <see cref="ProviderOperationResource" /> and their operations.
    /// Each <see cref="ProviderOperationResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="ProviderOperationCollection" /> instance call the GetProviderOperations method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class ProviderOperationCollection : ArmCollection, IEnumerable<ProviderOperationResource>, IAsyncEnumerable<ProviderOperationResource>
    {
        private readonly ClientDiagnostics _providerOperationClientDiagnostics;
        private readonly ProviderRestOperations _providerOperationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProviderOperationCollection"/> class for mocking. </summary>
        protected ProviderOperationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderOperationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProviderOperationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerOperationClientDiagnostics = new ClientDiagnostics("MgmtResourceName", ProviderOperationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProviderOperationResource.ResourceType, out string providerOperationApiVersion);
            _providerOperationRestClient = new ProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets provider operations metadata for the specified resource provider.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}
        /// Operation Id: ProviderOperations_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<ProviderOperationResource>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.Get");
            scope.Start();
            try
            {
                var response = await _providerOperationRestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets provider operations metadata for the specified resource provider.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}
        /// Operation Id: ProviderOperations_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<ProviderOperationResource> Get(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.Get");
            scope.Start();
            try
            {
                var response = _providerOperationRestClient.Get(resourceProviderNamespace, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets provider operations metadata for all resource providers.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations
        /// Operation Id: ProviderOperations_List
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderOperationResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderOperationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _providerOperationRestClient.ListAsync(expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProviderOperationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _providerOperationRestClient.ListNextPageAsync(nextLink, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets provider operations metadata for all resource providers.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations
        /// Operation Id: ProviderOperations_List
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderOperationResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ProviderOperationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _providerOperationRestClient.List(expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProviderOperationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _providerOperationRestClient.ListNextPage(nextLink, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}
        /// Operation Id: ProviderOperations_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _providerOperationRestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}
        /// Operation Id: ProviderOperations_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _providerOperationClientDiagnostics.CreateScope("ProviderOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = _providerOperationRestClient.Get(resourceProviderNamespace, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProviderOperationResource> IEnumerable<ProviderOperationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProviderOperationResource> IAsyncEnumerable<ProviderOperationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
