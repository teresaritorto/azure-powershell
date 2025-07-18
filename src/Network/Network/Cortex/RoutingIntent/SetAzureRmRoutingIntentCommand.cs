﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network
{
    using System;
    using System.Linq;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.Network.Models;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

    [Cmdlet("Set",
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RoutingIntent",
        DefaultParameterSetName = CortexParameterSetNames.ByRoutingIntentName,
        SupportsShouldProcess = true),
        OutputType(typeof(PSRoutingIntent))]
    public class SetAzureRmRoutingIntentCommand : RoutingIntentBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByRoutingIntentName,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("VirtualHubName", "ParentVirtualHubName")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByRoutingIntentName,
            HelpMessage = "The resource group name.")]
        public string ParentResourceName { get; set; }

        [Alias("ResourceName", "RoutingIntentName", "RouteTableName")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByRoutingIntentName,
            HelpMessage = "Name of the route table.")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByVirtualHubObject,
            HelpMessage = "Name of the route table.")]
        public string Name { get; set; }

        [Alias("VirtualHub", "ParentVirtualHub")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByVirtualHubObject,
            HelpMessage = "The parent virtual hub object.")]
        public PSVirtualHub ParentObject { get; set; }

        [Alias("RoutingIntent")]
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ParameterSetName = CortexParameterSetNames.ByRoutingIntentObject,
            HelpMessage = "The routing intent resource to modify.")]
        public PSRoutingIntent InputObject { get; set; }

        [Alias("RoutingIntentId")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = CortexParameterSetNames.ByRoutingIntentResourceId,
            HelpMessage = "The resource id of the routing intent to modify.")]
        [ResourceIdCompleter("Microsoft.Network/virtualHubs/routingIntent")]
        public string ResourceId { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The list of routing policies for this routing intent resource.")]
        public PSRoutingPolicy[] RoutingPolicy { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();
            PSRoutingIntent routingIntentToUpdate = null;
            if (ParameterSetName.Equals(CortexParameterSetNames.ByRoutingIntentObject, StringComparison.OrdinalIgnoreCase))
            {
                routingIntentToUpdate = this.InputObject;
                this.ResourceId = this.InputObject.Id;
                if (string.IsNullOrWhiteSpace(this.ResourceId))
                {
                    throw new PSArgumentException(Properties.Resources.RoutingIntentNotFound);
                }

                var parsedResourceId = new ResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = parsedResourceId.ResourceGroupName;
                this.ParentResourceName = parsedResourceId.ParentResource.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
                this.Name = parsedResourceId.ResourceName;
            }
            else
            {
                if (ParameterSetName.Equals(CortexParameterSetNames.ByRoutingIntentResourceId, StringComparison.OrdinalIgnoreCase))
                {
                    var parsedResourceId = new ResourceIdentifier(this.ResourceId);
                    this.ResourceGroupName = parsedResourceId.ResourceGroupName;
                    this.ParentResourceName = parsedResourceId.ParentResource.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
                    this.Name = parsedResourceId.ResourceName;
                }
                else if (ParameterSetName.Equals(CortexParameterSetNames.ByVirtualHubObject, StringComparison.OrdinalIgnoreCase))
                {
                    var parentResourceId = this.ParentObject.Id;
                    var parsedParentResourceId = new ResourceIdentifier(parentResourceId);
                    this.ResourceGroupName = parsedParentResourceId.ResourceGroupName;
                    this.ParentResourceName = parsedParentResourceId.ResourceName;
                }

                try
                {
                    routingIntentToUpdate = this.GetRoutingIntent(this.ResourceGroupName, this.ParentResourceName, this.Name);
                }
                catch (Exception ex)
                {
                    if (ex is Microsoft.Azure.Management.Network.Models.ErrorException || ex is Rest.Azure.CloudException)
                    {
                        throw new PSArgumentException(Properties.Resources.RoutingIntentNotFound);
                    }
                    throw;
                }
            }

            // this will throw if hub does not exist.
            IsParentVirtualHubPresent(this.ResourceGroupName, this.ParentResourceName);

            if (this.RoutingPolicy != null)
            {
                routingIntentToUpdate.RoutingPolicies = this.RoutingPolicy.ToList();
            }

            ConfirmAction(
                Properties.Resources.SettingResourceMessage,
                this.Name,
                () =>
                {
                    WriteVerbose(String.Format(Properties.Resources.CreatingLongRunningOperationMessage, this.ResourceGroupName, this.Name));
                    WriteObject(this.CreateOrUpdateRoutingIntent(this.ResourceGroupName, this.ParentResourceName, this.Name, routingIntentToUpdate));
                });
        }
    }
}
