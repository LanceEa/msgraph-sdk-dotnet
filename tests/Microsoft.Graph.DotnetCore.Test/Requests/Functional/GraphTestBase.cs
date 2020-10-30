// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    public class GraphTestBase
    {
        private readonly string clientId;
        private readonly string secret;
        private readonly string contentType = "application/x-www-form-urlencoded";
        private readonly string grantType = "client_credentials";
        private readonly string tenantId;
        private readonly string tokenEndpoint;
        private readonly string resourceId = "https%3A%2F%2Fgraph.microsoft.com%2F";
        private readonly string scope = "https://graph.microsoft.com/.default";

        private static string accessToken = null;
        private static string tokenForUser = null;
        private static System.DateTimeOffset expiration;

        protected static GraphServiceClient graphClient = null;

        public GraphTestBase()
        {
            // Setup for dev test
            clientId = System.Environment.GetEnvironmentVariable("test_client_id");
            secret = System.Environment.GetEnvironmentVariable("test_secret");
            tenantId = System.Environment.GetEnvironmentVariable("test_tenantId");
            tokenEndpoint = String.Format("https://login.microsoftonline.com/{0}/oauth2/token", tenantId);

            GetAuthenticatedClient();
        }

        // Get an access token and provide a GraphServiceClient.
        private void GetAuthenticatedClient()
        {
            if (graphClient == null)
            {
                // Create Microsoft Graph client.
                try
                {
                    graphClient = new GraphServiceClient(
                        "https://graph.microsoft.com/v1.0",
                        new DelegateAuthenticationProvider(
                            async (requestMessage) =>
                            {
                                var token = await GetAccessTokenUsingPasswordGrant();
                                requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);

                            }));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Could not create a graph client: " + ex.Message);
                }
            }
        }

        public async Task<string> GetAccessTokenUsingPasswordGrant()
        {
            JObject jResult = null;
            String urlParameters = String.Format(
                    "grant_type={0}&resource={1}&client_id={2}&scope={3}&client_secret={4}",
                    grantType,
                    resourceId,
                    clientId,
                    scope,
                    secret
            );

            HttpClient client = new HttpClient();
            var createBody = new StringContent(urlParameters, System.Text.Encoding.UTF8, contentType);

            HttpResponseMessage response = await client.PostAsync(tokenEndpoint, createBody);

            if (response.IsSuccessStatusCode)
            {
                Task<string> responseTask = response.Content.ReadAsStringAsync();
                responseTask.Wait();
                string responseContent = responseTask.Result;
                jResult = JObject.Parse(responseContent);
                accessToken = (string)jResult["access_token"];
            }

            if (!String.IsNullOrEmpty(accessToken))
            {
                //Set AuthenticationHelper values so that the regular MSAL auth flow won't be triggered.
                tokenForUser = accessToken;
                expiration = DateTimeOffset.UtcNow.AddHours(5);
            }

            return accessToken;
        }
    }
}
