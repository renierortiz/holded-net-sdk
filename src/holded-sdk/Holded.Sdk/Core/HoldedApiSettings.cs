namespace Holded.Sdk.Core;

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

    /// <summary>
    /// Invoice api settings
    /// </summary>
    public Api Invoice { get; set; }
}

public class Api
{
    public string Path { get; set; }
    public string Version { get; set; }
}