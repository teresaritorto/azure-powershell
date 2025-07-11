
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for KeySetUser.
.Description
Create an in-memory object for KeySetUser.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUser
.Link
https://learn.microsoft.com/powershell/module/Az.NetworkCloud/new-AzNetworkCloudKeySetUserObject
#>
function New-AzNetworkCloudKeySetUserObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUser')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The user name that will be used for access.")]
        [string]
        $AzureUserName,
        [Parameter(HelpMessage="The free-form description for this user.")]
        [string]
        $Description,
        [Parameter(Mandatory, HelpMessage="The SSH public key data.")]
        [string]
        $SshPublicKeyData,
        [Parameter(HelpMessage="The user principal name (email format) used to validate this user's group membership.")]
        [string]
        $UserPrincipalName
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUser]::New()

        if ($PSBoundParameters.ContainsKey('AzureUserName')) {
            $Object.AzureUserName = $AzureUserName
        }
        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('SshPublicKeyData')) {
            $Object.SshPublicKeyData = $SshPublicKeyData
        }
        if ($PSBoundParameters.ContainsKey('UserPrincipalName')) {
            $Object.UserPrincipalName = $UserPrincipalName
        }
        return $Object
    }
}

