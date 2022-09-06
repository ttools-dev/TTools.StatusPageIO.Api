using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;

namespace TTools.StatusPageIO.Api.Extensions;

/// <summary>
/// Extensions for registering the IStatusPageIoClient with a ServiceProvider
/// </summary>
public static class StatusPageServiceCollectionExtensions
{
    /// <summary>
    /// Adds a scoped service to interact with a site's public StatusPage.IO API
    /// </summary>
    /// <param name="serviceCollection">The service collection to register the client against</param>
    /// <param name="configureAction">The action to configure the status page HttpClient</param>
    /// <returns>The HttpClient's builder</returns>
    public static IHttpClientBuilder AddStatusPageHttpClient(this IServiceCollection serviceCollection,
        Action<IServiceProvider, StatusPageIoClientConfiguration>? configureAction)
    {
        return serviceCollection.AddHttpClient<IStatusPageIoClient, StatusPageIoClient>(
            (serviceProvider, httpClient) =>
            {
                var configuration = new StatusPageIoClientConfiguration();
                if (configureAction is not null)
                    configureAction(serviceProvider, configuration);

                SetupHttpClient(httpClient);
                httpClient.BaseAddress = configuration.StatusPageBaseUri;
            });
    }

    /// <summary>
    /// Adds a scoped service to interact with a site's public StatusPage.IO API
    /// </summary>
    /// <param name="serviceCollection">The service collection to register the client against</param>
    /// <param name="configureAction">The action to configure the status page HttpClient</param>
    /// <returns>The HttpClient's builder</returns>
    public static IHttpClientBuilder AddStatusPageHttpClient(this IServiceCollection serviceCollection,
        Action<IServiceProvider, HttpClient> configureAction)
    {
        return serviceCollection.AddHttpClient<IStatusPageIoClient, StatusPageIoClient>(
            (serviceProvider, httpClient) =>
            {
                SetupHttpClient(httpClient);
                configureAction(serviceProvider, httpClient);
            });
    }

    // TODO: support service-scoped IStatusPageIoClient registrations (ugly?)

    private static void SetupHttpClient(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}
