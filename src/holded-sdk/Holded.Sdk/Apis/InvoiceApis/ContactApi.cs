using Holded.Sdk.Apis.InvoiceApis.Contracts;
using Holded.Sdk.Core;
using Holded.Sdk.Entities.GET;
using Holded.Sdk.Entities.POST;
using Holded.Sdk.Entities.RESPONSE;
using Microsoft.Extensions.Logging;

namespace Holded.Sdk.Apis.InvoiceApis;

public class ContactApi : BaseInvoiceApi, IContactApi
{
    public ContactApi(HoldedApiSettings settings, ILogger<ContactApi> logger) : base(settings, logger)
    {
        BaseUrl = $"{BaseUrl}/contacts";
    }

    public async Task<ContactCreatedResponse> Create(ContactPostEntity data) =>
        await CreateEntity<ContactCreatedResponse, ContactPostEntity>(BaseUrl, data);

    public async Task<IEnumerable<ContactGetEntity>> List() => await GetEntities<ContactGetEntity>(BaseUrl);
}