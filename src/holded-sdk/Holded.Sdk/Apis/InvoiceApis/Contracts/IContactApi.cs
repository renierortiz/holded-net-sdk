using Holded.Sdk.Entities.GET;
using Holded.Sdk.Entities.POST;
using Holded.Sdk.Entities.RESPONSE;

namespace Holded.Sdk.Apis.InvoiceApis.Contracts;

/// <summary>
/// Contact api interface
/// </summary>
public interface IContactApi
{
    /// <summary>
    /// Allow to create a contact.
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    Task<ContactCreatedResponse> Create(ContactPostEntity data);

    /// <summary>
    /// Retrieve a list of contacts.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<ContactGetEntity>> List();
}