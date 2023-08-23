using Holded.Sdk.Core;
using Microsoft.Extensions.Logging;

namespace Holded.Sdk.Apis.InvoiceApis;

/// <summary>
/// Base invoice apis
/// </summary>
public abstract class BaseInvoiceApi : BaseApi
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="settings"></param>
    /// <param name="logger"></param>
    protected BaseInvoiceApi(HoldedApiSettings settings, ILogger<BaseApi> logger) : base(settings, logger) =>
        BaseUrl = $"{settings.HoldedApiBaseUrl}/{settings.Invoice.Path}/{settings.Invoice.Version}";
}