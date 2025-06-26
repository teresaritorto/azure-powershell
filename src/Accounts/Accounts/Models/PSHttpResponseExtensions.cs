using Microsoft.Azure.Commands.Common.Exceptions;
using Microsoft.Azure.Internal.Common;
using Microsoft.Rest.Azure;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Profile.Models
{
    public static class PSHttpResponseExtensions
    {
        const int MaxPageSize = int.MaxValue;
        const int MaxRetryAttempts = 3;
        const int DefaultRetryDelayMilliseconds = 3000;
        public const string DefaultNextLinkName = "nextLink";
        public const string DefaultPageableItemName = "value";

        /// <summary>
        /// Given an AzureOperationResponse with a paginated nextLink, fetch 
        /// all data async until maxLimit by following the nextLink. 
        /// Aggregate responses as value children to single PSHttpResponse.
        /// </summary>
        public static async Task<PSHttpResponse> FollowNextLinkAsync(
            this AzureOperationResponse<string> response,
            IAzureRestClient serviceClient,
            string apiVersion,            
            string pageableItemName = DefaultPageableItemName,
            string nextLinkName = DefaultNextLinkName,
            int maxPageSize = MaxPageSize)
        {
            try
            {
                var nextLink = GetNextLink(nextLinkName, response);

                //gracefully fallback to the first response as we cannot aggregate items
                if (nextLink == null)
                {
                    return new PSHttpResponse(response);                    
                }

                var items = await AggregatePagedResponsesAsync(
                    serviceClient,
                    response,
                    apiVersion,
                    pageableItemName,
                    nextLinkName,                    
                    maxPageSize
                ).ConfigureAwait(false);

                
                if (items == null || items.Count == 0)
                {
                    return new PSHttpResponse(response);
                }

                // return the aggregated response
                var content = new JObject
                {
                    [pageableItemName] = new JArray(items)
                };
                                
                return new PSHttpResponse(response)
                {
                    Content = content.ToString()
                };
            }
            catch (Exception e)
            {
                throw new AzPSException($"Failed to follow next link: {e.Message}", Commands.Common.ErrorKind.ServiceError);
            }
        }


        private static async Task<List<JToken>> AggregatePagedResponsesAsync(
            IAzureRestClient serviceClient,
            AzureOperationResponse<string> response,
            string apiVersion,
            string pageableItemName,
            string nextLinkName,
            int maxPageSize)
        {
            var items = new List<JToken>();
            var firstItem = ExtractItem(pageableItemName, response);
            if (firstItem == null)
            {
                return null;
            }

            items.AddRange(firstItem);
            var nextLink = GetNextLink(nextLinkName, response);
            var retry = 0;
            var pageSize = 1;

            while (!string.IsNullOrEmpty(nextLink) && pageSize < maxPageSize)
            {
                response = await serviceClient
                    .Operations
                    .BeginHttpGetMessagesAsyncWithFullResponse(nextLink, null)
                    .ConfigureAwait(false);

                if (response.Response.StatusCode == (HttpStatusCode)429 && retry <= MaxRetryAttempts)
                {
                    var delay = response.Response.Headers.Contains("Retry-After")
                        ? response.Response.Headers.RetryAfter.Delta?.TotalMilliseconds ?? DefaultRetryDelayMilliseconds
                        : DefaultRetryDelayMilliseconds;

                    await Task.Delay(TimeSpan.FromMilliseconds(delay)).ConfigureAwait(false);
                    //outputAction($"Retrying request after {delay} milliseconds due to 429 response. Attempt {retry}/{MaxRetryAttempts}");
                    retry++;
                    continue; // Retry the request after waiting
                }

                //halt processing if the response is not successful
                else if (!response.Response.IsSuccessStatusCode)
                {
                    throw new AzPSException($"Unsuccessful Status code: {response.Response.StatusCode}",
                        Commands.Common.ErrorKind.ServiceError);
                }

                var item = ExtractItem(pageableItemName, response);
                if (item == null)
                {
                    return null;
                }

                items.AddRange(item);
                nextLink = GetNextLink(nextLinkName, response);
                pageSize++;
            }

            return items;
        }

        private static string GetNextLink(string nextLinkName, AzureOperationResponse<string> response)
        {
            var json = JObject.Parse(response.Body);
            var nextLinkToken = json[nextLinkName];

            if (nextLinkToken == null || nextLinkToken.Type == JTokenType.Null)
                return null;

            var nextLinkValue = nextLinkToken.ToString();

            // Only accept valid absolute URIs
            if (!Uri.TryCreate(nextLinkValue, UriKind.Absolute, out var nextLinkPathQuery))
                return null;

            return nextLinkPathQuery.PathAndQuery;
        }

        private static IEnumerable<JToken> ExtractItem(string pageableItemName, AzureOperationResponse<string> response)
        {
            var json = JObject.Parse(response.Body);
            var itemsToken = json[pageableItemName];
            if (itemsToken != null)
            {
                if (itemsToken.Type == JTokenType.Array)
                {
                    return itemsToken.Children();
                }
                else if (itemsToken.Type == JTokenType.Object)
                {
                    return new List<JToken>() { itemsToken };
                }
            }
            return null;
        }
    }
}