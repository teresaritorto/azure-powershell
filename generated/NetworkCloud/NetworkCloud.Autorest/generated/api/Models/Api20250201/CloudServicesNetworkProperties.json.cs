// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// CloudServicesNetworkProperties represents properties of the cloud services network.
    /// </summary>
    public partial class CloudServicesNetworkProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject into a new instance of <see cref="CloudServicesNetworkProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CloudServicesNetworkProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_additionalEgressEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("additionalEgressEndpoints"), out var __jsonAdditionalEgressEndpoints) ? If( __jsonAdditionalEgressEndpoints as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint) (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.EgressEndpoint.FromJson(__u) )) ))() : null : AdditionalEgressEndpoint;}
            {_associatedResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("associatedResourceIds"), out var __jsonAssociatedResourceIds) ? If( __jsonAssociatedResourceIds as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : AssociatedResourceId;}
            {_clusterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("clusterId"), out var __jsonClusterId) ? (string)__jsonClusterId : (string)ClusterId;}
            {_detailedStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("detailedStatus"), out var __jsonDetailedStatus) ? (string)__jsonDetailedStatus : (string)DetailedStatus;}
            {_detailedStatusMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("detailedStatusMessage"), out var __jsonDetailedStatusMessage) ? (string)__jsonDetailedStatusMessage : (string)DetailedStatusMessage;}
            {_enableDefaultEgressEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("enableDefaultEgressEndpoints"), out var __jsonEnableDefaultEgressEndpoints) ? (string)__jsonEnableDefaultEgressEndpoints : (string)EnableDefaultEgressEndpoint;}
            {_enabledEgressEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("enabledEgressEndpoints"), out var __jsonEnabledEgressEndpoints) ? If( __jsonEnabledEgressEndpoints as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint) (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.EgressEndpoint.FromJson(__k) )) ))() : null : EnabledEgressEndpoint;}
            {_hybridAksClustersAssociatedId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("hybridAksClustersAssociatedIds"), out var __jsonHybridAksClustersAssociatedIds) ? If( __jsonHybridAksClustersAssociatedIds as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString __e ? (string)(__e.ToString()) : null)) ))() : null : HybridAksClustersAssociatedId;}
            {_interfaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("interfaceName"), out var __jsonInterfaceName) ? (string)__jsonInterfaceName : (string)InterfaceName;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_virtualMachinesAssociatedId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("virtualMachinesAssociatedIds"), out var __jsonVirtualMachinesAssociatedIds) ? If( __jsonVirtualMachinesAssociatedIds as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(string) (__a is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString ___z ? (string)(___z.ToString()) : null)) ))() : null : VirtualMachinesAssociatedId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json ? new CloudServicesNetworkProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CloudServicesNetworkProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CloudServicesNetworkProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._additionalEgressEndpoint)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                foreach( var __x in this._additionalEgressEndpoint )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("additionalEgressEndpoints",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._associatedResourceId)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                    foreach( var __s in this._associatedResourceId )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("associatedResourceIds",__r);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._clusterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._clusterId.ToString()) : null, "clusterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._detailedStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._detailedStatus.ToString()) : null, "detailedStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._detailedStatusMessage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._detailedStatusMessage.ToString()) : null, "detailedStatusMessage" ,container.Add );
            }
            AddIf( null != (((object)this._enableDefaultEgressEndpoint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._enableDefaultEgressEndpoint.ToString()) : null, "enableDefaultEgressEndpoints" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._enabledEgressEndpoint)
                {
                    var __m = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                    foreach( var __n in this._enabledEgressEndpoint )
                    {
                        AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                    }
                    container.Add("enabledEgressEndpoints",__m);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._hybridAksClustersAssociatedId)
                {
                    var __h = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                    foreach( var __i in this._hybridAksClustersAssociatedId )
                    {
                        AddIf(null != (((object)__i)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                    }
                    container.Add("hybridAksClustersAssociatedIds",__h);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._interfaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._interfaceName.ToString()) : null, "interfaceName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._virtualMachinesAssociatedId)
                {
                    var __c = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                    foreach( var __d in this._virtualMachinesAssociatedId )
                    {
                        AddIf(null != (((object)__d)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(__d.ToString()) : null ,__c.Add);
                    }
                    container.Add("virtualMachinesAssociatedIds",__c);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}