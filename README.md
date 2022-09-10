# StatusPageIO.Api

This project aims to provide a wrapper around the public JSON file-based StatusPage.io 'API'.

## Usage

The status page client can be initialised in two main ways:

### Self-instantiation
```csharp
// Construct it yourself, but make sure to dispose of it with 'using'!
using var statusPageClient = new StatusPageIoClient();
```

## Microsoft.Extensions.DependencyInjection extensions
```csharp 
// ... your usual WebApplicationBuilder setup in Program.cs

// Basic setup with the StatusPageIoClientConfiguration class
builder.Services.AddStatusPageHttpClient(
    (serviceProvider, config) => {
        // The base URL of your status page. You could pull this from IConfiguration via the provided IServiceProvider parameter
        config.StatusPageBaseUri = new Uri("https://www.githubstatus.com");
    });

// OR if you need more control over the HttpClient, you can directly configure it
builder.Services.AddStatusPageHttpClient(
    (serviceProvider, httpClient) => {
        // The base URL of your status page. You could pull this from IConfiguration via the provided IServiceProvider parameter
        httpClient.BaseAddress = new Uri("https://www.githubstatus.com");
        httpClient.Timeout = TimeSpan.FromSeconds(10);
    });
    
// ... the rest of the owl
```

## License

This project is licensed under the MIT license. See [LICENSE.txt](./LICENSE.txt) for more information.
