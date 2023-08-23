using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Holded.Sdk.Core;
using Holded.Sdk.Entities.GET;
using Holded.Sdk.Entities.POST;
using Holded.Sdk.Entities.RESPONSE;
using Holded.Sdk.Exceptions;
using Microsoft.Extensions.Logging;

namespace Holded.Sdk.Apis;

/// <summary>
/// Base api abstract class.
/// </summary>
public abstract class BaseApi
{
    private const string HEADER_KEY = "key";
    private const string HEADER_ACCEPT = "accept";

    /// <summary>
    /// Base url.
    /// </summary>
    protected string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    /// Logger.
    /// </summary>
    protected readonly ILogger<BaseApi> _logger;

    protected readonly HoldedApiSettings _settings;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="settings"></param>
    /// <param name="logger"></param>
    protected BaseApi(HoldedApiSettings settings, ILogger<BaseApi> logger)
    {
        _settings = settings;
        _logger = logger;
    }

    /// <summary>
    /// Ensure http client headers.
    /// </summary>
    /// <param name="client"></param>
    private void EnsureHeaders(HttpClient client)
    {
        client.DefaultRequestHeaders.Add(HEADER_KEY, _settings.HoldedApiKey);
        client.DefaultRequestHeaders.Add(HEADER_ACCEPT, "application/json");
    }

    /// <summary>
    /// Handle an api error messages.
    /// </summary>
    /// <param name="response"></param>
    /// <exception cref="UnauthorizedAccessException"></exception>
    /// <exception cref="TimeoutException"></exception>
    /// <exception cref="ResponseException"></exception>
    private static async Task HandleApiErrorAsync(HttpResponseMessage response)
    {
        var responseCode = (int)response.StatusCode;
        var content = await response.Content.ReadAsStringAsync();

        if (responseCode == 401)
            throw new UnauthorizedAccessException(content);
        if (response.StatusCode == HttpStatusCode.RequestTimeout)
            throw new TimeoutException(content);

        throw new ResponseException(content, responseCode);
    }

    /// <summary>
    /// Allow to create an entity.
    /// </summary>
    /// <param name="targetUrl"></param>
    /// <param name="entity"></param>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected async Task<U> CreateEntity<U, T>(string targetUrl, T entity)
        where U : BaseResponse, new() where T : EntityPostBase
    {
        using (HttpClient client = new HttpClient())
        {
            EnsureHeaders(client);
            var response = await client.PostAsJsonAsync(new Uri(targetUrl), JsonSerializer.Serialize(entity));
            if (!response.IsSuccessStatusCode) await HandleApiErrorAsync(response);
            return await response.Content.ReadFromJsonAsync<U>() ??
                   throw new ResponseException("Unable to create an entity.", (int)response.StatusCode);
        }
    }

    /// <summary>
    /// Retrieve all entities.
    /// </summary>
    /// <param name="targetUrl"></param>
    /// <typeparam name="U"></typeparam>
    /// <returns></returns>
    protected async Task<IEnumerable<U>> GetEntities<U>(string targetUrl) where U : EntityGetBase
    {
        using (HttpClient client = new HttpClient())
        {
            EnsureHeaders(client);
            var response = await client.GetAsync(new Uri(targetUrl));
            if (!response.IsSuccessStatusCode) await HandleApiErrorAsync(response);
            return await response.Content.ReadFromJsonAsync<IEnumerable<U>>() ?? new List<U>();
        }
    }
}