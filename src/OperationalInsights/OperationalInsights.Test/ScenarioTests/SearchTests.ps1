# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Get and update search results
#>
function Test-SearchGetSearchResultsAndUpdate
{
    $rgname = "mms-eus"
    $wsname = "188087e4-5850-4d8b-9d08-3e5b448eaecd"

	$top = 5

	$searchResult = Get-AzOperationalInsightsSearchResults -ResourceGroupName $rgname -WorkspaceName $wsname -Top $top -Query "*"

	Assert-NotNull $searchResult
	Assert-NotNull $searchResult.Metadata
	Assert-NotNull $searchResult.Value
	Assert-AreEqual $searchResult.Value.Count $top

	# Make sure we return each doc as string for backward compatible.
	$stringType = "string".GetType()
	$valueType = $searchResult.Value.GetType()
	$valueIsString = $valueType.GenericTypeArguments.Contains($stringType)
	Assert-AreEqual $true $valueIsString

	$idArray = $searchResult.Id.Split("/")
	$id = $idArray[$idArray.Length-1]
	$updatedResult = Get-AzOperationalInsightsSearchResults -ResourceGroupName $rgname -WorkspaceName $wsname -Id $id
	
	Assert-NotNull $updatedResult
	Assert-NotNull $updatedResult.Metadata
	Assert-NotNull $searchResult.Value
}

<#
.SYNOPSIS
Get schemas for a given workspace
#>
function Test-SearchGetSchema
{
    $wsname = Get-ResourceName
    $dsName = Get-ResourceName
    $rgname = Get-ResourceGroupName
    $wslocation = Get-ProviderLocation

    New-AzResourceGroup -Name $rgname -Location $wslocation -Force

    # Create a workspace to house the data sources
    $workspace = New-AzOperationalInsightsWorkspace -ResourceGroupName $rgname -Name $wsname -Location $wslocation -Sku "pergb2018" -Force
	$schema = Get-AzOperationalInsightsSchema -ResourceGroupName $rgname -WorkspaceName $wsname
	Assert-NotNull $schema
	Assert-NotNull $schema.Metadata
	#Metadata was removed in SDK
	#Assert-AreEqual $schema.Metadata.ResultType "schema"
	Assert-NotNull $schema.Value
}

<#
.SYNOPSIS
Get saved searches and search results from a saved search
#>
function Test-SearchGetSavedSearchesAndResults
{
    $wsname = Get-ResourceName
    $rgname = Get-ResourceGroupName
    $wslocation = Get-ProviderLocation

    New-AzResourceGroup -Name $rgname -Location $wslocation -Force

    try
	{
		# Create a workspace to house the data sources
		$workspace = New-AzOperationalInsightsWorkspace -ResourceGroupName $rgname -Name $wsname -Location $wslocation -Sku "pergb2018" -Force

		$savedSearches = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname
	
		Assert-NotNull $savedSearches
		Assert-NotNull $savedSearches.Value
	
		$idArray = $savedSearches.Value[0].Id.Split("/")
		$id = $idArray[$idArray.Length-1]

		$savedSearch = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname -SavedSearchId $id

		Assert-NotNull $savedSearch
		
		Assert-NotNull $savedSearch.Id
		Assert-NotNull $savedSearch.Properties
		#skip following two checks due to service break
		#Assert-NotNull $savedSearch.ETag
		#Assert-NotNull $savedSearch.Properties.Query

		Remove-AzOperationalInsightsWorkspace -ResourceGroupName $rgname -Name $wsname -Force
	}
	finally
	{
		Remove-AzResourceGroup -Name $rgname -Force
	}
}

<#
.SYNOPSIS
Create a new saved search, update, and then remove it
#>
function Test-SearchSetAndRemoveSavedSearches
{
    $wsname = Get-ResourceName
    $dsName = Get-ResourceName
    $rgname = Get-ResourceGroupName
    $wslocation = Get-ProviderLocation

    New-AzResourceGroup -Name $rgname -Location $wslocation -Force

    # Create a workspace to house the data sources
    $workspace = New-AzOperationalInsightsWorkspace -ResourceGroupName $rgname -Name $wsname -Location $wslocation -Sku premium -Force

	$id = "test-new-saved-search-id-2015"
	$displayName = "TestingSavedSearch"
	$category = "Saved Search Test Category"
	$version = 1
	$query = "* | measure Count() by Computer"

	# Get the count of saved searches
	$savedSearches = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname
	$count = $savedSearches.Value.Count
	$newCount = $count + 1
	$tags = @{"Group" = "Computer"}

	New-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname -SavedSearchId $id -DisplayName $displayName -Category $category -Query $query -Tag $tags -Version $version -Force
	
	# Check that the search was saved
	$savedSearches = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname
	Assert-AreEqual $savedSearches.Value.Count $newCount

	$etag = ""
	ForEach ($s in $savedSearches.Value)
	{
		If ($s.Properties.DisplayName.Equals($displayName)) {
			$etag = $s.ETag
		}
	}

	#Set saved search cmdlet has issue with Etag. Temporarily comment out the call until it's fixed.
	# Test updating the search
	$query = "* | distinct Computer"
	Set-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname -SavedSearchId $id -DisplayName $displayName -Category $category -Query $query -Tag $tags -Version $version -ETag $etag
	
	# Check that the search was updated
	$savedSearches = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname
	Assert-AreEqual $savedSearches.Value.Count $newCount

	$found = 0
	$hasTag = 0
	ForEach ($s in $savedSearches.Value)
	{
		If ($s.Properties.DisplayName.Equals($displayName) -And $s.Properties.Query.Equals($query)) {
			$found = 1
			If ($s.Properties.Tags["Group"] -eq "Computer") {
				$hasTag = 1
			}
		}
	}
	Assert-AreEqual $found 1
	Assert-AreEqual $hasTag 1


	Remove-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname -SavedSearchId $id
	
	# Check that the search was deleted
	$savedSearches = Get-AzOperationalInsightsSavedSearch -ResourceGroupName $rgname -WorkspaceName $wsname
	Assert-AreEqual $savedSearches.Value.Count $count
}