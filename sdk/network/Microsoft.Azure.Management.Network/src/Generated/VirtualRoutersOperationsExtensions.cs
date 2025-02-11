// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualRoutersOperations.
    /// </summary>
    public static partial class VirtualRoutersOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            public static void Delete(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName)
            {
                operations.DeleteAsync(resourceGroupName, virtualRouterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualRouterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static VirtualRouter Get(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, virtualRouterName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouter> GetAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualRouterName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the Virtual Router.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to Update Virtual Router Tags.
            /// </param>
            public static VirtualRouter Update(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, TagsObject parameters)
            {
                return operations.UpdateAsync(resourceGroupName, virtualRouterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the Virtual Router.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to Update Virtual Router Tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouter> UpdateAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, virtualRouterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router.
            /// </param>
            public static VirtualRouter CreateOrUpdate(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, VirtualRouter parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualRouterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouter> CreateOrUpdateAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, VirtualRouter parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualRouterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Virtual Routers in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualRouter> ListByResourceGroup(this IVirtualRoutersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Virtual Routers in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouter>> ListByResourceGroupAsync(this IVirtualRoutersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Virtual Routers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualRouter> List(this IVirtualRoutersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Virtual Routers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouter>> ListAsync(this IVirtualRoutersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            public static void BeginDelete(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualRouterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualRouterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router.
            /// </param>
            public static VirtualRouter BeginCreateOrUpdate(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, VirtualRouter parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualRouterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualRouterName'>
            /// The name of the Virtual Router.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouter> BeginCreateOrUpdateAsync(this IVirtualRoutersOperations operations, string resourceGroupName, string virtualRouterName, VirtualRouter parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualRouterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Virtual Routers in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualRouter> ListByResourceGroupNext(this IVirtualRoutersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Virtual Routers in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouter>> ListByResourceGroupNextAsync(this IVirtualRoutersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Virtual Routers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualRouter> ListNext(this IVirtualRoutersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Virtual Routers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouter>> ListNextAsync(this IVirtualRoutersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
