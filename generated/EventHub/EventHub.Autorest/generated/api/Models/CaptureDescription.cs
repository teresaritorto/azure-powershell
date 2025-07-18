// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties to configure capture description for eventhub</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class CaptureDescription :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureDescription,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureDescriptionInternal
    {

        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ArchiveNameFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).ArchiveNameFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).ArchiveNameFormat = value ?? null; }

        /// <summary>Blob container Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string BlobContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).BlobContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).BlobContainer = value ?? null; }

        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeAccountName = value ?? null; }

        /// <summary>The destination folder path for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeFolderPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeFolderPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeFolderPath = value ?? null; }

        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).DataLakeSubscriptionId = value ?? null; }

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestination _destination;

        /// <summary>
        /// Properties of Destination where capture will be stored. (Storage Account, Blob Names)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestination Destination { get => (this._destination = this._destination ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Destination()); set => this._destination = value; }

        /// <summary>Name for capture destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DestinationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>A value that indicates whether capture description is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Encoding" /> property.</summary>
        private string _encoding;

        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string Encoding { get => this._encoding; set => this._encoding = value; }

        /// <summary>Type of Azure Active Directory Managed Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).IdentityType = value ?? null; }

        /// <summary>
        /// ARM ID of Managed User Identity. This property is required is the type is UserAssignedIdentity. If type is SystemAssigned,
        /// then the System Assigned Identity Associated with the namespace will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).IdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).IdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Backing field for <see cref="IntervalInSecond" /> property.</summary>
        private int? _intervalInSecond;

        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public int? IntervalInSecond { get => this._intervalInSecond; set => this._intervalInSecond = value; }

        /// <summary>Internal Acessors for Destination</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestination Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureDescriptionInternal.Destination { get => (this._destination = this._destination ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Destination()); set { {_destination = value;} } }

        /// <summary>Internal Acessors for DestinationIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureIdentity Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureDescriptionInternal.DestinationIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Identity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DestinationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationProperties Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureDescriptionInternal.DestinationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).Property = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="SizeLimitInByte" /> property.</summary>
        private int? _sizeLimitInByte;

        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public int? SizeLimitInByte { get => this._sizeLimitInByte; set => this._sizeLimitInByte = value; }

        /// <summary>Backing field for <see cref="SkipEmptyArchive" /> property.</summary>
        private bool? _skipEmptyArchive;

        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public bool? SkipEmptyArchive { get => this._skipEmptyArchive; set => this._skipEmptyArchive = value; }

        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string StorageAccountResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).StorageAccountResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationInternal)Destination).StorageAccountResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="CaptureDescription" /> instance.</summary>
        public CaptureDescription()
        {

        }
    }
    /// Properties to configure capture description for eventhub
    public partial interface ICaptureDescription :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order",
        SerializedName = @"archiveNameFormat",
        PossibleTypes = new [] { typeof(string) })]
        string ArchiveNameFormat { get; set; }
        /// <summary>Blob container Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blob container Name",
        SerializedName = @"blobContainer",
        PossibleTypes = new [] { typeof(string) })]
        string BlobContainer { get; set; }
        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure Data Lake Store name for the captured events",
        SerializedName = @"dataLakeAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeAccountName { get; set; }
        /// <summary>The destination folder path for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The destination folder path for the captured events",
        SerializedName = @"dataLakeFolderPath",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeFolderPath { get; set; }
        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription Id of Azure Data Lake Store",
        SerializedName = @"dataLakeSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeSubscriptionId { get; set; }
        /// <summary>Name for capture destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name for capture destination",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationName { get; set; }
        /// <summary>A value that indicates whether capture description is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A value that indicates whether capture description is enabled. ",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version",
        SerializedName = @"encoding",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Avro", "AvroDeflate")]
        string Encoding { get; set; }
        /// <summary>Type of Azure Active Directory Managed Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Azure Active Directory Managed Identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// ARM ID of Managed User Identity. This property is required is the type is UserAssignedIdentity. If type is SystemAssigned,
        /// then the System Assigned Identity Associated with the namespace will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM ID of Managed User Identity. This property is required is the type is UserAssignedIdentity. If type is SystemAssigned, then the System Assigned Identity Associated with the namespace will be used.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds",
        SerializedName = @"intervalInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? IntervalInSecond { get; set; }
        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes",
        SerializedName = @"sizeLimitInBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeLimitInByte { get; set; }
        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A value that indicates whether to Skip Empty Archives",
        SerializedName = @"skipEmptyArchives",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SkipEmptyArchive { get; set; }
        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource id of the storage account to be used to create the blobs",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountResourceId { get; set; }

    }
    /// Properties to configure capture description for eventhub
    internal partial interface ICaptureDescriptionInternal

    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        string ArchiveNameFormat { get; set; }
        /// <summary>Blob container Name</summary>
        string BlobContainer { get; set; }
        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        string DataLakeAccountName { get; set; }
        /// <summary>The destination folder path for the captured events</summary>
        string DataLakeFolderPath { get; set; }
        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        string DataLakeSubscriptionId { get; set; }
        /// <summary>
        /// Properties of Destination where capture will be stored. (Storage Account, Blob Names)
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestination Destination { get; set; }
        /// <summary>A value that indicates whether capture description is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.ICaptureIdentity DestinationIdentity { get; set; }
        /// <summary>Name for capture destination</summary>
        string DestinationName { get; set; }
        /// <summary>
        /// Properties describing the storage account, blob container and archive name format for capture destination
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IDestinationProperties DestinationProperty { get; set; }
        /// <summary>A value that indicates whether capture description is enabled.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Avro", "AvroDeflate")]
        string Encoding { get; set; }
        /// <summary>Type of Azure Active Directory Managed Identity.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// ARM ID of Managed User Identity. This property is required is the type is UserAssignedIdentity. If type is SystemAssigned,
        /// then the System Assigned Identity Associated with the namespace will be used.
        /// </summary>
        string IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        int? IntervalInSecond { get; set; }
        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        int? SizeLimitInByte { get; set; }
        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        bool? SkipEmptyArchive { get; set; }
        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        string StorageAccountResourceId { get; set; }

    }
}