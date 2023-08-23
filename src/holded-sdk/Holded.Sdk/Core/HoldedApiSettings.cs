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
    public Api Invoice { get; set; } = null!;

    public Api Crm { get; set; } = null!;
    public Api Projects { get; set; } = null!;
}

// ReSharper disable once ClassNeverInstantiated.Global
public class Api
{
    public string Path { get; set; } = null!;
    public string Version { get; set; } = null!;
}