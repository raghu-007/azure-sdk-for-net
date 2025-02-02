// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> ARM resource. </summary>
    public partial class ResourceWithWritableName
    {
        /// <summary> Initializes a new instance of ResourceWithWritableName. </summary>
        public ResourceWithWritableName()
        {
        }

        /// <summary> Initializes a new instance of ResourceWithWritableName. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        internal ResourceWithWritableName(ResourceIdentifier id, string name, ResourceType? resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; set; }
        /// <summary> Resource type. </summary>
        public ResourceType? ResourceType { get; }
    }
}
