using Holded.Sdk.Apis.InvoiceApis;
using Holded.Sdk.Apis.InvoiceApis.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Holded.Sdk.Core;

/// <summary>
/// Service collection extensions class.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register all services.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddHoldedInvoiceServices(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        serviceCollection.AddLogging(config =>
        {
            config.AddDebug();
            config.AddConsole();
        });

        serviceCollection.AddScoped<IContactApi, ContactApi>();

        var settings = new HoldedApiSettings();
        configuration.Bind(nameof(HoldedApiSettings), settings);
        serviceCollection.AddSingleton(settings);

        return serviceCollection;
    }
}