// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> availabilityStatus of a resource. </summary>
    public partial class ResourceHealthAvailabilityStatus : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStatus"/>. </summary>
        internal ResourceHealthAvailabilityStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStatus"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Azure Resource Manager geo location of the resource. </param>
        /// <param name="properties"> Properties of availability state. </param>
        internal ResourceHealthAvailabilityStatus(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceHealthAvailabilityStatusProperties properties) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Properties = properties;
        }

        /// <summary> Azure Resource Manager geo location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Properties of availability state. </summary>
        public ResourceHealthAvailabilityStatusProperties Properties { get; }
    }
}
