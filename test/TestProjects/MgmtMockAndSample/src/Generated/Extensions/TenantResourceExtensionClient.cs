// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _tenantActivityLogsClientDiagnostics;
        private TenantActivityLogsRestOperations _tenantActivityLogsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics TenantActivityLogsClientDiagnostics => _tenantActivityLogsClientDiagnostics ??= new ClientDiagnostics("MgmtMockAndSample", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private TenantActivityLogsRestOperations TenantActivityLogsRestClient => _tenantActivityLogsRestClient ??= new TenantActivityLogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is applicable to the API to get the Activity Logs for the subscription is applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing to point out here is that this API does *not* retrieve the logs at the individual subscription of the tenant but only surfaces the logs that were generated at the tenant level.
        /// Request Path: /providers/Microsoft.Insights/eventtypes/management/values
        /// Operation Id: TenantActivityLogs_List
        /// </summary>
        /// <param name="filter"> Reduces the set of data collected. &lt;br&gt;The **$filter** is very restricted and allows only the following patterns.&lt;br&gt;- List events for a resource group: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceGroupName eq &apos;&lt;ResourceGroupName&gt;&apos;.&lt;br&gt;- List events for resource: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceUri eq &apos;&lt;ResourceURI&gt;&apos;.&lt;br&gt;- List events for a subscription: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos;.&lt;br&gt;- List events for a resource provider: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceProvider eq &apos;&lt;ResourceProviderName&gt;&apos;.&lt;br&gt;- List events for a correlation Id: api-version=2014-04-01&amp;$filter=eventTimestamp ge &apos;2014-07-16T04:36:37.6407898Z&apos; and eventTimestamp le &apos;2014-07-20T04:36:37.6407898Z&apos; and eventChannels eq &apos;Admin, Operation&apos; and correlationId eq &apos;&lt;CorrelationID&gt;&apos;.&lt;br&gt;**NOTE**: No other syntax is allowed. </param>
        /// <param name="select"> Used to fetch events with only the given properties.&lt;br&gt;The **$select** argument is a comma separated list of property names to be returned. Possible values are: *authorization*, *claims*, *correlationId*, *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*, *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*, *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*, *subStatus*, *subscriptionId*. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventData> GetTenantActivityLogsAsync(string filter = null, string select = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EventData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = TenantActivityLogsClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetTenantActivityLogs");
                scope.Start();
                try
                {
                    var response = await TenantActivityLogsRestClient.ListAsync(filter, select, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = TenantActivityLogsClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetTenantActivityLogs");
                scope.Start();
                try
                {
                    var response = await TenantActivityLogsRestClient.ListNextPageAsync(nextLink, filter, select, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is applicable to the API to get the Activity Logs for the subscription is applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing to point out here is that this API does *not* retrieve the logs at the individual subscription of the tenant but only surfaces the logs that were generated at the tenant level.
        /// Request Path: /providers/Microsoft.Insights/eventtypes/management/values
        /// Operation Id: TenantActivityLogs_List
        /// </summary>
        /// <param name="filter"> Reduces the set of data collected. &lt;br&gt;The **$filter** is very restricted and allows only the following patterns.&lt;br&gt;- List events for a resource group: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceGroupName eq &apos;&lt;ResourceGroupName&gt;&apos;.&lt;br&gt;- List events for resource: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceUri eq &apos;&lt;ResourceURI&gt;&apos;.&lt;br&gt;- List events for a subscription: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos;.&lt;br&gt;- List events for a resource provider: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceProvider eq &apos;&lt;ResourceProviderName&gt;&apos;.&lt;br&gt;- List events for a correlation Id: api-version=2014-04-01&amp;$filter=eventTimestamp ge &apos;2014-07-16T04:36:37.6407898Z&apos; and eventTimestamp le &apos;2014-07-20T04:36:37.6407898Z&apos; and eventChannels eq &apos;Admin, Operation&apos; and correlationId eq &apos;&lt;CorrelationID&gt;&apos;.&lt;br&gt;**NOTE**: No other syntax is allowed. </param>
        /// <param name="select"> Used to fetch events with only the given properties.&lt;br&gt;The **$select** argument is a comma separated list of property names to be returned. Possible values are: *authorization*, *claims*, *correlationId*, *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*, *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*, *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*, *subStatus*, *subscriptionId*. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventData> GetTenantActivityLogs(string filter = null, string select = null, CancellationToken cancellationToken = default)
        {
            Page<EventData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = TenantActivityLogsClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetTenantActivityLogs");
                scope.Start();
                try
                {
                    var response = TenantActivityLogsRestClient.List(filter, select, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = TenantActivityLogsClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetTenantActivityLogs");
                scope.Start();
                try
                {
                    var response = TenantActivityLogsRestClient.ListNextPage(nextLink, filter, select, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
