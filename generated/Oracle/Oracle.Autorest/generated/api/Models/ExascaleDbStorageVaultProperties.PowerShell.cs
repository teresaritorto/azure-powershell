// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.PowerShell;

    /// <summary>ExascaleDbStorageVault resource model</summary>
    [System.ComponentModel.TypeConverter(typeof(ExascaleDbStorageVaultPropertiesTypeConverter))]
    public partial class ExascaleDbStorageVaultProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExascaleDbStorageVaultProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExascaleDbStorageVaultProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExascaleDbStorageVaultProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HighCapacityDatabaseStorageInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInput = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageInputDetails) content.GetValueForProperty("HighCapacityDatabaseStorageInput",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInput, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageInputDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighCapacityDatabaseStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorage = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageDetails) content.GetValueForProperty("HighCapacityDatabaseStorage",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorage, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalFlashCacheInPercent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).AdditionalFlashCacheInPercent = (int?) content.GetValueForProperty("AdditionalFlashCacheInPercent",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).AdditionalFlashCacheInPercent, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("LifecycleState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleState = (string) content.GetValueForProperty("LifecycleState",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleState, global::System.Convert.ToString);
            }
            if (content.Contains("LifecycleDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleDetail = (string) content.GetValueForProperty("LifecycleDetail",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleDetail, global::System.Convert.ToString);
            }
            if (content.Contains("VMClusterCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).VMClusterCount = (int?) content.GetValueForProperty("VMClusterCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).VMClusterCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Ocid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Ocid = (string) content.GetValueForProperty("Ocid",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Ocid, global::System.Convert.ToString);
            }
            if (content.Contains("OciUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).OciUrl = (string) content.GetValueForProperty("OciUrl",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).OciUrl, global::System.Convert.ToString);
            }
            if (content.Contains("HighCapacityDatabaseStorageInputTotalSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInputTotalSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageInputTotalSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInputTotalSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HighCapacityDatabaseStorageAvailableSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageAvailableSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageAvailableSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageAvailableSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HighCapacityDatabaseStorageTotalSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageTotalSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageTotalSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageTotalSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExascaleDbStorageVaultProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HighCapacityDatabaseStorageInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInput = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageInputDetails) content.GetValueForProperty("HighCapacityDatabaseStorageInput",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInput, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageInputDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighCapacityDatabaseStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorage = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageDetails) content.GetValueForProperty("HighCapacityDatabaseStorage",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorage, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ExascaleDbStorageDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalFlashCacheInPercent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).AdditionalFlashCacheInPercent = (int?) content.GetValueForProperty("AdditionalFlashCacheInPercent",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).AdditionalFlashCacheInPercent, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("LifecycleState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleState = (string) content.GetValueForProperty("LifecycleState",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleState, global::System.Convert.ToString);
            }
            if (content.Contains("LifecycleDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleDetail = (string) content.GetValueForProperty("LifecycleDetail",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).LifecycleDetail, global::System.Convert.ToString);
            }
            if (content.Contains("VMClusterCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).VMClusterCount = (int?) content.GetValueForProperty("VMClusterCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).VMClusterCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Ocid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Ocid = (string) content.GetValueForProperty("Ocid",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).Ocid, global::System.Convert.ToString);
            }
            if (content.Contains("OciUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).OciUrl = (string) content.GetValueForProperty("OciUrl",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).OciUrl, global::System.Convert.ToString);
            }
            if (content.Contains("HighCapacityDatabaseStorageInputTotalSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInputTotalSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageInputTotalSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageInputTotalSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HighCapacityDatabaseStorageAvailableSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageAvailableSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageAvailableSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageAvailableSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HighCapacityDatabaseStorageTotalSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageTotalSizeInGb = (int?) content.GetValueForProperty("HighCapacityDatabaseStorageTotalSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultPropertiesInternal)this).HighCapacityDatabaseStorageTotalSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExascaleDbStorageVaultProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExascaleDbStorageVaultProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IExascaleDbStorageVaultProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// ExascaleDbStorageVault resource model
    [System.ComponentModel.TypeConverter(typeof(ExascaleDbStorageVaultPropertiesTypeConverter))]
    public partial interface IExascaleDbStorageVaultProperties

    {

    }
}