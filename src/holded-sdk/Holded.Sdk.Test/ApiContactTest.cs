using Holded.Sdk.Apis.InvoiceApis;
using Holded.Sdk.Apis.InvoiceApis.Contracts;
using Holded.Sdk.Core;
using Holded.Sdk.Entities.POST;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Assert = Xunit.Assert;

namespace Holded.Sdk.Test;

public class ApiContactTest
{
    private readonly ContactApi _contactApi;

    public ApiContactTest()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .Build();

        services.AddHoldedInvoiceServices(configuration);
        var provider = services.BuildServiceProvider();
        _contactApi = provider.GetRequiredService<IContactApi>() as ContactApi ??
                      throw new ArgumentException("Error on retrieve a service.");
    }

    [Fact]
    public async Task When_Create_Contact_Success()
    {
        ContactPostEntity entity = new ContactPostEntity();
        var response = await _contactApi.Create(entity);

        Assert.True(response != null);
    }

    [Fact]
    public async Task When_Retrieve_Contact_List_Success()
    {
        var response = await _contactApi.List();

        Assert.True(response.Any());
    }
}