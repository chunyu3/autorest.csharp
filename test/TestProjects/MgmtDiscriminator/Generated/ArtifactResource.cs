// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtDiscriminator
{
    /// <summary>
    /// A Class representing an Artifact along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ArtifactResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetArtifactResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetArtifact method.
    /// </summary>
    public partial class ArtifactResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ArtifactResource"/> instance. </summary>
        /// <param name="resourceScope"> The resourceScope. </param>
        /// <param name="artifactName"> The artifactName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string artifactName)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _artifactClientDiagnostics;
        private readonly ArtifactsRestOperations _artifactRestClient;
        private readonly ArtifactData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/artifacts";

        /// <summary> Initializes a new instance of the <see cref="ArtifactResource"/> class for mocking. </summary>
        protected ArtifactResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ArtifactResource(ArmClient client, ArtifactData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArtifactResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _artifactClientDiagnostics = new ClientDiagnostics("MgmtDiscriminator", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string artifactApiVersion);
            _artifactRestClient = new ArtifactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, artifactApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ArtifactData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArtifactResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Get");
            scope.Start();
            try
            {
                var response = await _artifactRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArtifactResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Get");
            scope.Start();
            try
            {
                var response = _artifactRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ArtifactResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Delete");
            scope.Start();
            try
            {
                var response = await _artifactRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtDiscriminatorArmOperation<ArtifactResource>(Response.FromValue(new ArtifactResource(Client, response), response.GetRawResponse()));
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
        /// Delete a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ArtifactResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Delete");
            scope.Start();
            try
            {
                var response = _artifactRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MgmtDiscriminatorArmOperation<ArtifactResource>(Response.FromValue(new ArtifactResource(Client, response), response.GetRawResponse()));
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
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArtifactResource>> UpdateAsync(WaitUntil waitUntil, ArtifactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Update");
            scope.Start();
            try
            {
                var response = await _artifactRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtDiscriminatorArmOperation<ArtifactResource>(Response.FromValue(new ArtifactResource(Client, response), response.GetRawResponse()));
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
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArtifactResource> Update(WaitUntil waitUntil, ArtifactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _artifactClientDiagnostics.CreateScope("ArtifactResource.Update");
            scope.Start();
            try
            {
                var response = _artifactRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new MgmtDiscriminatorArmOperation<ArtifactResource>(Response.FromValue(new ArtifactResource(Client, response), response.GetRawResponse()));
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
    }
}
