[![](https://img.shields.io/nuget/v/soenneker.workos.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.workos.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.workos.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.workos.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.workos.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.workos.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.workos.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.workos.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.WorkOs.OpenApiClient

A Kiota client for WorkOS organizations, users, directory sync, SSO, audit logs, webhooks, and User Management.

## Installation

```bash
dotnet add package Soenneker.WorkOs.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.WorkOs.OpenApiClient;
using Soenneker.WorkOs.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", "sk_example_123456789");

var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient)
{
    BaseUrl = "https://api.workos.com"
};

var client = new WorkOsOpenApiClient(adapter);

OrganizationList? result = await client.Organizations.GetAsync(request =>
{
    request.QueryParameters.Limit = 10;
});

foreach (Organization organization in result?.Data ?? [])
{
    Console.WriteLine($"{organization.Id}: {organization.Name}");
}
```

Use a secret API key from the WorkOS environment whose organizations and users you intend to manage. Keep browser-facing AuthKit flows and API keys separated; API keys must remain on a trusted server.
