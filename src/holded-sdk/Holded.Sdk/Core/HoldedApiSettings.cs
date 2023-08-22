namespace Holded.Sdk.Models.Core;

/// <summary>
/// Holded Api Settings
/// </summary>
public class HoldedApiSettings
{
    /// <summary>
    /// Holded Auth api key
    /// </summary>
    public string HoldedApiKey { get; set; } = null!;

    /// <summary>
    /// Holded api base url
    /// </summary>
    public string HoldedApiBaseUrl { get; set; } = null!;
}