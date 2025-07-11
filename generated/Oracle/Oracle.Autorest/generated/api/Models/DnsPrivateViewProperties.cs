// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Extensions;

    /// <summary>Views resource model</summary>
    public partial class DnsPrivateViewProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDnsPrivateViewProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDnsPrivateViewPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the view resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="IsProtected" /> property.</summary>
        private bool _isProtected;

        /// <summary>
        /// A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public bool IsProtected { get => this._isProtected; set => this._isProtected = value; }

        /// <summary>Backing field for <see cref="LifecycleState" /> property.</summary>
        private string _lifecycleState;

        /// <summary>Views lifecycleState</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string LifecycleState { get => this._lifecycleState; set => this._lifecycleState = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDnsPrivateViewPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="Ocid" /> property.</summary>
        private string _ocid;

        /// <summary>The OCID of the view</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string Ocid { get => this._ocid; set => this._ocid = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Azure resource provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Self" /> property.</summary>
        private string _self;

        /// <summary>The canonical absolute URL of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string Self { get => this._self; set => this._self = value; }

        /// <summary>Backing field for <see cref="TimeCreated" /> property.</summary>
        private global::System.DateTime _timeCreated;

        /// <summary>views timeCreated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public global::System.DateTime TimeCreated { get => this._timeCreated; set => this._timeCreated = value; }

        /// <summary>Backing field for <see cref="TimeUpdated" /> property.</summary>
        private global::System.DateTime _timeUpdated;

        /// <summary>views timeCreated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public global::System.DateTime TimeUpdated { get => this._timeUpdated; set => this._timeUpdated = value; }

        /// <summary>Creates an new <see cref="DnsPrivateViewProperties" /> instance.</summary>
        public DnsPrivateViewProperties()
        {

        }
    }
    /// Views resource model
    public partial interface IDnsPrivateViewProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.IJsonSerializable
    {
        /// <summary>The display name of the view resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The display name of the view resource",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed.",
        SerializedName = @"isProtected",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsProtected { get; set; }
        /// <summary>Views lifecycleState</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Views lifecycleState",
        SerializedName = @"lifecycleState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Active", "Deleted", "Deleting", "Updating")]
        string LifecycleState { get; set; }
        /// <summary>The OCID of the view</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OCID of the view",
        SerializedName = @"ocid",
        PossibleTypes = new [] { typeof(string) })]
        string Ocid { get; set; }
        /// <summary>Azure resource provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>The canonical absolute URL of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The canonical absolute URL of the resource.",
        SerializedName = @"self",
        PossibleTypes = new [] { typeof(string) })]
        string Self { get; set; }
        /// <summary>views timeCreated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"views timeCreated",
        SerializedName = @"timeCreated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime TimeCreated { get; set; }
        /// <summary>views timeCreated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"views timeCreated",
        SerializedName = @"timeUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime TimeUpdated { get; set; }

    }
    /// Views resource model
    internal partial interface IDnsPrivateViewPropertiesInternal

    {
        /// <summary>The display name of the view resource</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed.
        /// </summary>
        bool IsProtected { get; set; }
        /// <summary>Views lifecycleState</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Active", "Deleted", "Deleting", "Updating")]
        string LifecycleState { get; set; }
        /// <summary>The OCID of the view</summary>
        string Ocid { get; set; }
        /// <summary>Azure resource provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>The canonical absolute URL of the resource.</summary>
        string Self { get; set; }
        /// <summary>views timeCreated</summary>
        global::System.DateTime TimeCreated { get; set; }
        /// <summary>views timeCreated</summary>
        global::System.DateTime TimeUpdated { get; set; }

    }
}