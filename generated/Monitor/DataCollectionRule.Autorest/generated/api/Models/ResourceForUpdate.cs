// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    /// <summary>Definition of ARM tracked top level resource properties for update operation.</summary>
    public partial class ResourceForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentity _identity;

        /// <summary>Managed Service Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ResourceForUpdateIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentity Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ResourceForUpdateIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ResourceForUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ResourceForUpdate" /> instance.</summary>
        public ResourceForUpdate()
        {

        }
    }
    /// Definition of ARM tracked top level resource properties for update operation.
    public partial interface IResourceForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateTags Tag { get; set; }

    }
    /// Definition of ARM tracked top level resource properties for update operation.
    internal partial interface IResourceForUpdateInternal

    {
        /// <summary>Managed Service Identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateTags Tag { get; set; }

    }
}