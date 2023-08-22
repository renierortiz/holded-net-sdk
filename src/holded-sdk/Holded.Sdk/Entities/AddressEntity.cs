using System.Text.Json.Serialization;

namespace Holded.Sdk.Models.Entities;

/// <summary>
/// Address holded entity
/// </summary>
public class AddressEntity
{
    /// <summary>
    /// Address.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }
}