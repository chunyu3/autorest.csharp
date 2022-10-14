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

namespace MgmtMockAndSample
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskEncryptionSetResource" /> and their operations.
    /// Each <see cref="DiskEncryptionSetResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DiskEncryptionSetCollection" /> instance call the GetDiskEncryptionSets method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DiskEncryptionSetCollection : ArmCollection, IEnumerable<DiskEncryptionSetResource>, IAsyncEnumerable<DiskEncryptionSetResource>
    {
        private readonly ClientDiagnostics _diskEncryptionSetClientDiagnostics;
        private readonly DiskEncryptionSetsRestOperations _diskEncryptionSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class for mocking. </summary>
        protected DiskEncryptionSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskEncryptionSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskEncryptionSetClientDiagnostics = new ClientDiagnostics("MgmtMockAndSample", DiskEncryptionSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskEncryptionSetResource.ResourceType, out string diskEncryptionSetApiVersion);
            _diskEncryptionSetRestClient = new DiskEncryptionSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskEncryptionSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a disk encryption set
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskEncryptionSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diskEncryptionSetName, DiskEncryptionSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMockAndSampleArmOperation<DiskEncryptionSetResource>(new DiskEncryptionSetOperationSource(Client), _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a disk encryption set
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiskEncryptionSetResource> CreateOrUpdate(WaitUntil waitUntil, string diskEncryptionSetName, DiskEncryptionSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data, cancellationToken);
                var operation = new MgmtMockAndSampleArmOperation<DiskEncryptionSetResource>(new DiskEncryptionSetOperationSource(Client), _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a disk encryption set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_Get
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<Response<DiskEncryptionSetResource>> GetAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a disk encryption set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_Get
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<DiskEncryptionSetResource> Get(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the disk encryption sets under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets
        /// Operation Id: DiskEncryptionSets_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskEncryptionSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskEncryptionSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskEncryptionSetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskEncryptionSetRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskEncryptionSetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskEncryptionSetRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the disk encryption sets under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets
        /// Operation Id: DiskEncryptionSets_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskEncryptionSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskEncryptionSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskEncryptionSetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskEncryptionSetRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskEncryptionSetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskEncryptionSetRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_Get
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
        /// Operation Id: DiskEncryptionSets_Get
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskEncryptionSetResource> IEnumerable<DiskEncryptionSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskEncryptionSetResource> IAsyncEnumerable<DiskEncryptionSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
