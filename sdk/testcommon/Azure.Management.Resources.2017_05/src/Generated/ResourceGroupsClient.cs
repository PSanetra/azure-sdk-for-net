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
using Azure.Management.Resources.Models;

namespace Azure.Management.Resources
{
    /// <summary> The ResourceGroups service client. </summary>
    public partial class ResourceGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ResourceGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ResourceGroupsClient for mocking. </summary>
        protected ResourceGroupsClient()
        {
        }
        /// <summary> Initializes a new instance of ResourceGroupsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ResourceGroupsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2017-05-10")
        {
            RestClient = new ResourceGroupsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to check. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckExistenceAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.CheckExistence");
            scope.Start();
            try
            {
                return await RestClient.CheckExistenceAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks whether a resource group exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to check. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckExistence(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.CheckExistence");
            scope.Start();
            try
            {
                return RestClient.CheckExistence(resourceGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> CreateOrUpdateAsync(string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> CreateOrUpdate(string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> GetAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Get(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to update. The name is case insensitive. </param>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroup>> UpdateAsync(string resourceGroupName, ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to update. The name is case insensitive. </param>
        /// <param name="parameters"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Update(string resourceGroupName, ResourceGroupPatchable parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to export as a template. </param>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroupExportResult>> ExportTemplateAsync(string resourceGroupName, ExportTemplateRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.ExportTemplate");
            scope.Start();
            try
            {
                return await RestClient.ExportTemplateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Captures the specified resource group as a template. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to export as a template. </param>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroupExportResult> ExportTemplate(string resourceGroupName, ExportTemplateRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.ExportTemplate");
            scope.Start();
            try
            {
                return RestClient.ExportTemplate(resourceGroupName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ResourceGroup> ListAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, filter, top, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ResourceGroup> List(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, filter, top, cancellationToken);
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

        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to delete. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ResourceGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return new ResourceGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to delete. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ResourceGroupsDeleteOperation StartDelete(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, cancellationToken);
                return new ResourceGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}