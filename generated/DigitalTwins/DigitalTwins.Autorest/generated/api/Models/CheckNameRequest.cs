// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The result returned from a database check name availability request.</summary>
    public partial class CheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ICheckNameRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ICheckNameRequestInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ICheckNameRequestInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Microsoft.DigitalTwins/digitalTwinsInstances";

        /// <summary>
        /// The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="CheckNameRequest" /> instance.</summary>
        public CheckNameRequest()
        {

        }
    }
    /// The result returned from a database check name availability request.
    public partial interface ICheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The result returned from a database check name availability request.
    internal partial interface ICheckNameRequestInternal

    {
        /// <summary>Resource name.</summary>
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances.
        /// </summary>
        string Type { get; set; }

    }
}