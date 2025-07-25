// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Extensions;

    /// <summary>List of private endpoint connections associated with the specified resource.</summary>
    public partial class PrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnectionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnectionListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnection> _value;

        /// <summary>Array of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnection> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionListResult" /> instance.</summary>
        public PrivateEndpointConnectionListResult()
        {

        }
    }
    /// List of private endpoint connections associated with the specified resource.
    public partial interface IPrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to get the next set of private endpoint connections.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of private endpoint connections.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnection> Value { get; set; }

    }
    /// List of private endpoint connections associated with the specified resource.
    internal partial interface IPrivateEndpointConnectionListResultInternal

    {
        /// <summary>The URL to get the next set of private endpoint connections.</summary>
        string NextLink { get; set; }
        /// <summary>Array of private endpoint connections.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IPrivateEndpointConnection> Value { get; set; }

    }
}